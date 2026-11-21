using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002306 RID: 8966
[NullableContext(1)]
[Nullable(0)]
public class BulletDataInteract
{
	// Token: 0x170021C6 RID: 8646
	// (get) Token: 0x060161F1 RID: 90609 RVA: 0x0066DE9D File Offset: 0x0066C09D
	public FName SceneInteract
	{
		get
		{
			this.InitSceneInteract();
			return this.SceneInteractInternal;
		}
	}

	// Token: 0x170021C7 RID: 8647
	// (get) Token: 0x060161F2 RID: 90610 RVA: 0x0066DEAB File Offset: 0x0066C0AB
	public bool IsSceneInteract
	{
		get
		{
			this.InitSceneInteract();
			return this.IsSceneInteractInternal;
		}
	}

	// Token: 0x060161F3 RID: 90611 RVA: 0x0066DEB9 File Offset: 0x0066C0B9
	private void InitSceneInteract()
	{
		if (!this.SceneInteractInit)
		{
			this.SceneInteractInit = true;
			this.SceneInteractInternal = this.Data.场景物件交互.GetAssetPathName();
			this.IsSceneInteractInternal = (this.SceneInteractInternal != FName.NAME_None);
		}
	}

	// Token: 0x060161F4 RID: 90612 RVA: 0x0066DEF6 File Offset: 0x0066C0F6
	public BulletDataInteract(SReBulletDataInteraction data)
	{
		this.Data = data;
	}

	// Token: 0x0400B9E1 RID: 47585
	private readonly SReBulletDataInteraction Data;

	// Token: 0x0400B9E2 RID: 47586
	private FName SceneInteractInternal = FName.NAME_None;

	// Token: 0x0400B9E3 RID: 47587
	private bool IsSceneInteractInternal;

	// Token: 0x0400B9E4 RID: 47588
	private bool SceneInteractInit;
}
