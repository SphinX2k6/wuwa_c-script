using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200562A RID: 22058
	public class INpcModelConfigT
	{
		// Token: 0x1700A343 RID: 41795
		// (get) Token: 0x06024A07 RID: 150023 RVA: 0x0050D92E File Offset: 0x0050BB2E
		// (set) Token: 0x06024A08 RID: 150024 RVA: 0x0050D936 File Offset: 0x0050BB36
		public ENpcModelType Type { get; set; }

		// Token: 0x06024A09 RID: 150025 RVA: 0x0050D93F File Offset: 0x0050BB3F
		public INpcModelConfigT()
		{
			this.Type = ENpcModelType.Mesh;
		}
	}
}
