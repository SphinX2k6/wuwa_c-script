using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.KeySettingsView
{
	// Token: 0x0200545E RID: 21598
	public class ChangeModeRowView : UiPanelBase
	{
		// Token: 0x06037207 RID: 225799 RVA: 0x00D11230 File Offset: 0x00D0F430
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

		// Token: 0x06037208 RID: 225800 RVA: 0x00D112A0 File Offset: 0x00D0F4A0
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x06037209 RID: 225801 RVA: 0x00D112C4 File Offset: 0x00D0F4C4
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

		// Token: 0x0603720A RID: 225802 RVA: 0x00D112EB File Offset: 0x00D0F4EB
		[NullableContext(1)]
		public void Refresh(ChangeKeyModeRowData changeKeyModeRowData)
		{
			this.ChangeKeyModeRowData = changeKeyModeRowData;
			this.RefreshRawSprite();
			this.RefreshDescription();
		}

		// Token: 0x0603720B RID: 225803 RVA: 0x00D11300 File Offset: 0x00D0F500
		private void RefreshRawSprite()
		{
			if (this.ChangeKeyModeRowData == null)
			{
				return;
			}
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(this.ChangeKeyModeRowData.SpriteResourceId);
			this.SetSpriteByPath(resourcePath, base.GetSprite(1), false, null, null);
		}

		// Token: 0x0603720C RID: 225804 RVA: 0x00D11348 File Offset: 0x00D0F548
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

		// Token: 0x0603720D RID: 225805 RVA: 0x00D113C2 File Offset: 0x00D0F5C2
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

		// Token: 0x0603720E RID: 225806 RVA: 0x00D113E3 File Offset: 0x00D0F5E3
		[NullableContext(1)]
		public void BindOnSelected(Action<ChangeModeRowView> onSelected)
		{
			this.OnSelected = onSelected;
		}

		// Token: 0x0603720F RID: 225807 RVA: 0x00D113EC File Offset: 0x00D0F5EC
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

		// Token: 0x0401D161 RID: 119137
		[Nullable(2)]
		public ChangeKeyModeRowData ChangeKeyModeRowData;

		// Token: 0x0401D162 RID: 119138
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<ChangeModeRowView> OnSelected;

		// Token: 0x0200B6D3 RID: 46803
		public class EChildType
		{
			// Token: 0x04037632 RID: 226866
			public const int RowToggle = 0;

			// Token: 0x04037633 RID: 226867
			public const int RowSprite = 1;

			// Token: 0x04037634 RID: 226868
			public const int TextA = 2;

			// Token: 0x04037635 RID: 226869
			public const int TextB = 3;
		}
	}
}
