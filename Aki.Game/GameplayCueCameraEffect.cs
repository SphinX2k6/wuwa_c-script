using System;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;

// Token: 0x0200250C RID: 9484
public class GameplayCueCameraEffect : GameplayCueBase
{
	// Token: 0x06017778 RID: 96120 RVA: 0x006EBD20 File Offset: 0x006E9F20
	protected override void OnCreate()
	{
		if (!string.IsNullOrEmpty(this.CueConfig.Path) && this.EntityHandle.Entity.GetComponent<CharacterActorComponent>().IsAutonomousProxy && CharacterUtils.CanCharacterMonsterOrSummonedDisplayEffect(this.EntityHandle))
		{
			if (this.HandleId != 0)
			{
				ScreenEffectModel.Instance.EndScreenEffect(this.HandleId);
			}
			this.HandleId = ScreenEffectModel.Instance.PlayScreenEffect(this.CueConfig.Path, null, null);
		}
	}

	// Token: 0x06017779 RID: 96121 RVA: 0x006EBD98 File Offset: 0x006E9F98
	protected override void OnDestroy()
	{
		if (this.HandleId != 0)
		{
			ScreenEffectModel.Instance.EndScreenEffect(this.HandleId);
			this.HandleId = 0;
		}
	}

	// Token: 0x0601777A RID: 96122 RVA: 0x006EBDB9 File Offset: 0x006E9FB9
	public override void OnEnable()
	{
		this.OnCreate();
	}

	// Token: 0x0601777B RID: 96123 RVA: 0x006EBDC1 File Offset: 0x006E9FC1
	public override void OnDisable()
	{
		this.OnDestroy();
	}

	// Token: 0x0400C792 RID: 51090
	private int HandleId;
}
