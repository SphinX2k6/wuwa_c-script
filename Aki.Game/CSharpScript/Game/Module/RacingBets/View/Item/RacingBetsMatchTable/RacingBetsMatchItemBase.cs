using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.RacingBets.View.Item.RacingBetsMatchTable
{
	// Token: 0x02004F2A RID: 20266
	public class RacingBetsMatchItemBase : UiPanelBase
	{
		// Token: 0x06033FB7 RID: 212919 RVA: 0x00C2FC9B File Offset: 0x00C2DE9B
		protected override void OnBeforeCreate()
		{
			this.UiLevelSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiLevelSequence);
		}

		// Token: 0x06033FB8 RID: 212920 RVA: 0x00C2FCB8 File Offset: 0x00C2DEB8
		public void PlayAnim()
		{
			UiBehaviorLevelSequence uiLevelSequence = this.UiLevelSequence;
			if (uiLevelSequence != null)
			{
				uiLevelSequence.PlaySequence("Start", false, null);
			}
			GenericLayout<RacingBetsMatchTableDangoItem, IRacingBetsMatchTableDangoItemData> dangoLayout = this.DangoLayout;
			if (dangoLayout == null)
			{
				return;
			}
			dangoLayout.PlayGridAnim();
		}

		// Token: 0x0401B9C1 RID: 113089
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<RacingBetsMatchTableDangoItem, IRacingBetsMatchTableDangoItemData> DangoLayout;

		// Token: 0x0401B9C2 RID: 113090
		[Nullable(2)]
		public UiBehaviorLevelSequence UiLevelSequence;
	}
}
