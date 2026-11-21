using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000535 RID: 1333
	public class ConfigMapMarkRelativeSubTypeByFunctionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F49 RID: 8009 RVA: 0x0010D937 File Offset: 0x0010BB37
		static ConfigMapMarkRelativeSubTypeByFunctionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkRelativeSubTypeByFunctionId.CreateStaticDefaultValue), new Action(ConfigMapMarkRelativeSubTypeByFunctionId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x0010D958 File Offset: 0x0010BB58
		public static void CreateStaticDefaultValue()
		{
			ConfigMapMarkRelativeSubTypeByFunctionId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapMarkRelativeSubTypeByFunctionId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "MapMarkRelativeSubType"),
				new ValueTuple<string, object>("语句", "select BinData from `MapMarkRelativeSubType` where FunctionId=?")
			});
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x0010D9D7 File Offset: 0x0010BBD7
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkRelativeSubTypeByFunctionId.LogPair = null;
			ConfigMapMarkRelativeSubTypeByFunctionId.HandleId = 0;
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x0010D9E5 File Offset: 0x0010BBE5
		public static void Init()
		{
			ConfigMapMarkRelativeSubTypeByFunctionId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkRelativeSubTypeByFunctionId.HandleId, "db_map_mark.db", "select BinData from `MapMarkRelativeSubType` where FunctionId=?");
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x0010DA00 File Offset: 0x0010BC00
		public static MapMarkRelativeSubType? GetConfig(int p0FunctionId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapMarkRelativeSubTypeByFunctionId.HandleId, ConfigMapMarkRelativeSubTypeByFunctionId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkRelativeSubTypeByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapMarkRelativeSubType?(MapMarkRelativeSubType.GetRootAsMapMarkRelativeSubType(configBuffer));
				}
			}
			ConfigMapMarkRelativeSubTypeByFunctionId.LogPair.Clear();
			ConfigMapMarkRelativeSubTypeByFunctionId.LogPair.Add(new ValueTuple<string, object>("FunctionId", p0FunctionId));
			if (!ConfigCommon.BindInt(ConfigMapMarkRelativeSubTypeByFunctionId.HandleId, 1, p0FunctionId, ConfigMapMarkRelativeSubTypeByFunctionId.LogPair) || ConfigCommon.Step(ConfigMapMarkRelativeSubTypeByFunctionId.HandleId, true, ConfigMapMarkRelativeSubTypeByFunctionId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapMarkRelativeSubTypeByFunctionId.HandleId, ConfigMapMarkRelativeSubTypeByFunctionId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapMarkRelativeSubTypeByFunctionId.HandleId, 0, ConfigMapMarkRelativeSubTypeByFunctionId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapMarkRelativeSubTypeByFunctionId.HandleId, ConfigMapMarkRelativeSubTypeByFunctionId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapMarkRelativeSubType rootAsMapMarkRelativeSubType = MapMarkRelativeSubType.GetRootAsMapMarkRelativeSubType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkRelativeSubTypeByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapMarkRelativeSubTypeByFunctionId.HandleId, ConfigMapMarkRelativeSubTypeByFunctionId.LogPair);
			return new MapMarkRelativeSubType?(rootAsMapMarkRelativeSubType);
		}

		// Token: 0x04002457 RID: 9303
		private const string DB = "db_map_mark.db";

		// Token: 0x04002458 RID: 9304
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04002459 RID: 9305
		private const string TABLE = "MapMarkRelativeSubType";

		// Token: 0x0400245A RID: 9306
		private const string COMMAND = "select BinData from `MapMarkRelativeSubType` where FunctionId=?";

		// Token: 0x0400245B RID: 9307
		private const string KEY_PREFIX = "MapMarkRelativeSubTypeByFunctionId";

		// Token: 0x0400245C RID: 9308
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400245D RID: 9309
		private static int HandleId;
	}
}
