using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FB7 RID: 4023
public class FurnitureSingleLevelItem : FurnitureSceneItemBase
{
	// Token: 0x0600671E RID: 26398 RVA: 0x001463DA File Offset: 0x001445DA
	public FurnitureSingleLevelItem(int furnitureConfigId) : base(furnitureConfigId)
	{
		this.SceneItemType = EFurnitureSceneItemType.SingleLevel;
	}

	// Token: 0x0600671F RID: 26399 RVA: 0x001463EC File Offset: 0x001445EC
	protected override UniTask<bool> LoadAsyncImplement([Nullable(1)] Transform rootTransform)
	{
		FurnitureSingleLevelItem.<LoadAsyncImplement>d__2 <LoadAsyncImplement>d__;
		<LoadAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadAsyncImplement>d__.<>4__this = this;
		<LoadAsyncImplement>d__.rootTransform = rootTransform;
		<LoadAsyncImplement>d__.<>1__state = -1;
		<LoadAsyncImplement>d__.<>t__builder.Start<FurnitureSingleLevelItem.<LoadAsyncImplement>d__2>(ref <LoadAsyncImplement>d__);
		return <LoadAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06006720 RID: 26400 RVA: 0x00146437 File Offset: 0x00144637
	protected override void ShowImplement()
	{
		if (this.LevelContext == null)
		{
			return;
		}
		base.ShowLevelInstance(this.LevelContext);
	}

	// Token: 0x06006721 RID: 26401 RVA: 0x0014644E File Offset: 0x0014464E
	protected override void HideImplement()
	{
		if (this.LevelContext == null)
		{
			return;
		}
		base.HideLevelInstance(this.LevelContext);
	}

	// Token: 0x06006722 RID: 26402 RVA: 0x00146465 File Offset: 0x00144665
	protected override void UnloadImplement()
	{
		if (this.LevelContext != null)
		{
			base.UnloadLevelInstance(this.LevelContext);
			this.LevelContext = null;
		}
	}

	// Token: 0x04002EB4 RID: 11956
	[Nullable(2)]
	private FurnitureLevelContext LevelContext;
}
