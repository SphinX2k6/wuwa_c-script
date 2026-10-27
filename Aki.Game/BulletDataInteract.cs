using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002DAC RID: 11692
[NullableContext(1)]
[Nullable(0)]
public class BulletDataInteract
{
	// Token: 0x1700216A RID: 8554
	// (get) Token: 0x06018949 RID: 100681 RVA: 0x00647FBD File Offset: 0x006461BD
	public FName SceneInteract
	{
		get
		{
			this.InitSceneInteract();
			return this.SceneInteractInternal;
		}
	}

	// Token: 0x1700216B RID: 8555
	// (get) Token: 0x0601894A RID: 100682 RVA: 0x00647FCB File Offset: 0x006461CB
	public bool IsSceneInteract
	{
		get
		{
			this.InitSceneInteract();
			return this.IsSceneInteractInternal;
		}
	}

	// Token: 0x0601894B RID: 100683 RVA: 0x00647FD9 File Offset: 0x006461D9
	private void InitSceneInteract()
	{
		if (!this.SceneInteractInit)
		{
			this.SceneInteractInit = true;
			this.SceneInteractInternal = this.Data.场景物件交互.GetAssetPathName();
			this.IsSceneInteractInternal = (this.SceneInteractInternal != FName.NAME_None);
		}
	}

	// Token: 0x0601894C RID: 100684 RVA: 0x00648016 File Offset: 0x00646216
	public BulletDataInteract(SReBulletDataInteraction data)
	{
		this.Data = data;
	}

	// Token: 0x0400B667 RID: 46695
	private readonly SReBulletDataInteraction Data;

	// Token: 0x0400B668 RID: 46696
	private FName SceneInteractInternal = FName.NAME_None;

	// Token: 0x0400B669 RID: 46697
	private bool IsSceneInteractInternal;

	// Token: 0x0400B66A RID: 46698
	private bool SceneInteractInit;
}
