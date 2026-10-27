using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A07 RID: 10759
[NullableContext(2)]
[Nullable(0)]
public class ShowerMainView : UiTickViewBase
{
	// Token: 0x06016544 RID: 91460 RVA: 0x005A6CBF File Offset: 0x005A4EBF
	[NullableContext(1)]
	public ShowerMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016545 RID: 91461 RVA: 0x005A6CC8 File Offset: 0x005A4EC8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(delegate()
			{
				this.OnCloseButtonClick().Forget();
			}))
		};
	}

	// Token: 0x06016546 RID: 91462 RVA: 0x005A6D5C File Offset: 0x005A4F5C
	protected override UniTask OnBeforeStartAsync()
	{
		ShowerMainView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShowerMainView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016547 RID: 91463 RVA: 0x005A6D9F File Offset: 0x005A4F9F
	protected override void OnBeforeShow()
	{
		this.IsFirstPerson = false;
	}

	// Token: 0x06016548 RID: 91464 RVA: 0x005A6DA8 File Offset: 0x005A4FA8
	protected override void OnStart()
	{
		this.InviteSkillItem.SetPressCallback(delegate
		{
			this.OnInviteButtonClick().Forget();
		});
		this.ChangeVisionSkillItem.SetPressCallback(delegate
		{
			this.OnChangeVisionButtonClick().Forget();
		});
		this.TakePictureSkillItem.SetPressCallback(new Action(this.OnTakePictureButtonClick));
	}

	// Token: 0x06016549 RID: 91465 RVA: 0x005A6DFA File Offset: 0x005A4FFA
	protected override void OnTick(float delta)
	{
		this.ChangeVisionSkillItem.TickSkillCoolDown(delta);
	}

	// Token: 0x0601654A RID: 91466 RVA: 0x005A6E08 File Offset: 0x005A5008
	private UniTask OnInviteButtonClick()
	{
		ShowerMainView.<OnInviteButtonClick>d__11 <OnInviteButtonClick>d__;
		<OnInviteButtonClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnInviteButtonClick>d__.<>4__this = this;
		<OnInviteButtonClick>d__.<>1__state = -1;
		<OnInviteButtonClick>d__.<>t__builder.Start<ShowerMainView.<OnInviteButtonClick>d__11>(ref <OnInviteButtonClick>d__);
		return <OnInviteButtonClick>d__.<>t__builder.Task;
	}

	// Token: 0x0601654B RID: 91467 RVA: 0x005A6E4C File Offset: 0x005A504C
	private UniTask OnChangeVisionButtonClick()
	{
		ShowerMainView.<OnChangeVisionButtonClick>d__12 <OnChangeVisionButtonClick>d__;
		<OnChangeVisionButtonClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnChangeVisionButtonClick>d__.<>4__this = this;
		<OnChangeVisionButtonClick>d__.<>1__state = -1;
		<OnChangeVisionButtonClick>d__.<>t__builder.Start<ShowerMainView.<OnChangeVisionButtonClick>d__12>(ref <OnChangeVisionButtonClick>d__);
		return <OnChangeVisionButtonClick>d__.<>t__builder.Task;
	}

	// Token: 0x0601654C RID: 91468 RVA: 0x005A6E90 File Offset: 0x005A5090
	private void OnTakePictureButtonClick()
	{
		PhotoSaveViewParam param = new PhotoSaveViewParam
		{
			ScreenShot = true,
			PrepareFullScreenShot = false,
			IsHiddenBattleView = true,
			HandBookPhotoData = null,
			GachaData = null,
			FragmentMemory = null,
			RoleSkinData = null,
			ShareId = 1
		};
		PhotographController.Instance.ScreenShot(param);
	}

	// Token: 0x0601654D RID: 91469 RVA: 0x005A6EE8 File Offset: 0x005A50E8
	private UniTask OnCloseButtonClick()
	{
		ShowerMainView.<OnCloseButtonClick>d__14 <OnCloseButtonClick>d__;
		<OnCloseButtonClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCloseButtonClick>d__.<>4__this = this;
		<OnCloseButtonClick>d__.<>1__state = -1;
		<OnCloseButtonClick>d__.<>t__builder.Start<ShowerMainView.<OnCloseButtonClick>d__14>(ref <OnCloseButtonClick>d__);
		return <OnCloseButtonClick>d__.<>t__builder.Task;
	}

	// Token: 0x0400A612 RID: 42514
	private ShowerSkillButton InviteSkillItem;

	// Token: 0x0400A613 RID: 42515
	private ShowerSkillButton ChangeVisionSkillItem;

	// Token: 0x0400A614 RID: 42516
	private ShowerSkillButton TakePictureSkillItem;

	// Token: 0x0400A615 RID: 42517
	private bool IsFirstPerson;

	// Token: 0x02009044 RID: 36932
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402EB6E RID: 191342
		public const int InviteSkillItem = 0;

		// Token: 0x0402EB6F RID: 191343
		public const int ChangeVisionSkillItem = 1;

		// Token: 0x0402EB70 RID: 191344
		public const int TakePictureSkillItem = 2;

		// Token: 0x0402EB71 RID: 191345
		public const int CloseButton = 3;
	}
}
