using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200047C RID: 1148
	public class ConfigJokerSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AF2 RID: 6898 RVA: 0x000F5418 File Offset: 0x000F3618
		static ConfigJokerSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigJokerSkillById.CreateStaticDefaultValue), new Action(ConfigJokerSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x000F5438 File Offset: 0x000F3638
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

		// Token: 0x06001AF4 RID: 6900 RVA: 0x000F54B7 File Offset: 0x000F36B7
		public static void ResetStaticDefaultValue()
		{
			ConfigJokerSkillById.LogPair = null;
			ConfigJokerSkillById.HandleId = 0;
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x000F54C5 File Offset: 0x000F36C5
		public static void Init()
		{
			ConfigJokerSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigJokerSkillById.HandleId, "db_guessjokercard.db", "select BinData from `JokerSkill` where Id=?");
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x000F54E0 File Offset: 0x000F36E0
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

		// Token: 0x04001F48 RID: 8008
		private const string DB = "db_guessjokercard.db";

		// Token: 0x04001F49 RID: 8009
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x04001F4A RID: 8010
		private const string TABLE = "JokerSkill";

		// Token: 0x04001F4B RID: 8011
		private const string COMMAND = "select BinData from `JokerSkill` where Id=?";

		// Token: 0x04001F4C RID: 8012
		private const string KEY_PREFIX = "JokerSkillById";

		// Token: 0x04001F4D RID: 8013
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F4E RID: 8014
		private static int HandleId;
	}
}
