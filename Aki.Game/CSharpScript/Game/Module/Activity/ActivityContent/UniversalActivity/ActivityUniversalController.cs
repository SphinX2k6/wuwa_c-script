using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalActivity
{
	// Token: 0x02005F82 RID: 24450
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityUniversalController : ActivityControllerBase
	{
		// Token: 0x0603E0C5 RID: 254149 RVA: 0x00EFB1D1 File Offset: 0x00EF93D1
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x0603E0C6 RID: 254150 RVA: 0x00EFB1D4 File Offset: 0x00EF93D4
		protected override void OnOpenView(ActivityBaseData data)
		{
			if (this.GetFunctionTypeById(data.Id).GetValueOrDefault() != EActivityFunctionType.View)
			{
				return;
			}
			this.ActivityFunctionExecute(data.Id);
		}

		// Token: 0x0603E0C7 RID: 254151 RVA: 0x00EFB208 File Offset: 0x00EF9408
		private EActivityFunctionType? GetFunctionTypeById(int activityId)
		{
			UniversalActivity? activityUniversalConfig = ActivityUniversalConfig.Instance.GetActivityUniversalConfig(activityId);
			if (activityUniversalConfig == null)
			{
				return null;
			}
			return new EActivityFunctionType?((EActivityFunctionType)activityUniversalConfig.Value.FunctionType);
		}

		// Token: 0x0603E0C8 RID: 254152 RVA: 0x00EFB248 File Offset: 0x00EF9448
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			UniversalActivity? activityUniversalConfig = ActivityUniversalConfig.Instance.GetActivityUniversalConfig(data.Id);
			if (activityUniversalConfig == null)
			{
				return "";
			}
			return activityUniversalConfig.Value.UiResource;
		}

		// Token: 0x0603E0C9 RID: 254153 RVA: 0x00EFB284 File Offset: 0x00EF9484
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewUniversal();
		}

		// Token: 0x0603E0CA RID: 254154 RVA: 0x00EFB28B File Offset: 0x00EF948B
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.UniversalActivityIdSet.Add(data.Id);
			return new ActivityUniversalData();
		}

		// Token: 0x0603E0CB RID: 254155 RVA: 0x00EFB2A4 File Offset: 0x00EF94A4
		protected override bool OnInit()
		{
			this.RegisterOpenViewFunc();
			return true;
		}

		// Token: 0x0603E0CC RID: 254156 RVA: 0x00EFB2AD File Offset: 0x00EF94AD
		protected override bool OnClear()
		{
			this.UniversalActivityIdSet.Clear();
			this.OpenViewFuncMap.Clear();
			return true;
		}

		// Token: 0x0603E0CD RID: 254157 RVA: 0x00EFB2C8 File Offset: 0x00EF94C8
		public void ActivityFunctionExecute(int activityId)
		{
			UniversalActivity? activityUniversalConfig = ActivityUniversalConfig.Instance.GetActivityUniversalConfig(activityId);
			if (activityUniversalConfig == null)
			{
				return;
			}
			UniversalActivity value = activityUniversalConfig.Value;
			string[] array = value.FunctionParams();
			switch (value.FunctionType)
			{
			case 0:
				break;
			case 1:
			{
				int? questId = null;
				if (array != null && array.Length >= 1)
				{
					questId = new int?(int.Parse(array[0]));
				}
				this.FunctionExecuteQuest(questId);
				return;
			}
			case 2:
				if (array.Length >= 1)
				{
					EUiViewName viewName = (EUiViewName)Enum.Parse(typeof(EUiViewName), array[0]);
					string[] array2 = new string[array.Length - 1];
					Array.Copy(array, 1, array2, 0, array2.Length);
					this.FunctionExecuteView(viewName, array2);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x0603E0CE RID: 254158 RVA: 0x00EFB382 File Offset: 0x00EF9582
		private void FunctionExecuteQuest(int? questId = null)
		{
			UiManager.Instance.OpenView(EUiViewName.QuestView, questId, null);
		}

		// Token: 0x0603E0CF RID: 254159 RVA: 0x00EFB39C File Offset: 0x00EF959C
		private void FunctionExecuteView(EUiViewName viewName, [Nullable(new byte[]
		{
			2,
			1
		})] string[] params_ = null)
		{
			Action<string[]> action;
			if (this.OpenViewFuncMap.TryGetValue(viewName, out action))
			{
				action(params_);
				return;
			}
			UiManager.Instance.OpenView(viewName, params_, null);
		}

		// Token: 0x0603E0D0 RID: 254160 RVA: 0x00EFB3CE File Offset: 0x00EF95CE
		private void RegisterOpenViewFunc()
		{
			this.OpenViewFuncMap.Add(EUiViewName.WorldMapView, new Action<string[]>(this.OpenWorldMapView));
			this.OpenViewFuncMap.Add(EUiViewName.RoguelikeActivityView, new Action<string[]>(this.OpenRoguelikeActivityView));
		}

		// Token: 0x0603E0D1 RID: 254161 RVA: 0x00EFB408 File Offset: 0x00EF9608
		private void OpenWorldMapView([Nullable(new byte[]
		{
			2,
			1
		})] string[] params_)
		{
			int? num = (params_ != null) ? new int?(int.Parse(params_[0])) : null;
			if (num != null && !MapModel.Instance.IsConfigMarkIdUnlock(num.Value))
			{
				GenericPromptController.Instance.ShowPromptByCode("FunctionDisable", Array.Empty<object>());
				return;
			}
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = ((params_ != null) ? new int?(int.Parse(params_[0])) : null),
				MarkType = EMarkType.None,
				OpenFogId = new int?(0)
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
		}

		// Token: 0x0603E0D2 RID: 254162 RVA: 0x00EFB4AA File Offset: 0x00EF96AA
		private void OpenRoguelikeActivityView([Nullable(new byte[]
		{
			2,
			1
		})] string[] params_)
		{
			RoguelikeController.Instance.OpenRoguelikeActivityView();
		}

		// Token: 0x17008FDF RID: 36831
		// (get) Token: 0x0603E0D3 RID: 254163 RVA: 0x00EFB4B7 File Offset: 0x00EF96B7
		public static ActivityUniversalController Instance
		{
			get
			{
				return ActivityUniversalController._Instance;
			}
		}

		// Token: 0x0603E0D4 RID: 254164 RVA: 0x00EFB4BE File Offset: 0x00EF96BE
		public static ActivityUniversalController GetOrCreateInstance()
		{
			if (ActivityUniversalController._Instance == null)
			{
				ActivityUniversalController.CreateInstance();
			}
			return ActivityUniversalController._Instance;
		}

		// Token: 0x0603E0D5 RID: 254165 RVA: 0x00EFB4D2 File Offset: 0x00EF96D2
		public static bool CreateInstance()
		{
			if (ActivityUniversalController._Instance != null)
			{
				return true;
			}
			ActivityUniversalController._Instance = new ActivityUniversalController();
			return true;
		}

		// Token: 0x0603E0D6 RID: 254166 RVA: 0x00EFB4E8 File Offset: 0x00EF96E8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E0D7 RID: 254167 RVA: 0x00EFB4EA File Offset: 0x00EF96EA
		public static void ResetStaticDefaultValue()
		{
			ActivityUniversalController._Instance = null;
		}

		// Token: 0x0603E0D8 RID: 254168 RVA: 0x00EFB4F2 File Offset: 0x00EF96F2
		static ActivityUniversalController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityUniversalController.CreateStaticDefaultValue), new Action(ActivityUniversalController.ResetStaticDefaultValue));
		}

		// Token: 0x04020676 RID: 132726
		public HashSet<int> UniversalActivityIdSet = new HashSet<int>();

		// Token: 0x04020677 RID: 132727
		[Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})]
		public Dictionary<EUiViewName, Action<string[]>> OpenViewFuncMap = new Dictionary<EUiViewName, Action<string[]>>();

		// Token: 0x04020678 RID: 132728
		[Nullable(2)]
		private static ActivityUniversalController _Instance;
	}
}
