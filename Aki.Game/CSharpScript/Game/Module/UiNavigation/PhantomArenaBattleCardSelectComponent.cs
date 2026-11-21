using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003921 RID: 14625
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleCardSelectComponent : PhantomArenaBattleComponentBase
	{
		// Token: 0x06025CA2 RID: 154786 RVA: 0x00A9F0AC File Offset: 0x00A9D2AC
		public PhantomArenaBattleCardSelectComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025CA3 RID: 154787 RVA: 0x00A9F0B8 File Offset: 0x00A9D2B8
		protected override void OnPress(HotKeyMap _)
		{
			if (base.Proxy == null)
			{
				return;
			}
			if (base.Proxy.GamepadLogic.IsInCardSelectState)
			{
				this.PutDownCardToFunctional().Forget();
				return;
			}
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			NavigationSelectableBase navigationSelectableBase = (currentNavigationFocusListener != null) ? currentNavigationFocusListener.GetNavigationComponent() : null;
			if (navigationSelectableBase == null)
			{
				return;
			}
			if (navigationSelectableBase.GetType() == ENavigationSelectableDefine.PhantomArenaOwnHandToggle)
			{
				this.SelectHandCard(navigationSelectableBase).Forget();
				return;
			}
			if (navigationSelectableBase.GetType() == ENavigationSelectableDefine.PhantomArenaOwnBattleToggle)
			{
				this.SelectBattleCard(navigationSelectableBase).Forget();
			}
		}

		// Token: 0x06025CA4 RID: 154788 RVA: 0x00A9F134 File Offset: 0x00A9D334
		private UniTask PutDownCardToFunctional()
		{
			PhantomArenaBattleCardSelectComponent.<PutDownCardToFunctional>d__2 <PutDownCardToFunctional>d__;
			<PutDownCardToFunctional>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PutDownCardToFunctional>d__.<>4__this = this;
			<PutDownCardToFunctional>d__.<>1__state = -1;
			<PutDownCardToFunctional>d__.<>t__builder.Start<PhantomArenaBattleCardSelectComponent.<PutDownCardToFunctional>d__2>(ref <PutDownCardToFunctional>d__);
			return <PutDownCardToFunctional>d__.<>t__builder.Task;
		}

		// Token: 0x06025CA5 RID: 154789 RVA: 0x00A9F178 File Offset: 0x00A9D378
		private UniTask SelectHandCard(NavigationSelectableBase navigationComponent)
		{
			PhantomArenaBattleCardSelectComponent.<SelectHandCard>d__3 <SelectHandCard>d__;
			<SelectHandCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SelectHandCard>d__.<>4__this = this;
			<SelectHandCard>d__.navigationComponent = navigationComponent;
			<SelectHandCard>d__.<>1__state = -1;
			<SelectHandCard>d__.<>t__builder.Start<PhantomArenaBattleCardSelectComponent.<SelectHandCard>d__3>(ref <SelectHandCard>d__);
			return <SelectHandCard>d__.<>t__builder.Task;
		}

		// Token: 0x06025CA6 RID: 154790 RVA: 0x00A9F1C4 File Offset: 0x00A9D3C4
		private UniTask SelectBattleCard(NavigationSelectableBase navigationComponent)
		{
			PhantomArenaBattleCardSelectComponent.<SelectBattleCard>d__4 <SelectBattleCard>d__;
			<SelectBattleCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SelectBattleCard>d__.navigationComponent = navigationComponent;
			<SelectBattleCard>d__.<>1__state = -1;
			<SelectBattleCard>d__.<>t__builder.Start<PhantomArenaBattleCardSelectComponent.<SelectBattleCard>d__4>(ref <SelectBattleCard>d__);
			return <SelectBattleCard>d__.<>t__builder.Task;
		}

		// Token: 0x06025CA7 RID: 154791 RVA: 0x00A9F208 File Offset: 0x00A9D408
		[NullableContext(2)]
		private TsUiNavigationBehaviorListener GetOwnBattleSlotListenerByIndex(int index)
		{
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			NavigationGroup navigationGroup = (currentNavigationFocusListener != null) ? currentNavigationFocusListener.GetNavigationGroup() : null;
			if (navigationGroup == null)
			{
				return null;
			}
			List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in navigationGroup.ListenerList)
			{
				if (tsUiNavigationBehaviorListener.GetNavigationComponent().GetType() == ENavigationSelectableDefine.PhantomArenaOwnBattleToggle)
				{
					list.Add(tsUiNavigationBehaviorListener);
				}
			}
			if (index >= list.Count)
			{
				return null;
			}
			return list[index];
		}

		// Token: 0x06025CA8 RID: 154792 RVA: 0x00A9F2A0 File Offset: 0x00A9D4A0
		[NullableContext(2)]
		private TsUiNavigationBehaviorListener GetOwnHandCardListenerByIndex(int index)
		{
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			NavigationGroup navigationGroup = (currentNavigationFocusListener != null) ? currentNavigationFocusListener.GetNavigationGroup() : null;
			if (navigationGroup == null)
			{
				return null;
			}
			List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in navigationGroup.ListenerList)
			{
				if (tsUiNavigationBehaviorListener.GetNavigationComponent().GetType() == ENavigationSelectableDefine.PhantomArenaOwnHandToggle)
				{
					list.Add(tsUiNavigationBehaviorListener);
				}
			}
			if (index >= list.Count)
			{
				return null;
			}
			return list[index];
		}
	}
}
