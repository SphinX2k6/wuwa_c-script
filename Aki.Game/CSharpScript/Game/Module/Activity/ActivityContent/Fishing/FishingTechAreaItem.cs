using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020055A5 RID: 21925
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingTechAreaItem : UiPanelBase
	{
		// Token: 0x060365C1 RID: 222657 RVA: 0x00F2D548 File Offset: 0x00F2B748
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060365C2 RID: 222658 RVA: 0x00F2D658 File Offset: 0x00F2B858
		protected override UniTask OnBeforeStartAsync()
		{
			FishingTechAreaItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingTechAreaItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060365C3 RID: 222659 RVA: 0x00F2D69C File Offset: 0x00F2B89C
		public void RefreshNodeList(IFishingTechNode[] nodeList)
		{
			int num = 0;
			int num2 = 0;
			foreach (IFishingTechNode fishingTechNode in nodeList)
			{
				if (fishingTechNode.NodeType == EFishingTechNodeType.Secondary)
				{
					this.SecondaryNodeItemList[num2++].RefreshNode(fishingTechNode);
				}
				else
				{
					this.CoreAndImportantNodeItemList[num++].RefreshNode(fishingTechNode);
				}
			}
			foreach (FishingTechNodeItem fishingTechNodeItem in this.CoreAndImportantNodeItemList)
			{
				fishingTechNodeItem.OnClickToggleBack = new Action<IFishingTechNode, UUIExtendToggle>(this.OnClickToggle);
			}
			foreach (FishingTechSecondaryNodeItem fishingTechSecondaryNodeItem in this.SecondaryNodeItemList)
			{
				fishingTechSecondaryNodeItem.OnClickToggleBack = new Action<IFishingTechNode, UUIExtendToggle>(this.OnClickToggle);
			}
		}

		// Token: 0x060365C4 RID: 222660 RVA: 0x00F2D798 File Offset: 0x00F2B998
		public void FindAndSelectNode(IFishingTechNode node)
		{
			foreach (FishingTechNodeItem fishingTechNodeItem in this.CoreAndImportantNodeItemList)
			{
				if (fishingTechNodeItem.CurrentNode == node)
				{
					fishingTechNodeItem.SelectNode();
					return;
				}
			}
			foreach (FishingTechSecondaryNodeItem fishingTechSecondaryNodeItem in this.SecondaryNodeItemList)
			{
				if (fishingTechSecondaryNodeItem.CurrentNode == node)
				{
					fishingTechSecondaryNodeItem.SelectNode();
					break;
				}
			}
		}

		// Token: 0x060365C5 RID: 222661 RVA: 0x00F2D844 File Offset: 0x00F2BA44
		private void OnClickToggle(IFishingTechNode node, UUIExtendToggle toggle)
		{
			Action<IFishingTechNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(node, toggle);
		}

		// Token: 0x0401CAF7 RID: 117495
		private readonly List<FishingTechNodeItem> CoreAndImportantNodeItemList = new List<FishingTechNodeItem>();

		// Token: 0x0401CAF8 RID: 117496
		private readonly List<FishingTechSecondaryNodeItem> SecondaryNodeItemList = new List<FishingTechSecondaryNodeItem>();

		// Token: 0x0401CAF9 RID: 117497
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<IFishingTechNode, UUIExtendToggle> OnClickToggleBack;

		// Token: 0x0200B222 RID: 45602
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403711F RID: 225567
			public const int CoreNodeItem = 0;

			// Token: 0x04037120 RID: 225568
			public const int ImportantNodeOneItem = 1;

			// Token: 0x04037121 RID: 225569
			public const int ImportantNodeTwoItem = 2;

			// Token: 0x04037122 RID: 225570
			public const int ImportantNodeThreeItem = 3;

			// Token: 0x04037123 RID: 225571
			public const int SecondaryNodeOneItem = 4;

			// Token: 0x04037124 RID: 225572
			public const int SecondaryNodeTwoItem = 5;

			// Token: 0x04037125 RID: 225573
			public const int TitleSprite = 13;
		}
	}
}
