using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E8 RID: 488
	public class ConfigDangoBrawlOpponentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B73 RID: 2931 RVA: 0x0009DD84 File Offset: 0x0009BF84
		static ConfigDangoBrawlOpponentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlOpponentById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlOpponentById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0009DDA4 File Offset: 0x0009BFA4
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlOpponentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlOpponentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlOpponent"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlOpponent` where Id=?")
			});
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0009DE23 File Offset: 0x0009C023
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlOpponentById.LogPair = null;
			ConfigDangoBrawlOpponentById.HandleId = 0;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0009DE31 File Offset: 0x0009C031
		public static void Init()
		{
			ConfigDangoBrawlOpponentById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlOpponentById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlOpponent` where Id=?");
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0009DE4C File Offset: 0x0009C04C
		public static DangoBrawlOpponent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlOpponentById.HandleId, ConfigDangoBrawlOpponentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlOpponentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlOpponent?(DangoBrawlOpponent.GetRootAsDangoBrawlOpponent(configBuffer));
				}
			}
			ConfigDangoBrawlOpponentById.LogPair.Clear();
			ConfigDangoBrawlOpponentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlOpponentById.HandleId, 1, p0Id, ConfigDangoBrawlOpponentById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlOpponentById.HandleId, true, ConfigDangoBrawlOpponentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlOpponentById.HandleId, ConfigDangoBrawlOpponentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlOpponentById.HandleId, 0, ConfigDangoBrawlOpponentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlOpponentById.HandleId, ConfigDangoBrawlOpponentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlOpponent rootAsDangoBrawlOpponent = DangoBrawlOpponent.GetRootAsDangoBrawlOpponent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlOpponentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlOpponentById.HandleId, ConfigDangoBrawlOpponentById.LogPair);
			return new DangoBrawlOpponent?(rootAsDangoBrawlOpponent);
		}

		// Token: 0x04000D3C RID: 3388
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D3D RID: 3389
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D3E RID: 3390
		private const string TABLE = "DangoBrawlOpponent";

		// Token: 0x04000D3F RID: 3391
		private const string COMMAND = "select BinData from `DangoBrawlOpponent` where Id=?";

		// Token: 0x04000D40 RID: 3392
		private const string KEY_PREFIX = "DangoBrawlOpponentById";

		// Token: 0x04000D41 RID: 3393
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D42 RID: 3394
		private static int HandleId;
	}
}
