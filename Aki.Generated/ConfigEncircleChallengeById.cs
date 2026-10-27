using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200026D RID: 621
	public class ConfigEncircleChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E92 RID: 3730 RVA: 0x000ABA60 File Offset: 0x000A9C60
		static ConfigEncircleChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEncircleChallengeById.CreateStaticDefaultValue), new Action(ConfigEncircleChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x000ABA80 File Offset: 0x000A9C80
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

		// Token: 0x06000E94 RID: 3732 RVA: 0x000ABAFF File Offset: 0x000A9CFF
		public static void ResetStaticDefaultValue()
		{
			ConfigEncircleChallengeById.LogPair = null;
			ConfigEncircleChallengeById.HandleId = 0;
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x000ABB0D File Offset: 0x000A9D0D
		public static void Init()
		{
			ConfigEncircleChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigEncircleChallengeById.HandleId, "db_encircle.db", "select BinData from `EncircleChallenge` where Id=?");
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x000ABB28 File Offset: 0x000A9D28
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

		// Token: 0x06000E97 RID: 3735 RVA: 0x000ABCA0 File Offset: 0x000A9EA0
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

		// Token: 0x040010DF RID: 4319
		private const string DB = "db_encircle.db";

		// Token: 0x040010E0 RID: 4320
		private const string FILE = "j.界面围剿.xlsx";

		// Token: 0x040010E1 RID: 4321
		private const string TABLE = "EncircleChallenge";

		// Token: 0x040010E2 RID: 4322
		private const string COMMAND = "select BinData from `EncircleChallenge` where Id=?";

		// Token: 0x040010E3 RID: 4323
		private const string KEY_PREFIX = "EncircleChallengeById";

		// Token: 0x040010E4 RID: 4324
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010E5 RID: 4325
		private static int HandleId;
	}
}
