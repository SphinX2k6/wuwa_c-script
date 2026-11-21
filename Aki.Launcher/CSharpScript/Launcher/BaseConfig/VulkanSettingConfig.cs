using System;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200026B RID: 619
	public class VulkanSettingConfig
	{
		// Token: 0x04000A3D RID: 2621
		[JsonConverter(typeof(VulkanSettingIntegerConverter))]
		public int? DefaultValue;

		// Token: 0x04000A3E RID: 2622
		[JsonConverter(typeof(VulkanSettingIntegerConverter))]
		public int? Revision;
	}
}
