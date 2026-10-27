using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x020030CF RID: 12495
[NullableContext(2)]
[Nullable(0)]
public class VisionInputLayer : InputLayer
{
	// Token: 0x0601AC16 RID: 109590 RVA: 0x007362D4 File Offset: 0x007344D4
	[NullableContext(1)]
	public void Init(EntityHandle entityHandle)
	{
		WorldEntity entity = entityHandle.Entity;
		this.VisionComp = ((entity != null) ? entity.GetComponent<CharacterVisionComponent>() : null);
		WorldEntity entity2 = entityHandle.Entity;
		this.AbilityComp = ((entity2 != null) ? entity2.GetComponent<CharacterAbilityComponent>() : null);
	}

	// Token: 0x0601AC17 RID: 109591 RVA: 0x00736306 File Offset: 0x00734506
	public override void Clear()
	{
		this.VisionComp = null;
		this.AbilityComp = null;
	}

	// Token: 0x0601AC18 RID: 109592 RVA: 0x00736316 File Offset: 0x00734516
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Vision;
	}

	// Token: 0x0601AC19 RID: 109593 RVA: 0x0073631C File Offset: 0x0073451C
	public override SInputCommand HandlePress(EInputAction action, float time)
	{
		byte b = action;
		if (b != 4)
		{
			if (b == 9)
			{
				this.AbilityComp.SendGameplayEventToActor(GameplayTagUtils.GetGameplayTagById(GameplayTagDefine.EGameplayTagId["幻象.Common.输入.声骸技能按下"]).Value, null);
				if (this.VisionComp.HandlePress(action, time))
				{
					return InputLayer.GetSwallowCommand();
				}
			}
		}
		else
		{
			this.AbilityComp.SendGameplayEventToActor(GameplayTagUtils.GetGameplayTagById(GameplayTagDefine.EGameplayTagId["幻象.Common.输入.声骸技能攻击按下"]).Value, null);
			if (this.VisionComp.HandlePress(action, time))
			{
				return InputLayer.GetSwallowCommand();
			}
		}
		return null;
	}

	// Token: 0x0601AC1A RID: 109594 RVA: 0x007363C4 File Offset: 0x007345C4
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		if (action == 9)
		{
			this.AbilityComp.SendGameplayEventToActor(GameplayTagUtils.GetGameplayTagById(GameplayTagDefine.EGameplayTagId["幻象.Common.输入.声骸技能抬起"]).Value, null);
		}
		return null;
	}

	// Token: 0x0400CE87 RID: 52871
	private CharacterVisionComponent VisionComp;

	// Token: 0x0400CE88 RID: 52872
	private CharacterAbilityComponent AbilityComp;
}
