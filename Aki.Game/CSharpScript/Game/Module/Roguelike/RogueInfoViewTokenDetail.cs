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
	// Token: 0x02004E01 RID: 19969
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueInfoViewTokenDetail : UiPanelBase
	{
		// Token: 0x0603385D RID: 211037 RVA: 0x00C0A214 File Offset: 0x00C08414
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

		// Token: 0x0603385E RID: 211038 RVA: 0x00C0A29E File Offset: 0x00C0849E
		protected override void OnBeforeCreateImplement()
		{
			this.UiViewSequence = new UiBehaviorLevelSequence(this);
			base.AddUiBehavior(this.UiViewSequence);
		}

		// Token: 0x0603385F RID: 211039 RVA: 0x00C0A2B8 File Offset: 0x00C084B8
		protected override UniTask OnBeforeStartAsync()
		{
			RogueInfoViewTokenDetail.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueInfoViewTokenDetail.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033860 RID: 211040 RVA: 0x00C0A2FC File Offset: 0x00C084FC
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

		// Token: 0x06033861 RID: 211041 RVA: 0x00C0A3AE File Offset: 0x00C085AE
		protected override void OnStart()
		{
			this.DetailItem.SetActive(false);
		}

		// Token: 0x06033862 RID: 211042 RVA: 0x00C0A3BC File Offset: 0x00C085BC
		protected override void OnAfterShow()
		{
			if (this.Vm != null && this.Vm.IsBuffEntryEmpty())
			{
				return;
			}
			this.LoopScrollView.SelectGridProxy(0, true);
		}

		// Token: 0x06033863 RID: 211043 RVA: 0x00C0A3E4 File Offset: 0x00C085E4
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

		// Token: 0x06033864 RID: 211044 RVA: 0x00C0A433 File Offset: 0x00C08633
		private RogueInfoViewTokenDetailGrid OnCreateGrid()
		{
			return new RogueInfoViewTokenDetailGrid();
		}

		// Token: 0x06033865 RID: 211045 RVA: 0x00C0A43A File Offset: 0x00C0863A
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

		// Token: 0x06033866 RID: 211046 RVA: 0x00C0A470 File Offset: 0x00C08670
		public void OnSelected(RogueGainEntry data, int index)
		{
			int selectedGridIndex = this.LoopScrollView.GetSelectedGridIndex();
			this.LoopScrollView.SelectGridProxy(index, false);
			this.LoopScrollView.RefreshGridProxy(selectedGridIndex);
			this.DetailItem.SetActive(true);
			this.DetailItem.Update(data);
		}

		// Token: 0x06033867 RID: 211047 RVA: 0x00C0A4BA File Offset: 0x00C086BA
		public void SetViewModel(RogueInfoViewModel vm)
		{
			this.Vm = vm;
			this.Update(vm.BuffEntryList);
		}

		// Token: 0x06033868 RID: 211048 RVA: 0x00C0A4D0 File Offset: 0x00C086D0
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

		// Token: 0x06033869 RID: 211049 RVA: 0x00C0A590 File Offset: 0x00C08790
		private List<RogueGainEntry> GetSortedBuffEntryList(List<RogueGainEntry> dataList)
		{
			List<RogueGainEntry> list = dataList.ToList<RogueGainEntry>();
			list.Sort(new Comparison<RogueGainEntry>(this.SortBuffEntry));
			return list;
		}

		// Token: 0x0603386A RID: 211050 RVA: 0x00C0A5AC File Offset: 0x00C087AC
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

		// Token: 0x0401B55D RID: 111965
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public LoopScrollView<RogueInfoViewTokenDetailGrid, RogueGainEntry> LoopScrollView;

		// Token: 0x0401B55E RID: 111966
		[Nullable(2)]
		public CommonSelectItem DetailItem;

		// Token: 0x0401B55F RID: 111967
		[Nullable(2)]
		public UiBehaviorLevelSequence UiViewSequence;

		// Token: 0x0401B560 RID: 111968
		[Nullable(2)]
		private RogueInfoViewModel Vm;

		// Token: 0x0200AF8D RID: 44941
		[NullableContext(0)]
		private class ERogueInfoViewDetailDefine
		{
			// Token: 0x040354CB RID: 218315
			public const int LoopScrollItem = 0;

			// Token: 0x040354CC RID: 218316
			public const int GridItem = 1;

			// Token: 0x040354CD RID: 218317
			public const int DetailItem = 2;
		}
	}
}
