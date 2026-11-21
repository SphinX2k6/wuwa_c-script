using System;

namespace System
{
	// Token: 0x020000A1 RID: 161
	internal static class TypeIdentifiers
	{
		// Token: 0x06000886 RID: 2182 RVA: 0x0001BB36 File Offset: 0x00019D36
		internal static ITypeIdentifier FromDisplay(string displayName)
		{
			return new TypeIdentifiers.Display(displayName);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0001BB3E File Offset: 0x00019D3E
		internal static ITypeIdentifier FromInternal(string internalName)
		{
			return new TypeIdentifiers.Internal(internalName);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x0001BB46 File Offset: 0x00019D46
		internal static ITypeIdentifier FromInternal(string internalNameSpace, ITypeIdentifier typeName)
		{
			return new TypeIdentifiers.Internal(internalNameSpace, typeName);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x0001BB4F File Offset: 0x00019D4F
		internal static ITypeIdentifier WithoutEscape(string simpleName)
		{
			return new TypeIdentifiers.NoEscape(simpleName);
		}

		// Token: 0x020000A2 RID: 162
		private sealed class Display : TypeNames.ATypeName, ITypeIdentifier, ITypeName, IEquatable<ITypeName>
		{
			// Token: 0x0600088A RID: 2186 RVA: 0x0001BB57 File Offset: 0x00019D57
			internal Display(string displayName)
			{
				this.displayName = displayName;
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x0600088B RID: 2187 RVA: 0x0001BB66 File Offset: 0x00019D66
			public override string DisplayName
			{
				get
				{
					return this.displayName;
				}
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x0600088C RID: 2188 RVA: 0x0001BB70 File Offset: 0x00019D70
			public string InternalName
			{
				get
				{
					string result;
					if ((result = this.internal_name) == null)
					{
						result = (this.internal_name = this.GetInternalName());
					}
					return result;
				}
			}

			// Token: 0x0600088D RID: 2189 RVA: 0x0001BB96 File Offset: 0x00019D96
			private string GetInternalName()
			{
				return TypeSpec.UnescapeInternalName(this.displayName);
			}

			// Token: 0x0600088E RID: 2190 RVA: 0x0001BBA3 File Offset: 0x00019DA3
			public override ITypeName NestedName(ITypeIdentifier innerName)
			{
				return TypeNames.FromDisplay(this.DisplayName + "+" + innerName.DisplayName);
			}

			// Token: 0x040002A7 RID: 679
			private readonly string displayName;

			// Token: 0x040002A8 RID: 680
			private string internal_name;
		}

		// Token: 0x020000A3 RID: 163
		private sealed class Internal : TypeNames.ATypeName, ITypeIdentifier, ITypeName, IEquatable<ITypeName>
		{
			// Token: 0x0600088F RID: 2191 RVA: 0x0001BBC0 File Offset: 0x00019DC0
			internal Internal(string internalName)
			{
				this.internalName = internalName;
			}

			// Token: 0x06000890 RID: 2192 RVA: 0x0001BBCF File Offset: 0x00019DCF
			internal Internal(string nameSpaceInternal, ITypeIdentifier typeName)
			{
				this.internalName = nameSpaceInternal + "." + typeName.InternalName;
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x06000891 RID: 2193 RVA: 0x0001BBF0 File Offset: 0x00019DF0
			public override string DisplayName
			{
				get
				{
					string result;
					if ((result = this.display_name) == null)
					{
						result = (this.display_name = this.GetDisplayName());
					}
					return result;
				}
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x06000892 RID: 2194 RVA: 0x0001BC16 File Offset: 0x00019E16
			public string InternalName
			{
				get
				{
					return this.internalName;
				}
			}

			// Token: 0x06000893 RID: 2195 RVA: 0x0001BC1E File Offset: 0x00019E1E
			private string GetDisplayName()
			{
				return TypeSpec.EscapeDisplayName(this.internalName);
			}

			// Token: 0x06000894 RID: 2196 RVA: 0x0001BBA3 File Offset: 0x00019DA3
			public override ITypeName NestedName(ITypeIdentifier innerName)
			{
				return TypeNames.FromDisplay(this.DisplayName + "+" + innerName.DisplayName);
			}

			// Token: 0x040002A9 RID: 681
			private readonly string internalName;

			// Token: 0x040002AA RID: 682
			private string display_name;
		}

		// Token: 0x020000A4 RID: 164
		private sealed class NoEscape : TypeNames.ATypeName, ITypeIdentifier, ITypeName, IEquatable<ITypeName>
		{
			// Token: 0x06000895 RID: 2197 RVA: 0x0001BC2B File Offset: 0x00019E2B
			internal NoEscape(string simpleName)
			{
				this.simpleName = simpleName;
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x06000896 RID: 2198 RVA: 0x0001BC3A File Offset: 0x00019E3A
			public override string DisplayName
			{
				get
				{
					return this.simpleName;
				}
			}

			// Token: 0x170000CE RID: 206
			// (get) Token: 0x06000897 RID: 2199 RVA: 0x0001BC3A File Offset: 0x00019E3A
			public string InternalName
			{
				get
				{
					return this.simpleName;
				}
			}

			// Token: 0x06000898 RID: 2200 RVA: 0x0001BBA3 File Offset: 0x00019DA3
			public override ITypeName NestedName(ITypeIdentifier innerName)
			{
				return TypeNames.FromDisplay(this.DisplayName + "+" + innerName.DisplayName);
			}

			// Token: 0x040002AB RID: 683
			private readonly string simpleName;
		}
	}
}
