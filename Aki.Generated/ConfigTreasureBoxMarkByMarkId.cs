using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A50 RID: 2640
	public class ConfigTreasureBoxMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DF4 RID: 15860 RVA: 0x001B83D8 File Offset: 0x001B65D8
		static ConfigTreasureBoxMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTreasureBoxMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigTreasureBoxMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x001B83F8 File Offset: 0x001B65F8
		public static void CreateStaticDefaultValue()
		{
			ConfigTreasureBoxMarkByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTreasureBoxMarkByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "TreasureBoxMark"),
				new ValueTuple<string, object>("语句", "select BinData from `TreasureBoxMark` where MarkId=?")
			});
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x001B8477 File Offset: 0x001B6677
		public static void ResetStaticDefaultValue()
		{
			ConfigTreasureBoxMarkByMarkId.LogPair = null;
			ConfigTreasureBoxMarkByMarkId.HandleId = 0;
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x001B8485 File Offset: 0x001B6685
		public static void Init()
		{
			ConfigTreasureBoxMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigTreasureBoxMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `TreasureBoxMark` where MarkId=?");
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x001B84A0 File Offset: 0x001B66A0
		public static TreasureBoxMark? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTreasureBoxMarkByMarkId.HandleId, ConfigTreasureBoxMarkByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TreasureBoxMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TreasureBoxMark?(TreasureBoxMark.GetRootAsTreasureBoxMark(configBuffer));
				}
			}
			ConfigTreasureBoxMarkByMarkId.LogPair.Clear();
			ConfigTreasureBoxMarkByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigTreasureBoxMarkByMarkId.HandleId, 1, p0MarkId, ConfigTreasureBoxMarkByMarkId.LogPair) || ConfigCommon.Step(ConfigTreasureBoxMarkByMarkId.HandleId, true, ConfigTreasureBoxMarkByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTreasureBoxMarkByMarkId.HandleId, ConfigTreasureBoxMarkByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTreasureBoxMarkByMarkId.HandleId, 0, ConfigTreasureBoxMarkByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTreasureBoxMarkByMarkId.HandleId, ConfigTreasureBoxMarkByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TreasureBoxMark rootAsTreasureBoxMark = TreasureBoxMark.GetRootAsTreasureBoxMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TreasureBoxMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTreasureBoxMarkByMarkId.HandleId, ConfigTreasureBoxMarkByMarkId.LogPair);
			return new TreasureBoxMark?(rootAsTreasureBoxMark);
		}

		// Token: 0x04004816 RID: 18454
		private const string DB = "db_map_mark.db";

		// Token: 0x04004817 RID: 18455
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04004818 RID: 18456
		private const string TABLE = "TreasureBoxMark";

		// Token: 0x04004819 RID: 18457
		private const string COMMAND = "select BinData from `TreasureBoxMark` where MarkId=?";

		// Token: 0x0400481A RID: 18458
		private const string KEY_PREFIX = "TreasureBoxMarkByMarkId";

		// Token: 0x0400481B RID: 18459
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400481C RID: 18460
		private static int HandleId;
	}
}
