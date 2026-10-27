using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B1 RID: 433
	public class ConfigCustomizedThumbnailById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A29 RID: 2601 RVA: 0x00093034 File Offset: 0x00091234
		static ConfigCustomizedThumbnailById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCustomizedThumbnailById.CreateStaticDefaultValue), new Action(ConfigCustomizedThumbnailById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x00093054 File Offset: 0x00091254
		public static void CreateStaticDefaultValue()
		{
			ConfigCustomizedThumbnailById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCustomizedThumbnailById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map.db"),
				new ValueTuple<string, object>("文件", "d.地图.xlsx"),
				new ValueTuple<string, object>("表名", "CustomizedThumbnail"),
				new ValueTuple<string, object>("语句", "select BinData from `CustomizedThumbnail` where Id=?")
			});
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x000930D3 File Offset: 0x000912D3
		public static void ResetStaticDefaultValue()
		{
			ConfigCustomizedThumbnailById.LogPair = null;
			ConfigCustomizedThumbnailById.HandleId = 0;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x000930E1 File Offset: 0x000912E1
		public static void Init()
		{
			ConfigCustomizedThumbnailById.HandleId = ConfigCommon.InitDataStatement(ConfigCustomizedThumbnailById.HandleId, "db_map.db", "select BinData from `CustomizedThumbnail` where Id=?");
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x000930FC File Offset: 0x000912FC
		public static CustomizedThumbnail? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCustomizedThumbnailById.HandleId, ConfigCustomizedThumbnailById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CustomizedThumbnailById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CustomizedThumbnail?(CustomizedThumbnail.GetRootAsCustomizedThumbnail(configBuffer));
				}
			}
			ConfigCustomizedThumbnailById.LogPair.Clear();
			ConfigCustomizedThumbnailById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCustomizedThumbnailById.HandleId, 1, p0Id, ConfigCustomizedThumbnailById.LogPair) || ConfigCommon.Step(ConfigCustomizedThumbnailById.HandleId, true, ConfigCustomizedThumbnailById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCustomizedThumbnailById.HandleId, ConfigCustomizedThumbnailById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCustomizedThumbnailById.HandleId, 0, ConfigCustomizedThumbnailById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCustomizedThumbnailById.HandleId, ConfigCustomizedThumbnailById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CustomizedThumbnail rootAsCustomizedThumbnail = CustomizedThumbnail.GetRootAsCustomizedThumbnail(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CustomizedThumbnailById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCustomizedThumbnailById.HandleId, ConfigCustomizedThumbnailById.LogPair);
			return new CustomizedThumbnail?(rootAsCustomizedThumbnail);
		}

		// Token: 0x04000BBB RID: 3003
		private const string DB = "db_map.db";

		// Token: 0x04000BBC RID: 3004
		private const string FILE = "d.地图.xlsx";

		// Token: 0x04000BBD RID: 3005
		private const string TABLE = "CustomizedThumbnail";

		// Token: 0x04000BBE RID: 3006
		private const string COMMAND = "select BinData from `CustomizedThumbnail` where Id=?";

		// Token: 0x04000BBF RID: 3007
		private const string KEY_PREFIX = "CustomizedThumbnailById";

		// Token: 0x04000BC0 RID: 3008
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BC1 RID: 3009
		private static int HandleId;
	}
}
