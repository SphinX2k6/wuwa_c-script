using System;

namespace System
{
	// Token: 0x0200009E RID: 158
	internal static class TypeNames
	{
		// Token: 0x0600087C RID: 2172 RVA: 0x0001BAC7 File Offset: 0x00019CC7
		internal static ITypeName FromDisplay(string displayName)
		{
			return new TypeNames.Display(displayName);
		}

		// Token: 0x0200009F RID: 159
		internal abstract class ATypeName : ITypeName, IEquatable<ITypeName>
		{
			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x0600087D RID: 2173
			public abstract string DisplayName { get; }

			// Token: 0x0600087E RID: 2174
			public abstract ITypeName NestedName(ITypeIdentifier innerName);

			// Token: 0x0600087F RID: 2175 RVA: 0x0001BACF File Offset: 0x00019CCF
			public bool Equals(ITypeName other)
			{
				return other != null && this.DisplayName == other.DisplayName;
			}

			// Token: 0x06000880 RID: 2176 RVA: 0x0001BAE7 File Offset: 0x00019CE7
			public override int GetHashCode()
			{
				return this.DisplayName.GetHashCode();
			}

			// Token: 0x06000881 RID: 2177 RVA: 0x0001BAF4 File Offset: 0x00019CF4
			public override bool Equals(object other)
			{
				return this.Equals(other as ITypeName);
			}
		}

		// Token: 0x020000A0 RID: 160
		private sealed class Display : TypeNames.ATypeName
		{
			// Token: 0x06000883 RID: 2179 RVA: 0x0001BB02 File Offset: 0x00019D02
			internal Display(string displayName)
			{
				this.displayName = displayName;
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x06000884 RID: 2180 RVA: 0x0001BB11 File Offset: 0x00019D11
			public override string DisplayName
			{
				get
				{
					return this.displayName;
				}
			}

			// Token: 0x06000885 RID: 2181 RVA: 0x0001BB19 File Offset: 0x00019D19
			public override ITypeName NestedName(ITypeIdentifier innerName)
			{
				return new TypeNames.Display(this.DisplayName + "+" + innerName.DisplayName);
			}

			// Token: 0x040002A6 RID: 678
			private readonly string displayName;
		}
	}
}
