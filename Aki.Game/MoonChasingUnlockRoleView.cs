using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200081F RID: 2079
[NullableContext(1)]
[Nullable(0)]
public class MoonChasingUnlockRoleView : UiViewBase
{
	// Token: 0x06005E34 RID: 24116 RVA: 0x001E2C53 File Offset: 0x001E0E53
	public MoonChasingUnlockRoleView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005E35 RID: 24117 RVA: 0x001E2C5C File Offset: 0x001E0E5C
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

	// Token: 0x06005E36 RID: 24118 RVA: 0x001E2D08 File Offset: 0x001E0F08
	protected override UniTask OnBeforeStartAsync()
	{
		MoonChasingUnlockRoleView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MoonChasingUnlockRoleView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005E37 RID: 24119 RVA: 0x001E2D4C File Offset: 0x001E0F4C
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

	// Token: 0x06005E38 RID: 24120 RVA: 0x001E2D98 File Offset: 0x001E0F98
	private UniTask Refresh()
	{
		MoonChasingUnlockRoleView.<Refresh>d__6 <Refresh>d__;
		<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Refresh>d__.<>4__this = this;
		<Refresh>d__.<>1__state = -1;
		<Refresh>d__.<>t__builder.Start<MoonChasingUnlockRoleView.<Refresh>d__6>(ref <Refresh>d__);
		return <Refresh>d__.<>t__builder.Task;
	}

	// Token: 0x06005E39 RID: 24121 RVA: 0x001E2DDC File Offset: 0x001E0FDC
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		MoonChasingUnlockRoleView.<OnBeforeShowAsyncImplement>d__7 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<MoonChasingUnlockRoleView.<OnBeforeShowAsyncImplement>d__7>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06005E3A RID: 24122 RVA: 0x001E2E1F File Offset: 0x001E101F
	private CharacterItemWithLine InitCharacterItem()
	{
		return new CharacterItemWithLine();
	}

	// Token: 0x06005E3B RID: 24123 RVA: 0x001E2E28 File Offset: 0x001E1028
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

	// Token: 0x04003E55 RID: 15957
	protected CharacterListModule<CharacterItemWithLine> CharacterListModule;

	// Token: 0x04003E56 RID: 15958
	protected int? RoleId;

	// Token: 0x02006B69 RID: 27497
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04023501 RID: 144641
		public const int RoleSpine = 0;

		// Token: 0x04023502 RID: 144642
		public const int Name = 1;

		// Token: 0x04023503 RID: 144643
		public const int CharacterListItem = 2;

		// Token: 0x04023504 RID: 144644
		public const int CloseBtn = 3;

		// Token: 0x04023505 RID: 144645
		public const int Dialog = 4;
	}
}
