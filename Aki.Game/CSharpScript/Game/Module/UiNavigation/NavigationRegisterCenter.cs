using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.UiNavigation.New.PhantomArena;
using CSharpScript.Game.Module.UiNavigation.New.Vision;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020048F7 RID: 18679
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationRegisterCenter : IStaticVariableResetter
	{
		// Token: 0x06030D89 RID: 200073 RVA: 0x00B57C9E File Offset: 0x00B55E9E
		static NavigationRegisterCenter()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(NavigationRegisterCenter.CreateStaticDefaultValue), new Action(NavigationRegisterCenter.ResetStaticDefaultValue));
		}

		// Token: 0x170079BD RID: 31165
		// (get) Token: 0x06030D8A RID: 200074 RVA: 0x00B57CBD File Offset: 0x00B55EBD
		private static Dictionary<ENavigationSelectableDefine, Type> SelectableCtorMap
		{
			get
			{
				return NavigationRegisterCenter._selectableCtorMap;
			}
		}

		// Token: 0x170079BE RID: 31166
		// (get) Token: 0x06030D8B RID: 200075 RVA: 0x00B57CC4 File Offset: 0x00B55EC4
		private static Dictionary<ESpecialPanelHandleDefine, Type> PanelHandleCtorMap
		{
			get
			{
				return NavigationRegisterCenter._panelHandleCtorMap;
			}
		}

		// Token: 0x06030D8C RID: 200076 RVA: 0x00B57CCB File Offset: 0x00B55ECB
		public static void Init()
		{
			NavigationRegisterCenter.RegisterNavigationComponent();
			NavigationRegisterCenter.RegisterNavigationSpecialPanelHandle();
		}

		// Token: 0x06030D8D RID: 200077 RVA: 0x00B57CD8 File Offset: 0x00B55ED8
		private static void RegisterNavigationComponent()
		{
			foreach (KeyValuePair<ENavigationSelectableDefine, Type> keyValuePair in NavigationRegisterCenter.SelectableCtorMap)
			{
				NavigationSelectableCreator.RegisterNavigationBehavior(keyValuePair.Key.ToString(), keyValuePair.Value);
			}
		}

		// Token: 0x06030D8E RID: 200078 RVA: 0x00B57D44 File Offset: 0x00B55F44
		private static void RegisterNavigationSpecialPanelHandle()
		{
			foreach (KeyValuePair<ESpecialPanelHandleDefine, Type> keyValuePair in NavigationRegisterCenter.PanelHandleCtorMap)
			{
				NavigationPanelHandleCreator.RegisterSpecialPanelHandle(keyValuePair.Key.ToString(), keyValuePair.Value);
			}
		}

		// Token: 0x06030D8F RID: 200079 RVA: 0x00B57DB0 File Offset: 0x00B55FB0
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

		// Token: 0x06030D90 RID: 200080 RVA: 0x00B58200 File Offset: 0x00B56400
		public static void ResetStaticDefaultValue()
		{
			NavigationRegisterCenter._selectableCtorMap = null;
			NavigationRegisterCenter._panelHandleCtorMap = null;
		}

		// Token: 0x0401A3AE RID: 107438
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<ENavigationSelectableDefine, Type> _selectableCtorMap;

		// Token: 0x0401A3AF RID: 107439
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static Dictionary<ESpecialPanelHandleDefine, Type> _panelHandleCtorMap;
	}
}
