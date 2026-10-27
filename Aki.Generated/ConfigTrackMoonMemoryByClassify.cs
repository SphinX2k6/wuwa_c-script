using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A0F RID: 2575
	public class ConfigTrackMoonMemoryByClassify : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C6E RID: 15470 RVA: 0x001AF70F File Offset: 0x001AD90F
		static ConfigTrackMoonMemoryByClassify()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonMemoryByClassify.CreateStaticDefaultValue), new Action(ConfigTrackMoonMemoryByClassify.ResetStaticDefaultValue));
		}

		// Token: 0x06003C6F RID: 15471 RVA: 0x001AF730 File Offset: 0x001AD930
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

		// Token: 0x06003C70 RID: 15472 RVA: 0x001AF7AF File Offset: 0x001AD9AF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonMemoryByClassify.LogPair = null;
			ConfigTrackMoonMemoryByClassify.HandleId = 0;
		}

		// Token: 0x06003C71 RID: 15473 RVA: 0x001AF7BD File Offset: 0x001AD9BD
		public static void Init()
		{
			ConfigTrackMoonMemoryByClassify.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonMemoryByClassify.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonMemory` where Classify = ?");
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x001AF7D8 File Offset: 0x001AD9D8
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

		// Token: 0x0400464F RID: 17999
		private const string DB = "db_moonchasing.db";

		// Token: 0x04004650 RID: 18000
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04004651 RID: 18001
		private const string TABLE = "TrackMoonMemory";

		// Token: 0x04004652 RID: 18002
		private const string COMMAND = "select BinData from `TrackMoonMemory` where Classify = ?";

		// Token: 0x04004653 RID: 18003
		private const string KEY_PREFIX = "TrackMoonMemoryByClassify";

		// Token: 0x04004654 RID: 18004
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004655 RID: 18005
		private static int HandleId;
	}
}
