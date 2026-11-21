using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B24 RID: 2852
	public class ConfigTreasureBoxDetectorMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042EC RID: 17132 RVA: 0x001D7524 File Offset: 0x001D5724
		static ConfigTreasureBoxDetectorMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTreasureBoxDetectorMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigTreasureBoxDetectorMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x060042ED RID: 17133 RVA: 0x001D7544 File Offset: 0x001D5744
		public static void CreateStaticDefaultValue()
		{
			ConfigTreasureBoxDetectorMarkByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTreasureBoxDetectorMarkByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "TreasureBoxDetectorMark"),
				new ValueTuple<string, object>("语句", "select BinData from `TreasureBoxDetectorMark` where MarkId=?")
			});
		}

		// Token: 0x060042EE RID: 17134 RVA: 0x001D75C3 File Offset: 0x001D57C3
		public static void ResetStaticDefaultValue()
		{
			ConfigTreasureBoxDetectorMarkByMarkId.LogPair = null;
			ConfigTreasureBoxDetectorMarkByMarkId.HandleId = 0;
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x001D75D1 File Offset: 0x001D57D1
		public static void Init()
		{
			ConfigTreasureBoxDetectorMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigTreasureBoxDetectorMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `TreasureBoxDetectorMark` where MarkId=?");
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x001D75EC File Offset: 0x001D57EC
		public static TreasureBoxDetectorMark? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTreasureBoxDetectorMarkByMarkId.HandleId, ConfigTreasureBoxDetectorMarkByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TreasureBoxDetectorMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TreasureBoxDetectorMark?(TreasureBoxDetectorMark.GetRootAsTreasureBoxDetectorMark(configBuffer));
				}
			}
			ConfigTreasureBoxDetectorMarkByMarkId.LogPair.Clear();
			ConfigTreasureBoxDetectorMarkByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigTreasureBoxDetectorMarkByMarkId.HandleId, 1, p0MarkId, ConfigTreasureBoxDetectorMarkByMarkId.LogPair) || ConfigCommon.Step(ConfigTreasureBoxDetectorMarkByMarkId.HandleId, true, ConfigTreasureBoxDetectorMarkByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTreasureBoxDetectorMarkByMarkId.HandleId, ConfigTreasureBoxDetectorMarkByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTreasureBoxDetectorMarkByMarkId.HandleId, 0, ConfigTreasureBoxDetectorMarkByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTreasureBoxDetectorMarkByMarkId.HandleId, ConfigTreasureBoxDetectorMarkByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TreasureBoxDetectorMark rootAsTreasureBoxDetectorMark = TreasureBoxDetectorMark.GetRootAsTreasureBoxDetectorMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TreasureBoxDetectorMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTreasureBoxDetectorMarkByMarkId.HandleId, ConfigTreasureBoxDetectorMarkByMarkId.LogPair);
			return new TreasureBoxDetectorMark?(rootAsTreasureBoxDetectorMark);
		}

		// Token: 0x04004DE2 RID: 19938
		private const string DB = "db_map_mark.db";

		// Token: 0x04004DE3 RID: 19939
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04004DE4 RID: 19940
		private const string TABLE = "TreasureBoxDetectorMark";

		// Token: 0x04004DE5 RID: 19941
		private const string COMMAND = "select BinData from `TreasureBoxDetectorMark` where MarkId=?";

		// Token: 0x04004DE6 RID: 19942
		private const string KEY_PREFIX = "TreasureBoxDetectorMarkByMarkId";

		// Token: 0x04004DE7 RID: 19943
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004DE8 RID: 19944
		private static int HandleId;
	}
}
