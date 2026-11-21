using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x0200451B RID: 17691
	public class MarkOutOfBoundComponent : MarkPanelBase
	{
		// Token: 0x0602CA3F RID: 182847 RVA: 0x00C85F54 File Offset: 0x00C84154
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

		// Token: 0x0602CA40 RID: 182848 RVA: 0x00C85F9C File Offset: 0x00C8419C
		protected override void OnBeforeShow()
		{
			this.UpdateRotation();
		}

		// Token: 0x0602CA41 RID: 182849 RVA: 0x00C85FA4 File Offset: 0x00C841A4
		[NullableContext(1)]
		public void SetOutOfBoundDirection(Vector2D offset)
		{
			double num = Math.Atan2(offset.Y, offset.X) * 57.29577951308232 - 90.0;
			this.TempRotator.Yaw = (float)num;
			if (base.IsShowOrShowing)
			{
				this.UpdateRotation();
			}
		}

		// Token: 0x0602CA42 RID: 182850 RVA: 0x00C85FF2 File Offset: 0x00C841F2
		private void UpdateRotation()
		{
			base.GetItem(0).SetUIRelativeRotation(this.TempRotator);
		}

		// Token: 0x04017ED2 RID: 98002
		private const double RAD_2_DEG = 57.29577951308232;

		// Token: 0x04017ED3 RID: 98003
		private const double DEG_PI_4 = 90.0;

		// Token: 0x04017ED4 RID: 98004
		private FRotator TempRotator = new FRotator();

		// Token: 0x0200A19F RID: 41375
		public static class EChildComponents
		{
			// Token: 0x040322D0 RID: 205520
			public const int DirectionItem = 0;
		}
	}
}
