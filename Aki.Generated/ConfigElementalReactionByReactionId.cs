using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200025E RID: 606
	public class ConfigElementalReactionByReactionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E38 RID: 3640 RVA: 0x000A9D23 File Offset: 0x000A7F23
		static ConfigElementalReactionByReactionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementalReactionByReactionId.CreateStaticDefaultValue), new Action(ConfigElementalReactionByReactionId.ResetStaticDefaultValue));
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x000A9D44 File Offset: 0x000A7F44
		public static void CreateStaticDefaultValue()
		{
			ConfigElementalReactionByReactionId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigElementalReactionByReactionId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_element_info.db"),
				new ValueTuple<string, object>("文件", "y.元素属性.xlsx"),
				new ValueTuple<string, object>("表名", "ElementalReaction"),
				new ValueTuple<string, object>("语句", "select BinData from `ElementalReaction` where ReactionId=?")
			});
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x000A9DC3 File Offset: 0x000A7FC3
		public static void ResetStaticDefaultValue()
		{
			ConfigElementalReactionByReactionId.LogPair = null;
			ConfigElementalReactionByReactionId.HandleId = 0;
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x000A9DD1 File Offset: 0x000A7FD1
		public static void Init()
		{
			ConfigElementalReactionByReactionId.HandleId = ConfigCommon.InitDataStatement(ConfigElementalReactionByReactionId.HandleId, "db_element_info.db", "select BinData from `ElementalReaction` where ReactionId=?");
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x000A9DEC File Offset: 0x000A7FEC
		public static ElementalReaction? GetConfig(int p0ReactionId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigElementalReactionByReactionId.HandleId, ConfigElementalReactionByReactionId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ElementalReactionByReactionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ReactionId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ElementalReaction?(ElementalReaction.GetRootAsElementalReaction(configBuffer));
				}
			}
			ConfigElementalReactionByReactionId.LogPair.Clear();
			ConfigElementalReactionByReactionId.LogPair.Add(new ValueTuple<string, object>("ReactionId", p0ReactionId));
			if (!ConfigCommon.BindInt(ConfigElementalReactionByReactionId.HandleId, 1, p0ReactionId, ConfigElementalReactionByReactionId.LogPair) || ConfigCommon.Step(ConfigElementalReactionByReactionId.HandleId, true, ConfigElementalReactionByReactionId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigElementalReactionByReactionId.HandleId, ConfigElementalReactionByReactionId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigElementalReactionByReactionId.HandleId, 0, ConfigElementalReactionByReactionId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigElementalReactionByReactionId.HandleId, ConfigElementalReactionByReactionId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ElementalReaction rootAsElementalReaction = ElementalReaction.GetRootAsElementalReaction(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ElementalReactionByReactionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ReactionId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigElementalReactionByReactionId.HandleId, ConfigElementalReactionByReactionId.LogPair);
			return new ElementalReaction?(rootAsElementalReaction);
		}

		// Token: 0x04001076 RID: 4214
		private const string DB = "db_element_info.db";

		// Token: 0x04001077 RID: 4215
		private const string FILE = "y.元素属性.xlsx";

		// Token: 0x04001078 RID: 4216
		private const string TABLE = "ElementalReaction";

		// Token: 0x04001079 RID: 4217
		private const string COMMAND = "select BinData from `ElementalReaction` where ReactionId=?";

		// Token: 0x0400107A RID: 4218
		private const string KEY_PREFIX = "ElementalReactionByReactionId";

		// Token: 0x0400107B RID: 4219
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400107C RID: 4220
		private static int HandleId;
	}
}
