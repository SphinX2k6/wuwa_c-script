using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006186 RID: 24966
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class LanguageKeyTransBase
	{
		// Token: 0x0603BE35 RID: 245301 RVA: 0x01104A48 File Offset: 0x01102C48
		public void InitPcKeysByConfig(PcKey config)
		{
			string otherPcKey = this.GetOtherPcKey(config);
			if (!StringUtils.IsBlank(otherPcKey))
			{
				this.NormalToOtherPcKeysMap[config.KeyName] = otherPcKey;
				this.OtherToNormalPcKeysMap[otherPcKey] = config.KeyName;
			}
		}

		// Token: 0x0603BE36 RID: 245302
		protected abstract string GetOtherPcKey(PcKey config);

		// Token: 0x0603BE37 RID: 245303
		public abstract string[] GetActionPcKeys(ActionMapping actionMappingConfig);

		// Token: 0x0603BE38 RID: 245304
		public abstract Dictionary<string, float> GetAxisPcKeys(AxisMapping axisMappingConfig);

		// Token: 0x0603BE39 RID: 245305
		public abstract Dictionary<string, string> GetCombinationActionPcKeys(CombinationAction combinationActionMappingConfig);

		// Token: 0x0603BE3A RID: 245306
		public abstract string GetPcKeyIconPath(PcKey config);

		// Token: 0x0603BE3B RID: 245307 RVA: 0x01104A8C File Offset: 0x01102C8C
		public string GetNormalToOtherPcKeysMap(string keyName)
		{
			string result;
			if (this.NormalToOtherPcKeysMap.TryGetValue(keyName, out result))
			{
				return result;
			}
			return keyName;
		}

		// Token: 0x0603BE3C RID: 245308 RVA: 0x01104AAC File Offset: 0x01102CAC
		public string GetOtherToNormalPcKeysMap(string keyName)
		{
			string result;
			if (this.OtherToNormalPcKeysMap.TryGetValue(keyName, out result))
			{
				return result;
			}
			return keyName;
		}

		// Token: 0x0401FAAB RID: 129707
		private readonly Dictionary<string, string> NormalToOtherPcKeysMap = new Dictionary<string, string>();

		// Token: 0x0401FAAC RID: 129708
		private readonly Dictionary<string, string> OtherToNormalPcKeysMap = new Dictionary<string, string>();
	}
}
