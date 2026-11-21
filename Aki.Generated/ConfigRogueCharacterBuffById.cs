using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200083B RID: 2107
	public class ConfigRogueCharacterBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003174 RID: 12660 RVA: 0x00174570 File Offset: 0x00172770
		static ConfigRogueCharacterBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueCharacterBuffById.CreateStaticDefaultValue), new Action(ConfigRogueCharacterBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x00174590 File Offset: 0x00172790
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueCharacterBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueCharacterBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueCharacterBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueCharacterBuff` where Id=?")
			});
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x0017460F File Offset: 0x0017280F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueCharacterBuffById.LogPair = null;
			ConfigRogueCharacterBuffById.HandleId = 0;
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x0017461D File Offset: 0x0017281D
		public static void Init()
		{
			ConfigRogueCharacterBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueCharacterBuffById.HandleId, "db_rogue.db", "select BinData from `RogueCharacterBuff` where Id=?");
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x00174638 File Offset: 0x00172838
		public static RogueCharacterBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueCharacterBuffById.HandleId, ConfigRogueCharacterBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueCharacterBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueCharacterBuff?(RogueCharacterBuff.GetRootAsRogueCharacterBuff(configBuffer));
				}
			}
			ConfigRogueCharacterBuffById.LogPair.Clear();
			ConfigRogueCharacterBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueCharacterBuffById.HandleId, 1, p0Id, ConfigRogueCharacterBuffById.LogPair) || ConfigCommon.Step(ConfigRogueCharacterBuffById.HandleId, true, ConfigRogueCharacterBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueCharacterBuffById.HandleId, ConfigRogueCharacterBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueCharacterBuffById.HandleId, 0, ConfigRogueCharacterBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueCharacterBuffById.HandleId, ConfigRogueCharacterBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueCharacterBuff rootAsRogueCharacterBuff = RogueCharacterBuff.GetRootAsRogueCharacterBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueCharacterBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueCharacterBuffById.HandleId, ConfigRogueCharacterBuffById.LogPair);
			return new RogueCharacterBuff?(rootAsRogueCharacterBuff);
		}

		// Token: 0x04003983 RID: 14723
		private const string DB = "db_rogue.db";

		// Token: 0x04003984 RID: 14724
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003985 RID: 14725
		private const string TABLE = "RogueCharacterBuff";

		// Token: 0x04003986 RID: 14726
		private const string COMMAND = "select BinData from `RogueCharacterBuff` where Id=?";

		// Token: 0x04003987 RID: 14727
		private const string KEY_PREFIX = "RogueCharacterBuffById";

		// Token: 0x04003988 RID: 14728
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003989 RID: 14729
		private static int HandleId;
	}
}
