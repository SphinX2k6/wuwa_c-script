using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x0200584A RID: 22602
	[NullableContext(2)]
	[Nullable(0)]
	public class BossRushBuffSelectInGameView : UiViewBase
	{
		// Token: 0x06037BB9 RID: 228281 RVA: 0x00F94C4A File Offset: 0x00F92E4A
		[NullableContext(1)]
		public BossRushBuffSelectInGameView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06037BBA RID: 228282 RVA: 0x00F94C60 File Offset: 0x00F92E60
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickConfirmButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06037BBB RID: 228283 RVA: 0x00F94D28 File Offset: 0x00F92F28
		protected override UniTask OnBeforeStartAsync()
		{
			BossRushBuffSelectInGameView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossRushBuffSelectInGameView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037BBC RID: 228284 RVA: 0x00F94D6C File Offset: 0x00F92F6C
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			List<int> choseBuffInGameHandleList = BossRushModel.Instance.ChoseBuffInGameHandleList;
			int count = BossRushModel.Instance.ChoseBuffInGameHandleList.Count;
			for (int i = 0; i < count; i++)
			{
				int buffId = choseBuffInGameHandleList[i];
				this.BuffItemList[i].RefreshItem(buffId);
			}
			UUIInturnAnimController animationController = this.AnimationController;
			if (animationController != null)
			{
				animationController.Play("", -1, false);
			}
			this.RefreshConfirmButton();
		}

		// Token: 0x06037BBD RID: 228285 RVA: 0x00F94DEC File Offset: 0x00F92FEC
		private void OnClickConfirmButton()
		{
			if (this.CurrentSelectBuff == null)
			{
				return;
			}
			int index = this.BuffItemList.IndexOf(this.CurrentSelectBuff);
			BossRushController.Instance.RequestBossRushChooseBuffInGame(index);
			this.CloseMeAsync();
		}

		// Token: 0x06037BBE RID: 228286 RVA: 0x00F94E27 File Offset: 0x00F93027
		private void OnClickBuffItem(BossRushBuffSelectInGameItem selectItem)
		{
			BossRushBuffSelectInGameItem currentSelectBuff = this.CurrentSelectBuff;
			if (currentSelectBuff != null)
			{
				currentSelectBuff.SetToggleUnCheck();
			}
			this.CurrentSelectBuff = selectItem;
			this.RefreshConfirmButton();
		}

		// Token: 0x06037BBF RID: 228287 RVA: 0x00F94E47 File Offset: 0x00F93047
		private void RefreshConfirmButton()
		{
			base.GetButton(1).SetSelfInteractive(this.CurrentSelectBuff != null);
		}

		// Token: 0x0401D698 RID: 120472
		[Nullable(1)]
		private readonly List<BossRushBuffSelectInGameItem> BuffItemList = new List<BossRushBuffSelectInGameItem>();

		// Token: 0x0401D699 RID: 120473
		private BossRushBuffSelectInGameItem CurrentSelectBuff;

		// Token: 0x0401D69A RID: 120474
		private UUIInturnAnimController AnimationController;

		// Token: 0x0200B475 RID: 46197
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04037CF2 RID: 228594
			public const int BuffRootItem = 0;

			// Token: 0x04037CF3 RID: 228595
			public const int ConfirmButton = 1;

			// Token: 0x04037CF4 RID: 228596
			public const int ToggleItem = 2;
		}
	}
}
