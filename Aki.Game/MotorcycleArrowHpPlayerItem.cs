using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CCE RID: 7374
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleArrowHpPlayerItem : UiPanelBase
{
	// Token: 0x0600DF31 RID: 57137 RVA: 0x003443AC File Offset: 0x003425AC
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

	// Token: 0x0600DF32 RID: 57138 RVA: 0x00344434 File Offset: 0x00342634
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

	// Token: 0x0600DF33 RID: 57139 RVA: 0x003444CC File Offset: 0x003426CC
	protected override void OnBeforeShow()
	{
		this.OnAddEventListener();
		this.InitPlayerData();
		this.SequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
	}

	// Token: 0x0600DF34 RID: 57140 RVA: 0x00344502 File Offset: 0x00342702
	protected override void OnBeforeHide()
	{
		this.OnRemoveEventListener();
	}

	// Token: 0x0600DF35 RID: 57141 RVA: 0x0034450A File Offset: 0x0034270A
	protected void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnKscPlayerHpChanged, new Action(this.OnKscPlayerHpChanged));
		EventSystem.Instance.Add(EEventName.OnKscPlayerCreate, new Action(this.OnKscPlayerCreate));
	}

	// Token: 0x0600DF36 RID: 57142 RVA: 0x00344544 File Offset: 0x00342744
	protected void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnKscPlayerHpChanged, new Action(this.OnKscPlayerHpChanged));
		EventSystem.Instance.Remove(EEventName.OnKscPlayerCreate, new Action(this.OnKscPlayerCreate));
	}

	// Token: 0x0600DF37 RID: 57143 RVA: 0x0034457E File Offset: 0x0034277E
	private void OnKscPlayerCreate()
	{
		this.InitPlayerData();
	}

	// Token: 0x0600DF38 RID: 57144 RVA: 0x00344588 File Offset: 0x00342788
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

	// Token: 0x0600DF39 RID: 57145 RVA: 0x003445FC File Offset: 0x003427FC
	private void OnKscPlayerHpChanged()
	{
		this.RefreshHpInfo();
	}

	// Token: 0x0600DF3A RID: 57146 RVA: 0x00344604 File Offset: 0x00342804
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

	// Token: 0x0600DF3B RID: 57147 RVA: 0x003446D8 File Offset: 0x003428D8
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

	// Token: 0x0400669E RID: 26270
	private const int SCROLL_DURATION = 500;

	// Token: 0x0400669F RID: 26271
	private const string HURT_EVENT_NAME = "play_ui_moto_battle_hurt_start";

	// Token: 0x040066A0 RID: 26272
	[Nullable(2)]
	protected UUIArtText HpText;

	// Token: 0x040066A1 RID: 26273
	[Nullable(2)]
	private TMap<EKSC_AttrType, int> AttrMap;

	// Token: 0x040066A2 RID: 26274
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x040066A3 RID: 26275
	private int LastHp = -1;

	// Token: 0x040066A4 RID: 26276
	private bool IsFirst = true;

	// Token: 0x040066A5 RID: 26277
	private readonly DigitScroll DigitScroll = new DigitScroll();

	// Token: 0x040066A6 RID: 26278
	private readonly BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();

	// Token: 0x020082CE RID: 33486
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402AAB1 RID: 174769
		public const int Self = 0;

		// Token: 0x0402AAB2 RID: 174770
		public const int HpText = 1;

		// Token: 0x0402AAB3 RID: 174771
		public const int Hit = 2;

		// Token: 0x0402AAB4 RID: 174772
		public const int Life = 3;

		// Token: 0x0402AAB5 RID: 174773
		public const int HitEnd = 4;

		// Token: 0x0402AAB6 RID: 174774
		public const int LifeEnd = 5;
	}
}
