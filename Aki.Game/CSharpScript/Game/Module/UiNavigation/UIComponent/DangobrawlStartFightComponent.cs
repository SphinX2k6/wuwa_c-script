using System;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02004A01 RID: 18945
	public class DangobrawlStartFightComponent : DangobrawlHotKeyComponentBase
	{
		// Token: 0x060312CD RID: 201421 RVA: 0x00B67E0D File Offset: 0x00B6600D
		public DangobrawlStartFightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060312CE RID: 201422 RVA: 0x00B67E18 File Offset: 0x00B66018
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

		// Token: 0x060312CF RID: 201423 RVA: 0x00B67E5F File Offset: 0x00B6605F
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

		// Token: 0x060312D0 RID: 201424 RVA: 0x00B67E7A File Offset: 0x00B6607A
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add(EEventName.OnDangoBrawlCostChanged, new Action(this.OnCostChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlFightStateModify, new Action<EDangoBrawlFightState, EDangoBrawlFightState>(this.OnFightStateModify));
		}

		// Token: 0x060312D1 RID: 201425 RVA: 0x00B67EBA File Offset: 0x00B660BA
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlCostChanged, new Action(this.OnCostChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlFightStateModify, new Action<EDangoBrawlFightState, EDangoBrawlFightState>(this.OnFightStateModify));
			base.OnRemoveEventListener();
		}

		// Token: 0x060312D2 RID: 201426 RVA: 0x00B67EFA File Offset: 0x00B660FA
		private void OnCostChanged()
		{
			base.RequestRefresh();
		}

		// Token: 0x060312D3 RID: 201427 RVA: 0x00B67F02 File Offset: 0x00B66102
		private void OnFightStateModify(EDangoBrawlFightState state, EDangoBrawlFightState preState)
		{
			base.RequestRefresh();
		}
	}
}
