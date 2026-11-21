using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005098 RID: 20632
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikePropCardItem : RoverlikeMultiUseGridProxyAbstract<IRoverlikePropItemData>
	{
		// Token: 0x06033A68 RID: 211560 RVA: 0x00E74FDA File Offset: 0x00E731DA
		public void BindOnItemSelect(Action<IRoverlikePropItemData> callback)
		{
			this.OnItemSelect = callback;
		}

		// Token: 0x06033A69 RID: 211561 RVA: 0x00E74FE4 File Offset: 0x00E731E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnTogItemStateChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033A6A RID: 211562 RVA: 0x00E75194 File Offset: 0x00E73394
		protected override void OnStart()
		{
			ITermExplanationRegistryParam param = new TermExplanationRegistryParam
			{
				UiText = base.GetText(3),
				ViewType = ETermExplanationViewType.Center,
				ReportType = ETermExplanationReportType.Roverlike
			};
			TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
			base.GetExtendToggle(0).SetSelfInteractive(false);
		}

		// Token: 0x06033A6B RID: 211563 RVA: 0x00E751DC File Offset: 0x00E733DC
		public override void Refresh(IRoverlikePropItemData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			RoverRogueItem? itemConfig = RoverlikeConfig.Instance.GetItemConfig(data.ConfigId);
			if (itemConfig == null)
			{
				return;
			}
			RoverRogueQuality? qualityConfig = RoverlikeConfig.Instance.GetQualityConfig(itemConfig.Value.Quality);
			if (qualityConfig == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), itemConfig.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), itemConfig.Value.Desc, itemConfig.Value.DescParams());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "RoverRogue_ItemDurationOutGame", new <>z__ReadOnlySingleElementList<object>(itemConfig.Value.RoomPassedRequired));
			base.SetTextureShowUntilLoaded(itemConfig.Value.Icon, base.GetTexture(2), null);
			base.SetTextureByPath(qualityConfig.Value.ItemCard, base.GetTexture(1), null, null);
			if (data.IsInGame)
			{
				this.RefreshInGameMode(data);
				return;
			}
			this.RefreshOutGameMode();
		}

		// Token: 0x06033A6C RID: 211564 RVA: 0x00E7530C File Offset: 0x00E7350C
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x06033A6D RID: 211565 RVA: 0x00E7531F File Offset: 0x00E7351F
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06033A6E RID: 211566 RVA: 0x00E75332 File Offset: 0x00E73532
		private void RefreshOutGameMode()
		{
			base.GetItem(7).SetUIActive(true);
			base.GetItem(8).SetUIActive(false);
			base.GetItem(9).SetUIActive(false);
		}

		// Token: 0x06033A6F RID: 211567 RVA: 0x00E7535C File Offset: 0x00E7355C
		private void RefreshInGameMode(IRoverlikePropItemData data)
		{
			base.GetItem(7).SetUIActive(false);
			RoverlikeInstanceData instanceData = RoverlikeModel.Instance.InstanceData;
			RoverlikeGainEntry roverlikeGainEntry = (instanceData != null) ? instanceData.GetGainByIncId(data.IncId.GetValueOrDefault()) : null;
			int num = (roverlikeGainEntry != null) ? roverlikeGainEntry.ItemRemainingRooms : 0;
			bool flag = num <= 0;
			base.GetItem(8).SetUIActive(!flag);
			base.GetItem(9).SetUIActive(flag);
			if (!flag)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "RoverRogue_ItemDurationInGame", new <>z__ReadOnlySingleElementList<object>(num));
			}
		}

		// Token: 0x06033A70 RID: 211568 RVA: 0x00E753F1 File Offset: 0x00E735F1
		private void OnTogItemStateChanged(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked && this.CurrentData != null)
			{
				Action<IRoverlikePropItemData> onItemSelect = this.OnItemSelect;
				if (onItemSelect == null)
				{
					return;
				}
				onItemSelect(this.CurrentData);
			}
		}

		// Token: 0x0401B652 RID: 112210
		[Nullable(2)]
		private IRoverlikePropItemData CurrentData;

		// Token: 0x0401B653 RID: 112211
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikePropItemData> OnItemSelect;

		// Token: 0x0200AD5D RID: 44381
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035925 RID: 219429
			public const int TogItem = 0;

			// Token: 0x04035926 RID: 219430
			public const int TexQualityBg = 1;

			// Token: 0x04035927 RID: 219431
			public const int TexItemIcon = 2;

			// Token: 0x04035928 RID: 219432
			public const int TxtInfo = 3;

			// Token: 0x04035929 RID: 219433
			public const int TxtName = 4;

			// Token: 0x0403592A RID: 219434
			public const int TxtTipsOutGame = 5;

			// Token: 0x0403592B RID: 219435
			public const int TxtTipsRemainRound = 6;

			// Token: 0x0403592C RID: 219436
			public const int PanelOutGame = 7;

			// Token: 0x0403592D RID: 219437
			public const int PanelTipsActive = 8;

			// Token: 0x0403592E RID: 219438
			public const int PanelTipsExpired = 9;
		}
	}
}
