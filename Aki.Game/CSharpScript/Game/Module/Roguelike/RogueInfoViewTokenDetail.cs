using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DCA RID: 15818
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueInfoViewTokenDetail : UiPanelBase
	{
		// Token: 0x060286C8 RID: 165576 RVA: 0x00B53724 File Offset: 0x00B51924
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060286C9 RID: 165577 RVA: 0x00B537AE File Offset: 0x00B519AE
		protected override void OnBeforeCreateImplement()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x060286CA RID: 165578 RVA: 0x00B537C8 File Offset: 0x00B519C8
		protected override UniTask OnBeforeStartAsync()
		{
			RogueInfoViewTokenDetail.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueInfoViewTokenDetail.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060286CB RID: 165579 RVA: 0x00B5380C File Offset: 0x00B51A0C
		private int SortBuffEntry(RogueGainEntry a, RogueGainEntry b)
		{
			RogueBuffPool? rogueBuffConfig = RoguelikeConfig.Instance.GetRogueBuffConfig(a.ConfigId);
			int? num = (rogueBuffConfig != null) ? new int?(rogueBuffConfig.GetValueOrDefault().Quality) : null;
			rogueBuffConfig = RoguelikeConfig.Instance.GetRogueBuffConfig(b.ConfigId);
			int? num2 = (rogueBuffConfig != null) ? new int?(rogueBuffConfig.GetValueOrDefault().Quality) : null;
			if (num == null || num2 == null)
			{
				return b.ConfigId - a.ConfigId;
			}
			return num2.Value - num.Value;
		}

		// Token: 0x060286CC RID: 165580 RVA: 0x00B538BE File Offset: 0x00B51ABE
		protected override void OnStart()
		{
			this.DetailItem.SetActive(false);
		}

		// Token: 0x060286CD RID: 165581 RVA: 0x00B538CC File Offset: 0x00B51ACC
		protected override void OnAfterShow()
		{
			if (this.Vm != null && this.Vm.IsBuffEntryEmpty())
			{
				return;
			}
			this.LoopScrollView.SelectGridProxy(0, true);
		}

		// Token: 0x060286CE RID: 165582 RVA: 0x00B538F4 File Offset: 0x00B51AF4
		public void SelectFirstGrid()
		{
			RogueInfoViewModel vm = this.Vm;
			if (vm != null && vm.IsBuffEntryEmpty())
			{
				return;
			}
			LoopScrollView<RogueInfoViewTokenDetailGrid, RogueGainEntry> loopScrollView = this.LoopScrollView;
			RogueGainEntry rogueGainEntry;
			if (loopScrollView == null)
			{
				rogueGainEntry = null;
			}
			else
			{
				RogueInfoViewTokenDetailGrid rogueInfoViewTokenDetailGrid = loopScrollView.UnsafeGetGridProxy(0, false);
				rogueGainEntry = ((rogueInfoViewTokenDetailGrid != null) ? rogueInfoViewTokenDetailGrid.GridData : null);
			}
			RogueGainEntry rogueGainEntry2 = rogueGainEntry;
			if (rogueGainEntry2 == null)
			{
				return;
			}
			this.OnSelected(rogueGainEntry2, 0);
		}

		// Token: 0x060286CF RID: 165583 RVA: 0x00B53943 File Offset: 0x00B51B43
		private RogueInfoViewTokenDetailGrid OnCreateGrid()
		{
			return new RogueInfoViewTokenDetailGrid();
		}

		// Token: 0x060286D0 RID: 165584 RVA: 0x00B5394A File Offset: 0x00B51B4A
		public void Update(List<RogueGainEntry> dataList)
		{
			if (dataList.Count <= 0)
			{
				CommonSelectItem detailItem = this.DetailItem;
				if (detailItem != null)
				{
					detailItem.SetActive(false);
				}
			}
			LoopScrollView<RogueInfoViewTokenDetailGrid, RogueGainEntry> loopScrollView = this.LoopScrollView;
			if (loopScrollView == null)
			{
				return;
			}
			loopScrollView.ReloadData(this.GetSortedBuffEntryList(dataList), false);
		}

		// Token: 0x060286D1 RID: 165585 RVA: 0x00B53980 File Offset: 0x00B51B80
		public void OnSelected(RogueGainEntry data, int index)
		{
			int selectedGridIndex = this.LoopScrollView.GetSelectedGridIndex();
			this.LoopScrollView.SelectGridProxy(index, false);
			this.LoopScrollView.RefreshGridProxy(selectedGridIndex);
			this.DetailItem.SetActive(true);
			this.DetailItem.Update(data);
		}

		// Token: 0x060286D2 RID: 165586 RVA: 0x00B539CA File Offset: 0x00B51BCA
		public void SetViewModel(RogueInfoViewModel vm)
		{
			this.Vm = vm;
			this.Update(vm.BuffEntryList);
		}

		// Token: 0x060286D3 RID: 165587 RVA: 0x00B539E0 File Offset: 0x00B51BE0
		public void RefreshSelectedDetail()
		{
			if (this.DetailItem == null || this.Vm == null || !this.DetailItem.GetRootItem().IsUIActiveSelf())
			{
				return;
			}
			RogueGainEntry rogueGainEntry = this.DetailItem.RogueGainEntry;
			if (rogueGainEntry == null)
			{
				this.DetailItem.SetActive(false);
				return;
			}
			RogueGainEntry rogueGainEntry2 = null;
			foreach (RogueGainEntry rogueGainEntry3 in this.Vm.BuffEntryList)
			{
				if (rogueGainEntry3.IncId == rogueGainEntry.IncId)
				{
					rogueGainEntry2 = rogueGainEntry3;
					break;
				}
			}
			if (rogueGainEntry2 == null)
			{
				this.DetailItem.SetActive(false);
				return;
			}
			this.DetailItem.Update(rogueGainEntry2);
		}

		// Token: 0x060286D4 RID: 165588 RVA: 0x00B53AA0 File Offset: 0x00B51CA0
		private List<RogueGainEntry> GetSortedBuffEntryList(List<RogueGainEntry> dataList)
		{
			List<RogueGainEntry> list = dataList.ToList<RogueGainEntry>();
			list.Sort(new Comparison<RogueGainEntry>(this.SortBuffEntry));
			return list;
		}

		// Token: 0x060286D5 RID: 165589 RVA: 0x00B53ABC File Offset: 0x00B51CBC
		private UniTask RefreshTokenListAsync(List<RogueGainEntry> dataList)
		{
			RogueInfoViewTokenDetail.<RefreshTokenListAsync>d__18 <RefreshTokenListAsync>d__;
			<RefreshTokenListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTokenListAsync>d__.<>4__this = this;
			<RefreshTokenListAsync>d__.dataList = dataList;
			<RefreshTokenListAsync>d__.<>1__state = -1;
			<RefreshTokenListAsync>d__.<>t__builder.Start<RogueInfoViewTokenDetail.<RefreshTokenListAsync>d__18>(ref <RefreshTokenListAsync>d__);
			return <RefreshTokenListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04015F30 RID: 89904
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public LoopScrollView<RogueInfoViewTokenDetailGrid, RogueGainEntry> LoopScrollView;

		// Token: 0x04015F31 RID: 89905
		[Nullable(2)]
		public CommonSelectItem DetailItem;

		// Token: 0x04015F32 RID: 89906
		[Nullable(2)]
		public UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x04015F33 RID: 89907
		[Nullable(2)]
		private RogueInfoViewModel Vm;

		// Token: 0x020099C2 RID: 39362
		[NullableContext(0)]
		private class ERogueInfoViewDetailDefine
		{
			// Token: 0x0402FEFE RID: 196350
			public const int LoopScrollItem = 0;

			// Token: 0x0402FEFF RID: 196351
			public const int GridItem = 1;

			// Token: 0x0402FF00 RID: 196352
			public const int DetailItem = 2;
		}
	}
}
