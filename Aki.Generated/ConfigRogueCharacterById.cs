using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200083C RID: 2108
	public class ConfigRogueCharacterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600317A RID: 12666 RVA: 0x001747B8 File Offset: 0x001729B8
		static ConfigRogueCharacterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueCharacterById.CreateStaticDefaultValue), new Action(ConfigRogueCharacterById.ResetStaticDefaultValue));
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x001747D8 File Offset: 0x001729D8
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

		// Token: 0x0600317C RID: 12668 RVA: 0x00174857 File Offset: 0x00172A57
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueCharacterById.LogPair = null;
			ConfigRogueCharacterById.HandleId = 0;
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x00174865 File Offset: 0x00172A65
		public static void Init()
		{
			ConfigRogueCharacterById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueCharacterById.HandleId, "db_rogue.db", "select BinData from `RogueCharacter` where Id=?");
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x00174880 File Offset: 0x00172A80
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

		// Token: 0x0400398A RID: 14730
		private const string DB = "db_rogue.db";

		// Token: 0x0400398B RID: 14731
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x0400398C RID: 14732
		private const string TABLE = "RogueCharacter";

		// Token: 0x0400398D RID: 14733
		private const string COMMAND = "select BinData from `RogueCharacter` where Id=?";

		// Token: 0x0400398E RID: 14734
		private const string KEY_PREFIX = "RogueCharacterById";

		// Token: 0x0400398F RID: 14735
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003990 RID: 14736
		private static int HandleId;
	}
}
