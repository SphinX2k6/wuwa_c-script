using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F8A RID: 20362
	[NullableContext(2)]
	[Nullable(0)]
	public class QuickHackCameraControlItem : GridProxyAbstract<int>
	{
		// Token: 0x0603422C RID: 213548 RVA: 0x00C3C3F0 File Offset: 0x00C3A5F0
		protected override void OnStart()
		{
			UActorComponent componentByClass = this.RootActor.GetComponentByClass(UUIExtendToggle.StaticClass());
			if (componentByClass == null)
			{
				return;
			}
			this.Toggle = (componentByClass as UUIExtendToggle);
			this.Toggle.bLockStateOnSelect = true;
			this.Toggle.OnPointDownCallBack.Bind(new Action<EToggleState>(this.OnCameraItemPointDown));
		}

		// Token: 0x0603422D RID: 213549 RVA: 0x00C3C44B File Offset: 0x00C3A64B
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle toggle = this.Toggle;
			if (toggle != null && toggle.IsValid())
			{
				this.Toggle.OnPointDownCallBack.Unbind();
			}
			this.Toggle = null;
			this.OnCameraItemClick = null;
		}

		// Token: 0x0603422E RID: 213550 RVA: 0x00C3C47F File Offset: 0x00C3A67F
		[NullableContext(1)]
		public void RegisterOnCameraItemClick(Action<int> onCameraItemClick)
		{
			this.OnCameraItemClick = onCameraItemClick;
		}

		// Token: 0x0603422F RID: 213551 RVA: 0x00C3C488 File Offset: 0x00C3A688
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.PbDataId = data;
			UUIExtendToggle toggle = this.Toggle;
			if (toggle != null && toggle.IsValid())
			{
				this.Toggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x06034230 RID: 213552 RVA: 0x00C3C4BB File Offset: 0x00C3A6BB
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle toggle = this.Toggle;
			if (toggle != null && toggle.IsValid())
			{
				this.Toggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
		}

		// Token: 0x06034231 RID: 213553 RVA: 0x00C3C4E1 File Offset: 0x00C3A6E1
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle toggle = this.Toggle;
			if (toggle != null && toggle.IsValid())
			{
				this.Toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x06034232 RID: 213554 RVA: 0x00C3C507 File Offset: 0x00C3A707
		private void OnCameraItemPointDown(EToggleState state)
		{
			Action<int> onCameraItemClick = this.OnCameraItemClick;
			if (onCameraItemClick == null)
			{
				return;
			}
			onCameraItemClick(this.PbDataId);
		}

		// Token: 0x0401BB86 RID: 113542
		private int PbDataId;

		// Token: 0x0401BB87 RID: 113543
		private UUIExtendToggle Toggle;

		// Token: 0x0401BB88 RID: 113544
		private Action<int> OnCameraItemClick;
	}
}
