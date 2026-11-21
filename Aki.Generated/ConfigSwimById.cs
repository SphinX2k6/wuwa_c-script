using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A8D RID: 2701
	public class ConfigSwimById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F62 RID: 16226 RVA: 0x001C33B8 File Offset: 0x001C15B8
		static ConfigSwimById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSwimById.CreateStaticDefaultValue), new Action(ConfigSwimById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F63 RID: 16227 RVA: 0x001C33D8 File Offset: 0x001C15D8
		public static void CreateStaticDefaultValue()
		{
			ConfigSwimById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSwimById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_swim.db"),
				new ValueTuple<string, object>("文件", "y.游泳.xlsx"),
				new ValueTuple<string, object>("表名", "Swim"),
				new ValueTuple<string, object>("语句", "select BinData from `Swim` where Id=?")
			});
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x001C3457 File Offset: 0x001C1657
		public static void ResetStaticDefaultValue()
		{
			ConfigSwimById.LogPair = null;
			ConfigSwimById.HandleId = 0;
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x001C3465 File Offset: 0x001C1665
		public static void Init()
		{
			ConfigSwimById.HandleId = ConfigCommon.InitDataStatement(ConfigSwimById.HandleId, "db_swim.db", "select BinData from `Swim` where Id=?");
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x001C3480 File Offset: 0x001C1680
		public static Swim? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSwimById.HandleId, ConfigSwimById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("SwimById#" + p0Id);
				if (configBuffer != null)
				{
					return new Swim?(Swim.GetRootAsSwim(configBuffer));
				}
			}
			ConfigSwimById.LogPair.Clear();
			ConfigSwimById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigSwimById.HandleId, 1, p0Id, ConfigSwimById.LogPair) || ConfigCommon.Step(ConfigSwimById.HandleId, true, ConfigSwimById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSwimById.HandleId, ConfigSwimById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSwimById.HandleId, 0, ConfigSwimById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSwimById.HandleId, ConfigSwimById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Swim rootAsSwim = Swim.GetRootAsSwim(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("SwimById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSwimById.HandleId, ConfigSwimById.LogPair);
			return new Swim?(rootAsSwim);
		}

		// Token: 0x040049C1 RID: 18881
		private const string DB = "db_swim.db";

		// Token: 0x040049C2 RID: 18882
		private const string FILE = "y.游泳.xlsx";

		// Token: 0x040049C3 RID: 18883
		private const string TABLE = "Swim";

		// Token: 0x040049C4 RID: 18884
		private const string COMMAND = "select BinData from `Swim` where Id=?";

		// Token: 0x040049C5 RID: 18885
		private const string KEY_PREFIX = "SwimById";

		// Token: 0x040049C6 RID: 18886
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049C7 RID: 18887
		private static int HandleId;
	}
}
