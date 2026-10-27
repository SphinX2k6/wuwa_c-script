using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200611A RID: 24858
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikePropCardItem : RoverlikeMultiUseGridProxyAbstract<IRoverlikePropItemData>
	{
		// Token: 0x0603EDA6 RID: 257446 RVA: 0x00F2E1C6 File Offset: 0x00F2C3C6
		public void BindOnItemSelect(Action<IRoverlikePropItemData> callback)
		{
			this.OnItemSelect = callback;
		}

		// Token: 0x0603EDA7 RID: 257447 RVA: 0x00F2E1D0 File Offset: 0x00F2C3D0
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

		// Token: 0x0603EDA8 RID: 257448 RVA: 0x00F2E380 File Offset: 0x00F2C580
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

		// Token: 0x0603EDA9 RID: 257449 RVA: 0x00F2E3C8 File Offset: 0x00F2C5C8
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

		// Token: 0x0603EDAA RID: 257450 RVA: 0x00F2E4F8 File Offset: 0x00F2C6F8
		public override void OnSelected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}

		// Token: 0x0603EDAB RID: 257451 RVA: 0x00F2E50B File Offset: 0x00F2C70B
		public override void OnDeselected(bool fireEvent)
		{
			base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603EDAC RID: 257452 RVA: 0x00F2E51E File Offset: 0x00F2C71E
		private void RefreshOutGameMode()
		{
			base.GetItem(7).SetUIActive(true);
			base.GetItem(8).SetUIActive(false);
			base.GetItem(9).SetUIActive(false);
		}

		// Token: 0x0603EDAD RID: 257453 RVA: 0x00F2E548 File Offset: 0x00F2C748
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

		// Token: 0x0603EDAE RID: 257454 RVA: 0x00F2E5DD File Offset: 0x00F2C7DD
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

		// Token: 0x04020D25 RID: 134437
		[Nullable(2)]
		private IRoverlikePropItemData CurrentData;

		// Token: 0x04020D26 RID: 134438
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IRoverlikePropItemData> OnItemSelect;

		// Token: 0x0200C375 RID: 50037
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403AFC0 RID: 241600
			public const int TogItem = 0;

			// Token: 0x0403AFC1 RID: 241601
			public const int TexQualityBg = 1;

			// Token: 0x0403AFC2 RID: 241602
			public const int TexItemIcon = 2;

			// Token: 0x0403AFC3 RID: 241603
			public const int TxtInfo = 3;

			// Token: 0x0403AFC4 RID: 241604
			public const int TxtName = 4;

			// Token: 0x0403AFC5 RID: 241605
			public const int TxtTipsOutGame = 5;

			// Token: 0x0403AFC6 RID: 241606
			public const int TxtTipsRemainRound = 6;

			// Token: 0x0403AFC7 RID: 241607
			public const int PanelOutGame = 7;

			// Token: 0x0403AFC8 RID: 241608
			public const int PanelTipsActive = 8;

			// Token: 0x0403AFC9 RID: 241609
			public const int PanelTipsExpired = 9;
		}
	}
}
