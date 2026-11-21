using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000272 RID: 626
	public class ConfigElementalReactionByReactionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000EB0 RID: 3760 RVA: 0x000AFFE7 File Offset: 0x000AE1E7
		static ConfigElementalReactionByReactionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigElementalReactionByReactionId.CreateStaticDefaultValue), new Action(ConfigElementalReactionByReactionId.ResetStaticDefaultValue));
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x000B0008 File Offset: 0x000AE208
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

		// Token: 0x06000EB2 RID: 3762 RVA: 0x000B0087 File Offset: 0x000AE287
		public static void ResetStaticDefaultValue()
		{
			ConfigElementalReactionByReactionId.LogPair = null;
			ConfigElementalReactionByReactionId.HandleId = 0;
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x000B0095 File Offset: 0x000AE295
		public static void Init()
		{
			ConfigElementalReactionByReactionId.HandleId = ConfigCommon.InitDataStatement(ConfigElementalReactionByReactionId.HandleId, "db_element_info.db", "select BinData from `ElementalReaction` where ReactionId=?");
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x000B00B0 File Offset: 0x000AE2B0
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

		// Token: 0x04001102 RID: 4354
		private const string DB = "db_element_info.db";

		// Token: 0x04001103 RID: 4355
		private const string FILE = "y.元素属性.xlsx";

		// Token: 0x04001104 RID: 4356
		private const string TABLE = "ElementalReaction";

		// Token: 0x04001105 RID: 4357
		private const string COMMAND = "select BinData from `ElementalReaction` where ReactionId=?";

		// Token: 0x04001106 RID: 4358
		private const string KEY_PREFIX = "ElementalReactionByReactionId";

		// Token: 0x04001107 RID: 4359
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001108 RID: 4360
		private static int HandleId;
	}
}
