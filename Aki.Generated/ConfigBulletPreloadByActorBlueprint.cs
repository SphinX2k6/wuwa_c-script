using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200012E RID: 302
	public class ConfigBulletPreloadByActorBlueprint : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000715 RID: 1813 RVA: 0x00081BA5 File Offset: 0x0007FDA5
		static ConfigBulletPreloadByActorBlueprint()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBulletPreloadByActorBlueprint.CreateStaticDefaultValue), new Action(ConfigBulletPreloadByActorBlueprint.ResetStaticDefaultValue));
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00081BC4 File Offset: 0x0007FDC4
		public static void CreateStaticDefaultValue()
		{
			ConfigBulletPreloadByActorBlueprint.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBulletPreloadByActorBlueprint.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bullet_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/BulletPreload.csv"),
				new ValueTuple<string, object>("表名", "BulletPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `BulletPreload` where ActorBlueprint=?")
			});
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00081C43 File Offset: 0x0007FE43
		public static void ResetStaticDefaultValue()
		{
			ConfigBulletPreloadByActorBlueprint.LogPair = null;
			ConfigBulletPreloadByActorBlueprint.HandleId = 0;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00081C51 File Offset: 0x0007FE51
		public static void Init()
		{
			ConfigBulletPreloadByActorBlueprint.HandleId = ConfigCommon.InitDataStatement(ConfigBulletPreloadByActorBlueprint.HandleId, "db_bullet_preload.db", "select BinData from `BulletPreload` where ActorBlueprint=?");
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00081C6C File Offset: 0x0007FE6C
		[return: Nullable(2)]
		public static IReadOnlyList<BulletPreload> GetConfigList(string p0ActorBlueprint, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBulletPreloadByActorBlueprint.HandleId, ConfigBulletPreloadByActorBlueprint.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BulletPreload> readOnlyList = (IReadOnlyList<BulletPreload>)ConfigCommon.GetConfig("BulletPreloadByActorBlueprint#" + p0ActorBlueprint);
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBulletPreloadByActorBlueprint.LogPair.Clear();
			ConfigBulletPreloadByActorBlueprint.LogPair.Add(new ValueTuple<string, object>("ActorBlueprint", p0ActorBlueprint));
			if (!ConfigCommon.BindString(ConfigBulletPreloadByActorBlueprint.HandleId, 1, p0ActorBlueprint, ConfigBulletPreloadByActorBlueprint.LogPair))
			{
				ConfigCommon.Reset(ConfigBulletPreloadByActorBlueprint.HandleId, ConfigBulletPreloadByActorBlueprint.LogPair);
				return null;
			}
			List<BulletPreload> list = new List<BulletPreload>();
			while (ConfigCommon.Step(ConfigBulletPreloadByActorBlueprint.HandleId, false, ConfigBulletPreloadByActorBlueprint.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBulletPreloadByActorBlueprint.HandleId, 0, ConfigBulletPreloadByActorBlueprint.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBulletPreloadByActorBlueprint.HandleId, ConfigBulletPreloadByActorBlueprint.LogPair);
					return null;
				}
				BulletPreload rootAsBulletPreload = BulletPreload.GetRootAsBulletPreload(new ByteBuffer(item2));
				list.Add(rootAsBulletPreload);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BulletPreloadByActorBlueprint#" + p0ActorBlueprint, list, list.Count);
			}
			ConfigCommon.Reset(ConfigBulletPreloadByActorBlueprint.HandleId, ConfigBulletPreloadByActorBlueprint.LogPair);
			return list;
		}

		// Token: 0x04000826 RID: 2086
		private const string DB = "db_bullet_preload.db";

		// Token: 0x04000827 RID: 2087
		private const string FILE = "Preload/BulletPreload.csv";

		// Token: 0x04000828 RID: 2088
		private const string TABLE = "BulletPreload";

		// Token: 0x04000829 RID: 2089
		private const string COMMAND = "select BinData from `BulletPreload` where ActorBlueprint=?";

		// Token: 0x0400082A RID: 2090
		private const string KEY_PREFIX = "BulletPreloadByActorBlueprint";

		// Token: 0x0400082B RID: 2091
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400082C RID: 2092
		private static int HandleId;
	}
}
