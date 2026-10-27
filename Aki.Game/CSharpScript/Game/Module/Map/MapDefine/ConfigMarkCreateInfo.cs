using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005551 RID: 21841
	public class ConfigMarkCreateInfo : MarkCreateInfo
	{
		// Token: 0x06037B9A RID: 228250 RVA: 0x00D38961 File Offset: 0x00D36B61
		public ConfigMarkCreateInfo(MapMark markConfig, int? markId) : base(EMarkCreateType.ConfigMark)
		{
			this.MarkConfig = markConfig;
			if (markId == null)
			{
				this.MarkId = markConfig.MarkId;
			}
		}

		// Token: 0x0401D456 RID: 119894
		public int MarkId;

		// Token: 0x0401D457 RID: 119895
		public MapMark MarkConfig;
	}
}
