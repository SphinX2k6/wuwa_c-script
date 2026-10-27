using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006865 RID: 26725
	public class IFoxReversePushT
	{
		// Token: 0x1700C686 RID: 50822
		// (get) Token: 0x0602E9B1 RID: 190897 RVA: 0x0065B5B1 File Offset: 0x006597B1
		// (set) Token: 0x0602E9B2 RID: 190898 RVA: 0x0065B5B9 File Offset: 0x006597B9
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700C687 RID: 50823
		// (get) Token: 0x0602E9B3 RID: 190899 RVA: 0x0065B5C2 File Offset: 0x006597C2
		// (set) Token: 0x0602E9B4 RID: 190900 RVA: 0x0065B5CA File Offset: 0x006597CA
		public int SplineEntityId { get; set; }

		// Token: 0x1700C688 RID: 50824
		// (get) Token: 0x0602E9B5 RID: 190901 RVA: 0x0065B5D3 File Offset: 0x006597D3
		// (set) Token: 0x0602E9B6 RID: 190902 RVA: 0x0065B5DB File Offset: 0x006597DB
		public int SeqEntityId { get; set; }

		// Token: 0x1700C689 RID: 50825
		// (get) Token: 0x0602E9B7 RID: 190903 RVA: 0x0065B5E4 File Offset: 0x006597E4
		// (set) Token: 0x0602E9B8 RID: 190904 RVA: 0x0065B5EC File Offset: 0x006597EC
		public string SliderTag { get; set; }

		// Token: 0x1700C68A RID: 50826
		// (get) Token: 0x0602E9B9 RID: 190905 RVA: 0x0065B5F5 File Offset: 0x006597F5
		// (set) Token: 0x0602E9BA RID: 190906 RVA: 0x0065B5FD File Offset: 0x006597FD
		public float Radius { get; set; }

		// Token: 0x0602E9BB RID: 190907 RVA: 0x0065B606 File Offset: 0x00659806
		public IFoxReversePushT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.SplineEntityId = 0;
			this.SeqEntityId = 0;
			this.SliderTag = null;
			this.Radius = 0f;
		}
	}
}
