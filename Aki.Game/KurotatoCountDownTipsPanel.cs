using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CB8 RID: 7352
public class KurotatoCountDownTipsPanel : UiPanelBase
{
	// Token: 0x0600DE25 RID: 56869 RVA: 0x0033F088 File Offset: 0x0033D288
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
	}

	// Token: 0x0600DE26 RID: 56870 RVA: 0x0033F0F8 File Offset: 0x0033D2F8
	protected override void OnStart()
	{
		this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SeqPlayer.BindSequenceCloseEvent(delegate(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				base.Hide(null);
			}
		}, false);
	}

	// Token: 0x0600DE27 RID: 56871 RVA: 0x0033F123 File Offset: 0x0033D323
	protected override void OnBeforeShow()
	{
		this.TickEnabled = true;
	}

	// Token: 0x0600DE28 RID: 56872 RVA: 0x0033F12C File Offset: 0x0033D32C
	protected override void OnBeforeHide()
	{
		this.TickEnabled = false;
	}

	// Token: 0x0600DE29 RID: 56873 RVA: 0x0033F138 File Offset: 0x0033D338
	public void ShowTips()
	{
		base.Show(null);
		this.SeqPlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600DE2A RID: 56874 RVA: 0x0033F168 File Offset: 0x0033D368
	public void HideTips()
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null || !rootItem.IsUIActiveSelf())
		{
			return;
		}
		this.SeqPlayer.PlayOrReplaySequenceByName("Close", false, null);
	}

	// Token: 0x0600DE2B RID: 56875 RVA: 0x0033F1A8 File Offset: 0x0033D3A8
	public void InitCountDown(float remainTime)
	{
		this.TotalTime = remainTime;
		this.RemainTime = remainTime;
		this.NeedTick = true;
		this.IsLowTime = false;
		base.GetText(3).SetText(Math.Ceiling((double)this.RemainTime).ToString(), true);
	}

	// Token: 0x0600DE2C RID: 56876 RVA: 0x0033F1F4 File Offset: 0x0033D3F4
	public void OnTick(float delta)
	{
		if (!this.TickEnabled || !this.NeedTick)
		{
			return;
		}
		if (TickSystem.Instance.IsPaused)
		{
			return;
		}
		float num = Math.Max(this.RemainTime - delta * (float)TimeUtil.Instance.Millisecond, 0f);
		this.RemainTime = num;
		base.GetText(3).SetText(Math.Ceiling((double)this.RemainTime).ToString(), true);
		if (!this.IsLowTime && num <= this.TotalTime * 0.1f)
		{
			this.IsLowTime = true;
			this.SeqPlayer.PlayOrReplaySequenceByName("Switch", false, null);
		}
		if (num <= 0f)
		{
			this.NeedTick = false;
			EventSystem.Instance.Emit(EEventName.KurotatoOnWaveCountDownFinish);
		}
	}

	// Token: 0x040065F3 RID: 26099
	private const float LOW_TIME_RATIO = 0.1f;

	// Token: 0x040065F4 RID: 26100
	private float TotalTime;

	// Token: 0x040065F5 RID: 26101
	private float RemainTime;

	// Token: 0x040065F6 RID: 26102
	private bool NeedTick;

	// Token: 0x040065F7 RID: 26103
	private bool TickEnabled;

	// Token: 0x040065F8 RID: 26104
	private bool IsLowTime;

	// Token: 0x040065F9 RID: 26105
	[Nullable(1)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x020082A1 RID: 33441
	private static class EComponentDefine
	{
		// Token: 0x0402A9C8 RID: 174536
		public const int PanelRed = 0;

		// Token: 0x0402A9C9 RID: 174537
		public const int TextureLight1 = 1;

		// Token: 0x0402A9CA RID: 174538
		public const int TextureLight2 = 2;

		// Token: 0x0402A9CB RID: 174539
		public const int TextNum = 3;
	}
}
