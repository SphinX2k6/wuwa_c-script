using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD9 RID: 27865
	public class IPlayCommonEffectT
	{
		// Token: 0x1700CF80 RID: 53120
		// (get) Token: 0x060311F2 RID: 201202 RVA: 0x006AA663 File Offset: 0x006A8863
		// (set) Token: 0x060311F3 RID: 201203 RVA: 0x006AA66B File Offset: 0x006A886B
		public EEffectType Type { get; set; }

		// Token: 0x1700CF81 RID: 53121
		// (get) Token: 0x060311F4 RID: 201204 RVA: 0x006AA674 File Offset: 0x006A8874
		// (set) Token: 0x060311F5 RID: 201205 RVA: 0x006AA67C File Offset: 0x006A887C
		public string Path { get; set; }

		// Token: 0x1700CF82 RID: 53122
		// (get) Token: 0x060311F6 RID: 201206 RVA: 0x006AA685 File Offset: 0x006A8885
		// (set) Token: 0x060311F7 RID: 201207 RVA: 0x006AA68D File Offset: 0x006A888D
		public TEffectPos2Union Pos2 { get; set; }

		// Token: 0x1700CF83 RID: 53123
		// (get) Token: 0x060311F8 RID: 201208 RVA: 0x006AA696 File Offset: 0x006A8896
		// (set) Token: 0x060311F9 RID: 201209 RVA: 0x006AA69E File Offset: 0x006A889E
		public float DestroyTime { get; set; }

		// Token: 0x1700CF84 RID: 53124
		// (get) Token: 0x060311FA RID: 201210 RVA: 0x006AA6A7 File Offset: 0x006A88A7
		// (set) Token: 0x060311FB RID: 201211 RVA: 0x006AA6AF File Offset: 0x006A88AF
		public bool PlayEffectEnd { get; set; }

		// Token: 0x1700CF85 RID: 53125
		// (get) Token: 0x060311FC RID: 201212 RVA: 0x006AA6B8 File Offset: 0x006A88B8
		// (set) Token: 0x060311FD RID: 201213 RVA: 0x006AA6C0 File Offset: 0x006A88C0
		public byte NullMask { get; set; }

		// Token: 0x060311FE RID: 201214 RVA: 0x006AA6C9 File Offset: 0x006A88C9
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
