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
	// Token: 0x02004A80 RID: 19072
	public class DreamLinkRoleInstancePanel : UiPanelBase
	{
		// Token: 0x0602FBA5 RID: 195493 RVA: 0x00D4FD78 File Offset: 0x00D4DF78
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

		// Token: 0x0602FBA6 RID: 195494 RVA: 0x00D4FE04 File Offset: 0x00D4E004
		protected override UniTask OnBeforeStartAsync()
		{
			DreamLinkRoleInstancePanel.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DreamLinkRoleInstancePanel.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FBA7 RID: 195495 RVA: 0x00D4FE48 File Offset: 0x00D4E048
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

		// Token: 0x0602FBA8 RID: 195496 RVA: 0x00D4FE8C File Offset: 0x00D4E08C
		public FVector2D? GetScreenPositionByIndex(int index)
		{
			DreamLinkRoleInstanceItem dreamLinkRoleInstanceItem = this.RoleDungeonItemList[index];
			if (dreamLinkRoleInstanceItem != null)
			{
				return new FVector2D?(dreamLinkRoleInstanceItem.GetRootItem().GetPositionInViewPort(true));
			}
			return null;
		}

		// Token: 0x0602FBA9 RID: 195497 RVA: 0x00D4FEC4 File Offset: 0x00D4E0C4
		public FVectorDouble? GetLocationByIndex(int index)
		{
			DreamLinkRoleInstanceItem dreamLinkRoleInstanceItem = this.RoleDungeonItemList[index];
			if (dreamLinkRoleInstanceItem != null)
			{
				return new FVectorDouble?(dreamLinkRoleInstanceItem.GetRootItem().D_K2_GetComponentToWorld().GetLocation());
			}
			return null;
		}

		// Token: 0x0602FBAA RID: 195498 RVA: 0x00D4FF04 File Offset: 0x00D4E104
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

		// Token: 0x04019564 RID: 103780
		[Nullable(1)]
		private readonly List<DreamLinkRoleInstanceItem> RoleDungeonItemList = new List<DreamLinkRoleInstanceItem>();

		// Token: 0x0200A6DA RID: 42714
		private class EComponentDefine
		{
			// Token: 0x0403390A RID: 211210
			public const int Item1 = 0;

			// Token: 0x0403390B RID: 211211
			public const int Item2 = 1;

			// Token: 0x0403390C RID: 211212
			public const int Item3 = 2;
		}
	}
}
