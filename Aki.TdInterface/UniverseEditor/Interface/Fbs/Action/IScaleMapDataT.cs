using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076A0 RID: 30368
	public class IScaleMapDataT
	{
		// Token: 0x1700DECE RID: 57038
		// (get) Token: 0x0603545D RID: 218205 RVA: 0x00725D2F File Offset: 0x00723F2F
		// (set) Token: 0x0603545E RID: 218206 RVA: 0x00725D37 File Offset: 0x00723F37
		public string Key { get; set; }

		// Token: 0x1700DECF RID: 57039
		// (get) Token: 0x0603545F RID: 218207 RVA: 0x00725D40 File Offset: 0x00723F40
		// (set) Token: 0x06035460 RID: 218208 RVA: 0x00725D48 File Offset: 0x00723F48
		public float Scale { get; set; }

		// Token: 0x06035461 RID: 218209 RVA: 0x00725D51 File Offset: 0x00723F51
		public IScaleMapDataT()
		{
			this.Key = null;
			this.Scale = 0f;
		}
	}
}
