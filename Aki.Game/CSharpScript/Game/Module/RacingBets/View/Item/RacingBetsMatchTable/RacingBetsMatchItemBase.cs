using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.RacingBets.View.Item.RacingBetsMatchTable
{
	// Token: 0x02003EF3 RID: 16115
	public class RacingBetsMatchItemBase : UiPanelBase
	{
		// Token: 0x06028E25 RID: 167461 RVA: 0x00B79443 File Offset: 0x00B77643
		protected override void OnBeforeCreate()
		{
			this.UiLevelSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiLevelSequence);
		}

		// Token: 0x06028E26 RID: 167462 RVA: 0x00B79460 File Offset: 0x00B77660
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

		// Token: 0x04016396 RID: 91030
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<RacingBetsMatchTableDangoItem, IRacingBetsMatchTableDangoItemData> DangoLayout;

		// Token: 0x04016397 RID: 91031
		[Nullable(2)]
		public UiBehaviorLevelSequence UiLevelSequence;
	}
}
