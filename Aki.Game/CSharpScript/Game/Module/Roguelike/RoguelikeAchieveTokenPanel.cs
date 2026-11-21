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
	// Token: 0x02003D81 RID: 15745
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeAchieveTokenPanel : UiPanelBase
	{
		// Token: 0x06028442 RID: 164930 RVA: 0x00B476B0 File Offset: 0x00B458B0
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

		// Token: 0x06028443 RID: 164931 RVA: 0x00B477DC File Offset: 0x00B459DC
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

		// Token: 0x06028444 RID: 164932 RVA: 0x00B4783F File Offset: 0x00B45A3F
		protected override void OnBeforeDestroy()
		{
			this.TokenDetailLayout = null;
			this.CurrentArchiveInfoData = null;
			this.Vm = null;
		}

		// Token: 0x06028445 RID: 164933 RVA: 0x00B47856 File Offset: 0x00B45A56
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

		// Token: 0x06028446 RID: 164934 RVA: 0x00B4787C File Offset: 0x00B45A7C
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

		// Token: 0x06028447 RID: 164935 RVA: 0x00B47916 File Offset: 0x00B45B16
		private void OnBtnDetailClick()
		{
			RogueArchiveInfoData currentArchiveInfoData = this.CurrentArchiveInfoData;
			if (((currentArchiveInfoData != null) ? currentArchiveInfoData.RoguelikeInfo : null) == null)
			{
				return;
			}
			RoguelikeController.Instance.OpenRogueInfoView(this.CurrentArchiveInfoData.RoguelikeInfo, false, false, ERogueInfoViewPage.Token);
		}

		// Token: 0x06028448 RID: 164936 RVA: 0x00B47945 File Offset: 0x00B45B45
		private RoguelikeAchieveSmallTokenGrid CreateTokenDetailGrid()
		{
			return new RoguelikeAchieveSmallTokenGrid();
		}

		// Token: 0x06028449 RID: 164937 RVA: 0x00B4794C File Offset: 0x00B45B4C
		private void RefreshTokenDetailLayout(List<RogueGainEntry> dataList)
		{
			GenericLayout<RoguelikeAchieveSmallTokenGrid, RogueGainEntry> tokenDetailLayout = this.TokenDetailLayout;
			if (tokenDetailLayout == null)
			{
				return;
			}
			tokenDetailLayout.RefreshByData(dataList, null, false);
		}

		// Token: 0x0602844A RID: 164938 RVA: 0x00B47961 File Offset: 0x00B45B61
		private List<RogueGainEntry> GetSortedBuffEntryList(List<RogueGainEntry> dataList)
		{
			List<RogueGainEntry> list = new List<RogueGainEntry>(dataList);
			list.Sort(new Comparison<RogueGainEntry>(this.SortBuffEntry));
			return list;
		}

		// Token: 0x0602844B RID: 164939 RVA: 0x00B4797C File Offset: 0x00B45B7C
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

		// Token: 0x04015E48 RID: 89672
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikeAchieveSmallTokenGrid, RogueGainEntry> TokenDetailLayout;

		// Token: 0x04015E49 RID: 89673
		[Nullable(2)]
		private RogueArchiveInfoData CurrentArchiveInfoData;

		// Token: 0x04015E4A RID: 89674
		[Nullable(2)]
		private RoguelikeAchieveViewModel Vm;

		// Token: 0x02009963 RID: 39267
		[NullableContext(0)]
		private class ERoguelikeAchieveTokenPanelComponents
		{
			// Token: 0x0402FD58 RID: 195928
			public const int TokenPanel = 0;

			// Token: 0x0402FD59 RID: 195929
			public const int BtnDetail = 1;

			// Token: 0x0402FD5A RID: 195930
			public const int TxtValue = 2;

			// Token: 0x0402FD5B RID: 195931
			public const int BuffLayout = 3;

			// Token: 0x0402FD5C RID: 195932
			public const int TokenDetailGridItem = 4;

			// Token: 0x0402FD5D RID: 195933
			public const int PnlMore = 5;
		}
	}
}
