using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward
{
	// Token: 0x0200654D RID: 25933
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class LinkageRewardActivityConfig : ConfigBase
	{
		// Token: 0x06040FD7 RID: 266199 RVA: 0x00FBFAFC File Offset: 0x00FBDCFC
		public LinkageReward? GetById(int id)
		{
			return ConfigLinkageRewardById.GetConfig(id, true);
		}

		// Token: 0x06040FD8 RID: 266200 RVA: 0x00FBFB05 File Offset: 0x00FBDD05
		[NullableContext(2)]
		public IReadOnlyList<LinkageReward> GetListByActivityId(int activityId)
		{
			return ConfigLinkageRewardByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x1700953F RID: 38207
		// (get) Token: 0x06040FD9 RID: 266201 RVA: 0x00FBFB0E File Offset: 0x00FBDD0E
		public static LinkageRewardActivityConfig Instance
		{
			get
			{
				return LinkageRewardActivityConfig._Instance;
			}
		}

		// Token: 0x06040FDA RID: 266202 RVA: 0x00FBFB15 File Offset: 0x00FBDD15
		public static LinkageRewardActivityConfig GetOrCreateInstance()
		{
			if (LinkageRewardActivityConfig._Instance == null)
			{
				LinkageRewardActivityConfig.CreateInstance();
			}
			return LinkageRewardActivityConfig._Instance;
		}

		// Token: 0x06040FDB RID: 266203 RVA: 0x00FBFB29 File Offset: 0x00FBDD29
		public static bool CreateInstance()
		{
			if (LinkageRewardActivityConfig._Instance != null)
			{
				return true;
			}
			LinkageRewardActivityConfig._Instance = new LinkageRewardActivityConfig();
			return true;
		}

		// Token: 0x06040FDC RID: 266204 RVA: 0x00FBFB3F File Offset: 0x00FBDD3F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06040FDD RID: 266205 RVA: 0x00FBFB41 File Offset: 0x00FBDD41
		public static void ResetStaticDefaultValue()
		{
			LinkageRewardActivityConfig._Instance = null;
		}

		// Token: 0x06040FDE RID: 266206 RVA: 0x00FBFB49 File Offset: 0x00FBDD49
		static LinkageRewardActivityConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LinkageRewardActivityConfig.CreateStaticDefaultValue), new Action(LinkageRewardActivityConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04021E38 RID: 138808
		[Nullable(2)]
		private static LinkageRewardActivityConfig _Instance;
	}
}
