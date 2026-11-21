using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000281 RID: 641
	public class ConfigEncircleChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F0A RID: 3850 RVA: 0x000B1D24 File Offset: 0x000AFF24
		static ConfigEncircleChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEncircleChallengeById.CreateStaticDefaultValue), new Action(ConfigEncircleChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x000B1D44 File Offset: 0x000AFF44
		public static void CreateStaticDefaultValue()
		{
			ConfigEncircleChallengeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEncircleChallengeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_encircle.db"),
				new ValueTuple<string, object>("文件", "j.界面围剿.xlsx"),
				new ValueTuple<string, object>("表名", "EncircleChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `EncircleChallenge` where Id=?")
			});
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x000B1DC3 File Offset: 0x000AFFC3
		public static void ResetStaticDefaultValue()
		{
			ConfigEncircleChallengeById.LogPair = null;
			ConfigEncircleChallengeById.HandleId = 0;
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x000B1DD1 File Offset: 0x000AFFD1
		public static void Init()
		{
			ConfigEncircleChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigEncircleChallengeById.HandleId, "db_encircle.db", "select BinData from `EncircleChallenge` where Id=?");
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x000B1DEC File Offset: 0x000AFFEC
		public static EncircleChallenge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEncircleChallengeById.HandleId, ConfigEncircleChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EncircleChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EncircleChallenge?(EncircleChallenge.GetRootAsEncircleChallenge(configBuffer));
				}
			}
			ConfigEncircleChallengeById.LogPair.Clear();
			ConfigEncircleChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEncircleChallengeById.HandleId, 1, p0Id, ConfigEncircleChallengeById.LogPair) || ConfigCommon.Step(ConfigEncircleChallengeById.HandleId, true, ConfigEncircleChallengeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEncircleChallengeById.HandleId, ConfigEncircleChallengeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEncircleChallengeById.HandleId, 0, ConfigEncircleChallengeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEncircleChallengeById.HandleId, ConfigEncircleChallengeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EncircleChallenge rootAsEncircleChallenge = EncircleChallenge.GetRootAsEncircleChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EncircleChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEncircleChallengeById.HandleId, ConfigEncircleChallengeById.LogPair);
			return new EncircleChallenge?(rootAsEncircleChallenge);
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x000B1F64 File Offset: 0x000B0164
		[NullableContext(2)]
		public static IReadOnlyList<EncircleChallenge> GetConfigList(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEncircleChallengeById.HandleId, ConfigEncircleChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EncircleChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				IReadOnlyList<EncircleChallenge> readOnlyList = (IReadOnlyList<EncircleChallenge>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigEncircleChallengeById.LogPair.Clear();
			ConfigEncircleChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEncircleChallengeById.HandleId, 1, p0Id, ConfigEncircleChallengeById.LogPair))
			{
				ConfigCommon.Reset(ConfigEncircleChallengeById.HandleId, ConfigEncircleChallengeById.LogPair);
				return null;
			}
			List<EncircleChallenge> list = new List<EncircleChallenge>();
			while (ConfigCommon.Step(ConfigEncircleChallengeById.HandleId, false, ConfigEncircleChallengeById.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEncircleChallengeById.HandleId, 0, ConfigEncircleChallengeById.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEncircleChallengeById.HandleId, ConfigEncircleChallengeById.LogPair);
					return null;
				}
				EncircleChallenge rootAsEncircleChallenge = EncircleChallenge.GetRootAsEncircleChallenge(new ByteBuffer(item2));
				list.Add(rootAsEncircleChallenge);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EncircleChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigEncircleChallengeById.HandleId, ConfigEncircleChallengeById.LogPair);
			return list;
		}

		// Token: 0x0400116B RID: 4459
		private const string DB = "db_encircle.db";

		// Token: 0x0400116C RID: 4460
		private const string FILE = "j.界面围剿.xlsx";

		// Token: 0x0400116D RID: 4461
		private const string TABLE = "EncircleChallenge";

		// Token: 0x0400116E RID: 4462
		private const string COMMAND = "select BinData from `EncircleChallenge` where Id=?";

		// Token: 0x0400116F RID: 4463
		private const string KEY_PREFIX = "EncircleChallengeById";

		// Token: 0x04001170 RID: 4464
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001171 RID: 4465
		private static int HandleId;
	}
}
