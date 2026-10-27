using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DirectTrain.MainActivity
{
	// Token: 0x02006748 RID: 26440
	[NullableContext(1)]
	[Nullable(0)]
	public class DirectTrainActivityController : ActivityControllerBase
	{
		// Token: 0x06041FDD RID: 270301 RVA: 0x01001F5E File Offset: 0x0100015E
		protected override bool OnInit()
		{
			return true;
		}

		// Token: 0x06041FDE RID: 270302 RVA: 0x01001F61 File Offset: 0x01000161
		protected override bool OnClear()
		{
			return true;
		}

		// Token: 0x06041FDF RID: 270303 RVA: 0x01001F64 File Offset: 0x01000164
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06041FE0 RID: 270304 RVA: 0x01001F66 File Offset: 0x01000166
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new DirectTrainActivityData();
		}

		// Token: 0x06041FE1 RID: 270305 RVA: 0x01001F6D File Offset: 0x0100016D
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new DirectTrainMainSubView();
		}

		// Token: 0x06041FE2 RID: 270306 RVA: 0x01001F74 File Offset: 0x01000174
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_PlotArriveGuide";
		}

		// Token: 0x06041FE3 RID: 270307 RVA: 0x01001F7B File Offset: 0x0100017B
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x17009663 RID: 38499
		// (get) Token: 0x06041FE4 RID: 270308 RVA: 0x01001F7E File Offset: 0x0100017E
		public static DirectTrainActivityController Instance
		{
			get
			{
				return DirectTrainActivityController._Instance;
			}
		}

		// Token: 0x06041FE5 RID: 270309 RVA: 0x01001F85 File Offset: 0x01000185
		public static DirectTrainActivityController GetOrCreateInstance()
		{
			if (DirectTrainActivityController._Instance == null)
			{
				DirectTrainActivityController.CreateInstance();
			}
			return DirectTrainActivityController._Instance;
		}

		// Token: 0x06041FE6 RID: 270310 RVA: 0x01001F99 File Offset: 0x01000199
		public static bool CreateInstance()
		{
			if (DirectTrainActivityController._Instance != null)
			{
				return true;
			}
			DirectTrainActivityController._Instance = new DirectTrainActivityController();
			return true;
		}

		// Token: 0x06041FE7 RID: 270311 RVA: 0x01001FAF File Offset: 0x010001AF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06041FE8 RID: 270312 RVA: 0x01001FB1 File Offset: 0x010001B1
		public static void ResetStaticDefaultValue()
		{
			DirectTrainActivityController._Instance = null;
		}

		// Token: 0x06041FE9 RID: 270313 RVA: 0x01001FB9 File Offset: 0x010001B9
		static DirectTrainActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DirectTrainActivityController.CreateStaticDefaultValue), new Action(DirectTrainActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x04022602 RID: 140802
		[Nullable(2)]
		private static DirectTrainActivityController _Instance;
	}
}
