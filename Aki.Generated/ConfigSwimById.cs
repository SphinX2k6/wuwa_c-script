using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B8 RID: 2488
	public class ConfigSwimById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A64 RID: 14948 RVA: 0x001A4024 File Offset: 0x001A2224
		static ConfigSwimById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSwimById.CreateStaticDefaultValue), new Action(ConfigSwimById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A65 RID: 14949 RVA: 0x001A4044 File Offset: 0x001A2244
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

		// Token: 0x06003A66 RID: 14950 RVA: 0x001A40C3 File Offset: 0x001A22C3
		public static void ResetStaticDefaultValue()
		{
			ConfigSwimById.LogPair = null;
			ConfigSwimById.HandleId = 0;
		}

		// Token: 0x06003A67 RID: 14951 RVA: 0x001A40D1 File Offset: 0x001A22D1
		public static void Init()
		{
			ConfigSwimById.HandleId = ConfigCommon.InitDataStatement(ConfigSwimById.HandleId, "db_swim.db", "select BinData from `Swim` where Id=?");
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x001A40EC File Offset: 0x001A22EC
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

		// Token: 0x040043EE RID: 17390
		private const string DB = "db_swim.db";

		// Token: 0x040043EF RID: 17391
		private const string FILE = "y.游泳.xlsx";

		// Token: 0x040043F0 RID: 17392
		private const string TABLE = "Swim";

		// Token: 0x040043F1 RID: 17393
		private const string COMMAND = "select BinData from `Swim` where Id=?";

		// Token: 0x040043F2 RID: 17394
		private const string KEY_PREFIX = "SwimById";

		// Token: 0x040043F3 RID: 17395
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043F4 RID: 17396
		private static int HandleId;
	}
}
