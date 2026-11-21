using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A14 RID: 6676
[NullableContext(1)]
[Nullable(0)]
public class PhoneMsgTipViewB : UiTickViewBase
{
	// Token: 0x060106E8 RID: 67304 RVA: 0x004CDB68 File Offset: 0x004CBD68
	public PhoneMsgTipViewB(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060106E9 RID: 67305 RVA: 0x004CDBA4 File Offset: 0x004CBDA4
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

	// Token: 0x060106EA RID: 67306 RVA: 0x004CDC0C File Offset: 0x004CBE0C
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

	// Token: 0x060106EB RID: 67307 RVA: 0x004CDC70 File Offset: 0x004CBE70
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

	// Token: 0x060106EC RID: 67308 RVA: 0x004CDCFA File Offset: 0x004CBEFA
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

	// Token: 0x060106ED RID: 67309 RVA: 0x004CDD38 File Offset: 0x004CBF38
	public int? GetMessageDataId()
	{
		if (this.MsgData == null)
		{
			return null;
		}
		return new int?(this.MsgData.Value.Id);
	}

	// Token: 0x060106EE RID: 67310 RVA: 0x004CDD74 File Offset: 0x004CBF74
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

	// Token: 0x060106EF RID: 67311 RVA: 0x004CDDDC File Offset: 0x004CBFDC
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

	// Token: 0x060106F0 RID: 67312 RVA: 0x004CDE93 File Offset: 0x004CC093
	private void TurnToPhoneMsgPanel()
	{
		this.needShowTips = true;
		base.CloseMe(null);
	}

	// Token: 0x060106F1 RID: 67313 RVA: 0x004CDEA3 File Offset: 0x004CC0A3
	protected override void OnAfterDestroyImplement()
	{
		if (this.needShowTips)
		{
			UiManager.Instance.OpenView(EUiViewName.PhoneMsgPanelViewBig, this.MsgData, null);
		}
	}

	// Token: 0x040091D0 RID: 37328
	private ShortMessage? MsgData;

	// Token: 0x040091D1 RID: 37329
	private float CloseTimerDown = 4000f;

	// Token: 0x040091D2 RID: 37330
	private bool HaveClosed;

	// Token: 0x040091D3 RID: 37331
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x040091D4 RID: 37332
	private LguiFloatTween LocationXTween;

	// Token: 0x040091D5 RID: 37333
	private LguiFloatTween LocationYTween;

	// Token: 0x040091D6 RID: 37334
	private readonly UCurveFloat CurveX;

	// Token: 0x040091D7 RID: 37335
	private readonly UCurveFloat CurveY;

	// Token: 0x040091D8 RID: 37336
	private const float CLOSE_TIME = 4000f;

	// Token: 0x040091D9 RID: 37337
	protected global::Vector TipsWorldPos = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x040091DA RID: 37338
	private bool needShowTips;

	// Token: 0x02007C3D RID: 31805
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040283D9 RID: 164825
		BtnClick,
		// Token: 0x040283DA RID: 164826
		ItemProgressBar
	}
}
