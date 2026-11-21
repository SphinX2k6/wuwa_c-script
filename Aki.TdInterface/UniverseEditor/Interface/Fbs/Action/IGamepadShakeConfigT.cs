using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F0F RID: 28431
	public class IGamepadShakeConfigT
	{
		// Token: 0x1700D07D RID: 53373
		// (get) Token: 0x0603133D RID: 201533 RVA: 0x006AAEA2 File Offset: 0x006A90A2
		// (set) Token: 0x0603133E RID: 201534 RVA: 0x006AAEAA File Offset: 0x006A90AA
		public EGamepadShakeType Type { get; set; }

		// Token: 0x0603133F RID: 201535 RVA: 0x006AAEB3 File Offset: 0x006A90B3
		public IGamepadShakeConfigT()
		{
			this.Type = EGamepadShakeType.Onetime;
		}
	}
}
