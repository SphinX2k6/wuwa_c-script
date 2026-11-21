using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity
{
	// Token: 0x02005698 RID: 22168
	[NullableContext(1)]
	[Nullable(0)]
	public class DirectTrainActivityController : ActivityControllerBase
	{
		// Token: 0x06036B2C RID: 224044 RVA: 0x00F43352 File Offset: 0x00F41552
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06036B2D RID: 224045 RVA: 0x00F43355 File Offset: 0x00F41555
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x06036B2E RID: 224046 RVA: 0x00F43358 File Offset: 0x00F41558
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06036B2F RID: 224047 RVA: 0x00F4335A File Offset: 0x00F4155A
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new DirectTrainActivityData();
		}

		// Token: 0x06036B30 RID: 224048 RVA: 0x00F43361 File Offset: 0x00F41561
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new DirectTrainMainSubView();
		}

		// Token: 0x06036B31 RID: 224049 RVA: 0x00F43368 File Offset: 0x00F41568
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_PlotArriveGuide";
		}

		// Token: 0x06036B32 RID: 224050 RVA: 0x00F4336F File Offset: 0x00F4156F
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x170069A2 RID: 27042
		// (get) Token: 0x06036B33 RID: 224051 RVA: 0x00F43372 File Offset: 0x00F41572
		public static DirectTrainActivityController Instance
		{
			get
			{
				return DirectTrainActivityController._Instance;
			}
		}

		// Token: 0x06036B34 RID: 224052 RVA: 0x00F43379 File Offset: 0x00F41579
		public static DirectTrainActivityController GetOrCreateInstance()
		{
			if (DirectTrainActivityController._Instance == null)
			{
				DirectTrainActivityController.CreateInstance();
			}
			return DirectTrainActivityController._Instance;
		}

		// Token: 0x06036B35 RID: 224053 RVA: 0x00F4338D File Offset: 0x00F4158D
		public static bool CreateInstance()
		{
			if (DirectTrainActivityController._Instance != null)
			{
				return true;
			}
			DirectTrainActivityController._Instance = new DirectTrainActivityController();
			return true;
		}

		// Token: 0x06036B36 RID: 224054 RVA: 0x00F433A3 File Offset: 0x00F415A3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06036B37 RID: 224055 RVA: 0x00F433A5 File Offset: 0x00F415A5
		public static void ResetStaticDefaultValue()
		{
			DirectTrainActivityController._Instance = null;
		}

		// Token: 0x06036B38 RID: 224056 RVA: 0x00F433AD File Offset: 0x00F415AD
		static DirectTrainActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DirectTrainActivityController.CreateStaticDefaultValue), new Action(DirectTrainActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x0401CE5B RID: 118363
		[Nullable(2)]
		private static DirectTrainActivityController _Instance;
	}
}
