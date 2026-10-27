using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.KuroSimpleCombat;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CE8 RID: 7400
[NullableContext(2)]
[Nullable(0)]
public class PinballBattleBossHpBar : UiPanelBase
{
	// Token: 0x0600E029 RID: 57385 RVA: 0x00348380 File Offset: 0x00346580
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

	// Token: 0x0600E02A RID: 57386 RVA: 0x0034842C File Offset: 0x0034662C
	protected override void OnStart()
	{
		this.HpBar = base.GetSprite(0);
		UUISprite hpBar = this.HpBar;
		this.HpBarMaxAnchorOffsetX = ((hpBar != null) ? hpBar.GetWidth() : 0f);
		this.ShieldBar = base.GetSprite(1);
		UUISprite shieldBar = this.ShieldBar;
		this.ShieldBarMaxAnchorOffsetX = ((shieldBar != null) ? shieldBar.GetWidth() : 0f);
	}

	// Token: 0x0600E02B RID: 57387 RVA: 0x0034848B File Offset: 0x0034668B
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

	// Token: 0x0600E02C RID: 57388 RVA: 0x003484B4 File Offset: 0x003466B4
	private float CalculateHpBarAnchorOffsetX(float hpPercent)
	{
		return MathUtils.Instance.Lerp(-this.HpBarMaxAnchorOffsetX, 0f, hpPercent);
	}

	// Token: 0x0600E02D RID: 57389 RVA: 0x003484D0 File Offset: 0x003466D0
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

	// Token: 0x0600E02E RID: 57390 RVA: 0x0034853C File Offset: 0x0034673C
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

	// Token: 0x0600E02F RID: 57391 RVA: 0x0034857C File Offset: 0x0034677C
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

	// Token: 0x0600E030 RID: 57392 RVA: 0x00348628 File Offset: 0x00346828
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

	// Token: 0x0600E031 RID: 57393 RVA: 0x0034864F File Offset: 0x0034684F
	private void ClearDelegate()
	{
		this.UnBindHpDelegate();
		this.UnBindShieldDelegate();
	}

	// Token: 0x0600E032 RID: 57394 RVA: 0x00348660 File Offset: 0x00346860
	[NullableContext(1)]
	public void BindHpDelegate(UKSC_AttrSet attrSet)
	{
		this.UnBindHpDelegate();
		this.DelegateHpChange = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnHpChange));
		attrSet.AssignAttrListen(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.CurHpType, this.DelegateHpChange);
		attrSet.AssignAttrListen(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.MaxHpType, this.DelegateHpChange);
		this.UpdateHpBar(true);
	}

	// Token: 0x0600E033 RID: 57395 RVA: 0x003486B4 File Offset: 0x003468B4
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

	// Token: 0x0600E034 RID: 57396 RVA: 0x0034870D File Offset: 0x0034690D
	private void OnHpChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateHpBar(false);
	}

	// Token: 0x0600E035 RID: 57397 RVA: 0x00348718 File Offset: 0x00346918
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

	// Token: 0x0600E036 RID: 57398 RVA: 0x003487BC File Offset: 0x003469BC
	[NullableContext(1)]
	public void BindShieldDelegate(UKSC_AttrSet attrSet)
	{
		this.UnBindShieldDelegate();
		this.DelegateShieldChange = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnShieldChange));
		attrSet.AssignAttrListen(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.CurShieldType, this.DelegateShieldChange);
		attrSet.AssignAttrListen(<PinballBattleBossHpBar>F2C55DEDC3641F2EF332E79ACAE76522F2D64CFC6C1E139BC29C88C68355FA4FF__BossHpConst.MaxShieldType, this.DelegateShieldChange);
		this.UpdateShieldBar(true);
	}

	// Token: 0x0600E037 RID: 57399 RVA: 0x00348810 File Offset: 0x00346A10
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

	// Token: 0x0600E038 RID: 57400 RVA: 0x00348869 File Offset: 0x00346A69
	private void OnShieldChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateShieldBar(false);
	}

	// Token: 0x0600E039 RID: 57401 RVA: 0x00348872 File Offset: 0x00346A72
	private float CalculateShieldBarAnchorOffsetX(float shieldPercent)
	{
		return MathUtils.Instance.Lerp(-this.ShieldBarMaxAnchorOffsetX, 0f, shieldPercent);
	}

	// Token: 0x0600E03A RID: 57402 RVA: 0x0034888C File Offset: 0x00346A8C
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

	// Token: 0x0600E03B RID: 57403 RVA: 0x003488F8 File Offset: 0x00346AF8
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

	// Token: 0x04006743 RID: 26435
	private int EntityId;

	// Token: 0x04006744 RID: 26436
	private UKSC_AttrSet OwnerAttrSet;

	// Token: 0x04006745 RID: 26437
	private UUISprite HpBar;

	// Token: 0x04006746 RID: 26438
	private UUISprite ShieldBar;

	// Token: 0x04006747 RID: 26439
	private float HpBarMaxAnchorOffsetX;

	// Token: 0x04006748 RID: 26440
	private LguiFloatTween HpBarTween;

	// Token: 0x04006749 RID: 26441
	private float ShieldBarMaxAnchorOffsetX;

	// Token: 0x0400674A RID: 26442
	private LguiFloatTween ShieldBarTween;

	// Token: 0x0400674B RID: 26443
	private FOnKSCAttrChange DelegateHpChange;

	// Token: 0x0400674C RID: 26444
	private FOnKSCAttrChange DelegateShieldChange;
}
