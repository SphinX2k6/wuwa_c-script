using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RacingBets;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002712 RID: 10002
[NullableContext(2)]
[Nullable(0)]
public class RacingBetsDangoRankItem : UiPanelBase
{
	// Token: 0x06014807 RID: 83975 RVA: 0x0052D714 File Offset: 0x0052B914
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

	// Token: 0x06014808 RID: 83976 RVA: 0x0052D79A File Offset: 0x0052B99A
	protected override void OnBeforeCreateImplement()
	{
		this.UiLevelSequence = new UiBehaviorLevelSequence(this);
		base.AddUiBehavior(this.UiLevelSequence);
	}

	// Token: 0x06014809 RID: 83977 RVA: 0x0052D7B4 File Offset: 0x0052B9B4
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

	// Token: 0x0601480A RID: 83978 RVA: 0x0052D8AC File Offset: 0x0052BAAC
	public UniTask RefreshAsync()
	{
		RacingBetsDangoRankItem.<RefreshAsync>d__14 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<RacingBetsDangoRankItem.<RefreshAsync>d__14>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601480B RID: 83979 RVA: 0x0052D8F0 File Offset: 0x0052BAF0
	public UniTask LerpRankTargetPosition()
	{
		RacingBetsDangoRankItem.<LerpRankTargetPosition>d__15 <LerpRankTargetPosition>d__;
		<LerpRankTargetPosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LerpRankTargetPosition>d__.<>4__this = this;
		<LerpRankTargetPosition>d__.<>1__state = -1;
		<LerpRankTargetPosition>d__.<>t__builder.Start<RacingBetsDangoRankItem.<LerpRankTargetPosition>d__15>(ref <LerpRankTargetPosition>d__);
		return <LerpRankTargetPosition>d__.<>t__builder.Task;
	}

	// Token: 0x0601480C RID: 83980 RVA: 0x0052D934 File Offset: 0x0052BB34
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

	// Token: 0x0601480D RID: 83981 RVA: 0x0052D9D1 File Offset: 0x0052BBD1
	protected override void OnBeforeDestroy()
	{
		this.ReleaseHandle();
		this.ReleaseLerpPromise();
	}

	// Token: 0x0601480E RID: 83982 RVA: 0x0052D9DF File Offset: 0x0052BBDF
	private float GetDangoAnchorOffsetY(int rank)
	{
		if (this.RootItem == null)
		{
			return 0f;
		}
		return (float)(-(float)(rank - 1)) * (this.RootItem.GetHeight() + (float)this.DangoRankInterval);
	}

	// Token: 0x0601480F RID: 83983 RVA: 0x0052DA08 File Offset: 0x0052BC08
	public void ReleaseHandle()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x06014810 RID: 83984 RVA: 0x0052DA2A File Offset: 0x0052BC2A
	private void ReleaseLerpPromise()
	{
		if (this.LerpPromise != null)
		{
			this.LerpPromise.SetResult();
			this.LerpPromise = null;
		}
	}

	// Token: 0x04009A39 RID: 39481
	public UiBehaviorLevelSequence UiLevelSequence;

	// Token: 0x04009A3A RID: 39482
	[Nullable(1)]
	private RacingBetsDungeonDangoInfo DangoInfo;

	// Token: 0x04009A3B RID: 39483
	private int DangoRankInterval;

	// Token: 0x04009A3C RID: 39484
	public int LerpTime = 1000;

	// Token: 0x04009A3D RID: 39485
	private float CurLerpTime;

	// Token: 0x04009A3E RID: 39486
	private float StartOffsetY;

	// Token: 0x04009A3F RID: 39487
	private float EndOffsetY;

	// Token: 0x04009A40 RID: 39488
	private CustomPromise LerpPromise;

	// Token: 0x04009A41 RID: 39489
	private TimerHandle TimerHandle;

	// Token: 0x04009A42 RID: 39490
	private UCurveFloat LerpCurve;

	// Token: 0x02008D60 RID: 36192
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402DE02 RID: 187906
		RankText,
		// Token: 0x0402DE03 RID: 187907
		HeadTexture,
		// Token: 0x0402DE04 RID: 187908
		NameText,
		// Token: 0x0402DE05 RID: 187909
		DiceTexture,
		// Token: 0x0402DE06 RID: 187910
		BetItem
	}
}
