using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CCA RID: 27850
	public class IPictureCaptionConfigT
	{
		// Token: 0x1700CF59 RID: 53081
		// (get) Token: 0x06031161 RID: 201057 RVA: 0x006A9478 File Offset: 0x006A7678
		// (set) Token: 0x06031162 RID: 201058 RVA: 0x006A9480 File Offset: 0x006A7680
		public string PictureCaption { get; set; }

		// Token: 0x1700CF5A RID: 53082
		// (get) Token: 0x06031163 RID: 201059 RVA: 0x006A9489 File Offset: 0x006A7689
		// (set) Token: 0x06031164 RID: 201060 RVA: 0x006A9491 File Offset: 0x006A7691
		public string UiPrefabId { get; set; }

		// Token: 0x1700CF5B RID: 53083
		// (get) Token: 0x06031165 RID: 201061 RVA: 0x006A949A File Offset: 0x006A769A
		// (set) Token: 0x06031166 RID: 201062 RVA: 0x006A94A2 File Offset: 0x006A76A2
		public float Duration { get; set; }

		// Token: 0x1700CF5C RID: 53084
		// (get) Token: 0x06031167 RID: 201063 RVA: 0x006A94AB File Offset: 0x006A76AB
		// (set) Token: 0x06031168 RID: 201064 RVA: 0x006A94B3 File Offset: 0x006A76B3
		public IUiAnimConfigT UiAnimConfig { get; set; }

		// Token: 0x06031169 RID: 201065 RVA: 0x006A94BC File Offset: 0x006A76BC
		public IPictureCaptionConfigT()
		{
			this.PictureCaption = null;
			this.UiPrefabId = null;
			this.Duration = 0f;
			this.UiAnimConfig = null;
		}
	}
}
