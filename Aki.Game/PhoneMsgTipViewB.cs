using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200252D RID: 9517
[NullableContext(1)]
[Nullable(0)]
public class PhoneMsgTipViewB : UiTickViewBase
{
	// Token: 0x06013228 RID: 78376 RVA: 0x004BFE5C File Offset: 0x004BE05C
	public PhoneMsgTipViewB(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013229 RID: 78377 RVA: 0x004BFE98 File Offset: 0x004BE098
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.TurnToPhoneMsgPanel))
		};
	}

	// Token: 0x0601322A RID: 78378 RVA: 0x004BFF00 File Offset: 0x004BE100
	protected override void OnStart()
	{
		this.MsgData = (this.OpenParam as ShortMessage?);
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		if (this.MsgData == null)
		{
			base.CloseMe(null);
		}
		this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnEventSequence));
	}

	// Token: 0x0601322B RID: 78379 RVA: 0x004BFF64 File Offset: 0x004BE164
	protected override void OnTick(float delta)
	{
		if (this.HaveClosed)
		{
			return;
		}
		this.CloseTimerDown -= delta;
		float fillAmount = this.CloseTimerDown / 4000f;
		base.GetSprite(1).SetFillAmount(fillAmount);
		if (this.CloseTimerDown <= 0f)
		{
			this.HaveClosed = true;
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.StopSequenceByKey("Out", false, false);
			}
			LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
			if (seqPlayer2 == null)
			{
				return;
			}
			seqPlayer2.PlayLevelSequenceByName("Out", false, null, false);
		}
	}

	// Token: 0x0601322C RID: 78380 RVA: 0x004BFFEE File Offset: 0x004BE1EE
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.Clear();
		}
		this.SeqPlayer = null;
		LguiFloatTween locationXTween = this.LocationXTween;
		if (locationXTween != null)
		{
			locationXTween.Destroy();
		}
		LguiFloatTween locationYTween = this.LocationYTween;
		if (locationYTween == null)
		{
			return;
		}
		locationYTween.Destroy();
	}

	// Token: 0x0601322D RID: 78381 RVA: 0x004C002C File Offset: 0x004BE22C
	public int? GetMessageDataId()
	{
		if (this.MsgData == null)
		{
			return null;
		}
		return new int?(this.MsgData.Value.Id);
	}

	// Token: 0x0601322E RID: 78382 RVA: 0x004C0068 File Offset: 0x004BE268
	private void OnEventSequence(string sequenceName, string eventName)
	{
		if (eventName == "Close_UI")
		{
			base.CloseMe(null);
		}
		if (eventName == "Particle_In")
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.BattleView);
			if (viewByName == null)
			{
				return;
			}
			BattleViewProxy battleViewProxy = viewByName.OpenParam as BattleViewProxy;
			if (battleViewProxy == null)
			{
				return;
			}
			UUIItem topPanelPhoneMsgButtonItem = battleViewProxy.GetTopPanelPhoneMsgButtonItem();
			if (topPanelPhoneMsgButtonItem == null)
			{
				return;
			}
			this.FlyToLocation(topPanelPhoneMsgButtonItem);
		}
	}

	// Token: 0x0601322F RID: 78383 RVA: 0x004C00D0 File Offset: 0x004BE2D0
	private void FlyToLocation(UUIItem item)
	{
		this.LocationXTween = new LguiFloatTween();
		this.LocationXTween.BindUpdateTween(delegate(float value)
		{
			this.TipsWorldPos.X = (double)value;
			UUIItem rootItem = this.RootItem;
			FVector fvector = this.TipsWorldPos.ToUeVectorOld();
			rootItem.SetUIWorldLocation(fvector);
		});
		this.LocationYTween = new LguiFloatTween();
		this.LocationYTween.BindUpdateTween(delegate(float value)
		{
			this.TipsWorldPos.Z = (double)value;
			UUIItem rootItem = this.RootItem;
			FVector fvector = this.TipsWorldPos.ToUeVectorOld();
			rootItem.SetUIWorldLocation(fvector);
		});
		float time = 0.25f;
		FVectorDouble fvectorDouble = this.RootItem.D_K2_GetComponentLocation();
		FVectorDouble fvectorDouble2 = item.D_K2_GetComponentLocation();
		this.TipsWorldPos.DeepCopy(fvectorDouble);
		this.LocationXTween.PlayTween((float)fvectorDouble.X, (float)fvectorDouble2.X, time, this.CurveX);
		this.LocationYTween.PlayTween((float)fvectorDouble.Z, (float)fvectorDouble2.Z, time, this.CurveY);
	}

	// Token: 0x06013230 RID: 78384 RVA: 0x004C0187 File Offset: 0x004BE387
	private void TurnToPhoneMsgPanel()
	{
		this.needShowTips = true;
		base.CloseMe(null);
	}

	// Token: 0x06013231 RID: 78385 RVA: 0x004C0197 File Offset: 0x004BE397
	protected override void OnAfterDestroyImplement()
	{
		if (this.needShowTips)
		{
			UiManager.Instance.OpenView(EUiViewName.PhoneMsgPanelViewBig, this.MsgData, null);
		}
	}

	// Token: 0x0400907B RID: 36987
	private ShortMessage? MsgData;

	// Token: 0x0400907C RID: 36988
	private float CloseTimerDown = 4000f;

	// Token: 0x0400907D RID: 36989
	private bool HaveClosed;

	// Token: 0x0400907E RID: 36990
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0400907F RID: 36991
	private LguiFloatTween LocationXTween;

	// Token: 0x04009080 RID: 36992
	private LguiFloatTween LocationYTween;

	// Token: 0x04009081 RID: 36993
	private readonly UCurveFloat CurveX;

	// Token: 0x04009082 RID: 36994
	private readonly UCurveFloat CurveY;

	// Token: 0x04009083 RID: 36995
	private const float CLOSE_TIME = 4000f;

	// Token: 0x04009084 RID: 36996
	protected global::Vector TipsWorldPos = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04009085 RID: 36997
	private bool needShowTips;

	// Token: 0x02008AB6 RID: 35510
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402D0C5 RID: 184517
		BtnClick,
		// Token: 0x0402D0C6 RID: 184518
		ItemProgressBar
	}
}
