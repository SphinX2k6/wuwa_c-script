using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F82 RID: 8066
[NullableContext(2)]
[Nullable(0)]
public class ShowerMainView : UiTickViewBase
{
	// Token: 0x06013F4B RID: 81739 RVA: 0x005D1C97 File Offset: 0x005CFE97
	[NullableContext(1)]
	public ShowerMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013F4C RID: 81740 RVA: 0x005D1CA0 File Offset: 0x005CFEA0
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

	// Token: 0x06013F4D RID: 81741 RVA: 0x005D1D34 File Offset: 0x005CFF34
	protected override UniTask OnBeforeStartAsync()
	{
		ShowerMainView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShowerMainView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013F4E RID: 81742 RVA: 0x005D1D77 File Offset: 0x005CFF77
	protected override void OnBeforeShow()
	{
		this.IsFirstPerson = false;
	}

	// Token: 0x06013F4F RID: 81743 RVA: 0x005D1D80 File Offset: 0x005CFF80
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

	// Token: 0x06013F50 RID: 81744 RVA: 0x005D1DD2 File Offset: 0x005CFFD2
	protected override void OnTick(float delta)
	{
		this.ChangeVisionSkillItem.TickSkillCoolDown(delta);
	}

	// Token: 0x06013F51 RID: 81745 RVA: 0x005D1DE0 File Offset: 0x005CFFE0
	private UniTask OnInviteButtonClick()
	{
		ShowerMainView.<OnInviteButtonClick>d__11 <OnInviteButtonClick>d__;
		<OnInviteButtonClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnInviteButtonClick>d__.<>4__this = this;
		<OnInviteButtonClick>d__.<>1__state = -1;
		<OnInviteButtonClick>d__.<>t__builder.Start<ShowerMainView.<OnInviteButtonClick>d__11>(ref <OnInviteButtonClick>d__);
		return <OnInviteButtonClick>d__.<>t__builder.Task;
	}

	// Token: 0x06013F52 RID: 81746 RVA: 0x005D1E24 File Offset: 0x005D0024
	private UniTask OnChangeVisionButtonClick()
	{
		ShowerMainView.<OnChangeVisionButtonClick>d__12 <OnChangeVisionButtonClick>d__;
		<OnChangeVisionButtonClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnChangeVisionButtonClick>d__.<>4__this = this;
		<OnChangeVisionButtonClick>d__.<>1__state = -1;
		<OnChangeVisionButtonClick>d__.<>t__builder.Start<ShowerMainView.<OnChangeVisionButtonClick>d__12>(ref <OnChangeVisionButtonClick>d__);
		return <OnChangeVisionButtonClick>d__.<>t__builder.Task;
	}

	// Token: 0x06013F53 RID: 81747 RVA: 0x005D1E68 File Offset: 0x005D0068
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

	// Token: 0x06013F54 RID: 81748 RVA: 0x005D1EC0 File Offset: 0x005D00C0
	private UniTask OnCloseButtonClick()
	{
		ShowerMainView.<OnCloseButtonClick>d__14 <OnCloseButtonClick>d__;
		<OnCloseButtonClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCloseButtonClick>d__.<>4__this = this;
		<OnCloseButtonClick>d__.<>1__state = -1;
		<OnCloseButtonClick>d__.<>t__builder.Start<ShowerMainView.<OnCloseButtonClick>d__14>(ref <OnCloseButtonClick>d__);
		return <OnCloseButtonClick>d__.<>t__builder.Task;
	}

	// Token: 0x0400A9FC RID: 43516
	private ShowerSkillButton InviteSkillItem;

	// Token: 0x0400A9FD RID: 43517
	private ShowerSkillButton ChangeVisionSkillItem;

	// Token: 0x0400A9FE RID: 43518
	private ShowerSkillButton TakePictureSkillItem;

	// Token: 0x0400A9FF RID: 43519
	private bool IsFirstPerson;

	// Token: 0x0200828B RID: 33419
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402A266 RID: 172646
		public const int InviteSkillItem = 0;

		// Token: 0x0402A267 RID: 172647
		public const int ChangeVisionSkillItem = 1;

		// Token: 0x0402A268 RID: 172648
		public const int TakePictureSkillItem = 2;

		// Token: 0x0402A269 RID: 172649
		public const int CloseButton = 3;
	}
}
