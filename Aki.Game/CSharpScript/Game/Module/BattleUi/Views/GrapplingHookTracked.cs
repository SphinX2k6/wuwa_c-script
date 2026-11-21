using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D13 RID: 19731
	public class GrapplingHookTracked : UiPanelBase
	{
		// Token: 0x0603176D RID: 202605 RVA: 0x00DD471E File Offset: 0x00DD291E
		[NullableContext(1)]
		public GrapplingHookTracked(UUIItem parentItem)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_GsTracked", parentItem, true).ContinueWith(delegate()
			{
				this.IsTrackedActivated = true;
			}).Forget();
		}

		// Token: 0x0603176E RID: 202606 RVA: 0x00DD474C File Offset: 0x00DD294C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickedTrackedButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603176F RID: 202607 RVA: 0x00DD47F4 File Offset: 0x00DD29F4
		[NullableContext(1)]
		public void Refresh(in FVector2D screenPosition, Vector targetLocation)
		{
			if (!this.IsTrackedActivated)
			{
				return;
			}
			UUIItem item = base.GetItem(0);
			FRotator frotator = new FRotator();
			frotator.Yaw = (float)(Math.Atan2((double)screenPosition.Y, (double)screenPosition.X) * 57.2957763671875 - 90.0);
			item.SetUIRelativeRotation(frotator);
			this.RootItem.SetAnchorOffset(screenPosition);
			this.TargetLocation = targetLocation;
		}

		// Token: 0x06031770 RID: 202608 RVA: 0x00DD4866 File Offset: 0x00DD2A66
		private void OnClickedTrackedButton()
		{
			if (this.TargetLocation == null)
			{
				return;
			}
			BattleUiControl.Instance.FocusToTargetLocation(this.TargetLocation);
		}

		// Token: 0x06031771 RID: 202609 RVA: 0x00DD4881 File Offset: 0x00DD2A81
		public bool GetIsTrackedActivated()
		{
			return this.IsTrackedActivated;
		}

		// Token: 0x06031772 RID: 202610 RVA: 0x00DD4889 File Offset: 0x00DD2A89
		protected override void OnBeforeDestroy()
		{
			this.IsTrackedActivated = false;
			this.TargetLocation = null;
		}

		// Token: 0x0401A31D RID: 107293
		private bool IsTrackedActivated;

		// Token: 0x0401A31E RID: 107294
		[Nullable(2)]
		private Vector TargetLocation;

		// Token: 0x0200A9CE RID: 43470
		private enum EChildType
		{
			// Token: 0x04034779 RID: 214905
			DirectionItem,
			// Token: 0x0403477A RID: 214906
			TrackedButton
		}
	}
}
