using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007113 RID: 28947
	public class ILiveLoadDanmakuConfigT
	{
		// Token: 0x1700D403 RID: 54275
		// (get) Token: 0x06032495 RID: 205973 RVA: 0x006CCD63 File Offset: 0x006CAF63
		// (set) Token: 0x06032496 RID: 205974 RVA: 0x006CCD6B File Offset: 0x006CAF6B
		public ELiveDanmakuOperationType Type { get; set; }

		// Token: 0x1700D404 RID: 54276
		// (get) Token: 0x06032497 RID: 205975 RVA: 0x006CCD74 File Offset: 0x006CAF74
		// (set) Token: 0x06032498 RID: 205976 RVA: 0x006CCD7C File Offset: 0x006CAF7C
		public List<ILiveDanmakuPoolT> DanmakuPools { get; set; }

		// Token: 0x1700D405 RID: 54277
		// (get) Token: 0x06032499 RID: 205977 RVA: 0x006CCD85 File Offset: 0x006CAF85
		// (set) Token: 0x0603249A RID: 205978 RVA: 0x006CCD8D File Offset: 0x006CAF8D
		public float SendInterval { get; set; }

		// Token: 0x1700D406 RID: 54278
		// (get) Token: 0x0603249B RID: 205979 RVA: 0x006CCD96 File Offset: 0x006CAF96
		// (set) Token: 0x0603249C RID: 205980 RVA: 0x006CCD9E File Offset: 0x006CAF9E
		public int TrackCount { get; set; }

		// Token: 0x1700D407 RID: 54279
		// (get) Token: 0x0603249D RID: 205981 RVA: 0x006CCDA7 File Offset: 0x006CAFA7
		// (set) Token: 0x0603249E RID: 205982 RVA: 0x006CCDAF File Offset: 0x006CAFAF
		public ELiveDanmakuLinkType LinkType { get; set; }

		// Token: 0x1700D408 RID: 54280
		// (get) Token: 0x0603249F RID: 205983 RVA: 0x006CCDB8 File Offset: 0x006CAFB8
		// (set) Token: 0x060324A0 RID: 205984 RVA: 0x006CCDC0 File Offset: 0x006CAFC0
		public byte NullMask { get; set; }

		// Token: 0x060324A1 RID: 205985 RVA: 0x006CCDC9 File Offset: 0x006CAFC9
		public ILiveLoadDanmakuConfigT()
		{
			this.Type = ELiveDanmakuOperationType.Load;
			this.DanmakuPools = null;
			this.SendInterval = 0f;
			this.TrackCount = 0;
			this.LinkType = ELiveDanmakuLinkType.KeepCurrent;
			this.NullMask = 0;
		}
	}
}
