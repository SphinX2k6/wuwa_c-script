using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AB3 RID: 19123
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TrapDefenseLevelTabPanel<[Nullable(0)] TLevelModeData> : UiPanelBase where TLevelModeData : ITrapDefenseLevelModeData<TrapDefenseLevelModeDataBase>
	{
		// Token: 0x060318C5 RID: 202949 RVA: 0x00B7D50C File Offset: 0x00B7B70C
		public UniTask Init(UUIItem item)
		{
			TrapDefenseLevelTabPanel<TLevelModeData>.<Init>d__7 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<TrapDefenseLevelTabPanel<TLevelModeData>.<Init>d__7>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060318C6 RID: 202950 RVA: 0x00B7D558 File Offset: 0x00B7B758
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIArtText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtnBdSum));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060318C7 RID: 202951 RVA: 0x00B7D684 File Offset: 0x00B7B884
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseLevelTabPanel<TLevelModeData>.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseLevelTabPanel<TLevelModeData>.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060318C8 RID: 202952 RVA: 0x00B7D6C8 File Offset: 0x00B7B8C8
		public void OnClickBtnBdSum()
		{
			TrapDefenseModel.Instance.OpenViewBdSum(new bool?(this.IsInstance), new ETrapDefenseBdTabType?(ETrapDefenseBdTabType.BdProgress), null);
		}

		// Token: 0x060318C9 RID: 202953 RVA: 0x00B7D6F9 File Offset: 0x00B7B8F9
		public TrapDefenseLevelItem CreateItemLevel()
		{
			return new TrapDefenseLevelItem
			{
				OnSelectLevelCallBack = new Action<TrapDefenseLevelItem>(this.SelectLevelItem)
			};
		}

		// Token: 0x060318CA RID: 202954 RVA: 0x00B7D714 File Offset: 0x00B7B914
		public void SelectLevelItem(TrapDefenseLevelItem item)
		{
			TrapDefenseLevelData itemData = item.ItemData;
			this.CurSelectLevel = itemData;
			Action<TrapDefenseLevelData> onSelectLevelCallback = this.OnSelectLevelCallback;
			if (onSelectLevelCallback == null)
			{
				return;
			}
			onSelectLevelCallback(itemData);
		}

		// Token: 0x060318CB RID: 202955 RVA: 0x00B7D740 File Offset: 0x00B7B940
		public void InitSelectLevel(TrapDefenseLevelData data)
		{
			this.CurSelectLevel = data;
		}

		// Token: 0x060318CC RID: 202956 RVA: 0x00B7D74C File Offset: 0x00B7B94C
		public void UpdateLevelDataList(TrapDefenseLevelData[] list)
		{
			int selectIndex = this.UpdateSelectIndex(list);
			this.CurSelectLevel = ((selectIndex >= 0 && selectIndex < list.Length) ? list[selectIndex] : null);
			this.ScrollLevel.SelectGridProxy(-1, false);
			this.ScrollLevel.RefreshByData(list, delegate
			{
				this.ScrollLevel.SelectGridProxy(selectIndex, false);
				UUIItem itemByIndex = this.ScrollLevel.GetItemByIndex(selectIndex);
				if (itemByIndex != null)
				{
					this.ScrollLevel.ScrollTo(itemByIndex, false);
				}
			}, true);
		}

		// Token: 0x060318CD RID: 202957 RVA: 0x00B7D7C0 File Offset: 0x00B7B9C0
		private int UpdateSelectIndex(TrapDefenseLevelData[] list)
		{
			int num = Array.FindIndex<TrapDefenseLevelData>(list, delegate(TrapDefenseLevelData data)
			{
				int id = data.Id;
				TrapDefenseLevelData curSelectLevel = this.CurSelectLevel;
				int? num3 = (curSelectLevel != null) ? new int?(curSelectLevel.Id) : null;
				return id == num3.GetValueOrDefault() & num3 != null;
			});
			if (num >= 0)
			{
				return num;
			}
			int num2 = Array.FindIndex<TrapDefenseLevelData>(list, (TrapDefenseLevelData data) => !data.IsUnlock);
			if (num2 < 0)
			{
				return list.Length - 1;
			}
			if (num2 != 0)
			{
				return num2 - 1;
			}
			return 0;
		}

		// Token: 0x060318CE RID: 202958 RVA: 0x00B7D820 File Offset: 0x00B7BA20
		public void UpdateBdSumProgress()
		{
			TrapDefenseRougeModeData rougeModeData = TrapDefenseModel.Instance.RougeModeData;
			UUIArtText artText = base.GetArtText(5);
			int unlockBdBuffSum = rougeModeData.GetUnlockBdBuffSum();
			int count = rougeModeData.BdBuffDataList.Count;
			UUIArtText uuiartText = artText;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(unlockBdBuffSum);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(count);
			uuiartText.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x060318CF RID: 202959
		public abstract void UpdateModeData();

		// Token: 0x0401A7A5 RID: 108453
		public TLevelModeData ModeData;

		// Token: 0x0401A7A6 RID: 108454
		public TrapDefenseDifficultyChangePanel PanelDifficultyChange;

		// Token: 0x0401A7A7 RID: 108455
		public GenericScrollViewNew<TrapDefenseLevelItem, TrapDefenseLevelData> ScrollLevel;

		// Token: 0x0401A7A8 RID: 108456
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<TrapDefenseLevelData> OnSelectLevelCallback;

		// Token: 0x0401A7A9 RID: 108457
		[Nullable(2)]
		public TrapDefenseLevelData CurSelectLevel;

		// Token: 0x0401A7AA RID: 108458
		public bool IsInstance;

		// Token: 0x0200AC13 RID: 44051
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403449C RID: 214172
			public const int ItemDifficultyChange = 0;

			// Token: 0x0403449D RID: 214173
			public const int ScrollLevel = 1;

			// Token: 0x0403449E RID: 214174
			public const int ItemLevel = 2;

			// Token: 0x0403449F RID: 214175
			public const int BtnBdSum = 3;

			// Token: 0x040344A0 RID: 214176
			public const int TextBdSumTitle = 4;

			// Token: 0x040344A1 RID: 214177
			public const int ArtTextBdProgress = 5;
		}
	}
}
