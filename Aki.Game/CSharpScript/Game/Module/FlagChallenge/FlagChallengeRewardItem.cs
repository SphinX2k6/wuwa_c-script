using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A48 RID: 19016
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengeRewardItem : GridProxyAbstract<FlagChallengeTaskData>
	{
		// Token: 0x0602F9DA RID: 195034 RVA: 0x00D48474 File Offset: 0x00D46674
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(7, new Action(this.OnReceiveClick))
			};
		}

		// Token: 0x0602F9DB RID: 195035 RVA: 0x00D48575 File Offset: 0x00D46775
		protected override void OnStart()
		{
			this.ItemListScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(5), () => new CommonItemSmallItemGrid(), null, false, null);
		}

		// Token: 0x0602F9DC RID: 195036 RVA: 0x00D485AB File Offset: 0x00D467AB
		protected override void OnBeforeDestroy()
		{
			this.ReceiveCallback = null;
		}

		// Token: 0x0602F9DD RID: 195037 RVA: 0x00D485B4 File Offset: 0x00D467B4
		public override void Refresh(FlagChallengeTaskData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			if (this.Data == null)
			{
				return;
			}
			base.GetButton(0).GetRootComponent().SetUIActive(false);
			base.GetButton(7).GetRootComponent().SetUIActive(data.CanReceiveReward());
			base.GetText(1).SetUIActive(!data.CanReceiveReward() && !data.IsTaskReceived());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.GetRewardName(), Array.Empty<object>());
			base.GetItem(6).SetUIActive(false);
			base.GetItem(3).SetUIActive(data.IsTaskReceived());
			base.GetSprite(2).SetUIActive(data.IsTaskReceived());
			base.GetText(8).SetText(data.GetProgressText(), true);
			this.ItemListScrollView.RefreshByData(data.GetRewardList(), null, false);
		}

		// Token: 0x0602F9DE RID: 195038 RVA: 0x00D4868D File Offset: 0x00D4688D
		public void SetReceiveCallback(Action<FlagChallengeTaskData> callback)
		{
			this.ReceiveCallback = callback;
		}

		// Token: 0x0602F9DF RID: 195039 RVA: 0x00D48696 File Offset: 0x00D46896
		private void OnReceiveClick()
		{
			Action<FlagChallengeTaskData> receiveCallback = this.ReceiveCallback;
			if (receiveCallback == null)
			{
				return;
			}
			receiveCallback(this.Data);
		}

		// Token: 0x04019451 RID: 103505
		[Nullable(2)]
		private FlagChallengeTaskData Data;

		// Token: 0x04019452 RID: 103506
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> ItemListScrollView;

		// Token: 0x04019453 RID: 103507
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<FlagChallengeTaskData> ReceiveCallback;
	}
}
