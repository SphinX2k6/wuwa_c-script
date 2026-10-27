using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FB6 RID: 4022
public class FurnitureSingleEntityItem : FurnitureSceneItemBase
{
	// Token: 0x06006719 RID: 26393 RVA: 0x00146332 File Offset: 0x00144532
	public FurnitureSingleEntityItem(int furnitureConfigId) : base(furnitureConfigId)
	{
		this.SceneItemType = EFurnitureSceneItemType.SingleEntity;
	}

	// Token: 0x0600671A RID: 26394 RVA: 0x00146344 File Offset: 0x00144544
	protected override UniTask<bool> LoadAsyncImplement([Nullable(1)] Transform rootTransform)
	{
		FurnitureSingleEntityItem.<LoadAsyncImplement>d__2 <LoadAsyncImplement>d__;
		<LoadAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadAsyncImplement>d__.<>4__this = this;
		<LoadAsyncImplement>d__.rootTransform = rootTransform;
		<LoadAsyncImplement>d__.<>1__state = -1;
		<LoadAsyncImplement>d__.<>t__builder.Start<FurnitureSingleEntityItem.<LoadAsyncImplement>d__2>(ref <LoadAsyncImplement>d__);
		return <LoadAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x0600671B RID: 26395 RVA: 0x0014638F File Offset: 0x0014458F
	protected override void ShowImplement()
	{
		if (this.LevelContext == null)
		{
			return;
		}
		base.ShowLevelInstance(this.LevelContext);
	}

	// Token: 0x0600671C RID: 26396 RVA: 0x001463A6 File Offset: 0x001445A6
	protected override void HideImplement()
	{
		if (this.LevelContext == null)
		{
			return;
		}
		base.HideLevelInstance(this.LevelContext);
	}

	// Token: 0x0600671D RID: 26397 RVA: 0x001463BD File Offset: 0x001445BD
	protected override void UnloadImplement()
	{
		if (this.LevelContext != null)
		{
			base.UnloadLevelInstance(this.LevelContext);
			this.LevelContext = null;
		}
	}

	// Token: 0x04002EB3 RID: 11955
	[Nullable(2)]
	private FurnitureLevelContext LevelContext;
}
