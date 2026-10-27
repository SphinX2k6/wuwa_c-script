using System;

// Token: 0x02002FD4 RID: 12244
public class GameplayCueSkinDamage : GameplayCueBase
{
	// Token: 0x06019F54 RID: 106324 RVA: 0x006CAD58 File Offset: 0x006C8F58
	protected override void OnCreate()
	{
		WorldEntity entity = this.EntityHandle.Entity;
		CharacterSkinDamageComponent characterSkinDamageComponent = (entity != null) ? entity.GetComponent<CharacterSkinDamageComponent>() : null;
		if (characterSkinDamageComponent != null)
		{
			characterSkinDamageComponent.CuePath = base.GetPath();
			bool flag = this.IsIgnoreEnableSetting();
			characterSkinDamageComponent.IsCueIgnoreEnableSetting = flag;
			characterSkinDamageComponent.ApplySkinDamage(characterSkinDamageComponent.CuePath, flag, "GameplayCueSkinDamage生成", default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x06019F55 RID: 106325 RVA: 0x006CADB8 File Offset: 0x006C8FB8
	protected override void OnDestroy()
	{
		WorldEntity entity = this.EntityHandle.Entity;
		CharacterSkinDamageComponent characterSkinDamageComponent = (entity != null) ? entity.GetComponent<CharacterSkinDamageComponent>() : null;
		if (characterSkinDamageComponent != null)
		{
			characterSkinDamageComponent.ResetCueSkinDamage();
		}
	}

	// Token: 0x06019F56 RID: 106326 RVA: 0x006CADE6 File Offset: 0x006C8FE6
	protected bool IsIgnoreEnableSetting()
	{
		return this.CueConfig.ParametersLength > 0 && this.CueConfig.Parameters(0) == "1";
	}
}
