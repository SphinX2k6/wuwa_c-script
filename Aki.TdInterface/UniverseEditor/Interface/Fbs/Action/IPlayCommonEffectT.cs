using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200744C RID: 29772
	public class IPlayCommonEffectT
	{
		// Token: 0x1700DABA RID: 55994
		// (get) Token: 0x060341B7 RID: 213431 RVA: 0x0070571F File Offset: 0x0070391F
		// (set) Token: 0x060341B8 RID: 213432 RVA: 0x00705727 File Offset: 0x00703927
		public EEffectType Type { get; set; }

		// Token: 0x1700DABB RID: 55995
		// (get) Token: 0x060341B9 RID: 213433 RVA: 0x00705730 File Offset: 0x00703930
		// (set) Token: 0x060341BA RID: 213434 RVA: 0x00705738 File Offset: 0x00703938
		public string Path { get; set; }

		// Token: 0x1700DABC RID: 55996
		// (get) Token: 0x060341BB RID: 213435 RVA: 0x00705741 File Offset: 0x00703941
		// (set) Token: 0x060341BC RID: 213436 RVA: 0x00705749 File Offset: 0x00703949
		public TEffectPos2Union Pos2 { get; set; }

		// Token: 0x1700DABD RID: 55997
		// (get) Token: 0x060341BD RID: 213437 RVA: 0x00705752 File Offset: 0x00703952
		// (set) Token: 0x060341BE RID: 213438 RVA: 0x0070575A File Offset: 0x0070395A
		public float DestroyTime { get; set; }

		// Token: 0x1700DABE RID: 55998
		// (get) Token: 0x060341BF RID: 213439 RVA: 0x00705763 File Offset: 0x00703963
		// (set) Token: 0x060341C0 RID: 213440 RVA: 0x0070576B File Offset: 0x0070396B
		public bool PlayEffectEnd { get; set; }

		// Token: 0x1700DABF RID: 55999
		// (get) Token: 0x060341C1 RID: 213441 RVA: 0x00705774 File Offset: 0x00703974
		// (set) Token: 0x060341C2 RID: 213442 RVA: 0x0070577C File Offset: 0x0070397C
		public byte NullMask { get; set; }

		// Token: 0x060341C3 RID: 213443 RVA: 0x00705785 File Offset: 0x00703985
		public IPlayCommonEffectT()
		{
			this.Type = EEffectType.Effect;
			this.Path = null;
			this.Pos2 = null;
			this.DestroyTime = 0f;
			this.PlayEffectEnd = false;
			this.NullMask = 0;
		}
	}
}
