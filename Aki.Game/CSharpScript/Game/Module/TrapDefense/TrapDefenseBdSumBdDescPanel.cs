using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A85 RID: 14981
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdSumBdDescPanel : UiPanelBase
	{
		// Token: 0x060267CF RID: 157647 RVA: 0x00AC86C8 File Offset: 0x00AC68C8
		public UniTask Init(UUIItem item)
		{
			TrapDefenseBdSumBdDescPanel.<Init>d__3 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<TrapDefenseBdSumBdDescPanel.<Init>d__3>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060267D0 RID: 157648 RVA: 0x00AC8713 File Offset: 0x00AC6913
		protected override void OnBeforeCreate()
		{
		}

		// Token: 0x060267D1 RID: 157649 RVA: 0x00AC8718 File Offset: 0x00AC6918
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060267D2 RID: 157650 RVA: 0x00AC8826 File Offset: 0x00AC6A26
		[Conditional("WITH_EDITOR")]
		private void EditorShowActorLabel()
		{
		}

		// Token: 0x060267D3 RID: 157651 RVA: 0x00AC8828 File Offset: 0x00AC6A28
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBdSumBdDescPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdSumBdDescPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060267D4 RID: 157652 RVA: 0x00AC886B File Offset: 0x00AC6A6B
		protected override void OnStart()
		{
		}

		// Token: 0x060267D5 RID: 157653 RVA: 0x00AC886D File Offset: 0x00AC6A6D
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x060267D6 RID: 157654 RVA: 0x00AC886F File Offset: 0x00AC6A6F
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x060267D7 RID: 157655 RVA: 0x00AC8874 File Offset: 0x00AC6A74
		public void UpdateData(TrapDefenseBdData data)
		{
			this.BdData = data;
			bool flag = !data.IsUnlockInTheUi();
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(0);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			if (!flag)
			{
				UUIText text = base.GetText(2);
				if (text != null)
				{
					text.ShowTextNew(data.Config.Name);
				}
				UUIText text2 = base.GetText(3);
				if (text2 != null)
				{
					text2.ShowTextNew(data.Config.Desc);
				}
				this.UpdateGoldQualityBuffShow();
			}
		}

		// Token: 0x060267D8 RID: 157656 RVA: 0x00AC8900 File Offset: 0x00AC6B00
		public void UpdateGoldQualityBuffShow()
		{
			List<TrapDefenseBdBuffData> goldQualityBuffDataList = this.BdData.GetGoldQualityBuffDataList();
			bool flag = goldQualityBuffDataList.Count > 0;
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				this.LayoutBdBuff.RefreshByData(goldQualityBuffDataList, null, false);
			}
		}

		// Token: 0x060267D9 RID: 157657 RVA: 0x00AC8947 File Offset: 0x00AC6B47
		private TrapDefenseBdBuffItem CreateItemBdBuff()
		{
			return new TrapDefenseBdBuffItem
			{
				OnClickBuffItemCallback = new Action<TrapDefenseBdBuffData>(this.OnClickBdBuffItem),
				CanExecuteChangeCallback = new Func<TrapDefenseBdBuffData, bool>(this.BdBuffCanExecuteChange)
			};
		}

		// Token: 0x060267DA RID: 157658 RVA: 0x00AC8974 File Offset: 0x00AC6B74
		private void OnClickBdBuffItem(TrapDefenseBdBuffData data)
		{
			TrapDefenseBdData belongBdData = data.GetBelongBdData();
			int quality = data.Config.Quality;
			bool bdQualityShowNew = this.GetBdQualityShowNew(belongBdData, (ETrapDefenseBdBuffQuality)quality);
			TrapDefenseModel.Instance.OpenViewBdQuality(belongBdData.Id, new ETrapDefenseBdBuffQuality?((ETrapDefenseBdBuffQuality)quality), new bool?(bdQualityShowNew), new int?(data.Id));
		}

		// Token: 0x060267DB RID: 157659 RVA: 0x00AC89C4 File Offset: 0x00AC6BC4
		public bool GetBdQualityShowNew(TrapDefenseBdData bdData, ETrapDefenseBdBuffQuality quality)
		{
			return TrapDefenseModel.Instance.ViewModelBdSum.IsInstance && bdData.GetCurActiveQualityPool() == quality;
		}

		// Token: 0x060267DC RID: 157660 RVA: 0x00AC89E2 File Offset: 0x00AC6BE2
		private bool BdBuffCanExecuteChange(TrapDefenseBdBuffData _)
		{
			return false;
		}

		// Token: 0x04015186 RID: 86406
		[Nullable(2)]
		public TrapDefenseBdData BdData;

		// Token: 0x04015187 RID: 86407
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<TrapDefenseBdBuffItem, TrapDefenseBdBuffData> LayoutBdBuff;

		// Token: 0x02009681 RID: 38529
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EFE3 RID: 192483
			public const int ItemBdInfoRoot = 0;

			// Token: 0x0402EFE4 RID: 192484
			public const int ItemLockRoot = 1;

			// Token: 0x0402EFE5 RID: 192485
			public const int TextTitle = 2;

			// Token: 0x0402EFE6 RID: 192486
			public const int TextDesc = 3;

			// Token: 0x0402EFE7 RID: 192487
			public const int ItemBdBuffRoot = 4;

			// Token: 0x0402EFE8 RID: 192488
			public const int LayoutBdBuff = 5;

			// Token: 0x0402EFE9 RID: 192489
			public const int ItemBdBuff = 6;
		}
	}
}
