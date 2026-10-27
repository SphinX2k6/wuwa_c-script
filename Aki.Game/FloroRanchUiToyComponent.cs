using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001B20 RID: 6944
[NullableContext(2)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchUiToyComponent)]
public class FloroRanchUiToyComponent : FloroRanchUiItemBaseComponent
{
	// Token: 0x0600CE13 RID: 52755 RVA: 0x002EE930 File Offset: 0x002ECB30
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public override UniTask<FloroRanchUiItemBase> PlayShowAnim()
	{
		FloroRanchUiToyComponent.<PlayShowAnim>d__1 <PlayShowAnim>d__;
		<PlayShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloroRanchUiItemBase>.Create();
		<PlayShowAnim>d__.<>4__this = this;
		<PlayShowAnim>d__.<>1__state = -1;
		<PlayShowAnim>d__.<>t__builder.Start<FloroRanchUiToyComponent.<PlayShowAnim>d__1>(ref <PlayShowAnim>d__);
		return <PlayShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE14 RID: 52756 RVA: 0x002EE974 File Offset: 0x002ECB74
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public override UniTask<FloroRanchUiItemBase> CreateUiItem()
	{
		FloroRanchUiToyComponent.<CreateUiItem>d__2 <CreateUiItem>d__;
		<CreateUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloroRanchUiItemBase>.Create();
		<CreateUiItem>d__.<>4__this = this;
		<CreateUiItem>d__.<>1__state = -1;
		<CreateUiItem>d__.<>t__builder.Start<FloroRanchUiToyComponent.<CreateUiItem>d__2>(ref <CreateUiItem>d__);
		return <CreateUiItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE15 RID: 52757 RVA: 0x002EE9B8 File Offset: 0x002ECBB8
	public override UniTask PlayHideAnim()
	{
		FloroRanchUiToyComponent.<PlayHideAnim>d__3 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>4__this = this;
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchUiToyComponent.<PlayHideAnim>d__3>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE16 RID: 52758 RVA: 0x002EE9FC File Offset: 0x002ECBFC
	public override UniTask PlayNormalAnim()
	{
		FloroRanchUiToyComponent.<PlayNormalAnim>d__4 <PlayNormalAnim>d__;
		<PlayNormalAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayNormalAnim>d__.<>4__this = this;
		<PlayNormalAnim>d__.<>1__state = -1;
		<PlayNormalAnim>d__.<>t__builder.Start<FloroRanchUiToyComponent.<PlayNormalAnim>d__4>(ref <PlayNormalAnim>d__);
		return <PlayNormalAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE17 RID: 52759 RVA: 0x002EEA40 File Offset: 0x002ECC40
	public UniTask PlayToyLevelUpAnim()
	{
		FloroRanchUiToyComponent.<PlayToyLevelUpAnim>d__5 <PlayToyLevelUpAnim>d__;
		<PlayToyLevelUpAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayToyLevelUpAnim>d__.<>4__this = this;
		<PlayToyLevelUpAnim>d__.<>1__state = -1;
		<PlayToyLevelUpAnim>d__.<>t__builder.Start<FloroRanchUiToyComponent.<PlayToyLevelUpAnim>d__5>(ref <PlayToyLevelUpAnim>d__);
		return <PlayToyLevelUpAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE18 RID: 52760 RVA: 0x002EEA84 File Offset: 0x002ECC84
	[PreserveBaseOverrides]
	public new virtual FloroRanchUiToyItem GetUiItem()
	{
		if (this._floroRanchUiToyItem == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchUiToyComponent GetUiItem 实体不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", this.OwnerEntity.EntityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return this._floroRanchUiToyItem;
	}

	// Token: 0x04005E6C RID: 24172
	private FloroRanchUiToyItem _floroRanchUiToyItem;
}
