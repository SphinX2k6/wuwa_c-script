using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000514 RID: 1300
	public class ConfigMapLevelExpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E83 RID: 7811 RVA: 0x00105A5F File Offset: 0x00103C5F
		static ConfigMapLevelExpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapLevelExpById.CreateStaticDefaultValue), new Action(ConfigMapLevelExpById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x00105A80 File Offset: 0x00103C80
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

		// Token: 0x06001E85 RID: 7813 RVA: 0x00105AFF File Offset: 0x00103CFF
		public static void ResetStaticDefaultValue()
		{
			ConfigMapLevelExpById.LogPair = null;
			ConfigMapLevelExpById.HandleId = 0;
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00105B0D File Offset: 0x00103D0D
		public static void Init()
		{
			ConfigMapLevelExpById.HandleId = ConfigCommon.InitDataStatement(ConfigMapLevelExpById.HandleId, "db_activitymaptravel.db", "select BinData from `MapLevelExp` where Id=?");
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x00105B28 File Offset: 0x00103D28
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

		// Token: 0x04002370 RID: 9072
		private const string DB = "db_activitymaptravel.db";

		// Token: 0x04002371 RID: 9073
		private const string FILE = "d.地图主题活动.xlsx";

		// Token: 0x04002372 RID: 9074
		private const string TABLE = "MapLevelExp";

		// Token: 0x04002373 RID: 9075
		private const string COMMAND = "select BinData from `MapLevelExp` where Id=?";

		// Token: 0x04002374 RID: 9076
		private const string KEY_PREFIX = "MapLevelExpById";

		// Token: 0x04002375 RID: 9077
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002376 RID: 9078
		private static int HandleId;
	}
}
