using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001190 RID: 4496
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowHpPlayerItem : UiPanelBase
{
	// Token: 0x0600B34E RID: 45902 RVA: 0x0034FDD4 File Offset: 0x0034DFD4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(1, typeof(UUIArtText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
	}

	// Token: 0x0600B34F RID: 45903 RVA: 0x0034FE5C File Offset: 0x0034E05C
	protected override void OnStart()
	{
		this.HpText = base.GetArtText(1);
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.TweenAnimPlayer.InitTweenAnim(2, base.GetItem(2), false);
		this.TweenAnimPlayer.InitTweenAnim(3, base.GetItem(3), false);
		this.TweenAnimPlayer.InitTweenAnim(4, base.GetItem(4), false);
		this.TweenAnimPlayer.InitTweenAnim(5, base.GetItem(5), false);
		this.DigitScroll.Init(0f, 0f, 500f);
	}

	// Token: 0x0600B350 RID: 45904 RVA: 0x0034FEF4 File Offset: 0x0034E0F4
	protected override void OnBeforeShow()
	{
		this.OnAddEventListener();
		this.InitPlayerData();
		this.SequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600B351 RID: 45905 RVA: 0x0034FF2A File Offset: 0x0034E12A
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x0600B352 RID: 45906 RVA: 0x0034FF32 File Offset: 0x0034E132
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnKscPlayerHpChanged, new Action(this.OnKscPlayerHpChanged));
		EventSystem.Instance.Add(EEventName.OnKscPlayerCreate, new Action(this.OnKscPlayerCreate));
	}

	// Token: 0x0600B353 RID: 45907 RVA: 0x0034FF6C File Offset: 0x0034E16C
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnKscPlayerHpChanged, new Action(this.OnKscPlayerHpChanged));
		EventSystem.Instance.Remove(EEventName.OnKscPlayerCreate, new Action(this.OnKscPlayerCreate));
	}

	// Token: 0x0600B354 RID: 45908 RVA: 0x0034FFA6 File Offset: 0x0034E1A6
	private void OnKscPlayerCreate()
	{
		this.InitPlayerData();
	}

	// Token: 0x0600B355 RID: 45909 RVA: 0x0034FFB0 File Offset: 0x0034E1B0
	public void InitPlayerData()
	{
		KscSubModelBase curSubModel = KuroSimpleCombatController.Instance.CurSubModel;
		AKSC_Entity aksc_Entity = (curSubModel != null) ? curSubModel.KscPlayerEntity : null;
		if (aksc_Entity == null)
		{
			return;
		}
		UKSC_SkillComp skillComp = aksc_Entity.GetSkillComp();
		TMap<EKSC_AttrType, int> tmap;
		if (skillComp == null)
		{
			tmap = null;
		}
		else
		{
			UKSC_AttrSet attrSet_ = skillComp.AttrSet_;
			tmap = ((attrSet_ != null) ? attrSet_.Attrs_ : null);
		}
		TMap<EKSC_AttrType, int> tmap2 = tmap;
		if (tmap2 == null)
		{
			return;
		}
		Log.Instance.Info(ELogModule.UiComponent, ELogAuthor.TZQ, "[摩托战斗]UI初始化角色生命值成功", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.AttrMap = tmap2;
		this.RefreshHpInfo();
	}

	// Token: 0x0600B356 RID: 45910 RVA: 0x00350024 File Offset: 0x0034E224
	private void OnKscPlayerHpChanged()
	{
		this.RefreshHpInfo();
	}

	// Token: 0x0600B357 RID: 45911 RVA: 0x0035002C File Offset: 0x0034E22C
	public void RefreshHpInfo()
	{
		int num = 0;
		if (this.AttrMap != null)
		{
			num = this.AttrMap.Get(EKSC_AttrType.Life);
		}
		if (this.LastHp == num)
		{
			return;
		}
		if (!this.IsFirst)
		{
			this.DigitScroll.SetTarget((float)num);
			this.SequencePlayer.StopPlayingSequence(false, true);
			if (num > this.LastHp)
			{
				this.TweenAnimPlayer.PlayTweenAnim(5);
				this.TweenAnimPlayer.PlayTweenAnim(3);
			}
			else
			{
				this.TweenAnimPlayer.PlayTweenAnim(4);
				this.TweenAnimPlayer.PlayTweenAnim(2);
				AudioSystem.Instance.PostEvent("play_ui_moto_battle_hurt_start");
			}
		}
		else
		{
			this.DigitScroll.Reset((float)num);
			UUIArtText hpText = this.HpText;
			if (hpText != null)
			{
				hpText.SetText(MotorcycleUtil.CompactNumberFormat((float)num));
			}
		}
		this.IsFirst = false;
		this.LastHp = num;
	}

	// Token: 0x0600B358 RID: 45912 RVA: 0x00350100 File Offset: 0x0034E300
	public void OnTick(float delta)
	{
		if (!this.DigitScroll.IsFinished())
		{
			float num = this.DigitScroll.Tick(delta);
			UUIArtText hpText = this.HpText;
			if (hpText == null)
			{
				return;
			}
			hpText.SetText(MotorcycleUtil.CompactNumberFormat((float)Math.Floor((double)num)));
		}
	}

	// Token: 0x0400677D RID: 26493
	private const int SCROLL_DURATION = 500;

	// Token: 0x0400677E RID: 26494
	private const string HURT_EVENT_NAME = "play_ui_moto_battle_hurt_start";

	// Token: 0x0400677F RID: 26495
	[Nullable(2)]
	protected UUIArtText HpText;

	// Token: 0x04006780 RID: 26496
	[Nullable(2)]
	private TMap<EKSC_AttrType, int> AttrMap;

	// Token: 0x04006781 RID: 26497
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04006782 RID: 26498
	private int LastHp = -1;

	// Token: 0x04006783 RID: 26499
	private bool IsFirst = true;

	// Token: 0x04006784 RID: 26500
	private readonly DigitScroll DigitScroll = new DigitScroll();

	// Token: 0x04006785 RID: 26501
	private readonly BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

	// Token: 0x02007457 RID: 29783
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04025DD9 RID: 155097
		public const int Self = 0;

		// Token: 0x04025DDA RID: 155098
		public const int HpText = 1;

		// Token: 0x04025DDB RID: 155099
		public const int Hit = 2;

		// Token: 0x04025DDC RID: 155100
		public const int Life = 3;

		// Token: 0x04025DDD RID: 155101
		public const int HitEnd = 4;

		// Token: 0x04025DDE RID: 155102
		public const int LifeEnd = 5;
	}
}
