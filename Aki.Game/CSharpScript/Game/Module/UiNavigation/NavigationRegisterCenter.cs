using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.UiNavigation.New.PhantomArena;
using CSharpScript.Game.Module.UiNavigation.New.Vision;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200386E RID: 14446
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationRegisterCenter : IStaticVariableResetter
	{
		// Token: 0x060258B6 RID: 153782 RVA: 0x00A92B0E File Offset: 0x00A90D0E
		static NavigationRegisterCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(NavigationRegisterCenter.CreateStaticDefaultValue), new Action(NavigationRegisterCenter.ResetStaticDefaultValue));
		}

		// Token: 0x17004D25 RID: 19749
		// (get) Token: 0x060258B7 RID: 153783 RVA: 0x00A92B2D File Offset: 0x00A90D2D
		private static Dictionary<ENavigationSelectableDefine, Type> SelectableCtorMap
		{
			get
			{
				return NavigationRegisterCenter._selectableCtorMap;
			}
		}

		// Token: 0x17004D26 RID: 19750
		// (get) Token: 0x060258B8 RID: 153784 RVA: 0x00A92B34 File Offset: 0x00A90D34
		private static Dictionary<ESpecialPanelHandleDefine, Type> PanelHandleCtorMap
		{
			get
			{
				return NavigationRegisterCenter._panelHandleCtorMap;
			}
		}

		// Token: 0x060258B9 RID: 153785 RVA: 0x00A92B3B File Offset: 0x00A90D3B
		public static void Init()
		{
			NavigationRegisterCenter.RegisterNavigationComponent();
			NavigationRegisterCenter.RegisterNavigationSpecialPanelHandle();
		}

		// Token: 0x060258BA RID: 153786 RVA: 0x00A92B48 File Offset: 0x00A90D48
		private static void RegisterNavigationComponent()
		{
			foreach (KeyValuePair<ENavigationSelectableDefine, Type> keyValuePair in NavigationRegisterCenter.SelectableCtorMap)
			{
				NavigationSelectableCreator.RegisterNavigationBehavior(keyValuePair.Key.ToString(), keyValuePair.Value);
			}
		}

		// Token: 0x060258BB RID: 153787 RVA: 0x00A92BB4 File Offset: 0x00A90DB4
		private static void RegisterNavigationSpecialPanelHandle()
		{
			foreach (KeyValuePair<ESpecialPanelHandleDefine, Type> keyValuePair in NavigationRegisterCenter.PanelHandleCtorMap)
			{
				NavigationPanelHandleCreator.RegisterSpecialPanelHandle(keyValuePair.Key.ToString(), keyValuePair.Value);
			}
		}

		// Token: 0x060258BC RID: 153788 RVA: 0x00A92C20 File Offset: 0x00A90E20
		public static void CreateStaticDefaultValue()
		{
			NavigationRegisterCenter._selectableCtorMap = new Dictionary<ENavigationSelectableDefine, Type>
			{
				{
					ENavigationSelectableDefine.Button,
					typeof(NavigationButton)
				},
				{
					ENavigationSelectableDefine.Toggle,
					typeof(NavigationToggle)
				},
				{
					ENavigationSelectableDefine.Scrollbar,
					typeof(NavigationScrollbar)
				},
				{
					ENavigationSelectableDefine.Slider,
					typeof(NavigationSlider)
				},
				{
					ENavigationSelectableDefine.DragComponent,
					typeof(NavigationDragComponent)
				},
				{
					ENavigationSelectableDefine.Selectable,
					typeof(NavigationSelectable)
				},
				{
					ENavigationSelectableDefine.VisionReplaceViewToggle,
					typeof(NavigationVisionToggle)
				},
				{
					ENavigationSelectableDefine.VisionTabViewToggle,
					typeof(NavigationVisionTabViewToggle)
				},
				{
					ENavigationSelectableDefine.VisionTabViewReplaceButton,
					typeof(NavigationVisionTabViewReplaceButton)
				},
				{
					ENavigationSelectableDefine.FunctionPageButton,
					typeof(NavigationFunctionPageButton)
				},
				{
					ENavigationSelectableDefine.FunctionPageLeftButton,
					typeof(NavigationFunctionPageLeftButton)
				},
				{
					ENavigationSelectableDefine.FunctionPageRightButton,
					typeof(NavigationFunctionPageRightButton)
				},
				{
					ENavigationSelectableDefine.RoleSkillTreeToggle,
					typeof(NavigationRoleSkillTreeToggle)
				},
				{
					ENavigationSelectableDefine.RoleSkillTreeExitButton,
					typeof(NavigationRoleSkillTreeExitButton)
				},
				{
					ENavigationSelectableDefine.RoleSkillPreviewToggle,
					typeof(NavigationRoleSkillPreviewToggle)
				},
				{
					ENavigationSelectableDefine.RoleSkillPreviewExitButton,
					typeof(NavigationRoleSkillPreviewExitButton)
				},
				{
					ENavigationSelectableDefine.RoleResonanceToggle,
					typeof(NavigationRoleResonanceToggle)
				},
				{
					ENavigationSelectableDefine.RoleResonanceLockToggle,
					typeof(NavigationRoleResonanceLockToggle)
				},
				{
					ENavigationSelectableDefine.RoleResonanceExitButton,
					typeof(NavigationRoleResonanceExitButton)
				},
				{
					ENavigationSelectableDefine.InventoryDestroyEnterButton,
					typeof(NavigationInventoryDestroyEnterButton)
				},
				{
					ENavigationSelectableDefine.InventoryDestroyExitButton,
					typeof(NavigationInventoryDestroyExitButton)
				},
				{
					ENavigationSelectableDefine.InventoryItemGridToggle,
					typeof(NavigationInventoryItemGridToggle)
				},
				{
					ENavigationSelectableDefine.RouletteExitButton,
					typeof(NavigationRouletteExitButton)
				},
				{
					ENavigationSelectableDefine.RoguelikeGridToggle,
					typeof(NavigationRoguelikeGridToggle)
				},
				{
					ENavigationSelectableDefine.QuestTitleToggle,
					typeof(NavigationQuestTitleToggle)
				},
				{
					ENavigationSelectableDefine.VisionReplaceSortTabToggle,
					typeof(NavigationVisionReplaceSortTabToggle)
				},
				{
					ENavigationSelectableDefine.CalabashDetailExitBtn,
					typeof(NavigationCalabashDetailExitButton)
				},
				{
					ENavigationSelectableDefine.VisionAssembleToggle,
					typeof(NavigationVisionAssembleToggle)
				},
				{
					ENavigationSelectableDefine.VisionAssembleCompareToggle,
					typeof(NavigationVisionAssembleCompareToggle)
				},
				{
					ENavigationSelectableDefine.CommonRefreshNavigationButton,
					typeof(NavigationCommonRefreshNavigationButton)
				},
				{
					ENavigationSelectableDefine.PhantomArenaOwnHandToggle,
					typeof(NavigationPhantomArenaOwnHandToggle)
				},
				{
					ENavigationSelectableDefine.PhantomArenaOwnBattleToggle,
					typeof(NavigationPhantomArenaOwnBattleToggle)
				},
				{
					ENavigationSelectableDefine.PhantomArenaOwnFunctionalToggle,
					typeof(NavigationPhantomArenaOwnFunctionalToggle)
				},
				{
					ENavigationSelectableDefine.PhantomArenaOpponentBattleToggle,
					typeof(NavigationPhantomArenaOpponentBattleToggle)
				},
				{
					ENavigationSelectableDefine.PhantomArenaOpponentFunctionalToggle,
					typeof(NavigationPhantomArenaOpponentFunctionalToggle)
				},
				{
					ENavigationSelectableDefine.PhantomArenaVisionButton,
					typeof(NavigationPhantomArenaVisionButton)
				},
				{
					ENavigationSelectableDefine.PhantomArenaEmptyButton,
					typeof(NavigationPhantomArenaEmptyButton)
				},
				{
					ENavigationSelectableDefine.PhantomArenaCardToggle,
					typeof(NavigationPhantomArenaCardToggle)
				},
				{
					ENavigationSelectableDefine.PhantomManageConfigGridBig,
					typeof(NavigationPhantomManageConfigGridBig)
				},
				{
					ENavigationSelectableDefine.HonamiStoryGridItem,
					typeof(NavigationHonamiStoryGridItem)
				},
				{
					ENavigationSelectableDefine.CantFocusInScrollOrLayoutByJumpGroup,
					typeof(NavigationCantFocusInScrollOrLayoutByJumpGroupButton)
				},
				{
					ENavigationSelectableDefine.FormationSelectPosition,
					typeof(FormationSelectPositionButton)
				},
				{
					ENavigationSelectableDefine.ReFindMultipleScrollGridToggle,
					typeof(NavigationReFindMultipleScrollGridToggle)
				},
				{
					ENavigationSelectableDefine.NavigationChatTalkToggle,
					typeof(NavigationChatTalkToggle)
				},
				{
					ENavigationSelectableDefine.NavigationChatPhraseToggle,
					typeof(NavigationChatPhraseToggle)
				},
				{
					ENavigationSelectableDefine.NavigationChatTalkPartnerToggle,
					typeof(NavigationChatTalkPartnerToggle)
				}
			};
			NavigationRegisterCenter._panelHandleCtorMap = new Dictionary<ESpecialPanelHandleDefine, Type>
			{
				{
					ESpecialPanelHandleDefine.Default,
					typeof(BasePanelHandle)
				},
				{
					ESpecialPanelHandleDefine.VisionChooseMain,
					typeof(VisionChooseMainPanelHandle)
				},
				{
					ESpecialPanelHandleDefine.FunctionView,
					typeof(FunctionViewPanelHandle)
				},
				{
					ESpecialPanelHandleDefine.RoleSkill,
					typeof(RoleSkillPanelHandle)
				},
				{
					ESpecialPanelHandleDefine.RoleResonance,
					typeof(RoleResonancePanelHandle)
				},
				{
					ESpecialPanelHandleDefine.Inventory,
					typeof(InventoryViewPanelHandle)
				},
				{
					ESpecialPanelHandleDefine.Roulette,
					typeof(RouletteViewPanelHandle)
				},
				{
					ESpecialPanelHandleDefine.ExploreReward,
					typeof(ExploreRewardPanelHandle)
				},
				{
					ESpecialPanelHandleDefine.VisionAssemble,
					typeof(VisionAssemblePanelHandle)
				},
				{
					ESpecialPanelHandleDefine.PhantomArenaBattle,
					typeof(PhantomArenaBattlePanelHandle)
				},
				{
					ESpecialPanelHandleDefine.PhantomManageConfig,
					typeof(PhantomManageConfigPanelHandle)
				},
				{
					ESpecialPanelHandleDefine.HonamiStoryBackpack,
					typeof(HonamiStoryPanelHandle)
				}
			};
		}

		// Token: 0x060258BD RID: 153789 RVA: 0x00A93070 File Offset: 0x00A91270
		public static void ResetStaticDefaultValue()
		{
			NavigationRegisterCenter._selectableCtorMap = null;
			NavigationRegisterCenter._panelHandleCtorMap = null;
		}

		// Token: 0x04014C21 RID: 85025
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<ENavigationSelectableDefine, Type> _selectableCtorMap;

		// Token: 0x04014C22 RID: 85026
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<ESpecialPanelHandleDefine, Type> _panelHandleCtorMap;
	}
}
