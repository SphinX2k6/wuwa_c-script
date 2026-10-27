using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001B1E RID: 6942
[NullableContext(2)]
[Nullable(0)]
[FloroRanchEntityComponent(EFloroRanchEntityComponent.FloroRanchUiRoleSkillComponent)]
public class FloroRanchUiRoleSkillComponent : FloroRanchUiItemBaseComponent
{
	// Token: 0x0600CE04 RID: 52740 RVA: 0x002EE5E8 File Offset: 0x002EC7E8
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

	// Token: 0x0600CE05 RID: 52741 RVA: 0x002EE63C File Offset: 0x002EC83C
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

	// Token: 0x0600CE06 RID: 52742 RVA: 0x002EE680 File Offset: 0x002EC880
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

	// Token: 0x0600CE07 RID: 52743 RVA: 0x002EE6C4 File Offset: 0x002EC8C4
	public override UniTask PlayHideAnim()
	{
		FloroRanchUiRoleSkillComponent.<PlayHideAnim>d__4 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>4__this = this;
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchUiRoleSkillComponent.<PlayHideAnim>d__4>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE08 RID: 52744 RVA: 0x002EE708 File Offset: 0x002EC908
	public override UniTask PlayNormalAnim()
	{
		FloroRanchUiRoleSkillComponent.<PlayNormalAnim>d__5 <PlayNormalAnim>d__;
		<PlayNormalAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayNormalAnim>d__.<>4__this = this;
		<PlayNormalAnim>d__.<>1__state = -1;
		<PlayNormalAnim>d__.<>t__builder.Start<FloroRanchUiRoleSkillComponent.<PlayNormalAnim>d__5>(ref <PlayNormalAnim>d__);
		return <PlayNormalAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE09 RID: 52745 RVA: 0x002EE74C File Offset: 0x002EC94C
	public override UniTask PlaySkillAnim()
	{
		FloroRanchUiRoleSkillComponent.<PlaySkillAnim>d__6 <PlaySkillAnim>d__;
		<PlaySkillAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySkillAnim>d__.<>4__this = this;
		<PlaySkillAnim>d__.<>1__state = -1;
		<PlaySkillAnim>d__.<>t__builder.Start<FloroRanchUiRoleSkillComponent.<PlaySkillAnim>d__6>(ref <PlaySkillAnim>d__);
		return <PlaySkillAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600CE0A RID: 52746 RVA: 0x002EE78F File Offset: 0x002EC98F
	public override void Pause()
	{
		if (this.UiRoleSkillItem == null)
		{
			return;
		}
		this.UiRoleSkillItem.Pause();
	}

	// Token: 0x0600CE0B RID: 52747 RVA: 0x002EE7A5 File Offset: 0x002EC9A5
	public override void Resume()
	{
		if (this.UiRoleSkillItem == null)
		{
			return;
		}
		this.UiRoleSkillItem.Resume();
	}

	// Token: 0x04005E6A RID: 24170
	private FloroRanchUiRoleSkillItem UiRoleSkillItem;
}
