using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000466 RID: 1126
	public class ConfigJokerSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A6E RID: 6766 RVA: 0x000EECC4 File Offset: 0x000ECEC4
		static ConfigJokerSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigJokerSkillById.CreateStaticDefaultValue), new Action(ConfigJokerSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x000EECE4 File Offset: 0x000ECEE4
		public static void CreateStaticDefaultValue()
		{
			ConfigJokerSkillById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigJokerSkillById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guessjokercard.db"),
				new ValueTuple<string, object>("文件", "c.猜鬼牌玩法.xlsx"),
				new ValueTuple<string, object>("表名", "JokerSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `JokerSkill` where Id=?")
			});
		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x000EED63 File Offset: 0x000ECF63
		public static void ResetStaticDefaultValue()
		{
			ConfigJokerSkillById.LogPair = null;
			ConfigJokerSkillById.HandleId = 0;
		}

		// Token: 0x06001A71 RID: 6769 RVA: 0x000EED71 File Offset: 0x000ECF71
		public static void Init()
		{
			ConfigJokerSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigJokerSkillById.HandleId, "db_guessjokercard.db", "select BinData from `JokerSkill` where Id=?");
		}

		// Token: 0x06001A72 RID: 6770 RVA: 0x000EED8C File Offset: 0x000ECF8C
		public static JokerSkill? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigJokerSkillById.HandleId, ConfigJokerSkillById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("JokerSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new JokerSkill?(JokerSkill.GetRootAsJokerSkill(configBuffer));
				}
			}
			ConfigJokerSkillById.LogPair.Clear();
			ConfigJokerSkillById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigJokerSkillById.HandleId, 1, p0Id, ConfigJokerSkillById.LogPair) || ConfigCommon.Step(ConfigJokerSkillById.HandleId, true, ConfigJokerSkillById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigJokerSkillById.HandleId, ConfigJokerSkillById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigJokerSkillById.HandleId, 0, ConfigJokerSkillById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigJokerSkillById.HandleId, ConfigJokerSkillById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			JokerSkill rootAsJokerSkill = JokerSkill.GetRootAsJokerSkill(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("JokerSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigJokerSkillById.HandleId, ConfigJokerSkillById.LogPair);
			return new JokerSkill?(rootAsJokerSkill);
		}

		// Token: 0x04001EAE RID: 7854
		private const string DB = "db_guessjokercard.db";

		// Token: 0x04001EAF RID: 7855
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x04001EB0 RID: 7856
		private const string TABLE = "JokerSkill";

		// Token: 0x04001EB1 RID: 7857
		private const string COMMAND = "select BinData from `JokerSkill` where Id=?";

		// Token: 0x04001EB2 RID: 7858
		private const string KEY_PREFIX = "JokerSkillById";

		// Token: 0x04001EB3 RID: 7859
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EB4 RID: 7860
		private static int HandleId;
	}
}
