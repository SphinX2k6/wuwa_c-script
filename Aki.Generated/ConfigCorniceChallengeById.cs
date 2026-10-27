using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A9 RID: 425
	public class ConfigCorniceChallengeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009F9 RID: 2553 RVA: 0x00091EB8 File Offset: 0x000900B8
		static ConfigCorniceChallengeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCorniceChallengeById.CreateStaticDefaultValue), new Action(ConfigCorniceChallengeById.ResetStaticDefaultValue));
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00091ED8 File Offset: 0x000900D8
		public static void CreateStaticDefaultValue()
		{
			ConfigCorniceChallengeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCorniceChallengeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cornicechallenge.db"),
				new ValueTuple<string, object>("文件", "s.数据收集异常活动.xlsx"),
				new ValueTuple<string, object>("表名", "CorniceChallenge"),
				new ValueTuple<string, object>("语句", "select BinData from `CorniceChallenge` where Id=?")
			});
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00091F57 File Offset: 0x00090157
		public static void ResetStaticDefaultValue()
		{
			ConfigCorniceChallengeById.LogPair = null;
			ConfigCorniceChallengeById.HandleId = 0;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00091F65 File Offset: 0x00090165
		public static void Init()
		{
			ConfigCorniceChallengeById.HandleId = ConfigCommon.InitDataStatement(ConfigCorniceChallengeById.HandleId, "db_cornicechallenge.db", "select BinData from `CorniceChallenge` where Id=?");
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00091F80 File Offset: 0x00090180
		public static CorniceChallenge? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCorniceChallengeById.HandleId, ConfigCorniceChallengeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CorniceChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CorniceChallenge?(CorniceChallenge.GetRootAsCorniceChallenge(configBuffer));
				}
			}
			ConfigCorniceChallengeById.LogPair.Clear();
			ConfigCorniceChallengeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCorniceChallengeById.HandleId, 1, p0Id, ConfigCorniceChallengeById.LogPair) || ConfigCommon.Step(ConfigCorniceChallengeById.HandleId, true, ConfigCorniceChallengeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCorniceChallengeById.HandleId, ConfigCorniceChallengeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCorniceChallengeById.HandleId, 0, ConfigCorniceChallengeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCorniceChallengeById.HandleId, ConfigCorniceChallengeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CorniceChallenge rootAsCorniceChallenge = CorniceChallenge.GetRootAsCorniceChallenge(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CorniceChallengeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCorniceChallengeById.HandleId, ConfigCorniceChallengeById.LogPair);
			return new CorniceChallenge?(rootAsCorniceChallenge);
		}

		// Token: 0x04000B83 RID: 2947
		private const string DB = "db_cornicechallenge.db";

		// Token: 0x04000B84 RID: 2948
		private const string FILE = "s.数据收集异常活动.xlsx";

		// Token: 0x04000B85 RID: 2949
		private const string TABLE = "CorniceChallenge";

		// Token: 0x04000B86 RID: 2950
		private const string COMMAND = "select BinData from `CorniceChallenge` where Id=?";

		// Token: 0x04000B87 RID: 2951
		private const string KEY_PREFIX = "CorniceChallengeById";

		// Token: 0x04000B88 RID: 2952
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B89 RID: 2953
		private static int HandleId;
	}
}
