using System;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02003977 RID: 14711
	public class DangobrawlMoveRotateComponent : DangobrawlHotKeyComponentBase
	{
		// Token: 0x06025DF5 RID: 155125 RVA: 0x00AA29FE File Offset: 0x00AA0BFE
		public DangobrawlMoveRotateComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025DF6 RID: 155126 RVA: 0x00AA2A08 File Offset: 0x00AA0C08
		protected override bool ShouldShow()
		{
			EInputPlatform? inputPlatform = DangobrawlHotKeyComponentBase.InputPlatform;
			EInputPlatform einputPlatform = EInputPlatform.Mobile;
			bool flag = !(inputPlatform.GetValueOrDefault() == einputPlatform & inputPlatform != null);
			bool isDragging = DangobrawlHotKeyComponentBase.IsDragging;
			bool flag2;
			if (DangobrawlHotKeyComponentBase.CurrentHovered != null && DangobrawlHotKeyComponentBase.FsmSourceUid != null)
			{
				int id = DangobrawlHotKeyComponentBase.CurrentHovered.Id;
				int? fsmSourceUid = DangobrawlHotKeyComponentBase.FsmSourceUid;
				flag2 = (id == fsmSourceUid.GetValueOrDefault() & fsmSourceUid != null);
			}
			else
			{
				flag2 = false;
			}
			bool flag3 = flag2;
			return flag && (isDragging || flag3);
		}

		// Token: 0x06025DF7 RID: 155127 RVA: 0x00AA2A7C File Offset: 0x00AA0C7C
		protected override void OnRelease(HotKeyMap config)
		{
			int targetUid = DangobrawlHotKeyComponentBase.DraggingUid ?? DangobrawlHotKeyComponentBase.FsmSourceUid.GetValueOrDefault(-1);
			DangoBrawlOperationDispatcher dispatcher = DangobrawlHotKeyComponentBase.Dispatcher;
			if (dispatcher != null)
			{
				dispatcher.Execute(EDangoBrawlOptionType.Rotate, targetUid).Forget<bool>();
			}
			EventSystem.Instance.Emit(EEventName.OnDangobrawlMoveRotateHotKeyNotify);
		}
	}
}
