using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200626E RID: 25198
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewRealmBetween : ActivitySubViewBase
	{
		// Token: 0x1700926C RID: 37484
		// (get) Token: 0x0603F72D RID: 259885 RVA: 0x00F568D7 File Offset: 0x00F54AD7
		protected new ActivityRealmBetweenData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as ActivityRealmBetweenData;
			}
		}

		// Token: 0x0603F72E RID: 259886 RVA: 0x00F568E4 File Offset: 0x00F54AE4
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

		// Token: 0x0603F72F RID: 259887 RVA: 0x00F56954 File Offset: 0x00F54B54
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewRealmBetween.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewRealmBetween.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F730 RID: 259888 RVA: 0x00F56997 File Offset: 0x00F54B97
		protected override void OnRefreshView()
		{
			this.RefreshExpComponent();
			this.RefreshButton();
		}

		// Token: 0x0603F731 RID: 259889 RVA: 0x00F569A5 File Offset: 0x00F54BA5
		private void OnBtnClick(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				UiManager.Instance.OpenView(EUiViewName.RealmBetweenMainView, this.ActivityBaseData, null);
			});
		}

		// Token: 0x0603F732 RID: 259890 RVA: 0x00F569C4 File Offset: 0x00F54BC4
		private void RefreshExpComponent()
		{
			this.ExpComponent.SetProgress(this.ActivityBaseData.GetCurrentExp(), this.ActivityBaseData.GetCurrentTargetExp(), this.ActivityBaseData.TravelLevel == this.ActivityBaseData.MaxTravelLevel);
			this.ExpComponent.SetLevel(this.ActivityBaseData.TravelLevel);
		}

		// Token: 0x0603F733 RID: 259891 RVA: 0x00F56A20 File Offset: 0x00F54C20
		private void RefreshButton()
		{
			this.GeneralActivityInfo.SetFunctionRedDotVisible(this.ActivityBaseData.RedPointShowState);
		}

		// Token: 0x04021253 RID: 135763
		protected ActivitySubViewGeneralInfo GeneralActivityInfo;

		// Token: 0x04021254 RID: 135764
		protected RealmBetweenExpComponent ExpComponent;
	}
}
