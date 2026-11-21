using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003934 RID: 14644
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardTakeComponent : HotKeyComponent
	{
		// Token: 0x06025CEF RID: 154863 RVA: 0x00A9FA70 File Offset: 0x00A9DC70
		public RewardTakeComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CF0 RID: 154864 RVA: 0x00A9FA7C File Offset: 0x00A9DC7C
		public void SetDataCallback(Func<object> callback)
		{
			this.LastNotTakenFunc = (() => (int)callback());
		}

		// Token: 0x06025CF1 RID: 154865 RVA: 0x00A9FAA8 File Offset: 0x00A9DCA8
		protected override void OnPress(HotKeyMap config)
		{
			if (this.Listener != null)
			{
				UUIItem uiItem = this.Listener.GetBehaviorComponent().RootUIComp.Get();
				UiNavigationNewController.Instance.SimulateClickItem(uiItem, null);
			}
		}

		// Token: 0x06025CF2 RID: 154866 RVA: 0x00A9FAEC File Offset: 0x00A9DCEC
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			string bindButtonTag = base.GetBindButtonTag();
			if (string.IsNullOrEmpty(bindButtonTag))
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			int num = (this.LastNotTakenFunc != null) ? this.LastNotTakenFunc() : 0;
			if (num <= 0)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				return;
			}
			if (this.IndexReward <= 0)
			{
				base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, false, false);
				List<TsUiNavigationBehaviorListener> activeListenerListByTag = viewHandle.GetActiveListenerListByTag(bindButtonTag);
				if (activeListenerListByTag.Count <= 0)
				{
					return;
				}
				for (int i = 0; i < activeListenerListByTag.Count; i++)
				{
					TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = activeListenerListByTag[i];
					AActor owner = tsUiNavigationBehaviorListener.GetOwner();
					if (base.IsLinkListener(owner))
					{
						this.IndexReward = i + 1;
						this.Listener = tsUiNavigationBehaviorListener;
						break;
					}
				}
			}
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, this.IndexReward == num, false);
		}

		// Token: 0x06025CF3 RID: 154867 RVA: 0x00A9FBAC File Offset: 0x00A9DDAC
		protected override void OnClear()
		{
			base.OnClear();
			this.LastNotTakenFunc = null;
			this.IndexReward = 0;
			this.Listener = null;
		}

		// Token: 0x04014D2F RID: 85295
		private int IndexReward;

		// Token: 0x04014D30 RID: 85296
		[Nullable(2)]
		private TsUiNavigationBehaviorListener Listener;

		// Token: 0x04014D31 RID: 85297
		[Nullable(2)]
		private RewardTakeDataCallback LastNotTakenFunc;
	}
}
