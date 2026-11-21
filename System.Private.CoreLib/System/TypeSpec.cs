using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
	// Token: 0x020000AB RID: 171
	internal sealed class TypeSpec
	{
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x0001C125 File Offset: 0x0001A325
		internal bool HasModifiers
		{
			get
			{
				return this.modifier_spec != null;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0001C130 File Offset: 0x0001A330
		internal bool IsNested
		{
			get
			{
				return this.nested != null && this.nested.Count > 0;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x0001C14A File Offset: 0x0001A34A
		internal bool IsByRef
		{
			get
			{
				return this.is_byref;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0001C152 File Offset: 0x0001A352
		internal ITypeName Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x0001C15A File Offset: 0x0001A35A
		internal IEnumerable<ITypeName> Nested
		{
			get
			{
				if (this.nested != null)
				{
					return this.nested;
				}
				return Array.Empty<ITypeName>();
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x0001C170 File Offset: 0x0001A370
		internal IEnumerable<IModifierSpec> Modifiers
		{
			get
			{
				if (this.modifier_spec != null)
				{
					return this.modifier_spec;
				}
				return Array.Empty<IModifierSpec>();
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0001C188 File Offset: 0x0001A388
		private string GetDisplayFullName(TypeSpec.DisplayNameFormat flags)
		{
			bool flag = (flags & TypeSpec.DisplayNameFormat.WANT_ASSEMBLY) > TypeSpec.DisplayNameFormat.Default;
			bool flag2 = (flags & TypeSpec.DisplayNameFormat.NO_MODIFIERS) == TypeSpec.DisplayNameFormat.Default;
			StringBuilder stringBuilder = new StringBuilder(this.name.DisplayName);
			if (this.nested != null)
			{
				foreach (ITypeIdentifier typeIdentifier in this.nested)
				{
					stringBuilder.Append('+').Append(typeIdentifier.DisplayName);
				}
			}
			if (this.generic_params != null)
			{
				stringBuilder.Append('[');
				for (int i = 0; i < this.generic_params.Count; i++)
				{
					if (i > 0)
					{
						stringBuilder.Append(", ");
					}
					if (this.generic_params[i].assembly_name != null)
					{
						stringBuilder.Append('[').Append(this.generic_params[i].DisplayFullName).Append(']');
					}
					else
					{
						stringBuilder.Append(this.generic_params[i].DisplayFullName);
					}
				}
				stringBuilder.Append(']');
			}
			if (flag2)
			{
				this.GetModifierString(stringBuilder);
			}
			if (this.assembly_name != null && flag)
			{
				stringBuilder.Append(", ").Append(this.assembly_name);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0001C2E4 File Offset: 0x0001A4E4
		private StringBuilder GetModifierString(StringBuilder sb)
		{
			if (this.modifier_spec != null)
			{
				foreach (IModifierSpec modifierSpec in this.modifier_spec)
				{
					modifierSpec.Append(sb);
				}
			}
			if (this.is_byref)
			{
				sb.Append('&');
			}
			return sb;
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0001C350 File Offset: 0x0001A550
		internal string DisplayFullName
		{
			get
			{
				string result;
				if ((result = this.display_fullname) == null)
				{
					result = (this.display_fullname = this.GetDisplayFullName(TypeSpec.DisplayNameFormat.Default));
				}
				return result;
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0001C378 File Offset: 0x0001A578
		internal static TypeSpec Parse(string typeName)
		{
			int num = 0;
			ArgumentNullException.ThrowIfNull(typeName, "typeName");
			TypeSpec result = TypeSpec.Parse(typeName, ref num, false, true);
			if (num < typeName.Length)
			{
				throw new ArgumentException(SR.Argument_TypeParseError, "typeName");
			}
			return result;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0001C3B8 File Offset: 0x0001A5B8
		internal static string EscapeDisplayName(string internalName)
		{
			StringBuilder stringBuilder = new StringBuilder(internalName.Length);
			int i = 0;
			while (i < internalName.Length)
			{
				char value = internalName[i];
				switch (value)
				{
				case '&':
				case '*':
				case '+':
				case ',':
					goto IL_56;
				case '\'':
				case '(':
				case ')':
					goto IL_67;
				default:
					switch (value)
					{
					case '[':
					case '\\':
					case ']':
						goto IL_56;
					default:
						goto IL_67;
					}
					break;
				}
				IL_6F:
				i++;
				continue;
				IL_56:
				stringBuilder.Append('\\').Append(value);
				goto IL_6F;
				IL_67:
				stringBuilder.Append(value);
				goto IL_6F;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0001C448 File Offset: 0x0001A648
		internal static string UnescapeInternalName(string displayName)
		{
			StringBuilder stringBuilder = new StringBuilder(displayName.Length);
			for (int i = 0; i < displayName.Length; i++)
			{
				char c = displayName[i];
				if (c == '\\' && ++i < displayName.Length)
				{
					c = displayName[i];
				}
				stringBuilder.Append(c);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0001C4A2 File Offset: 0x0001A6A2
		private void AddName(string type_name)
		{
			if (this.name == null)
			{
				this.name = TypeSpec.ParsedTypeIdentifier(type_name);
				return;
			}
			if (this.nested == null)
			{
				this.nested = new List<ITypeIdentifier>();
			}
			this.nested.Add(TypeSpec.ParsedTypeIdentifier(type_name));
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0001C4DD File Offset: 0x0001A6DD
		private void AddModifier(IModifierSpec md)
		{
			if (this.modifier_spec == null)
			{
				this.modifier_spec = new List<IModifierSpec>();
			}
			this.modifier_spec.Add(md);
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0001C500 File Offset: 0x0001A700
		private static void SkipSpace(string name, ref int pos)
		{
			int num = pos;
			while (num < name.Length && char.IsWhiteSpace(name[num]))
			{
				num++;
			}
			pos = num;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0001C530 File Offset: 0x0001A730
		private static void BoundCheck(int idx, string s)
		{
			if (idx >= s.Length)
			{
				throw new ArgumentException(SR.Argument_InvalidGenericArg, "typeName");
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0001C54B File Offset: 0x0001A74B
		private static ITypeIdentifier ParsedTypeIdentifier(string displayName)
		{
			return TypeIdentifiers.FromDisplay(displayName);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0001C554 File Offset: 0x0001A754
		private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn)
		{
			int i = p;
			bool flag = false;
			TypeSpec typeSpec = new TypeSpec();
			TypeSpec.SkipSpace(name, ref i);
			int num = i;
			while (i < name.Length)
			{
				char c = name[i];
				switch (c)
				{
				case '&':
				case '*':
					goto IL_98;
				case '\'':
				case '(':
				case ')':
					break;
				case '+':
					typeSpec.AddName(name.Substring(num, i - num));
					num = i + 1;
					break;
				case ',':
					goto IL_77;
				default:
					switch (c)
					{
					case '[':
						goto IL_98;
					case '\\':
						i++;
						break;
					case ']':
						goto IL_77;
					}
					break;
				}
				IL_D6:
				if (!flag)
				{
					i++;
					continue;
				}
				break;
				IL_77:
				typeSpec.AddName(name.Substring(num, i - num));
				num = i + 1;
				flag = true;
				if (is_recurse && !allow_aqn)
				{
					p = i;
					return typeSpec;
				}
				goto IL_D6;
				IL_98:
				if (name[i] != '[' && is_recurse)
				{
					throw new ArgumentException(SR.Argument_GenericArgumentCannotBeByrefOrPointerType, "typeName");
				}
				typeSpec.AddName(name.Substring(num, i - num));
				num = i + 1;
				flag = true;
				goto IL_D6;
			}
			if (num < i)
			{
				typeSpec.AddName(name.Substring(num, i - num));
			}
			else if (num == i)
			{
				typeSpec.AddName(string.Empty);
			}
			if (flag)
			{
				while (i < name.Length)
				{
					char c = name[i];
					if (c <= '*')
					{
						if (c != '&')
						{
							if (c != '*')
							{
								goto IL_4C8;
							}
							if (typeSpec.is_byref)
							{
								throw new ArgumentException(SR.Format(SR.CannotCreatePointerOfByRef, typeSpec.TypeName), "typeName");
							}
							int num2 = 1;
							while (i + 1 < name.Length && name[i + 1] == '*')
							{
								i++;
								num2++;
							}
							typeSpec.AddModifier(new PointerSpec(num2));
						}
						else
						{
							if (typeSpec.is_byref)
							{
								throw new ArgumentException(SR.Format(SR.CannotCreateByRefOfByRef, typeSpec.TypeName), "typeName");
							}
							typeSpec.is_byref = true;
						}
					}
					else if (c != ',')
					{
						if (c != '[')
						{
							if (c != ']')
							{
								goto IL_4C8;
							}
							if (is_recurse)
							{
								p = i;
								return typeSpec;
							}
							throw new ArgumentException(SR.Argument_UnmatchedSquareBracketWhileParsingGenericArgAssemblyName, "typeName");
						}
						else
						{
							if (typeSpec.is_byref)
							{
								throw new ArgumentException(SR.Argument_ByrefQualifierMustBeLastOneOfAType, "typeName");
							}
							i++;
							if (i >= name.Length)
							{
								throw new ArgumentException(SR.Argument_InvalidArrayType, "typeName");
							}
							TypeSpec.SkipSpace(name, ref i);
							if (name[i] != ',' && name[i] != '*' && name[i] != ']')
							{
								List<TypeSpec> list = new List<TypeSpec>();
								if (typeSpec.HasModifiers)
								{
									throw new ArgumentException(SR.Arg_GenericArgumentsAfterArrayOrPointerType, "typeName");
								}
								while (i < name.Length)
								{
									TypeSpec.SkipSpace(name, ref i);
									bool flag2 = name[i] == '[';
									if (flag2)
									{
										i++;
									}
									list.Add(TypeSpec.Parse(name, ref i, true, flag2));
									TypeSpec.BoundCheck(i, name);
									if (flag2)
									{
										if (name[i] != ']')
										{
											throw new ArgumentException(SR.Format(SR.Argument_UnclosedAssemblyQualifiedTypeName, name[i]), "typeName");
										}
										i++;
										TypeSpec.BoundCheck(i, name);
									}
									if (name[i] == ']')
									{
										break;
									}
									if (name[i] != ',')
									{
										throw new ArgumentException(SR.Format(SR.Argument_InvalidGenericArgumentsSeparator, name[i]), "typeName");
									}
									i++;
								}
								if (i >= name.Length || name[i] != ']')
								{
									throw new ArgumentException(SR.Argument_GenericParsingError, "typeName");
								}
								typeSpec.generic_params = list;
							}
							else
							{
								int num3 = 1;
								bool flag3 = false;
								while (i < name.Length && name[i] != ']')
								{
									if (name[i] == '*')
									{
										if (flag3)
										{
											throw new ArgumentException(SR.Argument_MultiDimensionalArrayCannotBeBound, "typeName");
										}
										flag3 = true;
									}
									else
									{
										if (name[i] != ',')
										{
											throw new ArgumentException(SR.Format(SR.Argument_InvalidCharInArraySpecification, name[i]), "typeName");
										}
										num3++;
									}
									i++;
									TypeSpec.SkipSpace(name, ref i);
								}
								if (i >= name.Length || name[i] != ']')
								{
									throw new ArgumentException(SR.Argument_ArrayParsingError, "typeName");
								}
								if (num3 > 1 && flag3)
								{
									throw new ArgumentException(SR.Argument_MultiDimensionalArrayCannotBeBound, "typeName");
								}
								typeSpec.AddModifier(new IArraySpec(num3, flag3));
							}
						}
					}
					else if (is_recurse && allow_aqn)
					{
						int num4 = i;
						while (num4 < name.Length && name[num4] != ']')
						{
							num4++;
						}
						if (num4 >= name.Length)
						{
							throw new ArgumentException(SR.Argument_UnmatchedSquareBracketWhileParsingGenericArgAssemblyName);
						}
						typeSpec.assembly_name = name.Substring(i + 1, num4 - i - 1).Trim();
						p = num4;
						return typeSpec;
					}
					else
					{
						if (is_recurse)
						{
							p = i;
							return typeSpec;
						}
						if (allow_aqn)
						{
							typeSpec.assembly_name = name.Substring(i + 1).Trim();
							i = name.Length;
						}
					}
					i++;
					continue;
					IL_4C8:
					throw new ArgumentException(SR.Format(SR.Argument_BadTypeDef, name[i], i), "typeName");
				}
			}
			p = i;
			return typeSpec;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0001CA64 File Offset: 0x0001AC64
		internal ITypeName TypeNameWithoutModifiers()
		{
			return new TypeSpec.TypeSpecTypeName(this, false);
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0001CA6D File Offset: 0x0001AC6D
		internal ITypeName TypeName
		{
			get
			{
				return new TypeSpec.TypeSpecTypeName(this, true);
			}
		}

		// Token: 0x040002B6 RID: 694
		private ITypeIdentifier name;

		// Token: 0x040002B7 RID: 695
		private string assembly_name;

		// Token: 0x040002B8 RID: 696
		private List<ITypeIdentifier> nested;

		// Token: 0x040002B9 RID: 697
		private List<TypeSpec> generic_params;

		// Token: 0x040002BA RID: 698
		private List<IModifierSpec> modifier_spec;

		// Token: 0x040002BB RID: 699
		private bool is_byref;

		// Token: 0x040002BC RID: 700
		private string display_fullname;

		// Token: 0x020000AC RID: 172
		[Flags]
		internal enum DisplayNameFormat
		{
			// Token: 0x040002BE RID: 702
			Default = 0,
			// Token: 0x040002BF RID: 703
			WANT_ASSEMBLY = 1,
			// Token: 0x040002C0 RID: 704
			NO_MODIFIERS = 2
		}

		// Token: 0x020000AD RID: 173
		private sealed class TypeSpecTypeName : TypeNames.ATypeName, ITypeName, IEquatable<ITypeName>
		{
			// Token: 0x060008D4 RID: 2260 RVA: 0x0001CA76 File Offset: 0x0001AC76
			internal TypeSpecTypeName(TypeSpec ts, bool wantModifiers)
			{
				this.ts = ts;
				this.want_modifiers = wantModifiers;
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x060008D5 RID: 2261 RVA: 0x0001CA8C File Offset: 0x0001AC8C
			public override string DisplayName
			{
				get
				{
					if (this.want_modifiers)
					{
						return this.ts.DisplayFullName;
					}
					return this.ts.GetDisplayFullName(TypeSpec.DisplayNameFormat.NO_MODIFIERS);
				}
			}

			// Token: 0x060008D6 RID: 2262 RVA: 0x0001BBA3 File Offset: 0x00019DA3
			public override ITypeName NestedName(ITypeIdentifier innerName)
			{
				return TypeNames.FromDisplay(this.DisplayName + "+" + innerName.DisplayName);
			}

			// Token: 0x040002C1 RID: 705
			private readonly TypeSpec ts;

			// Token: 0x040002C2 RID: 706
			private readonly bool want_modifiers;
		}
	}
}
