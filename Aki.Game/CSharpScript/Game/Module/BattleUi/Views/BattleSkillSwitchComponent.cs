using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CD4 RID: 19668
	public class BattleSkillSwitchComponent : UiPanelBase
	{
		// Token: 0x06031365 RID: 201573 RVA: 0x00DBCEBC File Offset: 0x00DBB0BC
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

		// Token: 0x06031366 RID: 201574 RVA: 0x00DBCF88 File Offset: 0x00DBB188
		protected override void OnStart()
		{
			foreach (Action action in this.OperationMap.Values)
			{
				action();
			}
		}

		// Token: 0x06031367 RID: 201575 RVA: 0x00DBCFE0 File Offset: 0x00DBB1E0
		protected override void OnBeforeDestroy()
		{
			this.OperationMap.Clear();
		}

		// Token: 0x06031368 RID: 201576 RVA: 0x00DBCFF0 File Offset: 0x00DBB1F0
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

		// Token: 0x06031369 RID: 201577 RVA: 0x00DBD03C File Offset: 0x00DBB23C
		public void RefreshSwitch()
		{
			if (base.InAsyncLoading())
			{
				this.OperationMap["RefreshComponent"] = new Action(this.<RefreshSwitch>g__Callback|9_0);
				return;
			}
			this.<RefreshSwitch>g__Callback|9_0();
		}

		// Token: 0x0603136A RID: 201578 RVA: 0x00DBD06C File Offset: 0x00DBB26C
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

		// Token: 0x0603136B RID: 201579 RVA: 0x00DBD0EC File Offset: 0x00DBB2EC
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

		// Token: 0x0603136C RID: 201580 RVA: 0x00DBD140 File Offset: 0x00DBB340
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

		// Token: 0x0603136F RID: 201583 RVA: 0x00DBD1C8 File Offset: 0x00DBB3C8
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

		// Token: 0x0401A11B RID: 106779
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

		// Token: 0x0401A11C RID: 106780
		private const int ITEM_ANGLE_INDEX = 7;

		// Token: 0x0401A11D RID: 106781
		private int? SwitchIndex;

		// Token: 0x0401A11E RID: 106782
		[Nullable(1)]
		private readonly Dictionary<string, Action> OperationMap = new Dictionary<string, Action>();

		// Token: 0x0200A957 RID: 43351
		private enum ESkillNumItem
		{
			// Token: 0x040344FA RID: 214266
			ArrowSprite,
			// Token: 0x040344FB RID: 214267
			PanelNum,
			// Token: 0x040344FC RID: 214268
			TextNum,
			// Token: 0x040344FD RID: 214269
			ItemTimesRoot,
			// Token: 0x040344FE RID: 214270
			TxtTimes
		}
	}
}
