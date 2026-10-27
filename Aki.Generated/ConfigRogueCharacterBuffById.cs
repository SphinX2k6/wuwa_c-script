using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200081F RID: 2079
	public class ConfigRogueCharacterBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030CC RID: 12492 RVA: 0x0016D288 File Offset: 0x0016B488
		static ConfigRogueCharacterBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueCharacterBuffById.CreateStaticDefaultValue), new Action(ConfigRogueCharacterBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x0016D2A8 File Offset: 0x0016B4A8
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

		// Token: 0x060030CE RID: 12494 RVA: 0x0016D327 File Offset: 0x0016B527
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueCharacterBuffById.LogPair = null;
			ConfigRogueCharacterBuffById.HandleId = 0;
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x0016D335 File Offset: 0x0016B535
		public static void Init()
		{
			ConfigRogueCharacterBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueCharacterBuffById.HandleId, "db_rogue.db", "select BinData from `RogueCharacterBuff` where Id=?");
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x0016D350 File Offset: 0x0016B550
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

		// Token: 0x040038BF RID: 14527
		private const string DB = "db_rogue.db";

		// Token: 0x040038C0 RID: 14528
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x040038C1 RID: 14529
		private const string TABLE = "RogueCharacterBuff";

		// Token: 0x040038C2 RID: 14530
		private const string COMMAND = "select BinData from `RogueCharacterBuff` where Id=?";

		// Token: 0x040038C3 RID: 14531
		private const string KEY_PREFIX = "RogueCharacterBuffById";

		// Token: 0x040038C4 RID: 14532
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038C5 RID: 14533
		private static int HandleId;
	}
}
