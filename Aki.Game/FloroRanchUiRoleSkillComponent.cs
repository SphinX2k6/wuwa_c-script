using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000FDD RID: 4061
[NullableContext(2)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchUiRoleSkillComponent)]
public class FloroRanchUiRoleSkillComponent : FloroRanchUiItemBaseComponent
{
	// Token: 0x0600A215 RID: 41493 RVA: 0x002F96C8 File Offset: 0x002F78C8
	[PreserveBaseOverrides]
	public new virtual FloroRanchUiRoleSkillItem GetUiItem()
	{
		if (this.UiRoleSkillItem == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FloroRanchGamePlay;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "FloroRanchUiRoleSkillComponent GetUiItem 实体不存在";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", this.OwnerEntity.EntityId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return this.UiRoleSkillItem;
	}

	// Token: 0x0600A216 RID: 41494 RVA: 0x002F971C File Offset: 0x002F791C
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public override UniTask<FloroRanchUiItemBase> PlayShowAnim()
	{
		FloroRanchUiRoleSkillComponent.<PlayShowAnim>d__2 <PlayShowAnim>d__;
		<PlayShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloroRanchUiItemBase>.Create();
		<PlayShowAnim>d__.<>4__this = this;
		<PlayShowAnim>d__.<>1__state = -1;
		<PlayShowAnim>d__.<>t__builder.Start<FloroRanchUiRoleSkillComponent.<PlayShowAnim>d__2>(ref <PlayShowAnim>d__);
		return <PlayShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A217 RID: 41495 RVA: 0x002F9760 File Offset: 0x002F7960
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	public override UniTask<FloroRanchUiItemBase> CreateUiItem()
	{
		FloroRanchUiRoleSkillComponent.<CreateUiItem>d__3 <CreateUiItem>d__;
		<CreateUiItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<FloroRanchUiItemBase>.Create();
		<CreateUiItem>d__.<>4__this = this;
		<CreateUiItem>d__.<>1__state = -1;
		<CreateUiItem>d__.<>t__builder.Start<FloroRanchUiRoleSkillComponent.<CreateUiItem>d__3>(ref <CreateUiItem>d__);
		return <CreateUiItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A218 RID: 41496 RVA: 0x002F97A4 File Offset: 0x002F79A4
	public override UniTask PlayHideAnim()
	{
		FloroRanchUiRoleSkillComponent.<PlayHideAnim>d__4 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>4__this = this;
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchUiRoleSkillComponent.<PlayHideAnim>d__4>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A219 RID: 41497 RVA: 0x002F97E8 File Offset: 0x002F79E8
	public override UniTask PlayNormalAnim()
	{
		FloroRanchUiRoleSkillComponent.<PlayNormalAnim>d__5 <PlayNormalAnim>d__;
		<PlayNormalAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayNormalAnim>d__.<>4__this = this;
		<PlayNormalAnim>d__.<>1__state = -1;
		<PlayNormalAnim>d__.<>t__builder.Start<FloroRanchUiRoleSkillComponent.<PlayNormalAnim>d__5>(ref <PlayNormalAnim>d__);
		return <PlayNormalAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A21A RID: 41498 RVA: 0x002F982C File Offset: 0x002F7A2C
	public override UniTask PlaySkillAnim()
	{
		FloroRanchUiRoleSkillComponent.<PlaySkillAnim>d__6 <PlaySkillAnim>d__;
		<PlaySkillAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySkillAnim>d__.<>4__this = this;
		<PlaySkillAnim>d__.<>1__state = -1;
		<PlaySkillAnim>d__.<>t__builder.Start<FloroRanchUiRoleSkillComponent.<PlaySkillAnim>d__6>(ref <PlaySkillAnim>d__);
		return <PlaySkillAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A21B RID: 41499 RVA: 0x002F986F File Offset: 0x002F7A6F
	public override void Pause()
	{
		if (this.UiRoleSkillItem == null)
		{
			return;
		}
		this.UiRoleSkillItem.Pause();
	}

	// Token: 0x0600A21C RID: 41500 RVA: 0x002F9885 File Offset: 0x002F7A85
	public override void Resume()
	{
		if (this.UiRoleSkillItem == null)
		{
			return;
		}
		this.UiRoleSkillItem.Resume();
	}

	// Token: 0x04005F39 RID: 24377
	private FloroRanchUiRoleSkillItem UiRoleSkillItem;
}
