using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004ADE RID: 19166
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBdSumBdItem : GridProxyAbstract<TrapDefenseBdData>
	{
		// Token: 0x06031A4F RID: 203343 RVA: 0x00B84A44 File Offset: 0x00B82C44
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
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUILayoutBase));
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
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggleRoot));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06031A50 RID: 203344 RVA: 0x00B84BF4 File Offset: 0x00B82DF4
		[Conditional("WITH_EDITOR")]
		private void EditorShowActorLabel()
		{
		}

		// Token: 0x06031A51 RID: 203345 RVA: 0x00B84BF8 File Offset: 0x00B82DF8
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBdSumBdItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdSumBdItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031A52 RID: 203346 RVA: 0x00B84C3C File Offset: 0x00B82E3C
		public override UniTask RefreshAsync(TrapDefenseBdData data, bool isSelected, int gridIndex)
		{
			TrapDefenseBdSumBdItem.<RefreshAsync>d__7 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<TrapDefenseBdSumBdItem.<RefreshAsync>d__7>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031A53 RID: 203347 RVA: 0x00B84C88 File Offset: 0x00B82E88
		public UniTask UpdateProgress()
		{
			TrapDefenseBdSumBdItem.<UpdateProgress>d__8 <UpdateProgress>d__;
			<UpdateProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateProgress>d__.<>4__this = this;
			<UpdateProgress>d__.<>1__state = -1;
			<UpdateProgress>d__.<>t__builder.Start<TrapDefenseBdSumBdItem.<UpdateProgress>d__8>(ref <UpdateProgress>d__);
			return <UpdateProgress>d__.<>t__builder.Task;
		}

		// Token: 0x06031A54 RID: 203348 RVA: 0x00B84CCB File Offset: 0x00B82ECB
		private TrapDefenseBdSumBdProgressItem CreateItemLayoutProgress()
		{
			return new TrapDefenseBdSumBdProgressItem();
		}

		// Token: 0x06031A55 RID: 203349 RVA: 0x00B84CD2 File Offset: 0x00B82ED2
		private void OnClickToggleRoot(EToggleState check)
		{
			if (check == EToggleState.ETT_Checked)
			{
				IScrollViewDelegate<IGridProxy<TrapDefenseBdData>, TrapDefenseBdData> scrollViewDelegate = base.ScrollViewDelegate;
				if (scrollViewDelegate == null)
				{
					return;
				}
				scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
			}
		}

		// Token: 0x06031A56 RID: 203350 RVA: 0x00B84CF8 File Offset: 0x00B82EF8
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
			Action<TrapDefenseBdData> clickCallBack = this.ClickCallBack;
			if (clickCallBack != null)
			{
				clickCallBack(this.ItemData);
			}
			foreach (TrapDefenseBdSumBdProgressItem trapDefenseBdSumBdProgressItem in this.LayoutProgress.GetLayoutItemList())
			{
				trapDefenseBdSumBdProgressItem.SetQualityArrowShow(true);
			}
		}

		// Token: 0x06031A57 RID: 203351 RVA: 0x00B84D7C File Offset: 0x00B82F7C
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			foreach (TrapDefenseBdSumBdProgressItem trapDefenseBdSumBdProgressItem in this.LayoutProgress.GetLayoutItemList())
			{
				trapDefenseBdSumBdProgressItem.SetQualityArrowShow(false);
			}
		}

		// Token: 0x0401A836 RID: 108598
		public TrapDefenseBdData ItemData;

		// Token: 0x0401A837 RID: 108599
		public Action<TrapDefenseBdData> ClickCallBack;

		// Token: 0x0401A838 RID: 108600
		public GenericLayout<TrapDefenseBdSumBdProgressItem, ITrapDefenseBdProgressInfo> LayoutProgress;

		// Token: 0x0200AC64 RID: 44132
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04034642 RID: 214594
			public const int ToggleRoot = 0;

			// Token: 0x04034643 RID: 214595
			public const int TextureBgQuality = 1;

			// Token: 0x04034644 RID: 214596
			public const int TextureIcon = 2;

			// Token: 0x04034645 RID: 214597
			public const int TextTitle = 3;

			// Token: 0x04034646 RID: 214598
			public const int TextDesc = 4;

			// Token: 0x04034647 RID: 214599
			public const int TextProgress = 5;

			// Token: 0x04034648 RID: 214600
			public const int LayoutProgress = 6;

			// Token: 0x04034649 RID: 214601
			public const int ItemLayoutProgress = 7;

			// Token: 0x0403464A RID: 214602
			public const int ItemNormalState = 8;

			// Token: 0x0403464B RID: 214603
			public const int ItemLockState = 9;
		}
	}
}
