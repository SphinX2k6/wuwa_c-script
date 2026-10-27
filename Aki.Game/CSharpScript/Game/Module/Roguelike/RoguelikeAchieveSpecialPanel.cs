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
	// Token: 0x02004DB3 RID: 19891
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeAchieveSpecialPanel : UiPanelBase
	{
		// Token: 0x060335A9 RID: 210345 RVA: 0x00BFD5E4 File Offset: 0x00BFB7E4
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

		// Token: 0x060335AA RID: 210346 RVA: 0x00BFD6F0 File Offset: 0x00BFB8F0
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

		// Token: 0x060335AB RID: 210347 RVA: 0x00BFD753 File Offset: 0x00BFB953
		protected override void OnBeforeDestroy()
		{
			this.SpecialItemLayout = null;
			this.CurrentArchiveInfoData = null;
			this.Vm = null;
		}

		// Token: 0x060335AC RID: 210348 RVA: 0x00BFD76A File Offset: 0x00BFB96A
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

		// Token: 0x060335AD RID: 210349 RVA: 0x00BFD790 File Offset: 0x00BFB990
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

		// Token: 0x060335AE RID: 210350 RVA: 0x00BFD815 File Offset: 0x00BFBA15
		private void OnBtnDetailClick()
		{
			RogueArchiveInfoData currentArchiveInfoData = this.CurrentArchiveInfoData;
			if (((currentArchiveInfoData != null) ? currentArchiveInfoData.RoguelikeInfo : null) == null)
			{
				return;
			}
			RoguelikeController.Instance.OpenRogueInfoView(this.CurrentArchiveInfoData.RoguelikeInfo, false, false, ERogueInfoViewPage.Special);
		}

		// Token: 0x060335AF RID: 210351 RVA: 0x00BFD844 File Offset: 0x00BFBA44
		private RoguelikeAchieveSpecialItem CreateTokenItem()
		{
			return new RoguelikeAchieveSpecialItem();
		}

		// Token: 0x060335B0 RID: 210352 RVA: 0x00BFD84B File Offset: 0x00BFBA4B
		private void RefreshSpecialItemLayout(List<IRoguelikeAchieveTokenItemData> dataList)
		{
			GenericLayout<RoguelikeAchieveSpecialItem, IRoguelikeAchieveTokenItemData> specialItemLayout = this.SpecialItemLayout;
			if (specialItemLayout == null)
			{
				return;
			}
			specialItemLayout.RefreshByData(dataList, null, false);
		}

		// Token: 0x060335B1 RID: 210353 RVA: 0x00BFD860 File Offset: 0x00BFBA60
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

		// Token: 0x060335B2 RID: 210354 RVA: 0x00BFD8D4 File Offset: 0x00BFBAD4
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

		// Token: 0x0401B46F RID: 111727
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikeAchieveSpecialItem, IRoguelikeAchieveTokenItemData> SpecialItemLayout;

		// Token: 0x0401B470 RID: 111728
		[Nullable(2)]
		private RogueArchiveInfoData CurrentArchiveInfoData;

		// Token: 0x0401B471 RID: 111729
		[Nullable(2)]
		private RoguelikeAchieveViewModel Vm;

		// Token: 0x0200AF2A RID: 44842
		[NullableContext(0)]
		private class ERoguelikeAchieveSpecialPanelComponents
		{
			// Token: 0x04035312 RID: 217874
			public const int SpecialPanel = 0;

			// Token: 0x04035313 RID: 217875
			public const int BtnDetail = 1;

			// Token: 0x04035314 RID: 217876
			public const int TxtValue = 2;

			// Token: 0x04035315 RID: 217877
			public const int TokenLayout = 3;

			// Token: 0x04035316 RID: 217878
			public const int TokenItem = 4;
		}
	}
}
