using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003898 RID: 14488
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPhantomArenaOpponentBattleToggle : NavigationButton
	{
		// Token: 0x060259BF RID: 154047 RVA: 0x00A9606C File Offset: 0x00A9426C
		public NavigationPhantomArenaOpponentBattleToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x17004D31 RID: 19761
		// (get) Token: 0x060259C0 RID: 154048 RVA: 0x00A96078 File Offset: 0x00A94278
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

		// Token: 0x060259C1 RID: 154049 RVA: 0x00A960BA File Offset: 0x00A942BA
		protected override void OnButtonClick()
		{
		}

		// Token: 0x060259C2 RID: 154050 RVA: 0x00A960BC File Offset: 0x00A942BC
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.GamepadLogic.HideCardTips();
			}
		}

		// Token: 0x060259C3 RID: 154051 RVA: 0x00A960D9 File Offset: 0x00A942D9
		protected override bool OnCheckFindOpposite()
		{
			return this.Proxy == null || (!this.Proxy.GamepadLogic.IsInCardSelectState && (!this.Proxy.SkillTriggerMask.IsInSkillInteract || this.IsInSkillInteract));
		}

		// Token: 0x060259C4 RID: 154052 RVA: 0x00A96114 File Offset: 0x00A94314
		public void SwitchBattleCardTips()
		{
			if (this.Proxy != null)
			{
				int index = int.Parse(this.ParamList[0]);
				this.Proxy.GamepadLogic.SwitchOpponentBattleCardTips(index);
			}
		}

		// Token: 0x17004D32 RID: 19762
		// (get) Token: 0x060259C5 RID: 154053 RVA: 0x00A9614C File Offset: 0x00A9434C
		public bool IsInSkillInteract
		{
			get
			{
				if (this.Proxy != null)
				{
					int index = int.Parse(this.ParamList[0]);
					return this.Proxy.GamepadLogic.IsInSkillInteractByOpponentIndex(index);
				}
				return false;
			}
		}

		// Token: 0x04014C4F RID: 85071
		protected PhantomArenaBattleProxy ProxyInternal;
	}
}
