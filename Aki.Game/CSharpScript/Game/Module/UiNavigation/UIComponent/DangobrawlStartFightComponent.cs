using System;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x0200397B RID: 14715
	public class DangobrawlStartFightComponent : DangobrawlHotKeyComponentBase
	{
		// Token: 0x06025E03 RID: 155139 RVA: 0x00AA2DC9 File Offset: 0x00AA0FC9
		public DangobrawlStartFightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025E04 RID: 155140 RVA: 0x00AA2DD4 File Offset: 0x00AA0FD4
		protected override bool ShouldShow()
		{
			DangoBrawlItemViewRegistry registry = DangobrawlHotKeyComponentBase.Registry;
			bool? flag;
			if (registry == null)
			{
				flag = null;
			}
			else
			{
				DangoBrawlBackpackView backpackView = registry.GetBackpackView();
				flag = ((backpackView != null) ? new bool?(backpackView.IsFightBtnInteractive()) : null);
			}
			bool? flag2 = flag;
			return flag2.GetValueOrDefault();
		}

		// Token: 0x06025E05 RID: 155141 RVA: 0x00AA2E1B File Offset: 0x00AA101B
		protected override void OnRelease(HotKeyMap config)
		{
			DangoBrawlItemViewRegistry registry = DangobrawlHotKeyComponentBase.Registry;
			if (registry == null)
			{
				return;
			}
			DangoBrawlBackpackView backpackView = registry.GetBackpackView();
			if (backpackView == null)
			{
				return;
			}
			backpackView.ClickFightBtn();
		}

		// Token: 0x06025E06 RID: 155142 RVA: 0x00AA2E36 File Offset: 0x00AA1036
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add(EEventName.OnDangoBrawlCostChanged, new Action(this.OnCostChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlFightStateModify, new Action<EDangoBrawlFightState, EDangoBrawlFightState>(this.OnFightStateModify));
		}

		// Token: 0x06025E07 RID: 155143 RVA: 0x00AA2E76 File Offset: 0x00AA1076
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlCostChanged, new Action(this.OnCostChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlFightStateModify, new Action<EDangoBrawlFightState, EDangoBrawlFightState>(this.OnFightStateModify));
			base.OnRemoveEventListener();
		}

		// Token: 0x06025E08 RID: 155144 RVA: 0x00AA2EB6 File Offset: 0x00AA10B6
		private void OnCostChanged()
		{
			base.RequestRefresh();
		}

		// Token: 0x06025E09 RID: 155145 RVA: 0x00AA2EBE File Offset: 0x00AA10BE
		private void OnFightStateModify(EDangoBrawlFightState state, EDangoBrawlFightState preState)
		{
			base.RequestRefresh();
		}
	}
}
