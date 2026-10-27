using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004921 RID: 18721
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPhantomArenaOpponentBattleToggle : NavigationButton
	{
		// Token: 0x06030E92 RID: 200338 RVA: 0x00B5B1FC File Offset: 0x00B593FC
		public NavigationPhantomArenaOpponentBattleToggle(ULGUIBehaviour selectable, string type, List<string> paramList) : base(selectable, type, paramList)
		{
		}

		// Token: 0x170079C9 RID: 31177
		// (get) Token: 0x06030E93 RID: 200339 RVA: 0x00B5B208 File Offset: 0x00B59408
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

		// Token: 0x06030E94 RID: 200340 RVA: 0x00B5B24A File Offset: 0x00B5944A
		protected override void OnButtonClick()
		{
		}

		// Token: 0x06030E95 RID: 200341 RVA: 0x00B5B24C File Offset: 0x00B5944C
		protected override void OnNotifyFocusListener(bool isSameListener)
		{
			if (this.Proxy != null && !isSameListener)
			{
				this.Proxy.GamepadLogic.HideCardTips();
			}
		}

		// Token: 0x06030E96 RID: 200342 RVA: 0x00B5B269 File Offset: 0x00B59469
		protected override bool OnCheckFindOpposite()
		{
			return this.Proxy == null || (!this.Proxy.GamepadLogic.IsInCardSelectState && (!this.Proxy.SkillTriggerMask.IsInSkillInteract || this.IsInSkillInteract));
		}

		// Token: 0x06030E97 RID: 200343 RVA: 0x00B5B2A4 File Offset: 0x00B594A4
		public void SwitchBattleCardTips()
		{
			if (this.Proxy != null)
			{
				int index = int.Parse(this.ParamList[0]);
				this.Proxy.GamepadLogic.SwitchOpponentBattleCardTips(index);
			}
		}

		// Token: 0x170079CA RID: 31178
		// (get) Token: 0x06030E98 RID: 200344 RVA: 0x00B5B2DC File Offset: 0x00B594DC
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

		// Token: 0x0401A3DC RID: 107484
		protected PhantomArenaBattleProxy ProxyInternal;
	}
}
