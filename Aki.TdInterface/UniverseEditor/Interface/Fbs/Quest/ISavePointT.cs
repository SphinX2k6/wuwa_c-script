using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004545 RID: 17733
	public class ISavePointT
	{
		// Token: 0x17007B54 RID: 31572
		// (get) Token: 0x06019AE8 RID: 105192 RVA: 0x003A81F3 File Offset: 0x003A63F3
		// (set) Token: 0x06019AE9 RID: 105193 RVA: 0x003A81FB File Offset: 0x003A63FB
		public ESaveConfig Type { get; set; }

		// Token: 0x17007B55 RID: 31573
		// (get) Token: 0x06019AEA RID: 105194 RVA: 0x003A8204 File Offset: 0x003A6404
		// (set) Token: 0x06019AEB RID: 105195 RVA: 0x003A820C File Offset: 0x003A640C
		public bool RelinkRollback { get; set; }

		// Token: 0x17007B56 RID: 31574
		// (get) Token: 0x06019AEC RID: 105196 RVA: 0x003A8215 File Offset: 0x003A6415
		// (set) Token: 0x06019AED RID: 105197 RVA: 0x003A821D File Offset: 0x003A641D
		public IPositionRollbackConfigT PosRollbackCfg { get; set; }

		// Token: 0x17007B57 RID: 31575
		// (get) Token: 0x06019AEE RID: 105198 RVA: 0x003A8226 File Offset: 0x003A6426
		// (set) Token: 0x06019AEF RID: 105199 RVA: 0x003A822E File Offset: 0x003A642E
		public byte NullMask { get; set; }

		// Token: 0x06019AF0 RID: 105200 RVA: 0x003A8237 File Offset: 0x003A6437
		public ISavePointT()
		{
			this.Type = ESaveConfig.SaveNew;
			this.RelinkRollback = false;
			this.PosRollbackCfg = null;
			this.NullMask = 0;
		}
	}
}
