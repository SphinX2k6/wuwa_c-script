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
	// Token: 0x02003A86 RID: 14982
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseBdSumBdItem : GridProxyAbstract<TrapDefenseBdData>
	{
		// Token: 0x060267DF RID: 157663 RVA: 0x00AC89F8 File Offset: 0x00AC6BF8
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

		// Token: 0x060267E0 RID: 157664 RVA: 0x00AC8BA8 File Offset: 0x00AC6DA8
		[Conditional("WITH_EDITOR")]
		private void EditorShowActorLabel()
		{
		}

		// Token: 0x060267E1 RID: 157665 RVA: 0x00AC8BAC File Offset: 0x00AC6DAC
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBdSumBdItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdSumBdItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060267E2 RID: 157666 RVA: 0x00AC8BF0 File Offset: 0x00AC6DF0
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

		// Token: 0x060267E3 RID: 157667 RVA: 0x00AC8C3C File Offset: 0x00AC6E3C
		public UniTask UpdateProgress()
		{
			TrapDefenseBdSumBdItem.<UpdateProgress>d__8 <UpdateProgress>d__;
			<UpdateProgress>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<UpdateProgress>d__.<>4__this = this;
			<UpdateProgress>d__.<>1__state = -1;
			<UpdateProgress>d__.<>t__builder.Start<TrapDefenseBdSumBdItem.<UpdateProgress>d__8>(ref <UpdateProgress>d__);
			return <UpdateProgress>d__.<>t__builder.Task;
		}

		// Token: 0x060267E4 RID: 157668 RVA: 0x00AC8C7F File Offset: 0x00AC6E7F
		private TrapDefenseBdSumBdProgressItem CreateItemLayoutProgress()
		{
			return new TrapDefenseBdSumBdProgressItem();
		}

		// Token: 0x060267E5 RID: 157669 RVA: 0x00AC8C86 File Offset: 0x00AC6E86
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

		// Token: 0x060267E6 RID: 157670 RVA: 0x00AC8CAC File Offset: 0x00AC6EAC
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

		// Token: 0x060267E7 RID: 157671 RVA: 0x00AC8D30 File Offset: 0x00AC6F30
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

		// Token: 0x04015188 RID: 86408
		public TrapDefenseBdData ItemData;

		// Token: 0x04015189 RID: 86409
		public Action<TrapDefenseBdData> ClickCallBack;

		// Token: 0x0401518A RID: 86410
		public GenericLayout<TrapDefenseBdSumBdProgressItem, ITrapDefenseBdProgressInfo> LayoutProgress;

		// Token: 0x02009684 RID: 38532
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EFF3 RID: 192499
			public const int ToggleRoot = 0;

			// Token: 0x0402EFF4 RID: 192500
			public const int TextureBgQuality = 1;

			// Token: 0x0402EFF5 RID: 192501
			public const int TextureIcon = 2;

			// Token: 0x0402EFF6 RID: 192502
			public const int TextTitle = 3;

			// Token: 0x0402EFF7 RID: 192503
			public const int TextDesc = 4;

			// Token: 0x0402EFF8 RID: 192504
			public const int TextProgress = 5;

			// Token: 0x0402EFF9 RID: 192505
			public const int LayoutProgress = 6;

			// Token: 0x0402EFFA RID: 192506
			public const int ItemLayoutProgress = 7;

			// Token: 0x0402EFFB RID: 192507
			public const int ItemNormalState = 8;

			// Token: 0x0402EFFC RID: 192508
			public const int ItemLockState = 9;
		}
	}
}
