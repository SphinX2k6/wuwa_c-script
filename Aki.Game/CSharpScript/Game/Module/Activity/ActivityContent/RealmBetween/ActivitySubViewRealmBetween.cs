using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051EC RID: 20972
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewRealmBetween : ActivitySubViewBase
	{
		// Token: 0x170065CE RID: 26062
		// (get) Token: 0x060343EE RID: 213998 RVA: 0x00E9D833 File Offset: 0x00E9BA33
		protected new ActivityRealmBetweenData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as ActivityRealmBetweenData;
			}
		}

		// Token: 0x060343EF RID: 213999 RVA: 0x00E9D840 File Offset: 0x00E9BA40
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

		// Token: 0x060343F0 RID: 214000 RVA: 0x00E9D8B0 File Offset: 0x00E9BAB0
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewRealmBetween.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewRealmBetween.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060343F1 RID: 214001 RVA: 0x00E9D8F3 File Offset: 0x00E9BAF3
		protected override void OnRefreshView()
		{
			this.RefreshExpComponent();
			this.RefreshButton();
		}

		// Token: 0x060343F2 RID: 214002 RVA: 0x00E9D901 File Offset: 0x00E9BB01
		private void OnBtnClick(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				UiManager.Instance.OpenView(EUiViewName.RealmBetweenMainView, this.ActivityBaseData, null);
			});
		}

		// Token: 0x060343F3 RID: 214003 RVA: 0x00E9D920 File Offset: 0x00E9BB20
		private void RefreshExpComponent()
		{
			this.ExpComponent.SetProgress(this.ActivityBaseData.GetCurrentExp(), this.ActivityBaseData.GetCurrentTargetExp(), this.ActivityBaseData.TravelLevel == this.ActivityBaseData.MaxTravelLevel);
			this.ExpComponent.SetLevel(this.ActivityBaseData.TravelLevel);
		}

		// Token: 0x060343F4 RID: 214004 RVA: 0x00E9D97C File Offset: 0x00E9BB7C
		private void RefreshButton()
		{
			this.GeneralActivityInfo.SetFunctionRedDotVisible(this.ActivityBaseData.RedPointShowState);
		}

		// Token: 0x0401BB82 RID: 113538
		protected ActivitySubViewGeneralInfo GeneralActivityInfo;

		// Token: 0x0401BB83 RID: 113539
		protected RealmBetweenExpComponent ExpComponent;
	}
}
