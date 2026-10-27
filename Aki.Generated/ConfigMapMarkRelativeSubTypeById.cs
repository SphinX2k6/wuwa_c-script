using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000520 RID: 1312
	public class ConfigMapMarkRelativeSubTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001ECB RID: 7883 RVA: 0x0010742C File Offset: 0x0010562C
		static ConfigMapMarkRelativeSubTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkRelativeSubTypeById.CreateStaticDefaultValue), new Action(ConfigMapMarkRelativeSubTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x0010744C File Offset: 0x0010564C
		public static void CreateStaticDefaultValue()
		{
			ConfigMapMarkRelativeSubTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapMarkRelativeSubTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "MapMarkRelativeSubType"),
				new ValueTuple<string, object>("语句", "select BinData from `MapMarkRelativeSubType` where Id=?")
			});
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x001074CB File Offset: 0x001056CB
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkRelativeSubTypeById.LogPair = null;
			ConfigMapMarkRelativeSubTypeById.HandleId = 0;
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x001074D9 File Offset: 0x001056D9
		public static void Init()
		{
			ConfigMapMarkRelativeSubTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkRelativeSubTypeById.HandleId, "db_map_mark.db", "select BinData from `MapMarkRelativeSubType` where Id=?");
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x001074F4 File Offset: 0x001056F4
		public static MapMarkRelativeSubType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapMarkRelativeSubTypeById.HandleId, ConfigMapMarkRelativeSubTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkRelativeSubTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapMarkRelativeSubType?(MapMarkRelativeSubType.GetRootAsMapMarkRelativeSubType(configBuffer));
				}
			}
			ConfigMapMarkRelativeSubTypeById.LogPair.Clear();
			ConfigMapMarkRelativeSubTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMapMarkRelativeSubTypeById.HandleId, 1, p0Id, ConfigMapMarkRelativeSubTypeById.LogPair) || ConfigCommon.Step(ConfigMapMarkRelativeSubTypeById.HandleId, true, ConfigMapMarkRelativeSubTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapMarkRelativeSubTypeById.HandleId, ConfigMapMarkRelativeSubTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapMarkRelativeSubTypeById.HandleId, 0, ConfigMapMarkRelativeSubTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapMarkRelativeSubTypeById.HandleId, ConfigMapMarkRelativeSubTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapMarkRelativeSubType rootAsMapMarkRelativeSubType = MapMarkRelativeSubType.GetRootAsMapMarkRelativeSubType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkRelativeSubTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapMarkRelativeSubTypeById.HandleId, ConfigMapMarkRelativeSubTypeById.LogPair);
			return new MapMarkRelativeSubType?(rootAsMapMarkRelativeSubType);
		}

		// Token: 0x040023C4 RID: 9156
		private const string DB = "db_map_mark.db";

		// Token: 0x040023C5 RID: 9157
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x040023C6 RID: 9158
		private const string TABLE = "MapMarkRelativeSubType";

		// Token: 0x040023C7 RID: 9159
		private const string COMMAND = "select BinData from `MapMarkRelativeSubType` where Id=?";

		// Token: 0x040023C8 RID: 9160
		private const string KEY_PREFIX = "MapMarkRelativeSubTypeById";

		// Token: 0x040023C9 RID: 9161
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023CA RID: 9162
		private static int HandleId;
	}
}
