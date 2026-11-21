using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward
{
	// Token: 0x020054CB RID: 21707
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class LinkageRewardActivityConfig : ConfigBase
	{
		// Token: 0x06035C9C RID: 220316 RVA: 0x00F06AEC File Offset: 0x00F04CEC
		public LinkageReward? GetById(int id)
		{
			return ConfigLinkageRewardById.GetConfig(id, true);
		}

		// Token: 0x06035C9D RID: 220317 RVA: 0x00F06AF5 File Offset: 0x00F04CF5
		[NullableContext(2)]
		public IReadOnlyList<LinkageReward> GetListByActivityId(int activityId)
		{
			return ConfigLinkageRewardByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x170068A1 RID: 26785
		// (get) Token: 0x06035C9E RID: 220318 RVA: 0x00F06AFE File Offset: 0x00F04CFE
		public static LinkageRewardActivityConfig Instance
		{
			get
			{
				return LinkageRewardActivityConfig._Instance;
			}
		}

		// Token: 0x06035C9F RID: 220319 RVA: 0x00F06B05 File Offset: 0x00F04D05
		public static LinkageRewardActivityConfig GetOrCreateInstance()
		{
			if (LinkageRewardActivityConfig._Instance == null)
			{
				LinkageRewardActivityConfig.CreateInstance();
			}
			return LinkageRewardActivityConfig._Instance;
		}

		// Token: 0x06035CA0 RID: 220320 RVA: 0x00F06B19 File Offset: 0x00F04D19
		public static bool CreateInstance()
		{
			if (LinkageRewardActivityConfig._Instance != null)
			{
				return true;
			}
			LinkageRewardActivityConfig._Instance = new LinkageRewardActivityConfig();
			return true;
		}

		// Token: 0x06035CA1 RID: 220321 RVA: 0x00F06B2F File Offset: 0x00F04D2F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035CA2 RID: 220322 RVA: 0x00F06B31 File Offset: 0x00F04D31
		public static void ResetStaticDefaultValue()
		{
			LinkageRewardActivityConfig._Instance = null;
		}

		// Token: 0x06035CA3 RID: 220323 RVA: 0x00F06B39 File Offset: 0x00F04D39
		static LinkageRewardActivityConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LinkageRewardActivityConfig.CreateStaticDefaultValue), new Action(LinkageRewardActivityConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401C769 RID: 116585
		[Nullable(2)]
		private static LinkageRewardActivityConfig _Instance;
	}
}
