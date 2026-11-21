using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout
{
	// Token: 0x020036F7 RID: 14071
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapSecondaryUiContext
	{
		// Token: 0x17004B51 RID: 19281
		// (get) Token: 0x060249FE RID: 150014 RVA: 0x00A57CAF File Offset: 0x00A55EAF
		// (set) Token: 0x060249FF RID: 150015 RVA: 0x00A57CB7 File Offset: 0x00A55EB7
		public MarkItem MarkItem { get; set; }

		// Token: 0x17004B52 RID: 19282
		// (get) Token: 0x06024A00 RID: 150016 RVA: 0x00A57CC0 File Offset: 0x00A55EC0
		// (set) Token: 0x06024A01 RID: 150017 RVA: 0x00A57CC8 File Offset: 0x00A55EC8
		public TSetSpriteByPathAction SetSpriteByPathAction { get; set; }

		// Token: 0x17004B53 RID: 19283
		// (get) Token: 0x06024A02 RID: 150018 RVA: 0x00A57CD1 File Offset: 0x00A55ED1
		// (set) Token: 0x06024A03 RID: 150019 RVA: 0x00A57CD9 File Offset: 0x00A55ED9
		public UUISprite Icon { get; set; }

		// Token: 0x17004B54 RID: 19284
		// (get) Token: 0x06024A04 RID: 150020 RVA: 0x00A57CE2 File Offset: 0x00A55EE2
		// (set) Token: 0x06024A05 RID: 150021 RVA: 0x00A57CEA File Offset: 0x00A55EEA
		public UUIText Title { get; set; }

		// Token: 0x17004B55 RID: 19285
		// (get) Token: 0x06024A06 RID: 150022 RVA: 0x00A57CF3 File Offset: 0x00A55EF3
		// (set) Token: 0x06024A07 RID: 150023 RVA: 0x00A57CFB File Offset: 0x00A55EFB
		public UUIText AreaText { get; set; }

		// Token: 0x17004B56 RID: 19286
		// (get) Token: 0x06024A08 RID: 150024 RVA: 0x00A57D04 File Offset: 0x00A55F04
		// (set) Token: 0x06024A09 RID: 150025 RVA: 0x00A57D0C File Offset: 0x00A55F0C
		public UUIItem AreaIconItem { get; set; }

		// Token: 0x17004B57 RID: 19287
		// (get) Token: 0x06024A0A RID: 150026 RVA: 0x00A57D15 File Offset: 0x00A55F15
		// (set) Token: 0x06024A0B RID: 150027 RVA: 0x00A57D1D File Offset: 0x00A55F1D
		public UUIText DescriptionText { get; set; }

		// Token: 0x17004B58 RID: 19288
		// (get) Token: 0x06024A0C RID: 150028 RVA: 0x00A57D26 File Offset: 0x00A55F26
		// (set) Token: 0x06024A0D RID: 150029 RVA: 0x00A57D2E File Offset: 0x00A55F2E
		public ButtonItem TrackButtonItem { get; set; }

		// Token: 0x17004B59 RID: 19289
		// (get) Token: 0x06024A0E RID: 150030 RVA: 0x00A57D37 File Offset: 0x00A55F37
		// (set) Token: 0x06024A0F RID: 150031 RVA: 0x00A57D3F File Offset: 0x00A55F3F
		public UUISprite DownStateIcon { get; set; }

		// Token: 0x17004B5A RID: 19290
		// (get) Token: 0x06024A10 RID: 150032 RVA: 0x00A57D48 File Offset: 0x00A55F48
		// (set) Token: 0x06024A11 RID: 150033 RVA: 0x00A57D50 File Offset: 0x00A55F50
		public UUIItem PanelProgressItem { get; set; }

		// Token: 0x17004B5B RID: 19291
		// (get) Token: 0x06024A12 RID: 150034 RVA: 0x00A57D59 File Offset: 0x00A55F59
		// (set) Token: 0x06024A13 RID: 150035 RVA: 0x00A57D61 File Offset: 0x00A55F61
		public UUIVerticalLayout PanelListLayout { get; set; }

		// Token: 0x17004B5C RID: 19292
		// (get) Token: 0x06024A14 RID: 150036 RVA: 0x00A57D6A File Offset: 0x00A55F6A
		// (set) Token: 0x06024A15 RID: 150037 RVA: 0x00A57D72 File Offset: 0x00A55F72
		public UUIButtonComponent DelButton { get; set; }

		// Token: 0x17004B5D RID: 19293
		// (get) Token: 0x06024A16 RID: 150038 RVA: 0x00A57D7B File Offset: 0x00A55F7B
		// (set) Token: 0x06024A17 RID: 150039 RVA: 0x00A57D83 File Offset: 0x00A55F83
		public MapTipsActivateTipPanel MapTipsActivateTipPanel { get; set; }

		// Token: 0x17004B5E RID: 19294
		// (get) Token: 0x06024A18 RID: 150040 RVA: 0x00A57D8C File Offset: 0x00A55F8C
		// (set) Token: 0x06024A19 RID: 150041 RVA: 0x00A57D94 File Offset: 0x00A55F94
		public bool TakeAction { get; set; }

		// Token: 0x06024A1A RID: 150042 RVA: 0x00A57D9D File Offset: 0x00A55F9D
		[NullableContext(1)]
		public void SetConfirmBtnItem(ButtonItem item)
		{
			this.ConfirmButtonItem = item;
		}

		// Token: 0x06024A1B RID: 150043 RVA: 0x00A57DA6 File Offset: 0x00A55FA6
		public void SetConfirmBtnActive(bool active)
		{
			ButtonItem confirmButtonItem = this.ConfirmButtonItem;
			if (confirmButtonItem != null)
			{
				confirmButtonItem.SetActive(active);
			}
			this.IsConfirmBtnActiveInner = active;
		}

		// Token: 0x06024A1C RID: 150044 RVA: 0x00A57DC1 File Offset: 0x00A55FC1
		public bool GetIsConfirmBtnActive()
		{
			return this.ConfirmButtonItem != null && this.IsConfirmBtnActiveInner;
		}

		// Token: 0x06024A1D RID: 150045 RVA: 0x00A57DD3 File Offset: 0x00A55FD3
		[NullableContext(1)]
		public void SetConfirmBtnText([Nullable(2)] string textId, params object[] args)
		{
			if (textId == null)
			{
				return;
			}
			ButtonItem confirmButtonItem = this.ConfirmButtonItem;
			if (confirmButtonItem == null)
			{
				return;
			}
			confirmButtonItem.TrySetLocalTextNew(textId, args);
		}

		// Token: 0x06024A1E RID: 150046 RVA: 0x00A57DEB File Offset: 0x00A55FEB
		public void SetConfirmBtnEnableClick(bool state)
		{
			ButtonItem confirmButtonItem = this.ConfirmButtonItem;
			if (confirmButtonItem == null)
			{
				return;
			}
			confirmButtonItem.SetEnableClick(state);
		}

		// Token: 0x0401459D RID: 83357
		private ButtonItem ConfirmButtonItem;

		// Token: 0x040145A5 RID: 83365
		private bool IsConfirmBtnActiveInner = true;
	}
}
