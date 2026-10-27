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
	// Token: 0x02004ADD RID: 19165
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseBdSumBdDescPanel : UiPanelBase
	{
		// Token: 0x06031A3F RID: 203327 RVA: 0x00B84714 File Offset: 0x00B82914
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

		// Token: 0x06031A40 RID: 203328 RVA: 0x00B8475F File Offset: 0x00B8295F
		protected override void OnBeforeCreate()
		{
		}

		// Token: 0x06031A41 RID: 203329 RVA: 0x00B84764 File Offset: 0x00B82964
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

		// Token: 0x06031A42 RID: 203330 RVA: 0x00B84872 File Offset: 0x00B82A72
		[Conditional("WITH_EDITOR")]
		private void EditorShowActorLabel()
		{
		}

		// Token: 0x06031A43 RID: 203331 RVA: 0x00B84874 File Offset: 0x00B82A74
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseBdSumBdDescPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseBdSumBdDescPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031A44 RID: 203332 RVA: 0x00B848B7 File Offset: 0x00B82AB7
		protected override void OnStart()
		{
		}

		// Token: 0x06031A45 RID: 203333 RVA: 0x00B848B9 File Offset: 0x00B82AB9
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x06031A46 RID: 203334 RVA: 0x00B848BB File Offset: 0x00B82ABB
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06031A47 RID: 203335 RVA: 0x00B848C0 File Offset: 0x00B82AC0
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

		// Token: 0x06031A48 RID: 203336 RVA: 0x00B8494C File Offset: 0x00B82B4C
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

		// Token: 0x06031A49 RID: 203337 RVA: 0x00B84993 File Offset: 0x00B82B93
		private TrapDefenseBdBuffItem CreateItemBdBuff()
		{
			return new TrapDefenseBdBuffItem
			{
				OnClickBuffItemCallback = new Action<TrapDefenseBdBuffData>(this.OnClickBdBuffItem),
				CanExecuteChangeCallback = new Func<TrapDefenseBdBuffData, bool>(this.BdBuffCanExecuteChange)
			};
		}

		// Token: 0x06031A4A RID: 203338 RVA: 0x00B849C0 File Offset: 0x00B82BC0
		private void OnClickBdBuffItem(TrapDefenseBdBuffData data)
		{
			TrapDefenseBdData belongBdData = data.GetBelongBdData();
			int quality = data.Config.Quality;
			bool bdQualityShowNew = this.GetBdQualityShowNew(belongBdData, (ETrapDefenseBdBuffQuality)quality);
			TrapDefenseModel.Instance.OpenViewBdQuality(belongBdData.Id, new ETrapDefenseBdBuffQuality?((ETrapDefenseBdBuffQuality)quality), new bool?(bdQualityShowNew), new int?(data.Id));
		}

		// Token: 0x06031A4B RID: 203339 RVA: 0x00B84A10 File Offset: 0x00B82C10
		public bool GetBdQualityShowNew(TrapDefenseBdData bdData, ETrapDefenseBdBuffQuality quality)
		{
			return TrapDefenseModel.Instance.ViewModelBdSum.IsInstance && bdData.GetCurActiveQualityPool() == quality;
		}

		// Token: 0x06031A4C RID: 203340 RVA: 0x00B84A2E File Offset: 0x00B82C2E
		private bool BdBuffCanExecuteChange(TrapDefenseBdBuffData _)
		{
			return false;
		}

		// Token: 0x0401A834 RID: 108596
		[Nullable(2)]
		public TrapDefenseBdData BdData;

		// Token: 0x0401A835 RID: 108597
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<TrapDefenseBdBuffItem, TrapDefenseBdBuffData> LayoutBdBuff;

		// Token: 0x0200AC61 RID: 44129
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04034632 RID: 214578
			public const int ItemBdInfoRoot = 0;

			// Token: 0x04034633 RID: 214579
			public const int ItemLockRoot = 1;

			// Token: 0x04034634 RID: 214580
			public const int TextTitle = 2;

			// Token: 0x04034635 RID: 214581
			public const int TextDesc = 3;

			// Token: 0x04034636 RID: 214582
			public const int ItemBdBuffRoot = 4;

			// Token: 0x04034637 RID: 214583
			public const int LayoutBdBuff = 5;

			// Token: 0x04034638 RID: 214584
			public const int ItemBdBuff = 6;
		}
	}
}
