using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.TrainingDegree;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x0200689B RID: 26779
	[NullableContext(2)]
	[Nullable(0)]
	public class AdamSmasherChallengeFailView : UiViewBase
	{
		// Token: 0x06042D4D RID: 273741 RVA: 0x01044CCE File Offset: 0x01042ECE
		[NullableContext(1)]
		public AdamSmasherChallengeFailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042D4E RID: 273742 RVA: 0x01044CD8 File Offset: 0x01042ED8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUITexture)),
				new ValueTuple<int, Type>(11, typeof(UUIText)),
				new ValueTuple<int, Type>(12, typeof(UUIText))
			};
		}

		// Token: 0x06042D4F RID: 273743 RVA: 0x01044E14 File Offset: 0x01043014
		protected override UniTask OnBeforeStartAsync()
		{
			AdamSmasherChallengeFailView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AdamSmasherChallengeFailView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042D50 RID: 273744 RVA: 0x01044E57 File Offset: 0x01043057
		protected override void OnStart()
		{
			this.TrainingViewInstance = new TrainingView();
			this.TrainingViewInstance.Show(base.GetHorizontalLayout(7), null);
		}

		// Token: 0x06042D51 RID: 273745 RVA: 0x01044E77 File Offset: 0x01043077
		private void OnReturnToChallengeButtonClick(int a)
		{
			AdamSmasherController.Instance.OpenAdamSmasherSelectView().Forget<bool>();
			base.CloseMe(null);
		}

		// Token: 0x06042D52 RID: 273746 RVA: 0x01044E8F File Offset: 0x0104308F
		private void OnReChallengeButtonItemClick(int a)
		{
			AdamSmasherController.Instance.ReChallenge(this.StageId).Forget<bool>();
			base.CloseMe(null);
		}

		// Token: 0x06042D53 RID: 273747 RVA: 0x01044EAD File Offset: 0x010430AD
		private void OnLeaveDungeonClick(int a)
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
			base.CloseMe(null);
		}

		// Token: 0x04022C6B RID: 142443
		private int StageId;

		// Token: 0x04022C6C RID: 142444
		private TrainingView TrainingViewInstance;

		// Token: 0x04022C6D RID: 142445
		private ButtonItem ReturnToChallenge;

		// Token: 0x04022C6E RID: 142446
		private ButtonItem ReChallengeButtonItem;

		// Token: 0x0200CA65 RID: 51813
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403D2D9 RID: 250585
			Revive,
			// Token: 0x0403D2DA RID: 250586
			Fail,
			// Token: 0x0403D2DB RID: 250587
			ReturnToChallenge,
			// Token: 0x0403D2DC RID: 250588
			ReChallengeButtonItem,
			// Token: 0x0403D2DD RID: 250589
			WaitTime,
			// Token: 0x0403D2DE RID: 250590
			ReviveTitle,
			// Token: 0x0403D2DF RID: 250591
			ReviveContent,
			// Token: 0x0403D2E0 RID: 250592
			RoleTrainingLayout,
			// Token: 0x0403D2E1 RID: 250593
			ReviveAtLocationBtn,
			// Token: 0x0403D2E2 RID: 250594
			AutoReviveCountDownText,
			// Token: 0x0403D2E3 RID: 250595
			ItemTexture,
			// Token: 0x0403D2E4 RID: 250596
			ItemText,
			// Token: 0x0403D2E5 RID: 250597
			GiveUpBtnText
		}
	}
}
