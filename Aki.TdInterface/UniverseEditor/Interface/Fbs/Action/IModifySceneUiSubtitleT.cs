using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007205 RID: 29189
	public class IModifySceneUiSubtitleT
	{
		// Token: 0x1700D5A1 RID: 54689
		// (get) Token: 0x06032C76 RID: 207990 RVA: 0x006DBBDD File Offset: 0x006D9DDD
		// (set) Token: 0x06032C77 RID: 207991 RVA: 0x006DBBE5 File Offset: 0x006D9DE5
		public TSceneUiSubtitleOperationUnion Config { get; set; }

		// Token: 0x06032C78 RID: 207992 RVA: 0x006DBBEE File Offset: 0x006D9DEE
		public IModifySceneUiSubtitleT()
		{
			this.Config = null;
		}
	}
}
