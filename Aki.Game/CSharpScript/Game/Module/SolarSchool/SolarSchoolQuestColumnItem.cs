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
	// Token: 0x020059E4 RID: 23012
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolQuestColumnItem : GridProxyAbstract<SolarSchoolQuestColumnData>
	{
		// Token: 0x17006C48 RID: 27720
		// (get) Token: 0x06038ADD RID: 232157 RVA: 0x00FDD211 File Offset: 0x00FDB411
		// (set) Token: 0x06038ADE RID: 232158 RVA: 0x00FDD219 File Offset: 0x00FDB419
		public Action<int> ClickCallback { get; set; }

		// Token: 0x06038ADF RID: 232159 RVA: 0x00FDD224 File Offset: 0x00FDB424
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038AE0 RID: 232160 RVA: 0x00FDD290 File Offset: 0x00FDB490
		protected override void OnStart()
		{
			UUIVerticalLayout verticalLayout = base.GetVerticalLayout(0);
			UUIItem item = base.GetItem(1);
			AUIBaseActor auibaseActor = ((item != null) ? item.GetOwner() : null) as AUIBaseActor;
			if (verticalLayout == null || auibaseActor == null)
			{
				return;
			}
			this.ArrowLayout = new GenericLayout<SolarSchoolQuestArrowItem, SolarSchoolQuestArrowItemData>(verticalLayout, new Func<SolarSchoolQuestArrowItem>(this.CreateQuestArrowItem), auibaseActor, true, true);
		}

		// Token: 0x06038AE1 RID: 232161 RVA: 0x00FDD2E0 File Offset: 0x00FDB4E0
		[NullableContext(1)]
		public override UniTask RefreshAsync(SolarSchoolQuestColumnData data, bool isSelected, int gridIndex)
		{
			SolarSchoolQuestColumnItem.<RefreshAsync>d__8 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<SolarSchoolQuestColumnItem.<RefreshAsync>d__8>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038AE2 RID: 232162 RVA: 0x00FDD32B File Offset: 0x00FDB52B
		[NullableContext(1)]
		public override object GetKey(SolarSchoolQuestColumnData data, int displayIndex)
		{
			return displayIndex;
		}

		// Token: 0x06038AE3 RID: 232163 RVA: 0x00FDD333 File Offset: 0x00FDB533
		public UUIItem FindArrowItem(int questId)
		{
			GenericLayout<SolarSchoolQuestArrowItem, SolarSchoolQuestArrowItemData> arrowLayout = this.ArrowLayout;
			if (arrowLayout == null)
			{
				return null;
			}
			SolarSchoolQuestArrowItem layoutItemByKey = arrowLayout.GetLayoutItemByKey(questId);
			if (layoutItemByKey == null)
			{
				return null;
			}
			return layoutItemByKey.GetLocateItem();
		}

		// Token: 0x06038AE4 RID: 232164 RVA: 0x00FDD357 File Offset: 0x00FDB557
		public SolarSchoolQuestArrowItem FindArrow(int questId)
		{
			GenericLayout<SolarSchoolQuestArrowItem, SolarSchoolQuestArrowItemData> arrowLayout = this.ArrowLayout;
			if (arrowLayout == null)
			{
				return null;
			}
			return arrowLayout.GetLayoutItemByKey(questId);
		}

		// Token: 0x06038AE5 RID: 232165 RVA: 0x00FDD370 File Offset: 0x00FDB570
		public void StopAnimations()
		{
			if (this.ArrowLayout == null)
			{
				return;
			}
			foreach (SolarSchoolQuestArrowItem solarSchoolQuestArrowItem in this.ArrowLayout.GetLayoutItemList())
			{
				solarSchoolQuestArrowItem.StopAnimation();
			}
		}

		// Token: 0x06038AE6 RID: 232166 RVA: 0x00FDD3D0 File Offset: 0x00FDB5D0
		public bool TryRefreshQuest(int questId)
		{
			GenericLayout<SolarSchoolQuestArrowItem, SolarSchoolQuestArrowItemData> arrowLayout = this.ArrowLayout;
			SolarSchoolQuestArrowItem solarSchoolQuestArrowItem = (arrowLayout != null) ? arrowLayout.GetLayoutItemByKey(questId) : null;
			if (solarSchoolQuestArrowItem == null)
			{
				return false;
			}
			solarSchoolQuestArrowItem.RefreshNode();
			return true;
		}

		// Token: 0x06038AE7 RID: 232167 RVA: 0x00FDD402 File Offset: 0x00FDB602
		[NullableContext(1)]
		private SolarSchoolQuestArrowItem CreateQuestArrowItem()
		{
			return new SolarSchoolQuestArrowItem
			{
				ClickCallback = new Action<int>(this.OnArrowClick)
			};
		}

		// Token: 0x06038AE8 RID: 232168 RVA: 0x00FDD41B File Offset: 0x00FDB61B
		private void OnArrowClick(int questId)
		{
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(questId);
		}

		// Token: 0x0401DD92 RID: 122258
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SolarSchoolQuestArrowItem, SolarSchoolQuestArrowItemData> ArrowLayout;

		// Token: 0x0200B594 RID: 46484
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038267 RID: 229991
			public const int VerticalLayout = 0;

			// Token: 0x04038268 RID: 229992
			public const int QuestArrowItem = 1;
		}
	}
}
