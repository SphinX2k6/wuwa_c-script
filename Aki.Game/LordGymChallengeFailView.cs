using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.TrainingDegree;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200219A RID: 8602
[NullableContext(2)]
[Nullable(0)]
public class LordGymChallengeFailView : UiViewBase
{
	// Token: 0x06010B8D RID: 68493 RVA: 0x0040FC7F File Offset: 0x0040DE7F
	[NullableContext(1)]
	public LordGymChallengeFailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010B8E RID: 68494 RVA: 0x0040FC88 File Offset: 0x0040DE88
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

	// Token: 0x06010B8F RID: 68495 RVA: 0x0040FDC4 File Offset: 0x0040DFC4
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymChallengeFailView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymChallengeFailView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010B90 RID: 68496 RVA: 0x0040FE07 File Offset: 0x0040E007
	protected override void OnStart()
	{
		this.TrainingView = new TrainingView();
		this.TrainingView.Show(base.GetHorizontalLayout(7), null);
	}

	// Token: 0x06010B91 RID: 68497 RVA: 0x0040FE28 File Offset: 0x0040E028
	private void OnReturnToWorldButtonClick(int _)
	{
		if (this.Version.GetValueOrDefault() == ELordGymVersion.Third)
		{
			InstanceDungeonEntranceController.Instance.EnterEntrance(3924, 0, null).Forget<bool>();
		}
		else if (this.Version.GetValueOrDefault() == ELordGymVersion.Third5)
		{
			InstanceDungeonEntranceController.Instance.EnterEntrance(3925, 0, null).Forget<bool>();
		}
		else if (this.Version.GetValueOrDefault() == ELordGymVersion.First && this.IsFromGuide)
		{
			InstanceDungeonEntranceController.Instance.EnterEntrance(3927, 0, null).Forget<bool>();
		}
		else if (this.Version.GetValueOrDefault() == ELordGymVersion.Second && this.IsFromGuide)
		{
			InstanceDungeonEntranceController.Instance.EnterEntrance(3926, 0, null).Forget<bool>();
		}
		base.CloseMe(null);
	}

	// Token: 0x06010B92 RID: 68498 RVA: 0x0040FEE8 File Offset: 0x0040E0E8
	private void OnReChallengeButtonItemClick(int _)
	{
		if (this.Version.GetValueOrDefault() == ELordGymVersion.Second && !this.IsFromGuide)
		{
			LordGymController.Instance.LordGymBeginRequest(this.LordId).Forget<bool>();
		}
		else if (this.Version.GetValueOrDefault() == ELordGymVersion.Third)
		{
			InstanceDungeonEntranceController.Instance.RestartInstanceDungeon().Forget<bool>();
		}
		else if (this.Version.GetValueOrDefault() == ELordGymVersion.Third5)
		{
			InstanceDungeonEntranceController.Instance.RestartInstanceDungeon().Forget<bool>();
		}
		else if ((this.Version.GetValueOrDefault() == ELordGymVersion.First || this.Version.GetValueOrDefault() == ELordGymVersion.Second) && this.IsFromGuide)
		{
			LordGymModel.Instance.EntryChallengeId = this.LordId;
			InstanceDungeonEntranceController.Instance.RestartInstanceDungeon().Forget<bool>();
		}
		base.CloseMe(null);
	}

	// Token: 0x04007F56 RID: 32598
	private int LordId;

	// Token: 0x04007F57 RID: 32599
	private TrainingView TrainingView;

	// Token: 0x04007F58 RID: 32600
	private ButtonItem ReturnToWorldButtonItem;

	// Token: 0x04007F59 RID: 32601
	private ButtonItem ReChallengeButtonItem;

	// Token: 0x04007F5A RID: 32602
	private ELordGymVersion? Version;

	// Token: 0x04007F5B RID: 32603
	private bool IsFromGuide;

	// Token: 0x020086C4 RID: 34500
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402BD8C RID: 179596
		public const int Revive = 0;

		// Token: 0x0402BD8D RID: 179597
		public const int Fail = 1;

		// Token: 0x0402BD8E RID: 179598
		public const int ReturnToWorldButtonItem = 2;

		// Token: 0x0402BD8F RID: 179599
		public const int ReChallengeButtonItem = 3;

		// Token: 0x0402BD90 RID: 179600
		public const int WaitTime = 4;

		// Token: 0x0402BD91 RID: 179601
		public const int ReviveTitle = 5;

		// Token: 0x0402BD92 RID: 179602
		public const int ReviveContent = 6;

		// Token: 0x0402BD93 RID: 179603
		public const int RoleTrainingLayout = 7;

		// Token: 0x0402BD94 RID: 179604
		public const int ReviveAtLocationBtn = 8;

		// Token: 0x0402BD95 RID: 179605
		public const int AutoReviveCountDownText = 9;

		// Token: 0x0402BD96 RID: 179606
		public const int ItemTexture = 10;

		// Token: 0x0402BD97 RID: 179607
		public const int ItemText = 11;

		// Token: 0x0402BD98 RID: 179608
		public const int GiveUpBtnText = 12;
	}
}
