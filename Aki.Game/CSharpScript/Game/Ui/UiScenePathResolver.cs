using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200359D RID: 13725
	public class UiScenePathResolver : IStaticVariableResetter
	{
		// Token: 0x06022FA6 RID: 143270 RVA: 0x009F3950 File Offset: 0x009F1B50
		static UiScenePathResolver()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiScenePathResolver.CreateStaticDefaultValue), new Action(UiScenePathResolver.ResetStaticDefaultValue));
		}

		// Token: 0x170048C4 RID: 18628
		// (get) Token: 0x06022FA7 RID: 143271 RVA: 0x009F396F File Offset: 0x009F1B6F
		[Nullable(1)]
		public static Dictionary<EUiViewName, EUiViewName> UiViewToRootViewForUiScene
		{
			[NullableContext(1)]
			get
			{
				return UiScenePathResolver._uiViewToRootViewForUiScene;
			}
		}

		// Token: 0x06022FA8 RID: 143272 RVA: 0x009F3978 File Offset: 0x009F1B78
		public static void CreateStaticDefaultValue()
		{
			UiScenePathResolver._uiViewToRootViewForUiScene = new Dictionary<EUiViewName, EUiViewName>
			{
				{
					EUiViewName.RoleBreachView,
					EUiViewName.RoleRootView
				},
				{
					EUiViewName.RoleSkillView,
					EUiViewName.RoleRootView
				},
				{
					EUiViewName.RoleBreachSuccessView,
					EUiViewName.RoleRootView
				},
				{
					EUiViewName.RoleElementView,
					EUiViewName.RoleRootView
				},
				{
					EUiViewName.RoleAttributeDetailView,
					EUiViewName.RoleRootView
				},
				{
					EUiViewName.RoleLevelUpView,
					EUiViewName.RoleRootView
				},
				{
					EUiViewName.RoleFavorInfoView,
					EUiViewName.RoleRootView
				},
				{
					EUiViewName.RoleSelectionView,
					EUiViewName.RoleRootView
				},
				{
					EUiViewName.PhantomBattleFettersView,
					EUiViewName.RoleRootView
				},
				{
					EUiViewName.RoleDevRootView,
					EUiViewName.RoleRootView
				},
				{
					EUiViewName.RoleSkillMergeView,
					EUiViewName.RoleRootView
				},
				{
					EUiViewName.RoleDevelopRootView,
					EUiViewName.RoleRootView
				},
				{
					EUiViewName.WeaponReplaceView,
					EUiViewName.WeaponRootView
				},
				{
					EUiViewName.WeaponBreachSuccessView,
					EUiViewName.WeaponRootView
				},
				{
					EUiViewName.WeaponResonanceSuccessView,
					EUiViewName.WeaponRootView
				},
				{
					EUiViewName.SkinRootView,
					EUiViewName.WeaponRootView
				},
				{
					EUiViewName.VisionRecoveryResultView,
					EUiViewName.CalabashRootView
				},
				{
					EUiViewName.VisionRecoveryBatchResultView,
					EUiViewName.CalabashRootView
				},
				{
					EUiViewName.VisionRefineResultView,
					EUiViewName.CalabashRootView
				},
				{
					EUiViewName.VisionRefineSubResultView,
					EUiViewName.CalabashRootView
				},
				{
					EUiViewName.GachaScanView,
					EUiViewName.DrawMainView
				},
				{
					EUiViewName.WeeklyRogueAttributeDetailView,
					EUiViewName.WeeklyRogueInfo
				},
				{
					EUiViewName.PhantomManageConfigView,
					EUiViewName.CalabashRootView
				},
				{
					EUiViewName.SurvivorsAttributeDetailView,
					EUiViewName.SurvivorsHandbookView
				},
				{
					EUiViewName.MotorcycleTechTreeDetailView,
					EUiViewName.MotorcycleRootView
				},
				{
					EUiViewName.MotorcycleTechTreeLevelDetailView,
					EUiViewName.MotorcycleRootView
				},
				{
					EUiViewName.MotorcycleLevelAttrDetailView,
					EUiViewName.MotorcycleRootView
				},
				{
					EUiViewName.MotorcycleConditionView,
					EUiViewName.MotorcycleRootView
				},
				{
					EUiViewName.MotorcycleLevelUpView,
					EUiViewName.MotorcycleRootView
				},
				{
					EUiViewName.MotorcycleDiyRootView,
					EUiViewName.MotorcycleRootView
				},
				{
					EUiViewName.MotorcycleDiyEditRootView,
					EUiViewName.MotorcycleRootView
				},
				{
					EUiViewName.MotorcycleDiyEditOverviewView,
					EUiViewName.MotorcycleRootView
				},
				{
					EUiViewName.MotorcycleDiyImportPresetView,
					EUiViewName.MotorcycleRootView
				},
				{
					EUiViewName.MotorcycleDiyOverviewView,
					EUiViewName.MotorcycleRootView
				},
				{
					EUiViewName.MotorcycleDiySkinView,
					EUiViewName.MotorcycleRootView
				},
				{
					EUiViewName.MotorcycleScenePopupView,
					EUiViewName.MotorcycleRootView
				},
				{
					EUiViewName.TeamSceneRoleSelectView,
					EUiViewName.Formation3DView
				}
			};
		}

		// Token: 0x06022FA9 RID: 143273 RVA: 0x009F3BDF File Offset: 0x009F1DDF
		public static void ResetStaticDefaultValue()
		{
			UiScenePathResolver._uiViewToRootViewForUiScene = null;
		}

		// Token: 0x04013B95 RID: 80789
		[Nullable(2)]
		private static Dictionary<EUiViewName, EUiViewName> _uiViewToRootViewForUiScene;
	}
}
