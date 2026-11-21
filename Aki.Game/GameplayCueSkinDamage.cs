using System;

// Token: 0x02002528 RID: 9512
public class GameplayCueSkinDamage : GameplayCueBase
{
	// Token: 0x06017866 RID: 96358 RVA: 0x006F164C File Offset: 0x006EF84C
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

	// Token: 0x06017867 RID: 96359 RVA: 0x006F16AC File Offset: 0x006EF8AC
	protected override void OnDestroy()
	{
		WorldEntity entity = this.EntityHandle.Entity;
		CharacterSkinDamageComponent characterSkinDamageComponent = (entity != null) ? entity.GetComponent<CharacterSkinDamageComponent>() : null;
		if (characterSkinDamageComponent != null)
		{
			characterSkinDamageComponent.ResetCueSkinDamage();
		}
	}

	// Token: 0x06017868 RID: 96360 RVA: 0x006F16DA File Offset: 0x006EF8DA
	protected bool IsIgnoreEnableSetting()
	{
		return this.CueConfig.ParametersLength > 0 && this.CueConfig.Parameters(0) == "1";
	}
}
