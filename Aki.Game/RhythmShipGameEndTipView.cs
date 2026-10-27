using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200108E RID: 4238
[NullableContext(1)]
[Nullable(0)]
public class RhythmShipGameEndTipView : UiViewBase
{
	// Token: 0x06006E4B RID: 28235 RVA: 0x00167791 File Offset: 0x00165991
	public RhythmShipGameEndTipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06006E4C RID: 28236 RVA: 0x001677C8 File Offset: 0x001659C8
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

	// Token: 0x06006E4D RID: 28237 RVA: 0x00167864 File Offset: 0x00165A64
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

	// Token: 0x06006E4E RID: 28238 RVA: 0x001679C0 File Offset: 0x00165BC0
	protected override void OnAfterPlayStartSequence()
	{
		TimerSystem.Instance.Delay(delegate(float _)
		{
			base.CloseMe(null);
		}, 500f, null, null, true, 1f);
	}

	// Token: 0x06006E4F RID: 28239 RVA: 0x001679E8 File Offset: 0x00165BE8
	protected override void OnBeforePlayCloseSequence()
	{
		RhythmShipGameEndTipViewOpenParam rhythmShipGameEndTipViewOpenParam = this.OpenParam as RhythmShipGameEndTipViewOpenParam;
		if (rhythmShipGameEndTipViewOpenParam != null && rhythmShipGameEndTipViewOpenParam.Callback != null)
		{
			rhythmShipGameEndTipViewOpenParam.Callback();
		}
	}

	// Token: 0x06006E50 RID: 28240 RVA: 0x00167A18 File Offset: 0x00165C18
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		RhythmShipGameEndTipView.<OnPlayingStartSequenceAsync>d__10 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<RhythmShipGameEndTipView.<OnPlayingStartSequenceAsync>d__10>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0400330E RID: 13070
	private readonly string FcTextKey = "RhythmStageClear_02";

	// Token: 0x0400330F RID: 13071
	private readonly string FpTextKey = "RhythmStageClear_03";

	// Token: 0x04003310 RID: 13072
	private readonly string FinishTextKey = "RhythmStageClear_01";

	// Token: 0x04003311 RID: 13073
	private readonly string AccuracyTextKey = "PrefabTextItem_1492520868_Text";

	// Token: 0x02007683 RID: 30339
	[NullableContext(0)]
	private enum EViewComponent
	{
		// Token: 0x040271AF RID: 160175
		BtnMask,
		// Token: 0x040271B0 RID: 160176
		TxtTitle,
		// Token: 0x040271B1 RID: 160177
		TxtAchieve,
		// Token: 0x040271B2 RID: 160178
		TexLevelBg,
		// Token: 0x040271B3 RID: 160179
		TexLevelIcon,
		// Token: 0x040271B4 RID: 160180
		TxtLevel
	}
}
