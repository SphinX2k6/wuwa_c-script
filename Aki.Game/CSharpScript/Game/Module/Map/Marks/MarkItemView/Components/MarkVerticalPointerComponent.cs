using System;
using CSharpScript.Game.Module.Map.Mark;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x0200451F RID: 17695
	public class MarkVerticalPointerComponent : MarkPanelBase
	{
		// Token: 0x0602CA54 RID: 182868 RVA: 0x00C862A1 File Offset: 0x00C844A1
		protected override void OnBeforeShow()
		{
			this.UpdatePointerType();
		}

		// Token: 0x0602CA55 RID: 182869 RVA: 0x00C862A9 File Offset: 0x00C844A9
		public void SetPointerType(EVerticalPointerType type)
		{
			this.PointerType = type;
			if (base.IsShowOrShowing)
			{
				this.UpdatePointerType();
			}
		}

		// Token: 0x0602CA56 RID: 182870 RVA: 0x00C862C0 File Offset: 0x00C844C0
		private void UpdatePointerType()
		{
			switch (this.PointerType)
			{
			case EVerticalPointerType.None:
				this.HideSelf();
				return;
			case EVerticalPointerType.Up:
				this.ShowUp();
				return;
			case EVerticalPointerType.Down:
				this.ShowDown();
				return;
			default:
				return;
			}
		}

		// Token: 0x0602CA57 RID: 182871 RVA: 0x00C862FC File Offset: 0x00C844FC
		public void ShowUp()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(true);
			}
			UUIItem rootItem2 = this.RootItem;
			if (rootItem2 == null)
			{
				return;
			}
			FRotator frotator = new FRotator(0f, 0f, 0f);
			rootItem2.SetUIRelativeRotation(frotator);
		}

		// Token: 0x0602CA58 RID: 182872 RVA: 0x00C86344 File Offset: 0x00C84544
		public void ShowDown()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIActive(true);
			}
			UUIItem rootItem2 = this.RootItem;
			if (rootItem2 == null)
			{
				return;
			}
			FRotator frotator = new FRotator(0f, 0f, 180f);
			rootItem2.SetUIRelativeRotation(frotator);
		}

		// Token: 0x0602CA59 RID: 182873 RVA: 0x00C8638A File Offset: 0x00C8458A
		public void HideSelf()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(false);
		}

		// Token: 0x04017ED9 RID: 98009
		private EVerticalPointerType PointerType;
	}
}
