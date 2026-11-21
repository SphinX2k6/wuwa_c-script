using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000465 RID: 1125
public class FurnitureGroupEntityItem : FurnitureSceneItemBase
{
	// Token: 0x06003A74 RID: 14964 RVA: 0x0014E335 File Offset: 0x0014C535
	public FurnitureGroupEntityItem(int furnitureConfigId) : base(furnitureConfigId)
	{
		this.SceneItemType = EFurnitureSceneItemType.GroupEntity;
	}

	// Token: 0x06003A75 RID: 14965 RVA: 0x0014E350 File Offset: 0x0014C550
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

	// Token: 0x06003A76 RID: 14966 RVA: 0x0014E39C File Offset: 0x0014C59C
	protected override void ShowImplement()
	{
		for (int i = 0; i < this.LevelContextList.Count; i++)
		{
			FurnitureLevelContext context = this.LevelContextList[i];
			base.ShowLevelInstance(context);
		}
	}

	// Token: 0x06003A77 RID: 14967 RVA: 0x0014E3D4 File Offset: 0x0014C5D4
	protected override void HideImplement()
	{
		for (int i = 0; i < this.LevelContextList.Count; i++)
		{
			FurnitureLevelContext context = this.LevelContextList[i];
			base.HideLevelInstance(context);
		}
	}

	// Token: 0x06003A78 RID: 14968 RVA: 0x0014E40C File Offset: 0x0014C60C
	protected override void UnloadImplement()
	{
		for (int i = 0; i < this.LevelContextList.Count; i++)
		{
			FurnitureLevelContext context = this.LevelContextList[i];
			base.UnloadLevelInstance(context);
		}
		this.LevelContextList.Clear();
	}

	// Token: 0x04002F3D RID: 12093
	[Nullable(1)]
	private readonly List<FurnitureLevelContext> LevelContextList = new List<FurnitureLevelContext>();
}
