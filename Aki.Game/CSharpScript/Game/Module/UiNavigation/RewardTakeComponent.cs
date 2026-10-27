using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049BA RID: 18874
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardTakeComponent : HotKeyComponent
	{
		// Token: 0x060311B9 RID: 201145 RVA: 0x00B64B20 File Offset: 0x00B62D20
		public RewardTakeComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311BA RID: 201146 RVA: 0x00B64B2C File Offset: 0x00B62D2C
		public override void SetDataCallback(Func<object> callback)
		{
			this.LastNotTakenFunc = (() => (int)callback());
		}

		// Token: 0x060311BB RID: 201147 RVA: 0x00B64B58 File Offset: 0x00B62D58
		protected override void OnPress(HotKeyMap config)
		{
			if (this.Listener != null)
			{
				UUIItem uiItem = this.Listener.GetBehaviorComponent().RootUIComp.Get();
				UiNavigationNewController.Instance.SimulateClickItem(uiItem, null);
			}
		}

		// Token: 0x060311BC RID: 201148 RVA: 0x00B64B9C File Offset: 0x00B62D9C
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

		// Token: 0x060311BD RID: 201149 RVA: 0x00B64C5C File Offset: 0x00B62E5C
		protected override void OnClear()
		{
			base.OnClear();
			this.LastNotTakenFunc = null;
			this.IndexReward = 0;
			this.Listener = null;
		}

		// Token: 0x0401A4BD RID: 107709
		private int IndexReward;

		// Token: 0x0401A4BE RID: 107710
		[Nullable(2)]
		private TsUiNavigationBehaviorListener Listener;

		// Token: 0x0401A4BF RID: 107711
		[Nullable(2)]
		private RewardTakeDataCallback LastNotTakenFunc;
	}
}
