using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200466C RID: 18028
	public class UiScenePathResolver : IStaticVariableResetter
	{
		// Token: 0x0602E85C RID: 190556 RVA: 0x00AC5DF1 File Offset: 0x00AC3FF1
		static UiScenePathResolver()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UiScenePathResolver.CreateStaticDefaultValue), new Action(UiScenePathResolver.ResetStaticDefaultValue));
		}

		// Token: 0x17007608 RID: 30216
		// (get) Token: 0x0602E85D RID: 190557 RVA: 0x00AC5E10 File Offset: 0x00AC4010
		[Nullable(1)]
		public static Dictionary<EUiViewName, EUiViewName> UiViewToRootViewForUiScene
		{
			[NullableContext(1)]
			get
			{
				return UiScenePathResolver._uiViewToRootViewForUiScene;
			}
		}

		// Token: 0x0602E85E RID: 190558 RVA: 0x00AC5E18 File Offset: 0x00AC4018
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

		// Token: 0x0602E85F RID: 190559 RVA: 0x00AC607F File Offset: 0x00AC427F
		public static void ResetStaticDefaultValue()
		{
			UiScenePathResolver._uiViewToRootViewForUiScene = null;
		}

		// Token: 0x040194EE RID: 103662
		[Nullable(2)]
		private static Dictionary<EUiViewName, EUiViewName> _uiViewToRootViewForUiScene;
	}
}
