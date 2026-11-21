using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000539 RID: 1337
	public class ConfigMapPeriodicActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F61 RID: 8033 RVA: 0x0010E1A3 File Offset: 0x0010C3A3
		static ConfigMapPeriodicActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapPeriodicActivityById.CreateStaticDefaultValue), new Action(ConfigMapPeriodicActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x0010E1C4 File Offset: 0x0010C3C4
		public static void CreateStaticDefaultValue()
		{
			ConfigMapPeriodicActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapPeriodicActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "MapPeriodicActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `MapPeriodicActivity` where Id=?")
			});
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x0010E243 File Offset: 0x0010C443
		public static void ResetStaticDefaultValue()
		{
			ConfigMapPeriodicActivityById.LogPair = null;
			ConfigMapPeriodicActivityById.HandleId = 0;
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x0010E251 File Offset: 0x0010C451
		public static void Init()
		{
			ConfigMapPeriodicActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigMapPeriodicActivityById.HandleId, "db_map.db", "select BinData from `MapPeriodicActivity` where Id=?");
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x0010E26C File Offset: 0x0010C46C
		public static MapPeriodicActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapPeriodicActivityById.HandleId, ConfigMapPeriodicActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapPeriodicActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapPeriodicActivity?(MapPeriodicActivity.GetRootAsMapPeriodicActivity(configBuffer));
				}
			}
			ConfigMapPeriodicActivityById.LogPair.Clear();
			ConfigMapPeriodicActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMapPeriodicActivityById.HandleId, 1, p0Id, ConfigMapPeriodicActivityById.LogPair) || ConfigCommon.Step(ConfigMapPeriodicActivityById.HandleId, true, ConfigMapPeriodicActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapPeriodicActivityById.HandleId, ConfigMapPeriodicActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapPeriodicActivityById.HandleId, 0, ConfigMapPeriodicActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapPeriodicActivityById.HandleId, ConfigMapPeriodicActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapPeriodicActivity rootAsMapPeriodicActivity = MapPeriodicActivity.GetRootAsMapPeriodicActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapPeriodicActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapPeriodicActivityById.HandleId, ConfigMapPeriodicActivityById.LogPair);
			return new MapPeriodicActivity?(rootAsMapPeriodicActivity);
		}

		// Token: 0x04002473 RID: 9331
		private const string DB = "db_map.db";

		// Token: 0x04002474 RID: 9332
		private const string FILE = "d.地图.xlsx";

		// Token: 0x04002475 RID: 9333
		private const string TABLE = "MapPeriodicActivity";

		// Token: 0x04002476 RID: 9334
		private const string COMMAND = "select BinData from `MapPeriodicActivity` where Id=?";

		// Token: 0x04002477 RID: 9335
		private const string KEY_PREFIX = "MapPeriodicActivityById";

		// Token: 0x04002478 RID: 9336
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002479 RID: 9337
		private static int HandleId;
	}
}
