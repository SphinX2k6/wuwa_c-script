using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Core.Common;
using CSharpScript.Game.Input;
using CSharpScript.Game.NewWorld.Character.Common.Component;

// Token: 0x02002620 RID: 9760
[NullableContext(2)]
[Nullable(0)]
public class ManipulateInputLayer : InputLayer
{
	// Token: 0x060185F7 RID: 99831 RVA: 0x0075B2D8 File Offset: 0x007594D8
	[NullableContext(1)]
	public void Init(EntityHandle entityHandle)
	{
		WorldEntity entity = entityHandle.Entity;
		this.TagComp = entity.GetComponent<RoleTagComponent>();
		this.SkillComp = entity.GetComponent<CharacterSkillComponent>();
		this.CreatureDataComp = entity.GetComponent<CreatureDataComponent>();
	}

	// Token: 0x060185F8 RID: 99832 RVA: 0x0075B310 File Offset: 0x00759510
	public override void Clear()
	{
		this.TagComp = null;
		this.SkillComp = null;
		this.CreatureDataComp = null;
	}

	// Token: 0x060185F9 RID: 99833 RVA: 0x0075B327 File Offset: 0x00759527
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Manipulate;
	}

	// Token: 0x060185FA RID: 99834 RVA: 0x0075B32C File Offset: 0x0075952C
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		ManipulateSkillConfigData manipulateSkillConfig = this.GetManipulateSkillConfig();
		byte b = action;
		switch (b)
		{
		case 4:
			if (manipulateSkillConfig.CastSkillId != 0 && !this.TagComp.HasAnyTag(this.ThrowForbidTags))
			{
				this.SkillComp.BeginSkill(manipulateSkillConfig.CastSkillId, new SkillParam
				{
					Reason = "Manipulate InputLayer, Item Throw"
				});
			}
			return InputLayer.GetSwallowCommand();
		case 5:
			break;
		case 6:
			if (this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.控物拼图旋转.可用"]))
			{
				this.SkillComp.BeginSkill(210009, new SkillParam
				{
					Reason = "Manipulate InputLayer, Item Rotate"
				});
				return InputLayer.GetSwallowCommand();
			}
			break;
		case 7:
			if (!Info.Instance.IsInTouch())
			{
				if (manipulateSkillConfig.CancelSkillId != 0 && !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.新版控物.输入.控物放下禁止"]))
				{
					this.SkillComp.BeginSkill(manipulateSkillConfig.CancelSkillId, new SkillParam
					{
						Reason = "Manipulate InputLayer, Item Release"
					});
				}
				return InputLayer.GetSwallowCommand();
			}
			break;
		default:
			if (b == 14)
			{
				this.SkillComp.BeginSkill(240001, new SkillParam
				{
					Reason = "Manipulate InputLayer, Item Rotate"
				});
				return InputLayer.GetSwallowCommand();
			}
			break;
		}
		if (ManipulateInputLayer.actionsForbid.Contains(action) && this.IsManipulating())
		{
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x060185FB RID: 99835 RVA: 0x0075B490 File Offset: 0x00759690
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		if (action == 7 && Info.Instance.IsInTouch())
		{
			int cancelSkillId = this.GetManipulateSkillConfig().CancelSkillId;
			if (cancelSkillId != 0 && !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.新版控物.输入.控物放下禁止"]))
			{
				this.SkillComp.BeginSkill(cancelSkillId, new SkillParam
				{
					Reason = "Manipulate InputLayer, Item Release"
				});
			}
			return InputLayer.GetSwallowCommand();
		}
		if (this.IsManipulating())
		{
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x060185FC RID: 99836 RVA: 0x0075B50F File Offset: 0x0075970F
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		if (this.IsManipulating())
		{
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x060185FD RID: 99837 RVA: 0x0075B520 File Offset: 0x00759720
	[NullableContext(1)]
	private ManipulateSkillConfigData GetManipulateSkillConfig()
	{
		CreatureDataComponent creatureDataComp = this.CreatureDataComp;
		return ManipulateSkillConfig.GetSkillConfig((creatureDataComp != null) ? creatureDataComp.GetRoleId() : 0);
	}

	// Token: 0x060185FE RID: 99838 RVA: 0x0075B539 File Offset: 0x00759739
	private bool IsManipulating()
	{
		return this.TagComp.HasAnyTag(this.ManipulatingTags) && !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.控物.可释放技能"]);
	}

	// Token: 0x0400D269 RID: 53865
	private const int MANIPULATE_ROTATE_SKILL = 210009;

	// Token: 0x0400D26A RID: 53866
	private const int MANIPULATE_PARABOLA_SKILL = 240001;

	// Token: 0x0400D26B RID: 53867
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly List<EInputAction> actionsForbid = new List<EInputAction>
	{
		EInputAction.攻击,
		EInputAction.幻象1,
		EInputAction.幻象2,
		EInputAction.技能1,
		EInputAction.瞄准,
		EInputAction.大招
	};

	// Token: 0x0400D26C RID: 53868
	private RoleTagComponent TagComp;

	// Token: 0x0400D26D RID: 53869
	private CharacterSkillComponent SkillComp;

	// Token: 0x0400D26E RID: 53870
	private CreatureDataComponent CreatureDataComp;

	// Token: 0x0400D26F RID: 53871
	[Nullable(1)]
	private readonly int[] ThrowForbidTags = new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.新版控物.输入.控物投掷禁止"],
		GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.控物投掷不可用"],
		GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]
	};

	// Token: 0x0400D270 RID: 53872
	[Nullable(1)]
	private readonly int[] ManipulatingTags = new int[]
	{
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.控物.控物中"],
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.控物.控物选取"],
		GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.控物.进入投掷"]
	};
}
