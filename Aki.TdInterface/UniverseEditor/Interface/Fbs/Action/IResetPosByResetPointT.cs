using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EA4 RID: 28324
	public class IResetPosByResetPointT
	{
		// Token: 0x1700D2E4 RID: 53988
		// (get) Token: 0x060320FF RID: 205055 RVA: 0x006C5316 File Offset: 0x006C3516
		// (set) Token: 0x06032100 RID: 205056 RVA: 0x006C531E File Offset: 0x006C351E
		public EResetPosType Type { get; set; }

		// Token: 0x06032101 RID: 205057 RVA: 0x006C5327 File Offset: 0x006C3527
		public IResetPosByResetPointT()
		{
			this.Type = EResetPosType.PosEntity;
		}
	}
}
