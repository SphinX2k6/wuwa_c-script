using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent
{
	// Token: 0x02004878 RID: 18552
	[NullableContext(1)]
	[Nullable(0)]
	public class InstanceDungeonMowingPanelItemData
	{
		// Token: 0x17005E60 RID: 24160
		// (get) Token: 0x0602EAB9 RID: 191161 RVA: 0x00D06FF0 File Offset: 0x00D051F0
		// (set) Token: 0x0602EABA RID: 191162 RVA: 0x00D06FF8 File Offset: 0x00D051F8
		public bool ScoreItemActive { get; set; }

		// Token: 0x17005E61 RID: 24161
		// (get) Token: 0x0602EABB RID: 191163 RVA: 0x00D07001 File Offset: 0x00D05201
		// (set) Token: 0x0602EABC RID: 191164 RVA: 0x00D07009 File Offset: 0x00D05209
		[Nullable(2)]
		public string ScoreText { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17005E62 RID: 24162
		// (get) Token: 0x0602EABD RID: 191165 RVA: 0x00D07012 File Offset: 0x00D05212
		// (set) Token: 0x0602EABE RID: 191166 RVA: 0x00D0701A File Offset: 0x00D0521A
		public Action LeftBtnClickCallBack { get; set; }

		// Token: 0x17005E63 RID: 24163
		// (get) Token: 0x0602EABF RID: 191167 RVA: 0x00D07023 File Offset: 0x00D05223
		// (set) Token: 0x0602EAC0 RID: 191168 RVA: 0x00D0702B File Offset: 0x00D0522B
		public Action RightBtnClickCallBack { get; set; }
	}
}
