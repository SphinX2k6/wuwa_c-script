using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x02004822 RID: 18466
	public class IRefSourceT
	{
		// Token: 0x170080E1 RID: 32993
		// (get) Token: 0x0601B567 RID: 111975 RVA: 0x003DF81E File Offset: 0x003DDA1E
		// (set) Token: 0x0601B568 RID: 111976 RVA: 0x003DF826 File Offset: 0x003DDA26
		public ERefSourceType Type { get; set; }

		// Token: 0x0601B569 RID: 111977 RVA: 0x003DF82F File Offset: 0x003DDA2F
		public IRefSourceT()
		{
			this.Type = ERefSourceType.AwakeEntity;
		}
	}
}
