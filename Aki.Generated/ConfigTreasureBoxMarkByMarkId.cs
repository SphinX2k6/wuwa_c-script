using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B25 RID: 2853
	public class ConfigTreasureBoxMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060042F2 RID: 17138 RVA: 0x001D776C File Offset: 0x001D596C
		static ConfigTreasureBoxMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTreasureBoxMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigTreasureBoxMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x001D778C File Offset: 0x001D598C
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

		// Token: 0x060042F4 RID: 17140 RVA: 0x001D780B File Offset: 0x001D5A0B
		public static void ResetStaticDefaultValue()
		{
			ConfigTreasureBoxMarkByMarkId.LogPair = null;
			ConfigTreasureBoxMarkByMarkId.HandleId = 0;
		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x001D7819 File Offset: 0x001D5A19
		public static void Init()
		{
			ConfigTreasureBoxMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigTreasureBoxMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `TreasureBoxMark` where MarkId=?");
		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x001D7834 File Offset: 0x001D5A34
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

		// Token: 0x04004DE9 RID: 19945
		private const string DB = "db_map_mark.db";

		// Token: 0x04004DEA RID: 19946
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04004DEB RID: 19947
		private const string TABLE = "TreasureBoxMark";

		// Token: 0x04004DEC RID: 19948
		private const string COMMAND = "select BinData from `TreasureBoxMark` where MarkId=?";

		// Token: 0x04004DED RID: 19949
		private const string KEY_PREFIX = "TreasureBoxMarkByMarkId";

		// Token: 0x04004DEE RID: 19950
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004DEF RID: 19951
		private static int HandleId;
	}
}
