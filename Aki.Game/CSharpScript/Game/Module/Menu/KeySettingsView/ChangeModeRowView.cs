using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x02004441 RID: 17473
	public class ChangeModeRowView : UiPanelBase
	{
		// Token: 0x0602C150 RID: 180560 RVA: 0x00C60648 File Offset: 0x00C5E848
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
		}

		// Token: 0x0602C151 RID: 180561 RVA: 0x00C606B8 File Offset: 0x00C5E8B8
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x0602C152 RID: 180562 RVA: 0x00C606DC File Offset: 0x00C5E8DC
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.OnStateChange.Clear();
			}
			this.OnSelected = null;
			this.ChangeKeyModeRowData = null;
		}

		// Token: 0x0602C153 RID: 180563 RVA: 0x00C60703 File Offset: 0x00C5E903
		[NullableContext(1)]
		public void Refresh(ChangeKeyModeRowData changeKeyModeRowData)
		{
			this.ChangeKeyModeRowData = changeKeyModeRowData;
			this.RefreshRawSprite();
			this.RefreshDescription();
		}

		// Token: 0x0602C154 RID: 180564 RVA: 0x00C60718 File Offset: 0x00C5E918
		private void RefreshRawSprite()
		{
			if (this.ChangeKeyModeRowData == null)
			{
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(this.ChangeKeyModeRowData.SpriteResourceId);
			this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, null);
		}

		// Token: 0x0602C155 RID: 180565 RVA: 0x00C60760 File Offset: 0x00C5E960
		private void RefreshDescription()
		{
			if (this.ChangeKeyModeRowData == null)
			{
				return;
			}
			UUIText text = base.GetText(2);
			UUIText text2 = base.GetText(3);
			LguiUtil.Instance.SetLocalTextNew(text, this.ChangeKeyModeRowData.DescriptionA, this.ChangeKeyModeRowData.DescriptionParametersA ?? Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(text2, this.ChangeKeyModeRowData.DescriptionB, this.ChangeKeyModeRowData.DescriptionParametersB ?? Array.Empty<object>());
		}

		// Token: 0x0602C156 RID: 180566 RVA: 0x00C607DA File Offset: 0x00C5E9DA
		private void OnToggleStateChanged(EToggleState state)
		{
			if (this.ChangeKeyModeRowData == null)
			{
				return;
			}
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			Action<ChangeModeRowView> onSelected = this.OnSelected;
			if (onSelected == null)
			{
				return;
			}
			onSelected(this);
		}

		// Token: 0x0602C157 RID: 180567 RVA: 0x00C607FB File Offset: 0x00C5E9FB
		[NullableContext(1)]
		public void BindOnSelected(Action<ChangeModeRowView> onSelected)
		{
			this.OnSelected = onSelected;
		}

		// Token: 0x0602C158 RID: 180568 RVA: 0x00C60804 File Offset: 0x00C5EA04
		public void SetSelected(bool bSelected)
		{
			if (bSelected)
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(0);
				if (extendToggle == null)
				{
					return;
				}
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
				return;
			}
			else
			{
				UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
				if (extendToggle2 == null)
				{
					return;
				}
				extendToggle2.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
				return;
			}
		}

		// Token: 0x04017BFA RID: 97274
		[Nullable(2)]
		public ChangeKeyModeRowData ChangeKeyModeRowData;

		// Token: 0x04017BFB RID: 97275
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ChangeModeRowView> OnSelected;

		// Token: 0x0200A10B RID: 41227
		public class EChildType
		{
			// Token: 0x04032087 RID: 204935
			public const int RowToggle = 0;

			// Token: 0x04032088 RID: 204936
			public const int RowSprite = 1;

			// Token: 0x04032089 RID: 204937
			public const int TextA = 2;

			// Token: 0x0403208A RID: 204938
			public const int TextB = 3;
		}
	}
}
