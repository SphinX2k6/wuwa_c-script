using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011B6 RID: 4534
[NullableContext(2)]
[Nullable(0)]
public class PinballBattleRoleSkillItem : UiPanelBase, IStaticVariableResetter
{
	// Token: 0x0600B49F RID: 46239 RVA: 0x00355830 File Offset: 0x00353A30
	static PinballBattleRoleSkillItem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballBattleRoleSkillItem.CreateStaticDefaultValue), new Action(PinballBattleRoleSkillItem.ResetStaticDefaultValue));
	}

	// Token: 0x0600B4A0 RID: 46240 RVA: 0x0035584F File Offset: 0x00353A4F
	public static void CreateStaticDefaultValue()
	{
		PinballBattleRoleSkillItem.ChargeBarRange = new float[]
		{
			0.552f,
			0.882f
		};
	}

	// Token: 0x0600B4A1 RID: 46241 RVA: 0x0035586C File Offset: 0x00353A6C
	public static void ResetStaticDefaultValue()
	{
		PinballBattleRoleSkillItem.ChargeBarRange = null;
	}

	// Token: 0x0600B4A2 RID: 46242 RVA: 0x00355874 File Offset: 0x00353A74
	protected unsafe override void OnRegisterComponent()
	{
		int num = 18;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnSkillClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B4A3 RID: 46243 RVA: 0x00355B34 File Offset: 0x00353D34
	protected override void OnStart()
	{
		this.TexHpBar = base.GetTexture(15);
		this.ChargeBar = base.GetSprite(12);
		this.BuffLayout = new GenericLayout<PinballBattleBuffItem, IBuffView>(base.GetLayoutBase(8), () => new PinballBattleBuffItem(), null, false, true);
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		EventSystem.Instance.Add<int, bool>(EEventName.OnPinballRoleStateChange, new Action<int, bool>(this.OnRoleStateChange));
	}

	// Token: 0x0600B4A4 RID: 46244 RVA: 0x00355BBE File Offset: 0x00353DBE
	protected override void OnBeforeDestroy()
	{
		this.ClearDelegate();
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.Clear();
		}
		EventSystem.Instance.Remove(EEventName.OnPinballRoleStateChange, new Action<int, bool>(this.OnRoleStateChange));
	}

	// Token: 0x0600B4A5 RID: 46245 RVA: 0x00355BF4 File Offset: 0x00353DF4
	public void Refresh(int roleId)
	{
		this.RoleId = roleId;
		if (roleId == -1)
		{
			this.ClearDelegate();
			this.OwnerEntity = null;
			this.RefreshPerformanceByState(PinballBattleRoleSkillItem.EState.None);
			return;
		}
		PinballRoleConfig value = PinballConfig.Instance.GetPinballRoleConfigById(roleId).Value;
		base.SetTextureShowUntilLoaded(value.Icon, base.GetTexture(0), null);
		this.SetSpriteByPath(value.RoleSkillIcon, base.GetSprite(16), false, null, null);
		this.SetSpriteByPath(value.RoleSkillIcon, base.GetSprite(17), false, null, null);
		PinballBattleSubModel pinballBattleSubModel = KuroSimpleCombatController.Instance.CurSubModel as PinballBattleSubModel;
		object obj;
		if (pinballBattleSubModel == null)
		{
			obj = null;
		}
		else
		{
			KscEntityHandle kscEntityByRoleId = pinballBattleSubModel.GetKscEntityByRoleId(roleId);
			obj = ((kscEntityByRoleId != null) ? kscEntityByRoleId.KscEntity : null);
		}
		AKSC_Shape2D_Entity_Player aksc_Shape2D_Entity_Player = obj as AKSC_Shape2D_Entity_Player;
		if (aksc_Shape2D_Entity_Player == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PinballBattle;
			ELogAuthor author = ELogAuthor.LJ;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(20, 1);
			defaultInterpolatedStringHandler.AppendLiteral("找不到角色id对应的实体！RoleId：");
			defaultInterpolatedStringHandler.AppendFormatted<int>(roleId);
			instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.OwnerEntity = aksc_Shape2D_Entity_Player;
		UKSC_SkillComp skillComp = aksc_Shape2D_Entity_Player.GetSkillComp();
		if (skillComp == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.PinballBattle;
			ELogAuthor author2 = ELogAuthor.LJ;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
			defaultInterpolatedStringHandler.AppendLiteral("找不到角色id对应的技能组件！RoleId：");
			defaultInterpolatedStringHandler.AppendFormatted<int>(roleId);
			instance2.Warn(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		UKSC_AttrSet attrSet_ = skillComp.AttrSet_;
		if (attrSet_ == null)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.PinballBattle;
			ELogAuthor author3 = ELogAuthor.LJ;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
			defaultInterpolatedStringHandler.AppendLiteral("找不到角色id对应的属性集！RoleId：");
			defaultInterpolatedStringHandler.AppendFormatted<int>(roleId);
			instance3.Warn(module3, author3, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.BindAttrDelegate(attrSet_);
		this.UpdateHpChange();
		this.UpdateChargeChange();
		this.RefreshPerformance();
		this.BindBuffDelegate(skillComp);
		this.RefreshBuff();
	}

	// Token: 0x0600B4A6 RID: 46246 RVA: 0x00355DC2 File Offset: 0x00353FC2
	private void OnRoleStateChange(int roleId, bool isAlive)
	{
		if (this.RoleId == roleId)
		{
			this.RefreshPerformance();
		}
	}

	// Token: 0x0600B4A7 RID: 46247 RVA: 0x00355DD4 File Offset: 0x00353FD4
	private void OnSkillClick()
	{
		if (Time.Instance.ServerTimeStamp - this.LastSkillClickTime < 500.0)
		{
			return;
		}
		UKSC_AttrSet ownerAttrSet = this.OwnerAttrSet;
		int? num;
		if (ownerAttrSet == null)
		{
			num = null;
		}
		else
		{
			TMap<EKSC_AttrType, int> attrs_ = ownerAttrSet.Attrs_;
			num = ((attrs_ != null) ? attrs_.GetValueOrNull(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.CurChargeType) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		UKSC_AttrSet ownerAttrSet2 = this.OwnerAttrSet;
		int? num3;
		if (ownerAttrSet2 == null)
		{
			num3 = null;
		}
		else
		{
			TMap<EKSC_AttrType, int> attrs_2 = ownerAttrSet2.Attrs_;
			num3 = ((attrs_2 != null) ? attrs_2.GetValueOrNull(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.MaxChargeType) : null);
		}
		num2 = num3;
		int valueOrDefault2 = num2.GetValueOrDefault();
		if (valueOrDefault < valueOrDefault2)
		{
			return;
		}
		PinballBattleSubController pinballBattleSubController = KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController;
		if (pinballBattleSubController != null)
		{
			PinballBattleLaunchPhaseController launchPhaseController = pinballBattleSubController.LaunchPhaseController;
			if (launchPhaseController == null || !launchPhaseController.IsActive())
			{
				PinballBattleSubModel model = pinballBattleSubController.GetModel();
				if (model.GetRoleSlotIndex(this.RoleId) == null)
				{
					return;
				}
				KscEntityHandle kscEntityByRoleId = model.GetKscEntityByRoleId(this.RoleId);
				AKSC_Shape2D_Entity_Player aksc_Shape2D_Entity_Player = ((kscEntityByRoleId != null) ? kscEntityByRoleId.KscEntity : null) as AKSC_Shape2D_Entity_Player;
				if (aksc_Shape2D_Entity_Player == null || !aksc_Shape2D_Entity_Player.IsPlayerAlive)
				{
					return;
				}
				Action<int> onSkillClickCallback = this.OnSkillClickCallback;
				if (onSkillClickCallback == null)
				{
					return;
				}
				onSkillClickCallback(this.RoleId);
				return;
			}
		}
	}

	// Token: 0x0600B4A8 RID: 46248 RVA: 0x00355F07 File Offset: 0x00354107
	public void StartClickCooldown()
	{
		this.LastSkillClickTime = Time.Instance.ServerTimeStamp;
	}

	// Token: 0x0600B4A9 RID: 46249 RVA: 0x00355F19 File Offset: 0x00354119
	public void ClearDelegate()
	{
		this.UnBindAttrDelegate();
		this.UnBindBuffDelegate();
	}

	// Token: 0x0600B4AA RID: 46250 RVA: 0x00355F28 File Offset: 0x00354128
	[NullableContext(1)]
	public void BindAttrDelegate(UKSC_AttrSet attrSet)
	{
		this.UnBindAttrDelegate();
		this.OwnerAttrSet = attrSet;
		this.ChargeDelegate = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnChargeChange));
		UKSC_AttrSet ownerAttrSet = this.OwnerAttrSet;
		if (ownerAttrSet != null)
		{
			ownerAttrSet.AssignAttrListen(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.CurChargeType, this.ChargeDelegate);
		}
		UKSC_AttrSet ownerAttrSet2 = this.OwnerAttrSet;
		if (ownerAttrSet2 != null)
		{
			ownerAttrSet2.AssignAttrListen(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.MaxChargeType, this.ChargeDelegate);
		}
		this.HpDelegate = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnHpChange));
		UKSC_AttrSet ownerAttrSet3 = this.OwnerAttrSet;
		if (ownerAttrSet3 != null)
		{
			ownerAttrSet3.AssignAttrListen(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.CurHpType, this.HpDelegate);
		}
		UKSC_AttrSet ownerAttrSet4 = this.OwnerAttrSet;
		if (ownerAttrSet4 == null)
		{
			return;
		}
		ownerAttrSet4.AssignAttrListen(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.MaxHpType, this.HpDelegate);
	}

	// Token: 0x0600B4AB RID: 46251 RVA: 0x00355FE0 File Offset: 0x003541E0
	public void UnBindAttrDelegate()
	{
		if (this.OwnerAttrSet == null)
		{
			return;
		}
		UKSC_AttrSet ownerAttrSet = this.OwnerAttrSet;
		if (ownerAttrSet != null)
		{
			ownerAttrSet.RemoveAttrListen(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.CurChargeType, this.ChargeDelegate);
		}
		UKSC_AttrSet ownerAttrSet2 = this.OwnerAttrSet;
		if (ownerAttrSet2 != null)
		{
			ownerAttrSet2.RemoveAttrListen(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.MaxChargeType, this.ChargeDelegate);
		}
		UKSC_AttrSet ownerAttrSet3 = this.OwnerAttrSet;
		if (ownerAttrSet3 != null)
		{
			ownerAttrSet3.RemoveAttrListen(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.CurHpType, this.HpDelegate);
		}
		UKSC_AttrSet ownerAttrSet4 = this.OwnerAttrSet;
		if (ownerAttrSet4 != null)
		{
			ownerAttrSet4.RemoveAttrListen(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.MaxHpType, this.HpDelegate);
		}
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<EKSC_AttrType, int>(this.OnChargeChange));
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<EKSC_AttrType, int>(this.OnHpChange));
		this.ChargeDelegate = null;
		this.HpDelegate = null;
		this.OwnerAttrSet = null;
	}

	// Token: 0x0600B4AC RID: 46252 RVA: 0x0035609D File Offset: 0x0035429D
	private void OnChargeChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateChargeChange();
		this.RefreshPerformance();
	}

	// Token: 0x0600B4AD RID: 46253 RVA: 0x003560AB File Offset: 0x003542AB
	private void OnHpChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateHpChange();
		this.RefreshPerformance();
	}

	// Token: 0x0600B4AE RID: 46254 RVA: 0x003560BC File Offset: 0x003542BC
	private void UpdateChargeChange()
	{
		UKSC_AttrSet ownerAttrSet = this.OwnerAttrSet;
		int? num;
		if (ownerAttrSet == null)
		{
			num = null;
		}
		else
		{
			TMap<EKSC_AttrType, int> attrs_ = ownerAttrSet.Attrs_;
			num = ((attrs_ != null) ? attrs_.GetValueOrNull(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.CurChargeType) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		UKSC_AttrSet ownerAttrSet2 = this.OwnerAttrSet;
		int? num3;
		if (ownerAttrSet2 == null)
		{
			num3 = null;
		}
		else
		{
			TMap<EKSC_AttrType, int> attrs_2 = ownerAttrSet2.Attrs_;
			num3 = ((attrs_2 != null) ? attrs_2.GetValueOrNull(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.MaxChargeType) : null);
		}
		num2 = num3;
		int valueOrDefault2 = num2.GetValueOrDefault();
		UUISprite chargeBar = this.ChargeBar;
		if (chargeBar != null)
		{
			chargeBar.SetFillAmount(MathUtils.Instance.Lerp(PinballBattleRoleSkillItem.ChargeBarRange[0], PinballBattleRoleSkillItem.ChargeBarRange[1], (float)valueOrDefault / (float)valueOrDefault2));
		}
		if (valueOrDefault < valueOrDefault2)
		{
			this.IsPlayedChargeTips = false;
			return;
		}
		if (!this.IsPlayedChargeTips)
		{
			this.IsPlayedChargeTips = true;
			PinballController instance = PinballController.Instance;
			if (instance != null)
			{
				instance.ShowRoleSkillMaxTips(this.RoleId);
			}
			EventSystem.Instance.Emit<int>(EEventName.OnPinballRoleChargeMax, this.RoleId);
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "PinballRoleChargeMax");
		}
	}

	// Token: 0x0600B4AF RID: 46255 RVA: 0x003561CC File Offset: 0x003543CC
	private void UpdateHpChange()
	{
		UKSC_AttrSet ownerAttrSet = this.OwnerAttrSet;
		int? num;
		if (ownerAttrSet == null)
		{
			num = null;
		}
		else
		{
			TMap<EKSC_AttrType, int> attrs_ = ownerAttrSet.Attrs_;
			num = ((attrs_ != null) ? attrs_.GetValueOrNull(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.CurHpType) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		UKSC_AttrSet ownerAttrSet2 = this.OwnerAttrSet;
		int? num3;
		if (ownerAttrSet2 == null)
		{
			num3 = null;
		}
		else
		{
			TMap<EKSC_AttrType, int> attrs_2 = ownerAttrSet2.Attrs_;
			num3 = ((attrs_2 != null) ? attrs_2.GetValueOrNull(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.MaxHpType) : null);
		}
		num2 = num3;
		int valueOrDefault2 = num2.GetValueOrDefault();
		UUITexture texHpBar = this.TexHpBar;
		if (texHpBar == null)
		{
			return;
		}
		texHpBar.SetCustomMaterialScalarParameter(this.NamePercent.Value, (float)valueOrDefault / (float)valueOrDefault2);
	}

	// Token: 0x0600B4B0 RID: 46256 RVA: 0x00356274 File Offset: 0x00354474
	[NullableContext(1)]
	private void BindBuffDelegate(UKSC_SkillComp skillComp)
	{
		this.UnBindBuffDelegate();
		this.OwnerSkillComp = skillComp;
		TMap<UKSC_DA_Buff, int> tmap = new TMap<UKSC_DA_Buff, int>();
		skillComp.GetAllBuffs(ref tmap);
		List<IBuffView> list = new List<IBuffView>(tmap.Num());
		foreach (KeyValuePair<UKSC_DA_Buff, int> keyValuePair in tmap)
		{
			UKSC_DA_Buff uksc_DA_Buff;
			int num;
			keyValuePair.Deconstruct(out uksc_DA_Buff, out num);
			UKSC_DA_Buff buffDa = uksc_DA_Buff;
			int buffCount = num;
			int? buffId = this.GetBuffId(buffDa);
			if (buffId != null)
			{
				PinballModel instance = PinballModel.Instance;
				BuffView buffView = (instance != null) ? instance.CreateBuffView(buffId.Value, buffCount) : null;
				if (buffView != null)
				{
					list.Add(buffView);
				}
			}
		}
		this.SetBuffViewList(list);
		skillComp.OnKSCBuffChange.Add(new Action<UKSC_DA_Buff, int>(this.OnBuffChange));
	}

	// Token: 0x0600B4B1 RID: 46257 RVA: 0x00356350 File Offset: 0x00354550
	private void UnBindBuffDelegate()
	{
		if (this.OwnerSkillComp == null)
		{
			return;
		}
		this.OwnerSkillComp.OnKSCBuffChange.Remove(new Action<UKSC_DA_Buff, int>(this.OnBuffChange));
	}

	// Token: 0x0600B4B2 RID: 46258 RVA: 0x00356377 File Offset: 0x00354577
	[NullableContext(1)]
	private void SetBuffViewList(List<IBuffView> buffIds)
	{
		this.CurBuffViewList = buffIds;
	}

	// Token: 0x0600B4B3 RID: 46259 RVA: 0x00356380 File Offset: 0x00354580
	public void RefreshBuff()
	{
		if (this.CurBuffViewList == null)
		{
			return;
		}
		List<IBuffView> buffViewList = PinballModel.Instance.GetBuffViewList(this.CurBuffViewList, 4);
		this.BuffLayout.RefreshByData(buffViewList, null, false);
		UUIItem item = base.GetItem(10);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(this.CurBuffViewList.Count > 4);
	}

	// Token: 0x0600B4B4 RID: 46260 RVA: 0x003563D8 File Offset: 0x003545D8
	private void OnBuffChange(UKSC_DA_Buff buffDa, int count)
	{
		if (this.CurBuffViewList == null)
		{
			this.CurBuffViewList = new List<IBuffView>();
		}
		if (buffDa == null)
		{
			return;
		}
		int? buffId = this.GetBuffId(buffDa);
		if (buffId == null)
		{
			return;
		}
		int num = this.CurBuffViewList.FindIndex((IBuffView buffView) => buffView.BuffId == buffId.Value);
		if (count == 0)
		{
			if (num != -1)
			{
				this.CurBuffViewList = this.CurBuffViewList.FindAll((IBuffView buffView) => buffView.BuffId != buffId.Value);
			}
		}
		else if (num != -1)
		{
			this.CurBuffViewList[num].BuffCount = count;
		}
		else
		{
			PinballModel instance = PinballModel.Instance;
			BuffView buffView2 = (instance != null) ? instance.CreateBuffView(buffId.Value, count) : null;
			if (buffView2 == null)
			{
				return;
			}
			List<IBuffView> curBuffViewList = this.CurBuffViewList;
			if (curBuffViewList != null)
			{
				curBuffViewList.Add(buffView2);
			}
		}
		this.RefreshBuff();
	}

	// Token: 0x0600B4B5 RID: 46261 RVA: 0x003564B0 File Offset: 0x003546B0
	[NullableContext(1)]
	private int? GetBuffId(UKSC_DA_Buff buffDa)
	{
		UKuroSimpleCombatSubsystem kscSubsystem = KscEnv.Instance.KscSubsystem;
		bool flag;
		int value;
		if (kscSubsystem == null)
		{
			flag = false;
		}
		else
		{
			UKSC_World kscworld = kscSubsystem.GetKSCWorld();
			flag = ((kscworld != null) ? new bool?(kscworld.LoadedBuffDa.TryGetValue(buffDa, out value)) : null).GetValueOrDefault();
		}
		if (!flag)
		{
			return null;
		}
		return new int?(value);
	}

	// Token: 0x0600B4B6 RID: 46262 RVA: 0x00356510 File Offset: 0x00354710
	public void RefreshPerformance()
	{
		if (this.OwnerAttrSet == null)
		{
			return;
		}
		int valueOrDefault = this.OwnerAttrSet.Attrs_.GetValueOrNull(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.CurChargeType).GetValueOrDefault();
		int valueOrDefault2 = this.OwnerAttrSet.Attrs_.GetValueOrNull(<PinballBattleRoleSkillItem>F84489B893D508BEF487B2C64570D01B6752BE307C8FE69A23023DDF42E28A491__RoleSkillConst.MaxChargeType).GetValueOrDefault();
		if (this.OwnerEntity != null && !this.OwnerEntity.IsPlayerAlive)
		{
			this.RefreshPerformanceByState(PinballBattleRoleSkillItem.EState.Dead);
			return;
		}
		if (valueOrDefault2 > 0 && valueOrDefault >= valueOrDefault2)
		{
			this.RefreshPerformanceByState(PinballBattleRoleSkillItem.EState.Charge);
			return;
		}
		this.RefreshPerformanceByState(PinballBattleRoleSkillItem.EState.Normal);
	}

	// Token: 0x0600B4B7 RID: 46263 RVA: 0x00356598 File Offset: 0x00354798
	private void RefreshPerformanceByState(PinballBattleRoleSkillItem.EState state)
	{
		PinballBattleRoleSkillItem.EState? curState = this.CurState;
		if (curState.GetValueOrDefault() == state & curState != null)
		{
			return;
		}
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			item.SetUIActive(state == PinballBattleRoleSkillItem.EState.None);
		}
		UUIItem item2 = base.GetItem(14);
		if (item2 != null)
		{
			item2.SetUIActive(state > PinballBattleRoleSkillItem.EState.None);
		}
		if (state == PinballBattleRoleSkillItem.EState.None)
		{
			return;
		}
		UUIItem item3 = base.GetItem(2);
		if (item3 != null)
		{
			item3.SetUIActive(state == PinballBattleRoleSkillItem.EState.Dead);
		}
		UUIItem item4 = base.GetItem(4);
		if (item4 != null)
		{
			item4.SetUIActive(state == PinballBattleRoleSkillItem.EState.Normal || state == PinballBattleRoleSkillItem.EState.Charge);
		}
		UUIItem item5 = base.GetItem(6);
		if (item5 != null)
		{
			item5.SetUIActive(state == PinballBattleRoleSkillItem.EState.Charge);
		}
		UUIItem item6 = base.GetItem(3);
		if (item6 != null)
		{
			item6.SetUIActive(state == PinballBattleRoleSkillItem.EState.Dead);
		}
		UUIItem item7 = base.GetItem(5);
		if (item7 != null)
		{
			item7.SetUIActive(state == PinballBattleRoleSkillItem.EState.Normal);
		}
		UUIItem item8 = base.GetItem(7);
		if (item8 != null)
		{
			item8.SetUIActive(state == PinballBattleRoleSkillItem.EState.Charge);
		}
		UUILayoutBase layoutBase = base.GetLayoutBase(8);
		if (layoutBase != null)
		{
			layoutBase.RootUIComp.Get().SetUIActive(state != PinballBattleRoleSkillItem.EState.Dead);
		}
		UUITexture texHpBar = this.TexHpBar;
		if (texHpBar != null)
		{
			texHpBar.SetUIActive(state != PinballBattleRoleSkillItem.EState.Dead);
		}
		UUISprite chargeBar = this.ChargeBar;
		if (chargeBar != null)
		{
			chargeBar.SetUIActive(state != PinballBattleRoleSkillItem.EState.Dead);
		}
		UUITexture texture = base.GetTexture(0);
		if (texture != null)
		{
			texture.SetIsGray(state == PinballBattleRoleSkillItem.EState.Dead);
		}
		this.RefreshAnimation(state);
		this.CurState = new PinballBattleRoleSkillItem.EState?(state);
	}

	// Token: 0x0600B4B8 RID: 46264 RVA: 0x00356700 File Offset: 0x00354900
	private void RefreshAnimation(PinballBattleRoleSkillItem.EState newState)
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.StopPlayingSequence(false, true);
		}
		if (newState != PinballBattleRoleSkillItem.EState.Charge)
		{
			if (this.CurState.GetValueOrDefault() == PinballBattleRoleSkillItem.EState.Charge)
			{
				LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
				if (seqPlayer2 == null)
				{
					return;
				}
				seqPlayer2.PlayOrReplaySequenceByName("Charge_Out", false, null);
			}
			return;
		}
		LevelSequencePlayer seqPlayer3 = this.SeqPlayer;
		if (seqPlayer3 == null)
		{
			return;
		}
		seqPlayer3.PlayOrReplaySequenceByName("Charge_Done", false, null);
	}

	// Token: 0x04006879 RID: 26745
	private static float[] ChargeBarRange;

	// Token: 0x0400687A RID: 26746
	private const int INVALID_VALUE = -1;

	// Token: 0x0400687B RID: 26747
	private int RoleId = -1;

	// Token: 0x0400687C RID: 26748
	private UUITexture TexHpBar;

	// Token: 0x0400687D RID: 26749
	private UUISprite ChargeBar;

	// Token: 0x0400687E RID: 26750
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<PinballBattleBuffItem, IBuffView> BuffLayout;

	// Token: 0x0400687F RID: 26751
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04006880 RID: 26752
	private AKSC_Shape2D_Entity_Player OwnerEntity;

	// Token: 0x04006881 RID: 26753
	private UKSC_SkillComp OwnerSkillComp;

	// Token: 0x04006882 RID: 26754
	private UKSC_AttrSet OwnerAttrSet;

	// Token: 0x04006883 RID: 26755
	private bool IsPlayedChargeTips;

	// Token: 0x04006884 RID: 26756
	private PinballBattleRoleSkillItem.EState? CurState;

	// Token: 0x04006885 RID: 26757
	private FOnKSCAttrChange ChargeDelegate;

	// Token: 0x04006886 RID: 26758
	private FOnKSCAttrChange HpDelegate;

	// Token: 0x04006887 RID: 26759
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IBuffView> CurBuffViewList;

	// Token: 0x04006888 RID: 26760
	private readonly FName? NamePercent = FNameUtil.GetDynamicFName("percent");

	// Token: 0x04006889 RID: 26761
	public Action<int> OnSkillClickCallback;

	// Token: 0x0400688A RID: 26762
	private double LastSkillClickTime;

	// Token: 0x0200747B RID: 29819
	[NullableContext(0)]
	private enum EState
	{
		// Token: 0x04025E95 RID: 155285
		None,
		// Token: 0x04025E96 RID: 155286
		Normal,
		// Token: 0x04025E97 RID: 155287
		Charge,
		// Token: 0x04025E98 RID: 155288
		Dead
	}
}
