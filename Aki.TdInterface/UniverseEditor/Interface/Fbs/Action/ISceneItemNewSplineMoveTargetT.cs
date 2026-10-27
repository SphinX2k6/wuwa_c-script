using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F40 RID: 28480
	public class ISceneItemNewSplineMoveTargetT
	{
		// Token: 0x1700D3A6 RID: 54182
		// (get) Token: 0x06032513 RID: 206099 RVA: 0x006CBA40 File Offset: 0x006C9C40
		// (set) Token: 0x06032514 RID: 206100 RVA: 0x006CBA48 File Offset: 0x006C9C48
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x1700D3A7 RID: 54183
		// (get) Token: 0x06032515 RID: 206101 RVA: 0x006CBA51 File Offset: 0x006C9C51
		// (set) Token: 0x06032516 RID: 206102 RVA: 0x006CBA59 File Offset: 0x006C9C59
		public int EntityId { get; set; }

		// Token: 0x1700D3A8 RID: 54184
		// (get) Token: 0x06032517 RID: 206103 RVA: 0x006CBA62 File Offset: 0x006C9C62
		// (set) Token: 0x06032518 RID: 206104 RVA: 0x006CBA6A File Offset: 0x006C9C6A
		public bool IsLookDir { get; set; }

		// Token: 0x1700D3A9 RID: 54185
		// (get) Token: 0x06032519 RID: 206105 RVA: 0x006CBA73 File Offset: 0x006C9C73
		// (set) Token: 0x0603251A RID: 206106 RVA: 0x006CBA7B File Offset: 0x006C9C7B
		public byte NullMask { get; set; }

		// Token: 0x0603251B RID: 206107 RVA: 0x006CBA84 File Offset: 0x006C9C84
		public ISceneItemNewSplineMoveTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
			this.EntityId = 0;
			this.IsLookDir = false;
			this.NullMask = 0;
		}
	}
}
