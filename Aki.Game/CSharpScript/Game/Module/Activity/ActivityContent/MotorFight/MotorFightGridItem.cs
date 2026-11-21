using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200538D RID: 21389
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorFightGridItem : SyncGridProxyAbstract<MotorFightItemData>
	{
		// Token: 0x060353A3 RID: 218019 RVA: 0x00EDD020 File Offset: 0x00EDB220
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

		// Token: 0x060353A4 RID: 218020 RVA: 0x00EDD068 File Offset: 0x00EDB268
		protected override void OnStart()
		{
			this.GridItem = new MotorFightGridMediumItemGrid();
			this.GridItem.CreateThenShowByActor(base.GetItem(0).GetOwner(), null);
			this.GridItem.OnClickCallBack = this.OnClickCb;
		}

		// Token: 0x060353A5 RID: 218021 RVA: 0x00EDD0A0 File Offset: 0x00EDB2A0
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

		// Token: 0x060353A6 RID: 218022 RVA: 0x00EDD0E9 File Offset: 0x00EDB2E9
		public void SetToggleState(bool state)
		{
			MotorFightGridMediumItemGrid gridItem = this.GridItem;
			if (gridItem == null)
			{
				return;
			}
			gridItem.SetToggleState(state);
		}

		// Token: 0x0401C133 RID: 114995
		[Nullable(2)]
		public MotorFightItemData Data;

		// Token: 0x0401C134 RID: 114996
		public Func<int, bool> IsSelected = (int id) => false;

		// Token: 0x0401C135 RID: 114997
		[Nullable(2)]
		private MotorFightGridMediumItemGrid GridItem;

		// Token: 0x0401C136 RID: 114998
		public Action<MotorFightItemData> OnClickCb;

		// Token: 0x0200B018 RID: 45080
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040366B9 RID: 222905
			public const int ItemBaseGrid = 0;
		}
	}
}
