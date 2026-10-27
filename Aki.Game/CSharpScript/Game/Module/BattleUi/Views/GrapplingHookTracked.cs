using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D31 RID: 23857
	public class GrapplingHookTracked : UiPanelBase
	{
		// Token: 0x0603C814 RID: 247828 RVA: 0x00E83F7E File Offset: 0x00E8217E
		[NullableContext(1)]
		public GrapplingHookTracked(UUIItem parentItem)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_GsTracked", parentItem, true).ContinueWith(delegate()
			{
				this.IsTrackedActivated = true;
			}).Forget();
		}

		// Token: 0x0603C815 RID: 247829 RVA: 0x00E83FAC File Offset: 0x00E821AC
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

		// Token: 0x0603C816 RID: 247830 RVA: 0x00E84054 File Offset: 0x00E82254
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

		// Token: 0x0603C817 RID: 247831 RVA: 0x00E840C6 File Offset: 0x00E822C6
		private void OnClickedTrackedButton()
		{
			if (this.TargetLocation == null)
			{
				return;
			}
			BattleUiControl.Instance.FocusToTargetLocation(this.TargetLocation);
		}

		// Token: 0x0603C818 RID: 247832 RVA: 0x00E840E1 File Offset: 0x00E822E1
		public bool GetIsTrackedActivated()
		{
			return this.IsTrackedActivated;
		}

		// Token: 0x0603C819 RID: 247833 RVA: 0x00E840E9 File Offset: 0x00E822E9
		protected override void OnBeforeDestroy()
		{
			this.IsTrackedActivated = false;
			this.TargetLocation = null;
		}

		// Token: 0x0401F864 RID: 129124
		private bool IsTrackedActivated;

		// Token: 0x0401F865 RID: 129125
		[Nullable(2)]
		private Vector TargetLocation;

		// Token: 0x0200BFC8 RID: 49096
		private enum EChildType
		{
			// Token: 0x04039DB7 RID: 236983
			DirectionItem,
			// Token: 0x04039DB8 RID: 236984
			TrackedButton
		}
	}
}
