using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003CC RID: 972
	public class ConfigHandBookEntranceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016CF RID: 5839 RVA: 0x000DA71F File Offset: 0x000D891F
		static ConfigHandBookEntranceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHandBookEntranceById.CreateStaticDefaultValue), new Action(ConfigHandBookEntranceById.ResetStaticDefaultValue));
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x000DA740 File Offset: 0x000D8940
		public static void CreateStaticDefaultValue()
		{
			ConfigHandBookEntranceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHandBookEntranceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook_entrance.db"),
				new ValueTuple<string, object>("文件", "t.图鉴入口.xlsx"),
				new ValueTuple<string, object>("表名", "HandBookEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `HandBookEntrance` where Id=?")
			});
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x000DA7BF File Offset: 0x000D89BF
		public static void ResetStaticDefaultValue()
		{
			ConfigHandBookEntranceById.LogPair = null;
			ConfigHandBookEntranceById.HandleId = 0;
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x000DA7CD File Offset: 0x000D89CD
		public static void Init()
		{
			ConfigHandBookEntranceById.HandleId = ConfigCommon.InitDataStatement(ConfigHandBookEntranceById.HandleId, "db_handbook_entrance.db", "select BinData from `HandBookEntrance` where Id=?");
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x000DA7E8 File Offset: 0x000D89E8
		public static HandBookEntrance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHandBookEntranceById.HandleId, ConfigHandBookEntranceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HandBookEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HandBookEntrance?(HandBookEntrance.GetRootAsHandBookEntrance(configBuffer));
				}
			}
			ConfigHandBookEntranceById.LogPair.Clear();
			ConfigHandBookEntranceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHandBookEntranceById.HandleId, 1, p0Id, ConfigHandBookEntranceById.LogPair) || ConfigCommon.Step(ConfigHandBookEntranceById.HandleId, true, ConfigHandBookEntranceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHandBookEntranceById.HandleId, ConfigHandBookEntranceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHandBookEntranceById.HandleId, 0, ConfigHandBookEntranceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHandBookEntranceById.HandleId, ConfigHandBookEntranceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HandBookEntrance rootAsHandBookEntrance = HandBookEntrance.GetRootAsHandBookEntrance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HandBookEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHandBookEntranceById.HandleId, ConfigHandBookEntranceById.LogPair);
			return new HandBookEntrance?(rootAsHandBookEntrance);
		}

		// Token: 0x04001A78 RID: 6776
		private const string DB = "db_handbook_entrance.db";

		// Token: 0x04001A79 RID: 6777
		private const string FILE = "t.图鉴入口.xlsx";

		// Token: 0x04001A7A RID: 6778
		private const string TABLE = "HandBookEntrance";

		// Token: 0x04001A7B RID: 6779
		private const string COMMAND = "select BinData from `HandBookEntrance` where Id=?";

		// Token: 0x04001A7C RID: 6780
		private const string KEY_PREFIX = "HandBookEntranceById";

		// Token: 0x04001A7D RID: 6781
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A7E RID: 6782
		private static int HandleId;
	}
}
