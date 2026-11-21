using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x0200046C RID: 1132
public class FurnitureSingleLevelItem : FurnitureSceneItemBase
{
	// Token: 0x06003AB6 RID: 15030 RVA: 0x0014EC9E File Offset: 0x0014CE9E
	public FurnitureSingleLevelItem(int furnitureConfigId) : base(furnitureConfigId)
	{
		this.SceneItemType = EFurnitureSceneItemType.SingleLevel;
	}

	// Token: 0x06003AB7 RID: 15031 RVA: 0x0014ECB0 File Offset: 0x0014CEB0
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

	// Token: 0x06003AB8 RID: 15032 RVA: 0x0014ECFB File Offset: 0x0014CEFB
	protected override void ShowImplement()
	{
		if (this.LevelContext == null)
		{
			return;
		}
		base.ShowLevelInstance(this.LevelContext);
	}

	// Token: 0x06003AB9 RID: 15033 RVA: 0x0014ED12 File Offset: 0x0014CF12
	protected override void HideImplement()
	{
		if (this.LevelContext == null)
		{
			return;
		}
		base.HideLevelInstance(this.LevelContext);
	}

	// Token: 0x06003ABA RID: 15034 RVA: 0x0014ED29 File Offset: 0x0014CF29
	protected override void UnloadImplement()
	{
		if (this.LevelContext != null)
		{
			base.UnloadLevelInstance(this.LevelContext);
			this.LevelContext = null;
		}
	}

	// Token: 0x04002F4D RID: 12109
	[Nullable(2)]
	private FurnitureLevelContext LevelContext;
}
