using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FDF RID: 4063
[NullableContext(2)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchUiToyComponent)]
public class FloroRanchUiToyComponent : FloroRanchUiItemBaseComponent
{
	// Token: 0x0600A224 RID: 41508 RVA: 0x002F9A10 File Offset: 0x002F7C10
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

	// Token: 0x0600A225 RID: 41509 RVA: 0x002F9A54 File Offset: 0x002F7C54
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

	// Token: 0x0600A226 RID: 41510 RVA: 0x002F9A98 File Offset: 0x002F7C98
	public override UniTask PlayHideAnim()
	{
		FloroRanchUiToyComponent.<PlayHideAnim>d__3 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>4__this = this;
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchUiToyComponent.<PlayHideAnim>d__3>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A227 RID: 41511 RVA: 0x002F9ADC File Offset: 0x002F7CDC
	public override UniTask PlayNormalAnim()
	{
		FloroRanchUiToyComponent.<PlayNormalAnim>d__4 <PlayNormalAnim>d__;
		<PlayNormalAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayNormalAnim>d__.<>4__this = this;
		<PlayNormalAnim>d__.<>1__state = -1;
		<PlayNormalAnim>d__.<>t__builder.Start<FloroRanchUiToyComponent.<PlayNormalAnim>d__4>(ref <PlayNormalAnim>d__);
		return <PlayNormalAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A228 RID: 41512 RVA: 0x002F9B20 File Offset: 0x002F7D20
	public UniTask PlayToyLevelUpAnim()
	{
		FloroRanchUiToyComponent.<PlayToyLevelUpAnim>d__5 <PlayToyLevelUpAnim>d__;
		<PlayToyLevelUpAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayToyLevelUpAnim>d__.<>4__this = this;
		<PlayToyLevelUpAnim>d__.<>1__state = -1;
		<PlayToyLevelUpAnim>d__.<>t__builder.Start<FloroRanchUiToyComponent.<PlayToyLevelUpAnim>d__5>(ref <PlayToyLevelUpAnim>d__);
		return <PlayToyLevelUpAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A229 RID: 41513 RVA: 0x002F9B64 File Offset: 0x002F7D64
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

	// Token: 0x04005F3B RID: 24379
	private FloroRanchUiToyItem _floroRanchUiToyItem;
}
