using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005149 RID: 20809
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewRoadBook : ActivitySubViewBase
	{
		// Token: 0x1700658B RID: 25995
		// (get) Token: 0x06034076 RID: 213110 RVA: 0x00E8E10E File Offset: 0x00E8C30E
		protected new ActivityRoadBookData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as ActivityRoadBookData;
			}
		}

		// Token: 0x06034077 RID: 213111 RVA: 0x00E8E11C File Offset: 0x00E8C31C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x06034078 RID: 213112 RVA: 0x00E8E18C File Offset: 0x00E8C38C
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewRoadBook.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewRoadBook.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034079 RID: 213113 RVA: 0x00E8E1CF File Offset: 0x00E8C3CF
		protected override void OnRefreshView()
		{
			this.RefreshExpComponent();
			this.RefreshButton();
		}

		// Token: 0x0603407A RID: 213114 RVA: 0x00E8E1DD File Offset: 0x00E8C3DD
		private void OnBtnClick(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				UiManager.Instance.OpenView(EUiViewName.RoadBookMainView, this.ActivityBaseData, null);
			});
		}

		// Token: 0x0603407B RID: 213115 RVA: 0x00E8E1FC File Offset: 0x00E8C3FC
		private void RefreshExpComponent()
		{
			this.ExpComponent.SetProgress(this.ActivityBaseData.GetCurrentExp(), this.ActivityBaseData.GetCurrentTargetExp(), this.ActivityBaseData.TravelLevel == this.ActivityBaseData.MaxTravelLevel);
			this.ExpComponent.SetLevel(this.ActivityBaseData.TravelLevel);
		}

		// Token: 0x0603407C RID: 213116 RVA: 0x00E8E258 File Offset: 0x00E8C458
		private void RefreshButton()
		{
			this.GeneralActivityInfo.SetFunctionRedDotVisible(this.ActivityBaseData.RedPointShowState);
		}

		// Token: 0x0401B874 RID: 112756
		protected ActivitySubViewGeneralInfo GeneralActivityInfo;

		// Token: 0x0401B875 RID: 112757
		protected RoadBookExpComponent ExpComponent;
	}
}
