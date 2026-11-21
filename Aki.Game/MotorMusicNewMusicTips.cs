using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020017B1 RID: 6065
public class MotorMusicNewMusicTips : UiViewBase
{
	// Token: 0x0600EC7F RID: 60543 RVA: 0x004570A2 File Offset: 0x004552A2
	[NullableContext(1)]
	public MotorMusicNewMusicTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600EC80 RID: 60544 RVA: 0x004570B8 File Offset: 0x004552B8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClick))
		};
	}

	// Token: 0x0600EC81 RID: 60545 RVA: 0x00457120 File Offset: 0x00455320
	protected override UniTask OnBeforeStartAsync()
	{
		MotorMusicNewMusicTips.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorMusicNewMusicTips.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600EC82 RID: 60546 RVA: 0x00457163 File Offset: 0x00455363
	protected override void OnBeforeDestroy()
	{
		this.ClearTimer();
	}

	// Token: 0x0600EC83 RID: 60547 RVA: 0x0045716B File Offset: 0x0045536B
	private void ClearTimer()
	{
		if (this.CloseTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseTimer);
			this.CloseTimer = null;
		}
	}

	// Token: 0x0600EC84 RID: 60548 RVA: 0x0045718D File Offset: 0x0045538D
	private void OnCloseTimer(float delta)
	{
		base.CloseMe(null);
		this.CloseTimer = null;
	}

	// Token: 0x0600EC85 RID: 60549 RVA: 0x0045719D File Offset: 0x0045539D
	private void OnClick()
	{
		base.CloseMe(null);
		UiManager.Instance.OpenView(EUiViewName.PhonographNewMusicView, new PhonographNewMusicViewOpenParam
		{
			UnlockMusicList = this.MusicIds
		}, null);
	}

	// Token: 0x0400860E RID: 34318
	[Nullable(1)]
	private List<int> MusicIds = new List<int>();

	// Token: 0x0400860F RID: 34319
	[Nullable(2)]
	private TimerHandle CloseTimer;

	// Token: 0x020079CC RID: 31180
	private class EComponents
	{
		// Token: 0x04027783 RID: 161667
		public const int Btn = 0;

		// Token: 0x04027784 RID: 161668
		public const int Txt = 1;
	}
}
