using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MingSu.View
{
	// Token: 0x020053DC RID: 21468
	public class DarkCoastDeliveryTipPanel : UiPanelBase
	{
		// Token: 0x06036DF7 RID: 224759 RVA: 0x00CFF120 File Offset: 0x00CFD320
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

		// Token: 0x06036DF8 RID: 224760 RVA: 0x00CFF224 File Offset: 0x00CFD424
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

		// Token: 0x06036DF9 RID: 224761 RVA: 0x00CFF344 File Offset: 0x00CFD544
		private void OnClickTrackBtn()
		{
			SkipTaskManager.RunByConfigId(this.Data.Config.JumpId, null);
		}

		// Token: 0x0401CF49 RID: 118601
		[Nullable(2)]
		private DarkCoastDeliveryLevelData Data;

		// Token: 0x0200B686 RID: 46726
		private static class EComponent
		{
			// Token: 0x040374AE RID: 226478
			public const int TipTexture = 0;

			// Token: 0x040374AF RID: 226479
			public const int TipTitle = 1;

			// Token: 0x040374B0 RID: 226480
			public const int TipDesc = 2;

			// Token: 0x040374B1 RID: 226481
			public const int RewardCount = 3;

			// Token: 0x040374B2 RID: 226482
			public const int TrackBtn = 4;

			// Token: 0x040374B3 RID: 226483
			public const int LockItem = 5;

			// Token: 0x040374B4 RID: 226484
			public const int LockText = 6;

			// Token: 0x040374B5 RID: 226485
			public const int AchieveTip = 7;

			// Token: 0x040374B6 RID: 226486
			public const int ReceivedTip = 8;
		}
	}
}
