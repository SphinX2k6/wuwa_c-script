using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A7 RID: 22183
	public class IElementDamageT
	{
		// Token: 0x17009F99 RID: 40857
		// (get) Token: 0x06023856 RID: 145494 RVA: 0x004E2CFE File Offset: 0x004E0EFE
		// (set) Token: 0x06023857 RID: 145495 RVA: 0x004E2D06 File Offset: 0x004E0F06
		public int DefaultValue { get; set; }

		// Token: 0x17009F9A RID: 40858
		// (get) Token: 0x06023858 RID: 145496 RVA: 0x004E2D0F File Offset: 0x004E0F0F
		// (set) Token: 0x06023859 RID: 145497 RVA: 0x004E2D17 File Offset: 0x004E0F17
		public int Physics { get; set; }

		// Token: 0x17009F9B RID: 40859
		// (get) Token: 0x0602385A RID: 145498 RVA: 0x004E2D20 File Offset: 0x004E0F20
		// (set) Token: 0x0602385B RID: 145499 RVA: 0x004E2D28 File Offset: 0x004E0F28
		public int Ice { get; set; }

		// Token: 0x17009F9C RID: 40860
		// (get) Token: 0x0602385C RID: 145500 RVA: 0x004E2D31 File Offset: 0x004E0F31
		// (set) Token: 0x0602385D RID: 145501 RVA: 0x004E2D39 File Offset: 0x004E0F39
		public int Fire { get; set; }

		// Token: 0x17009F9D RID: 40861
		// (get) Token: 0x0602385E RID: 145502 RVA: 0x004E2D42 File Offset: 0x004E0F42
		// (set) Token: 0x0602385F RID: 145503 RVA: 0x004E2D4A File Offset: 0x004E0F4A
		public int Thunder { get; set; }

		// Token: 0x17009F9E RID: 40862
		// (get) Token: 0x06023860 RID: 145504 RVA: 0x004E2D53 File Offset: 0x004E0F53
		// (set) Token: 0x06023861 RID: 145505 RVA: 0x004E2D5B File Offset: 0x004E0F5B
		public int Wind { get; set; }

		// Token: 0x17009F9F RID: 40863
		// (get) Token: 0x06023862 RID: 145506 RVA: 0x004E2D64 File Offset: 0x004E0F64
		// (set) Token: 0x06023863 RID: 145507 RVA: 0x004E2D6C File Offset: 0x004E0F6C
		public int Light { get; set; }

		// Token: 0x17009FA0 RID: 40864
		// (get) Token: 0x06023864 RID: 145508 RVA: 0x004E2D75 File Offset: 0x004E0F75
		// (set) Token: 0x06023865 RID: 145509 RVA: 0x004E2D7D File Offset: 0x004E0F7D
		public int Dark { get; set; }

		// Token: 0x17009FA1 RID: 40865
		// (get) Token: 0x06023866 RID: 145510 RVA: 0x004E2D86 File Offset: 0x004E0F86
		// (set) Token: 0x06023867 RID: 145511 RVA: 0x004E2D8E File Offset: 0x004E0F8E
		public byte NullMask { get; set; }

		// Token: 0x06023868 RID: 145512 RVA: 0x004E2D98 File Offset: 0x004E0F98
		public IElementDamageT()
		{
			this.DefaultValue = 0;
			this.Physics = 0;
			this.Ice = 0;
			this.Fire = 0;
			this.Thunder = 0;
			this.Wind = 0;
			this.Light = 0;
			this.Dark = 0;
			this.NullMask = 0;
		}
	}
}
