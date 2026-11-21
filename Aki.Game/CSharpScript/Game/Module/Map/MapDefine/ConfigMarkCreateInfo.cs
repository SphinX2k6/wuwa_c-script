using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02004523 RID: 17699
	public class ConfigMarkCreateInfo : MarkCreateInfo
	{
		// Token: 0x0602CA6A RID: 182890 RVA: 0x00C86435 File Offset: 0x00C84635
		public ConfigMarkCreateInfo(MapMark markConfig, int? markId) : base(EMarkCreateType.ConfigMark)
		{
			this.MarkConfig = markConfig;
			if (markId == null)
			{
				this.MarkId = markConfig.MarkId;
			}
		}

		// Token: 0x04017EDF RID: 98015
		public int MarkId;

		// Token: 0x04017EE0 RID: 98016
		public MapMark MarkConfig;
	}
}
