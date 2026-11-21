using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000525 RID: 1317
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerHeadItem : UiPanelBase
{
	// Token: 0x0600404A RID: 16458 RVA: 0x00168514 File Offset: 0x00166714
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(11, typeof(UUISprite)),
			new ValueTuple<int, Type>(12, typeof(UUITexture)),
			new ValueTuple<int, Type>(13, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(10, new Action(this.OnClickSkillButton))
		};
	}

	// Token: 0x0600404B RID: 16459 RVA: 0x0016868C File Offset: 0x0016688C
	protected override void OnStart()
	{
		this.HpLayout = new GenericLayout<GuessJokerHpItem, bool>(base.GetHorizontalLayout(2), new Func<GuessJokerHpItem>(this.CreateHpItem), (AUIBaseActor)base.GetItem(3).GetOwner(), false, true);
		base.GetItem(6).SetUIActive(false);
		base.GetItem(8).SetUIActive(false);
		this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		AUIBaseActor auibaseActor = base.GetButton(10).GetOwner() as AUIBaseActor;
		this.SkillButtonSequencePlayer = new LevelSequencePlayer((auibaseActor != null) ? auibaseActor.GetUIItem() : null);
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceFinish), false);
		}
		LevelSequencePlayer skillButtonSequencePlayer = this.SkillButtonSequencePlayer;
		if (skillButtonSequencePlayer == null)
		{
			return;
		}
		skillButtonSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceFinish), false);
	}

	// Token: 0x0600404C RID: 16460 RVA: 0x0016875C File Offset: 0x0016695C
	private void OnSequenceFinish(string sequenceName)
	{
		Action action;
		if (this.SequenceFinishCallbackMap.TryGetValue(sequenceName, out action))
		{
			if (action != null)
			{
				action();
			}
			this.SequenceFinishCallbackMap.Remove(sequenceName);
		}
	}

	// Token: 0x0600404D RID: 16461 RVA: 0x0016878F File Offset: 0x0016698F
	public void SetRoleData(GuessJokerRoleData roleData)
	{
		this.RoleData = roleData;
		this.InitView();
	}

	// Token: 0x170008E9 RID: 2281
	// (get) Token: 0x0600404E RID: 16462 RVA: 0x0016879E File Offset: 0x0016699E
	public int Hp
	{
		get
		{
			GuessJokerRoleData roleData = this.RoleData;
			if (roleData == null)
			{
				return 0;
			}
			return roleData.GetHp();
		}
	}

	// Token: 0x0600404F RID: 16463 RVA: 0x001687B4 File Offset: 0x001669B4
	public void InitView()
	{
		if (this.RoleData == null)
		{
			return;
		}
		int num;
		if (this.RoleData.GetPlayerType() == EGuessJokerPlayerType.Me)
		{
			num = RoleModel.Instance.GetCurSelectMainRoleId().Value;
		}
		else
		{
			num = GuessJokerGamePlayModel.Instance.GetRoleId();
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(num);
		if (roleConfig != null)
		{
			base.SetRoleIcon(roleConfig.Value.RoleHeadIconCircle, base.GetTexture(1), num, null, null);
		}
		bool isFinish = GuessJokerGamePlayModel.Instance.IsFinish;
		this.SetSkillUnlock(isFinish);
		GuessJokerRoleData roleData = this.RoleData;
		int num2 = (roleData != null) ? roleData.GetMaxHp() : 0;
		List<bool> list = new List<bool>(num2);
		for (int i = 0; i < num2; i++)
		{
			list.Add(false);
		}
		GuessJokerRoleData roleData2 = this.RoleData;
		int num3 = (roleData2 != null) ? roleData2.GetHp() : 0;
		for (int j = 0; j < num3; j++)
		{
			list[j] = true;
		}
		this.HpLayout.RefreshByData(list, null, false);
		base.GetItem(5).SetUIActive(false);
	}

	// Token: 0x06004050 RID: 16464 RVA: 0x001688C8 File Offset: 0x00166AC8
	[NullableContext(2)]
	public void UpdateHp(Action completeCallback = null)
	{
		string sequenceName = "PlayerHit";
		if (this.IsPlayer)
		{
			sequenceName = "MeHit";
		}
		this.PlayHeadSequence(sequenceName, delegate
		{
			GuessJokerRoleData roleData = this.RoleData;
			int num = (roleData != null) ? roleData.GetMaxHp() : 0;
			List<bool> list = new List<bool>(num);
			for (int i = 0; i < num; i++)
			{
				list.Add(false);
			}
			GuessJokerRoleData roleData2 = this.RoleData;
			int num2 = (roleData2 != null) ? roleData2.GetHp() : 0;
			for (int j = 0; j < num2; j++)
			{
				list[j] = true;
			}
			this.HpLayout.RefreshByData(list, null, false);
			if (num2 <= 0)
			{
				this.PlayHeadSequence("Kill", completeCallback);
				return;
			}
			Action completeCallback2 = completeCallback;
			if (completeCallback2 == null)
			{
				return;
			}
			completeCallback2();
		});
	}

	// Token: 0x06004051 RID: 16465 RVA: 0x00168910 File Offset: 0x00166B10
	public void SetSkillUnlock(bool isUnlock)
	{
		this.IsUnlock = isUnlock;
		bool flag = isUnlock || this.IsPlayer;
		if (flag)
		{
			this.UpdateSkill();
		}
		base.GetSprite(11).SetUIActive(!flag);
		base.GetTexture(12).SetUIActive(flag);
		if (flag)
		{
			this.ShowLockSkillTips(false);
		}
	}

	// Token: 0x06004052 RID: 16466 RVA: 0x00168964 File Offset: 0x00166B64
	private void UpdateSkill()
	{
		if (this.RoleData == null)
		{
			return;
		}
		int skillId;
		if (this.RoleData.GetPlayerType() == EGuessJokerPlayerType.Me)
		{
			skillId = 100001;
		}
		else
		{
			skillId = GuessJokerGamePlayModel.Instance.GetAiSkillId();
		}
		this.SkillId = skillId;
		JokerSkill? jokerSkill = GuessJokerConfig.Instance.GetJokerSkill(skillId);
		if (jokerSkill != null)
		{
			UUITextureTransitionComponent textureTransitionComp = base.GetTexture(12).GetOwner().GetComponentByClass(UUITextureTransitionComponent.StaticClass()) as UUITextureTransitionComponent;
			base.SetTextureByPath(jokerSkill.Value.WhiteSkillIconPath, base.GetTexture(12), null, delegate(bool _)
			{
				textureTransitionComp.SetAllStateTexture(this.GetTexture(12).GetTexture());
			});
		}
	}

	// Token: 0x06004053 RID: 16467 RVA: 0x00168A20 File Offset: 0x00166C20
	public void PlayHeadSequence(string sequenceName, [Nullable(2)] Action finishCallback = null)
	{
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.PlaySequencePurely(sequenceName, false, false, null, null, false);
		}
		if (finishCallback != null)
		{
			this.SequenceFinishCallbackMap[sequenceName] = finishCallback;
		}
	}

	// Token: 0x06004054 RID: 16468 RVA: 0x00168A5C File Offset: 0x00166C5C
	public void SetSelfRound(bool isSelfRound)
	{
		if (isSelfRound)
		{
			base.GetItem(5).SetUIActive(true);
			this.PlayHeadSequence("Sle", null);
			return;
		}
		this.PlayHeadSequence("Unsle", delegate
		{
			base.GetItem(5).SetUIActive(false);
		});
	}

	// Token: 0x06004055 RID: 16469 RVA: 0x00168A94 File Offset: 0x00166C94
	private void PlaySkillButtonSequence(string sequenceName, [Nullable(2)] Action finishCallback = null)
	{
		LevelSequencePlayer skillButtonSequencePlayer = this.SkillButtonSequencePlayer;
		if (skillButtonSequencePlayer != null)
		{
			skillButtonSequencePlayer.PlaySequencePurely(sequenceName, false, false, null, null, false);
		}
		if (finishCallback != null)
		{
			this.SequenceFinishCallbackMap[sequenceName] = finishCallback;
		}
	}

	// Token: 0x06004056 RID: 16470 RVA: 0x00168AD0 File Offset: 0x00166CD0
	private GuessJokerHpItem CreateHpItem()
	{
		return new GuessJokerHpItem();
	}

	// Token: 0x06004057 RID: 16471 RVA: 0x00168AD7 File Offset: 0x00166CD7
	public void SetDialogueText(string textKey)
	{
		if (!this.IsPlayer)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), textKey, Array.Empty<object>());
	}

	// Token: 0x06004058 RID: 16472 RVA: 0x00168AFC File Offset: 0x00166CFC
	[NullableContext(2)]
	public void SetDialogueItemActive(bool active, Action onComplete = null)
	{
		if (!this.IsPlayer)
		{
			return;
		}
		if (active)
		{
			base.GetItem(8).SetUIActive(true);
			this.PlayHeadSequence("WordShow", onComplete);
			return;
		}
		this.PlayHeadSequence("WordHide", delegate
		{
			this.GetItem(8).SetUIActive(false);
			Action onComplete2 = onComplete;
			if (onComplete2 == null)
			{
				return;
			}
			onComplete2();
		});
	}

	// Token: 0x06004059 RID: 16473 RVA: 0x00168B60 File Offset: 0x00166D60
	public void ShowLockSkillTips(bool active)
	{
		if (this.IsLockSkillTipsClicked)
		{
			return;
		}
		this.IsLockSkillTipsClicked = true;
		if (active)
		{
			base.GetItem(13).SetUIActive(true);
			this.IsLockSkillTipsClicked = false;
			this.PlaySkillButtonSequence("TipsShow", null);
			return;
		}
		this.IsLockSkillTipsClicked = false;
		this.PlaySkillButtonSequence("TipsHide", delegate
		{
			base.GetItem(13).SetUIActive(false);
		});
	}

	// Token: 0x170008EA RID: 2282
	// (get) Token: 0x0600405A RID: 16474 RVA: 0x00168BC0 File Offset: 0x00166DC0
	private bool IsPlayer
	{
		get
		{
			GuessJokerRoleData roleData = this.RoleData;
			return roleData != null && roleData.GetPlayerType() == EGuessJokerPlayerType.Me;
		}
	}

	// Token: 0x0600405B RID: 16475 RVA: 0x00168BD8 File Offset: 0x00166DD8
	private void OnClickSkillButton()
	{
		if (!this.IsUnlock && !this.IsPlayer)
		{
			if (!this.IsLockSkillTipsClicked)
			{
				bool active = !base.GetItem(13).bIsUIActive;
				this.ShowLockSkillTips(active);
			}
			return;
		}
		JokerSkill? jokerSkill = GuessJokerConfig.Instance.GetJokerSkill(this.SkillId);
		if (jokerSkill != null)
		{
			int helpId = jokerSkill.Value.HelpId;
			if (helpId != 0)
			{
				HelpController.Instance.OpenHelpById(helpId);
			}
		}
	}

	// Token: 0x040032EE RID: 13038
	[Nullable(2)]
	public GuessJokerRoleData RoleData;

	// Token: 0x040032EF RID: 13039
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<GuessJokerHpItem, bool> HpLayout;

	// Token: 0x040032F0 RID: 13040
	private bool IsUnlock;

	// Token: 0x040032F1 RID: 13041
	private int SkillId = -1;

	// Token: 0x040032F2 RID: 13042
	private bool IsLockSkillTipsClicked;

	// Token: 0x040032F3 RID: 13043
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x040032F4 RID: 13044
	[Nullable(2)]
	private LevelSequencePlayer SkillButtonSequencePlayer;

	// Token: 0x040032F5 RID: 13045
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private readonly Dictionary<string, Action> SequenceFinishCallbackMap = new Dictionary<string, Action>();

	// Token: 0x020067FA RID: 26618
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402249A RID: 140442
		public const int Button = 0;

		// Token: 0x0402249B RID: 140443
		public const int RoleTexture = 1;

		// Token: 0x0402249C RID: 140444
		public const int HpHorizontalLayout = 2;

		// Token: 0x0402249D RID: 140445
		public const int HpItem = 3;

		// Token: 0x0402249E RID: 140446
		public const int HeadBgItem = 4;

		// Token: 0x0402249F RID: 140447
		public const int SelectItem = 5;

		// Token: 0x040224A0 RID: 140448
		public const int TimePanel = 6;

		// Token: 0x040224A1 RID: 140449
		public const int TimeProgressSprite = 7;

		// Token: 0x040224A2 RID: 140450
		public const int DialoguePanel = 8;

		// Token: 0x040224A3 RID: 140451
		public const int DialogueText = 9;

		// Token: 0x040224A4 RID: 140452
		public const int SkillButton = 10;

		// Token: 0x040224A5 RID: 140453
		public const int LockSprite = 11;

		// Token: 0x040224A6 RID: 140454
		public const int SkillTexture = 12;

		// Token: 0x040224A7 RID: 140455
		public const int LockSkillTipsItem = 13;
	}
}
