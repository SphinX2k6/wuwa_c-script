using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000820 RID: 2080
	public class ConfigRogueCharacterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030D2 RID: 12498 RVA: 0x0016D4D0 File Offset: 0x0016B6D0
		static ConfigRogueCharacterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueCharacterById.CreateStaticDefaultValue), new Action(ConfigRogueCharacterById.ResetStaticDefaultValue));
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x0016D4F0 File Offset: 0x0016B6F0
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueCharacterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueCharacterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueCharacter"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueCharacter` where Id=?")
			});
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x0016D56F File Offset: 0x0016B76F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueCharacterById.LogPair = null;
			ConfigRogueCharacterById.HandleId = 0;
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x0016D57D File Offset: 0x0016B77D
		public static void Init()
		{
			ConfigRogueCharacterById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueCharacterById.HandleId, "db_rogue.db", "select BinData from `RogueCharacter` where Id=?");
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x0016D598 File Offset: 0x0016B798
		public static RogueCharacter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueCharacterById.HandleId, ConfigRogueCharacterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueCharacterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueCharacter?(RogueCharacter.GetRootAsRogueCharacter(configBuffer));
				}
			}
			ConfigRogueCharacterById.LogPair.Clear();
			ConfigRogueCharacterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueCharacterById.HandleId, 1, p0Id, ConfigRogueCharacterById.LogPair) || ConfigCommon.Step(ConfigRogueCharacterById.HandleId, true, ConfigRogueCharacterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueCharacterById.HandleId, ConfigRogueCharacterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueCharacterById.HandleId, 0, ConfigRogueCharacterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueCharacterById.HandleId, ConfigRogueCharacterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueCharacter rootAsRogueCharacter = RogueCharacter.GetRootAsRogueCharacter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueCharacterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueCharacterById.HandleId, ConfigRogueCharacterById.LogPair);
			return new RogueCharacter?(rootAsRogueCharacter);
		}

		// Token: 0x040038C6 RID: 14534
		private const string DB = "db_rogue.db";

		// Token: 0x040038C7 RID: 14535
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x040038C8 RID: 14536
		private const string TABLE = "RogueCharacter";

		// Token: 0x040038C9 RID: 14537
		private const string COMMAND = "select BinData from `RogueCharacter` where Id=?";

		// Token: 0x040038CA RID: 14538
		private const string KEY_PREFIX = "RogueCharacterById";

		// Token: 0x040038CB RID: 14539
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038CC RID: 14540
		private static int HandleId;
	}
}
