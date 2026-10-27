using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CF2 RID: 23794
	public class BattleSkillSwitchComponent : UiPanelBase
	{
		// Token: 0x0603C40F RID: 246799 RVA: 0x00E6C908 File Offset: 0x00E6AB08
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603C410 RID: 246800 RVA: 0x00E6C9D4 File Offset: 0x00E6ABD4
		protected override void OnStart()
		{
			foreach (Action action in this.OperationMap.Values)
			{
				action();
			}
		}

		// Token: 0x0603C411 RID: 246801 RVA: 0x00E6CA2C File Offset: 0x00E6AC2C
		protected override void OnBeforeDestroy()
		{
			this.OperationMap.Clear();
		}

		// Token: 0x0603C412 RID: 246802 RVA: 0x00E6CA3C File Offset: 0x00E6AC3C
		public void SetComponentActive(bool visibility)
		{
			BattleSkillSwitchComponent.<>c__DisplayClass8_0 CS$<>8__locals1 = new BattleSkillSwitchComponent.<>c__DisplayClass8_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.visibility = visibility;
			if (base.InAsyncLoading())
			{
				this.OperationMap["SetActive"] = new Action(CS$<>8__locals1.<SetComponentActive>g__Callback|0);
				return;
			}
			CS$<>8__locals1.<SetComponentActive>g__Callback|0();
		}

		// Token: 0x0603C413 RID: 246803 RVA: 0x00E6CA88 File Offset: 0x00E6AC88
		public void RefreshSwitch()
		{
			if (base.InAsyncLoading())
			{
				this.OperationMap["RefreshComponent"] = new Action(this.<RefreshSwitch>g__Callback|9_0);
				return;
			}
			this.<RefreshSwitch>g__Callback|9_0();
		}

		// Token: 0x0603C414 RID: 246804 RVA: 0x00E6CAB8 File Offset: 0x00E6ACB8
		public void UpdateSwitch(int index)
		{
			BattleSkillSwitchComponent.<>c__DisplayClass10_0 CS$<>8__locals1 = new BattleSkillSwitchComponent.<>c__DisplayClass10_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.index = index;
			int? switchIndex = this.SwitchIndex;
			int index2 = CS$<>8__locals1.index;
			if (switchIndex.GetValueOrDefault() == index2 & switchIndex != null)
			{
				return;
			}
			if (CS$<>8__locals1.index >= BattleSkillSwitchComponent.RotatorAngles.Length)
			{
				return;
			}
			if (base.InAsyncLoading())
			{
				this.OperationMap["UpdateSwitch"] = new Action(CS$<>8__locals1.<UpdateSwitch>g__Callback|0);
				return;
			}
			CS$<>8__locals1.<UpdateSwitch>g__Callback|0();
		}

		// Token: 0x0603C415 RID: 246805 RVA: 0x00E6CB38 File Offset: 0x00E6AD38
		public void UpdateNumPanel(bool bVisible, int? num = null)
		{
			BattleSkillSwitchComponent.<>c__DisplayClass11_0 CS$<>8__locals1 = new BattleSkillSwitchComponent.<>c__DisplayClass11_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.bVisible = bVisible;
			CS$<>8__locals1.num = num;
			if (base.InAsyncLoading())
			{
				this.OperationMap["UpdateNumPanel"] = new Action(CS$<>8__locals1.<UpdateNumPanel>g__Callback|0);
				return;
			}
			CS$<>8__locals1.<UpdateNumPanel>g__Callback|0();
		}

		// Token: 0x0603C416 RID: 246806 RVA: 0x00E6CB8C File Offset: 0x00E6AD8C
		public void UpdatePointPanel(bool bVisible, int? totalNum = null, int? setNum = null)
		{
			BattleSkillSwitchComponent.<>c__DisplayClass12_0 CS$<>8__locals1 = new BattleSkillSwitchComponent.<>c__DisplayClass12_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.bVisible = bVisible;
			CS$<>8__locals1.totalNum = totalNum;
			CS$<>8__locals1.setNum = setNum;
			if (base.InAsyncLoading())
			{
				this.OperationMap["UpdatePointPanel"] = new Action(CS$<>8__locals1.<UpdatePointPanel>g__Callback|0);
				return;
			}
			CS$<>8__locals1.<UpdatePointPanel>g__Callback|0();
		}

		// Token: 0x0603C419 RID: 246809 RVA: 0x00E6CC14 File Offset: 0x00E6AE14
		[CompilerGenerated]
		private void <RefreshSwitch>g__Callback|9_0()
		{
			int currentExploreSkillId = RouletteModel.Instance.CurrentExploreSkillId;
			int index = RouletteModel.Instance.GetCurrentExploreRouletteListData().GetRouletteIdList().IndexOf(currentExploreSkillId);
			if (currentExploreSkillId == 3002 || currentExploreSkillId == 3001)
			{
				this.UpdateSwitch(7);
				return;
			}
			this.UpdateSwitch(index);
		}

		// Token: 0x0401F662 RID: 128610
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly int[] RotatorAngles = new int[]
		{
			135,
			90,
			45,
			0,
			-45,
			-90,
			-135,
			-180
		};

		// Token: 0x0401F663 RID: 128611
		private const int ITEM_ANGLE_INDEX = 7;

		// Token: 0x0401F664 RID: 128612
		private int? SwitchIndex;

		// Token: 0x0401F665 RID: 128613
		[Nullable(1)]
		private readonly Dictionary<string, Action> OperationMap = new Dictionary<string, Action>();

		// Token: 0x0200BF51 RID: 48977
		private enum ESkillNumItem
		{
			// Token: 0x04039B38 RID: 236344
			ArrowSprite,
			// Token: 0x04039B39 RID: 236345
			PanelNum,
			// Token: 0x04039B3A RID: 236346
			TextNum,
			// Token: 0x04039B3B RID: 236347
			ItemTimesRoot,
			// Token: 0x04039B3C RID: 236348
			TxtTimes
		}
	}
}
