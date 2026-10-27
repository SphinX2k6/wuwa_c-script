using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200026F RID: 623
	public class ConfigEncircleChallengeGroupByDay : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E9F RID: 3743 RVA: 0x000AC047 File Offset: 0x000AA247
		static ConfigEncircleChallengeGroupByDay()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEncircleChallengeGroupByDay.CreateStaticDefaultValue), new Action(ConfigEncircleChallengeGroupByDay.ResetStaticDefaultValue));
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x000AC068 File Offset: 0x000AA268
		public static void CreateStaticDefaultValue()
		{
			ConfigEncircleChallengeGroupByDay.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEncircleChallengeGroupByDay.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_encircle.db"),
				new ValueTuple<string, object>("文件", "j.界面围剿.xlsx"),
				new ValueTuple<string, object>("表名", "EncircleChallengeGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `EncircleChallengeGroup` where ActivityId=? AND OpenDay=?")
			});
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x000AC0E7 File Offset: 0x000AA2E7
		public static void ResetStaticDefaultValue()
		{
			ConfigEncircleChallengeGroupByDay.LogPair = null;
			ConfigEncircleChallengeGroupByDay.HandleId = 0;
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x000AC0F5 File Offset: 0x000AA2F5
		public static void Init()
		{
			ConfigEncircleChallengeGroupByDay.HandleId = ConfigCommon.InitDataStatement(ConfigEncircleChallengeGroupByDay.HandleId, "db_encircle.db", "select BinData from `EncircleChallengeGroup` where ActivityId=? AND OpenDay=?");
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x000AC110 File Offset: 0x000AA310
		public static EncircleChallengeGroup? GetConfig(int p0ActivityId, int p1OpenDay, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEncircleChallengeGroupByDay.HandleId, ConfigEncircleChallengeGroupByDay.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("EncircleChallengeGroupByDay");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1OpenDay);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EncircleChallengeGroup?(EncircleChallengeGroup.GetRootAsEncircleChallengeGroup(configBuffer));
				}
			}
			ConfigEncircleChallengeGroupByDay.LogPair.Clear();
			ConfigEncircleChallengeGroupByDay.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			ConfigEncircleChallengeGroupByDay.LogPair.Add(new ValueTuple<string, object>("OpenDay", p1OpenDay));
			if (!ConfigCommon.BindInt(ConfigEncircleChallengeGroupByDay.HandleId, 1, p0ActivityId, ConfigEncircleChallengeGroupByDay.LogPair) || !ConfigCommon.BindInt(ConfigEncircleChallengeGroupByDay.HandleId, 2, p1OpenDay, ConfigEncircleChallengeGroupByDay.LogPair) || ConfigCommon.Step(ConfigEncircleChallengeGroupByDay.HandleId, true, ConfigEncircleChallengeGroupByDay.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEncircleChallengeGroupByDay.HandleId, ConfigEncircleChallengeGroupByDay.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEncircleChallengeGroupByDay.HandleId, 0, ConfigEncircleChallengeGroupByDay.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEncircleChallengeGroupByDay.HandleId, ConfigEncircleChallengeGroupByDay.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EncircleChallengeGroup rootAsEncircleChallengeGroup = EncircleChallengeGroup.GetRootAsEncircleChallengeGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("EncircleChallengeGroupByDay");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1OpenDay);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEncircleChallengeGroupByDay.HandleId, ConfigEncircleChallengeGroupByDay.LogPair);
			return new EncircleChallengeGroup?(rootAsEncircleChallengeGroup);
		}

		// Token: 0x040010ED RID: 4333
		private const string DB = "db_encircle.db";

		// Token: 0x040010EE RID: 4334
		private const string FILE = "j.界面围剿.xlsx";

		// Token: 0x040010EF RID: 4335
		private const string TABLE = "EncircleChallengeGroup";

		// Token: 0x040010F0 RID: 4336
		private const string COMMAND = "select BinData from `EncircleChallengeGroup` where ActivityId=? AND OpenDay=?";

		// Token: 0x040010F1 RID: 4337
		private const string KEY_PREFIX = "EncircleChallengeGroupByDay";

		// Token: 0x040010F2 RID: 4338
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010F3 RID: 4339
		private static int HandleId;
	}
}
