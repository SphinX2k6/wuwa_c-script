using System;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x020049FD RID: 18941
	public class DangobrawlMoveRotateComponent : DangobrawlHotKeyComponentBase
	{
		// Token: 0x060312BF RID: 201407 RVA: 0x00B67A42 File Offset: 0x00B65C42
		public DangobrawlMoveRotateComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060312C0 RID: 201408 RVA: 0x00B67A4C File Offset: 0x00B65C4C
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

		// Token: 0x060312C1 RID: 201409 RVA: 0x00B67AC0 File Offset: 0x00B65CC0
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
