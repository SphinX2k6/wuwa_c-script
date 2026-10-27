using System;
using System.Collections.Generic;
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
	// Token: 0x02004DD8 RID: 19928
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikePopularEntriesDescPanel : UiPanelBase
	{
		// Token: 0x0603370D RID: 210701 RVA: 0x00C044F0 File Offset: 0x00C026F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickReduce));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickAdd));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603370E RID: 210702 RVA: 0x00C0461C File Offset: 0x00C0281C
		protected override void OnStart()
		{
			this.DescLayout = new GenericScrollViewNew<RoguelikePopularEntryDesc, int>(base.GetScrollViewWithScrollbar(0), new Func<RoguelikePopularEntryDesc>(this.CreateDescItem), null, false, null);
		}

		// Token: 0x0603370F RID: 210703 RVA: 0x00C04640 File Offset: 0x00C02840
		public UniTask Init(RoguelikeEntranceViewModel vm)
		{
			RoguelikePopularEntriesDescPanel.<Init>d__5 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.vm = vm;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<RoguelikePopularEntriesDescPanel.<Init>d__5>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06033710 RID: 210704 RVA: 0x00C0468C File Offset: 0x00C0288C
		public void Refresh(RoguelikeEntranceViewModel vm)
		{
			GenericScrollViewNew<RoguelikePopularEntryDesc, int> descLayout = this.DescLayout;
			List<RoguelikePopularEntryDesc> list = ((descLayout != null) ? descLayout.GetScrollItemList() : null) ?? new List<RoguelikePopularEntryDesc>();
			List<bool> list2 = new List<bool>();
			List<bool> list3 = new List<bool>();
			int num = -1;
			for (int i = 0; i < list.Count; i++)
			{
				RoguelikePopularEntryDesc roguelikePopularEntryDesc = list[i];
				list2.Add(roguelikePopularEntryDesc.ShowState);
				bool overviewIdActiveState = vm.GetOverviewIdActiveState(roguelikePopularEntryDesc.OverviewId);
				list3.Add(overviewIdActiveState);
				if (overviewIdActiveState)
				{
					num = i;
				}
			}
			bool delayEmit = false;
			for (int j = 0; j < list.Count; j++)
			{
				if (j != num && !list2[j] && list3[j])
				{
					delayEmit = true;
					break;
				}
			}
			for (int k = 0; k < list.Count; k++)
			{
				RoguelikePopularEntryDesc roguelikePopularEntryDesc2 = list[k];
				roguelikePopularEntryDesc2.Reset();
				roguelikePopularEntryDesc2.RefreshState(list3[k], delayEmit);
			}
			RogueHotEntryGroup config = vm.CurrentEntriesGroupData.GetConfig();
			base.GetText(2).SetText(((float)config.Rate / 100f).ToString() + "%", true);
			base.GetText(2).SetColor(FColor.FromHex(config.RateColor));
			base.GetButton(3).SetSelfInteractive(vm.IsReduceMultiplierAvailable);
			base.GetButton(4).SetSelfInteractive(vm.IsAddMultiplierAvailable);
		}

		// Token: 0x06033711 RID: 210705 RVA: 0x00C047EC File Offset: 0x00C029EC
		private RoguelikePopularEntryDesc CreateDescItem()
		{
			return new RoguelikePopularEntryDesc();
		}

		// Token: 0x06033712 RID: 210706 RVA: 0x00C047F3 File Offset: 0x00C029F3
		private void OnClickReduce()
		{
			Action<bool> onMultiplierChange = this.OnMultiplierChange;
			if (onMultiplierChange == null)
			{
				return;
			}
			onMultiplierChange(false);
		}

		// Token: 0x06033713 RID: 210707 RVA: 0x00C04806 File Offset: 0x00C02A06
		private void OnClickAdd()
		{
			Action<bool> onMultiplierChange = this.OnMultiplierChange;
			if (onMultiplierChange == null)
			{
				return;
			}
			onMultiplierChange(true);
		}

		// Token: 0x0401B4EC RID: 111852
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<RoguelikePopularEntryDesc, int> DescLayout;

		// Token: 0x0401B4ED RID: 111853
		[Nullable(2)]
		public Action<bool> OnMultiplierChange;

		// Token: 0x0200AF5A RID: 44890
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040353E1 RID: 218081
			public const int ScrollViewEntryDesc = 0;

			// Token: 0x040353E2 RID: 218082
			public const int EntryDesc = 1;

			// Token: 0x040353E3 RID: 218083
			public const int TxtMultiplier = 2;

			// Token: 0x040353E4 RID: 218084
			public const int BtnReduce = 3;

			// Token: 0x040353E5 RID: 218085
			public const int BtnAdd = 4;
		}
	}
}
