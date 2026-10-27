using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity
{
	// Token: 0x020061AD RID: 25005
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityRogueController : ActivityControllerBase
	{
		// Token: 0x0603F264 RID: 258660 RVA: 0x00F414CB File Offset: 0x00F3F6CB
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0603F265 RID: 258661 RVA: 0x00F414D0 File Offset: 0x00F3F6D0
		protected override void OnOpenView(ActivityBaseData data)
		{
			if (this.GetFunctionTypeById(data.Id).GetValueOrDefault() != ERogueFunctionType.View)
			{
				return;
			}
			this.ActivityFunctionExecute(data.Id);
		}

		// Token: 0x0603F266 RID: 258662 RVA: 0x00F41504 File Offset: 0x00F3F704
		private ERogueFunctionType? GetFunctionTypeById(int activityId)
		{
			ActivityRogueConfig instance = ActivityRogueConfig.Instance;
			RogueActivity? rogueActivity = (instance != null) ? instance.GetActivityUniversalConfig(activityId) : null;
			if (rogueActivity == null)
			{
				return null;
			}
			return new ERogueFunctionType?((ERogueFunctionType)rogueActivity.Value.FunctionType);
		}

		// Token: 0x0603F267 RID: 258663 RVA: 0x00F41554 File Offset: 0x00F3F754
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			ActivityRogueConfig instance = ActivityRogueConfig.Instance;
			RogueActivity? rogueActivity = (instance != null) ? instance.GetActivityUniversalConfig(data.Id) : null;
			if (rogueActivity == null)
			{
				return "UiItem_ActivityRouge";
			}
			return rogueActivity.Value.ActivityResource;
		}

		// Token: 0x0603F268 RID: 258664 RVA: 0x00F4159F File Offset: 0x00F3F79F
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewRogue();
		}

		// Token: 0x0603F269 RID: 258665 RVA: 0x00F415A6 File Offset: 0x00F3F7A6
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new ActivityRogueData();
		}

		// Token: 0x0603F26A RID: 258666 RVA: 0x00F415B9 File Offset: 0x00F3F7B9
		protected override bool OnInit()
		{
			this.RegisterOpenViewFunc();
			return true;
		}

		// Token: 0x0603F26B RID: 258667 RVA: 0x00F415C2 File Offset: 0x00F3F7C2
		protected override bool OnClear()
		{
			this.OpenViewFuncMap.Clear();
			return true;
		}

		// Token: 0x0603F26C RID: 258668 RVA: 0x00F415D0 File Offset: 0x00F3F7D0
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x0603F26D RID: 258669 RVA: 0x00F415EE File Offset: 0x00F3F7EE
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x0603F26E RID: 258670 RVA: 0x00F4160C File Offset: 0x00F3F80C
		private void OnQuestStateChange(int questId, QuestState state, EQuestStatusUpdateReason _)
		{
			foreach (ActivityBaseData activityBaseData in ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.RougeActivity))
			{
				ActivityRogueData activityRogueData = activityBaseData as ActivityRogueData;
				if (activityRogueData != null)
				{
					activityRogueData.OnQuestStateChange(questId, state);
				}
			}
		}

		// Token: 0x0603F26F RID: 258671 RVA: 0x00F41670 File Offset: 0x00F3F870
		[NullableContext(2)]
		public ActivityRogueData GetCurrentActivityData()
		{
			ActivityRogueData activityRogueData = ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityRogueData;
			if (activityRogueData == null)
			{
				return null;
			}
			return activityRogueData;
		}

		// Token: 0x0603F270 RID: 258672 RVA: 0x00F41699 File Offset: 0x00F3F899
		public void RefreshActivityRedDot()
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}

		// Token: 0x0603F271 RID: 258673 RVA: 0x00F416B4 File Offset: 0x00F3F8B4
		public void ActivityFunctionExecute(int activityId)
		{
			ActivityRogueConfig instance = ActivityRogueConfig.Instance;
			RogueActivity? rogueActivity = (instance != null) ? instance.GetActivityUniversalConfig(activityId) : null;
			if (rogueActivity == null)
			{
				return;
			}
			string[] array = rogueActivity.Value.FunctionParams();
			List<string> list = (array != null) ? new List<string>(array) : new List<string>();
			switch (rogueActivity.Value.FunctionType)
			{
			case 0:
				break;
			case 1:
			{
				int? questId = null;
				if (list != null && list.Count >= 1)
				{
					questId = new int?(int.Parse(list[0]));
				}
				this.FunctionExecuteQuest(questId);
				return;
			}
			case 2:
				if (list.Count >= 1)
				{
					EUiViewName viewName = (EUiViewName)list[0];
					List<string> params_ = (list.Count > 1) ? list.GetRange(1, list.Count - 1) : new List<string>();
					this.FunctionExecuteView(viewName, params_);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x0603F272 RID: 258674 RVA: 0x00F417A0 File Offset: 0x00F3F9A0
		private void FunctionExecuteQuest(int? questId)
		{
			UiManager.Instance.OpenView(EUiViewName.QuestView, questId, null);
		}

		// Token: 0x0603F273 RID: 258675 RVA: 0x00F417B8 File Offset: 0x00F3F9B8
		private void FunctionExecuteView(EUiViewName viewName, [Nullable(new byte[]
		{
			2,
			1
		})] List<string> params_)
		{
			Action<string[]> action;
			if (this.OpenViewFuncMap.TryGetValue(viewName, out action))
			{
				action((params_ != null && params_.Count > 0) ? params_.ToArray() : null);
				return;
			}
			UiManager.Instance.OpenView(viewName, (params_ != null) ? params_.ToArray() : null, null);
		}

		// Token: 0x0603F274 RID: 258676 RVA: 0x00F41809 File Offset: 0x00F3FA09
		private void RegisterOpenViewFunc()
		{
			this.OpenViewFuncMap[EUiViewName.WorldMapView] = new Action<string[]>(this.OpenWorldMapView);
			this.OpenViewFuncMap[EUiViewName.RoguelikeActivityView] = new Action<string[]>(this.OpenRoguelikeActivityView);
		}

		// Token: 0x0603F275 RID: 258677 RVA: 0x00F41844 File Offset: 0x00F3FA44
		private void OpenWorldMapView([Nullable(new byte[]
		{
			2,
			1
		})] string[] params_)
		{
			int? num = (params_ != null && params_.Length >= 1) ? new int?(int.Parse(params_[0])) : null;
			if (num != null && !MapModel.Instance.IsConfigMarkIdUnlock(num.Value))
			{
				GenericPromptController.Instance.ShowPromptByCode("FunctionDisable", Array.Empty<object>());
				return;
			}
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = ((params_ != null && params_.Length >= 1) ? new int?(int.Parse(params_[0])) : null),
				MarkType = EMarkType.None,
				OpenFogId = new int?(0)
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
		}

		// Token: 0x0603F276 RID: 258678 RVA: 0x00F418F2 File Offset: 0x00F3FAF2
		private void OpenRoguelikeActivityView([Nullable(new byte[]
		{
			2,
			1
		})] string[] params_)
		{
			RoguelikeController.Instance.OpenRoguelikeActivityView().Forget<bool>();
		}

		// Token: 0x1700920A RID: 37386
		// (get) Token: 0x0603F277 RID: 258679 RVA: 0x00F41903 File Offset: 0x00F3FB03
		public static ActivityRogueController Instance
		{
			get
			{
				return ActivityRogueController._Instance;
			}
		}

		// Token: 0x0603F278 RID: 258680 RVA: 0x00F4190A File Offset: 0x00F3FB0A
		public static ActivityRogueController GetOrCreateInstance()
		{
			if (ActivityRogueController._Instance == null)
			{
				ActivityRogueController.CreateInstance();
			}
			return ActivityRogueController._Instance;
		}

		// Token: 0x0603F279 RID: 258681 RVA: 0x00F4191E File Offset: 0x00F3FB1E
		public static bool CreateInstance()
		{
			if (ActivityRogueController._Instance != null)
			{
				return true;
			}
			ActivityRogueController._Instance = new ActivityRogueController();
			return true;
		}

		// Token: 0x0603F27A RID: 258682 RVA: 0x00F41934 File Offset: 0x00F3FB34
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603F27B RID: 258683 RVA: 0x00F41936 File Offset: 0x00F3FB36
		public static void ResetStaticDefaultValue()
		{
			ActivityRogueController._Instance = null;
		}

		// Token: 0x0603F27C RID: 258684 RVA: 0x00F4193E File Offset: 0x00F3FB3E
		static ActivityRogueController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRogueController.CreateStaticDefaultValue), new Action(ActivityRogueController.ResetStaticDefaultValue));
		}

		// Token: 0x04020EA8 RID: 134824
		public int ActivityId;

		// Token: 0x04020EA9 RID: 134825
		[Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})]
		public Dictionary<EUiViewName, Action<string[]>> OpenViewFuncMap = new Dictionary<EUiViewName, Action<string[]>>();

		// Token: 0x04020EAA RID: 134826
		[Nullable(2)]
		private static ActivityRogueController _Instance;
	}
}
