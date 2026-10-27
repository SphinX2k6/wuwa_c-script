using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046C1 RID: 18113
	public class ITeleportToLevelPlayCenterT
	{
		// Token: 0x170080B4 RID: 32948
		// (get) Token: 0x0601B88F RID: 112783 RVA: 0x003E83AC File Offset: 0x003E65AC
		// (set) Token: 0x0601B890 RID: 112784 RVA: 0x003E83B4 File Offset: 0x003E65B4
		public EGmCommand Type { get; set; }

		// Token: 0x170080B5 RID: 32949
		// (get) Token: 0x0601B891 RID: 112785 RVA: 0x003E83BD File Offset: 0x003E65BD
		// (set) Token: 0x0601B892 RID: 112786 RVA: 0x003E83C5 File Offset: 0x003E65C5
		public int LevelPlayId { get; set; }

		// Token: 0x0601B893 RID: 112787 RVA: 0x003E83CE File Offset: 0x003E65CE
		public ITeleportToLevelPlayCenterT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.LevelPlayId = 0;
		}
	}
}
