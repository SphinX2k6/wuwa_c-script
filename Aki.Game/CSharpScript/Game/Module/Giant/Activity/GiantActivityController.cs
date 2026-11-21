using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Giant.Activity
{
	// Token: 0x02004966 RID: 18790
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class GiantActivityController : ActivityControllerBase
	{
		// Token: 0x0602F1EC RID: 193004 RVA: 0x00D232A0 File Offset: 0x00D214A0
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

		// Token: 0x0602F1ED RID: 193005 RVA: 0x00D232D0 File Offset: 0x00D214D0
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

		// Token: 0x0602F1EE RID: 193006 RVA: 0x00D23335 File Offset: 0x00D21535
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_GiantSystemEntrance";
		}

		// Token: 0x0602F1EF RID: 193007 RVA: 0x00D2333C File Offset: 0x00D2153C
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new GiantActivitySubView();
		}

		// Token: 0x0602F1F0 RID: 193008 RVA: 0x00D23343 File Offset: 0x00D21543
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.Data = new GiantActivityData();
			return this.Data;
		}

		// Token: 0x0602F1F1 RID: 193009 RVA: 0x00D23356 File Offset: 0x00D21556
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x17005F3F RID: 24383
		// (get) Token: 0x0602F1F2 RID: 193010 RVA: 0x00D23359 File Offset: 0x00D21559
		public static GiantActivityController Instance
		{
			get
			{
				return GiantActivityController._Instance;
			}
		}

		// Token: 0x0602F1F3 RID: 193011 RVA: 0x00D23360 File Offset: 0x00D21560
		public static GiantActivityController GetOrCreateInstance()
		{
			if (GiantActivityController._Instance == null)
			{
				GiantActivityController.CreateInstance();
			}
			return GiantActivityController._Instance;
		}

		// Token: 0x0602F1F4 RID: 193012 RVA: 0x00D23374 File Offset: 0x00D21574
		public static bool CreateInstance()
		{
			if (GiantActivityController._Instance != null)
			{
				return true;
			}
			GiantActivityController._Instance = new GiantActivityController();
			return true;
		}

		// Token: 0x0602F1F5 RID: 193013 RVA: 0x00D2338A File Offset: 0x00D2158A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602F1F6 RID: 193014 RVA: 0x00D2338C File Offset: 0x00D2158C
		public static void ResetStaticDefaultValue()
		{
			GiantActivityController._Instance = null;
		}

		// Token: 0x0602F1F7 RID: 193015 RVA: 0x00D23394 File Offset: 0x00D21594
		static GiantActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GiantActivityController.CreateStaticDefaultValue), new Action(GiantActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x04019037 RID: 102455
		[Nullable(2)]
		private GiantActivityData Data;

		// Token: 0x04019038 RID: 102456
		[Nullable(2)]
		private static GiantActivityController _Instance;
	}
}
