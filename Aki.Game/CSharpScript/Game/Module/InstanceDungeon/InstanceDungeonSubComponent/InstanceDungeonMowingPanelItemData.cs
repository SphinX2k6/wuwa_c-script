using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x020058A0 RID: 22688
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonMowingPanelItemData
	{
		// Token: 0x17008A94 RID: 35476
		// (get) Token: 0x06039B96 RID: 236438 RVA: 0x00DB80D8 File Offset: 0x00DB62D8
		// (set) Token: 0x06039B97 RID: 236439 RVA: 0x00DB80E0 File Offset: 0x00DB62E0
		public bool ScoreItemActive { get; set; }

		// Token: 0x17008A95 RID: 35477
		// (get) Token: 0x06039B98 RID: 236440 RVA: 0x00DB80E9 File Offset: 0x00DB62E9
		// (set) Token: 0x06039B99 RID: 236441 RVA: 0x00DB80F1 File Offset: 0x00DB62F1
		[Nullable(2)]
		public string ScoreText { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17008A96 RID: 35478
		// (get) Token: 0x06039B9A RID: 236442 RVA: 0x00DB80FA File Offset: 0x00DB62FA
		// (set) Token: 0x06039B9B RID: 236443 RVA: 0x00DB8102 File Offset: 0x00DB6302
		public Action LeftBtnClickCallBack { get; set; }

		// Token: 0x17008A97 RID: 35479
		// (get) Token: 0x06039B9C RID: 236444 RVA: 0x00DB810B File Offset: 0x00DB630B
		// (set) Token: 0x06039B9D RID: 236445 RVA: 0x00DB8113 File Offset: 0x00DB6313
		public Action RightBtnClickCallBack { get; set; }
	}
}
