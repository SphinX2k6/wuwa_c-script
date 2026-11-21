using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200052A RID: 1322
	public class ConfigMapLevelExpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F07 RID: 7943 RVA: 0x0010C1B3 File Offset: 0x0010A3B3
		static ConfigMapLevelExpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapLevelExpById.CreateStaticDefaultValue), new Action(ConfigMapLevelExpById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x0010C1D4 File Offset: 0x0010A3D4
		public static void CreateStaticDefaultValue()
		{
			ConfigMapLevelExpById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapLevelExpById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitymaptravel.db"),
				new ValueTuple<string, object>("文件", "d.地图主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "MapLevelExp"),
				new ValueTuple<string, object>("语句", "select BinData from `MapLevelExp` where Id=?")
			});
		}

		// Token: 0x06001F09 RID: 7945 RVA: 0x0010C253 File Offset: 0x0010A453
		public static void ResetStaticDefaultValue()
		{
			ConfigMapLevelExpById.LogPair = null;
			ConfigMapLevelExpById.HandleId = 0;
		}

		// Token: 0x06001F0A RID: 7946 RVA: 0x0010C261 File Offset: 0x0010A461
		public static void Init()
		{
			ConfigMapLevelExpById.HandleId = ConfigCommon.InitDataStatement(ConfigMapLevelExpById.HandleId, "db_activitymaptravel.db", "select BinData from `MapLevelExp` where Id=?");
		}

		// Token: 0x06001F0B RID: 7947 RVA: 0x0010C27C File Offset: 0x0010A47C
		public static MapLevelExp? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapLevelExpById.HandleId, ConfigMapLevelExpById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapLevelExpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapLevelExp?(MapLevelExp.GetRootAsMapLevelExp(configBuffer));
				}
			}
			ConfigMapLevelExpById.LogPair.Clear();
			ConfigMapLevelExpById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMapLevelExpById.HandleId, 1, p0Id, ConfigMapLevelExpById.LogPair) || ConfigCommon.Step(ConfigMapLevelExpById.HandleId, true, ConfigMapLevelExpById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapLevelExpById.HandleId, ConfigMapLevelExpById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapLevelExpById.HandleId, 0, ConfigMapLevelExpById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapLevelExpById.HandleId, ConfigMapLevelExpById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapLevelExp rootAsMapLevelExp = MapLevelExp.GetRootAsMapLevelExp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapLevelExpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapLevelExpById.HandleId, ConfigMapLevelExpById.LogPair);
			return new MapLevelExp?(rootAsMapLevelExp);
		}

		// Token: 0x0400240A RID: 9226
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x0400240B RID: 9227
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x0400240C RID: 9228
		private const string TABLE = "MapLevelExp";

		// Token: 0x0400240D RID: 9229
		private const string COMMAND = "select BinData from `MapLevelExp` where Id=?";

		// Token: 0x0400240E RID: 9230
		private const string KEY_PREFIX = "MapLevelExpById";

		// Token: 0x0400240F RID: 9231
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002410 RID: 9232
		private static int HandleId;
	}
}
