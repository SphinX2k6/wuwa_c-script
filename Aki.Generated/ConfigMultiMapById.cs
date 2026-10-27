using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D9 RID: 1497
	public class ConfigMultiMapById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002323 RID: 8995 RVA: 0x0012018B File Offset: 0x0011E38B
		static ConfigMultiMapById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMultiMapById.CreateStaticDefaultValue), new Action(ConfigMultiMapById.ResetStaticDefaultValue));
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x001201AC File Offset: 0x0011E3AC
		public static void CreateStaticDefaultValue()
		{
			ConfigMultiMapById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMultiMapById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "MultiMap"),
				new ValueTuple<string, object>("语句", "select BinData from `MultiMap` where Id=?")
			});
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x0012022B File Offset: 0x0011E42B
		public static void ResetStaticDefaultValue()
		{
			ConfigMultiMapById.LogPair = null;
			ConfigMultiMapById.HandleId = 0;
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00120239 File Offset: 0x0011E439
		public static void Init()
		{
			ConfigMultiMapById.HandleId = ConfigCommon.InitDataStatement(ConfigMultiMapById.HandleId, "db_map.db", "select BinData from `MultiMap` where Id=?");
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00120254 File Offset: 0x0011E454
		public static MultiMap? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMultiMapById.HandleId, ConfigMultiMapById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MultiMapById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MultiMap?(MultiMap.GetRootAsMultiMap(configBuffer));
				}
			}
			ConfigMultiMapById.LogPair.Clear();
			ConfigMultiMapById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMultiMapById.HandleId, 1, p0Id, ConfigMultiMapById.LogPair) || ConfigCommon.Step(ConfigMultiMapById.HandleId, true, ConfigMultiMapById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMultiMapById.HandleId, ConfigMultiMapById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMultiMapById.HandleId, 0, ConfigMultiMapById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMultiMapById.HandleId, ConfigMultiMapById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MultiMap rootAsMultiMap = MultiMap.GetRootAsMultiMap(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MultiMapById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMultiMapById.HandleId, ConfigMultiMapById.LogPair);
			return new MultiMap?(rootAsMultiMap);
		}

		// Token: 0x040028D3 RID: 10451
		private const string DB = "db_map.db";

		// Token: 0x040028D4 RID: 10452
		private const string FILE = "d.地图.xlsx";

		// Token: 0x040028D5 RID: 10453
		private const string TABLE = "MultiMap";

		// Token: 0x040028D6 RID: 10454
		private const string COMMAND = "select BinData from `MultiMap` where Id=?";

		// Token: 0x040028D7 RID: 10455
		private const string KEY_PREFIX = "MultiMapById";

		// Token: 0x040028D8 RID: 10456
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028D9 RID: 10457
		private static int HandleId;
	}
}
