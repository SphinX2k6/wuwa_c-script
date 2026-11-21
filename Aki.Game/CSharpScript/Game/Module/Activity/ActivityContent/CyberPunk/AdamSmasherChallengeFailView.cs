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
	// Token: 0x020057EB RID: 22507
	[NullableContext(2)]
	[Nullable(0)]
	public class AdamSmasherChallengeFailView : UiViewBase
	{
		// Token: 0x060378A5 RID: 227493 RVA: 0x00F86246 File Offset: 0x00F84446
		[NullableContext(1)]
		public AdamSmasherChallengeFailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060378A6 RID: 227494 RVA: 0x00F86250 File Offset: 0x00F84450
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

		// Token: 0x060378A7 RID: 227495 RVA: 0x00F8638C File Offset: 0x00F8458C
		protected override UniTask OnBeforeStartAsync()
		{
			AdamSmasherChallengeFailView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AdamSmasherChallengeFailView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060378A8 RID: 227496 RVA: 0x00F863CF File Offset: 0x00F845CF
		protected override void OnStart()
		{
			this.TrainingViewInstance = new TrainingView();
			this.TrainingViewInstance.Show(base.GetHorizontalLayout(7), null);
		}

		// Token: 0x060378A9 RID: 227497 RVA: 0x00F863EF File Offset: 0x00F845EF
		private void OnReturnToChallengeButtonClick(int a)
		{
			AdamSmasherController.Instance.OpenAdamSmasherSelectView().Forget<bool>();
			base.CloseMe(null);
		}

		// Token: 0x060378AA RID: 227498 RVA: 0x00F86407 File Offset: 0x00F84607
		private void OnReChallengeButtonItemClick(int a)
		{
			AdamSmasherController.Instance.ReChallenge(this.StageId).Forget<bool>();
			base.CloseMe(null);
		}

		// Token: 0x060378AB RID: 227499 RVA: 0x00F86425 File Offset: 0x00F84625
		private void OnLeaveDungeonClick(int a)
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
			base.CloseMe(null);
		}

		// Token: 0x0401D4C7 RID: 120007
		private int StageId;

		// Token: 0x0401D4C8 RID: 120008
		private TrainingView TrainingViewInstance;

		// Token: 0x0401D4C9 RID: 120009
		private ButtonItem ReturnToChallenge;

		// Token: 0x0401D4CA RID: 120010
		private ButtonItem ReChallengeButtonItem;

		// Token: 0x0200B42F RID: 46127
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037BB8 RID: 228280
			Revive,
			// Token: 0x04037BB9 RID: 228281
			Fail,
			// Token: 0x04037BBA RID: 228282
			ReturnToChallenge,
			// Token: 0x04037BBB RID: 228283
			ReChallengeButtonItem,
			// Token: 0x04037BBC RID: 228284
			WaitTime,
			// Token: 0x04037BBD RID: 228285
			ReviveTitle,
			// Token: 0x04037BBE RID: 228286
			ReviveContent,
			// Token: 0x04037BBF RID: 228287
			RoleTrainingLayout,
			// Token: 0x04037BC0 RID: 228288
			ReviveAtLocationBtn,
			// Token: 0x04037BC1 RID: 228289
			AutoReviveCountDownText,
			// Token: 0x04037BC2 RID: 228290
			ItemTexture,
			// Token: 0x04037BC3 RID: 228291
			ItemText,
			// Token: 0x04037BC4 RID: 228292
			GiveUpBtnText
		}
	}
}
