using System;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004086 RID: 16518
	public class IVolumeTriggerShapeT
	{
		// Token: 0x17007076 RID: 28790
		// (get) Token: 0x06016BF5 RID: 93173 RVA: 0x0033FCDF File Offset: 0x0033DEDF
		// (set) Token: 0x06016BF6 RID: 93174 RVA: 0x0033FCE7 File Offset: 0x0033DEE7
		public ETriggerShape Type { get; set; }

		// Token: 0x17007077 RID: 28791
		// (get) Token: 0x06016BF7 RID: 93175 RVA: 0x0033FCF0 File Offset: 0x0033DEF0
		// (set) Token: 0x06016BF8 RID: 93176 RVA: 0x0033FCF8 File Offset: 0x0033DEF8
		public string VolumeKey { get; set; }

		// Token: 0x06016BF9 RID: 93177 RVA: 0x0033FD01 File Offset: 0x0033DF01
		public IVolumeTriggerShapeT()
		{
			this.Type = ETriggerShape.Box;
			this.VolumeKey = null;
		}
	}
}
