using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004923 RID: 18723
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPhantomArenaOwnBattleToggle : NavigationButton
	{
		// Token: 0x06030E9E RID: 200350 RVA: 0x00B5B3A6 File Offset: 0x00B595A6
		public NavigationPhantomArenaOwnBattleToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x170079CC RID: 31180
		// (get) Token: 0x06030E9F RID: 200351 RVA: 0x00B5B3B4 File Offset: 0x00B595B4
		protected PhantomArenaBattleProxy Proxy
		{
			get
			{
				if (this.ProxyInternal == null)
				{
					UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.PhantomArenaBattleView);
					this.ProxyInternal = (((viewByName != null) ? viewByName.OpenParam : null) as PhantomArenaBattleProxy);
				}
				return this.ProxyInternal;
			}
		}

		// Token: 0x06030EA0 RID: 200352 RVA: 0x00B5B3F6 File Offset: 0x00B595F6
		protected override void OnButtonClick()
		{
		}

		// Token: 0x06030EA1 RID: 200353 RVA: 0x00B5B3F8 File Offset: 0x00B595F8
		protected override bool OnCheckFindOpposite()
		{
			return this.Proxy == null || !this.Proxy.SkillTriggerMask.IsInSkillInteract || this.IsInSkillInteract;
		}

		// Token: 0x06030EA2 RID: 200354 RVA: 0x00B5B420 File Offset: 0x00B59620
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			int index = int.Parse(this.ParamList[0]);
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.GamepadLogic.HideCardTips();
				if (this.Proxy.GamepadLogic.IsInHandCardSelectState)
				{
					this.Proxy.GamepadLogic.MoveHandCardToFunctional(index);
					return;
				}
				if (this.Proxy.GamepadLogic.IsInBattleCardSelectState)
				{
					this.Proxy.GamepadLogic.MoveBattleCardToFunctional(index);
				}
			}
		}

		// Token: 0x06030EA3 RID: 200355 RVA: 0x00B5B4A4 File Offset: 0x00B596A4
		[NullableContext(0)]
		public UniTask<bool> TriggerSelectCard()
		{
			NavigationPhantomArenaOwnBattleToggle.<TriggerSelectCard>d__7 <TriggerSelectCard>d__;
			<TriggerSelectCard>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TriggerSelectCard>d__.<>4__this = this;
			<TriggerSelectCard>d__.<>1__state = -1;
			<TriggerSelectCard>d__.<>t__builder.Start<NavigationPhantomArenaOwnBattleToggle.<TriggerSelectCard>d__7>(ref <TriggerSelectCard>d__);
			return <TriggerSelectCard>d__.<>t__builder.Task;
		}

		// Token: 0x06030EA4 RID: 200356 RVA: 0x00B5B4E8 File Offset: 0x00B596E8
		public void SwitchBattleCardTips()
		{
			if (this.Proxy != null)
			{
				int index = int.Parse(this.ParamList[0]);
				this.Proxy.GamepadLogic.SwitchOwnBattleCardTips(index);
			}
		}

		// Token: 0x170079CD RID: 31181
		// (get) Token: 0x06030EA5 RID: 200357 RVA: 0x00B5B520 File Offset: 0x00B59720
		public bool IsInSkillInteract
		{
			get
			{
				if (this.Proxy != null)
				{
					int index = int.Parse(this.ParamList[0]);
					return this.Proxy.GamepadLogic.IsInSkillInteractByOwnIndex(index);
				}
				return false;
			}
		}

		// Token: 0x0401A3DE RID: 107486
		protected PhantomArenaBattleProxy ProxyInternal;
	}
}
