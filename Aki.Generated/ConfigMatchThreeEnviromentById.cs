using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000545 RID: 1349
	public class ConfigMatchThreeEnviromentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FA9 RID: 8105 RVA: 0x0010FC48 File Offset: 0x0010DE48
		static ConfigMatchThreeEnviromentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMatchThreeEnviromentById.CreateStaticDefaultValue), new Action(ConfigMatchThreeEnviromentById.ResetStaticDefaultValue));
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x0010FC68 File Offset: 0x0010DE68
		public static void CreateStaticDefaultValue()
		{
			ConfigMatchThreeEnviromentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMatchThreeEnviromentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_matchthree.db"),
				new ValueTuple<string, object>("文件", "s.三消活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "MatchThreeEnviroment"),
				new ValueTuple<string, object>("语句", "select BinData from `MatchThreeEnviroment` where Id=?")
			});
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x0010FCE7 File Offset: 0x0010DEE7
		public static void ResetStaticDefaultValue()
		{
			ConfigMatchThreeEnviromentById.LogPair = null;
			ConfigMatchThreeEnviromentById.HandleId = 0;
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x0010FCF5 File Offset: 0x0010DEF5
		public static void Init()
		{
			ConfigMatchThreeEnviromentById.HandleId = ConfigCommon.InitDataStatement(ConfigMatchThreeEnviromentById.HandleId, "db_matchthree.db", "select BinData from `MatchThreeEnviroment` where Id=?");
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x0010FD10 File Offset: 0x0010DF10
		public static MatchThreeEnviroment? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMatchThreeEnviromentById.HandleId, ConfigMatchThreeEnviromentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeEnviromentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MatchThreeEnviroment?(MatchThreeEnviroment.GetRootAsMatchThreeEnviroment(configBuffer));
				}
			}
			ConfigMatchThreeEnviromentById.LogPair.Clear();
			ConfigMatchThreeEnviromentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMatchThreeEnviromentById.HandleId, 1, p0Id, ConfigMatchThreeEnviromentById.LogPair) || ConfigCommon.Step(ConfigMatchThreeEnviromentById.HandleId, true, ConfigMatchThreeEnviromentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMatchThreeEnviromentById.HandleId, ConfigMatchThreeEnviromentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMatchThreeEnviromentById.HandleId, 0, ConfigMatchThreeEnviromentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMatchThreeEnviromentById.HandleId, ConfigMatchThreeEnviromentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MatchThreeEnviroment rootAsMatchThreeEnviroment = MatchThreeEnviroment.GetRootAsMatchThreeEnviroment(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MatchThreeEnviromentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMatchThreeEnviromentById.HandleId, ConfigMatchThreeEnviromentById.LogPair);
			return new MatchThreeEnviroment?(rootAsMatchThreeEnviroment);
		}

		// Token: 0x040024C7 RID: 9415
		private const string DB = "db_matchthree.db";

		// Token: 0x040024C8 RID: 9416
		private const string FILE = "s.三消活动局内.xlsx";

		// Token: 0x040024C9 RID: 9417
		private const string TABLE = "MatchThreeEnviroment";

		// Token: 0x040024CA RID: 9418
		private const string COMMAND = "select BinData from `MatchThreeEnviroment` where Id=?";

		// Token: 0x040024CB RID: 9419
		private const string KEY_PREFIX = "MatchThreeEnviromentById";

		// Token: 0x040024CC RID: 9420
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024CD RID: 9421
		private static int HandleId;
	}
}
