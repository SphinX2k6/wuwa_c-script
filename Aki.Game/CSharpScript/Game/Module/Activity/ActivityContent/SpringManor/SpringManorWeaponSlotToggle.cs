using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006056 RID: 24662
	[NullableContext(2)]
	[Nullable(0)]
	public class SpringManorWeaponSlotToggle : UiPanelBase
	{
		// Token: 0x0603E67B RID: 255611 RVA: 0x00F12F02 File Offset: 0x00F11102
		private void OnClickWeaponTog(EToggleState state)
		{
			if (this.SlotIndex < 0)
			{
				return;
			}
			Action<int> onSelectedCallback = this.OnSelectedCallback;
			if (onSelectedCallback == null)
			{
				return;
			}
			onSelectedCallback(this.SlotIndex);
		}

		// Token: 0x0603E67C RID: 255612 RVA: 0x00F12F24 File Offset: 0x00F11124
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickWeaponTog))
			};
		}

		// Token: 0x0603E67D RID: 255613 RVA: 0x00F12FA4 File Offset: 0x00F111A4
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorWeaponSlotToggle.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorWeaponSlotToggle.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E67E RID: 255614 RVA: 0x00F12FE7 File Offset: 0x00F111E7
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0603E67F RID: 255615 RVA: 0x00F13001 File Offset: 0x00F11201
		[NullableContext(1)]
		public void Setup(int index, Action<int> callback)
		{
			this.SlotIndex = index;
			this.OnSelectedCallback = callback;
		}

		// Token: 0x0603E680 RID: 255616 RVA: 0x00F13014 File Offset: 0x00F11214
		public void SetSelected(bool isSelected)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			extendToggle.SetToggleStateForce(state, false, false, false);
		}

		// Token: 0x0603E681 RID: 255617 RVA: 0x00F1303F File Offset: 0x00F1123F
		public void SetWeaponItemId(int itemId)
		{
			this.AssignedWeaponItemId = itemId;
			this.RefreshSlotState();
		}

		// Token: 0x0603E682 RID: 255618 RVA: 0x00F1304E File Offset: 0x00F1124E
		public int GetWeaponItemId()
		{
			return this.AssignedWeaponItemId;
		}

		// Token: 0x0603E683 RID: 255619 RVA: 0x00F13058 File Offset: 0x00F11258
		private void RefreshSlotState()
		{
			bool flag = this.AssignedWeaponItemId != 0;
			if (this.PreviousHasWeapon != null && this.SequencePlayer != null)
			{
				if (!this.PreviousHasWeapon.Value && flag)
				{
					this.SequencePlayer.PlaySequence("Assembled", false, null);
				}
				else if (this.PreviousHasWeapon.Value && !flag)
				{
					this.SequencePlayer.PlaySequence("Unassembled", false, null);
				}
			}
			this.PreviousHasWeapon = new bool?(flag);
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(flag);
		}

		// Token: 0x040209B4 RID: 133556
		private int SlotIndex = -1;

		// Token: 0x040209B5 RID: 133557
		private Action<int> OnSelectedCallback;

		// Token: 0x040209B6 RID: 133558
		private int AssignedWeaponItemId;

		// Token: 0x040209B7 RID: 133559
		private UiSequencePlayer SequencePlayer;

		// Token: 0x040209B8 RID: 133560
		private bool? PreviousHasWeapon;
	}
}
