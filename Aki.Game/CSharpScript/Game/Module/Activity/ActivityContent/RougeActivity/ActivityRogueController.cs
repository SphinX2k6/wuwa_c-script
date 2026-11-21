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
	// Token: 0x0200512B RID: 20779
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityRogueController : ActivityControllerBase
	{
		// Token: 0x06033F24 RID: 212772 RVA: 0x00E88393 File Offset: 0x00E86593
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06033F25 RID: 212773 RVA: 0x00E88398 File Offset: 0x00E86598
		protected override void OnOpenView(ActivityBaseData data)
		{
			if (this.GetFunctionTypeById(data.Id).GetValueOrDefault() != ERogueFunctionType.View)
			{
				return;
			}
			this.ActivityFunctionExecute(data.Id);
		}

		// Token: 0x06033F26 RID: 212774 RVA: 0x00E883CC File Offset: 0x00E865CC
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

		// Token: 0x06033F27 RID: 212775 RVA: 0x00E8841C File Offset: 0x00E8661C
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

		// Token: 0x06033F28 RID: 212776 RVA: 0x00E88467 File Offset: 0x00E86667
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewRogue();
		}

		// Token: 0x06033F29 RID: 212777 RVA: 0x00E8846E File Offset: 0x00E8666E
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new ActivityRogueData();
		}

		// Token: 0x06033F2A RID: 212778 RVA: 0x00E88481 File Offset: 0x00E86681
		protected override bool OnInit()
		{
			this.RegisterOpenViewFunc();
			return true;
		}

		// Token: 0x06033F2B RID: 212779 RVA: 0x00E8848A File Offset: 0x00E8668A
		protected override bool OnClear()
		{
			this.OpenViewFuncMap.Clear();
			return true;
		}

		// Token: 0x06033F2C RID: 212780 RVA: 0x00E88498 File Offset: 0x00E86698
		protected override void OnAddEvents()
		{
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x06033F2D RID: 212781 RVA: 0x00E884B6 File Offset: 0x00E866B6
		protected override void OnRemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChange));
		}

		// Token: 0x06033F2E RID: 212782 RVA: 0x00E884D4 File Offset: 0x00E866D4
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

		// Token: 0x06033F2F RID: 212783 RVA: 0x00E88538 File Offset: 0x00E86738
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

		// Token: 0x06033F30 RID: 212784 RVA: 0x00E88561 File Offset: 0x00E86761
		public void RefreshActivityRedDot()
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}

		// Token: 0x06033F31 RID: 212785 RVA: 0x00E8857C File Offset: 0x00E8677C
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

		// Token: 0x06033F32 RID: 212786 RVA: 0x00E88668 File Offset: 0x00E86868
		private void FunctionExecuteQuest(int? questId)
		{
			UiManager.Instance.OpenView(EUiViewName.QuestView, questId, null);
		}

		// Token: 0x06033F33 RID: 212787 RVA: 0x00E88680 File Offset: 0x00E86880
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

		// Token: 0x06033F34 RID: 212788 RVA: 0x00E886D1 File Offset: 0x00E868D1
		private void RegisterOpenViewFunc()
		{
			this.OpenViewFuncMap[EUiViewName.WorldMapView] = new Action<string[]>(this.OpenWorldMapView);
			this.OpenViewFuncMap[EUiViewName.RoguelikeActivityView] = new Action<string[]>(this.OpenRoguelikeActivityView);
		}

		// Token: 0x06033F35 RID: 212789 RVA: 0x00E8870C File Offset: 0x00E8690C
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

		// Token: 0x06033F36 RID: 212790 RVA: 0x00E887BA File Offset: 0x00E869BA
		private void OpenRoguelikeActivityView([Nullable(new byte[]
		{
			2,
			1
		})] string[] params_)
		{
			RoguelikeController.Instance.OpenRoguelikeActivityView().Forget<bool>();
		}

		// Token: 0x1700656C RID: 25964
		// (get) Token: 0x06033F37 RID: 212791 RVA: 0x00E887CB File Offset: 0x00E869CB
		public static ActivityRogueController Instance
		{
			get
			{
				return ActivityRogueController._Instance;
			}
		}

		// Token: 0x06033F38 RID: 212792 RVA: 0x00E887D2 File Offset: 0x00E869D2
		public static ActivityRogueController GetOrCreateInstance()
		{
			if (ActivityRogueController._Instance == null)
			{
				ActivityRogueController.CreateInstance();
			}
			return ActivityRogueController._Instance;
		}

		// Token: 0x06033F39 RID: 212793 RVA: 0x00E887E6 File Offset: 0x00E869E6
		public static bool CreateInstance()
		{
			if (ActivityRogueController._Instance != null)
			{
				return true;
			}
			ActivityRogueController._Instance = new ActivityRogueController();
			return true;
		}

		// Token: 0x06033F3A RID: 212794 RVA: 0x00E887FC File Offset: 0x00E869FC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033F3B RID: 212795 RVA: 0x00E887FE File Offset: 0x00E869FE
		public static void ResetStaticDefaultValue()
		{
			ActivityRogueController._Instance = null;
		}

		// Token: 0x06033F3C RID: 212796 RVA: 0x00E88806 File Offset: 0x00E86A06
		static ActivityRogueController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRogueController.CreateStaticDefaultValue), new Action(ActivityRogueController.ResetStaticDefaultValue));
		}

		// Token: 0x0401B7D5 RID: 112597
		public int ActivityId;

		// Token: 0x0401B7D6 RID: 112598
		[Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})]
		public Dictionary<EUiViewName, Action<string[]>> OpenViewFuncMap = new Dictionary<EUiViewName, Action<string[]>>();

		// Token: 0x0401B7D7 RID: 112599
		[Nullable(2)]
		private static ActivityRogueController _Instance;
	}
}
