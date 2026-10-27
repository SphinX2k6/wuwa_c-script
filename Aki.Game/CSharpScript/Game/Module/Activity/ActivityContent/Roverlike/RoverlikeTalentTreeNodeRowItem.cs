using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020061A7 RID: 24999
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeTalentTreeNodeRowItem : GridProxyAbstract<RoverlikeTalentTreeNodeRowData>
	{
		// Token: 0x17009208 RID: 37384
		// (get) Token: 0x0603F235 RID: 258613 RVA: 0x00F40A83 File Offset: 0x00F3EC83
		[Nullable(2)]
		private RoverlikeTalentTreeData TreeData
		{
			[NullableContext(2)]
			get
			{
				RoverlikeActivityData currentActivityData = RoverlikeActivityController.Instance.GetCurrentActivityData();
				if (currentActivityData == null)
				{
					return null;
				}
				return currentActivityData.TalentTreeData;
			}
		}

		// Token: 0x0603F236 RID: 258614 RVA: 0x00F40A9C File Offset: 0x00F3EC9C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603F237 RID: 258615 RVA: 0x00F40B08 File Offset: 0x00F3ED08
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeTalentTreeNodeRowItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeTalentTreeNodeRowItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F238 RID: 258616 RVA: 0x00F40B4B File Offset: 0x00F3ED4B
		public override void Refresh(RoverlikeTalentTreeNodeRowData data, bool isSelected, int gridIndex)
		{
			this.RefreshVersion++;
			this.RefreshInternalAsync(data, this.RefreshVersion).Forget();
		}

		// Token: 0x0603F239 RID: 258617 RVA: 0x00F40B70 File Offset: 0x00F3ED70
		public override UniTask RefreshAsync(RoverlikeTalentTreeNodeRowData data, bool isSelected, int gridIndex)
		{
			RoverlikeTalentTreeNodeRowItem.<RefreshAsync>d__9 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<RoverlikeTalentTreeNodeRowItem.<RefreshAsync>d__9>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F23A RID: 258618 RVA: 0x00F40BBC File Offset: 0x00F3EDBC
		private UniTask RefreshInternalAsync(RoverlikeTalentTreeNodeRowData data, int version)
		{
			RoverlikeTalentTreeNodeRowItem.<RefreshInternalAsync>d__10 <RefreshInternalAsync>d__;
			<RefreshInternalAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshInternalAsync>d__.<>4__this = this;
			<RefreshInternalAsync>d__.data = data;
			<RefreshInternalAsync>d__.version = version;
			<RefreshInternalAsync>d__.<>1__state = -1;
			<RefreshInternalAsync>d__.<>t__builder.Start<RoverlikeTalentTreeNodeRowItem.<RefreshInternalAsync>d__10>(ref <RefreshInternalAsync>d__);
			return <RefreshInternalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F23B RID: 258619 RVA: 0x00F40C0F File Offset: 0x00F3EE0F
		public override object GetKey(RoverlikeTalentTreeNodeRowData data, int displayIndex)
		{
			return data.Row;
		}

		// Token: 0x0603F23C RID: 258620 RVA: 0x00F40C1C File Offset: 0x00F3EE1C
		private void ResetAllLines()
		{
			foreach (UUIItem uuiitem in this.LineList.GetAllLines())
			{
				uuiitem.SetUIActive(false);
			}
			foreach (UUIItem uuiitem2 in this.NodeList.GetAllLines())
			{
				uuiitem2.SetUIActive(false);
			}
		}

		// Token: 0x0603F23D RID: 258621 RVA: 0x00F40CB8 File Offset: 0x00F3EEB8
		private void ResetAllNodes()
		{
			for (int i = 0; i < 6; i++)
			{
				RoverlikeTalentTreeNodeItem nodeItem = this.NodeList.GetNodeItem(i);
				if (nodeItem != null)
				{
					nodeItem.SetNodeActive(false);
				}
			}
		}

		// Token: 0x0603F23E RID: 258622 RVA: 0x00F40CEC File Offset: 0x00F3EEEC
		private void RefreshAllDots()
		{
			foreach (UUIItem uuiitem in this.LineList.GetAllDots())
			{
				uuiitem.SetUIActive(false);
			}
		}

		// Token: 0x0603F23F RID: 258623 RVA: 0x00F40D44 File Offset: 0x00F3EF44
		[NullableContext(2)]
		private UUIItem GetSolidLineByIndex(int index)
		{
			return this.LineList.GetSolidLineByIndexInLineId(index) ?? this.NodeList.GetSolidLineByIndexInLineId(index);
		}

		// Token: 0x0603F240 RID: 258624 RVA: 0x00F40D62 File Offset: 0x00F3EF62
		[NullableContext(2)]
		private UUIItem GetDashedLineByIndex(int index)
		{
			return this.LineList.GetDashedLineByIndexInLineId(index) ?? this.NodeList.GetDashedLineByIndexInLineId(index);
		}

		// Token: 0x04020EA0 RID: 134816
		private RoverlikeTalentTreeNodeGroupItem NodeList;

		// Token: 0x04020EA1 RID: 134817
		private RoverlikeTalentTreeLineGroupItem LineList;

		// Token: 0x04020EA2 RID: 134818
		private int RefreshVersion;

		// Token: 0x0200C3F5 RID: 50165
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403B245 RID: 242245
			public const int ItemNodeList = 0;

			// Token: 0x0403B246 RID: 242246
			public const int ItemLineList = 1;
		}
	}
}
