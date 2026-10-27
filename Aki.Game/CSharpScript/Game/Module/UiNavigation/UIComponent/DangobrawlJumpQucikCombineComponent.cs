using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x020049FA RID: 18938
	[NullableContext(1)]
	[Nullable(0)]
	public class DangobrawlJumpQucikCombineComponent : HotKeyComponent
	{
		// Token: 0x060312AB RID: 201387 RVA: 0x00B6766E File Offset: 0x00B6586E
		public DangobrawlJumpQucikCombineComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060312AC RID: 201388 RVA: 0x00B6768C File Offset: 0x00B6588C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBackpackModified, new Action<EDangoBrawlModifyType, int>(this.OnDangoBrawlBackpackModified));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBenchModified, new Action<EDangoBrawlModifyType, int>(this.OnDangoBrawlBenchModified));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnDangoBrawlBagUpdated));
		}

		// Token: 0x060312AD RID: 201389 RVA: 0x00B676F0 File Offset: 0x00B658F0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBackpackModified, new Action<EDangoBrawlModifyType, int>(this.OnDangoBrawlBackpackModified));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBenchModified, new Action<EDangoBrawlModifyType, int>(this.OnDangoBrawlBenchModified));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnDangoBrawlBagUpdated));
		}

		// Token: 0x060312AE RID: 201390 RVA: 0x00B67754 File Offset: 0x00B65954
		protected override void OnRelease(HotKeyMap config)
		{
			DangoBrawlItemViewRegistry viewRegistry = DangoBrawlModel.Instance.GetViewRegistry();
			UUIItem uuiitem;
			if (viewRegistry == null)
			{
				uuiitem = null;
			}
			else
			{
				DangoBrawlBackpackView backpackView = viewRegistry.GetBackpackView();
				uuiitem = ((backpackView != null) ? backpackView.GetFirstCombineItemRootItem() : null);
			}
			UUIItem uuiitem2 = uuiitem;
			if (uuiitem2 == null || !uuiitem2.IsValid())
			{
				return;
			}
			UiNavigationNewController.Instance.SetNavigationMousePositionForView(uuiitem2);
		}

		// Token: 0x060312AF RID: 201391 RVA: 0x00B6779B File Offset: 0x00B6599B
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			this.RefreshVisibleMode();
		}

		// Token: 0x060312B0 RID: 201392 RVA: 0x00B677A3 File Offset: 0x00B659A3
		private void OnDangoBrawlBackpackModified(EDangoBrawlModifyType modifyType, int uid)
		{
			this.RefreshVisibleMode();
		}

		// Token: 0x060312B1 RID: 201393 RVA: 0x00B677AB File Offset: 0x00B659AB
		private void OnDangoBrawlBenchModified(EDangoBrawlModifyType modifyType, int uid)
		{
			this.RefreshVisibleMode();
		}

		// Token: 0x060312B2 RID: 201394 RVA: 0x00B677B3 File Offset: 0x00B659B3
		private void OnDangoBrawlBagUpdated()
		{
			this.RefreshVisibleMode();
		}

		// Token: 0x060312B3 RID: 201395 RVA: 0x00B677BC File Offset: 0x00B659BC
		private void RefreshVisibleMode()
		{
			ActivityDangoBrawlController instance = ActivityDangoBrawlController.Instance;
			ActivityDangoBrawlData activityDangoBrawlData = (instance != null) ? instance.MyActivityData : null;
			bool isActive = activityDangoBrawlData != null && DangoBrawlCombineUtil.GetCombineDataListAll(activityDangoBrawlData, this.SourceKinds, 0).Length != 0;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, isActive, false);
		}

		// Token: 0x0401A4E9 RID: 107753
		private EDragSourceKind[] SourceKinds = new EDragSourceKind[]
		{
			EDragSourceKind.Bag,
			EDragSourceKind.Bench
		};
	}
}
