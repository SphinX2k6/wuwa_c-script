using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061CB RID: 25035
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewRoadBook : ActivitySubViewBase
	{
		// Token: 0x17009229 RID: 37417
		// (get) Token: 0x0603F3B5 RID: 258997 RVA: 0x00F471B6 File Offset: 0x00F453B6
		protected new ActivityRoadBookData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as ActivityRoadBookData;
			}
		}

		// Token: 0x0603F3B6 RID: 258998 RVA: 0x00F471C4 File Offset: 0x00F453C4
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

		// Token: 0x0603F3B7 RID: 258999 RVA: 0x00F47234 File Offset: 0x00F45434
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewRoadBook.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewRoadBook.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F3B8 RID: 259000 RVA: 0x00F47277 File Offset: 0x00F45477
		protected override void OnRefreshView()
		{
			this.RefreshExpComponent();
			this.RefreshButton();
		}

		// Token: 0x0603F3B9 RID: 259001 RVA: 0x00F47285 File Offset: 0x00F45485
		private void OnBtnClick(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				UiManager.Instance.OpenView(EUiViewName.RoadBookMainView, this.ActivityBaseData, null);
			});
		}

		// Token: 0x0603F3BA RID: 259002 RVA: 0x00F472A4 File Offset: 0x00F454A4
		private void RefreshExpComponent()
		{
			this.ExpComponent.SetProgress(this.ActivityBaseData.GetCurrentExp(), this.ActivityBaseData.GetCurrentTargetExp(), this.ActivityBaseData.TravelLevel == this.ActivityBaseData.MaxTravelLevel);
			this.ExpComponent.SetLevel(this.ActivityBaseData.TravelLevel);
		}

		// Token: 0x0603F3BB RID: 259003 RVA: 0x00F47300 File Offset: 0x00F45500
		private void RefreshButton()
		{
			this.GeneralActivityInfo.SetFunctionRedDotVisible(this.ActivityBaseData.RedPointShowState);
		}

		// Token: 0x04020F45 RID: 134981
		protected ActivitySubViewGeneralInfo GeneralActivityInfo;

		// Token: 0x04020F46 RID: 134982
		protected RoadBookExpComponent ExpComponent;
	}
}
