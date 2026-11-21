using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000599 RID: 1433
[NullableContext(1)]
[Nullable(0)]
public class ArtemisActivityCertificationView : UiViewBase
{
	// Token: 0x0600442D RID: 17453 RVA: 0x001783B5 File Offset: 0x001765B5
	public ArtemisActivityCertificationView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600442E RID: 17454 RVA: 0x001783C0 File Offset: 0x001765C0
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

	// Token: 0x0600442F RID: 17455 RVA: 0x001784AC File Offset: 0x001766AC
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

	// Token: 0x06004430 RID: 17456 RVA: 0x00178536 File Offset: 0x00176736
	protected override void OnAddEventListener()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.AddSequenceFinishEvent("Fix_Done_02", new Action<string>(this.OnFixDone2End), false);
	}

	// Token: 0x06004431 RID: 17457 RVA: 0x0017855A File Offset: 0x0017675A
	protected override void OnRemoveEventListener()
	{
		this.UiViewSequence.RemoveSequenceFinishEvent("Fix_Done_02", new Action<string>(this.OnFixDone2End));
	}

	// Token: 0x06004432 RID: 17458 RVA: 0x00178578 File Offset: 0x00176778
	private void OnPlaySequenceEvent(string sequenceName, string eventName)
	{
		if (eventName == "Sequence_Bottom_In")
		{
			this.IsCanClickFingerprintBtn = true;
		}
	}

	// Token: 0x06004433 RID: 17459 RVA: 0x00178590 File Offset: 0x00176790
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

	// Token: 0x06004434 RID: 17460 RVA: 0x0017861B File Offset: 0x0017681B
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

	// Token: 0x06004435 RID: 17461 RVA: 0x00178636 File Offset: 0x00176836
	private void OnFixDone2End(string _)
	{
		Action finishCallback = this.FinishCallback;
		if (finishCallback != null)
		{
			finishCallback();
		}
		base.CloseMe(null);
	}

	// Token: 0x040034D7 RID: 13527
	private bool IsPlayFixedDone;

	// Token: 0x040034D8 RID: 13528
	private bool IsCanClickFingerprintBtn;

	// Token: 0x040034D9 RID: 13529
	[Nullable(2)]
	private Action FinishCallback;

	// Token: 0x0200683E RID: 26686
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040225E2 RID: 140770
		public const int FingerprintBtn = 0;

		// Token: 0x040225E3 RID: 140771
		public const int CircularProgressBar = 1;

		// Token: 0x040225E4 RID: 140772
		public const int ProgressText = 2;

		// Token: 0x040225E5 RID: 140773
		public const int PnlFixProgress = 3;

		// Token: 0x040225E6 RID: 140774
		public const int PnlPopupTip = 4;

		// Token: 0x040225E7 RID: 140775
		public const int ClickTipsText = 5;

		// Token: 0x040225E8 RID: 140776
		public const int WarningTipsText = 6;

		// Token: 0x040225E9 RID: 140777
		public const int FixedTipsText = 7;
	}
}
