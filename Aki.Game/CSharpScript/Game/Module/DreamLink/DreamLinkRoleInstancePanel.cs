using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AA4 RID: 23204
	public class DreamLinkRoleInstancePanel : UiPanelBase
	{
		// Token: 0x0603AC59 RID: 240729 RVA: 0x00DFF7C4 File Offset: 0x00DFD9C4
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

		// Token: 0x0603AC5A RID: 240730 RVA: 0x00DFF850 File Offset: 0x00DFDA50
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkRoleInstancePanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkRoleInstancePanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AC5B RID: 240731 RVA: 0x00DFF894 File Offset: 0x00DFDA94
		[NullableContext(1)]
		public void Refresh(RogueRoleInstData[] dungeonList, int selectIndex)
		{
			for (int i = 0; i < this.RoleDungeonItemList.Count; i++)
			{
				if (i < dungeonList.Length)
				{
					this.RoleDungeonItemList[i].Refresh(dungeonList[i], i == selectIndex);
				}
			}
		}

		// Token: 0x0603AC5C RID: 240732 RVA: 0x00DFF8D8 File Offset: 0x00DFDAD8
		public FVector2D? GetScreenPositionByIndex(int index)
		{
			DreamLinkRoleInstanceItem dreamLinkRoleInstanceItem = this.RoleDungeonItemList[index];
			if (dreamLinkRoleInstanceItem != null)
			{
				return new FVector2D?(dreamLinkRoleInstanceItem.GetRootItem().GetPositionInViewPort(true));
			}
			return null;
		}

		// Token: 0x0603AC5D RID: 240733 RVA: 0x00DFF910 File Offset: 0x00DFDB10
		public FVectorDouble? GetLocationByIndex(int index)
		{
			DreamLinkRoleInstanceItem dreamLinkRoleInstanceItem = this.RoleDungeonItemList[index];
			if (dreamLinkRoleInstanceItem != null)
			{
				return new FVectorDouble?(dreamLinkRoleInstanceItem.GetRootItem().D_K2_GetComponentToWorld().GetLocation());
			}
			return null;
		}

		// Token: 0x0603AC5E RID: 240734 RVA: 0x00DFF950 File Offset: 0x00DFDB50
		public void SetSelectItem(int index)
		{
			for (int i = 0; i < this.RoleDungeonItemList.Count; i++)
			{
				if (i != index)
				{
					this.RoleDungeonItemList[i].SetToggleState(false);
				}
			}
		}

		// Token: 0x0401EABD RID: 125629
		[Nullable(1)]
		private readonly List<DreamLinkRoleInstanceItem> RoleDungeonItemList = new List<DreamLinkRoleInstanceItem>();

		// Token: 0x0200BCD1 RID: 48337
		private class EComponentDefine
		{
			// Token: 0x04038F3F RID: 233279
			public const int Item1 = 0;

			// Token: 0x04038F40 RID: 233280
			public const int Item2 = 1;

			// Token: 0x04038F41 RID: 233281
			public const int Item3 = 2;
		}
	}
}
