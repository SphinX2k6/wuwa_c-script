using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075EF RID: 30191
	public class IRemoveScreenEffectT
	{
		// Token: 0x1700DDE1 RID: 56801
		// (get) Token: 0x06034F80 RID: 216960 RVA: 0x0071DCC7 File Offset: 0x0071BEC7
		// (set) Token: 0x06034F81 RID: 216961 RVA: 0x0071DCCF File Offset: 0x0071BECF
		public EEffectType Type { get; set; }

		// Token: 0x1700DDE2 RID: 56802
		// (get) Token: 0x06034F82 RID: 216962 RVA: 0x0071DCD8 File Offset: 0x0071BED8
		// (set) Token: 0x06034F83 RID: 216963 RVA: 0x0071DCE0 File Offset: 0x0071BEE0
		public string Path { get; set; }

		// Token: 0x06034F84 RID: 216964 RVA: 0x0071DCE9 File Offset: 0x0071BEE9
		public IRemoveScreenEffectT()
		{
			this.Type = EEffectType.Effect;
			this.Path = null;
		}
	}
}
