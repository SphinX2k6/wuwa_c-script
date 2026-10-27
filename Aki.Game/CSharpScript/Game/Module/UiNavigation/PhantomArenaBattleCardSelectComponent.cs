using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049A7 RID: 18855
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleCardSelectComponent : PhantomArenaBattleComponentBase
	{
		// Token: 0x0603116C RID: 201068 RVA: 0x00B6415C File Offset: 0x00B6235C
		public PhantomArenaBattleCardSelectComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x0603116D RID: 201069 RVA: 0x00B64168 File Offset: 0x00B62368
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

		// Token: 0x0603116E RID: 201070 RVA: 0x00B641E4 File Offset: 0x00B623E4
		private UniTask PutDownCardToFunctional()
		{
			PhantomArenaBattleCardSelectComponent.<PutDownCardToFunctional>d__2 <PutDownCardToFunctional>d__;
			<PutDownCardToFunctional>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PutDownCardToFunctional>d__.<>4__this = this;
			<PutDownCardToFunctional>d__.<>1__state = -1;
			<PutDownCardToFunctional>d__.<>t__builder.Start<PhantomArenaBattleCardSelectComponent.<PutDownCardToFunctional>d__2>(ref <PutDownCardToFunctional>d__);
			return <PutDownCardToFunctional>d__.<>t__builder.Task;
		}

		// Token: 0x0603116F RID: 201071 RVA: 0x00B64228 File Offset: 0x00B62428
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

		// Token: 0x06031170 RID: 201072 RVA: 0x00B64274 File Offset: 0x00B62474
		private UniTask SelectBattleCard(NavigationSelectableBase navigationComponent)
		{
			PhantomArenaBattleCardSelectComponent.<SelectBattleCard>d__4 <SelectBattleCard>d__;
			<SelectBattleCard>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SelectBattleCard>d__.navigationComponent = navigationComponent;
			<SelectBattleCard>d__.<>1__state = -1;
			<SelectBattleCard>d__.<>t__builder.Start<PhantomArenaBattleCardSelectComponent.<SelectBattleCard>d__4>(ref <SelectBattleCard>d__);
			return <SelectBattleCard>d__.<>t__builder.Task;
		}

		// Token: 0x06031171 RID: 201073 RVA: 0x00B642B8 File Offset: 0x00B624B8
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

		// Token: 0x06031172 RID: 201074 RVA: 0x00B64350 File Offset: 0x00B62550
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
