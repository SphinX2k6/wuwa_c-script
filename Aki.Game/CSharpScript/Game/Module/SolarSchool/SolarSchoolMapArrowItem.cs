using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059BF RID: 22975
	public class SolarSchoolMapArrowItem : UiPanelBase
	{
		// Token: 0x17006C42 RID: 27714
		// (get) Token: 0x06038A07 RID: 231943 RVA: 0x00FD867F File Offset: 0x00FD687F
		// (set) Token: 0x06038A08 RID: 231944 RVA: 0x00FD8687 File Offset: 0x00FD6887
		public int LocationId { get; private set; }

		// Token: 0x06038A09 RID: 231945 RVA: 0x00FD8690 File Offset: 0x00FD6890
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

		// Token: 0x06038A0A RID: 231946 RVA: 0x00FD86D8 File Offset: 0x00FD68D8
		public void SetLocationId(int locationId)
		{
			this.LocationId = locationId;
		}

		// Token: 0x06038A0B RID: 231947 RVA: 0x00FD86E1 File Offset: 0x00FD68E1
		public void Refresh(FVector2D position, double degrees)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetAnchorOffset(position);
			}
			this.SetAngle(degrees);
		}

		// Token: 0x06038A0C RID: 231948 RVA: 0x00FD86FC File Offset: 0x00FD68FC
		public void SetAngle(double degrees)
		{
			UUIItem item = base.GetItem(0);
			if (item == null)
			{
				return;
			}
			FRotator frotator = new FRotator(0f, (float)degrees, 0f);
			item.SetUIRelativeRotation(frotator);
		}

		// Token: 0x0200B56B RID: 46443
		private class EComponents
		{
			// Token: 0x04038183 RID: 229763
			public const int PnlRot = 0;
		}
	}
}
