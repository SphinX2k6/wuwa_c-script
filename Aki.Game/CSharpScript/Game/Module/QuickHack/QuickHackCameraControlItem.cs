using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F53 RID: 16211
	[NullableContext(2)]
	[Nullable(0)]
	public class QuickHackCameraControlItem : GridProxyAbstract<int>
	{
		// Token: 0x0602909A RID: 168090 RVA: 0x00B85B9C File Offset: 0x00B83D9C
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

		// Token: 0x0602909B RID: 168091 RVA: 0x00B85BF7 File Offset: 0x00B83DF7
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

		// Token: 0x0602909C RID: 168092 RVA: 0x00B85C2B File Offset: 0x00B83E2B
		[NullableContext(1)]
		public void RegisterOnCameraItemClick(Action<int> onCameraItemClick)
		{
			this.OnCameraItemClick = onCameraItemClick;
		}

		// Token: 0x0602909D RID: 168093 RVA: 0x00B85C34 File Offset: 0x00B83E34
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.PbDataId = data;
			UUIExtendToggle toggle = this.Toggle;
			if (toggle != null && toggle.IsValid())
			{
				this.Toggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x0602909E RID: 168094 RVA: 0x00B85C67 File Offset: 0x00B83E67
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle toggle = this.Toggle;
			if (toggle != null && toggle.IsValid())
			{
				this.Toggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
		}

		// Token: 0x0602909F RID: 168095 RVA: 0x00B85C8D File Offset: 0x00B83E8D
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle toggle = this.Toggle;
			if (toggle != null && toggle.IsValid())
			{
				this.Toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x060290A0 RID: 168096 RVA: 0x00B85CB3 File Offset: 0x00B83EB3
		private void OnCameraItemPointDown(EToggleState state)
		{
			Action<int> onCameraItemClick = this.OnCameraItemClick;
			if (onCameraItemClick == null)
			{
				return;
			}
			onCameraItemClick(this.PbDataId);
		}

		// Token: 0x0401655B RID: 91483
		private int PbDataId;

		// Token: 0x0401655C RID: 91484
		private UUIExtendToggle Toggle;

		// Token: 0x0401655D RID: 91485
		private Action<int> OnCameraItemClick;
	}
}
