using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200051F RID: 1311
	public class ConfigMapMarkRelativeSubTypeByFunctionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EC5 RID: 7877 RVA: 0x001071E3 File Offset: 0x001053E3
		static ConfigMapMarkRelativeSubTypeByFunctionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkRelativeSubTypeByFunctionId.CreateStaticDefaultValue), new Action(ConfigMapMarkRelativeSubTypeByFunctionId.ResetStaticDefaultValue));
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00107204 File Offset: 0x00105404
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

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00107283 File Offset: 0x00105483
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkRelativeSubTypeByFunctionId.LogPair = null;
			ConfigMapMarkRelativeSubTypeByFunctionId.HandleId = 0;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00107291 File Offset: 0x00105491
		public static void Init()
		{
			ConfigMapMarkRelativeSubTypeByFunctionId.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkRelativeSubTypeByFunctionId.HandleId, "db_map_mark.db", "select BinData from `MapMarkRelativeSubType` where FunctionId=?");
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x001072AC File Offset: 0x001054AC
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

		// Token: 0x040023BD RID: 9149
		private const string DB = "db_map_mark.db";

		// Token: 0x040023BE RID: 9150
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x040023BF RID: 9151
		private const string TABLE = "MapMarkRelativeSubType";

		// Token: 0x040023C0 RID: 9152
		private const string COMMAND = "select BinData from `MapMarkRelativeSubType` where FunctionId=?";

		// Token: 0x040023C1 RID: 9153
		private const string KEY_PREFIX = "MapMarkRelativeSubTypeByFunctionId";

		// Token: 0x040023C2 RID: 9154
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023C3 RID: 9155
		private static int HandleId;
	}
}
