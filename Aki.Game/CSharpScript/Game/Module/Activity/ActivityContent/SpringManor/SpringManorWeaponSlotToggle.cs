using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FD4 RID: 20436
	[NullableContext(2)]
	[Nullable(0)]
	public class SpringManorWeaponSlotToggle : UiPanelBase
	{
		// Token: 0x0603333F RID: 209727 RVA: 0x00E59CC6 File Offset: 0x00E57EC6
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

		// Token: 0x06033340 RID: 209728 RVA: 0x00E59CE8 File Offset: 0x00E57EE8
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

		// Token: 0x06033341 RID: 209729 RVA: 0x00E59D68 File Offset: 0x00E57F68
		protected override UniTask OnBeforeStartAsync()
		{
			SpringManorWeaponSlotToggle.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SpringManorWeaponSlotToggle.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033342 RID: 209730 RVA: 0x00E59DAB File Offset: 0x00E57FAB
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06033343 RID: 209731 RVA: 0x00E59DC5 File Offset: 0x00E57FC5
		[NullableContext(1)]
		public void Setup(int index, Action<int> callback)
		{
			this.SlotIndex = index;
			this.OnSelectedCallback = callback;
		}

		// Token: 0x06033344 RID: 209732 RVA: 0x00E59DD8 File Offset: 0x00E57FD8
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

		// Token: 0x06033345 RID: 209733 RVA: 0x00E59E03 File Offset: 0x00E58003
		public void SetWeaponItemId(int itemId)
		{
			this.AssignedWeaponItemId = itemId;
			this.RefreshSlotState();
		}

		// Token: 0x06033346 RID: 209734 RVA: 0x00E59E12 File Offset: 0x00E58012
		public int GetWeaponItemId()
		{
			return this.AssignedWeaponItemId;
		}

		// Token: 0x06033347 RID: 209735 RVA: 0x00E59E1C File Offset: 0x00E5801C
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

		// Token: 0x0401B2E1 RID: 111329
		private int SlotIndex = -1;

		// Token: 0x0401B2E2 RID: 111330
		private Action<int> OnSelectedCallback;

		// Token: 0x0401B2E3 RID: 111331
		private int AssignedWeaponItemId;

		// Token: 0x0401B2E4 RID: 111332
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401B2E5 RID: 111333
		private bool? PreviousHasWeapon;
	}
}
