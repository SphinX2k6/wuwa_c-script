using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200002C RID: 44
	public class ConfigAbyssRouteById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000108 RID: 264 RVA: 0x0005F997 File Offset: 0x0005DB97
		static ConfigAbyssRouteById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRouteById.CreateStaticDefaultValue), new Action(ConfigAbyssRouteById.ResetStaticDefaultValue));
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0005F9B8 File Offset: 0x0005DBB8
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRouteById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRouteById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabyss.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔副本.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssRoute"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssRoute` where Id=?")
			});
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0005FA37 File Offset: 0x0005DC37
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRouteById.LogPair = null;
			ConfigAbyssRouteById.HandleId = 0;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0005FA45 File Offset: 0x0005DC45
		public static void Init()
		{
			ConfigAbyssRouteById.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRouteById.HandleId, "db_dangoabyss.db", "select BinData from `AbyssRoute` where Id=?");
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0005FA60 File Offset: 0x0005DC60
		public static AbyssRoute? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRouteById.HandleId, ConfigAbyssRouteById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRouteById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssRoute?(AbyssRoute.GetRootAsAbyssRoute(configBuffer));
				}
			}
			ConfigAbyssRouteById.LogPair.Clear();
			ConfigAbyssRouteById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbyssRouteById.HandleId, 1, p0Id, ConfigAbyssRouteById.LogPair) || ConfigCommon.Step(ConfigAbyssRouteById.HandleId, true, ConfigAbyssRouteById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssRouteById.HandleId, ConfigAbyssRouteById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRouteById.HandleId, 0, ConfigAbyssRouteById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssRouteById.HandleId, ConfigAbyssRouteById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssRoute rootAsAbyssRoute = AbyssRoute.GetRootAsAbyssRoute(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRouteById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssRouteById.HandleId, ConfigAbyssRouteById.LogPair);
			return new AbyssRoute?(rootAsAbyssRoute);
		}

		// Token: 0x04000118 RID: 280
		private const string DB = "db_dangoabyss.db";

		// Token: 0x04000119 RID: 281
		private const string FILE = "s.深渊爬塔副本.xlsx";

		// Token: 0x0400011A RID: 282
		private const string TABLE = "AbyssRoute";

		// Token: 0x0400011B RID: 283
		private const string COMMAND = "select BinData from `AbyssRoute` where Id=?";

		// Token: 0x0400011C RID: 284
		private const string KEY_PREFIX = "AbyssRouteById";

		// Token: 0x0400011D RID: 285
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400011E RID: 286
		private static int HandleId;
	}
}
