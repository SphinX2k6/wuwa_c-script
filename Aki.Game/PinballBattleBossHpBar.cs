using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011AA RID: 4522
[NullableContext(2)]
[Nullable(0)]
public class PinballBattleBossHpBar : UiPanelBase
{
	// Token: 0x0600B446 RID: 46150 RVA: 0x00353DA8 File Offset: 0x00351FA8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600B447 RID: 46151 RVA: 0x00353E54 File Offset: 0x00352054
	protected override void OnStart()
	{
		this.HpBar = base.GetSprite(0);
		UUISprite hpBar = this.HpBar;
		this.HpBarMaxAnchorOffsetX = ((hpBar != null) ? hpBar.GetWidth() : 0f);
		this.ShieldBar = base.GetSprite(1);
		UUISprite shieldBar = this.ShieldBar;
		this.ShieldBarMaxAnchorOffsetX = ((shieldBar != null) ? shieldBar.GetWidth() : 0f);
	}

	// Token: 0x0600B448 RID: 46152 RVA: 0x00353EB3 File Offset: 0x003520B3
	protected override void OnBeforeDestroy()
	{
		this.ClearDelegate();
		LguiFloatTween hpBarTween = this.HpBarTween;
		if (hpBarTween != null)
		{
			hpBarTween.Destroy();
		}
		LguiFloatTween shieldBarTween = this.ShieldBarTween;
		if (shieldBarTween == null)
		{
			return;
		}
		shieldBarTween.Destroy();
	}

	// Token: 0x0600B449 RID: 46153 RVA: 0x00353EDC File Offset: 0x003520DC
	private float CalculateHpBarAnchorOffsetX(float hpPercent)
	{
		return MathUtils.Instance.Lerp(-this.HpBarMaxAnchorOffsetX, 0f, hpPercent);
	}

	// Token: 0x0600B44A RID: 46154 RVA: 0x00353EF8 File Offset: 0x003520F8
	private void PlayHpBarTween(float targetAnchorOffsetX, float duration = 0.3f)
	{
		if (this.HpBar == null)
		{
			return;
		}
		if (this.HpBarTween == null)
		{
			this.HpBarTween = new LguiFloatTween();
		}
		float anchorOffsetX = this.HpBar.GetAnchorOffsetX();
		if (Math.Abs(anchorOffsetX - targetAnchorOffsetX) < 0.01f)
		{
			return;
		}
		this.HpBarTween.BindUpdateTween(delegate(float value)
		{
			UUISprite hpBar = this.HpBar;
			if (hpBar == null)
			{
				return;
			}
			hpBar.SetAnchorOffsetX(value);
		});
		this.HpBarTween.PlayTween(anchorOffsetX, targetAnchorOffsetX, duration, null);
	}

	// Token: 0x0600B44B RID: 46155 RVA: 0x00353F64 File Offset: 0x00352164
	[NullableContext(1)]
	public void Refresh(FKSC_HeadHpContext hpContext)
	{
		EKSC_HeadHpContextType actionType = hpContext.ActionType;
		if (actionType > EKSC_HeadHpContextType.Update)
		{
			if (actionType != EKSC_HeadHpContextType.Remove)
			{
				return;
			}
			this.UnInit(hpContext.EntityId);
		}
		else if (this.EntityId == 0)
		{
			this.Init(hpContext.EntityId);
			return;
		}
	}

