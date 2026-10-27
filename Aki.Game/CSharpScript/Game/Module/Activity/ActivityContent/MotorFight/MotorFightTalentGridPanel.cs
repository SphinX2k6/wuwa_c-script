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
	// Token: 0x0200641A RID: 25626
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorFightTalentGridPanel : UiPanelBase, IGridProxy<List<MotorFightTalentData>>
	{
		// Token: 0x17009476 RID: 38006
		// (get) Token: 0x0604071F RID: 263967 RVA: 0x00F97FFE File Offset: 0x00F961FE
		// (set) Token: 0x06040720 RID: 263968 RVA: 0x00F98006 File Offset: 0x00F96206
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

		// Token: 0x17009477 RID: 38007
		// (get) Token: 0x06040721 RID: 263969 RVA: 0x00F9800F File Offset: 0x00F9620F
		// (set) Token: 0x06040722 RID: 263970 RVA: 0x00F98017 File Offset: 0x00F96217
		public int GridIndex { get; set; }

		// Token: 0x17009478 RID: 38008
		// (get) Token: 0x06040723 RID: 263971 RVA: 0x00F98020 File Offset: 0x00F96220
		// (set) Token: 0x06040724 RID: 263972 RVA: 0x00F98028 File Offset: 0x00F96228
		public int DisplayIndex { get; set; }

		// Token: 0x06040725 RID: 263973 RVA: 0x00F98034 File Offset: 0x00F96234
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

		// Token: 0x06040726 RID: 263974 RVA: 0x00F980C0 File Offset: 0x00F962C0
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

		// Token: 0x06040727 RID: 263975 RVA: 0x00F9810B File Offset: 0x00F9630B
		public void Clear()
		{
		}

		// Token: 0x06040728 RID: 263976 RVA: 0x00F9810D File Offset: 0x00F9630D
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06040729 RID: 263977 RVA: 0x00F9810F File Offset: 0x00F9630F
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0604072A RID: 263978 RVA: 0x00F98111 File Offset: 0x00F96311
		public object GetKey(List<MotorFightTalentData> data, int gridIndex)
		{
			return this.GridIndex;
		}

		// Token: 0x0402181A RID: 137242
		private readonly List<MotorFightTalentNodeItem> TalentNodeItemList = new List<MotorFightTalentNodeItem>();

		// Token: 0x0402181E RID: 137246
		public Action<MotorFightTalentNodeItem> OnSelectTalentNode = delegate(MotorFightTalentNodeItem technologyNode)
		{
		};

		// Token: 0x0200C63F RID: 50751
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BDAE RID: 245166
			public const int Pos1 = 0;

			// Token: 0x0403BDAF RID: 245167
			public const int Pos2 = 1;

			// Token: 0x0403BDB0 RID: 245168
			public const int Pos3 = 2;
		}
	}
}
