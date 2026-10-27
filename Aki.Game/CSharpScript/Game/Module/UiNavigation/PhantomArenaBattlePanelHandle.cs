using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048FF RID: 18687
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattlePanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x06030DB4 RID: 200116 RVA: 0x00B58920 File Offset: 0x00B56B20
		public PhantomArenaBattlePanelHandle(string type) : base(type)
		{
		}

		// Token: 0x170079C1 RID: 31169
		// (get) Token: 0x06030DB5 RID: 200117 RVA: 0x00B5892C File Offset: 0x00B56B2C
		private PhantomArenaBattleProxy Proxy
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

		// Token: 0x06030DB6 RID: 200118 RVA: 0x00B58970 File Offset: 0x00B56B70
		protected override List<TsUiNavigationBehaviorListener> OnGetSuitableNavigationListenerList(bool isDefault)
		{
			if (this.Proxy == null)
			{
				return new List<TsUiNavigationBehaviorListener>();
			}
			if (this.Proxy.SkillTriggerMask.IsInSkillInteract)
			{
				return this.GetListenerListBySkillInteract();
			}
			if (this.Proxy.IsInPanelInteract)
			{
				return this.GetListenerListByPanelInteract();
			}
			if (PhantomArenaBattleModel.Instance.OwnData.GetHandCardIdList().Count == 0)
			{
				return this.GetListenerListByBattle();
			}
			return this.GetListenerListByHand();
		}

		// Token: 0x06030DB7 RID: 200119 RVA: 0x00B589DC File Offset: 0x00B56BDC
		private List<TsUiNavigationBehaviorListener> GetListenerListBySkillInteract()
		{
			List<TsUiNavigationBehaviorListener> navigationListenerListByTypeList = this.GetNavigationListenerListByTypeList(new ENavigationSelectableDefine[]
			{
				ENavigationSelectableDefine.PhantomArenaOpponentBattleToggle,
				ENavigationSelectableDefine.PhantomArenaOwnBattleToggle
			}, "GroupTarget");
			if (navigationListenerListByTypeList == null)
			{
				return new List<TsUiNavigationBehaviorListener>();
			}
			List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in navigationListenerListByTypeList)
			{
				NavigationSelectableBase navigationComponent = tsUiNavigationBehaviorListener.GetNavigationComponent();
				ENavigationSelectableDefine type = navigationComponent.GetType();
				if (type == ENavigationSelectableDefine.PhantomArenaOpponentBattleToggle)
				{
					NavigationPhantomArenaOpponentBattleToggle navigationPhantomArenaOpponentBattleToggle = navigationComponent as NavigationPhantomArenaOpponentBattleToggle;
					if (navigationPhantomArenaOpponentBattleToggle != null && navigationPhantomArenaOpponentBattleToggle.IsInSkillInteract)
					{
						list.Add(tsUiNavigationBehaviorListener);
					}
				}
				else if (type == ENavigationSelectableDefine.PhantomArenaOwnBattleToggle)
				{
					NavigationPhantomArenaOwnBattleToggle navigationPhantomArenaOwnBattleToggle = navigationComponent as NavigationPhantomArenaOwnBattleToggle;
					if (navigationPhantomArenaOwnBattleToggle != null && navigationPhantomArenaOwnBattleToggle.IsInSkillInteract)
					{
						list.Add(tsUiNavigationBehaviorListener);
					}
				}
			}
			return list;
		}

		// Token: 0x06030DB8 RID: 200120 RVA: 0x00B58AA8 File Offset: 0x00B56CA8
		private List<TsUiNavigationBehaviorListener> GetListenerListByPanelInteract()
		{
			if (this.Proxy == null)
			{
				return new List<TsUiNavigationBehaviorListener>();
			}
			if (!this.Proxy.IsMainInVisible)
			{
				return new List<TsUiNavigationBehaviorListener>();
			}
			return this.GetNavigationListenerListByType(ENavigationSelectableDefine.PhantomArenaOwnBattleToggle, "GroupNor");
		}

		// Token: 0x06030DB9 RID: 200121 RVA: 0x00B58AD8 File Offset: 0x00B56CD8
		private List<TsUiNavigationBehaviorListener> GetListenerListByBattle()
		{
			return this.GetNavigationListenerListByType(ENavigationSelectableDefine.PhantomArenaOwnBattleToggle, "GroupNor");
		}

		// Token: 0x06030DBA RID: 200122 RVA: 0x00B58AE7 File Offset: 0x00B56CE7
		private List<TsUiNavigationBehaviorListener> GetListenerListByHand()
		{
			return this.GetNavigationListenerListByType(ENavigationSelectableDefine.PhantomArenaOwnHandToggle, "GroupNor");
		}

		// Token: 0x06030DBB RID: 200123 RVA: 0x00B58AF8 File Offset: 0x00B56CF8
		public List<TsUiNavigationBehaviorListener> GetNavigationListenerListByType(ENavigationSelectableDefine type, string groupName = "GroupNor")
		{
			NavigationGroup navigationGroup = base.GetNavigationGroup(groupName);
			if (navigationGroup == null)
			{
				return new List<TsUiNavigationBehaviorListener>();
			}
			List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in navigationGroup.ListenerList)
			{
				if (tsUiNavigationBehaviorListener.GetNavigationComponent().GetType() == type)
				{
					list.Add(tsUiNavigationBehaviorListener);
				}
			}
			return list;
		}

		// Token: 0x06030DBC RID: 200124 RVA: 0x00B58B74 File Offset: 0x00B56D74
		public List<TsUiNavigationBehaviorListener> GetNavigationListenerListByTypeList(ENavigationSelectableDefine[] typeList, string groupName)
		{
			NavigationGroup navigationGroup = base.GetNavigationGroup(groupName);
			if (navigationGroup == null)
			{
				return new List<TsUiNavigationBehaviorListener>();
			}
			List<TsUiNavigationBehaviorListener> list = new List<TsUiNavigationBehaviorListener>();
			foreach (TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener in navigationGroup.ListenerList)
			{
				ENavigationSelectableDefine type = tsUiNavigationBehaviorListener.GetNavigationComponent().GetType();
				if (Array.IndexOf<ENavigationSelectableDefine>(typeList, type) >= 0)
				{
					list.Add(tsUiNavigationBehaviorListener);
				}
			}
			return list;
		}

		// Token: 0x0401A3BA RID: 107450
		private PhantomArenaBattleProxy ProxyInternal;
	}
}
