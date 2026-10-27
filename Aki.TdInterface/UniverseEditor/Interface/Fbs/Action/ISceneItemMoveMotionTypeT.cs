using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F3A RID: 28474
	public class ISceneItemMoveMotionTypeT
	{
		// Token: 0x1700D39E RID: 54174
		// (get) Token: 0x060324ED RID: 206061 RVA: 0x006CB65A File Offset: 0x006C985A
		// (set) Token: 0x060324EE RID: 206062 RVA: 0x006CB662 File Offset: 0x006C9862
		public EMoveMotion Type { get; set; }

		// Token: 0x060324EF RID: 206063 RVA: 0x006CB66B File Offset: 0x006C986B
		public ISceneItemMoveMotionTypeT()
		{
			this.Type = EMoveMotion.UniformMotion;
		}
	}
}
