using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CEE RID: 23790
	public class BattleSkillNumItem : UiPanelBase
	{
		// Token: 0x0603C3E7 RID: 246759 RVA: 0x00E6BEDF File Offset: 0x00E6A0DF
		[NullableContext(1)]
		public BattleSkillNumItem(UUIItem rootUiItem)
		{
			base.CreateByResourceIdAsync("UiItem_BattleSkillNumItem", rootUiItem, false).Forget();
		}

		// Token: 0x0603C3E8 RID: 246760 RVA: 0x00E6BF0C File Offset: 0x00E6A10C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C3E9 RID: 246761 RVA: 0x00E6BF78 File Offset: 0x00E6A178
		protected override void OnStart()
		{
			foreach (Action action in this.OperationMap.Values)
			{
				action();
			}
		}

		// Token: 0x0603C3EA RID: 246762 RVA: 0x00E6BFD0 File Offset: 0x00E6A1D0
		public void SetComponentActive(bool visibility)
		{
			BattleSkillNumItem.<>c__DisplayClass7_0 CS$<>8__locals1 = new BattleSkillNumItem.<>c__DisplayClass7_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.visibility = visibility;
			this.TargetActive = CS$<>8__locals1.visibility;
			if (base.InAsyncLoading())
			{
				this.OperationMap["SetActive"] = new Action(CS$<>8__locals1.<SetComponentActive>g__Callback|0);
				return;
			}
			CS$<>8__locals1.<SetComponentActive>g__Callback|0();
		}

		// Token: 0x0603C3EB RID: 246763 RVA: 0x00E6C028 File Offset: 0x00E6A228
		public void SetTotalCount(int count)
		{
		}

		// Token: 0x0603C3EC RID: 246764 RVA: 0x00E6C02C File Offset: 0x00E6A22C
		public void SetRemainingCount(int remainingUseCount)
		{
			BattleSkillNumItem.<>c__DisplayClass9_0 CS$<>8__locals1 = new BattleSkillNumItem.<>c__DisplayClass9_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.remainingUseCount = remainingUseCount;
			if (base.InAsyncLoading())
			{
				this.OperationMap["SetRemainingCount"] = new Action(CS$<>8__locals1.<SetRemainingCount>g__Callback|0);
				return;
			}
			CS$<>8__locals1.<SetRemainingCount>g__Callback|0();
		}

		// Token: 0x0603C3ED RID: 246765 RVA: 0x00E6C078 File Offset: 0x00E6A278
		public void RefreshCountType(int totalUseCount)
		{
		}

		// Token: 0x0603C3EE RID: 246766 RVA: 0x00E6C07A File Offset: 0x00E6A27A
		public void RefreshTotalCount(int totalLimitUseCount)
		{
		}

		// Token: 0x0401F651 RID: 128593
		private int RemainingUseCount = -1;

		// Token: 0x0401F652 RID: 128594
		public bool TargetActive;

		// Token: 0x0401F653 RID: 128595
		[Nullable(1)]
		private readonly Dictionary<string, Action> OperationMap = new Dictionary<string, Action>();

		// Token: 0x0200BF4A RID: 48970
		private enum ESkillNumItem
		{
			// Token: 0x04039B25 RID: 236325
			BgSprite,
			// Token: 0x04039B26 RID: 236326
			NumText
		}
	}
}
