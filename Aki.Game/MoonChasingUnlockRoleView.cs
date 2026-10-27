using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200136B RID: 4971
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingUnlockRoleView : UiViewBase
{
	// Token: 0x06008A99 RID: 35481 RVA: 0x001D9DF7 File Offset: 0x001D7FF7
	public MoonChasingUnlockRoleView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008A9A RID: 35482 RVA: 0x001D9E00 File Offset: 0x001D8000
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(USpineSkeletonAnimationComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnClose))
		};
	}

	// Token: 0x06008A9B RID: 35483 RVA: 0x001D9EAC File Offset: 0x001D80AC
	protected override UniTask OnBeforeStartAsync()
	{
		MoonChasingUnlockRoleView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MoonChasingUnlockRoleView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008A9C RID: 35484 RVA: 0x001D9EF0 File Offset: 0x001D80F0
	private UniTask RefreshSpine(EntrustRole config)
	{
		MoonChasingUnlockRoleView.<RefreshSpine>d__5 <RefreshSpine>d__;
		<RefreshSpine>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshSpine>d__.<>4__this = this;
		<RefreshSpine>d__.config = config;
		<RefreshSpine>d__.<>1__state = -1;
		<RefreshSpine>d__.<>t__builder.Start<MoonChasingUnlockRoleView.<RefreshSpine>d__5>(ref <RefreshSpine>d__);
		return <RefreshSpine>d__.<>t__builder.Task;
	}

	// Token: 0x06008A9D RID: 35485 RVA: 0x001D9F3C File Offset: 0x001D813C
	private UniTask Refresh()
	{
		MoonChasingUnlockRoleView.<Refresh>d__6 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<MoonChasingUnlockRoleView.<Refresh>d__6>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x06008A9E RID: 35486 RVA: 0x001D9F80 File Offset: 0x001D8180
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		MoonChasingUnlockRoleView.<OnBeforeShowAsyncImplement>d__7 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<MoonChasingUnlockRoleView.<OnBeforeShowAsyncImplement>d__7>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06008A9F RID: 35487 RVA: 0x001D9FC3 File Offset: 0x001D81C3
	private CharacterItemWithLine InitCharacterItem()
	{
		return new CharacterItemWithLine();
	}

	// Token: 0x06008AA0 RID: 35488 RVA: 0x001D9FCC File Offset: 0x001D81CC
	private void OnClose()
	{
		this.RoleId = MoonChasingBusinessModel.Instance.PopUnlockRoleId();
		if (this.RoleId != null)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequencePurely("Switch", false, false);
			}
			this.Refresh().Forget();
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x04003DBD RID: 15805
	protected CharacterListModule<CharacterItemWithLine> CharacterListModule;

	// Token: 0x04003DBE RID: 15806
	protected int? RoleId;

	// Token: 0x020079DF RID: 31199
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040281D4 RID: 164308
		public const int RoleSpine = 0;

		// Token: 0x040281D5 RID: 164309
		public const int Name = 1;

		// Token: 0x040281D6 RID: 164310
		public const int CharacterListItem = 2;

		// Token: 0x040281D7 RID: 164311
		public const int CloseBtn = 3;

		// Token: 0x040281D8 RID: 164312
		public const int Dialog = 4;
	}
}
