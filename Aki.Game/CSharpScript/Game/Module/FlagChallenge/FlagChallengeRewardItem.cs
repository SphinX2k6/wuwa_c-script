using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A6C RID: 23148
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FlagChallengeRewardItem : GridProxyAbstract<FlagChallengeTaskData>
	{
		// Token: 0x0603AA91 RID: 240273 RVA: 0x00DF7EF0 File Offset: 0x00DF60F0
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

		// Token: 0x0603AA92 RID: 240274 RVA: 0x00DF7FF1 File Offset: 0x00DF61F1
		protected override void OnStart()
		{
			this.ItemListScrollView = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(5), () => new CommonItemSmallItemGrid(), null, false, null);
		}

		// Token: 0x0603AA93 RID: 240275 RVA: 0x00DF8027 File Offset: 0x00DF6227
		protected override void OnBeforeDestroy()
		{
			this.ReceiveCallback = null;
		}

		// Token: 0x0603AA94 RID: 240276 RVA: 0x00DF8030 File Offset: 0x00DF6230
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

		// Token: 0x0603AA95 RID: 240277 RVA: 0x00DF8109 File Offset: 0x00DF6309
		public void SetReceiveCallback(Action<FlagChallengeTaskData> callback)
		{
			this.ReceiveCallback = callback;
		}

		// Token: 0x0603AA96 RID: 240278 RVA: 0x00DF8112 File Offset: 0x00DF6312
		private void OnReceiveClick()
		{
			Action<FlagChallengeTaskData> receiveCallback = this.ReceiveCallback;
			if (receiveCallback == null)
			{
				return;
			}
			receiveCallback(this.Data);
		}

		// Token: 0x0401E9AA RID: 125354
		[Nullable(2)]
		private FlagChallengeTaskData Data;

		// Token: 0x0401E9AB RID: 125355
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> ItemListScrollView;

		// Token: 0x0401E9AC RID: 125356
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<FlagChallengeTaskData> ReceiveCallback;
	}
}
