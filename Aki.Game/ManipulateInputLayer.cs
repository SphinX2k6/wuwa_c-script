using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Core.Common;
using CSharpScript.Game.Input;
using CSharpScript.Game.NewWorld.Character.Common.Component;

// Token: 0x020030C8 RID: 12488
[NullableContext(2)]
[Nullable(0)]
public class ManipulateInputLayer : InputLayer
{
	// Token: 0x0601ABE3 RID: 109539 RVA: 0x0073567C File Offset: 0x0073387C
	[NullableContext(1)]
	public void Init(EntityHandle entityHandle)
	{
		WorldEntity entity = entityHandle.Entity;
		this.TagComp = entity.GetComponent<RoleTagComponent>();
		this.SkillComp = entity.GetComponent<CharacterSkillComponent>();
		this.CreatureDataComp = entity.GetComponent<CreatureDataComponent>();
	}

	// Token: 0x0601ABE4 RID: 109540 RVA: 0x007356B4 File Offset: 0x007338B4
	public override void Clear()
	{
		this.TagComp = null;
		this.SkillComp = null;
		this.CreatureDataComp = null;
	}

	// Token: 0x0601ABE5 RID: 109541 RVA: 0x007356CB File Offset: 0x007338CB
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Manipulate;
	}

	// Token: 0x0601ABE6 RID: 109542 RVA: 0x007356D0 File Offset: 0x007338D0
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		ManipulateSkillConfigData manipulateSkillConfig = this.GetManipulateSkillConfig();
		byte b = action;
		switch (b)
		{
		case 4:
			if (manipulateSkillConfig.CastSkillId != 0 && !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.新版控物.输入.控物投掷禁止"]))
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

	// Token: 0x0601ABE7 RID: 109543 RVA: 0x00735840 File Offset: 0x00733A40
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

	// Token: 0x0601ABE8 RID: 109544 RVA: 0x007358BF File Offset: 0x00733ABF
	public override SInputCommand HandleHold(EInputAction action, float time)
	{
		if (this.IsManipulating())
		{
			return InputLayer.GetSwallowCommand();
		}
		return null;
	}

	// Token: 0x0601ABE9 RID: 109545 RVA: 0x007358D0 File Offset: 0x00733AD0
	[NullableContext(1)]
	private ManipulateSkillConfigData GetManipulateSkillConfig()
	{
		CreatureDataComponent creatureDataComp = this.CreatureDataComp;
		return ManipulateSkillConfig.GetSkillConfig((creatureDataComp != null) ? creatureDataComp.GetRoleId() : 0);
	}

	// Token: 0x0601ABEA RID: 109546 RVA: 0x007358EC File Offset: 0x00733AEC
	private bool IsManipulating()
	{
		return this.TagComp.HasAnyTag(new int[]
		{
			GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.控物.控物中"],
			GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.控物.控物选取"],
			GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.控物.进入投掷"]
		}) && !this.TagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.控物.可释放技能"]);
	}

	// Token: 0x0400CE7B RID: 52859
	private const int MANIPULATE_ROTATE_SKILL = 210009;

	// Token: 0x0400CE7C RID: 52860
	private const int MANIPULATE_PARABOLA_SKILL = 240001;

	// Token: 0x0400CE7D RID: 52861
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

	// Token: 0x0400CE7E RID: 52862
	private RoleTagComponent TagComp;

	// Token: 0x0400CE7F RID: 52863
	private CharacterSkillComponent SkillComp;

	// Token: 0x0400CE80 RID: 52864
	private CreatureDataComponent CreatureDataComp;
}
