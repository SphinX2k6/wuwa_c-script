using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CC1 RID: 7361
[NullableContext(1)]
[Nullable(0)]
public class KurotatoWaveTipsPanel : UiPanelBase
{
	// Token: 0x0600DEB3 RID: 57011 RVA: 0x00341DC0 File Offset: 0x0033FFC0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x0600DEB4 RID: 57012 RVA: 0x00341E1A File Offset: 0x0034001A
	protected override void OnStart()
	{
		this.TextTips = base.GetText(0);
		this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		this.SeqPlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceClose), false);
	}

	// Token: 0x0600DEB5 RID: 57013 RVA: 0x00341E52 File Offset: 0x00340052
	public void SetFinishCb(Action cb)
	{
		this.FinishCb = cb;
	}

	// Token: 0x0600DEB6 RID: 57014 RVA: 0x00341E5C File Offset: 0x0034005C
	public void PlaySuccess(string tipsTextKey)
	{
		base.SetUiActive(true);
		LguiUtil.Instance.SetLocalTextNew(this.TextTips, tipsTextKey, Array.Empty<object>());
		this.SeqPlayer.PlayOrReplaySequenceByName("StartSuccess", false, null);
	}

	// Token: 0x0600DEB7 RID: 57015 RVA: 0x00341EA0 File Offset: 0x003400A0
	public void PlayFail(string tipsTextKey)
	{
		base.SetUiActive(true);
		LguiUtil.Instance.SetLocalTextNew(this.TextTips, tipsTextKey, Array.Empty<object>());
		this.SeqPlayer.PlayOrReplaySequenceByName("StartFail", false, null);
	}

	// Token: 0x0600DEB8 RID: 57016 RVA: 0x00341EE4 File Offset: 0x003400E4
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

	// Token: 0x04006652 RID: 26194
	private UUIText TextTips;

	// Token: 0x04006653 RID: 26195
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04006654 RID: 26196
	[Nullable(2)]
	private Action FinishCb;

	// Token: 0x020082B2 RID: 33458
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AA2E RID: 174638
		public const int TextTips = 0;

		// Token: 0x0402AA2F RID: 174639
		public const int TextureWin = 1;

		// Token: 0x0402AA30 RID: 174640
		public const int TextureFailure = 2;
	}
}
