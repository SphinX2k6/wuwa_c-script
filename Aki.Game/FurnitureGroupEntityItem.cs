using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FB0 RID: 4016
public class FurnitureGroupEntityItem : FurnitureSceneItemBase
{
	// Token: 0x060066DC RID: 26332 RVA: 0x00145A71 File Offset: 0x00143C71
	public FurnitureGroupEntityItem(int furnitureConfigId) : base(furnitureConfigId)
	{
		this.SceneItemType = EFurnitureSceneItemType.GroupEntity;
	}

	// Token: 0x060066DD RID: 26333 RVA: 0x00145A8C File Offset: 0x00143C8C
	protected override UniTask<bool> LoadAsyncImplement([Nullable(1)] Transform rootTransform)
	{
		FurnitureGroupEntityItem.<LoadAsyncImplement>d__2 <LoadAsyncImplement>d__;
		<LoadAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<LoadAsyncImplement>d__.<>4__this = this;
		<LoadAsyncImplement>d__.rootTransform = rootTransform;
		<LoadAsyncImplement>d__.<>1__state = -1;
		<LoadAsyncImplement>d__.<>t__builder.Start<FurnitureGroupEntityItem.<LoadAsyncImplement>d__2>(ref <LoadAsyncImplement>d__);
		return <LoadAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x060066DE RID: 26334 RVA: 0x00145AD8 File Offset: 0x00143CD8
	protected override void ShowImplement()
	{
		for (int i = 0; i < this.LevelContextList.Count; i++)
		{
			FurnitureLevelContext context = this.LevelContextList[i];
			base.ShowLevelInstance(context);
		}
	}

	// Token: 0x060066DF RID: 26335 RVA: 0x00145B10 File Offset: 0x00143D10
	protected override void HideImplement()
	{
		for (int i = 0; i < this.LevelContextList.Count; i++)
		{
			FurnitureLevelContext context = this.LevelContextList[i];
			base.HideLevelInstance(context);
		}
	}

	// Token: 0x060066E0 RID: 26336 RVA: 0x00145B48 File Offset: 0x00143D48
	protected override void UnloadImplement()
	{
		for (int i = 0; i < this.LevelContextList.Count; i++)
		{
			FurnitureLevelContext context = this.LevelContextList[i];
			base.UnloadLevelInstance(context);
		}
		this.LevelContextList.Clear();
	}

	// Token: 0x04002EA4 RID: 11940
	[Nullable(1)]
	private readonly List<FurnitureLevelContext> LevelContextList = new List<FurnitureLevelContext>();
}
