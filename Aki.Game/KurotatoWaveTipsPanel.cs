using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001183 RID: 4483
[NullableContext(1)]
[Nullable(0)]
public class KurotatoWaveTipsPanel : UiPanelBase
{
	// Token: 0x0600B2D0 RID: 45776 RVA: 0x0034D7E8 File Offset: 0x0034B9E8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x0600B2D1 RID: 45777 RVA: 0x0034D842 File Offset: 0x0034BA42
	protected override void OnStart()
	{
		this.TextTips = base.GetText(0);
		this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
	}

	// Token: 0x0600B2D2 RID: 45778 RVA: 0x0034D87A File Offset: 0x0034BA7A
	public void SetFinishCb(Action cb)
	{
		this.FinishCb = cb;
	}

	// Token: 0x0600B2D3 RID: 45779 RVA: 0x0034D884 File Offset: 0x0034BA84
	public void PlaySuccess(string tipsTextKey)
	{
		base.SetUiActive(true);
		LguiUtil.Instance.SetLocalTextNew(this.TextTips, tipsTextKey, Array.Empty<object>());
		this.SeqPlayer.PlayOrReplaySequenceByName("StartSuccess", false, null);
	}

	// Token: 0x0600B2D4 RID: 45780 RVA: 0x0034D8C8 File Offset: 0x0034BAC8
	public void PlayFail(string tipsTextKey)
	{
		base.SetUiActive(true);
		LguiUtil.Instance.SetLocalTextNew(this.TextTips, tipsTextKey, Array.Empty<object>());
		this.SeqPlayer.PlayOrReplaySequenceByName("StartFail", false, null);
	}

	// Token: 0x0600B2D5 RID: 45781 RVA: 0x0034D90C File Offset: 0x0034BB0C
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "StartSuccess" || sequenceName == "StartFail")
		{
			Action finishCb = this.FinishCb;
			if (finishCb == null)
			{
				return;
			}
			finishCb();
		}
	}

	// Token: 0x04006731 RID: 26417
	private UUIText TextTips;

	// Token: 0x04006732 RID: 26418
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04006733 RID: 26419
	[Nullable(2)]
	private Action FinishCb;

	// Token: 0x0200743B RID: 29755
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025D56 RID: 154966
		public const int TextTips = 0;

		// Token: 0x04025D57 RID: 154967
		public const int TextureWin = 1;

		// Token: 0x04025D58 RID: 154968
		public const int TextureFailure = 2;
	}
}
