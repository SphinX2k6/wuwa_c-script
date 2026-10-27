using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Coop
{
	// Token: 0x020068E6 RID: 26854
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CoopSpRewardItem : GridProxyAbstract<CoopSpRewardData>
	{
		// Token: 0x06042FDF RID: 274399 RVA: 0x01051678 File Offset: 0x0104F878
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickRewardBtn))
			};
		}

		// Token: 0x06042FE0 RID: 274400 RVA: 0x01051737 File Offset: 0x0104F937
		protected override void OnStart()
		{
			this.RewardItem = new CommonItemSmallItemGrid();
			this.RewardItem.Initialize(base.GetItem(2).GetOwner());
		}

		// Token: 0x06042FE1 RID: 274401 RVA: 0x0105175C File Offset: 0x0104F95C
		public override void Refresh(CoopSpRewardData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.GetConfig.Value.ShowText, Array.Empty<object>());
			ActivityModel instance = ActivityModel.Instance;
			int value = Math.Min((((instance != null) ? instance.GetActivityById(this.CurrentData.GetConfig.Value.ActivityId) : null) as CoopActivityData).GetCurTotalCoopLevel(), data.GetConfig.Value.RoleLevelSum);
			UUIText text = base.GetText(1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral("/<color=#b4aaca>");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.GetConfig.Value.RoleLevelSum);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			TItem titem = RewardConfig.Instance.GetDropPackagePreviewItemList(data.GetConfig.Value.Reward)[0];
			this.RewardItem.RefreshByConfigId(titem.ItemData.ItemId, new int?(titem.Count), null, data.State == ECoopSpRewardState.Done, false);
			this.RefreshRewardState(data.State);
		}

		// Token: 0x06042FE2 RID: 274402 RVA: 0x010518A8 File Offset: 0x0104FAA8
		private void RefreshRewardState(ECoopSpRewardState state)
		{
			bool uiactive = state == ECoopSpRewardState.Reward;
			bool uiactive2 = state == ECoopSpRewardState.Done;
			base.GetButton(3).RootUIComp.Get().SetUIActive(uiactive);
			base.GetSprite(4).SetUIActive(uiactive2);
			base.GetItem(5).SetUIActive(state == ECoopSpRewardState.Lock);
		}

		// Token: 0x06042FE3 RID: 274403 RVA: 0x010518F6 File Offset: 0x0104FAF6
		private void OnClickRewardBtn()
		{
			if (this.CurrentData != null)
			{
				this.OnRewardBtnClick();
			}
		}

		// Token: 0x04022DFD RID: 142845
		[Nullable(2)]
		private CoopSpRewardData CurrentData;

		// Token: 0x04022DFE RID: 142846
		public Action OnRewardBtnClick = delegate()
		{
		};

		// Token: 0x04022DFF RID: 142847
		[Nullable(2)]
		private CommonItemSmallItemGrid RewardItem;
	}
}
