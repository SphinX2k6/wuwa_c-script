using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001B1F RID: 6943
[NullableContext(2)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchUiTerrainComponent)]
public class FloroRanchUiTerrainComponent : FloroRanchUiItemBaseComponent
{
	// Token: 0x0600CE0D RID: 52749 RVA: 0x002EE7C4 File Offset: 0x002EC9C4
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public override UniTask<FloroRanchUiItemBase> PlayShowAnim()
	{
		FloroRanchUiTerrainComponent.<PlayShowAnim>d__1 <PlayShowAnim>d__;
		<PlayShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloroRanchUiItemBase>.Create();
		<PlayShowAnim>d__.<>4__this = this;
		<PlayShowAnim>d__.<>1__state = -1;
		<PlayShowAnim>d__.<>t__builder.Start<FloroRanchUiTerrainComponent.<PlayShowAnim>d__1>(ref <PlayShowAnim>d__);
		return <PlayShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE0E RID: 52750 RVA: 0x002EE808 File Offset: 0x002ECA08
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public override UniTask<FloroRanchUiItemBase> CreateUiItem()
	{
		FloroRanchUiTerrainComponent.<CreateUiItem>d__2 <CreateUiItem>d__;
		<CreateUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloroRanchUiItemBase>.Create();
		<CreateUiItem>d__.<>4__this = this;
		<CreateUiItem>d__.<>1__state = -1;
		<CreateUiItem>d__.<>t__builder.Start<FloroRanchUiTerrainComponent.<CreateUiItem>d__2>(ref <CreateUiItem>d__);
		return <CreateUiItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE0F RID: 52751 RVA: 0x002EE84C File Offset: 0x002ECA4C
	public override UniTask PlayHideAnim()
	{
		FloroRanchUiTerrainComponent.<PlayHideAnim>d__3 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>4__this = this;
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchUiTerrainComponent.<PlayHideAnim>d__3>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE10 RID: 52752 RVA: 0x002EE890 File Offset: 0x002ECA90
	public override UniTask PlayNormalAnim()
	{
		FloroRanchUiTerrainComponent.<PlayNormalAnim>d__4 <PlayNormalAnim>d__;
		<PlayNormalAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayNormalAnim>d__.<>4__this = this;
		<PlayNormalAnim>d__.<>1__state = -1;
		<PlayNormalAnim>d__.<>t__builder.Start<FloroRanchUiTerrainComponent.<PlayNormalAnim>d__4>(ref <PlayNormalAnim>d__);
		return <PlayNormalAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE11 RID: 52753 RVA: 0x002EE8D4 File Offset: 0x002ECAD4
	[PreserveBaseOverrides]
	public new virtual FloroRanchUiTerrainItem GetUiItem()
	{
		if (this.FloroRanchUiTerrainItem == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchUiTerrainComponent GetUiItem 实体不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", this.OwnerEntity.EntityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return this.FloroRanchUiTerrainItem;
	}

	// Token: 0x04005E6B RID: 24171
	private FloroRanchUiTerrainItem FloroRanchUiTerrainItem;
}
