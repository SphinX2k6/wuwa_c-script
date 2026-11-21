using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x02005023 RID: 20515
	internal class ItemInMain : UiPanelBase
	{
		// Token: 0x06033579 RID: 210297 RVA: 0x00E64D5A File Offset: 0x00E62F5A
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUITexture))
			};
		}

		// Token: 0x0603357A RID: 210298 RVA: 0x00E64D94 File Offset: 0x00E62F94
		protected override UniTask OnBeforeStartAsync()
		{
			ItemInMain.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ItemInMain.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603357B RID: 210299 RVA: 0x00E64DD8 File Offset: 0x00E62FD8
		public UniTask RefreshByInvitedAsync(bool isInvited, bool isNew = false)
		{
			ItemInMain.<RefreshByInvitedAsync>d__5 <RefreshByInvitedAsync>d__;
			<RefreshByInvitedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshByInvitedAsync>d__.<>4__this = this;
			<RefreshByInvitedAsync>d__.isInvited = isInvited;
			<RefreshByInvitedAsync>d__.isNew = isNew;
			<RefreshByInvitedAsync>d__.<>1__state = -1;
			<RefreshByInvitedAsync>d__.<>t__builder.Start<ItemInMain.<RefreshByInvitedAsync>d__5>(ref <RefreshByInvitedAsync>d__);
			return <RefreshByInvitedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603357C RID: 210300 RVA: 0x00E64E2C File Offset: 0x00E6302C
		private UniTask PlayUnlockAnimAsync()
		{
			ItemInMain.<PlayUnlockAnimAsync>d__6 <PlayUnlockAnimAsync>d__;
			<PlayUnlockAnimAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockAnimAsync>d__.<>4__this = this;
			<PlayUnlockAnimAsync>d__.<>1__state = -1;
			<PlayUnlockAnimAsync>d__.<>t__builder.Start<ItemInMain.<PlayUnlockAnimAsync>d__6>(ref <PlayUnlockAnimAsync>d__);
			return <PlayUnlockAnimAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401B4B2 RID: 111794
		[Nullable(1)]
		private UiSequencePlayer Player;

		// Token: 0x0200ACF1 RID: 44273
		private static class EItemComponent
		{
			// Token: 0x040357B2 RID: 219058
			public const int LockTexture = 0;

			// Token: 0x040357B3 RID: 219059
			public const int SelfTexture = 1;
		}
	}
}
