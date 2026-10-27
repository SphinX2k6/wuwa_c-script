using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000153 RID: 339
	public class ConfigChatFilterTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007F3 RID: 2035 RVA: 0x0008681B File Offset: 0x00084A1B
		static ConfigChatFilterTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatFilterTypeById.CreateStaticDefaultValue), new Action(ConfigChatFilterTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0008683C File Offset: 0x00084A3C
		public static void CreateStaticDefaultValue()
		{
			ConfigChatFilterTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatFilterTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChatFilterType"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatFilterType` where Id=?")
			});
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x000868BB File Offset: 0x00084ABB
		public static void ResetStaticDefaultValue()
		{
			ConfigChatFilterTypeById.LogPair = null;
			ConfigChatFilterTypeById.HandleId = 0;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x000868C9 File Offset: 0x00084AC9
		public static void Init()
		{
			ConfigChatFilterTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigChatFilterTypeById.HandleId, "db_phonemsg.db", "select BinData from `ChatFilterType` where Id=?");
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x000868E4 File Offset: 0x00084AE4
		public static ChatFilterType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatFilterTypeById.HandleId, ConfigChatFilterTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatFilterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ChatFilterType?(ChatFilterType.GetRootAsChatFilterType(configBuffer));
				}
			}
			ConfigChatFilterTypeById.LogPair.Clear();
			ConfigChatFilterTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigChatFilterTypeById.HandleId, 1, p0Id, ConfigChatFilterTypeById.LogPair) || ConfigCommon.Step(ConfigChatFilterTypeById.HandleId, true, ConfigChatFilterTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChatFilterTypeById.HandleId, ConfigChatFilterTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatFilterTypeById.HandleId, 0, ConfigChatFilterTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChatFilterTypeById.HandleId, ConfigChatFilterTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChatFilterType rootAsChatFilterType = ChatFilterType.GetRootAsChatFilterType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatFilterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChatFilterTypeById.HandleId, ConfigChatFilterTypeById.LogPair);
			return new ChatFilterType?(rootAsChatFilterType);
		}

		// Token: 0x04000929 RID: 2345
		private const string DB = "db_phonemsg.db";

		// Token: 0x0400092A RID: 2346
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x0400092B RID: 2347
		private const string TABLE = "ChatFilterType";

		// Token: 0x0400092C RID: 2348
		private const string COMMAND = "select BinData from `ChatFilterType` where Id=?";

		// Token: 0x0400092D RID: 2349
		private const string KEY_PREFIX = "ChatFilterTypeById";

		// Token: 0x0400092E RID: 2350
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400092F RID: 2351
		private static int HandleId;
	}
}
