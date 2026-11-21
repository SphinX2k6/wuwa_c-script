using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A4D RID: 19021
	public class ITwoDimensionTransformT
	{
		// Token: 0x17008578 RID: 34168
		// (get) Token: 0x0601C950 RID: 117072 RVA: 0x004088A7 File Offset: 0x00406AA7
		// (set) Token: 0x0601C951 RID: 117073 RVA: 0x004088AF File Offset: 0x00406AAF
		public IVector2T Position { get; set; }

		// Token: 0x17008579 RID: 34169
		// (get) Token: 0x0601C952 RID: 117074 RVA: 0x004088B8 File Offset: 0x00406AB8
		// (set) Token: 0x0601C953 RID: 117075 RVA: 0x004088C0 File Offset: 0x00406AC0
		public float Rotation { get; set; }

		// Token: 0x0601C954 RID: 117076 RVA: 0x004088C9 File Offset: 0x00406AC9
		public ITwoDimensionTransformT()
		{
			this.Position = null;
			this.Rotation = 0f;
		}
	}
}
