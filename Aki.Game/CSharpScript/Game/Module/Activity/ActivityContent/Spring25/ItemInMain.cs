using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x020060A5 RID: 24741
	internal class ItemInMain : UiPanelBase
	{
		// Token: 0x0603E8B5 RID: 256181 RVA: 0x00F1DF96 File Offset: 0x00F1C196
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUITexture))
			};
		}

		// Token: 0x0603E8B6 RID: 256182 RVA: 0x00F1DFD0 File Offset: 0x00F1C1D0
		protected override UniTask OnBeforeStartAsync()
		{
			ItemInMain.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ItemInMain.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E8B7 RID: 256183 RVA: 0x00F1E014 File Offset: 0x00F1C214
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

		// Token: 0x0603E8B8 RID: 256184 RVA: 0x00F1E068 File Offset: 0x00F1C268
		private UniTask PlayUnlockAnimAsync()
		{
			ItemInMain.<PlayUnlockAnimAsync>d__6 <PlayUnlockAnimAsync>d__;
			<PlayUnlockAnimAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockAnimAsync>d__.<>4__this = this;
			<PlayUnlockAnimAsync>d__.<>1__state = -1;
			<PlayUnlockAnimAsync>d__.<>t__builder.Start<ItemInMain.<PlayUnlockAnimAsync>d__6>(ref <PlayUnlockAnimAsync>d__);
			return <PlayUnlockAnimAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04020B85 RID: 134021
		[Nullable(1)]
		private UiSequencePlayer Player;

		// Token: 0x0200C306 RID: 49926
		private static class EItemComponent
		{
			// Token: 0x0403AE4A RID: 241226
			public const int LockTexture = 0;

			// Token: 0x0403AE4B RID: 241227
			public const int SelfTexture = 1;
		}
	}
}
