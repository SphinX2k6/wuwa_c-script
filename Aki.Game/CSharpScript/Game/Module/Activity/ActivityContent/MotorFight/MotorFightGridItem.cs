using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200640F RID: 25615
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorFightGridItem : SyncGridProxyAbstract<MotorFightItemData>
	{
		// Token: 0x060406E2 RID: 263906 RVA: 0x00F96080 File Offset: 0x00F94280
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060406E3 RID: 263907 RVA: 0x00F960C8 File Offset: 0x00F942C8
		protected override void OnStart()
		{
			this.GridItem = new MotorFightGridMediumItemGrid();
			this.GridItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
			this.GridItem.OnClickCallBack = this.OnClickCb;
		}

		// Token: 0x060406E4 RID: 263908 RVA: 0x00F96100 File Offset: 0x00F94300
		public override void Refresh(MotorFightItemData data)
		{
			this.Data = data;
			MotorFightGridMediumItemGrid gridItem = this.GridItem;
			if (gridItem != null)
			{
				gridItem.Refresh(data);
			}
			bool toggleState = this.IsSelected(data.Id);
			MotorFightGridMediumItemGrid gridItem2 = this.GridItem;
			if (gridItem2 == null)
			{
				return;
			}
			gridItem2.SetToggleState(toggleState);
		}

		// Token: 0x060406E5 RID: 263909 RVA: 0x00F96149 File Offset: 0x00F94349
		public void SetToggleState(bool state)
		{
			MotorFightGridMediumItemGrid gridItem = this.GridItem;
			if (gridItem == null)
			{
				return;
			}
			gridItem.SetToggleState(state);
		}

		// Token: 0x04021804 RID: 137220
		[Nullable(2)]
		public MotorFightItemData Data;

		// Token: 0x04021805 RID: 137221
		public Func<int, bool> IsSelected = (int id) => false;

		// Token: 0x04021806 RID: 137222
		[Nullable(2)]
		private MotorFightGridMediumItemGrid GridItem;

		// Token: 0x04021807 RID: 137223
		public Action<MotorFightItemData> OnClickCb;

		// Token: 0x0200C631 RID: 50737
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BD5C RID: 245084
			public const int ItemBaseGrid = 0;
		}
	}
}
