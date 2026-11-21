using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000284 RID: 644
	public class ConfigEncircleChallengeGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F1D RID: 3869 RVA: 0x000B25A9 File Offset: 0x000B07A9
		static ConfigEncircleChallengeGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEncircleChallengeGroupById.CreateStaticDefaultValue), new Action(ConfigEncircleChallengeGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x000B25C8 File Offset: 0x000B07C8
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

		// Token: 0x06000F1F RID: 3871 RVA: 0x000B2647 File Offset: 0x000B0847
		public static void ResetStaticDefaultValue()
		{
			ConfigEncircleChallengeGroupById.LogPair = null;
			ConfigEncircleChallengeGroupById.HandleId = 0;
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x000B2655 File Offset: 0x000B0855
		public static void Init()
		{
			ConfigEncircleChallengeGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigEncircleChallengeGroupById.HandleId, "db_encircle.db", "select BinData from `EncircleChallengeGroup` where Id=?");
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x000B2670 File Offset: 0x000B0870
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

		// Token: 0x04001180 RID: 4480
		private const string DB = "db_encircle.db";

		// Token: 0x04001181 RID: 4481
		private const string FILE = "j.界面围剿.xlsx";

		// Token: 0x04001182 RID: 4482
		private const string TABLE = "EncircleChallengeGroup";

		// Token: 0x04001183 RID: 4483
		private const string COMMAND = "select BinData from `EncircleChallengeGroup` where Id=?";

		// Token: 0x04001184 RID: 4484
		private const string KEY_PREFIX = "EncircleChallengeGroupById";

		// Token: 0x04001185 RID: 4485
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001186 RID: 4486
		private static int HandleId;
	}
}
