using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C3 RID: 451
	public class ConfigCustomizedThumbnailById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A95 RID: 2709 RVA: 0x00098F6C File Offset: 0x0009716C
		static ConfigCustomizedThumbnailById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCustomizedThumbnailById.CreateStaticDefaultValue), new Action(ConfigCustomizedThumbnailById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00098F8C File Offset: 0x0009718C
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

		// Token: 0x06000A97 RID: 2711 RVA: 0x0009900B File Offset: 0x0009720B
		public static void ResetStaticDefaultValue()
		{
			ConfigCustomizedThumbnailById.LogPair = null;
			ConfigCustomizedThumbnailById.HandleId = 0;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00099019 File Offset: 0x00097219
		public static void Init()
		{
			ConfigCustomizedThumbnailById.HandleId = ConfigCommon.InitDataStatement(ConfigCustomizedThumbnailById.HandleId, "db_map.db", "select BinData from `CustomizedThumbnail` where Id=?");
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00099034 File Offset: 0x00097234
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

		// Token: 0x04000C39 RID: 3129
		private const string DB = "db_map.db";

		// Token: 0x04000C3A RID: 3130
		private const string FILE = "d.地图.xlsx";

		// Token: 0x04000C3B RID: 3131
		private const string TABLE = "CustomizedThumbnail";

		// Token: 0x04000C3C RID: 3132
		private const string COMMAND = "select BinData from `CustomizedThumbnail` where Id=?";

		// Token: 0x04000C3D RID: 3133
		private const string KEY_PREFIX = "CustomizedThumbnailById";

		// Token: 0x04000C3E RID: 3134
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C3F RID: 3135
		private static int HandleId;
	}
}
