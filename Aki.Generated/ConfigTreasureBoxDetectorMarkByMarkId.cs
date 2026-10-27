using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A4F RID: 2639
	public class ConfigTreasureBoxDetectorMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DEE RID: 15854 RVA: 0x001B8190 File Offset: 0x001B6390
		static ConfigTreasureBoxDetectorMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTreasureBoxDetectorMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigTreasureBoxDetectorMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x001B81B0 File Offset: 0x001B63B0
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

		// Token: 0x06003DF0 RID: 15856 RVA: 0x001B822F File Offset: 0x001B642F
		public static void ResetStaticDefaultValue()
		{
			ConfigTreasureBoxDetectorMarkByMarkId.LogPair = null;
			ConfigTreasureBoxDetectorMarkByMarkId.HandleId = 0;
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x001B823D File Offset: 0x001B643D
		public static void Init()
		{
			ConfigTreasureBoxDetectorMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigTreasureBoxDetectorMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `TreasureBoxDetectorMark` where MarkId=?");
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x001B8258 File Offset: 0x001B6458
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

		// Token: 0x0400480F RID: 18447
		private const string DB = "db_map_mark.db";

		// Token: 0x04004810 RID: 18448
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04004811 RID: 18449
		private const string TABLE = "TreasureBoxDetectorMark";

		// Token: 0x04004812 RID: 18450
		private const string COMMAND = "select BinData from `TreasureBoxDetectorMark` where MarkId=?";

		// Token: 0x04004813 RID: 18451
		private const string KEY_PREFIX = "TreasureBoxDetectorMarkByMarkId";

		// Token: 0x04004814 RID: 18452
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004815 RID: 18453
		private static int HandleId;
	}
}
