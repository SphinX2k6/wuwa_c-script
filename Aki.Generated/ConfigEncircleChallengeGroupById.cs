using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000270 RID: 624
	public class ConfigEncircleChallengeGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EA5 RID: 3749 RVA: 0x000AC2E5 File Offset: 0x000AA4E5
		static ConfigEncircleChallengeGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEncircleChallengeGroupById.CreateStaticDefaultValue), new Action(ConfigEncircleChallengeGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x000AC304 File Offset: 0x000AA504
		public static void CreateStaticDefaultValue()
		{
			ConfigEncircleChallengeGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEncircleChallengeGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_encircle.db"),
				new ValueTuple<string, object>("文件", "j.界面围剿.xlsx"),
				new ValueTuple<string, object>("表名", "EncircleChallengeGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `EncircleChallengeGroup` where Id=?")
			});
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x000AC383 File Offset: 0x000AA583
		public static void ResetStaticDefaultValue()
		{
			ConfigEncircleChallengeGroupById.LogPair = null;
			ConfigEncircleChallengeGroupById.HandleId = 0;
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x000AC391 File Offset: 0x000AA591
		public static void Init()
		{
			ConfigEncircleChallengeGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigEncircleChallengeGroupById.HandleId, "db_encircle.db", "select BinData from `EncircleChallengeGroup` where Id=?");
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x000AC3AC File Offset: 0x000AA5AC
		public static EncircleChallengeGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEncircleChallengeGroupById.HandleId, ConfigEncircleChallengeGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EncircleChallengeGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EncircleChallengeGroup?(EncircleChallengeGroup.GetRootAsEncircleChallengeGroup(configBuffer));
				}
			}
			ConfigEncircleChallengeGroupById.LogPair.Clear();
			ConfigEncircleChallengeGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEncircleChallengeGroupById.HandleId, 1, p0Id, ConfigEncircleChallengeGroupById.LogPair) || ConfigCommon.Step(ConfigEncircleChallengeGroupById.HandleId, true, ConfigEncircleChallengeGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEncircleChallengeGroupById.HandleId, ConfigEncircleChallengeGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEncircleChallengeGroupById.HandleId, 0, ConfigEncircleChallengeGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEncircleChallengeGroupById.HandleId, ConfigEncircleChallengeGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EncircleChallengeGroup rootAsEncircleChallengeGroup = EncircleChallengeGroup.GetRootAsEncircleChallengeGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EncircleChallengeGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEncircleChallengeGroupById.HandleId, ConfigEncircleChallengeGroupById.LogPair);
			return new EncircleChallengeGroup?(rootAsEncircleChallengeGroup);
		}

		// Token: 0x040010F4 RID: 4340
		private const string DB = "db_encircle.db";

		// Token: 0x040010F5 RID: 4341
		private const string FILE = "j.界面围剿.xlsx";

		// Token: 0x040010F6 RID: 4342
		private const string TABLE = "EncircleChallengeGroup";

		// Token: 0x040010F7 RID: 4343
		private const string COMMAND = "select BinData from `EncircleChallengeGroup` where Id=?";

		// Token: 0x040010F8 RID: 4344
		private const string KEY_PREFIX = "EncircleChallengeGroupById";

		// Token: 0x040010F9 RID: 4345
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010FA RID: 4346
		private static int HandleId;
	}
}
