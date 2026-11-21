using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B41 RID: 23361
	public class IMonsterSummonInteractPointT
	{
		// Token: 0x1700AA75 RID: 43637
		// (get) Token: 0x060266C0 RID: 157376 RVA: 0x00543033 File Offset: 0x00541233
		// (set) Token: 0x060266C1 RID: 157377 RVA: 0x0054303B File Offset: 0x0054123B
		public EExploreSkillInteractType Type { get; set; }

		// Token: 0x1700AA76 RID: 43638
		// (get) Token: 0x060266C2 RID: 157378 RVA: 0x00543044 File Offset: 0x00541244
		// (set) Token: 0x060266C3 RID: 157379 RVA: 0x0054304C File Offset: 0x0054124C
		public float Range { get; set; }

		// Token: 0x1700AA77 RID: 43639
		// (get) Token: 0x060266C4 RID: 157380 RVA: 0x00543055 File Offset: 0x00541255
		// (set) Token: 0x060266C5 RID: 157381 RVA: 0x0054305D File Offset: 0x0054125D
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700AA78 RID: 43640
		// (get) Token: 0x060266C6 RID: 157382 RVA: 0x00543066 File Offset: 0x00541266
		// (set) Token: 0x060266C7 RID: 157383 RVA: 0x0054306E File Offset: 0x0054126E
		public byte NullMask { get; set; }

		// Token: 0x060266C8 RID: 157384 RVA: 0x00543077 File Offset: 0x00541277
		public IMonsterSummonInteractPointT()
		{
			this.Type = EExploreSkillInteractType.PullGiant;
			this.Range = 0f;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
