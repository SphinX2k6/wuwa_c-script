using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001D13 RID: 7443
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerWaveTipsItem : GridProxyAbstract<RoleTowerWaveRecordData>
{
	// Token: 0x17001B7A RID: 7034
	// (get) Token: 0x060126D0 RID: 75472 RVA: 0x00571EA6 File Offset: 0x005700A6
	// (set) Token: 0x060126D1 RID: 75473 RVA: 0x00571EAE File Offset: 0x005700AE
	public bool IsBound { get; set; }

	// Token: 0x060126D2 RID: 75474 RVA: 0x00571EB8 File Offset: 0x005700B8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
	}

	// Token: 0x060126D3 RID: 75475 RVA: 0x00571F3E File Offset: 0x0057013E
	protected override void OnStart()
	{
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceFinish), false);
		UUIText text = base.GetText(3);
		if (text == null)
		{
			return;
		}
		text.SetUIActive(false);
	}

	// Token: 0x060126D4 RID: 75476 RVA: 0x00571F7B File Offset: 0x0057017B
	protected override void OnBeforeShow()
	{
		this.PlayStart();
	}

	// Token: 0x060126D5 RID: 75477 RVA: 0x00571F84 File Offset: 0x00570184
	public override void Refresh(RoleTowerWaveRecordData data, bool isSelected, int gridIndex)
	{
		RoleTowerFloor? roleTowerFloor;
		string text = (RoleTowerConfig.Instance.GetFloorById(data.FloorId) != null) ? roleTowerFloor.GetValueOrDefault().FloorName : null;
		string item = string.IsNullOrEmpty(text) ? "" : (ConfigMultiTextLang.GetLocalTextNew(text, null) ?? "");
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "RoleTowerFloorFinish", new <>z__ReadOnlySingleElementList<object>(item));
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			UUIItem uuiitem = text2;
			bool bUseChangeColor = data.GainTime > 0L;
			FColor? fcolor = new FColor?(text2.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			text2.SetText(RoleTowerTimeUtil.FormatDeltaHud(data.GainTime), true);
		}
		UUIText text3 = base.GetText(4);
		if (text3 == null)
		{
			return;
		}
		text3.SetText(RoleTowerTimeUtil.Format(data.RemainTime), true);
	}

	// Token: 0x060126D6 RID: 75478 RVA: 0x00572054 File Offset: 0x00570254
	public void SetNewest(bool isNewest)
	{
		UUIItem item = base.GetItem(0);
		if (item == null)
		{
			return;
		}
		item.SetAlpha(isNewest ? 1f : 0.4f);
	}

	// Token: 0x060126D7 RID: 75479 RVA: 0x00572078 File Offset: 0x00570278
	private void PlayStart()
	{
		this.OnCloseFinished = null;
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x060126D8 RID: 75480 RVA: 0x005720AC File Offset: 0x005702AC
	public void PlayClose(Action onFinished)
	{
		this.OnCloseFinished = onFinished;
		if (this.SequencePlayer == null)
		{
			if (onFinished != null)
			{
				onFinished();
			}
			return;
		}
		this.SequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x060126D9 RID: 75481 RVA: 0x005720ED File Offset: 0x005702ED
	private void OnSequenceFinish(string sequenceName)
	{
		if (sequenceName == "Close")
		{
			Action onCloseFinished = this.OnCloseFinished;
			this.OnCloseFinished = null;
			if (onCloseFinished == null)
			{
				return;
			}
			onCloseFinished();
		}
	}

	// Token: 0x060126DA RID: 75482 RVA: 0x00572113 File Offset: 0x00570313
	public override object GetKey(RoleTowerWaveRecordData data, int displayIndex)
	{
		return displayIndex;
	}

	// Token: 0x0400A07C RID: 41084
	private const float OldWaveAlpha = 0.4f;

	// Token: 0x0400A07D RID: 41085
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0400A07E RID: 41086
	[Nullable(2)]
	private Action OnCloseFinished;

	// Token: 0x02008051 RID: 32849
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402984A RID: 170058
		public const int PnlWaveItem = 0;

		// Token: 0x0402984B RID: 170059
		public const int TxtWave = 1;

		// Token: 0x0402984C RID: 170060
		public const int TxtRewardTime = 2;

		// Token: 0x0402984D RID: 170061
		public const int TxtUseTime = 3;

		// Token: 0x0402984E RID: 170062
		public const int TxtWaveTime = 4;
	}
}
