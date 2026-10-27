using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Motorcycle.Model
{
	// Token: 0x02005393 RID: 21395
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorcycleUiModelParam
	{
		// Token: 0x170083A7 RID: 33703
		// (get) Token: 0x06036A80 RID: 223872 RVA: 0x00CEF82B File Offset: 0x00CEDA2B
		// (set) Token: 0x06036A81 RID: 223873 RVA: 0x00CEF833 File Offset: 0x00CEDA33
		public int FrameId { get; set; }

		// Token: 0x170083A8 RID: 33704
		// (get) Token: 0x06036A82 RID: 223874 RVA: 0x00CEF83C File Offset: 0x00CEDA3C
		// (set) Token: 0x06036A83 RID: 223875 RVA: 0x00CEF844 File Offset: 0x00CEDA44
		public int[] StickerIds { get; set; }

		// Token: 0x170083A9 RID: 33705
		// (get) Token: 0x06036A84 RID: 223876 RVA: 0x00CEF84D File Offset: 0x00CEDA4D
		// (set) Token: 0x06036A85 RID: 223877 RVA: 0x00CEF855 File Offset: 0x00CEDA55
		public int[] DecorationIds { get; set; }
	}
}
