using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A9 RID: 27049
	public class ICharacterGroupNewT
	{
		// Token: 0x1700C719 RID: 50969
		// (get) Token: 0x0602E667 RID: 190055 RVA: 0x006551C0 File Offset: 0x006533C0
		// (set) Token: 0x0602E668 RID: 190056 RVA: 0x006551C8 File Offset: 0x006533C8
		public int CharacterId { get; set; }

		// Token: 0x1700C71A RID: 50970
		// (get) Token: 0x0602E669 RID: 190057 RVA: 0x006551D1 File Offset: 0x006533D1
		// (set) Token: 0x0602E66A RID: 190058 RVA: 0x006551D9 File Offset: 0x006533D9
		public bool IsAiCharacter { get; set; }

		// Token: 0x0602E66B RID: 190059 RVA: 0x006551E2 File Offset: 0x006533E2
		public ICharacterGroupNewT()
		{
			this.CharacterId = 0;
			this.IsAiCharacter = false;
		}
	}
}
