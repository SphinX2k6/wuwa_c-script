using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C4 RID: 16836
	public class IConditionBtNodeT
	{
		// Token: 0x17007262 RID: 29282
		// (get) Token: 0x06017496 RID: 95382 RVA: 0x0035314E File Offset: 0x0035134E
		// (set) Token: 0x06017497 RID: 95383 RVA: 0x00353156 File Offset: 0x00351356
		public EBtNode Type { get; set; }

		// Token: 0x17007263 RID: 29283
		// (get) Token: 0x06017498 RID: 95384 RVA: 0x0035315F File Offset: 0x0035135F
		// (set) Token: 0x06017499 RID: 95385 RVA: 0x00353167 File Offset: 0x00351367
		public int Id { get; set; }

		// Token: 0x17007264 RID: 29284
		// (get) Token: 0x0601749A RID: 95386 RVA: 0x00353170 File Offset: 0x00351370
		// (set) Token: 0x0601749B RID: 95387 RVA: 0x00353178 File Offset: 0x00351378
		public string Desc { get; set; }

		// Token: 0x17007265 RID: 29285
		// (get) Token: 0x0601749C RID: 95388 RVA: 0x00353181 File Offset: 0x00351381
		// (set) Token: 0x0601749D RID: 95389 RVA: 0x00353189 File Offset: 0x00351389
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17007266 RID: 29286
		// (get) Token: 0x0601749E RID: 95390 RVA: 0x00353192 File Offset: 0x00351392
		// (set) Token: 0x0601749F RID: 95391 RVA: 0x0035319A File Offset: 0x0035139A
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007267 RID: 29287
		// (get) Token: 0x060174A0 RID: 95392 RVA: 0x003531A3 File Offset: 0x003513A3
		// (set) Token: 0x060174A1 RID: 95393 RVA: 0x003531AB File Offset: 0x003513AB
		public bool Disabled { get; set; }

		// Token: 0x17007268 RID: 29288
		// (get) Token: 0x060174A2 RID: 95394 RVA: 0x003531B4 File Offset: 0x003513B4
		// (set) Token: 0x060174A3 RID: 95395 RVA: 0x003531BC File Offset: 0x003513BC
		public IConditionGroupT Condition { get; set; }

		// Token: 0x17007269 RID: 29289
		// (get) Token: 0x060174A4 RID: 95396 RVA: 0x003531C5 File Offset: 0x003513C5
		// (set) Token: 0x060174A5 RID: 95397 RVA: 0x003531CD File Offset: 0x003513CD
		public bool WaitUntilTrue { get; set; }

		// Token: 0x1700726A RID: 29290
		// (get) Token: 0x060174A6 RID: 95398 RVA: 0x003531D6 File Offset: 0x003513D6
		// (set) Token: 0x060174A7 RID: 95399 RVA: 0x003531DE File Offset: 0x003513DE
		public byte NullMask { get; set; }

		// Token: 0x060174A8 RID: 95400 RVA: 0x003531E8 File Offset: 0x003513E8
		public IConditionBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.Condition = null;
			this.WaitUntilTrue = false;
			this.NullMask = 0;
		}
	}
}
