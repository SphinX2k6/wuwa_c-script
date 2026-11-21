using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MingSu.View
{
	// Token: 0x020043BF RID: 17343
	public class DarkCoastDeliveryTipPanel : UiPanelBase
	{
		// Token: 0x0602BD3E RID: 179518 RVA: 0x00C4E1F0 File Offset: 0x00C4C3F0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickTrackBtn))
			};
		}

		// Token: 0x0602BD3F RID: 179519 RVA: 0x00C4E2F4 File Offset: 0x00C4C4F4
		[NullableContext(1)]
		public void RefreshUi(DarkCoastDeliveryLevelData data)
		{
			this.Data = data;
			base.SetTextureShowUntilLoaded(data.Config.TipIcon, base.GetTexture(0), null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.Config.TipName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Config.TipDesc, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), data.Config.UnlockCondition, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "DarkShoreRewardNumber", new <>z__ReadOnlySingleElementList<object>(data.Config.RewardCount));
			MingSuDefine.EDarkCoastDeliveryLevelDataState darkCoastDeliveryGuardState = data.GetDarkCoastDeliveryGuardState();
			base.GetItem(5).SetUIActive(darkCoastDeliveryGuardState == MingSuDefine.EDarkCoastDeliveryLevelDataState.Lock);
			base.GetButton(4).RootUIComp.Get().SetUIActive(darkCoastDeliveryGuardState > MingSuDefine.EDarkCoastDeliveryLevelDataState.Lock);
			base.GetItem(7).SetUIActive(darkCoastDeliveryGuardState == MingSuDefine.EDarkCoastDeliveryLevelDataState.Passed);
			base.GetItem(8).SetUIActive(darkCoastDeliveryGuardState == MingSuDefine.EDarkCoastDeliveryLevelDataState.Received);
		}

		// Token: 0x0602BD40 RID: 179520 RVA: 0x00C4E414 File Offset: 0x00C4C614
		private void OnClickTrackBtn()
		{
			SkipTaskManager.RunByConfigId(this.Data.Config.JumpId, null);
		}

		// Token: 0x040179E1 RID: 96737
		[Nullable(2)]
		private DarkCoastDeliveryLevelData Data;

		// Token: 0x0200A0BE RID: 41150
		private static class EComponent
		{
			// Token: 0x04031F03 RID: 204547
			public const int TipTexture = 0;

			// Token: 0x04031F04 RID: 204548
			public const int TipTitle = 1;

			// Token: 0x04031F05 RID: 204549
			public const int TipDesc = 2;

			// Token: 0x04031F06 RID: 204550
			public const int RewardCount = 3;

			// Token: 0x04031F07 RID: 204551
			public const int TrackBtn = 4;

			// Token: 0x04031F08 RID: 204552
			public const int LockItem = 5;

			// Token: 0x04031F09 RID: 204553
			public const int LockText = 6;

			// Token: 0x04031F0A RID: 204554
			public const int AchieveTip = 7;

			// Token: 0x04031F0B RID: 204555
			public const int ReceivedTip = 8;
		}
	}
}
