using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02003974 RID: 14708
	[NullableContext(1)]
	[Nullable(0)]
	public class DangobrawlJumpQucikCombineComponent : HotKeyComponent
	{
		// Token: 0x06025DE1 RID: 155105 RVA: 0x00AA262A File Offset: 0x00AA082A
		public DangobrawlJumpQucikCombineComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025DE2 RID: 155106 RVA: 0x00AA2648 File Offset: 0x00AA0848
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBackpackModified, new Action<EDangoBrawlModifyType, int>(this.OnDangoBrawlBackpackModified));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBenchModified, new Action<EDangoBrawlModifyType, int>(this.OnDangoBrawlBenchModified));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnDangoBrawlBagUpdated));
		}

		// Token: 0x06025DE3 RID: 155107 RVA: 0x00AA26AC File Offset: 0x00AA08AC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBackpackModified, new Action<EDangoBrawlModifyType, int>(this.OnDangoBrawlBackpackModified));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBenchModified, new Action<EDangoBrawlModifyType, int>(this.OnDangoBrawlBenchModified));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnDangoBrawlBagUpdated));
		}

		// Token: 0x06025DE4 RID: 155108 RVA: 0x00AA2710 File Offset: 0x00AA0910
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

		// Token: 0x06025DE5 RID: 155109 RVA: 0x00AA2757 File Offset: 0x00AA0957
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			this.RefreshVisibleMode();
		}

		// Token: 0x06025DE6 RID: 155110 RVA: 0x00AA275F File Offset: 0x00AA095F
		private void OnDangoBrawlBackpackModified(EDangoBrawlModifyType modifyType, int uid)
		{
			this.RefreshVisibleMode();
		}

		// Token: 0x06025DE7 RID: 155111 RVA: 0x00AA2767 File Offset: 0x00AA0967
		private void OnDangoBrawlBenchModified(EDangoBrawlModifyType modifyType, int uid)
		{
			this.RefreshVisibleMode();
		}

		// Token: 0x06025DE8 RID: 155112 RVA: 0x00AA276F File Offset: 0x00AA096F
		private void OnDangoBrawlBagUpdated()
		{
			this.RefreshVisibleMode();
		}

		// Token: 0x06025DE9 RID: 155113 RVA: 0x00AA2778 File Offset: 0x00AA0978
		private void RefreshVisibleMode()
		{
			ActivityDangoBrawlController instance = ActivityDangoBrawlController.Instance;
			ActivityDangoBrawlData activityDangoBrawlData = (instance != null) ? instance.MyActivityData : null;
			bool isActive = activityDangoBrawlData != null && DangoBrawlCombineUtil.GetCombineDataListAll(activityDangoBrawlData, this.SourceKinds, 0).Length != 0;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, isActive, false);
		}

		// Token: 0x04014D5B RID: 85339
		private EDragSourceKind[] SourceKinds = new EDragSourceKind[]
		{
			EDragSourceKind.Bag,
			EDragSourceKind.Bench
		};
	}
}
