using System;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02004A00 RID: 18944
	public class DangobrawlReplaceComponent : DangobrawlHotKeyComponentBase
	{
		// Token: 0x060312CA RID: 201418 RVA: 0x00B67D38 File Offset: 0x00B65F38
		public DangobrawlReplaceComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060312CB RID: 201419 RVA: 0x00B67D44 File Offset: 0x00B65F44
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

		// Token: 0x060312CC RID: 201420 RVA: 0x00B67DCC File Offset: 0x00B65FCC
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
