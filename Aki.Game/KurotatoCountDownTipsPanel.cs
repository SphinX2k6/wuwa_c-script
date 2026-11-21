using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200117A RID: 4474
public class KurotatoCountDownTipsPanel : UiPanelBase
{
	// Token: 0x0600B242 RID: 45634 RVA: 0x0034AAC4 File Offset: 0x00348CC4
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

	// Token: 0x0600B243 RID: 45635 RVA: 0x0034AB34 File Offset: 0x00348D34
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

	// Token: 0x0600B244 RID: 45636 RVA: 0x0034AB5F File Offset: 0x00348D5F
	protected override void OnBeforeShow()
	{
		this.TickEnabled = true;
	}

	// Token: 0x0600B245 RID: 45637 RVA: 0x0034AB68 File Offset: 0x00348D68
	protected override void OnBeforeHide()
	{
		this.TickEnabled = false;
	}

	// Token: 0x0600B246 RID: 45638 RVA: 0x0034AB74 File Offset: 0x00348D74
	public void ShowTips()
	{
		base.Show(null);
		this.SeqPlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600B247 RID: 45639 RVA: 0x0034ABA4 File Offset: 0x00348DA4
	public void HideTips()
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null || !rootItem.IsUIActiveSelf())
		{
			return;
		}
		this.SeqPlayer.PlayOrReplaySequenceByName("Close", false, null);
	}

	// Token: 0x0600B248 RID: 45640 RVA: 0x0034ABE4 File Offset: 0x00348DE4
	public void InitCountDown(float remainTime)
	{
		this.TotalTime = remainTime;
		this.RemainTime = remainTime;
		this.NeedTick = true;
		this.IsLowTime = false;
		base.GetText(3).SetText(Math.Ceiling((double)this.RemainTime).ToString(), true);
	}

	// Token: 0x0600B249 RID: 45641 RVA: 0x0034AC30 File Offset: 0x00348E30
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

	// Token: 0x040066D2 RID: 26322
	private const float LOW_TIME_RATIO = 0.1f;

	// Token: 0x040066D3 RID: 26323
	private float TotalTime;

	// Token: 0x040066D4 RID: 26324
	private float RemainTime;

	// Token: 0x040066D5 RID: 26325
	private bool NeedTick;

	// Token: 0x040066D6 RID: 26326
	private bool TickEnabled;

	// Token: 0x040066D7 RID: 26327
	private bool IsLowTime;

	// Token: 0x040066D8 RID: 26328
	[Nullable(1)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0200742B RID: 29739
	private static class EComponentDefine
	{
		// Token: 0x04025CF3 RID: 154867
		public const int PanelRed = 0;

		// Token: 0x04025CF4 RID: 154868
		public const int TextureLight1 = 1;

		// Token: 0x04025CF5 RID: 154869
		public const int TextureLight2 = 2;

		// Token: 0x04025CF6 RID: 154870
		public const int TextNum = 3;
	}
}
