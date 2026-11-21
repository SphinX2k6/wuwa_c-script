using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003876 RID: 14454
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattlePanelHandle : SpecialPanelHandleBase
	{
		// Token: 0x060258E1 RID: 153825 RVA: 0x00A93790 File Offset: 0x00A91990
		public PhantomArenaBattlePanelHandle(string type) : base(type)
		{
		}

		// Token: 0x17004D29 RID: 19753
		// (get) Token: 0x060258E2 RID: 153826 RVA: 0x00A9379C File Offset: 0x00A9199C
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

		// Token: 0x060258E3 RID: 153827 RVA: 0x00A937E0 File Offset: 0x00A919E0
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

		// Token: 0x060258E4 RID: 153828 RVA: 0x00A9384C File Offset: 0x00A91A4C
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

		// Token: 0x060258E5 RID: 153829 RVA: 0x00A93918 File Offset: 0x00A91B18
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

		// Token: 0x060258E6 RID: 153830 RVA: 0x00A93948 File Offset: 0x00A91B48
		private List<TsUiNavigationBehaviorListener> GetListenerListByBattle()
		{
			return this.GetNavigationListenerListByType(ENavigationSelectableDefine.PhantomArenaOwnBattleToggle, "GroupNor");
		}

		// Token: 0x060258E7 RID: 153831 RVA: 0x00A93957 File Offset: 0x00A91B57
		private List<TsUiNavigationBehaviorListener> GetListenerListByHand()
		{
			return this.GetNavigationListenerListByType(ENavigationSelectableDefine.PhantomArenaOwnHandToggle, "GroupNor");
		}

		// Token: 0x060258E8 RID: 153832 RVA: 0x00A93968 File Offset: 0x00A91B68
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

		// Token: 0x060258E9 RID: 153833 RVA: 0x00A939E4 File Offset: 0x00A91BE4
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

		// Token: 0x04014C2D RID: 85037
		private PhantomArenaBattleProxy ProxyInternal;
	}
}
