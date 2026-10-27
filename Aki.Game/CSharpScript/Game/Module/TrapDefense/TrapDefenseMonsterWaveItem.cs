using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AC6 RID: 19142
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseMonsterWaveItem : GridProxyAbstract<TrapDefenseMonsterWaveData>, IDynamicScrollItem<TrapDefenseMonsterWaveData>
	{
		// Token: 0x06031970 RID: 203120 RVA: 0x00B7FD50 File Offset: 0x00B7DF50
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUILayoutBase));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031971 RID: 203121 RVA: 0x00B7FF2C File Offset: 0x00B7E12C
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseMonsterWaveItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseMonsterWaveItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031972 RID: 203122 RVA: 0x00B7FF70 File Offset: 0x00B7E170
		public override UniTask RefreshAsync(TrapDefenseMonsterWaveData data, bool isSelected, int gridIndex)
		{
			TrapDefenseMonsterWaveItem.<RefreshAsync>d__9 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<TrapDefenseMonsterWaveItem.<RefreshAsync>d__9>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031973 RID: 203123 RVA: 0x00B7FFBB File Offset: 0x00B7E1BB
		public TrapDefenseMonsterItem CreateItemMonster()
		{
			return new TrapDefenseMonsterItem(true)
			{
				OnSelectMonsterItemCallback = new Action<TrapDefenseMonsterData>(this.OnSelectMonsterItem),
				OnShowNumCallback = new Func<TrapDefenseMonsterData, string>(this.GetMonsterInTheWaveShowNum)
			};
		}

		// Token: 0x06031974 RID: 203124 RVA: 0x00B7FFE7 File Offset: 0x00B7E1E7
		public override void OnSelected(bool isSelected)
		{
			if (!this.IsFireForBuffClick)
			{
				this.LayoutMonster.SelectGridProxy(Math.Max(this.LastSelectMonsterIndex, 0), false);
			}
		}

		// Token: 0x06031975 RID: 203125 RVA: 0x00B80009 File Offset: 0x00B7E209
		public override void OnDeselected(bool isSelected)
		{
			this.LayoutMonster.DeselectCurrentGridProxy();
		}

		// Token: 0x06031976 RID: 203126 RVA: 0x00B80018 File Offset: 0x00B7E218
		private void OnSelectMonsterItem(TrapDefenseMonsterData data)
		{
			this.IsFireForBuffClick = true;
			IScrollViewDelegate<IGridProxy<TrapDefenseMonsterWaveData>, TrapDefenseMonsterWaveData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate != null)
			{
				scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
			}
			Action<TrapDefenseMonsterData, TrapDefenseMonsterWaveData> onSelectMonsterCallBack = this.OnSelectMonsterCallBack;
			if (onSelectMonsterCallBack != null)
			{
				onSelectMonsterCallBack(data, this.ItemData);
			}
			this.IsFireForBuffClick = false;
		}

		// Token: 0x06031977 RID: 203127 RVA: 0x00B8006C File Offset: 0x00B7E26C
		public string GetMonsterInTheWaveShowNum(TrapDefenseMonsterData data)
		{
			int monsterNum = this.ItemData.GetMonsterNum(data);
			if (monsterNum <= 1)
			{
				return "";
			}
			string multiText = TextConfig.Instance.GetMultiText(ETrapDefenseTextKey.XValueShow.ToString(), new string[]
			{
				monsterNum.ToString()
			});
			if (string.IsNullOrEmpty(multiText))
			{
				return monsterNum.ToString();
			}
			return multiText;
		}

		// Token: 0x06031978 RID: 203128 RVA: 0x00B800CC File Offset: 0x00B7E2CC
		public AUIBaseActor GetUsingItem(TrapDefenseMonsterWaveData data)
		{
			UUIItem item = base.GetItem(10);
			return ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
		}

		// Token: 0x06031979 RID: 203129 RVA: 0x00B800E8 File Offset: 0x00B7E2E8
		public void Update(TrapDefenseMonsterWaveData data, int index)
		{
			if (this.ItemData == data)
			{
				this.UpdateSelectState();
				return;
			}
			this.ItemData = data;
			bool flag = data.IsInTheCurrentWave();
			bool flag2 = data.IsFinish();
			UUIArtText artText = base.GetArtText(2);
			UUIText text = base.GetText(3);
			if (artText != null)
			{
				artText.SetText(data.GetWaveFormat(2));
			}
			if (artText != null)
			{
				UUIItem uuiitem = artText;
				bool bUseChangeColor = flag;
				FColor? fcolor = new FColor?(artText.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
			if (text != null)
			{
				UUIItem uuiitem2 = text;
				bool bUseChangeColor2 = flag;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
			}
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetAlpha(flag2 ? 0.5f : 1f);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(flag2);
			}
			UUIItem item3 = base.GetItem(0);
			if (item3 != null)
			{
				item3.SetUIActive(!flag);
			}
			UUIItem item4 = base.GetItem(1);
			if (item4 != null)
			{
				item4.SetUIActive(flag);
			}
			string enhanceTipsInfoKey = data.GetEnhanceTipsInfoKey();
			bool flag3 = !string.IsNullOrEmpty(enhanceTipsInfoKey);
			UUIItem item5 = base.GetItem(5);
			if (item5 != null)
			{
				item5.SetUIActive(flag3);
			}
			if (flag3)
			{
				UUIText text2 = base.GetText(6);
				if (text2 != null)
				{
					text2.ShowTextNew(enhanceTipsInfoKey);
				}
			}
			this.EndlessItem.SetActive(data.IsEndlessStart);
			if (data.IsEndlessStart)
			{
				this.EndlessItem.UpdateDescKey(data.EndlessWaveDesc ?? data.Wave.ToString());
			}
			List<TrapDefenseMonsterData> monsterDataList = data.GetMonsterDataList();
			this.LayoutMonster.RefreshByData(monsterDataList, new Action(this.UpdateSelectState), true);
		}

		// Token: 0x0603197A RID: 203130 RVA: 0x00B80265 File Offset: 0x00B7E465
		public void UpdateSelectState()
		{
			GenericLayout<TrapDefenseMonsterItem, TrapDefenseMonsterData> layoutMonster = this.LayoutMonster;
			if (layoutMonster == null)
			{
				return;
			}
			layoutMonster.GetLayoutItemList().ForEach(delegate(TrapDefenseMonsterItem item)
			{
				item.CheckWaveUpdate(this.ItemData);
			});
		}

		// Token: 0x0603197B RID: 203131 RVA: 0x00B80288 File Offset: 0x00B7E488
		public UniTask Init(UUIItem actor)
		{
			TrapDefenseMonsterWaveItem.<Init>d__18 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<TrapDefenseMonsterWaveItem.<Init>d__18>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0603197C RID: 203132 RVA: 0x00B802D3 File Offset: 0x00B7E4D3
		public void ClearItem()
		{
		}

		// Token: 0x0401A7F3 RID: 108531
		public TrapDefenseMonsterWaveData ItemData;

		// Token: 0x0401A7F4 RID: 108532
		public Action<TrapDefenseMonsterWaveData> ClickCallBack;

		// Token: 0x0401A7F5 RID: 108533
		public Action<TrapDefenseMonsterData, TrapDefenseMonsterWaveData> OnSelectMonsterCallBack;

		// Token: 0x0401A7F6 RID: 108534
		public GenericLayout<TrapDefenseMonsterItem, TrapDefenseMonsterData> LayoutMonster;

		// Token: 0x0401A7F7 RID: 108535
		public TrapDefenseMonsterEndlessWaveItem EndlessItem;

		// Token: 0x0401A7F8 RID: 108536
		public int LastSelectMonsterIndex = -1;

		// Token: 0x0401A7F9 RID: 108537
		public bool IsFireForBuffClick;
	}
}
