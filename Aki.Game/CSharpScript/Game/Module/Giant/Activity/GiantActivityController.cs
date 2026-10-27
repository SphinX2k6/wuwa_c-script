using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Giant.Activity
{
	// Token: 0x0200598D RID: 22925
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class GiantActivityController : ActivityControllerBase
	{
		// Token: 0x0603A2C6 RID: 238278 RVA: 0x00DD3E10 File Offset: 0x00DD2010
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			if (viewName != EUiViewName.GiantSystemMainView || this.Data == null)
			{
				return UniTask.FromResult<bool>(false);
			}
			this.OnOpenView(this.Data);
			return UniTask.FromResult<bool>(true);
		}

		// Token: 0x0603A2C7 RID: 238279 RVA: 0x00DD3E40 File Offset: 0x00DD2040
		protected override void OnOpenView(ActivityBaseData data)
		{
			if (!data.GetPreGuideQuestFinishState())
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, data.GetUnFinishPreGuideQuestId(), null);
				return;
			}
			EventSystem.Instance.Emit<bool>(EEventName.ChangeActivityViewNeedBlurState, false);
			IGiantSystemMainOpenParam param = new GiantSystemMainOpenParam
			{
				ActivityId = data.Id
			};
			UiManager.Instance.OpenView(EUiViewName.GiantSystemMainView, param, null);
		}

		// Token: 0x0603A2C8 RID: 238280 RVA: 0x00DD3EA5 File Offset: 0x00DD20A5
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_GiantSystemEntrance";
		}

		// Token: 0x0603A2C9 RID: 238281 RVA: 0x00DD3EAC File Offset: 0x00DD20AC
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new GiantActivitySubView();
		}

		// Token: 0x0603A2CA RID: 238282 RVA: 0x00DD3EB3 File Offset: 0x00DD20B3
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.Data = new GiantActivityData();
			return this.Data;
		}

		// Token: 0x0603A2CB RID: 238283 RVA: 0x00DD3EC6 File Offset: 0x00DD20C6
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x17008B72 RID: 35698
		// (get) Token: 0x0603A2CC RID: 238284 RVA: 0x00DD3EC9 File Offset: 0x00DD20C9
		public static GiantActivityController Instance
		{
			get
			{
				return GiantActivityController._Instance;
			}
		}

		// Token: 0x0603A2CD RID: 238285 RVA: 0x00DD3ED0 File Offset: 0x00DD20D0
		public static GiantActivityController GetOrCreateInstance()
		{
			if (GiantActivityController._Instance == null)
			{
				GiantActivityController.CreateInstance();
			}
			return GiantActivityController._Instance;
		}

		// Token: 0x0603A2CE RID: 238286 RVA: 0x00DD3EE4 File Offset: 0x00DD20E4
		public static bool CreateInstance()
		{
			if (GiantActivityController._Instance != null)
			{
				return true;
			}
			GiantActivityController._Instance = new GiantActivityController();
			return true;
		}

		// Token: 0x0603A2CF RID: 238287 RVA: 0x00DD3EFA File Offset: 0x00DD20FA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603A2D0 RID: 238288 RVA: 0x00DD3EFC File Offset: 0x00DD20FC
		public static void ResetStaticDefaultValue()
		{
			GiantActivityController._Instance = null;
		}

		// Token: 0x0603A2D1 RID: 238289 RVA: 0x00DD3F04 File Offset: 0x00DD2104
		static GiantActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GiantActivityController.CreateStaticDefaultValue), new Action(GiantActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E599 RID: 124313
		[Nullable(2)]
		private GiantActivityData Data;

		// Token: 0x0401E59A RID: 124314
		[Nullable(2)]
		private static GiantActivityController _Instance;
	}
}
