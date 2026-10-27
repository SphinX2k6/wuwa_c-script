using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000523 RID: 1315
	public class ConfigMapPeriodicActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EDD RID: 7901 RVA: 0x00107A4F File Offset: 0x00105C4F
		static ConfigMapPeriodicActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapPeriodicActivityById.CreateStaticDefaultValue), new Action(ConfigMapPeriodicActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x00107A70 File Offset: 0x00105C70
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

		// Token: 0x06001EDF RID: 7903 RVA: 0x00107AEF File Offset: 0x00105CEF
		public static void ResetStaticDefaultValue()
		{
			ConfigMapPeriodicActivityById.LogPair = null;
			ConfigMapPeriodicActivityById.HandleId = 0;
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x00107AFD File Offset: 0x00105CFD
		public static void Init()
		{
			ConfigMapPeriodicActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigMapPeriodicActivityById.HandleId, "db_map.db", "select BinData from `MapPeriodicActivity` where Id=?");
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x00107B18 File Offset: 0x00105D18
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

		// Token: 0x040023D9 RID: 9177
		private const string DB = "db_map.db";

		// Token: 0x040023DA RID: 9178
		private const string FILE = "d.地图.xlsx";

		// Token: 0x040023DB RID: 9179
		private const string TABLE = "MapPeriodicActivity";

		// Token: 0x040023DC RID: 9180
		private const string COMMAND = "select BinData from `MapPeriodicActivity` where Id=?";

		// Token: 0x040023DD RID: 9181
		private const string KEY_PREFIX = "MapPeriodicActivityById";

		// Token: 0x040023DE RID: 9182
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023DF RID: 9183
		private static int HandleId;
	}
}
