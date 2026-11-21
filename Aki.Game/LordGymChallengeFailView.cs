using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.TrainingDegree;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200167E RID: 5758
[NullableContext(2)]
[Nullable(0)]
public class LordGymChallengeFailView : UiViewBase
{
	// Token: 0x0600E01E RID: 57374 RVA: 0x0041C567 File Offset: 0x0041A767
	[NullableContext(1)]
	public LordGymChallengeFailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E01F RID: 57375 RVA: 0x0041C570 File Offset: 0x0041A770
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

	// Token: 0x0600E020 RID: 57376 RVA: 0x0041C6AC File Offset: 0x0041A8AC
	protected override UniTask OnBeforeStartAsync()
	{
		LordGymChallengeFailView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<LordGymChallengeFailView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600E021 RID: 57377 RVA: 0x0041C6EF File Offset: 0x0041A8EF
	protected override void OnStart()
	{
		this.TrainingView = new TrainingView();
		this.TrainingView.Show(base.GetHorizontalLayout(7), null);
	}

	// Token: 0x0600E022 RID: 57378 RVA: 0x0041C710 File Offset: 0x0041A910
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

	// Token: 0x0600E023 RID: 57379 RVA: 0x0041C7D0 File Offset: 0x0041A9D0
	private void OnReChallengeButtonItemClick(int _)
	{
		if (this.Version.GetValueOrDefault() == ELordGymVersion.Second && !this.IsFromGuide)
		{
			LordGymController.Instance.LordGymBeginRequest(this.LordId).Forget<bool>();
		}
		else if (this.Version.GetValueOrDefault() == ELordGymVersion.Third)
		{
			InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false).Forget<bool>();
		}
		else if (this.Version.GetValueOrDefault() == ELordGymVersion.Third5)
		{
			InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false).Forget<bool>();
		}
		else if ((this.Version.GetValueOrDefault() == ELordGymVersion.First || this.Version.GetValueOrDefault() == ELordGymVersion.Second) && this.IsFromGuide)
		{
			LordGymModel.Instance.EntryChallengeId = this.LordId;
			InstanceDungeonEntranceController.Instance.RestartInstanceDungeon(false).Forget<bool>();
		}
		base.CloseMe(null);
	}

	// Token: 0x0400809D RID: 32925
	private int LordId;

	// Token: 0x0400809E RID: 32926
	private TrainingView TrainingView;

	// Token: 0x0400809F RID: 32927
	private ButtonItem ReturnToWorldButtonItem;

	// Token: 0x040080A0 RID: 32928
	private ButtonItem ReChallengeButtonItem;

	// Token: 0x040080A1 RID: 32929
	private ELordGymVersion? Version;

	// Token: 0x040080A2 RID: 32930
	private bool IsFromGuide;

	// Token: 0x0200784F RID: 30799
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x040270AD RID: 159917
		public const int Revive = 0;

		// Token: 0x040270AE RID: 159918
		public const int Fail = 1;

		// Token: 0x040270AF RID: 159919
		public const int ReturnToWorldButtonItem = 2;

		// Token: 0x040270B0 RID: 159920
		public const int ReChallengeButtonItem = 3;

		// Token: 0x040270B1 RID: 159921
		public const int WaitTime = 4;

		// Token: 0x040270B2 RID: 159922
		public const int ReviveTitle = 5;

		// Token: 0x040270B3 RID: 159923
		public const int ReviveContent = 6;

		// Token: 0x040270B4 RID: 159924
		public const int RoleTrainingLayout = 7;

		// Token: 0x040270B5 RID: 159925
		public const int ReviveAtLocationBtn = 8;

		// Token: 0x040270B6 RID: 159926
		public const int AutoReviveCountDownText = 9;

		// Token: 0x040270B7 RID: 159927
		public const int ItemTexture = 10;

		// Token: 0x040270B8 RID: 159928
		public const int ItemText = 11;

		// Token: 0x040270B9 RID: 159929
		public const int GiveUpBtnText = 12;
	}
}
