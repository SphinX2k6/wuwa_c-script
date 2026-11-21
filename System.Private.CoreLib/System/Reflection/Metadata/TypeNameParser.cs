using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.Reflection.Metadata
{
	// Token: 0x02000797 RID: 1943
	[CompilerFeatureRequired("RefStructs")]
	[DebuggerDisplay("{_inputString}")]
	internal ref struct TypeNameParser
	{
		// Token: 0x06007BB9 RID: 31673 RVA: 0x00123AEC File Offset: 0x00121CEC
		private TypeNameParser(ReadOnlySpan<char> name, bool throwOnError, TypeNameParseOptions? options)
		{
			this = default(TypeNameParser);
			this._inputString = name;
			this._throwOnError = throwOnError;
			this._parseOptions = (options ?? TypeNameParser.s_defaults);
		}

		// Token: 0x06007BBA RID: 31674 RVA: 0x00123B30 File Offset: 0x00121D30
		internal static TypeName Parse(ReadOnlySpan<char> typeName, bool throwOnError, TypeNameParseOptions? options = null)
		{
			ReadOnlySpan<char> name = typeName.TrimStart();
			if (name.IsEmpty)
			{
				if (throwOnError)
				{
					TypeNameParserHelpers.ThrowArgumentException_InvalidTypeName(0);
				}
				return null;
			}
			int depth = 0;
			TypeNameParser typeNameParser = new TypeNameParser(name, throwOnError, options);
			TypeName typeName2 = typeNameParser.ParseNextTypeName(true, ref depth);
			if (typeName2 == null || !typeNameParser._inputString.IsEmpty)
			{
				if (throwOnError)
				{
					if (TypeNameParserHelpers.IsMaxDepthExceeded(typeNameParser._parseOptions, depth))
					{
					}
					TypeNameParserHelpers.ThrowArgumentException_InvalidTypeName(typeName.Length - typeNameParser._inputString.Length);
				}
				return null;
			}
			return typeName2;
		}

		// Token: 0x06007BBB RID: 31675 RVA: 0x00123BB0 File Offset: 0x00121DB0
		private TypeName ParseNextTypeName(bool allowFullyQualifiedName, ref int recursiveDepth)
		{
			if (!TypeNameParserHelpers.TryDive(this._parseOptions, ref recursiveDepth))
			{
				return null;
			}
			List<int> nestedNameLengths = null;
			int num;
			if (!TypeNameParserHelpers.TryGetTypeNameInfo(this._parseOptions, ref this._inputString, ref nestedNameLengths, ref recursiveDepth, out num))
			{
				return null;
			}
			ReadOnlySpan<char> readOnlySpan = this._inputString.Slice(0, num);
			this._inputString = this._inputString.Slice(num);
			List<TypeName> list = null;
			ReadOnlySpan<char> inputString = this._inputString;
			bool flag;
			if (TypeNameParserHelpers.IsBeginningOfGenericArgs(ref this._inputString, out flag))
			{
				for (;;)
				{
					TypeName typeName = this.ParseNextTypeName(flag, ref recursiveDepth);
					if (typeName == null)
					{
						break;
					}
					if (flag && !TypeNameParserHelpers.TryStripFirstCharAndTrailingSpaces(ref this._inputString, ']'))
					{
						goto Block_5;
					}
					if (list == null)
					{
						list = new List<TypeName>(2);
					}
					list.Add(typeName);
					if (!TypeNameParserHelpers.TryStripFirstCharAndTrailingSpaces(ref this._inputString, ','))
					{
						goto IL_BD;
					}
					flag = TypeNameParserHelpers.TryStripFirstCharAndTrailingSpaces(ref this._inputString, '[');
				}
				return null;
				Block_5:
				return null;
				IL_BD:
				if (!TypeNameParserHelpers.TryStripFirstCharAndTrailingSpaces(ref this._inputString, ']'))
				{
					return null;
				}
			}
			if (list == null)
			{
				this._inputString = inputString;
			}
			else if (!TypeNameParserHelpers.TryDive(this._parseOptions, ref recursiveDepth))
			{
				return null;
			}
			int num2 = 0;
			inputString = this._inputString;
			int num3;
			while (TypeNameParserHelpers.TryParseNextDecorator(ref this._inputString, out num3))
			{
				if (!TypeNameParserHelpers.TryDive(this._parseOptions, ref recursiveDepth))
				{
					return null;
				}
				num2 = num3;
			}
			AssemblyNameInfo assemblyName = null;
			if (allowFullyQualifiedName && !this.TryParseAssemblyName(ref assemblyName) && (this._throwOnError || !this._inputString.TrimStart().StartsWith(",")))
			{
				throw new FileLoadException(SR.InvalidAssemblyName, this._inputString.ToString());
			}
			string text = readOnlySpan.ToString();
			TypeName declaringType = TypeNameParser.GetDeclaringType(text, nestedNameLengths, assemblyName);
			TypeName typeName2 = new TypeName(text, assemblyName, null, declaringType, null, 0, -1);
			if (list != null)
			{
				typeName2 = new TypeName(null, assemblyName, typeName2, declaringType, list, 0, -1);
			}
			if (num2 != 0)
			{
				int rankOrModifier;
				while (TypeNameParserHelpers.TryParseNextDecorator(ref inputString, out rankOrModifier))
				{
					typeName2 = new TypeName(null, assemblyName, typeName2, null, null, rankOrModifier, -1);
				}
			}
			return typeName2;
		}

		// Token: 0x06007BBC RID: 31676 RVA: 0x00123D88 File Offset: 0x00121F88
		private bool TryParseAssemblyName(ref AssemblyNameInfo assemblyName)
		{
			ReadOnlySpan<char> inputString = this._inputString;
			if (!TypeNameParserHelpers.TryStripFirstCharAndTrailingSpaces(ref this._inputString, ','))
			{
				return true;
			}
			if (this._inputString.IsEmpty)
			{
				this._inputString = inputString;
				return false;
			}
			ReadOnlySpan<char> assemblyNameCandidate = TypeNameParserHelpers.GetAssemblyNameCandidate(this._inputString);
			if (!AssemblyNameInfo.TryParse(assemblyNameCandidate, out assemblyName))
			{
				return false;
			}
			this._inputString = this._inputString.Slice(assemblyNameCandidate.Length);
			return true;
		}

		// Token: 0x06007BBD RID: 31677 RVA: 0x00123DF4 File Offset: 0x00121FF4
		private static TypeName GetDeclaringType(string fullTypeName, List<int> nestedNameLengths, AssemblyNameInfo assemblyName)
		{
			if (nestedNameLengths == null)
			{
				return null;
			}
			TypeName typeName = null;
			int num = 0;
			foreach (int num2 in nestedNameLengths)
			{
				int nestedNameLength = num + num2;
				typeName = new TypeName(fullTypeName, assemblyName, null, typeName, null, 0, nestedNameLength);
				num += num2 + 1;
			}
			return typeName;
		}

		// Token: 0x0400177E RID: 6014
		private static readonly TypeNameParseOptions s_defaults = new TypeNameParseOptions();

		// Token: 0x0400177F RID: 6015
		private readonly bool _throwOnError;

		// Token: 0x04001780 RID: 6016
		private readonly TypeNameParseOptions _parseOptions;

		// Token: 0x04001781 RID: 6017
		private ReadOnlySpan<char> _inputString;
	}
}
