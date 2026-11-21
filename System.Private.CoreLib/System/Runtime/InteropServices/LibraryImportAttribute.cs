using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005DF RID: 1503
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class LibraryImportAttribute : Attribute
	{
		// Token: 0x06007047 RID: 28743 RVA: 0x0010DCCE File Offset: 0x0010BECE
		[NullableContext(1)]
		public LibraryImportAttribute(string libraryName)
		{
			this.LibraryName = libraryName;
		}

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06007048 RID: 28744 RVA: 0x0010DCDD File Offset: 0x0010BEDD
		[Nullable(1)]
		public string LibraryName { [NullableContext(1)] get; }

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06007049 RID: 28745 RVA: 0x0010DCE5 File Offset: 0x0010BEE5
		// (set) Token: 0x0600704A RID: 28746 RVA: 0x0010DCED File Offset: 0x0010BEED
		public string EntryPoint { get; set; }

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x0600704B RID: 28747 RVA: 0x0010DCF6 File Offset: 0x0010BEF6
		// (set) Token: 0x0600704C RID: 28748 RVA: 0x0010DCFE File Offset: 0x0010BEFE
		public StringMarshalling StringMarshalling { get; set; }

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x0600704D RID: 28749 RVA: 0x0010DD07 File Offset: 0x0010BF07
		// (set) Token: 0x0600704E RID: 28750 RVA: 0x0010DD0F File Offset: 0x0010BF0F
		public Type StringMarshallingCustomType { get; set; }

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x0600704F RID: 28751 RVA: 0x0010DD18 File Offset: 0x0010BF18
		// (set) Token: 0x06007050 RID: 28752 RVA: 0x0010DD20 File Offset: 0x0010BF20
		public bool SetLastError { get; set; }
	}
}
