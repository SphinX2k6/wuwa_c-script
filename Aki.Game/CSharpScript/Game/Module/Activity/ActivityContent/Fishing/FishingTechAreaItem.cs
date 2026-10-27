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
	// Token: 0x02006627 RID: 26151
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingTechAreaItem : UiPanelBase
	{
		// Token: 0x060418FC RID: 268540 RVA: 0x00FE6494 File Offset: 0x00FE4694
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

		// Token: 0x060418FD RID: 268541 RVA: 0x00FE65A4 File Offset: 0x00FE47A4
		protected override UniTask OnBeforeStartAsync()
		{
			FishingTechAreaItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingTechAreaItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060418FE RID: 268542 RVA: 0x00FE65E8 File Offset: 0x00FE47E8
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

		// Token: 0x060418FF RID: 268543 RVA: 0x00FE66E4 File Offset: 0x00FE48E4
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

		// Token: 0x06041900 RID: 268544 RVA: 0x00FE6790 File Offset: 0x00FE4990
		private void OnClickToggle(IFishingTechNode node, UUIExtendToggle toggle)
		{
			Action<IFishingTechNode, UUIExtendToggle> onClickToggleBack = this.OnClickToggleBack;
			if (onClickToggleBack == null)
			{
				return;
			}
			onClickToggleBack(node, toggle);
		}

		// Token: 0x040221C6 RID: 139718
		private readonly List<FishingTechNodeItem> CoreAndImportantNodeItemList = new List<FishingTechNodeItem>();

		// Token: 0x040221C7 RID: 139719
		private readonly List<FishingTechSecondaryNodeItem> SecondaryNodeItemList = new List<FishingTechSecondaryNodeItem>();

		// Token: 0x040221C8 RID: 139720
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<IFishingTechNode, UUIExtendToggle> OnClickToggleBack;

		// Token: 0x0200C840 RID: 51264
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C7DA RID: 247770
			public const int CoreNodeItem = 0;

			// Token: 0x0403C7DB RID: 247771
			public const int ImportantNodeOneItem = 1;

			// Token: 0x0403C7DC RID: 247772
			public const int ImportantNodeTwoItem = 2;

			// Token: 0x0403C7DD RID: 247773
			public const int ImportantNodeThreeItem = 3;

			// Token: 0x0403C7DE RID: 247774
			public const int SecondaryNodeOneItem = 4;

			// Token: 0x0403C7DF RID: 247775
			public const int SecondaryNodeTwoItem = 5;

			// Token: 0x0403C7E0 RID: 247776
			public const int TitleSprite = 13;
		}
	}
}
