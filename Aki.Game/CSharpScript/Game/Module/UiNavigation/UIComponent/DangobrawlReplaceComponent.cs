using System;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x0200397A RID: 14714
	public class DangobrawlReplaceComponent : DangobrawlHotKeyComponentBase
	{
		// Token: 0x06025E00 RID: 155136 RVA: 0x00AA2CF4 File Offset: 0x00AA0EF4
		public DangobrawlReplaceComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025E01 RID: 155137 RVA: 0x00AA2D00 File Offset: 0x00AA0F00
		protected override bool ShouldShow()
		{
			bool flag = DangobrawlHotKeyComponentBase.InputPlatform.GetValueOrDefault() == EInputPlatform.Pc;
			bool isHolding = DangobrawlHotKeyComponentBase.IsHolding;
			DangoBrawlOperationDispatcher dispatcher = DangobrawlHotKeyComponentBase.Dispatcher;
			bool flag2 = dispatcher != null && dispatcher.CanExecute(EDangoBrawlOptionType.Confim, DangobrawlHotKeyComponentBase.FsmSourceUid.GetValueOrDefault(-1));
			bool flag3;
			if (DangobrawlHotKeyComponentBase.CurrentHovered != null && DangobrawlHotKeyComponentBase.FsmSourceUid != null)
			{
				int id = DangobrawlHotKeyComponentBase.CurrentHovered.Id;
				int? fsmSourceUid = DangobrawlHotKeyComponentBase.FsmSourceUid;
				flag3 = (id == fsmSourceUid.GetValueOrDefault() & fsmSourceUid != null);
			}
			else
			{
				flag3 = false;
			}
			bool flag4 = flag3;
			return flag && isHolding && flag2 && flag4;
		}

		// Token: 0x06025E02 RID: 155138 RVA: 0x00AA2D88 File Offset: 0x00AA0F88
		protected override void OnRelease(HotKeyMap config)
		{
			DangoBrawlOperationDispatcher dispatcher = DangobrawlHotKeyComponentBase.Dispatcher;
			if (dispatcher != null)
			{
				dispatcher.Execute(EDangoBrawlOptionType.Confim, DangobrawlHotKeyComponentBase.FsmSourceUid.GetValueOrDefault(-1)).Forget<bool>();
			}
			EventSystem.Instance.Emit(EEventName.OnDangobrawlReplaceHotKeyNotify);
		}
	}
}
