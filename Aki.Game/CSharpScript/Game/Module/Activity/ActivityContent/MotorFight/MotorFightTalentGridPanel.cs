using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x02005398 RID: 21400
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightTalentGridPanel : UiPanelBase, IGridProxy<List<MotorFightTalentData>>
	{
		// Token: 0x170067D8 RID: 26584
		// (get) Token: 0x060353E0 RID: 218080 RVA: 0x00EDEF9E File Offset: 0x00EDD19E
		// (set) Token: 0x060353E1 RID: 218081 RVA: 0x00EDEFA6 File Offset: 0x00EDD1A6
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1,
			1,
			1
		})]
		public IScrollViewDelegate<IGridProxy<List<MotorFightTalentData>>, List<MotorFightTalentData>> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1,
			1,
			1,
			1
		})] set; }

		// Token: 0x170067D9 RID: 26585
		// (get) Token: 0x060353E2 RID: 218082 RVA: 0x00EDEFAF File Offset: 0x00EDD1AF
		// (set) Token: 0x060353E3 RID: 218083 RVA: 0x00EDEFB7 File Offset: 0x00EDD1B7
		public int GridIndex { get; set; }

		// Token: 0x170067DA RID: 26586
		// (get) Token: 0x060353E4 RID: 218084 RVA: 0x00EDEFC0 File Offset: 0x00EDD1C0
		// (set) Token: 0x060353E5 RID: 218085 RVA: 0x00EDEFC8 File Offset: 0x00EDD1C8
		public int DisplayIndex { get; set; }

		// Token: 0x060353E6 RID: 218086 RVA: 0x00EDEFD4 File Offset: 0x00EDD1D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060353E7 RID: 218087 RVA: 0x00EDF060 File Offset: 0x00EDD260
		public UniTask RefreshAsync(List<MotorFightTalentData> dataList, bool isSelected, int gridIndex)
		{
			MotorFightTalentGridPanel.<RefreshAsync>d__16 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.dataList = dataList;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<MotorFightTalentGridPanel.<RefreshAsync>d__16>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060353E8 RID: 218088 RVA: 0x00EDF0AB File Offset: 0x00EDD2AB
		public void Clear()
		{
		}

		// Token: 0x060353E9 RID: 218089 RVA: 0x00EDF0AD File Offset: 0x00EDD2AD
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x060353EA RID: 218090 RVA: 0x00EDF0AF File Offset: 0x00EDD2AF
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x060353EB RID: 218091 RVA: 0x00EDF0B1 File Offset: 0x00EDD2B1
		public object GetKey(List<MotorFightTalentData> data, int gridIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x0401C149 RID: 115017
		private readonly List<MotorFightTalentNodeItem> TalentNodeItemList = new List<MotorFightTalentNodeItem>();

		// Token: 0x0401C14D RID: 115021
		public Action<MotorFightTalentNodeItem> OnSelectTalentNode = delegate(MotorFightTalentNodeItem technologyNode)
		{
		};

		// Token: 0x0200B026 RID: 45094
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403670B RID: 222987
			public const int Pos1 = 0;

			// Token: 0x0403670C RID: 222988
			public const int Pos2 = 1;

			// Token: 0x0403670D RID: 222989
			public const int Pos3 = 2;
		}
	}
}
