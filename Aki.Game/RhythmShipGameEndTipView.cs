using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000542 RID: 1346
[NullableContext(1)]
[Nullable(0)]
public class RhythmShipGameEndTipView : UiViewBase
{
	// Token: 0x060041E0 RID: 16864 RVA: 0x001700C5 File Offset: 0x0016E2C5
	public RhythmShipGameEndTipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060041E1 RID: 16865 RVA: 0x001700FC File Offset: 0x0016E2FC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIText))
		};
	}

	// Token: 0x060041E2 RID: 16866 RVA: 0x00170198 File Offset: 0x0016E398
	protected override void OnBeforeShow()
	{
		RhythmShipGameEndTipViewOpenParam rhythmShipGameEndTipViewOpenParam = this.OpenParam as RhythmShipGameEndTipViewOpenParam;
		if (rhythmShipGameEndTipViewOpenParam == null)
		{
			Log.Instance.Error(ELogModule.RhythmGame, ELogAuthor.CH, "RhythmShipGameEndTipView OpenParam is undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		if (rhythmShipGameEndTipViewOpenParam.Level < 1)
		{
			Log.Instance.Error(ELogModule.RhythmGame, ELogAuthor.CH, "RhythmShipGameEndTipView Level is less than 1", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		string resourcePath = UiResourceConfig.Instance.GetResourcePath(RhythmShipDefine.rhythmShipLevelRatingBgTexture[rhythmShipGameEndTipViewOpenParam.Level]);
		string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(RhythmShipDefine.rhythmShipLevelRatingSettlementTexture[rhythmShipGameEndTipViewOpenParam.Level]);
		base.SetTextureByPath(resourcePath, base.GetTexture(3), null, null);
		base.SetTextureByPath(resourcePath2, base.GetTexture(4), null, null);
		if (rhythmShipGameEndTipViewOpenParam.IsFp)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.FpTextKey, Array.Empty<object>());
		}
		else if (rhythmShipGameEndTipViewOpenParam.IsFc)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.FcTextKey, Array.Empty<object>());
		}
		else
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), this.FinishTextKey, Array.Empty<object>());
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.AccuracyTextKey, new <>z__ReadOnlySingleElementList<object>(rhythmShipGameEndTipViewOpenParam.Accuracy.ToString()));
	}

	// Token: 0x060041E3 RID: 16867 RVA: 0x001702F4 File Offset: 0x0016E4F4
	protected override void OnAfterPlayStartSequence()
	{
		TimerSystem.Instance.Delay(delegate(float _)
		{
			base.CloseMe(null);
		}, 500f, null, null, true, 1f);
	}

	// Token: 0x060041E4 RID: 16868 RVA: 0x0017031C File Offset: 0x0016E51C
	protected override void OnBeforePlayCloseSequence()
	{
		RhythmShipGameEndTipViewOpenParam rhythmShipGameEndTipViewOpenParam = this.OpenParam as RhythmShipGameEndTipViewOpenParam;
		if (rhythmShipGameEndTipViewOpenParam != null && rhythmShipGameEndTipViewOpenParam.Callback != null)
		{
			rhythmShipGameEndTipViewOpenParam.Callback();
		}
	}

	// Token: 0x060041E5 RID: 16869 RVA: 0x0017034C File Offset: 0x0016E54C
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		RhythmShipGameEndTipView.<OnPlayingStartSequenceAsync>d__10 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<RhythmShipGameEndTipView.<OnPlayingStartSequenceAsync>d__10>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x040033A7 RID: 13223
	private readonly string FcTextKey = "RhythmStageClear_02";

	// Token: 0x040033A8 RID: 13224
	private readonly string FpTextKey = "RhythmStageClear_03";

	// Token: 0x040033A9 RID: 13225
	private readonly string FinishTextKey = "RhythmStageClear_01";

	// Token: 0x040033AA RID: 13226
	private readonly string AccuracyTextKey = "PrefabTextItem_1492520868_Text";

	// Token: 0x02006817 RID: 26647
	[NullableContext(0)]
	private enum EViewComponent
	{
		// Token: 0x040224FA RID: 140538
		BtnMask,
		// Token: 0x040224FB RID: 140539
		TxtTitle,
		// Token: 0x040224FC RID: 140540
		TxtAchieve,
		// Token: 0x040224FD RID: 140541
		TexLevelBg,
		// Token: 0x040224FE RID: 140542
		TexLevelIcon,
		// Token: 0x040224FF RID: 140543
		TxtLevel
	}
}
