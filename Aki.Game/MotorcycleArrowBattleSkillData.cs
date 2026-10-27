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

// Token: 0x02001CD3 RID: 7379
[NullableContext(2)]
[Nullable(0)]
public class MotorcycleArrowBattleSkillData : BattleSkillDataBase
{
	// Token: 0x0600DF78 RID: 57208 RVA: 0x00345830 File Offset: 0x00343A30
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

	// Token: 0x0600DF79 RID: 57209 RVA: 0x00345902 File Offset: 0x00343B02
	protected override void OnInitData()
	{
		if (this.SkillId == 0)
		{
			return;
		}
		this.SkillButtonConfig = this.GetActiveSkillButtonConfig();
	}

	// Token: 0x0600DF7A RID: 57210 RVA: 0x0034591C File Offset: 0x00343B1C
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

	// Token: 0x0600DF7B RID: 57211 RVA: 0x0034597F File Offset: 0x00343B7F
	public override int GetSkillId()
	{
		return this.SkillId;
	}

	// Token: 0x0600DF7C RID: 57212 RVA: 0x00345988 File Offset: 0x00343B88
	public override string GetSkillTexturePath()
	{
		if (this.SkillButtonConfig == null)
		{
			return null;
		}
		return this.SkillButtonConfig.GetValueOrDefault().SkillIcon;
	}

	// Token: 0x0600DF7D RID: 57213 RVA: 0x003459B4 File Offset: 0x00343BB4
	public override EInputAction GetActionType()
	{
		if (this.SkillButtonConfig != null)
		{
			return (EInputAction)((byte)this.SkillButtonConfig.Value.ButtonType);
		}
		return EInputAction.None;
	}

	// Token: 0x0600DF7E RID: 57214 RVA: 0x003459F0 File Offset: 0x00343BF0
	public override ESkillButtonType GetButtonType()
	{
		if (this.SkillButtonConfig != null)
		{
			return (ESkillButtonType)this.SkillButtonConfig.Value.ButtonType;
		}
		return ESkillButtonType.None;
	}

	// Token: 0x0600DF7F RID: 57215 RVA: 0x00345A1F File Offset: 0x00343C1F
	public override FColor? GetFrameSpriteColor()
	{
		return this.FrameSpriteColor;
	}

	// Token: 0x0600DF80 RID: 57216 RVA: 0x00345A27 File Offset: 0x00343C27
	public override FLinearColor? GetMaxAttributeColor()
	{
		return this.MaxAttributeColor;
	}

	// Token: 0x0600DF81 RID: 57217 RVA: 0x00345A2F File Offset: 0x00343C2F
	[NullableContext(1)]
	public override string GetMaxAttributeEffectPath()
	{
		if (!Info.Instance.IsInTouch())
		{
			return this.MaxAttributeEffectPc;
		}
		return this.MaxAttributeEffect;
	}

	// Token: 0x0600DF82 RID: 57218 RVA: 0x00345A4C File Offset: 0x00343C4C
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

	// Token: 0x0600DF83 RID: 57219 RVA: 0x00345A82 File Offset: 0x00343C82
	public override bool IsEnable()
	{
		return this.IsEnableInternal;
	}

	// Token: 0x0600DF84 RID: 57220 RVA: 0x00345A8C File Offset: 0x00343C8C
	public override float GetAttribute()
	{
		if (this.AttrMap == null)
		{
			return 0f;
		}
		int num;
		return (float)(this.AttrMap.TryGetValue(this.KscAttrId, out num) ? num : 0);
	}

	// Token: 0x0600DF85 RID: 57221 RVA: 0x00345AC4 File Offset: 0x00343CC4
	public override float GetMaxAttribute()
	{
		if (this.AttrMap == null)
		{
			return 0f;
		}
		int num;
		return (float)(this.AttrMap.TryGetValue(this.MaxKscAttributeId, out num) ? num : 0);
	}

	// Token: 0x0600DF86 RID: 57222 RVA: 0x00345AF9 File Offset: 0x00343CF9
	public override bool HasAttribute()
	{
		return true;
	}

	// Token: 0x0600DF87 RID: 57223 RVA: 0x00345AFC File Offset: 0x00343CFC
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

	// Token: 0x0600DF88 RID: 57224 RVA: 0x00345BD1 File Offset: 0x00343DD1
	private void OnAttrChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateAttrChange();
	}

	// Token: 0x0600DF89 RID: 57225 RVA: 0x00345BD9 File Offset: 0x00343DD9
	private void OnMaxAttrChange(EKSC_AttrType attrType, int value)
	{
		this.UpdateAttrChange();
	}

	// Token: 0x0600DF8A RID: 57226 RVA: 0x00345BE1 File Offset: 0x00343DE1
	protected void UpdateAttrChange()
	{
		this.RefreshIsEnable();
		EventSystem.Instance.Emit<ESkillButtonType>(EEventName.OnSkillButtonAttributeRefresh, this.GetButtonType());
	}

	// Token: 0x0600DF8B RID: 57227 RVA: 0x00345BFF File Offset: 0x00343DFF
	public void SetVisible(bool visible)
	{
		this.IsVisibleInternal = visible;
	}

	// Token: 0x0600DF8C RID: 57228 RVA: 0x00345C08 File Offset: 0x00343E08
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

	// Token: 0x040066C8 RID: 26312
	private bool IsEnableInternal;

	// Token: 0x040066C9 RID: 26313
	private readonly int SkillId;

	// Token: 0x040066CA RID: 26314
	private SkillGameplayButton? SkillButtonConfig;

	// Token: 0x040066CB RID: 26315
	private TMap<EKSC_AttrType, int> AttrMap;

	// Token: 0x040066CC RID: 26316
	private UKSC_AttrSet AttrSet;

	// Token: 0x040066CD RID: 26317
	private readonly EKSC_AttrType KscAttrId = EKSC_AttrType.SpecialChange1;

	// Token: 0x040066CE RID: 26318
	private readonly EKSC_AttrType MaxKscAttributeId = EKSC_AttrType.SpecialChange0;

	// Token: 0x040066CF RID: 26319
	private readonly FColor? FrameSpriteColor;

	// Token: 0x040066D0 RID: 26320
	private readonly FLinearColor? MaxAttributeColor;

	// Token: 0x040066D1 RID: 26321
	[Nullable(1)]
	private readonly string MaxAttributeEffect = "";

	// Token: 0x040066D2 RID: 26322
	[Nullable(1)]
	private readonly string MaxAttributeEffectPc = "";

	// Token: 0x040066D3 RID: 26323
	public FOnKSCAttrChange DelegateAttrChange;

	// Token: 0x040066D4 RID: 26324
	public FOnKSCAttrChange DelegateMaxAttrChange;
}
