using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FDA RID: 20442
	public class IComponentBaseT
	{
		// Token: 0x1700941F RID: 37919
		// (get) Token: 0x06020913 RID: 133395 RVA: 0x00487644 File Offset: 0x00485844
		// (set) Token: 0x06020914 RID: 133396 RVA: 0x0048764C File Offset: 0x0048584C
		public bool Disabled { get; set; }

		// Token: 0x17009420 RID: 37920
		// (get) Token: 0x06020915 RID: 133397 RVA: 0x00487655 File Offset: 0x00485855
		// (set) Token: 0x06020916 RID: 133398 RVA: 0x0048765D File Offset: 0x0048585D
		public byte NullMask { get; set; }

		// Token: 0x06020917 RID: 133399 RVA: 0x00487666 File Offset: 0x00485866
		public IComponentBaseT()
		{
			this.Disabled = false;
			this.NullMask = 0;
		}
	}
}
