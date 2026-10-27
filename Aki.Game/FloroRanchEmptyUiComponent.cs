using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001B13 RID: 6931
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchEmptyUiComponent)]
public class FloroRanchEmptyUiComponent : FloroRanchUiItemBaseComponent
{
	// Token: 0x0600CDA4 RID: 52644 RVA: 0x002ED56C File Offset: 0x002EB76C
	[NullableContext(2)]
	public override FloroRanchUiItemBase GetUiItem()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FloroRanchGamePlay;
		ELogAuthor author = ELogAuthor.LRC;
		string message = "FloroRanchEmptyUiComponent GetUiItem 实体不存在";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", this.OwnerEntity.EntityId);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x0600CDA5 RID: 52645 RVA: 0x002ED5B4 File Offset: 0x002EB7B4
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public override UniTask<FloroRanchUiItemBase> PlayShowAnim()
	{
		FloroRanchEmptyUiComponent.<PlayShowAnim>d__1 <PlayShowAnim>d__;
		<PlayShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloroRanchUiItemBase>.Create();
		<PlayShowAnim>d__.<>1__state = -1;
		<PlayShowAnim>d__.<>t__builder.Start<FloroRanchEmptyUiComponent.<PlayShowAnim>d__1>(ref <PlayShowAnim>d__);
		return <PlayShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDA6 RID: 52646 RVA: 0x002ED5F0 File Offset: 0x002EB7F0
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public override UniTask<FloroRanchUiItemBase> CreateUiItem()
	{
		FloroRanchEmptyUiComponent.<CreateUiItem>d__2 <CreateUiItem>d__;
		<CreateUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloroRanchUiItemBase>.Create();
		<CreateUiItem>d__.<>1__state = -1;
		<CreateUiItem>d__.<>t__builder.Start<FloroRanchEmptyUiComponent.<CreateUiItem>d__2>(ref <CreateUiItem>d__);
		return <CreateUiItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDA7 RID: 52647 RVA: 0x002ED62C File Offset: 0x002EB82C
	public override UniTask PlayHideAnim()
	{
		FloroRanchEmptyUiComponent.<PlayHideAnim>d__3 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchEmptyUiComponent.<PlayHideAnim>d__3>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDA8 RID: 52648 RVA: 0x002ED668 File Offset: 0x002EB868
	public override UniTask PlayNormalAnim()
	{
		FloroRanchEmptyUiComponent.<PlayNormalAnim>d__4 <PlayNormalAnim>d__;
		<PlayNormalAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayNormalAnim>d__.<>1__state = -1;
		<PlayNormalAnim>d__.<>t__builder.Start<FloroRanchEmptyUiComponent.<PlayNormalAnim>d__4>(ref <PlayNormalAnim>d__);
		return <PlayNormalAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDA9 RID: 52649 RVA: 0x002ED6A4 File Offset: 0x002EB8A4
	public override UniTask ShowUiItem()
	{
		FloroRanchEmptyUiComponent.<ShowUiItem>d__5 <ShowUiItem>d__;
		<ShowUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowUiItem>d__.<>1__state = -1;
		<ShowUiItem>d__.<>t__builder.Start<FloroRanchEmptyUiComponent.<ShowUiItem>d__5>(ref <ShowUiItem>d__);
		return <ShowUiItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDAA RID: 52650 RVA: 0x002ED6E0 File Offset: 0x002EB8E0
	public override UniTask HideUiItem()
	{
		FloroRanchEmptyUiComponent.<HideUiItem>d__6 <HideUiItem>d__;
		<HideUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HideUiItem>d__.<>1__state = -1;
		<HideUiItem>d__.<>t__builder.Start<FloroRanchEmptyUiComponent.<HideUiItem>d__6>(ref <HideUiItem>d__);
		return <HideUiItem>d__.<>t__builder.Task;
	}
}