	// Token: 0x0600B44C RID: 46156 RVA: 0x00353FA4 File Offset: 0x003521A4
	private void Init(int entityId)
	{
		PinballBattleSubModel pinballBattleSubModel = KuroSimpleCombatController.Instance.CurSubModel as PinballBattleSubModel;
		KscEntityHandle kscEntityHandle2;
		KscEntityHandle kscEntityHandle = (pinballBattleSubModel != null && pinballBattleSubModel.KscEntities.TryGetValue(entityId, out kscEntityHandle2)) ? kscEntityHandle2 : null;
		AKSC_Entity aksc_Entity = (kscEntityHandle != null) ? kscEntityHandle.KscEntity : null;
		if (aksc_Entity == null)
		{
			Log.Instance.Error(ELogModule.PinballBattle, ELogAuthor.LJ, "未根据ksc实体id找到指定Ksc实体，无法绑定Boss血条！", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.EntityId = entityId;
		UKSC_SkillComp skillComp_ = aksc_Entity.SkillComp_;
		this.OwnerAttrSet = ((skillComp_ != null) ? skillComp_.AttrSet_ : null);
		base.SetUiActive(true);
		if (this.OwnerAttrSet != null)
		{
			this.BindHpDelegate(this.OwnerAttrSet);
			this.BindShieldDelegate(this.OwnerAttrSet);
		}
	}

	// Token: 0x0600B44D RID: 46157 RVA: 0x00354050 File Offset: 0x00352250
	private void UnInit(int entityId)
	{
		if (entityId != this.EntityId)
		{
			return;
		}
		this.ClearDelegate();
		this.EntityId = 0;
		this.OwnerAttrSet = null;
		base.SetUiActive(false);
	}

	// Token: 0x0600B44E RID: 46158 RVA: 0x00354077 File Offset: 0x00352277
	private void ClearDelegate()
	{
		this.UnBindHpDelegate();
		this.UnBindShieldDelegate();
	}

	// Token: 0x0600B44F RID: 46159 RVA: 0x00354088 File Offset: 0x00352288
	[NullableContext(1)]
	public void BindHpDelegate(UKSC_AttrSet attrSet)
	{
		this.UnBindHpDelegate();
		this.DelegateHpChange = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnHpChange));
		attrSet.AssignAttrListen(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.CurHpType, this.DelegateHpChange);
		attrSet.AssignAttrListen(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.MaxHpType, this.DelegateHpChange);
		this.UpdateHpBar(true);
	}

