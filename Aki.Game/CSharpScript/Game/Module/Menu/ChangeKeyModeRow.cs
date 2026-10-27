using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020053FB RID: 21499
	[NullableContext(1)]
	[Nullable(0)]
	public class ChangeKeyModeRow : IChangeKeyModeRow
	{
		// Token: 0x17008413 RID: 33811
		// (get) Token: 0x06036F25 RID: 225061 RVA: 0x00D04E51 File Offset: 0x00D03051
		// (set) Token: 0x06036F26 RID: 225062 RVA: 0x00D04E59 File Offset: 0x00D03059
		public string RowSpriteResourceId { get; set; } = "";

		// Token: 0x17008414 RID: 33812
		// (get) Token: 0x06036F27 RID: 225063 RVA: 0x00D04E62 File Offset: 0x00D03062
		// (set) Token: 0x06036F28 RID: 225064 RVA: 0x00D04E6A File Offset: 0x00D0306A
		public string DescriptionA { get; set; } = "";

		// Token: 0x17008415 RID: 33813
		// (get) Token: 0x06036F29 RID: 225065 RVA: 0x00D04E73 File Offset: 0x00D03073
		// (set) Token: 0x06036F2A RID: 225066 RVA: 0x00D04E7B File Offset: 0x00D0307B
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] DescriptionParametersA { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17008416 RID: 33814
		// (get) Token: 0x06036F2B RID: 225067 RVA: 0x00D04E84 File Offset: 0x00D03084
		// (set) Token: 0x06036F2C RID: 225068 RVA: 0x00D04E8C File Offset: 0x00D0308C
		public string DescriptionB { get; set; } = "";

		// Token: 0x17008417 RID: 33815
		// (get) Token: 0x06036F2D RID: 225069 RVA: 0x00D04E95 File Offset: 0x00D03095
		// (set) Token: 0x06036F2E RID: 225070 RVA: 0x00D04E9D File Offset: 0x00D0309D
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] DescriptionParametersB { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }
	}
}
