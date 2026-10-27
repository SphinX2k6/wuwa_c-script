using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D8A RID: 28042
	public class IPreloadActionT
	{
		// Token: 0x1700D136 RID: 53558
		// (get) Token: 0x0603189B RID: 202907 RVA: 0x006B7001 File Offset: 0x006B5201
		// (set) Token: 0x0603189C RID: 202908 RVA: 0x006B7009 File Offset: 0x006B5209
		public TPreloadObjectTypeConfigUnion PreloadObjectType { get; set; }

		// Token: 0x0603189D RID: 202909 RVA: 0x006B7012 File Offset: 0x006B5212
		public IPreloadActionT()
		{
			this.PreloadObjectType = null;
		}
	}
}
