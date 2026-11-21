using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D7C RID: 15740
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeAchieveSpecialPanel : UiPanelBase
	{
		// Token: 0x06028416 RID: 164886 RVA: 0x00B46B14 File Offset: 0x00B44D14
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnDetailClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06028417 RID: 164887 RVA: 0x00B46C20 File Offset: 0x00B44E20
		protected override void OnStart()
		{
			this.SpecialItemLayout = new GenericLayout<RoguelikeAchieveSpecialItem, IRoguelikeAchieveTokenItemData>(base.GetHorizontalLayout(3), new Func<RoguelikeAchieveSpecialItem>(this.CreateTokenItem), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
			base.SetUiActive(false);
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(false);
			}
			this.RefreshSpecialItemLayout(new List<IRoguelikeAchieveTokenItemData>());
		}

		// Token: 0x06028418 RID: 164888 RVA: 0x00B46C83 File Offset: 0x00B44E83
		protected override void OnBeforeDestroy()
		{
			this.SpecialItemLayout = null;
			this.CurrentArchiveInfoData = null;
			this.Vm = null;
		}

		// Token: 0x06028419 RID: 164889 RVA: 0x00B46C9A File Offset: 0x00B44E9A
		public void SetViewModel(RoguelikeAchieveViewModel vm)
		{
			this.Vm = vm;
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(this.CurrentArchiveInfoData != null);
		}

		// Token: 0x0602841A RID: 164890 RVA: 0x00B46CC0 File Offset: 0x00B44EC0
		[NullableContext(2)]
		public void Refresh(RogueArchiveInfoData archiveInfoData)
		{
			this.CurrentArchiveInfoData = archiveInfoData;
			if (archiveInfoData == null || !archiveInfoData.HasData)
			{
				base.SetUiActive(false);
				return;
			}
			RoguelikeInfo roguelikeInfo = archiveInfoData.RoguelikeInfo;
			List<IRoguelikeAchieveTokenItemData> specialItemDataList = this.GetSpecialItemDataList(roguelikeInfo.SpecialEntryList);
			base.SetUiActive(true);
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(this.Vm != null);
			}
			base.GetText(2).SetText(specialItemDataList.Count.ToString(), true);
			this.RefreshSpecialItemLayout(specialItemDataList);
		}

		// Token: 0x0602841B RID: 164891 RVA: 0x00B46D45 File Offset: 0x00B44F45
		private void OnBtnDetailClick()
		{
			RogueArchiveInfoData currentArchiveInfoData = this.CurrentArchiveInfoData;
			if (((currentArchiveInfoData != null) ? currentArchiveInfoData.RoguelikeInfo : null) == null)
			{
				return;
			}
			RoguelikeController.Instance.OpenRogueInfoView(this.CurrentArchiveInfoData.RoguelikeInfo, false, false, ERogueInfoViewPage.Special);
		}

		// Token: 0x0602841C RID: 164892 RVA: 0x00B46D74 File Offset: 0x00B44F74
		private RoguelikeAchieveSpecialItem CreateTokenItem()
		{
			return new RoguelikeAchieveSpecialItem();
		}

		// Token: 0x0602841D RID: 164893 RVA: 0x00B46D7B File Offset: 0x00B44F7B
		private void RefreshSpecialItemLayout(List<IRoguelikeAchieveTokenItemData> dataList)
		{
			GenericLayout<RoguelikeAchieveSpecialItem, IRoguelikeAchieveTokenItemData> specialItemLayout = this.SpecialItemLayout;
			if (specialItemLayout == null)
			{
				return;
			}
			specialItemLayout.RefreshByData(dataList, null, false);
		}

		// Token: 0x0602841E RID: 164894 RVA: 0x00B46D90 File Offset: 0x00B44F90
		private List<IRoguelikeAchieveTokenItemData> GetSpecialItemDataList(List<RogueGainEntry> specialEntryList)
		{
			List<IRoguelikeAchieveTokenItemData> list = new List<IRoguelikeAchieveTokenItemData>();
			foreach (RogueGainEntry gainEntry in specialEntryList)
			{
				list.Add(new RoguelikeAchieveTokenItemData
				{
					GainEntry = gainEntry
				});
			}
			list.Sort(new Comparison<IRoguelikeAchieveTokenItemData>(this.SortSpecialItem));
			return list;
		}

		// Token: 0x0602841F RID: 164895 RVA: 0x00B46E04 File Offset: 0x00B45004
		private int SortSpecialItem(IRoguelikeAchieveTokenItemData a, IRoguelikeAchieveTokenItemData b)
		{
			RoguelikeConfig instance = RoguelikeConfig.Instance;
			RougeMiraclecreation? rougeMiraclecreation = (instance != null) ? instance.GetRoguelikeSpecialConfig(a.GainEntry.ConfigId) : null;
			RoguelikeConfig instance2 = RoguelikeConfig.Instance;
			RougeMiraclecreation? rougeMiraclecreation2 = (instance2 != null) ? instance2.GetRoguelikeSpecialConfig(b.GainEntry.ConfigId) : null;
			RougeMiraclecreationColor? rougeMiraclecreationColor = (rougeMiraclecreation != null) ? RoguelikeConfig.Instance.GetRoguelikeMiraclecreationColorConfig(rougeMiraclecreation.Value.ColorType) : null;
			RougeMiraclecreationColor? rougeMiraclecreationColor2 = (rougeMiraclecreation2 != null) ? RoguelikeConfig.Instance.GetRoguelikeMiraclecreationColorConfig(rougeMiraclecreation2.Value.ColorType) : null;
			int num = (rougeMiraclecreationColor != null) ? rougeMiraclecreationColor.GetValueOrDefault().Sort : 0;
			return ((rougeMiraclecreationColor2 != null) ? rougeMiraclecreationColor2.GetValueOrDefault().Sort : 0) - num;
		}

		// Token: 0x04015E42 RID: 89666
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikeAchieveSpecialItem, IRoguelikeAchieveTokenItemData> SpecialItemLayout;

		// Token: 0x04015E43 RID: 89667
		[Nullable(2)]
		private RogueArchiveInfoData CurrentArchiveInfoData;

		// Token: 0x04015E44 RID: 89668
		[Nullable(2)]
		private RoguelikeAchieveViewModel Vm;

		// Token: 0x0200995F RID: 39263
		[NullableContext(0)]
		private class ERoguelikeAchieveSpecialPanelComponents
		{
			// Token: 0x0402FD47 RID: 195911
			public const int SpecialPanel = 0;

			// Token: 0x0402FD48 RID: 195912
			public const int BtnDetail = 1;

			// Token: 0x0402FD49 RID: 195913
			public const int TxtValue = 2;

			// Token: 0x0402FD4A RID: 195914
			public const int TokenLayout = 3;

			// Token: 0x0402FD4B RID: 195915
			public const int TokenItem = 4;
		}
	}
}
