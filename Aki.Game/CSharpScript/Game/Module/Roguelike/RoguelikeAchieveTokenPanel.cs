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
	// Token: 0x02004DB8 RID: 19896
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeAchieveTokenPanel : UiPanelBase
	{
		// Token: 0x060335D5 RID: 210389 RVA: 0x00BFE170 File Offset: 0x00BFC370
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnDetailClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060335D6 RID: 210390 RVA: 0x00BFE29C File Offset: 0x00BFC49C
		protected override void OnStart()
		{
			this.TokenDetailLayout = new GenericLayout<RoguelikeAchieveSmallTokenGrid, RogueGainEntry>(base.GetHorizontalLayout(3), new Func<RoguelikeAchieveSmallTokenGrid>(this.CreateTokenDetailGrid), base.GetItem(4).GetOwner() as AUIBaseActor, false, true);
			base.SetUiActive(false);
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(false);
			}
			this.RefreshTokenDetailLayout(new List<RogueGainEntry>());
		}

		// Token: 0x060335D7 RID: 210391 RVA: 0x00BFE2FF File Offset: 0x00BFC4FF
		protected override void OnBeforeDestroy()
		{
			this.TokenDetailLayout = null;
			this.CurrentArchiveInfoData = null;
			this.Vm = null;
		}

		// Token: 0x060335D8 RID: 210392 RVA: 0x00BFE316 File Offset: 0x00BFC516
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

		// Token: 0x060335D9 RID: 210393 RVA: 0x00BFE33C File Offset: 0x00BFC53C
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
			List<RogueGainEntry> sortedBuffEntryList = this.GetSortedBuffEntryList(roguelikeInfo.BuffEntryList);
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(this.Vm != null);
			}
			base.GetText(2).SetText(sortedBuffEntryList.Count.ToString(), true);
			base.GetItem(5).SetUIActive(sortedBuffEntryList.Count > 8);
			this.RefreshTokenDetailLayout(sortedBuffEntryList);
			base.SetUiActive(true);
		}

		// Token: 0x060335DA RID: 210394 RVA: 0x00BFE3D6 File Offset: 0x00BFC5D6
		private void OnBtnDetailClick()
		{
			RogueArchiveInfoData currentArchiveInfoData = this.CurrentArchiveInfoData;
			if (((currentArchiveInfoData != null) ? currentArchiveInfoData.RoguelikeInfo : null) == null)
			{
				return;
			}
			RoguelikeController.Instance.OpenRogueInfoView(this.CurrentArchiveInfoData.RoguelikeInfo, false, false, ERogueInfoViewPage.Token);
		}

		// Token: 0x060335DB RID: 210395 RVA: 0x00BFE405 File Offset: 0x00BFC605
		private RoguelikeAchieveSmallTokenGrid CreateTokenDetailGrid()
		{
			return new RoguelikeAchieveSmallTokenGrid();
		}

		// Token: 0x060335DC RID: 210396 RVA: 0x00BFE40C File Offset: 0x00BFC60C
		private void RefreshTokenDetailLayout(List<RogueGainEntry> dataList)
		{
			GenericLayout<RoguelikeAchieveSmallTokenGrid, RogueGainEntry> tokenDetailLayout = this.TokenDetailLayout;
			if (tokenDetailLayout == null)
			{
				return;
			}
			tokenDetailLayout.RefreshByData(dataList, null, false);
		}

		// Token: 0x060335DD RID: 210397 RVA: 0x00BFE421 File Offset: 0x00BFC621
		private List<RogueGainEntry> GetSortedBuffEntryList(List<RogueGainEntry> dataList)
		{
			List<RogueGainEntry> list = new List<RogueGainEntry>(dataList);
			list.Sort(new Comparison<RogueGainEntry>(this.SortBuffEntry));
			return list;
		}

		// Token: 0x060335DE RID: 210398 RVA: 0x00BFE43C File Offset: 0x00BFC63C
		private int SortBuffEntry(RogueGainEntry a, RogueGainEntry b)
		{
			RoguelikeConfig instance = RoguelikeConfig.Instance;
			int? num;
			if (instance == null)
			{
				num = null;
			}
			else
			{
				RogueBuffPool? rogueBuffConfig = instance.GetRogueBuffConfig(a.ConfigId);
				num = ((rogueBuffConfig != null) ? new int?(rogueBuffConfig.GetValueOrDefault().Quality) : null);
			}
			int? num2 = num;
			RoguelikeConfig instance2 = RoguelikeConfig.Instance;
			int? num3;
			if (instance2 == null)
			{
				num3 = null;
			}
			else
			{
				RogueBuffPool? rogueBuffConfig = instance2.GetRogueBuffConfig(b.ConfigId);
				num3 = ((rogueBuffConfig != null) ? new int?(rogueBuffConfig.GetValueOrDefault().Quality) : null);
			}
			int? num4 = num3;
			if (num2 == null || num4 == null)
			{
				return 0;
			}
			return num4.Value - num2.Value;
		}

		// Token: 0x0401B475 RID: 111733
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikeAchieveSmallTokenGrid, RogueGainEntry> TokenDetailLayout;

		// Token: 0x0401B476 RID: 111734
		[Nullable(2)]
		private RogueArchiveInfoData CurrentArchiveInfoData;

		// Token: 0x0401B477 RID: 111735
		[Nullable(2)]
		private RoguelikeAchieveViewModel Vm;

		// Token: 0x0200AF2E RID: 44846
		[NullableContext(0)]
		private class ERoguelikeAchieveTokenPanelComponents
		{
			// Token: 0x04035323 RID: 217891
			public const int TokenPanel = 0;

			// Token: 0x04035324 RID: 217892
			public const int BtnDetail = 1;

			// Token: 0x04035325 RID: 217893
			public const int TxtValue = 2;

			// Token: 0x04035326 RID: 217894
			public const int BuffLayout = 3;

			// Token: 0x04035327 RID: 217895
			public const int TokenDetailGridItem = 4;

			// Token: 0x04035328 RID: 217896
			public const int PnlMore = 5;
		}
	}
}
