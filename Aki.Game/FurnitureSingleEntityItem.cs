using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200046B RID: 1131
public class FurnitureSingleEntityItem : FurnitureSceneItemBase
{
	// Token: 0x06003AB1 RID: 15025 RVA: 0x0014EBF6 File Offset: 0x0014CDF6
	public FurnitureSingleEntityItem(int furnitureConfigId) : base(furnitureConfigId)
	{
		this.SceneItemType = EFurnitureSceneItemType.SingleEntity;
	}

	// Token: 0x06003AB2 RID: 15026 RVA: 0x0014EC08 File Offset: 0x0014CE08
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

	// Token: 0x06003AB3 RID: 15027 RVA: 0x0014EC53 File Offset: 0x0014CE53
	protected override void ShowImplement()
	{
		if (this.LevelContext == null)
		{
			return;
		}
		base.ShowLevelInstance(this.LevelContext);
	}

	// Token: 0x06003AB4 RID: 15028 RVA: 0x0014EC6A File Offset: 0x0014CE6A
	protected override void HideImplement()
	{
		if (this.LevelContext == null)
		{
			return;
		}
		base.HideLevelInstance(this.LevelContext);
	}

	// Token: 0x06003AB5 RID: 15029 RVA: 0x0014EC81 File Offset: 0x0014CE81
	protected override void UnloadImplement()
	{
		if (this.LevelContext != null)
		{
			base.UnloadLevelInstance(this.LevelContext);
			this.LevelContext = null;
		}
	}

	// Token: 0x04002F4C RID: 12108
	[Nullable(2)]
	private FurnitureLevelContext LevelContext;
}
