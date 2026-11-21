using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE5 RID: 2789
	public class ConfigTrackMoonMemoryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004172 RID: 16754 RVA: 0x001CECDB File Offset: 0x001CCEDB
		static ConfigTrackMoonMemoryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonMemoryById.CreateStaticDefaultValue), new Action(ConfigTrackMoonMemoryById.ResetStaticDefaultValue));
		}

		// Token: 0x06004173 RID: 16755 RVA: 0x001CECFC File Offset: 0x001CCEFC
		public static void CreateStaticDefaultValue()
		{
			ConfigTrackMoonMemoryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrackMoonMemoryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "TrackMoonMemory"),
				new ValueTuple<string, object>("语句", "select BinData from `TrackMoonMemory` where Id = ?")
			});
		}

		// Token: 0x06004174 RID: 16756 RVA: 0x001CED7B File Offset: 0x001CCF7B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonMemoryById.LogPair = null;
			ConfigTrackMoonMemoryById.HandleId = 0;
		}

		// Token: 0x06004175 RID: 16757 RVA: 0x001CED89 File Offset: 0x001CCF89
		public static void Init()
		{
			ConfigTrackMoonMemoryById.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonMemoryById.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonMemory` where Id = ?");
		}

		// Token: 0x06004176 RID: 16758 RVA: 0x001CEDA4 File Offset: 0x001CCFA4
		public static TrackMoonMemory? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrackMoonMemoryById.HandleId, ConfigTrackMoonMemoryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonMemoryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrackMoonMemory?(TrackMoonMemory.GetRootAsTrackMoonMemory(configBuffer));
				}
			}
			ConfigTrackMoonMemoryById.LogPair.Clear();
			ConfigTrackMoonMemoryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrackMoonMemoryById.HandleId, 1, p0Id, ConfigTrackMoonMemoryById.LogPair) || ConfigCommon.Step(ConfigTrackMoonMemoryById.HandleId, true, ConfigTrackMoonMemoryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrackMoonMemoryById.HandleId, ConfigTrackMoonMemoryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrackMoonMemoryById.HandleId, 0, ConfigTrackMoonMemoryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrackMoonMemoryById.HandleId, ConfigTrackMoonMemoryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrackMoonMemory rootAsTrackMoonMemory = TrackMoonMemory.GetRootAsTrackMoonMemory(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonMemoryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrackMoonMemoryById.HandleId, ConfigTrackMoonMemoryById.LogPair);
			return new TrackMoonMemory?(rootAsTrackMoonMemory);
		}

		// Token: 0x04004C29 RID: 19497
		private const string DB = "db_moonchasing.db";

		// Token: 0x04004C2A RID: 19498
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04004C2B RID: 19499
		private const string TABLE = "TrackMoonMemory";

		// Token: 0x04004C2C RID: 19500
		private const string COMMAND = "select BinData from `TrackMoonMemory` where Id = ?";

		// Token: 0x04004C2D RID: 19501
		private const string KEY_PREFIX = "TrackMoonMemoryById";

		// Token: 0x04004C2E RID: 19502
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C2F RID: 19503
		private static int HandleId;
	}
}
