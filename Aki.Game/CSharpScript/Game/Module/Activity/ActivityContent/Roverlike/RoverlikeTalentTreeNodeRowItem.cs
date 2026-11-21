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
	// Token: 0x02005125 RID: 20773
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoverlikeTalentTreeNodeRowItem : GridProxyAbstract<RoverlikeTalentTreeNodeRowData>
	{
		// Token: 0x1700656A RID: 25962
		// (get) Token: 0x06033EF5 RID: 212725 RVA: 0x00E8794B File Offset: 0x00E85B4B
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

		// Token: 0x06033EF6 RID: 212726 RVA: 0x00E87964 File Offset: 0x00E85B64
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

		// Token: 0x06033EF7 RID: 212727 RVA: 0x00E879D0 File Offset: 0x00E85BD0
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeTalentTreeNodeRowItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeTalentTreeNodeRowItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033EF8 RID: 212728 RVA: 0x00E87A13 File Offset: 0x00E85C13
		public override void Refresh(RoverlikeTalentTreeNodeRowData data, bool isSelected, int gridIndex)
		{
			this.RefreshVersion++;
			this.RefreshInternalAsync(data, this.RefreshVersion).Forget();
		}

		// Token: 0x06033EF9 RID: 212729 RVA: 0x00E87A38 File Offset: 0x00E85C38
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

		// Token: 0x06033EFA RID: 212730 RVA: 0x00E87A84 File Offset: 0x00E85C84
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

		// Token: 0x06033EFB RID: 212731 RVA: 0x00E87AD7 File Offset: 0x00E85CD7
		public override object GetKey(RoverlikeTalentTreeNodeRowData data, int displayIndex)
		{
			return data.Row;
		}

		// Token: 0x06033EFC RID: 212732 RVA: 0x00E87AE4 File Offset: 0x00E85CE4
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

		// Token: 0x06033EFD RID: 212733 RVA: 0x00E87B80 File Offset: 0x00E85D80
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

		// Token: 0x06033EFE RID: 212734 RVA: 0x00E87BB4 File Offset: 0x00E85DB4
		private void RefreshAllDots()
		{
			foreach (UUIItem uuiitem in this.LineList.GetAllDots())
			{
				uuiitem.SetUIActive(false);
			}
		}

		// Token: 0x06033EFF RID: 212735 RVA: 0x00E87C0C File Offset: 0x00E85E0C
		[NullableContext(2)]
		private UUIItem GetSolidLineByIndex(int index)
		{
			return this.LineList.GetSolidLineByIndexInLineId(index) ?? this.NodeList.GetSolidLineByIndexInLineId(index);
		}

		// Token: 0x06033F00 RID: 212736 RVA: 0x00E87C2A File Offset: 0x00E85E2A
		[NullableContext(2)]
		private UUIItem GetDashedLineByIndex(int index)
		{
			return this.LineList.GetDashedLineByIndexInLineId(index) ?? this.NodeList.GetDashedLineByIndexInLineId(index);
		}

		// Token: 0x0401B7CD RID: 112589
		private RoverlikeTalentTreeNodeGroupItem NodeList;

		// Token: 0x0401B7CE RID: 112590
		private RoverlikeTalentTreeLineGroupItem LineList;

		// Token: 0x0401B7CF RID: 112591
		private int RefreshVersion;

		// Token: 0x0200ADDC RID: 44508
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04035BA6 RID: 220070
			public const int ItemNodeList = 0;

			// Token: 0x04035BA7 RID: 220071
			public const int ItemLineList = 1;
		}
	}
}
