using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Structures;
using CSharpScript.Game.Input;

// Token: 0x02002627 RID: 9767
[NullableContext(2)]
[Nullable(0)]
public class VisionInputLayer : InputLayer
{
	// Token: 0x0601862B RID: 99883 RVA: 0x0075BFF3 File Offset: 0x0075A1F3
	[NullableContext(1)]
	public void Init(EntityHandle entityHandle)
	{
		WorldEntity entity = entityHandle.Entity;
		this.VisionComp = ((entity != null) ? entity.GetComponent<CharacterVisionComponent>() : null);
		WorldEntity entity2 = entityHandle.Entity;
		this.AbilityComp = ((entity2 != null) ? entity2.GetComponent<CharacterAbilityComponent>() : null);
	}

	// Token: 0x0601862C RID: 99884 RVA: 0x0075C025 File Offset: 0x0075A225
	public override void Clear()
	{
		this.VisionComp = null;
		this.AbilityComp = null;
	}

	// Token: 0x0601862D RID: 99885 RVA: 0x0075C035 File Offset: 0x0075A235
	public override EInputLayer GetLayerType()
	{
		return EInputLayer.Vision;
	}

	// Token: 0x0601862E RID: 99886 RVA: 0x0075C038 File Offset: 0x0075A238
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

	// Token: 0x0601862F RID: 99887 RVA: 0x0075C0E0 File Offset: 0x0075A2E0
	public override SInputCommand HandleRelease(EInputAction action, float time)
	{
		if (action == 9)
		{
			this.AbilityComp.SendGameplayEventToActor(GameplayTagUtils.GetGameplayTagById(GameplayTagDefine.EGameplayTagId["幻象.Common.输入.声骸技能抬起"]).Value, null);
		}
		return null;
	}

	// Token: 0x0400D277 RID: 53879
	private CharacterVisionComponent VisionComp;

	// Token: 0x0400D278 RID: 53880
	private CharacterAbilityComponent AbilityComp;
}
