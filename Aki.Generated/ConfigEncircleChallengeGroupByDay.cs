using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000283 RID: 643
	public class ConfigEncircleChallengeGroupByDay : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F17 RID: 3863 RVA: 0x000B230B File Offset: 0x000B050B
		static ConfigEncircleChallengeGroupByDay()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEncircleChallengeGroupByDay.CreateStaticDefaultValue), new Action(ConfigEncircleChallengeGroupByDay.ResetStaticDefaultValue));
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x000B232C File Offset: 0x000B052C
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

		// Token: 0x06000F19 RID: 3865 RVA: 0x000B23AB File Offset: 0x000B05AB
		public static void ResetStaticDefaultValue()
		{
			ConfigEncircleChallengeGroupByDay.LogPair = null;
			ConfigEncircleChallengeGroupByDay.HandleId = 0;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x000B23B9 File Offset: 0x000B05B9
		public static void Init()
		{
			ConfigEncircleChallengeGroupByDay.HandleId = ConfigCommon.InitDataStatement(ConfigEncircleChallengeGroupByDay.HandleId, "db_encircle.db", "select BinData from `EncircleChallengeGroup` where ActivityId=? AND OpenDay=?");
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x000B23D4 File Offset: 0x000B05D4
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

		// Token: 0x04001179 RID: 4473
		private const string DB = "db_encircle.db";

		// Token: 0x0400117A RID: 4474
		private const string FILE = "j.界面围剿.xlsx";

		// Token: 0x0400117B RID: 4475
		private const string TABLE = "EncircleChallengeGroup";

		// Token: 0x0400117C RID: 4476
		private const string COMMAND = "select BinData from `EncircleChallengeGroup` where ActivityId=? AND OpenDay=?";

		// Token: 0x0400117D RID: 4477
		private const string KEY_PREFIX = "EncircleChallengeGroupByDay";

		// Token: 0x0400117E RID: 4478
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400117F RID: 4479
		private static int HandleId;
	}
}
