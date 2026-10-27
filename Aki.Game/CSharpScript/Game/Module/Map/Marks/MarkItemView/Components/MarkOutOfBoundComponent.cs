using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x02005549 RID: 21833
	public class MarkOutOfBoundComponent : MarkPanelBase
	{
		// Token: 0x06037B6F RID: 228207 RVA: 0x00D38480 File Offset: 0x00D36680
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

		// Token: 0x06037B70 RID: 228208 RVA: 0x00D384C8 File Offset: 0x00D366C8
		protected override void OnBeforeShow()
		{
			this.UpdateRotation();
		}

		// Token: 0x06037B71 RID: 228209 RVA: 0x00D384D0 File Offset: 0x00D366D0
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

		// Token: 0x06037B72 RID: 228210 RVA: 0x00D3851E File Offset: 0x00D3671E
		private void UpdateRotation()
		{
			base.GetItem(0).SetUIRelativeRotation(this.TempRotator);
		}

		// Token: 0x0401D449 RID: 119881
		private const double RAD_2_DEG = 57.29577951308232;

		// Token: 0x0401D44A RID: 119882
		private const double DEG_PI_4 = 90.0;

		// Token: 0x0401D44B RID: 119883
		private FRotator TempRotator = new FRotator();

		// Token: 0x0200B774 RID: 46964
		public static class EChildComponents
		{
			// Token: 0x040378A5 RID: 227493
			public const int DirectionItem = 0;
		}
	}
}
