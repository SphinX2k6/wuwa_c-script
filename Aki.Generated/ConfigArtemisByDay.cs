using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B2 RID: 178
	public class ConfigArtemisByDay : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600042D RID: 1069 RVA: 0x00071503 File Offset: 0x0006F703
		static ConfigArtemisByDay()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigArtemisByDay.CreateStaticDefaultValue), new Action(ConfigArtemisByDay.ResetStaticDefaultValue));
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00071524 File Offset: 0x0006F724
		public static void CreateStaticDefaultValue()
		{
			ConfigArtemisByDay.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigArtemisByDay.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_artemis.db"),
				new ValueTuple<string, object>("文件", "a.爱弥斯预热签到活动.xlsx"),
				new ValueTuple<string, object>("表名", "Artemis"),
				new ValueTuple<string, object>("语句", "select BinData from `Artemis` where ActivityId=? AND UnlockDay=?")
			});
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000715A3 File Offset: 0x0006F7A3
		public static void ResetStaticDefaultValue()
		{
			ConfigArtemisByDay.LogPair = null;
			ConfigArtemisByDay.HandleId = 0;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000715B1 File Offset: 0x0006F7B1
		public static void Init()
		{
			ConfigArtemisByDay.HandleId = ConfigCommon.InitDataStatement(ConfigArtemisByDay.HandleId, "db_artemis.db", "select BinData from `Artemis` where ActivityId=? AND UnlockDay=?");
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000715CC File Offset: 0x0006F7CC
		public static Artemis? GetConfig(int p0ActivityId, int p1UnlockDay, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigArtemisByDay.HandleId, ConfigArtemisByDay.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("ArtemisByDay");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1UnlockDay);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Artemis?(Artemis.GetRootAsArtemis(configBuffer));
				}
			}
			ConfigArtemisByDay.LogPair.Clear();
			ConfigArtemisByDay.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigArtemisByDay.LogPair.Add(new ValueTuple<string, object>("UnlockDay", p1UnlockDay));
			if (!ConfigCommon.BindInt(ConfigArtemisByDay.HandleId, 1, p0ActivityId, ConfigArtemisByDay.LogPair) || !ConfigCommon.BindInt(ConfigArtemisByDay.HandleId, 2, p1UnlockDay, ConfigArtemisByDay.LogPair) || ConfigCommon.Step(ConfigArtemisByDay.HandleId, true, ConfigArtemisByDay.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigArtemisByDay.HandleId, ConfigArtemisByDay.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigArtemisByDay.HandleId, 0, ConfigArtemisByDay.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigArtemisByDay.HandleId, ConfigArtemisByDay.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Artemis rootAsArtemis = Artemis.GetRootAsArtemis(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("ArtemisByDay");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1UnlockDay);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigArtemisByDay.HandleId, ConfigArtemisByDay.LogPair);
			return new Artemis?(rootAsArtemis);
		}

		// Token: 0x040004C2 RID: 1218
		private const string DB = "db_artemis.db";

		// Token: 0x040004C3 RID: 1219
		private const string FILE = "a.爱弥斯预热签到活动.xlsx";

		// Token: 0x040004C4 RID: 1220
		private const string TABLE = "Artemis";

		// Token: 0x040004C5 RID: 1221
		private const string COMMAND = "select BinData from `Artemis` where ActivityId=? AND UnlockDay=?";

		// Token: 0x040004C6 RID: 1222
		private const string KEY_PREFIX = "ArtemisByDay";

		// Token: 0x040004C7 RID: 1223
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004C8 RID: 1224
		private static int HandleId;
	}
}
