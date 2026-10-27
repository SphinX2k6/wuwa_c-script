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

// Token: 0x02001CF4 RID: 7412
[NullableContext(2)]
[Nullable(0)]
public class PinballBattleRoleSkillItem : UiPanelBase, IStaticVariableResetter
{
	// Token: 0x0600E082 RID: 57474 RVA: 0x00349E08 File Offset: 0x00348008
	static PinballBattleRoleSkillItem()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PinballBattleRoleSkillItem.CreateStaticDefaultValue), new Action(PinballBattleRoleSkillItem.ResetStaticDefaultValue));
	}

	// Token: 0x0600E083 RID: 57475 RVA: 0x00349E27 File Offset: 0x00348027
	public static void CreateStaticDefaultValue()
	{
		PinballBattleRoleSkillItem.ChargeBarRange = new float[]
		{
			0.552f,
			0.882f
		};
	}

	// Token: 0x0600E084 RID: 57476 RVA: 0x00349E44 File Offset: 0x00348044
	public static void ResetStaticDefaultValue()
	{
		PinballBattleRoleSkillItem.ChargeBarRange = null;
	}

	// Token: 0x0600E085 RID: 57477 RVA: 0x00349E4C File Offset: 0x0034804C
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

	// Token: 0x0600E086 RID: 57478 RVA: 0x0034A10C File Offset: 0x0034830C
	protected override void OnStart()
	{
		this.TexHpBar = base.GetTexture(15);
		this.ChargeBar = base.GetSprite(12);
		this.BuffLayout = new GenericLayout<PinballBattleBuffItem, IBuffView>(base.GetLayoutBase(8), () => new PinballBattleBuffItem(), null, false, true);
		this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		EventSystem.Instance.Add<int, bool>(EEventName.OnPinballRoleStateChange, new Action<int, bool>(this.OnRoleStateChange));
	}

	// Token: 0x0600E087 RID: 57479 RVA: 0x0034A196 File Offset: 0x00348396
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

	// Token: 0x0600E088 RID: 57480 RVA: 0x0034A1CC File Offset: 0x003483CC
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

	// Token: 0x0600E089 RID: 57481 RVA: 0x0034A39A File Offset: 0x0034859A
	private void OnRoleStateChange(int roleId, bool isAlive)
	{
		if (this.RoleId == roleId)
		{
			this.RefreshPerformance();
		}
	}

	// Token: 0x0600E08A RID: 57482 RVA: 0x0034A3AC File Offset: 0x003485AC
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

	// Token: 0x0600E08B RID: 57483 RVA: 0x0034A4DF File Offset: 0x003486DF
	public void StartClickCooldown()
	{
		this.LastSkillClickTime = Time.Instance.ServerTimeStamp;
	}

	// Token: 0x0600E08C RID: 57484 RVA: 0x0034A4F1 File Offset: 0x003486F1
	public void ClearDelegate()
	{
		this.UnBindAttrDelegate();
		this.UnBindBuffDelegate();
	}

	// Token: 0x0600E08D RID: 57485 RVA: 0x0034A500 File Offset: 0x00348700
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

	// Token: 0x0600E08E RID: 57486 RVA: 0x0034A5B8 File Offset: 0x003487B8
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

	// Token: 0x0600E08F RID: 57487 RVA: 0x0034A675 File Offset: 0x00348875
	private void OnChargeChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateChargeChange();
		this.RefreshPerformance();
	}

	// Token: 0x0600E090 RID: 57488 RVA: 0x0034A683 File Offset: 0x00348883
	private void OnHpChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateHpChange();
		this.RefreshPerformance();
	}

	// Token: 0x0600E091 RID: 57489 RVA: 0x0034A694 File Offset: 0x00348894
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

	// Token: 0x0600E092 RID: 57490 RVA: 0x0034A7A4 File Offset: 0x003489A4
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

	// Token: 0x0600E093 RID: 57491 RVA: 0x0034A84C File Offset: 0x00348A4C
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

	// Token: 0x0600E094 RID: 57492 RVA: 0x0034A920 File Offset: 0x00348B20
	private void UnBindBuffDelegate()
	{
		if (this.OwnerSkillComp == null)
		{
			return;
		}
		this.OwnerSkillComp.OnKSCBuffChange.Remove(new Action<UKSC_DA_Buff, int>(this.OnBuffChange));
	}

	// Token: 0x0600E095 RID: 57493 RVA: 0x0034A947 File Offset: 0x00348B47
	[NullableContext(1)]
	private void SetBuffViewList(List<IBuffView> buffIds)
	{
		this.CurBuffViewList = buffIds;
	}

	// Token: 0x0600E096 RID: 57494 RVA: 0x0034A950 File Offset: 0x00348B50
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

	// Token: 0x0600E097 RID: 57495 RVA: 0x0034A9A8 File Offset: 0x00348BA8
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

	// Token: 0x0600E098 RID: 57496 RVA: 0x0034AA80 File Offset: 0x00348C80
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

	// Token: 0x0600E099 RID: 57497 RVA: 0x0034AAE0 File Offset: 0x00348CE0
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

	// Token: 0x0600E09A RID: 57498 RVA: 0x0034AB68 File Offset: 0x00348D68
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

	// Token: 0x0600E09B RID: 57499 RVA: 0x0034ACD0 File Offset: 0x00348ED0
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

	// Token: 0x0400679A RID: 26522
	private static float[] ChargeBarRange;

	// Token: 0x0400679B RID: 26523
	private const int INVALID_VALUE = -1;

	// Token: 0x0400679C RID: 26524
	private int RoleId = -1;

	// Token: 0x0400679D RID: 26525
	private UUITexture TexHpBar;

	// Token: 0x0400679E RID: 26526
	private UUISprite ChargeBar;

	// Token: 0x0400679F RID: 26527
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<PinballBattleBuffItem, IBuffView> BuffLayout;

	// Token: 0x040067A0 RID: 26528
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x040067A1 RID: 26529
	private AKSC_Shape2D_Entity_Player OwnerEntity;

	// Token: 0x040067A2 RID: 26530
	private UKSC_SkillComp OwnerSkillComp;

	// Token: 0x040067A3 RID: 26531
	private UKSC_AttrSet OwnerAttrSet;

	// Token: 0x040067A4 RID: 26532
	private bool IsPlayedChargeTips;

	// Token: 0x040067A5 RID: 26533
	private PinballBattleRoleSkillItem.EState? CurState;

	// Token: 0x040067A6 RID: 26534
	private FOnKSCAttrChange ChargeDelegate;

	// Token: 0x040067A7 RID: 26535
	private FOnKSCAttrChange HpDelegate;

	// Token: 0x040067A8 RID: 26536
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IBuffView> CurBuffViewList;

	// Token: 0x040067A9 RID: 26537
	private readonly FName? NamePercent = FNameUtil.GetDynamicFName("percent");

	// Token: 0x040067AA RID: 26538
	public Action<int> OnSkillClickCallback;

	// Token: 0x040067AB RID: 26539
	private double LastSkillClickTime;

	// Token: 0x020082F2 RID: 33522
	[NullableContext(0)]
	private enum EState
	{
		// Token: 0x0402AB6D RID: 174957
		None,
		// Token: 0x0402AB6E RID: 174958
		Normal,
		// Token: 0x0402AB6F RID: 174959
		Charge,
		// Token: 0x0402AB70 RID: 174960
		Dead
	}
}
