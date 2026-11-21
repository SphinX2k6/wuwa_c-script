using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059E1 RID: 23009
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolQuestArrowItem : GridProxyAbstract<SolarSchoolQuestArrowItemData>
	{
		// Token: 0x17006C47 RID: 27719
		// (get) Token: 0x06038AB9 RID: 232121 RVA: 0x00FDC6A0 File Offset: 0x00FDA8A0
		// (set) Token: 0x06038ABA RID: 232122 RVA: 0x00FDC6A8 File Offset: 0x00FDA8A8
		[Nullable(2)]
		public Action<int> ClickCallback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x06038ABB RID: 232123 RVA: 0x00FDC6B4 File Offset: 0x00FDA8B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038ABC RID: 232124 RVA: 0x00FDC7A1 File Offset: 0x00FDA9A1
		protected override void OnStart()
		{
			this.Lines = new SolarSchoolQuestLinePlayer(this.RootItem, base.GetItem(2), base.GetItem(3), base.GetItem(4), base.GetItem(5));
		}

		// Token: 0x06038ABD RID: 232125 RVA: 0x00FDC7D0 File Offset: 0x00FDA9D0
		protected override void OnBeforeDestroy()
		{
			SolarSchoolQuestLinePlayer lines = this.Lines;
			if (lines != null)
			{
				lines.Clear();
			}
			this.Lines = null;
		}

		// Token: 0x06038ABE RID: 232126 RVA: 0x00FDC7EC File Offset: 0x00FDA9EC
		public override UniTask RefreshAsync(SolarSchoolQuestArrowItemData data, bool isSelected, int gridIndex)
		{
			SolarSchoolQuestArrowItem.<RefreshAsync>d__15 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<SolarSchoolQuestArrowItem.<RefreshAsync>d__15>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038ABF RID: 232127 RVA: 0x00FDC837 File Offset: 0x00FDAA37
		public override object GetKey(SolarSchoolQuestArrowItemData data, int displayIndex)
		{
			return data.QuestId;
		}

		// Token: 0x06038AC0 RID: 232128 RVA: 0x00FDC844 File Offset: 0x00FDAA44
		[NullableContext(2)]
		public UUIItem GetLocateItem()
		{
			SolarSchoolQuestNodeItemBase nodeItem = this.NodeItem;
			if (nodeItem == null)
			{
				return null;
			}
			return nodeItem.GetRootItem();
		}

		// Token: 0x06038AC1 RID: 232129 RVA: 0x00FDC857 File Offset: 0x00FDAA57
		public bool PreparePresentation(SolarSchoolQuestPresentationState state, SolarSchoolQuestLinePlan linePlan)
		{
			this.LinePlan = linePlan;
			this.Lines.Hide();
			if (this.NodeItem == null)
			{
				return false;
			}
			this.NodeItem.PreparePresentation(state);
			return true;
		}

		// Token: 0x06038AC2 RID: 232130 RVA: 0x00FDC882 File Offset: 0x00FDAA82
		public UniTask PlayExistingLinesAsync()
		{
			return this.Lines.PlayAsync(this.LinePlan.Existing);
		}

		// Token: 0x06038AC3 RID: 232131 RVA: 0x00FDC89A File Offset: 0x00FDAA9A
		public UniTask PlayAppearingLinesAsync()
		{
			return this.Lines.PlayAsync(this.LinePlan.Existing | this.LinePlan.Appearing);
		}

		// Token: 0x06038AC4 RID: 232132 RVA: 0x00FDC8BE File Offset: 0x00FDAABE
		public UniTask PlayNodeAppearAsync()
		{
			return this.NodeItem.PlayAppearAsync();
		}

		// Token: 0x06038AC5 RID: 232133 RVA: 0x00FDC8CB File Offset: 0x00FDAACB
		public UniTask PlayNodeUnlockAsync()
		{
			return this.NodeItem.PlayUnlockAsync();
		}

		// Token: 0x06038AC6 RID: 232134 RVA: 0x00FDC8D8 File Offset: 0x00FDAAD8
		public void StopAnimation()
		{
			SolarSchoolQuestNodeItemBase nodeItem = this.NodeItem;
			if (nodeItem != null)
			{
				nodeItem.StopAnimation();
			}
			SolarSchoolQuestLinePlayer lines = this.Lines;
			if (lines == null)
			{
				return;
			}
			lines.Stop();
		}

		// Token: 0x06038AC7 RID: 232135 RVA: 0x00FDC8FB File Offset: 0x00FDAAFB
		public void RefreshNode()
		{
			if (this.QuestId != 0)
			{
				SolarSchoolQuestNodeItemBase nodeItem = this.NodeItem;
				if (nodeItem == null)
				{
					return;
				}
				nodeItem.RefreshByQuest(this.QuestId);
			}
		}

		// Token: 0x06038AC8 RID: 232136 RVA: 0x00FDC91C File Offset: 0x00FDAB1C
		private UniTask EnsureNodeItemAsync(string resourceId)
		{
			SolarSchoolQuestArrowItem.<EnsureNodeItemAsync>d__25 <EnsureNodeItemAsync>d__;
			<EnsureNodeItemAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<EnsureNodeItemAsync>d__.<>4__this = this;
			<EnsureNodeItemAsync>d__.resourceId = resourceId;
			<EnsureNodeItemAsync>d__.<>1__state = -1;
			<EnsureNodeItemAsync>d__.<>t__builder.Start<SolarSchoolQuestArrowItem.<EnsureNodeItemAsync>d__25>(ref <EnsureNodeItemAsync>d__);
			return <EnsureNodeItemAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038AC9 RID: 232137 RVA: 0x00FDC967 File Offset: 0x00FDAB67
		private string GetNodeResourceId(int showType)
		{
			if (showType != 1)
			{
				return "UiItem_SolarSchoolMissionBig";
			}
			return "UiItem_SolarSchoolMissionSmall";
		}

		// Token: 0x06038ACA RID: 232138 RVA: 0x00FDC978 File Offset: 0x00FDAB78
		private void OnNodeClick(int questId)
		{
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(questId);
		}

		// Token: 0x0401DD85 RID: 122245
		private const string QuestBigResourceId = "UiItem_SolarSchoolMissionBig";

		// Token: 0x0401DD86 RID: 122246
		private const string QuestSmallResourceId = "UiItem_SolarSchoolMissionSmall";

		// Token: 0x0401DD87 RID: 122247
		[Nullable(2)]
		private SolarSchoolQuestNodeItemBase NodeItem;

		// Token: 0x0401DD88 RID: 122248
		private string LoadedResourceId = string.Empty;

		// Token: 0x0401DD89 RID: 122249
		private int QuestId;

		// Token: 0x0401DD8A RID: 122250
		[Nullable(2)]
		private SolarSchoolQuestLinePlayer Lines;

		// Token: 0x0401DD8B RID: 122251
		private SolarSchoolQuestLinePlan LinePlan;

		// Token: 0x0200B58E RID: 46478
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403823A RID: 229946
			public const int PnlRoot = 0;

			// Token: 0x0403823B RID: 229947
			public const int TabLayout = 1;

			// Token: 0x0403823C RID: 229948
			public const int PanelLine = 2;

			// Token: 0x0403823D RID: 229949
			public const int TopLine = 3;

			// Token: 0x0403823E RID: 229950
			public const int MiddleLine = 4;

			// Token: 0x0403823F RID: 229951
			public const int BottomLine = 5;
		}
	}
}
