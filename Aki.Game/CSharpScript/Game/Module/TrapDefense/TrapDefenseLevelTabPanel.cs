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
	// Token: 0x02003A5B RID: 14939
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class TrapDefenseLevelTabPanel<[Nullable(0)] TLevelModeData> : UiPanelBase where TLevelModeData : ITrapDefenseLevelModeData<TrapDefenseLevelModeDataBase>
	{
		// Token: 0x06026655 RID: 157269 RVA: 0x00AC14C0 File Offset: 0x00ABF6C0
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

		// Token: 0x06026656 RID: 157270 RVA: 0x00AC150C File Offset: 0x00ABF70C
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

		// Token: 0x06026657 RID: 157271 RVA: 0x00AC1638 File Offset: 0x00ABF838
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseLevelTabPanel<TLevelModeData>.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseLevelTabPanel<TLevelModeData>.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026658 RID: 157272 RVA: 0x00AC167C File Offset: 0x00ABF87C
		public void OnClickBtnBdSum()
		{
			TrapDefenseModel.Instance.OpenViewBdSum(new bool?(this.IsInstance), new ETrapDefenseBdTabType?(ETrapDefenseBdTabType.BdProgress), null);
		}

		// Token: 0x06026659 RID: 157273 RVA: 0x00AC16AD File Offset: 0x00ABF8AD
		public TrapDefenseLevelItem CreateItemLevel()
		{
			return new TrapDefenseLevelItem
			{
				OnSelectLevelCallBack = new Action<TrapDefenseLevelItem>(this.SelectLevelItem)
			};
		}

		// Token: 0x0602665A RID: 157274 RVA: 0x00AC16C8 File Offset: 0x00ABF8C8
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

		// Token: 0x0602665B RID: 157275 RVA: 0x00AC16F4 File Offset: 0x00ABF8F4
		public void InitSelectLevel(TrapDefenseLevelData data)
		{
			this.CurSelectLevel = data;
		}

		// Token: 0x0602665C RID: 157276 RVA: 0x00AC1700 File Offset: 0x00ABF900
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

		// Token: 0x0602665D RID: 157277 RVA: 0x00AC1774 File Offset: 0x00ABF974
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

		// Token: 0x0602665E RID: 157278 RVA: 0x00AC17D4 File Offset: 0x00ABF9D4
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

		// Token: 0x0602665F RID: 157279
		public abstract void UpdateModeData();

		// Token: 0x040150F7 RID: 86263
		public TLevelModeData ModeData;

		// Token: 0x040150F8 RID: 86264
		public TrapDefenseDifficultyChangePanel PanelDifficultyChange;

		// Token: 0x040150F9 RID: 86265
		public GenericScrollViewNew<TrapDefenseLevelItem, TrapDefenseLevelData> ScrollLevel;

		// Token: 0x040150FA RID: 86266
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<TrapDefenseLevelData> OnSelectLevelCallback;

		// Token: 0x040150FB RID: 86267
		[Nullable(2)]
		public TrapDefenseLevelData CurSelectLevel;

		// Token: 0x040150FC RID: 86268
		public bool IsInstance;

		// Token: 0x02009633 RID: 38451
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EE4D RID: 192077
			public const int ItemDifficultyChange = 0;

			// Token: 0x0402EE4E RID: 192078
			public const int ScrollLevel = 1;

			// Token: 0x0402EE4F RID: 192079
			public const int ItemLevel = 2;

			// Token: 0x0402EE50 RID: 192080
			public const int BtnBdSum = 3;

			// Token: 0x0402EE51 RID: 192081
			public const int TextBdSumTitle = 4;

			// Token: 0x0402EE52 RID: 192082
			public const int ArtTextBdProgress = 5;
		}
	}
}
