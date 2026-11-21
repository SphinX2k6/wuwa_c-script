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
	// Token: 0x0200389A RID: 14490
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPhantomArenaOwnBattleToggle : NavigationButton
	{
		// Token: 0x060259CB RID: 154059 RVA: 0x00A96216 File Offset: 0x00A94416
		public NavigationPhantomArenaOwnBattleToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x17004D34 RID: 19764
		// (get) Token: 0x060259CC RID: 154060 RVA: 0x00A96224 File Offset: 0x00A94424
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

		// Token: 0x060259CD RID: 154061 RVA: 0x00A96266 File Offset: 0x00A94466
		protected override void OnButtonClick()
		{
		}

		// Token: 0x060259CE RID: 154062 RVA: 0x00A96268 File Offset: 0x00A94468
		protected override bool OnCheckFindOpposite()
		{
			return this.Proxy == null || !this.Proxy.SkillTriggerMask.IsInSkillInteract || this.IsInSkillInteract;
		}

		// Token: 0x060259CF RID: 154063 RVA: 0x00A96290 File Offset: 0x00A94490
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

		// Token: 0x060259D0 RID: 154064 RVA: 0x00A96314 File Offset: 0x00A94514
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

		// Token: 0x060259D1 RID: 154065 RVA: 0x00A96358 File Offset: 0x00A94558
		public void SwitchBattleCardTips()
		{
			if (this.Proxy != null)
			{
				int index = int.Parse(this.ParamList[0]);
				this.Proxy.GamepadLogic.SwitchOwnBattleCardTips(index);
			}
		}

		// Token: 0x17004D35 RID: 19765
		// (get) Token: 0x060259D2 RID: 154066 RVA: 0x00A96390 File Offset: 0x00A94590
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

		// Token: 0x04014C51 RID: 85073
		protected PhantomArenaBattleProxy ProxyInternal;
	}
}
