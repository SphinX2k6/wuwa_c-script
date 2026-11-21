using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FD2 RID: 4050
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchEmptyUiComponent)]
public class FloroRanchEmptyUiComponent : FloroRanchUiItemBaseComponent
{
	// Token: 0x0600A1B5 RID: 41397 RVA: 0x002F8658 File Offset: 0x002F6858
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

	// Token: 0x0600A1B6 RID: 41398 RVA: 0x002F86A0 File Offset: 0x002F68A0
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

	// Token: 0x0600A1B7 RID: 41399 RVA: 0x002F86DC File Offset: 0x002F68DC
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

	// Token: 0x0600A1B8 RID: 41400 RVA: 0x002F8718 File Offset: 0x002F6918
	public override UniTask PlayHideAnim()
	{
		FloroRanchEmptyUiComponent.<PlayHideAnim>d__3 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchEmptyUiComponent.<PlayHideAnim>d__3>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1B9 RID: 41401 RVA: 0x002F8754 File Offset: 0x002F6954
	public override UniTask PlayNormalAnim()
	{
		FloroRanchEmptyUiComponent.<PlayNormalAnim>d__4 <PlayNormalAnim>d__;
		<PlayNormalAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayNormalAnim>d__.<>1__state = -1;
		<PlayNormalAnim>d__.<>t__builder.Start<FloroRanchEmptyUiComponent.<PlayNormalAnim>d__4>(ref <PlayNormalAnim>d__);
		return <PlayNormalAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1BA RID: 41402 RVA: 0x002F8790 File Offset: 0x002F6990
	public override UniTask ShowUiItem()
	{
		FloroRanchEmptyUiComponent.<ShowUiItem>d__5 <ShowUiItem>d__;
		<ShowUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ShowUiItem>d__.<>1__state = -1;
		<ShowUiItem>d__.<>t__builder.Start<FloroRanchEmptyUiComponent.<ShowUiItem>d__5>(ref <ShowUiItem>d__);
		return <ShowUiItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A1BB RID: 41403 RVA: 0x002F87CC File Offset: 0x002F69CC
	public override UniTask HideUiItem()
	{
		FloroRanchEmptyUiComponent.<HideUiItem>d__6 <HideUiItem>d__;
		<HideUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HideUiItem>d__.<>1__state = -1;
		<HideUiItem>d__.<>t__builder.Start<FloroRanchEmptyUiComponent.<HideUiItem>d__6>(ref <HideUiItem>d__);
		return <HideUiItem>d__.<>t__builder.Task;
	}
}
