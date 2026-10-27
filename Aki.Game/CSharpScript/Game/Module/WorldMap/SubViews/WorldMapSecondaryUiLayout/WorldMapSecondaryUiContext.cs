using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Module.WorldMap.SubViews.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapSecondaryUiLayout
{
	// Token: 0x020047C6 RID: 18374
	[NullableContext(2)]
	[Nullable(0)]
	public class WorldMapSecondaryUiContext
	{
		// Token: 0x17007894 RID: 30868
		// (get) Token: 0x0603022E RID: 197166 RVA: 0x00B27EA3 File Offset: 0x00B260A3
		// (set) Token: 0x0603022F RID: 197167 RVA: 0x00B27EAB File Offset: 0x00B260AB
		public MarkItem MarkItem { get; set; }

		// Token: 0x17007895 RID: 30869
		// (get) Token: 0x06030230 RID: 197168 RVA: 0x00B27EB4 File Offset: 0x00B260B4
		// (set) Token: 0x06030231 RID: 197169 RVA: 0x00B27EBC File Offset: 0x00B260BC
		public TSetSpriteByPathAction SetSpriteByPathAction { get; set; }

		// Token: 0x17007896 RID: 30870
		// (get) Token: 0x06030232 RID: 197170 RVA: 0x00B27EC5 File Offset: 0x00B260C5
		// (set) Token: 0x06030233 RID: 197171 RVA: 0x00B27ECD File Offset: 0x00B260CD
		public UUISprite Icon { get; set; }

		// Token: 0x17007897 RID: 30871
		// (get) Token: 0x06030234 RID: 197172 RVA: 0x00B27ED6 File Offset: 0x00B260D6
		// (set) Token: 0x06030235 RID: 197173 RVA: 0x00B27EDE File Offset: 0x00B260DE
		public UUIText Title { get; set; }

		// Token: 0x17007898 RID: 30872
		// (get) Token: 0x06030236 RID: 197174 RVA: 0x00B27EE7 File Offset: 0x00B260E7
		// (set) Token: 0x06030237 RID: 197175 RVA: 0x00B27EEF File Offset: 0x00B260EF
		public UUIText AreaText { get; set; }

		// Token: 0x17007899 RID: 30873
		// (get) Token: 0x06030238 RID: 197176 RVA: 0x00B27EF8 File Offset: 0x00B260F8
		// (set) Token: 0x06030239 RID: 197177 RVA: 0x00B27F00 File Offset: 0x00B26100
		public UUIItem AreaIconItem { get; set; }

		// Token: 0x1700789A RID: 30874
		// (get) Token: 0x0603023A RID: 197178 RVA: 0x00B27F09 File Offset: 0x00B26109
		// (set) Token: 0x0603023B RID: 197179 RVA: 0x00B27F11 File Offset: 0x00B26111
		public UUIText DescriptionText { get; set; }

		// Token: 0x1700789B RID: 30875
		// (get) Token: 0x0603023C RID: 197180 RVA: 0x00B27F1A File Offset: 0x00B2611A
		// (set) Token: 0x0603023D RID: 197181 RVA: 0x00B27F22 File Offset: 0x00B26122
		public ButtonItem TrackButtonItem { get; set; }

		// Token: 0x1700789C RID: 30876
		// (get) Token: 0x0603023E RID: 197182 RVA: 0x00B27F2B File Offset: 0x00B2612B
		// (set) Token: 0x0603023F RID: 197183 RVA: 0x00B27F33 File Offset: 0x00B26133
		public UUISprite DownStateIcon { get; set; }

		// Token: 0x1700789D RID: 30877
		// (get) Token: 0x06030240 RID: 197184 RVA: 0x00B27F3C File Offset: 0x00B2613C
		// (set) Token: 0x06030241 RID: 197185 RVA: 0x00B27F44 File Offset: 0x00B26144
		public UUIItem PanelProgressItem { get; set; }

		// Token: 0x1700789E RID: 30878
		// (get) Token: 0x06030242 RID: 197186 RVA: 0x00B27F4D File Offset: 0x00B2614D
		// (set) Token: 0x06030243 RID: 197187 RVA: 0x00B27F55 File Offset: 0x00B26155
		public UUIVerticalLayout PanelListLayout { get; set; }

		// Token: 0x1700789F RID: 30879
		// (get) Token: 0x06030244 RID: 197188 RVA: 0x00B27F5E File Offset: 0x00B2615E
		// (set) Token: 0x06030245 RID: 197189 RVA: 0x00B27F66 File Offset: 0x00B26166
		public UUIButtonComponent DelButton { get; set; }

		// Token: 0x170078A0 RID: 30880
		// (get) Token: 0x06030246 RID: 197190 RVA: 0x00B27F6F File Offset: 0x00B2616F
		// (set) Token: 0x06030247 RID: 197191 RVA: 0x00B27F77 File Offset: 0x00B26177
		public MapTipsActivateTipPanel MapTipsActivateTipPanel { get; set; }

		// Token: 0x170078A1 RID: 30881
		// (get) Token: 0x06030248 RID: 197192 RVA: 0x00B27F80 File Offset: 0x00B26180
		// (set) Token: 0x06030249 RID: 197193 RVA: 0x00B27F88 File Offset: 0x00B26188
		public bool TakeAction { get; set; }

		// Token: 0x0603024A RID: 197194 RVA: 0x00B27F91 File Offset: 0x00B26191
		[NullableContext(1)]
		public void SetConfirmBtnItem(ButtonItem item)
		{
			this.ConfirmButtonItem = item;
		}

		// Token: 0x0603024B RID: 197195 RVA: 0x00B27F9A File Offset: 0x00B2619A
		public void SetConfirmBtnActive(bool active)
		{
			ButtonItem confirmButtonItem = this.ConfirmButtonItem;
			if (confirmButtonItem != null)
			{
				confirmButtonItem.SetActive(active);
			}
			this.IsConfirmBtnActiveInner = active;
		}

		// Token: 0x0603024C RID: 197196 RVA: 0x00B27FB5 File Offset: 0x00B261B5
		public bool GetIsConfirmBtnActive()
		{
			return this.ConfirmButtonItem != null && this.IsConfirmBtnActiveInner;
		}

		// Token: 0x0603024D RID: 197197 RVA: 0x00B27FC7 File Offset: 0x00B261C7
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

		// Token: 0x0603024E RID: 197198 RVA: 0x00B27FDF File Offset: 0x00B261DF
		public void SetConfirmBtnEnableClick(bool state)
		{
			ButtonItem confirmButtonItem = this.ConfirmButtonItem;
			if (confirmButtonItem == null)
			{
				return;
			}
			confirmButtonItem.SetEnableClick(state);
		}

		// Token: 0x04019EEC RID: 106220
		private ButtonItem ConfirmButtonItem;

		// Token: 0x04019EF4 RID: 106228
		private bool IsConfirmBtnActiveInner = true;
	}
}
