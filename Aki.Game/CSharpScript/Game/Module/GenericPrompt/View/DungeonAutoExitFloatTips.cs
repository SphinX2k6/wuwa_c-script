using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x020059A5 RID: 22949
	public class DungeonAutoExitFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0603A376 RID: 238454 RVA: 0x00DD5F7A File Offset: 0x00DD417A
		[NullableContext(1)]
		public DungeonAutoExitFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A377 RID: 238455 RVA: 0x00DD5F83 File Offset: 0x00DD4183
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add<double, double>(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.UpdateCountDown));
		}

		// Token: 0x0603A378 RID: 238456 RVA: 0x00DD5FA7 File Offset: 0x00DD41A7
		protected override void OnRemoveEventListener()
		{
			base.OnRemoveEventListener();
			EventSystem.Instance.Remove(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.UpdateCountDown));
		}

		// Token: 0x0603A379 RID: 238457 RVA: 0x00DD5FCB File Offset: 0x00DD41CB
		private void UpdateCountDown(double cdRemainTime, double d)
		{
			this.SetMainText(new <>z__ReadOnlySingleElementList<object>(cdRemainTime.ToString(CultureInfo.InvariantCulture)));
		}
	}
}
