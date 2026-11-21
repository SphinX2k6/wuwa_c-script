using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007134 RID: 28980
	public class ILiveStartInteractDanmakuConfigT
	{
		// Token: 0x1700D42C RID: 54316
		// (get) Token: 0x06032592 RID: 206226 RVA: 0x006CECC7 File Offset: 0x006CCEC7
		// (set) Token: 0x06032593 RID: 206227 RVA: 0x006CECCF File Offset: 0x006CCECF
		public ELiveDanmakuOperationType Type { get; set; }

		// Token: 0x1700D42D RID: 54317
		// (get) Token: 0x06032594 RID: 206228 RVA: 0x006CECD8 File Offset: 0x006CCED8
		// (set) Token: 0x06032595 RID: 206229 RVA: 0x006CECE0 File Offset: 0x006CCEE0
		public List<ILiveInteractDanmakuListenerGroupT> ListenerGroups { get; set; }

		// Token: 0x06032596 RID: 206230 RVA: 0x006CECE9 File Offset: 0x006CCEE9
		public ILiveStartInteractDanmakuConfigT()
		{
			this.Type = ELiveDanmakuOperationType.Load;
			this.ListenerGroups = null;
		}
	}
}
