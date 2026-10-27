using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020022CD RID: 8909
public class MotorMusicNewMusicTips : UiViewBase
{
	// Token: 0x060117E8 RID: 71656 RVA: 0x0044A37A File Offset: 0x0044857A
	[NullableContext(1)]
	public MotorMusicNewMusicTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060117E9 RID: 71657 RVA: 0x0044A390 File Offset: 0x00448590
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

	// Token: 0x060117EA RID: 71658 RVA: 0x0044A3F8 File Offset: 0x004485F8
	protected override UniTask OnBeforeStartAsync()
	{
		MotorMusicNewMusicTips.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MotorMusicNewMusicTips.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060117EB RID: 71659 RVA: 0x0044A43B File Offset: 0x0044863B
	protected override void OnBeforeDestroy()
	{
		this.ClearTimer();
	}

	// Token: 0x060117EC RID: 71660 RVA: 0x0044A443 File Offset: 0x00448643
	private void ClearTimer()
	{
		if (this.CloseTimer != null)
		{
			TimerSystem.Instance.Remove(this.CloseTimer);
			this.CloseTimer = null;
		}
	}

	// Token: 0x060117ED RID: 71661 RVA: 0x0044A465 File Offset: 0x00448665
	private void OnCloseTimer(float delta)
	{
		base.CloseMe(null);
		this.CloseTimer = null;
	}

	// Token: 0x060117EE RID: 71662 RVA: 0x0044A475 File Offset: 0x00448675
	private void OnClick()
	{
		base.CloseMe(null);
		UiManager.Instance.OpenView(EUiViewName.PhonographNewMusicView, new PhonographNewMusicViewOpenParam
		{
			UnlockMusicList = this.MusicIds
		}, null);
	}

	// Token: 0x040084D0 RID: 34000
	[Nullable(1)]
	private List<int> MusicIds = new List<int>();

	// Token: 0x040084D1 RID: 34001
	[Nullable(2)]
	private TimerHandle CloseTimer;

	// Token: 0x02008848 RID: 34888
	private class EComponents
	{
		// Token: 0x0402C481 RID: 181377
		public const int Btn = 0;

		// Token: 0x0402C482 RID: 181378
		public const int Txt = 1;
	}
}
