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
	// Token: 0x020068FA RID: 26874
	[NullableContext(2)]
	[Nullable(0)]
	public class BossRushBuffSelectInGameView : UiViewBase
	{
		// Token: 0x06043061 RID: 274529 RVA: 0x01053622 File Offset: 0x01051822
		[NullableContext(1)]
		public BossRushBuffSelectInGameView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06043062 RID: 274530 RVA: 0x01053638 File Offset: 0x01051838
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

		// Token: 0x06043063 RID: 274531 RVA: 0x01053700 File Offset: 0x01051900
		protected override UniTask OnBeforeStartAsync()
		{
			BossRushBuffSelectInGameView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossRushBuffSelectInGameView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043064 RID: 274532 RVA: 0x01053744 File Offset: 0x01051944
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

		// Token: 0x06043065 RID: 274533 RVA: 0x010537C4 File Offset: 0x010519C4
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

		// Token: 0x06043066 RID: 274534 RVA: 0x010537FF File Offset: 0x010519FF
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

		// Token: 0x06043067 RID: 274535 RVA: 0x0105381F File Offset: 0x01051A1F
		private void RefreshConfirmButton()
		{
			base.GetButton(1).SetSelfInteractive(this.CurrentSelectBuff != null);
		}

		// Token: 0x04022E3C RID: 142908
		[Nullable(1)]
		private readonly List<BossRushBuffSelectInGameItem> BuffItemList = new List<BossRushBuffSelectInGameItem>();

		// Token: 0x04022E3D RID: 142909
		private BossRushBuffSelectInGameItem CurrentSelectBuff;

		// Token: 0x04022E3E RID: 142910
		private UUIInturnAnimController AnimationController;

		// Token: 0x0200CAAD RID: 51885
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403D418 RID: 250904
			public const int BuffRootItem = 0;

			// Token: 0x0403D419 RID: 250905
			public const int ConfirmButton = 1;

			// Token: 0x0403D41A RID: 250906
			public const int ToggleItem = 2;
		}
	}
}
