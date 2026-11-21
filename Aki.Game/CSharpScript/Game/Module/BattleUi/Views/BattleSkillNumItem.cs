using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CD0 RID: 19664
	public class BattleSkillNumItem : UiPanelBase
	{
		// Token: 0x0603133D RID: 201533 RVA: 0x00DBC493 File Offset: 0x00DBA693
		[NullableContext(1)]
		public BattleSkillNumItem(UUIItem rootUiItem)
		{
			base.CreateByResourceIdAsync("UiItem_BattleSkillNumItem", rootUiItem, false).Forget();
		}

		// Token: 0x0603133E RID: 201534 RVA: 0x00DBC4C0 File Offset: 0x00DBA6C0
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

		// Token: 0x0603133F RID: 201535 RVA: 0x00DBC52C File Offset: 0x00DBA72C
		protected override void OnStart()
		{
			foreach (Action action in this.OperationMap.Values)
			{
				action();
			}
		}

		// Token: 0x06031340 RID: 201536 RVA: 0x00DBC584 File Offset: 0x00DBA784
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

		// Token: 0x06031341 RID: 201537 RVA: 0x00DBC5DC File Offset: 0x00DBA7DC
		public void SetTotalCount(int count)
		{
		}

		// Token: 0x06031342 RID: 201538 RVA: 0x00DBC5E0 File Offset: 0x00DBA7E0
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

		// Token: 0x06031343 RID: 201539 RVA: 0x00DBC62C File Offset: 0x00DBA82C
		public void RefreshCountType(int totalUseCount)
		{
		}

		// Token: 0x06031344 RID: 201540 RVA: 0x00DBC62E File Offset: 0x00DBA82E
		public void RefreshTotalCount(int totalLimitUseCount)
		{
		}

		// Token: 0x0401A10A RID: 106762
		private int RemainingUseCount = -1;

		// Token: 0x0401A10B RID: 106763
		public bool TargetActive;

		// Token: 0x0401A10C RID: 106764
		[Nullable(1)]
		private readonly Dictionary<string, Action> OperationMap = new Dictionary<string, Action>();

		// Token: 0x0200A950 RID: 43344
		private enum ESkillNumItem
		{
			// Token: 0x040344E7 RID: 214247
			BgSprite,
			// Token: 0x040344E8 RID: 214248
			NumText
		}
	}
}
