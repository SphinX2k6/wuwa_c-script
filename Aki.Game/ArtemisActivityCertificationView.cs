using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020010E5 RID: 4325
[NullableContext(1)]
[Nullable(0)]
public class ArtemisActivityCertificationView : UiViewBase
{
	// Token: 0x06007097 RID: 28823 RVA: 0x0016F9F9 File Offset: 0x0016DBF9
	public ArtemisActivityCertificationView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06007098 RID: 28824 RVA: 0x0016FA04 File Offset: 0x0016DC04
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIArtText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.StartVerification))
		};
	}

	// Token: 0x06007099 RID: 28825 RVA: 0x0016FAF0 File Offset: 0x0016DCF0
	protected override void OnStart()
	{
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor != null)
		{
			rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
		}
		UUIText text = base.GetText(6);
		if (text != null)
		{
			text.ShowTextNew("Activity_ArtemisChatFixTips_1");
		}
		UUIText text2 = base.GetText(5);
		if (text2 != null)
		{
			text2.ShowTextNew("Activity_ArtemisChatFixTips_2");
		}
		UUIText text3 = base.GetText(7);
		if (text3 != null)
		{
			text3.ShowTextNew("Activity_ArtemisChatFixTips_3");
		}
		UUIArtText artText = base.GetArtText(2);
		if (artText == null)
		{
			return;
		}
		artText.SetText("100");
	}

	// Token: 0x0600709A RID: 28826 RVA: 0x0016FB7A File Offset: 0x0016DD7A
	protected override void OnAddEventListener()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.AddSequenceFinishEvent("Fix_Done_02", new Action<string>(this.OnFixDone2End), false);
	}

	// Token: 0x0600709B RID: 28827 RVA: 0x0016FB9E File Offset: 0x0016DD9E
	protected override void OnRemoveEventListener()
	{
		this.UiViewSequence.RemoveSequenceFinishEvent("Fix_Done_02", new Action<string>(this.OnFixDone2End));
	}

	// Token: 0x0600709C RID: 28828 RVA: 0x0016FBBC File Offset: 0x0016DDBC
	private void OnPlaySequenceEvent(string sequenceName, string eventName)
	{
		if (eventName == "Sequence_Bottom_In")
		{
			this.IsCanClickFingerprintBtn = true;
		}
	}

	// Token: 0x0600709D RID: 28829 RVA: 0x0016FBD4 File Offset: 0x0016DDD4
	protected override void OnBeforeShow()
	{
		ArtemisActivityCertificationViewParams artemisActivityCertificationViewParams = this.OpenParam as ArtemisActivityCertificationViewParams;
		this.IsPlayFixedDone = (artemisActivityCertificationViewParams != null && artemisActivityCertificationViewParams.IsPlayFixedDone);
		this.FinishCallback = ((artemisActivityCertificationViewParams != null) ? artemisActivityCertificationViewParams.Callback : null);
		this.IsCanClickFingerprintBtn = false;
		if (this.IsPlayFixedDone)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequence("Fix_Done_02", true, null);
			return;
		}
		else
		{
			UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
			if (uiViewSequence2 == null)
			{
				return;
			}
			uiViewSequence2.PlaySequence("Wanring", true, null);
			return;
		}
	}

	// Token: 0x0600709E RID: 28830 RVA: 0x0016FC5F File Offset: 0x0016DE5F
	private void StartVerification()
	{
		if (!this.IsCanClickFingerprintBtn)
		{
			return;
		}
		Action finishCallback = this.FinishCallback;
		if (finishCallback == null)
		{
			return;
		}
		finishCallback();
	}

	// Token: 0x0600709F RID: 28831 RVA: 0x0016FC7A File Offset: 0x0016DE7A
	private void OnFixDone2End(string _)
	{
		Action finishCallback = this.FinishCallback;
		if (finishCallback != null)
		{
			finishCallback();
		}
		base.CloseMe(null);
	}

	// Token: 0x0400343E RID: 13374
	private bool IsPlayFixedDone;

	// Token: 0x0400343F RID: 13375
	private bool IsCanClickFingerprintBtn;

	// Token: 0x04003440 RID: 13376
	[Nullable(2)]
	private Action FinishCallback;

	// Token: 0x020076AA RID: 30378
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04027299 RID: 160409
		public const int FingerprintBtn = 0;

		// Token: 0x0402729A RID: 160410
		public const int CircularProgressBar = 1;

		// Token: 0x0402729B RID: 160411
		public const int ProgressText = 2;

		// Token: 0x0402729C RID: 160412
		public const int PnlFixProgress = 3;

		// Token: 0x0402729D RID: 160413
		public const int PnlPopupTip = 4;

		// Token: 0x0402729E RID: 160414
		public const int ClickTipsText = 5;

		// Token: 0x0402729F RID: 160415
		public const int WarningTipsText = 6;

		// Token: 0x040272A0 RID: 160416
		public const int FixedTipsText = 7;
	}
}
