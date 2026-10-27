using System;
using CSharpScript.Game.Module.Map.Mark;
using UnrealEngine;

namespace CSharpScript.Game.Module.Map.Marks.MarkItemView.Components
{
	// Token: 0x0200554D RID: 21837
	public class MarkVerticalPointerComponent : MarkPanelBase
	{
		// Token: 0x06037B84 RID: 228228 RVA: 0x00D387CD File Offset: 0x00D369CD
		protected override void OnBeforeShow()
		{
			this.UpdatePointerType();
		}

		// Token: 0x06037B85 RID: 228229 RVA: 0x00D387D5 File Offset: 0x00D369D5
		public void SetPointerType(EVerticalPointerType type)
		{
			this.PointerType = type;
			if (base.IsShowOrShowing)
			{
				this.UpdatePointerType();
			}
		}

		// Token: 0x06037B86 RID: 228230 RVA: 0x00D387EC File Offset: 0x00D369EC
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

		// Token: 0x06037B87 RID: 228231 RVA: 0x00D38828 File Offset: 0x00D36A28
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

		// Token: 0x06037B88 RID: 228232 RVA: 0x00D38870 File Offset: 0x00D36A70
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

		// Token: 0x06037B89 RID: 228233 RVA: 0x00D388B6 File Offset: 0x00D36AB6
		public void HideSelf()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(false);
		}

		// Token: 0x0401D450 RID: 119888
		private EVerticalPointerType PointerType;
	}
}
