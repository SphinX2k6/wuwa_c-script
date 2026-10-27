using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BAB RID: 7083
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUiRoleSkillItem : FloroRanchUiItemBase
{
	// Token: 0x0600D311 RID: 54033 RVA: 0x003086C0 File Offset: 0x003068C0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickSkillButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D312 RID: 54034 RVA: 0x0030880C File Offset: 0x00306A0C
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchUiRoleSkillItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchUiRoleSkillItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D313 RID: 54035 RVA: 0x00308850 File Offset: 0x00306A50
	public override UniTask PlayShowAnim()
	{
		FloroRanchUiRoleSkillItem.<PlayShowAnim>d__5 <PlayShowAnim>d__;
		<PlayShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayShowAnim>d__.<>4__this = this;
		<PlayShowAnim>d__.<>1__state = -1;
		<PlayShowAnim>d__.<>t__builder.Start<FloroRanchUiRoleSkillItem.<PlayShowAnim>d__5>(ref <PlayShowAnim>d__);
		return <PlayShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D314 RID: 54036 RVA: 0x00308894 File Offset: 0x00306A94
	public override UniTask PlaySkillAnim()
	{
		FloroRanchUiRoleSkillItem.<PlaySkillAnim>d__6 <PlaySkillAnim>d__;
		<PlaySkillAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySkillAnim>d__.<>4__this = this;
		<PlaySkillAnim>d__.<>1__state = -1;
		<PlaySkillAnim>d__.<>t__builder.Start<FloroRanchUiRoleSkillItem.<PlaySkillAnim>d__6>(ref <PlaySkillAnim>d__);
		return <PlaySkillAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D315 RID: 54037 RVA: 0x003088D8 File Offset: 0x00306AD8
	public override UniTask PlayHideAnim()
	{
		FloroRanchUiRoleSkillItem.<PlayHideAnim>d__7 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>4__this = this;
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchUiRoleSkillItem.<PlayHideAnim>d__7>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D316 RID: 54038 RVA: 0x0030891B File Offset: 0x00306B1B
	public override void Pause()
	{
		base.GetSpine(1).SetTimeScale(0f);
	}

	// Token: 0x0600D317 RID: 54039 RVA: 0x0030892E File Offset: 0x00306B2E
	public override void Resume()
	{
		base.GetSpine(1).SetTimeScale(1f);
	}

	// Token: 0x0600D318 RID: 54040 RVA: 0x00308944 File Offset: 0x00306B44
	public override UniTask RefreshItem()
	{
		FloroRanchUiRoleSkillItem.<RefreshItem>d__10 <RefreshItem>d__;
		<RefreshItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshItem>d__.<>4__this = this;
		<RefreshItem>d__.<>1__state = -1;
		<RefreshItem>d__.<>t__builder.Start<FloroRanchUiRoleSkillItem.<RefreshItem>d__10>(ref <RefreshItem>d__);
		return <RefreshItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600D319 RID: 54041 RVA: 0x00308987 File Offset: 0x00306B87
	public override FTransform? GetRewardPopTransform()
	{
		return new FTransform?(base.GetItem(5).GetOwner().GetTransform());
	}

	// Token: 0x0600D31A RID: 54042 RVA: 0x0030899F File Offset: 0x00306B9F
	public void BindClickSkillCallback(Action<FloroRanchEntityBase> callback)
	{
		this.OnClickSkillCallback = callback;
	}

	// Token: 0x0600D31B RID: 54043 RVA: 0x003089A8 File Offset: 0x00306BA8
	private void OnClickSkillButton()
	{
		Action<FloroRanchEntityBase> onClickSkillCallback = this.OnClickSkillCallback;
		if (onClickSkillCallback == null)
		{
			return;
		}
		onClickSkillCallback(this.Entity);
	}

	// Token: 0x040060B2 RID: 24754
	private FloroRanchEntityDebugInfoItem DebugInfoItem;

	// Token: 0x040060B3 RID: 24755
	private Action<FloroRanchEntityBase> OnClickSkillCallback = delegate(FloroRanchEntityBase entity)
	{
	};

	// Token: 0x0200815D RID: 33117
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402A382 RID: 172930
		public const int SkillChatText = 0;

		// Token: 0x0402A383 RID: 172931
		public const int RoleSpine = 1;

		// Token: 0x0402A384 RID: 172932
		public const int RemainUseTimeText = 2;

		// Token: 0x0402A385 RID: 172933
		public const int RoleSkillButton = 3;

		// Token: 0x0402A386 RID: 172934
		public const int SkillIconTexture = 4;

		// Token: 0x0402A387 RID: 172935
		public const int RoleRootItem = 5;

		// Token: 0x0402A388 RID: 172936
		public const int ActiveNiagara = 6;
	}
}
