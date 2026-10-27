using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001071 RID: 4209
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerHeadItem : UiPanelBase
{
	// Token: 0x06006CB5 RID: 27829 RVA: 0x0015FBE0 File Offset: 0x0015DDE0
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

	// Token: 0x06006CB6 RID: 27830 RVA: 0x0015FD58 File Offset: 0x0015DF58
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

	// Token: 0x06006CB7 RID: 27831 RVA: 0x0015FE28 File Offset: 0x0015E028
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

	// Token: 0x06006CB8 RID: 27832 RVA: 0x0015FE5B File Offset: 0x0015E05B
	public void SetRoleData(GuessJokerRoleData roleData)
	{
		this.RoleData = roleData;
		this.InitView();
	}

	// Token: 0x170008C9 RID: 2249
	// (get) Token: 0x06006CB9 RID: 27833 RVA: 0x0015FE6A File Offset: 0x0015E06A
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

	// Token: 0x06006CBA RID: 27834 RVA: 0x0015FE80 File Offset: 0x0015E080
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

	// Token: 0x06006CBB RID: 27835 RVA: 0x0015FF94 File Offset: 0x0015E194
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

	// Token: 0x06006CBC RID: 27836 RVA: 0x0015FFDC File Offset: 0x0015E1DC
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

	// Token: 0x06006CBD RID: 27837 RVA: 0x00160030 File Offset: 0x0015E230
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

	// Token: 0x06006CBE RID: 27838 RVA: 0x001600EC File Offset: 0x0015E2EC
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

	// Token: 0x06006CBF RID: 27839 RVA: 0x00160128 File Offset: 0x0015E328
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

	// Token: 0x06006CC0 RID: 27840 RVA: 0x00160160 File Offset: 0x0015E360
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

	// Token: 0x06006CC1 RID: 27841 RVA: 0x0016019C File Offset: 0x0015E39C
	private GuessJokerHpItem CreateHpItem()
	{
		return new GuessJokerHpItem();
	}

	// Token: 0x06006CC2 RID: 27842 RVA: 0x001601A3 File Offset: 0x0015E3A3
	public void SetDialogueText(string textKey)
	{
		if (!this.IsPlayer)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(9), textKey, Array.Empty<object>());
	}

	// Token: 0x06006CC3 RID: 27843 RVA: 0x001601C8 File Offset: 0x0015E3C8
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

	// Token: 0x06006CC4 RID: 27844 RVA: 0x0016022C File Offset: 0x0015E42C
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

	// Token: 0x170008CA RID: 2250
	// (get) Token: 0x06006CC5 RID: 27845 RVA: 0x0016028C File Offset: 0x0015E48C
	private bool IsPlayer
	{
		get
		{
			GuessJokerRoleData roleData = this.RoleData;
			return roleData != null && roleData.GetPlayerType() == EGuessJokerPlayerType.Me;
		}
	}

	// Token: 0x06006CC6 RID: 27846 RVA: 0x001602A4 File Offset: 0x0015E4A4
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

	// Token: 0x04003255 RID: 12885
	[Nullable(2)]
	public GuessJokerRoleData RoleData;

	// Token: 0x04003256 RID: 12886
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<GuessJokerHpItem, bool> HpLayout;

	// Token: 0x04003257 RID: 12887
	private bool IsUnlock;

	// Token: 0x04003258 RID: 12888
	private int SkillId = -1;

	// Token: 0x04003259 RID: 12889
	private bool IsLockSkillTipsClicked;

	// Token: 0x0400325A RID: 12890
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x0400325B RID: 12891
	[Nullable(2)]
	private LevelSequencePlayer SkillButtonSequencePlayer;

	// Token: 0x0400325C RID: 12892
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private readonly Dictionary<string, Action> SequenceFinishCallbackMap = new Dictionary<string, Action>();

	// Token: 0x02007666 RID: 30310
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x0402714F RID: 160079
		public const int Button = 0;

		// Token: 0x04027150 RID: 160080
		public const int RoleTexture = 1;

		// Token: 0x04027151 RID: 160081
		public const int HpHorizontalLayout = 2;

		// Token: 0x04027152 RID: 160082
		public const int HpItem = 3;

		// Token: 0x04027153 RID: 160083
		public const int HeadBgItem = 4;

		// Token: 0x04027154 RID: 160084
		public const int SelectItem = 5;

		// Token: 0x04027155 RID: 160085
		public const int TimePanel = 6;

		// Token: 0x04027156 RID: 160086
		public const int TimeProgressSprite = 7;

		// Token: 0x04027157 RID: 160087
		public const int DialoguePanel = 8;

		// Token: 0x04027158 RID: 160088
		public const int DialogueText = 9;

		// Token: 0x04027159 RID: 160089
		public const int SkillButton = 10;

		// Token: 0x0402715A RID: 160090
		public const int LockSprite = 11;

		// Token: 0x0402715B RID: 160091
		public const int SkillTexture = 12;

		// Token: 0x0402715C RID: 160092
		public const int LockSkillTipsItem = 13;
	}
}
