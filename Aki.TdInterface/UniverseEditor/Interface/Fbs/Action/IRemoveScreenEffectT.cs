using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E6B RID: 28267
	public class IRemoveScreenEffectT
	{
		// Token: 0x1700D28A RID: 53898
		// (get) Token: 0x06031F40 RID: 204608 RVA: 0x006C1F93 File Offset: 0x006C0193
		// (set) Token: 0x06031F41 RID: 204609 RVA: 0x006C1F9B File Offset: 0x006C019B
		public EEffectType Type { get; set; }

		// Token: 0x1700D28B RID: 53899
		// (get) Token: 0x06031F42 RID: 204610 RVA: 0x006C1FA4 File Offset: 0x006C01A4
		// (set) Token: 0x06031F43 RID: 204611 RVA: 0x006C1FAC File Offset: 0x006C01AC
		public string Path { get; set; }

		// Token: 0x06031F44 RID: 204612 RVA: 0x006C1FB5 File Offset: 0x006C01B5
		public IRemoveScreenEffectT()
		{
			this.Type = EEffectType.Effect;
			this.Path = null;
		}
	}
}
