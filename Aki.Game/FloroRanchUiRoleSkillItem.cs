using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200106A RID: 4202
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchUiRoleSkillItem : FloroRanchUiItemBase
{
	// Token: 0x0600A722 RID: 42786 RVA: 0x003137A0 File Offset: 0x003119A0
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

	// Token: 0x0600A723 RID: 42787 RVA: 0x003138EC File Offset: 0x00311AEC
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchUiRoleSkillItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchUiRoleSkillItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A724 RID: 42788 RVA: 0x00313930 File Offset: 0x00311B30
	public override UniTask PlayShowAnim()
	{
		FloroRanchUiRoleSkillItem.<PlayShowAnim>d__5 <PlayShowAnim>d__;
		<PlayShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayShowAnim>d__.<>4__this = this;
		<PlayShowAnim>d__.<>1__state = -1;
		<PlayShowAnim>d__.<>t__builder.Start<FloroRanchUiRoleSkillItem.<PlayShowAnim>d__5>(ref <PlayShowAnim>d__);
		return <PlayShowAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A725 RID: 42789 RVA: 0x00313974 File Offset: 0x00311B74
	public override UniTask PlaySkillAnim()
	{
		FloroRanchUiRoleSkillItem.<PlaySkillAnim>d__6 <PlaySkillAnim>d__;
		<PlaySkillAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySkillAnim>d__.<>4__this = this;
		<PlaySkillAnim>d__.<>1__state = -1;
		<PlaySkillAnim>d__.<>t__builder.Start<FloroRanchUiRoleSkillItem.<PlaySkillAnim>d__6>(ref <PlaySkillAnim>d__);
		return <PlaySkillAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A726 RID: 42790 RVA: 0x003139B8 File Offset: 0x00311BB8
	public override UniTask PlayHideAnim()
	{
		FloroRanchUiRoleSkillItem.<PlayHideAnim>d__7 <PlayHideAnim>d__;
		<PlayHideAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideAnim>d__.<>4__this = this;
		<PlayHideAnim>d__.<>1__state = -1;
		<PlayHideAnim>d__.<>t__builder.Start<FloroRanchUiRoleSkillItem.<PlayHideAnim>d__7>(ref <PlayHideAnim>d__);
		return <PlayHideAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A727 RID: 42791 RVA: 0x003139FB File Offset: 0x00311BFB
	public override void Pause()
	{
		base.GetSpine(1).SetTimeScale(0f);
	}

	// Token: 0x0600A728 RID: 42792 RVA: 0x00313A0E File Offset: 0x00311C0E
	public override void Resume()
	{
		base.GetSpine(1).SetTimeScale(1f);
	}

	// Token: 0x0600A729 RID: 42793 RVA: 0x00313A24 File Offset: 0x00311C24
	public override UniTask RefreshItem()
	{
		FloroRanchUiRoleSkillItem.<RefreshItem>d__10 <RefreshItem>d__;
		<RefreshItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshItem>d__.<>4__this = this;
		<RefreshItem>d__.<>1__state = -1;
		<RefreshItem>d__.<>t__builder.Start<FloroRanchUiRoleSkillItem.<RefreshItem>d__10>(ref <RefreshItem>d__);
		return <RefreshItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600A72A RID: 42794 RVA: 0x00313A67 File Offset: 0x00311C67
	public override FTransform? GetRewardPopTransform()
	{
		return new FTransform?(base.GetItem(5).GetOwner().GetTransform());
	}

	// Token: 0x0600A72B RID: 42795 RVA: 0x00313A7F File Offset: 0x00311C7F
	public void BindClickSkillCallback(Action<FloroRanchEntityBase> callback)
	{
		this.OnClickSkillCallback = callback;
	}

	// Token: 0x0600A72C RID: 42796 RVA: 0x00313A88 File Offset: 0x00311C88
	private void OnClickSkillButton()
	{
		Action<FloroRanchEntityBase> onClickSkillCallback = this.OnClickSkillCallback;
		if (onClickSkillCallback == null)
		{
			return;
		}
		onClickSkillCallback(this.Entity);
	}

	// Token: 0x04006181 RID: 24961
	private FloroRanchEntityDebugInfoItem DebugInfoItem;

	// Token: 0x04006182 RID: 24962
	private Action<FloroRanchEntityBase> OnClickSkillCallback = delegate(FloroRanchEntityBase entity)
	{
	};

	// Token: 0x020072EB RID: 29419
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x040256B6 RID: 153270
		public const int SkillChatText = 0;

		// Token: 0x040256B7 RID: 153271
		public const int RoleSpine = 1;

		// Token: 0x040256B8 RID: 153272
		public const int RemainUseTimeText = 2;

		// Token: 0x040256B9 RID: 153273
		public const int RoleSkillButton = 3;

		// Token: 0x040256BA RID: 153274
		public const int SkillIconTexture = 4;

		// Token: 0x040256BB RID: 153275
		public const int RoleRootItem = 5;

		// Token: 0x040256BC RID: 153276
		public const int ActiveNiagara = 6;
	}
}
