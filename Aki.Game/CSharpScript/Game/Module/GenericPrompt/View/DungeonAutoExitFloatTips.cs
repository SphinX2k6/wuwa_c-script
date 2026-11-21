using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x0200497E RID: 18814
	public class DungeonAutoExitFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0602F29C RID: 193180 RVA: 0x00D2540A File Offset: 0x00D2360A
		[NullableContext(1)]
		public DungeonAutoExitFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F29D RID: 193181 RVA: 0x00D25413 File Offset: 0x00D23613
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add<double, double>(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.UpdateCountDown));
		}

		// Token: 0x0602F29E RID: 193182 RVA: 0x00D25437 File Offset: 0x00D23637
		protected override void OnRemoveEventListener()
		{
			base.OnRemoveEventListener();
			EventSystem.Instance.Remove(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.UpdateCountDown));
		}

		// Token: 0x0602F29F RID: 193183 RVA: 0x00D2545B File Offset: 0x00D2365B
		private void UpdateCountDown(double cdRemainTime, double d)
		{
			this.SetMainText(new <>z__ReadOnlySingleElementList<object>(cdRemainTime.ToString(CultureInfo.InvariantCulture)));
		}
	}
}