	// Token: 0x0600B450 RID: 46160 RVA: 0x003540DC File Offset: 0x003522DC
	public void UnBindHpDelegate()
	{
		if (this.OwnerAttrSet != null)
		{
			this.OwnerAttrSet.RemoveAttrListen(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.CurHpType, this.DelegateHpChange);
			this.OwnerAttrSet.RemoveAttrListen(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.MaxHpType, this.DelegateHpChange);
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<EKSC_AttrType, int>(this.OnHpChange));
			this.DelegateHpChange = null;
		}
	}

	// Token: 0x0600B451 RID: 46161 RVA: 0x00354135 File Offset: 0x00352335
	private void OnHpChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateHpBar(false);
	}

	// Token: 0x0600B452 RID: 46162 RVA: 0x00354140 File Offset: 0x00352340
	private void UpdateHpBar(bool disableTween = false)
	{
		if (this.OwnerAttrSet == null || this.HpBar == null)
		{
			return;
		}
		TMap<EKSC_AttrType, int> attrs_ = this.OwnerAttrSet.Attrs_;
		float valueOrDefault = (float)((attrs_ != null) ? attrs_.GetValueOrNull(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.CurHpType) : null).GetValueOrDefault();
		TMap<EKSC_AttrType, int> attrs_2 = this.OwnerAttrSet.Attrs_;
		int valueOrDefault2 = ((attrs_2 != null) ? attrs_2.GetValueOrNull(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.MaxHpType) : null).GetValueOrDefault(1);
		float hpPercent = valueOrDefault / (float)valueOrDefault2;
		float num = this.CalculateHpBarAnchorOffsetX(hpPercent);
		if (disableTween)
		{
			this.HpBar.SetAnchorOffsetX(num);
			return;
		}
		this.PlayHpBarTween(num, 0.3f);
	}

	// Token: 0x0600B453 RID: 46163 RVA: 0x003541E4 File Offset: 0x003523E4
	[NullableContext(1)]
	public void BindShieldDelegate(UKSC_AttrSet attrSet)
	{
		this.UnBindShieldDelegate();
		this.DelegateShieldChange = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnShieldChange));
		attrSet.AssignAttrListen(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.CurShieldType, this.DelegateShieldChange);
		attrSet.AssignAttrListen(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.MaxShieldType, this.DelegateShieldChange);
		this.UpdateShieldBar(true);
	}

	// Token: 0x0600B454 RID: 46164 RVA: 0x00354238 File Offset: 0x00352438
	public void UnBindShieldDelegate()
	{
		if (this.OwnerAttrSet != null)
		{
			this.OwnerAttrSet.RemoveAttrListen(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.CurShieldType, this.DelegateShieldChange);
			this.OwnerAttrSet.RemoveAttrListen(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.MaxShieldType, this.DelegateShieldChange);
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<EKSC_AttrType, int>(this.OnShieldChange));
			this.DelegateShieldChange = null;
		}
	}

	// Token: 0x0600B455 RID: 46165 RVA: 0x00354291 File Offset: 0x00352491
	private void OnShieldChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateShieldBar(false);
	}

	// Token: 0x0600B456 RID: 46166 RVA: 0x0035429A File Offset: 0x0035249A
	private float CalculateShieldBarAnchorOffsetX(float shieldPercent)
	{
		return MathUtils.Instance.Lerp(-this.ShieldBarMaxAnchorOffsetX, 0f, shieldPercent);
	}

	// Token: 0x0600B457 RID: 46167 RVA: 0x003542B4 File Offset: 0x003524B4
	private void PlayShieldBarTween(float targetAnchorOffsetX, float duration = 0.3f)
	{
		if (this.ShieldBar == null)
		{
			return;
		}
		if (this.ShieldBarTween == null)
		{
			this.ShieldBarTween = new LguiFloatTween();
		}
		float anchorOffsetX = this.ShieldBar.GetAnchorOffsetX();
		if (Math.Abs(anchorOffsetX - targetAnchorOffsetX) < 0.01f)
		{
			return;
		}
		this.ShieldBarTween.BindUpdateTween(delegate(float value)
		{
			UUISprite shieldBar = this.ShieldBar;
			if (shieldBar == null)
			{
				return;
			}
			shieldBar.SetAnchorOffsetX(value);
		});
		this.ShieldBarTween.PlayTween(anchorOffsetX, targetAnchorOffsetX, duration, null);
	}

	// Token: 0x0600B458 RID: 46168 RVA: 0x00354320 File Offset: 0x00352520
	private void UpdateShieldBar(bool disableTween = false)
	{
		if (this.OwnerAttrSet == null || this.ShieldBar == null)
		{
			return;
		}
		TMap<EKSC_AttrType, int> attrs_ = this.OwnerAttrSet.Attrs_;
		float valueOrDefault = (float)((attrs_ != null) ? attrs_.GetValueOrNull(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.CurShieldType) : null).GetValueOrDefault();
		TMap<EKSC_AttrType, int> attrs_2 = this.OwnerAttrSet.Attrs_;
		int valueOrDefault2 = ((attrs_2 != null) ? attrs_2.GetValueOrNull(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.MaxShieldType) : null).GetValueOrDefault(1);
		float shieldPercent = valueOrDefault / (float)valueOrDefault2;
		float num = this.CalculateShieldBarAnchorOffsetX(shieldPercent);
		if (disableTween)
		{
			this.ShieldBar.SetAnchorOffsetX(num);
			return;
		}
		this.PlayShieldBarTween(num, 0.3f);
	}

	// Token: 0x04006822 RID: 26658
	private int EntityId;

	// Token: 0x04006823 RID: 26659
	private UKSC_AttrSet OwnerAttrSet;

	// Token: 0x04006824 RID: 26660
	private UUISprite HpBar;

	// Token: 0x04006825 RID: 26661
	private UUISprite ShieldBar;

	// Token: 0x04006826 RID: 26662
	private float HpBarMaxAnchorOffsetX;

	// Token: 0x04006827 RID: 26663
	private LguiFloatTween HpBarTween;

	// Token: 0x04006828 RID: 26664
	private float ShieldBarMaxAnchorOffsetX;

	// Token: 0x04006829 RID: 26665
	private LguiFloatTween ShieldBarTween;

	// Token: 0x0400682A RID: 26666
	private FOnKSCAttrChange DelegateHpChange;

	// Token: 0x0400682B RID: 26667
	private FOnKSCAttrChange DelegateShieldChange;
}
