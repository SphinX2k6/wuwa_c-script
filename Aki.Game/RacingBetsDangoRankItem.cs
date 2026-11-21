using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BFD RID: 7165
[NullableContext(2)]
[Nullable(0)]
public class RacingBetsDangoRankItem : UiPanelBase
{
	// Token: 0x06011CE9 RID: 72937 RVA: 0x0053C430 File Offset: 0x0053A630
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06011CEA RID: 72938 RVA: 0x0053C4B6 File Offset: 0x0053A6B6
	protected override void OnBeforeCreateImplement()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
	}

	// Token: 0x06011CEB RID: 72939 RVA: 0x0053C4D0 File Offset: 0x0053A6D0
	[NullableContext(1)]
	public void Init(RacingBetsDungeonDangoInfo data, UCurveFloat lerpCurve, int itemInterval)
	{
		this.DangoInfo = data;
		this.LerpCurve = lerpCurve;
		this.DangoRankInterval = itemInterval;
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.SetText(data.Rank.ToString(), true);
		}
		DangoData dangoData = DangoManager.Instance.GetDangoData(data.DangoId);
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.ShowTextNew(dangoData.NameKey);
		}
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetAnchorOffsetY(this.GetDangoAnchorOffsetY(data.Rank));
		}
		base.SetTextureShowUntilLoaded(dangoData.DangoConfig.Value.IconSmall, base.GetTexture(1), null);
		Dice? diceConfig = data.GetDiceConfig();
		if (diceConfig != null)
		{
			base.SetTextureShowUntilLoaded(diceConfig.Value.RollDiceBackgroundIcon, base.GetTexture(3), null);
		}
		bool uiactive = RacingBetsModel.Instance.IsDungeonBettingDango(data.DangoId);
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x06011CEC RID: 72940 RVA: 0x0053C5C8 File Offset: 0x0053A7C8
	public UniTask RefreshAsync()
	{
		RacingBetsDangoRankItem.<RefreshAsync>d__14 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<RacingBetsDangoRankItem.<RefreshAsync>d__14>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011CED RID: 72941 RVA: 0x0053C60C File Offset: 0x0053A80C
	public UniTask LerpRankTargetPosition()
	{
		RacingBetsDangoRankItem.<LerpRankTargetPosition>d__15 <LerpRankTargetPosition>d__;
		<LerpRankTargetPosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LerpRankTargetPosition>d__.<>4__this = this;
		<LerpRankTargetPosition>d__.<>1__state = -1;
		<LerpRankTargetPosition>d__.<>t__builder.Start<RacingBetsDangoRankItem.<LerpRankTargetPosition>d__15>(ref <LerpRankTargetPosition>d__);
		return <LerpRankTargetPosition>d__.<>t__builder.Task;
	}

	// Token: 0x06011CEE RID: 72942 RVA: 0x0053C650 File Offset: 0x0053A850
	private void OnTick(float deltaTime)
	{
		this.CurLerpTime += deltaTime;
		float num = (float)this.LerpTime / Time.Instance.TimeDilation;
		if (this.CurLerpTime >= num)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetAnchorOffsetY(this.EndOffsetY);
			}
			this.ReleaseLerpPromise();
			this.ReleaseHandle();
			return;
		}
		if (this.LerpCurve != null)
		{
			float anchorOffsetY = this.LerpCurve.GetFloatValue(this.CurLerpTime / num) * (this.EndOffsetY - this.StartOffsetY) + this.StartOffsetY;
			UUIItem rootItem2 = this.RootItem;
			if (rootItem2 == null)
			{
				return;
			}
			rootItem2.SetAnchorOffsetY(anchorOffsetY);
		}
	}

	// Token: 0x06011CEF RID: 72943 RVA: 0x0053C6ED File Offset: 0x0053A8ED
	protected override void OnBeforeDestroy()
	{
		this.ReleaseHandle();
		this.ReleaseLerpPromise();
	}

	// Token: 0x06011CF0 RID: 72944 RVA: 0x0053C6FB File Offset: 0x0053A8FB
	private float GetDangoAnchorOffsetY(int rank)
	{
		if (this.RootItem == null)
		{
			return 0f;
		}
		return (float)(-(float)(rank - 1)) * (this.RootItem.GetHeight() + (float)this.DangoRankInterval);
	}

	// Token: 0x06011CF1 RID: 72945 RVA: 0x0053C724 File Offset: 0x0053A924
	public void ReleaseHandle()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06011CF2 RID: 72946 RVA: 0x0053C746 File Offset: 0x0053A946
	private void ReleaseLerpPromise()
	{
		if (this.LerpPromise != null)
		{
			this.LerpPromise.SetResult();
			this.LerpPromise = null;
		}
	}

	// Token: 0x04009B91 RID: 39825
	public UiBehaviorLevelSequence UiLevelSequence;

	// Token: 0x04009B92 RID: 39826
	[Nullable(1)]
	private RacingBetsDungeonDangoInfo DangoInfo;

	// Token: 0x04009B93 RID: 39827
	private int DangoRankInterval;

	// Token: 0x04009B94 RID: 39828
	public int LerpTime = 1000;

	// Token: 0x04009B95 RID: 39829
	private float CurLerpTime;

	// Token: 0x04009B96 RID: 39830
	private float StartOffsetY;

	// Token: 0x04009B97 RID: 39831
	private float EndOffsetY;

	// Token: 0x04009B98 RID: 39832
	private CustomPromise LerpPromise;

	// Token: 0x04009B99 RID: 39833
	private TimerHandle TimerHandle;

	// Token: 0x04009B9A RID: 39834
	private UCurveFloat LerpCurve;

	// Token: 0x02007EE9 RID: 32489
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029119 RID: 168217
		RankText,
		// Token: 0x0402911A RID: 168218
		HeadTexture,
		// Token: 0x0402911B RID: 168219
		NameText,
		// Token: 0x0402911C RID: 168220
		DiceTexture,
		// Token: 0x0402911D RID: 168221
		BetItem
	}
}
