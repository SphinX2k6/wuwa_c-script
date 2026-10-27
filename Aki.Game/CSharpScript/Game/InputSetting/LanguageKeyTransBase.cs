using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007005 RID: 28677
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class LanguageKeyTransBase
	{
		// Token: 0x06045C7F RID: 285823 RVA: 0x0115A63C File Offset: 0x0115883C
		public void InitPcKeysByConfig(PcKey config)
		{
			string otherPcKey = this.GetOtherPcKey(config);
			if (!StringUtils.IsBlank(otherPcKey))
			{
				this.NormalToOtherPcKeysMap[config.KeyName] = otherPcKey;
				this.OtherToNormalPcKeysMap[otherPcKey] = config.KeyName;
			}
		}

		// Token: 0x06045C80 RID: 285824
		protected abstract string GetOtherPcKey(PcKey config);

		// Token: 0x06045C81 RID: 285825
		public abstract string[] GetActionPcKeys(ActionMapping actionMappingConfig);

		// Token: 0x06045C82 RID: 285826
		public abstract Dictionary<string, float> GetAxisPcKeys(AxisMapping axisMappingConfig);

		// Token: 0x06045C83 RID: 285827
		public abstract Dictionary<string, string> GetCombinationActionPcKeys(CombinationAction combinationActionMappingConfig);

		// Token: 0x06045C84 RID: 285828
		public abstract string GetPcKeyIconPath(PcKey config);

		// Token: 0x06045C85 RID: 285829 RVA: 0x0115A680 File Offset: 0x01158880
		public string GetNormalToOtherPcKeysMap(string keyName)
		{
			string result;
			if (this.NormalToOtherPcKeysMap.TryGetValue(keyName, out result))
			{
				return result;
			}
			return keyName;
		}

		// Token: 0x06045C86 RID: 285830 RVA: 0x0115A6A0 File Offset: 0x011588A0
		public string GetOtherToNormalPcKeysMap(string keyName)
		{
			string result;
			if (this.OtherToNormalPcKeysMap.TryGetValue(keyName, out result))
			{
				return result;
			}
			return keyName;
		}

		// Token: 0x040247F5 RID: 149493
		private readonly Dictionary<string, string> NormalToOtherPcKeysMap = new Dictionary<string, string>();

		// Token: 0x040247F6 RID: 149494
		private readonly Dictionary<string, string> OtherToNormalPcKeysMap = new Dictionary<string, string>();
	}
}
