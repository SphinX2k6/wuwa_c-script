using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.GameMainView.Data;
using CSharpScript.Game.Module.SkillButtonUi;
using UnrealEngine;

// Token: 0x02001195 RID: 4501
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleArrowBattleSkillData : BattleSkillDataBase
{
	// Token: 0x0600B395 RID: 45973 RVA: 0x00351258 File Offset: 0x0034F458
	public MotorcycleArrowBattleSkillData(int skillId)
	{
		this.SkillId = skillId;
		this.IsVisibleInternal = false;
		string stringConfig = ConfigCommonParamById.GetStringConfig("MotorArrowSkillColor");
		if (!string.IsNullOrEmpty(stringConfig))
		{
			this.FrameSpriteColor = new FColor?(FColor.FromHex(stringConfig));
		}
		string stringConfig2 = ConfigCommonParamById.GetStringConfig("MotorArrowSkillEffectColor");
		if (!string.IsNullOrEmpty(stringConfig2))
		{
			FColor fcolor = FColor.FromHex(stringConfig2);
			this.MaxAttributeColor = new FLinearColor?(new FLinearColor(ref fcolor));
		}
		string stringConfig3 = ConfigCommonParamById.GetStringConfig("MotorArrowSkillEffectPath");
		if (!string.IsNullOrEmpty(stringConfig3))
		{
			this.MaxAttributeEffect = stringConfig3;
		}
		string stringConfig4 = ConfigCommonParamById.GetStringConfig("MotorArrowSkillEffectPathPC");
		if (!string.IsNullOrEmpty(stringConfig4))
		{
			this.MaxAttributeEffectPc = stringConfig4;
		}
	}

	// Token: 0x0600B396 RID: 45974 RVA: 0x0035132A File Offset: 0x0034F52A
	protected override void OnInitData()
	{
		if (this.SkillId == 0)
		{
			return;
		}
		this.SkillButtonConfig = this.GetActiveSkillButtonConfig();
	}

	// Token: 0x0600B397 RID: 45975 RVA: 0x00351344 File Offset: 0x0034F544
	private SkillGameplayButton? GetActiveSkillButtonConfig()
	{
		IReadOnlyList<SkillGameplayButton> configList = ConfigSkillGameplayButtonByGameplayType.GetConfigList(5, true);
		if (configList == null)
		{
			return null;
		}
		string actionName = base.GetActionName();
		for (int i = 0; i < configList.Count; i++)
		{
			SkillGameplayButton value = configList[i];
			if (value.ActionName == actionName)
			{
				return new SkillGameplayButton?(value);
			}
		}
		return null;
	}

	// Token: 0x0600B398 RID: 45976 RVA: 0x003513A7 File Offset: 0x0034F5A7
	public override int GetSkillId()
	{
		return this.SkillId;
	}

	// Token: 0x0600B399 RID: 45977 RVA: 0x003513B0 File Offset: 0x0034F5B0
	public override string GetSkillTexturePath()
	{
		if (this.SkillButtonConfig == null)
		{
			return null;
		}
		return this.SkillButtonConfig.GetValueOrDefault().SkillIcon;
	}

	// Token: 0x0600B39A RID: 45978 RVA: 0x003513DC File Offset: 0x0034F5DC
	public override EInputAction GetActionType()
	{
		if (this.SkillButtonConfig != null)
		{
			return (EInputAction)((byte)this.SkillButtonConfig.Value.ButtonType);
		}
		return EInputAction.None;
	}

	// Token: 0x0600B39B RID: 45979 RVA: 0x00351418 File Offset: 0x0034F618
	public override ESkillButtonType GetButtonType()
	{
		if (this.SkillButtonConfig != null)
		{
			return (ESkillButtonType)this.SkillButtonConfig.Value.ButtonType;
		}
		return ESkillButtonType.None;
	}

	// Token: 0x0600B39C RID: 45980 RVA: 0x00351447 File Offset: 0x0034F647
	public override FColor? GetFrameSpriteColor()
	{
		return this.FrameSpriteColor;
	}

	// Token: 0x0600B39D RID: 45981 RVA: 0x0035144F File Offset: 0x0034F64F
	public override FLinearColor? GetMaxAttributeColor()
	{
		return this.MaxAttributeColor;
	}

	// Token: 0x0600B39E RID: 45982 RVA: 0x00351457 File Offset: 0x0034F657
	[NullableContext(1)]
	public override string GetMaxAttributeEffectPath()
	{
		if (!Info.Instance.IsInTouch())
		{
			return this.MaxAttributeEffectPc;
		}
		return this.MaxAttributeEffect;
	}

	// Token: 0x0600B39F RID: 45983 RVA: 0x00351474 File Offset: 0x0034F674
	public override void RefreshIsEnable()
	{
		float attribute = this.GetAttribute();
		float maxAttribute = this.GetMaxAttribute();
		if (attribute >= maxAttribute && attribute > 0f)
		{
			this.IsEnableInternal = true;
			return;
		}
		this.IsEnableInternal = false;
	}

	// Token: 0x0600B3A0 RID: 45984 RVA: 0x003514AA File Offset: 0x0034F6AA
	public override bool IsEnable()
	{
		return this.IsEnableInternal;
	}

	// Token: 0x0600B3A1 RID: 45985 RVA: 0x003514B4 File Offset: 0x0034F6B4
	public override float GetAttribute()
	{
		if (this.AttrMap == null)
		{
			return 0f;
		}
		int num;
		return (float)(this.AttrMap.TryGetValue(this.KscAttrId, out num) ? num : 0);
	}

	// Token: 0x0600B3A2 RID: 45986 RVA: 0x003514EC File Offset: 0x0034F6EC
	public override float GetMaxAttribute()
	{
		if (this.AttrMap == null)
		{
			return 0f;
		}
		int num;
		return (float)(this.AttrMap.TryGetValue(this.MaxKscAttributeId, out num) ? num : 0);
	}

	// Token: 0x0600B3A3 RID: 45987 RVA: 0x00351521 File Offset: 0x0034F721
	public override bool HasAttribute()
	{
		return true;
	}

	// Token: 0x0600B3A4 RID: 45988 RVA: 0x00351524 File Offset: 0x0034F724
	[NullableContext(1)]
	public void InitAttrData(AKSC_Entity kscEntity)
	{
		UKSC_AttrSet uksc_AttrSet;
		if (kscEntity == null)
		{
			uksc_AttrSet = null;
		}
		else
		{
			UKSC_SkillComp skillComp = kscEntity.GetSkillComp();
			uksc_AttrSet = ((skillComp != null) ? skillComp.AttrSet_ : null);
		}
		UKSC_AttrSet uksc_AttrSet2 = uksc_AttrSet;
		TMap<EKSC_AttrType, int> tmap = (uksc_AttrSet2 != null) ? uksc_AttrSet2.Attrs_ : null;
		if (tmap == null)
		{
			Log.Instance.Error(ELogModule.UiComponent, ELogAuthor.TZQ, "[摩托战斗]技能按钮获取属性失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		Log.Instance.Info(ELogModule.UiComponent, ELogAuthor.TZQ, "[摩托战斗]技能按钮获取属性成功", default(ReadOnlySpan<ValueTuple<string, object>>));
		this.AttrMap = tmap;
		this.AttrSet = uksc_AttrSet2;
		this.DelegateAttrChange = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnAttrChange));
		uksc_AttrSet2.AssignAttrListen(this.KscAttrId, this.DelegateAttrChange);
		this.DelegateMaxAttrChange = DelegateUtils.ToManualReleaseDelegate<FOnKSCAttrChange>(new Action<EKSC_AttrType, int>(this.OnMaxAttrChange));
		uksc_AttrSet2.AssignAttrListen(this.MaxKscAttributeId, this.DelegateMaxAttrChange);
		this.RefreshIsEnable();
	}

	// Token: 0x0600B3A5 RID: 45989 RVA: 0x003515F9 File Offset: 0x0034F7F9
	private void OnAttrChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateAttrChange();
	}

	// Token: 0x0600B3A6 RID: 45990 RVA: 0x00351601 File Offset: 0x0034F801
	private void OnMaxAttrChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateAttrChange();
	}

	// Token: 0x0600B3A7 RID: 45991 RVA: 0x00351609 File Offset: 0x0034F809
	protected void UpdateAttrChange()
	{
		this.RefreshIsEnable();
		EventSystem.Instance.Emit<ESkillButtonType>(EEventName.OnSkillButtonAttributeRefresh, this.GetButtonType());
	}

	// Token: 0x0600B3A8 RID: 45992 RVA: 0x00351627 File Offset: 0x0034F827
	public void SetVisible(bool visible)
	{
		this.IsVisibleInternal = visible;
	}

	// Token: 0x0600B3A9 RID: 45993 RVA: 0x00351630 File Offset: 0x0034F830
	public void Clear()
	{
		if (this.AttrSet != null)
		{
			if (this.DelegateAttrChange != null)
			{
				this.AttrSet.RemoveAttrListen(this.KscAttrId, this.DelegateAttrChange);
				this.DelegateAttrChange = null;
			}
			if (this.DelegateMaxAttrChange != null)
			{
				this.AttrSet.RemoveAttrListen(this.MaxKscAttributeId, this.DelegateMaxAttrChange);
				this.DelegateMaxAttrChange = null;
			}
			this.AttrSet = null;
		}
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<EKSC_AttrType, int>(this.OnAttrChange));
		DelegateUtils.ReleaseManualReleaseDelegate(new Action<EKSC_AttrType, int>(this.OnMaxAttrChange));
	}

	// Token: 0x040067A7 RID: 26535
	private bool IsEnableInternal;

	// Token: 0x040067A8 RID: 26536
	private readonly int SkillId;

	// Token: 0x040067A9 RID: 26537
	private SkillGameplayButton? SkillButtonConfig;

	// Token: 0x040067AA RID: 26538
	private TMap<EKSC_AttrType, int> AttrMap;

	// Token: 0x040067AB RID: 26539
	private UKSC_AttrSet AttrSet;

	// Token: 0x040067AC RID: 26540
	private readonly EKSC_AttrType KscAttrId = EKSC_AttrType.SpecialChange1;

	// Token: 0x040067AD RID: 26541
	private readonly EKSC_AttrType MaxKscAttributeId = EKSC_AttrType.SpecialChange0;

	// Token: 0x040067AE RID: 26542
	private readonly FColor? FrameSpriteColor;

	// Token: 0x040067AF RID: 26543
	private readonly FLinearColor? MaxAttributeColor;

	// Token: 0x040067B0 RID: 26544
	[Nullable(1)]
	private readonly string MaxAttributeEffect = "";

	// Token: 0x040067B1 RID: 26545
	[Nullable(1)]
	private readonly string MaxAttributeEffectPc = "";

	// Token: 0x040067B2 RID: 26546
	public FOnKSCAttrChange DelegateAttrChange;

	// Token: 0x040067B3 RID: 26547
	public FOnKSCAttrChange DelegateMaxAttrChange;
}
