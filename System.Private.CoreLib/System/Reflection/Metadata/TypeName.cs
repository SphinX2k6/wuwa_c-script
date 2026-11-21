using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Reflection.Metadata
{
	// Token: 0x02000795 RID: 1941
	[DebuggerDisplay("{AssemblyQualifiedName}")]
	internal sealed class TypeName
	{
		// Token: 0x06007BA6 RID: 31654 RVA: 0x001236C2 File Offset: 0x001218C2
		internal TypeName(string fullName, AssemblyNameInfo assemblyName, TypeName elementOrGenericType = null, TypeName declaringType = null, List<TypeName> genericTypeArguments = null, int rankOrModifier = 0, int nestedNameLength = -1)
		{
			this._fullName = fullName;
			this.AssemblyName = assemblyName;
			this._rankOrModifier = rankOrModifier;
			this._elementOrGenericType = elementOrGenericType;
			this._declaringType = declaringType;
			this._nestedNameLength = nestedNameLength;
			this._genericArguments = genericTypeArguments;
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x06007BA7 RID: 31655 RVA: 0x00123700 File Offset: 0x00121900
		public string AssemblyQualifiedName
		{
			get
			{
				string result;
				if ((result = this._assemblyQualifiedName) == null)
				{
					result = (this._assemblyQualifiedName = ((this.AssemblyName == null) ? this.FullName : (this.FullName + ", " + this.AssemblyName.FullName)));
				}
				return result;
			}
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x06007BA8 RID: 31656 RVA: 0x0012374B File Offset: 0x0012194B
		public AssemblyNameInfo AssemblyName { get; }

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x06007BA9 RID: 31657 RVA: 0x00123753 File Offset: 0x00121953
		public TypeName DeclaringType
		{
			get
			{
				if (this._declaringType == null)
				{
					TypeNameParserHelpers.ThrowInvalidOperation_NotNestedType();
				}
				return this._declaringType;
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06007BAA RID: 31658 RVA: 0x00123768 File Offset: 0x00121968
		public unsafe string FullName
		{
			get
			{
				if (this._fullName == null)
				{
					if (this.IsConstructedGenericType)
					{
						this._fullName = TypeNameParserHelpers.GetGenericTypeFullName(this.GetGenericTypeDefinition().FullName.AsSpan(), CollectionsMarshal.AsSpan<TypeName>(this._genericArguments));
					}
					else if (this.IsArray || this.IsPointer || this.IsByRef)
					{
						Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
						ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
						valueStringBuilder.Append(this.GetElementType().FullName);
						this._fullName = TypeNameParserHelpers.GetRankOrModifierStringRepresentation(this._rankOrModifier, ref valueStringBuilder);
					}
				}
				else if (this._nestedNameLength > 0 && this._fullName.Length > this._nestedNameLength)
				{
					this._fullName = this._fullName.Substring(0, this._nestedNameLength);
				}
				return this._fullName;
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06007BAB RID: 31659 RVA: 0x0012384C File Offset: 0x00121A4C
		public bool IsArray
		{
			get
			{
				return this._rankOrModifier == -1 || this._rankOrModifier > 0;
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x06007BAC RID: 31660 RVA: 0x00123862 File Offset: 0x00121A62
		public bool IsConstructedGenericType
		{
			get
			{
				return this._genericArguments != null;
			}
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x06007BAD RID: 31661 RVA: 0x00123870 File Offset: 0x00121A70
		public bool IsSimple
		{
			get
			{
				return this._elementOrGenericType == null;
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x06007BAE RID: 31662 RVA: 0x0012387B File Offset: 0x00121A7B
		public bool IsByRef
		{
			get
			{
				return this._rankOrModifier == -3;
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06007BAF RID: 31663 RVA: 0x00123887 File Offset: 0x00121A87
		public bool IsNested
		{
			get
			{
				return this._declaringType != null;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06007BB0 RID: 31664 RVA: 0x00123895 File Offset: 0x00121A95
		public bool IsSZArray
		{
			get
			{
				return this._rankOrModifier == -1;
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06007BB1 RID: 31665 RVA: 0x001238A0 File Offset: 0x00121AA0
		public bool IsPointer
		{
			get
			{
				return this._rankOrModifier == -2;
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06007BB2 RID: 31666 RVA: 0x001238AC File Offset: 0x00121AAC
		public unsafe string Name
		{
			get
			{
				if (this._name == null)
				{
					if (this.IsConstructedGenericType)
					{
						this._name = TypeNameParserHelpers.GetName(this.GetGenericTypeDefinition().FullName.AsSpan()).ToString();
					}
					else if (this.IsPointer || this.IsByRef || this.IsArray)
					{
						Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)128], 64);
						ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
						valueStringBuilder.Append(this.GetElementType().Name);
						this._name = TypeNameParserHelpers.GetRankOrModifierStringRepresentation(this._rankOrModifier, ref valueStringBuilder);
					}
					else if (this._nestedNameLength > 0 && this._fullName != null)
					{
						this._name = TypeNameParserHelpers.GetName(this._fullName.AsSpan(0, this._nestedNameLength)).ToString();
					}
					else
					{
						this._name = TypeNameParserHelpers.GetName(this.FullName.AsSpan()).ToString();
					}
				}
				return this._name;
			}
		}

		// Token: 0x06007BB3 RID: 31667 RVA: 0x001239B9 File Offset: 0x00121BB9
		public TypeName GetElementType()
		{
			if (!this.IsArray && !this.IsPointer && !this.IsByRef)
			{
				TypeNameParserHelpers.ThrowInvalidOperation_NoElement();
			}
			return this._elementOrGenericType;
		}

		// Token: 0x06007BB4 RID: 31668 RVA: 0x001239DE File Offset: 0x00121BDE
		public TypeName GetGenericTypeDefinition()
		{
			if (!this.IsConstructedGenericType)
			{
				TypeNameParserHelpers.ThrowInvalidOperation_NotGenericType();
			}
			return this._elementOrGenericType;
		}

		// Token: 0x06007BB5 RID: 31669 RVA: 0x001239F3 File Offset: 0x00121BF3
		public int GetArrayRank()
		{
			if (this._rankOrModifier != -1 && this._rankOrModifier <= 0)
			{
				TypeNameParserHelpers.ThrowInvalidOperation_HasToBeArrayClass();
			}
			if (this._rankOrModifier != -1)
			{
				return this._rankOrModifier;
			}
			return 1;
		}

		// Token: 0x06007BB6 RID: 31670 RVA: 0x00123A1D File Offset: 0x00121C1D
		public ReadOnlySpan<TypeName> GetGenericArguments()
		{
			return CollectionsMarshal.AsSpan<TypeName>(this._genericArguments);
		}

		// Token: 0x04001775 RID: 6005
		private readonly int _rankOrModifier;

		// Token: 0x04001776 RID: 6006
		private readonly int _nestedNameLength;

		// Token: 0x04001777 RID: 6007
		private readonly TypeName _elementOrGenericType;

		// Token: 0x04001778 RID: 6008
		private readonly TypeName _declaringType;

		// Token: 0x04001779 RID: 6009
		private readonly List<TypeName> _genericArguments;

		// Token: 0x0400177A RID: 6010
		private string _name;

		// Token: 0x0400177B RID: 6011
		private string _fullName;

		// Token: 0x0400177C RID: 6012
		private string _assemblyQualifiedName;
	}
}
