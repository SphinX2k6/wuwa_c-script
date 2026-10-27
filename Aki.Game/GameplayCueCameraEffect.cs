using System;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;

// Token: 0x02002FB8 RID: 12216
public class GameplayCueCameraEffect : GameplayCueBase
{
	// Token: 0x06019E66 RID: 106086 RVA: 0x006C545C File Offset: 0x006C365C
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

	// Token: 0x06019E67 RID: 106087 RVA: 0x006C54D4 File Offset: 0x006C36D4
	protected override void OnDestroy()
	{
		if (this.HandleId != 0)
		{
			ScreenEffectModel.Instance.EndScreenEffect(this.HandleId);
			this.HandleId = 0;
		}
	}

	// Token: 0x06019E68 RID: 106088 RVA: 0x006C54F5 File Offset: 0x006C36F5
	public override void OnEnable()
	{
		this.OnCreate();
	}

	// Token: 0x06019E69 RID: 106089 RVA: 0x006C54FD File Offset: 0x006C36FD
	public override void OnDisable()
	{
		this.OnDestroy();
	}

	// Token: 0x0400C3E9 RID: 50153
	private int HandleId;
}
