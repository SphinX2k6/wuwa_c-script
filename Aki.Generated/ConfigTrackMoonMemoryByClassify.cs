using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE4 RID: 2788
	public class ConfigTrackMoonMemoryByClassify : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600416C RID: 16748 RVA: 0x001CEAA3 File Offset: 0x001CCCA3
		static ConfigTrackMoonMemoryByClassify()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonMemoryByClassify.CreateStaticDefaultValue), new Action(ConfigTrackMoonMemoryByClassify.ResetStaticDefaultValue));
		}

		// Token: 0x0600416D RID: 16749 RVA: 0x001CEAC4 File Offset: 0x001CCCC4
		public static void CreateStaticDefaultValue()
		{
			ConfigTrackMoonMemoryByClassify.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrackMoonMemoryByClassify.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "TrackMoonMemory"),
				new ValueTuple<string, object>("语句", "select BinData from `TrackMoonMemory` where Classify = ?")
			});
		}

		// Token: 0x0600416E RID: 16750 RVA: 0x001CEB43 File Offset: 0x001CCD43
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonMemoryByClassify.LogPair = null;
			ConfigTrackMoonMemoryByClassify.HandleId = 0;
		}

		// Token: 0x0600416F RID: 16751 RVA: 0x001CEB51 File Offset: 0x001CCD51
		public static void Init()
		{
			ConfigTrackMoonMemoryByClassify.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonMemoryByClassify.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonMemory` where Classify = ?");
		}

		// Token: 0x06004170 RID: 16752 RVA: 0x001CEB6C File Offset: 0x001CCD6C
		[NullableContext(2)]
		public static IReadOnlyList<TrackMoonMemory> GetConfigList(int p0Classify, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrackMoonMemoryByClassify.HandleId, ConfigTrackMoonMemoryByClassify.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonMemoryByClassify");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Classify);
				IReadOnlyList<TrackMoonMemory> readOnlyList = (IReadOnlyList<TrackMoonMemory>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTrackMoonMemoryByClassify.LogPair.Clear();
			ConfigTrackMoonMemoryByClassify.LogPair.Add(new ValueTuple<string, object>("Classify", p0Classify));
			if (!ConfigCommon.BindInt(ConfigTrackMoonMemoryByClassify.HandleId, 1, p0Classify, ConfigTrackMoonMemoryByClassify.LogPair))
			{
				ConfigCommon.Reset(ConfigTrackMoonMemoryByClassify.HandleId, ConfigTrackMoonMemoryByClassify.LogPair);
				return null;
			}
			List<TrackMoonMemory> list = new List<TrackMoonMemory>();
			while (ConfigCommon.Step(ConfigTrackMoonMemoryByClassify.HandleId, false, ConfigTrackMoonMemoryByClassify.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrackMoonMemoryByClassify.HandleId, 0, ConfigTrackMoonMemoryByClassify.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrackMoonMemoryByClassify.HandleId, ConfigTrackMoonMemoryByClassify.LogPair);
					return null;
				}
				TrackMoonMemory rootAsTrackMoonMemory = TrackMoonMemory.GetRootAsTrackMoonMemory(new ByteBuffer(item2));
				list.Add(rootAsTrackMoonMemory);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrackMoonMemoryByClassify");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Classify);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrackMoonMemoryByClassify.HandleId, ConfigTrackMoonMemoryByClassify.LogPair);
			return list;
		}

		// Token: 0x04004C22 RID: 19490
		private const string DB = "db_moonchasing.db";

		// Token: 0x04004C23 RID: 19491
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04004C24 RID: 19492
		private const string TABLE = "TrackMoonMemory";

		// Token: 0x04004C25 RID: 19493
		private const string COMMAND = "select BinData from `TrackMoonMemory` where Classify = ?";

		// Token: 0x04004C26 RID: 19494
		private const string KEY_PREFIX = "TrackMoonMemoryByClassify";

		// Token: 0x04004C27 RID: 19495
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C28 RID: 19496
		private static int HandleId;
	}
}
