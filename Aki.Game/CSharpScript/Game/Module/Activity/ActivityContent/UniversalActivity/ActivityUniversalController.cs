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
	// Token: 0x02004F69 RID: 20329
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityUniversalController : ActivityControllerBase
	{
		// Token: 0x0603305F RID: 208991 RVA: 0x00E4CEB1 File Offset: 0x00E4B0B1
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06033060 RID: 208992 RVA: 0x00E4CEB4 File Offset: 0x00E4B0B4
		protected override void OnOpenView(ActivityBaseData data)
		{
			if (this.GetFunctionTypeById(data.Id).GetValueOrDefault() != EActivityFunctionType.View)
			{
				return;
			}
			this.ActivityFunctionExecute(data.Id);
		}

		// Token: 0x06033061 RID: 208993 RVA: 0x00E4CEE8 File Offset: 0x00E4B0E8
		private EActivityFunctionType? GetFunctionTypeById(int activityId)
		{
			UniversalActivity? activityUniversalConfig = ActivityUniversalConfig.Instance.GetActivityUniversalConfig(activityId);
			if (activityUniversalConfig == null)
			{
				return null;
			}
			return new EActivityFunctionType?((EActivityFunctionType)activityUniversalConfig.Value.FunctionType);
		}

		// Token: 0x06033062 RID: 208994 RVA: 0x00E4CF28 File Offset: 0x00E4B128
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			UniversalActivity? activityUniversalConfig = ActivityUniversalConfig.Instance.GetActivityUniversalConfig(data.Id);
			if (activityUniversalConfig == null)
			{
				return "";
			}
			return activityUniversalConfig.Value.UiResource;
		}

		// Token: 0x06033063 RID: 208995 RVA: 0x00E4CF64 File Offset: 0x00E4B164
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewUniversal();
		}

		// Token: 0x06033064 RID: 208996 RVA: 0x00E4CF6B File Offset: 0x00E4B16B
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.UniversalActivityIdSet.Add(data.Id);
			return new ActivityUniversalData();
		}

		// Token: 0x06033065 RID: 208997 RVA: 0x00E4CF84 File Offset: 0x00E4B184
		protected override bool OnInit()
		{
			this.RegisterOpenViewFunc();
			return true;
		}

		// Token: 0x06033066 RID: 208998 RVA: 0x00E4CF8D File Offset: 0x00E4B18D
		protected override bool OnClear()
		{
			this.UniversalActivityIdSet.Clear();
			this.OpenViewFuncMap.Clear();
			return true;
		}

		// Token: 0x06033067 RID: 208999 RVA: 0x00E4CFA8 File Offset: 0x00E4B1A8
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
					EUiViewName viewName = (EUiViewName)array[0];
					string[] array2 = new string[array.Length - 1];
					Array.Copy(array, 1, array2, 0, array2.Length);
					this.FunctionExecuteView(viewName, array2);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06033068 RID: 209000 RVA: 0x00E4D053 File Offset: 0x00E4B253
		private void FunctionExecuteQuest(int? questId = null)
		{
			UiManager.Instance.OpenView(EUiViewName.QuestView, questId, null);
		}

		// Token: 0x06033069 RID: 209001 RVA: 0x00E4D06C File Offset: 0x00E4B26C
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

		// Token: 0x0603306A RID: 209002 RVA: 0x00E4D09E File Offset: 0x00E4B29E
		private void RegisterOpenViewFunc()
		{
			this.OpenViewFuncMap.Add(EUiViewName.WorldMapView, new Action<string[]>(this.OpenWorldMapView));
			this.OpenViewFuncMap.Add(EUiViewName.RoguelikeActivityView, new Action<string[]>(this.OpenRoguelikeActivityView));
		}

		// Token: 0x0603306B RID: 209003 RVA: 0x00E4D0D8 File Offset: 0x00E4B2D8
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

		// Token: 0x0603306C RID: 209004 RVA: 0x00E4D17A File Offset: 0x00E4B37A
		private void OpenRoguelikeActivityView([Nullable(new byte[]
		{
			2,
			1
		})] string[] params_)
		{
			RoguelikeController.Instance.OpenRoguelikeActivityView();
		}

		// Token: 0x170063B1 RID: 25521
		// (get) Token: 0x0603306D RID: 209005 RVA: 0x00E4D187 File Offset: 0x00E4B387
		public static ActivityUniversalController Instance
		{
			get
			{
				return ActivityUniversalController._Instance;
			}
		}

		// Token: 0x0603306E RID: 209006 RVA: 0x00E4D18E File Offset: 0x00E4B38E
		public static ActivityUniversalController GetOrCreateInstance()
		{
			if (ActivityUniversalController._Instance == null)
			{
				ActivityUniversalController.CreateInstance();
			}
			return ActivityUniversalController._Instance;
		}

		// Token: 0x0603306F RID: 209007 RVA: 0x00E4D1A2 File Offset: 0x00E4B3A2
		public static bool CreateInstance()
		{
			if (ActivityUniversalController._Instance != null)
			{
				return true;
			}
			ActivityUniversalController._Instance = new ActivityUniversalController();
			return true;
		}

		// Token: 0x06033070 RID: 209008 RVA: 0x00E4D1B8 File Offset: 0x00E4B3B8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033071 RID: 209009 RVA: 0x00E4D1BA File Offset: 0x00E4B3BA
		public static void ResetStaticDefaultValue()
		{
			ActivityUniversalController._Instance = null;
		}

		// Token: 0x06033072 RID: 209010 RVA: 0x00E4D1C2 File Offset: 0x00E4B3C2
		static ActivityUniversalController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityUniversalController.CreateStaticDefaultValue), new Action(ActivityUniversalController.ResetStaticDefaultValue));
		}

		// Token: 0x0401B148 RID: 110920
		public HashSet<int> UniversalActivityIdSet = new HashSet<int>();

		// Token: 0x0401B149 RID: 110921
		[Nullable(new byte[]
		{
			1,
			1,
			2,
			1
		})]
		public Dictionary<EUiViewName, Action<string[]>> OpenViewFuncMap = new Dictionary<EUiViewName, Action<string[]>>();

		// Token: 0x0401B14A RID: 110922
		[Nullable(2)]
		private static ActivityUniversalController _Instance;
	}
}
