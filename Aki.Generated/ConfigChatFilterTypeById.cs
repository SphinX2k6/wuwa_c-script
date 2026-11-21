using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000162 RID: 354
	public class ConfigChatFilterTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600084D RID: 2125 RVA: 0x0008C17F File Offset: 0x0008A37F
		static ConfigChatFilterTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatFilterTypeById.CreateStaticDefaultValue), new Action(ConfigChatFilterTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0008C1A0 File Offset: 0x0008A3A0
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

		// Token: 0x0600084F RID: 2127 RVA: 0x0008C21F File Offset: 0x0008A41F
		public static void ResetStaticDefaultValue()
		{
			ConfigChatFilterTypeById.LogPair = null;
			ConfigChatFilterTypeById.HandleId = 0;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0008C22D File Offset: 0x0008A42D
		public static void Init()
		{
			ConfigChatFilterTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigChatFilterTypeById.HandleId, "db_phonemsg.db", "select BinData from `ChatFilterType` where Id=?");
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0008C248 File Offset: 0x0008A448
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

		// Token: 0x04000992 RID: 2450
		private const string DB = "db_phonemsg.db";

		// Token: 0x04000993 RID: 2451
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04000994 RID: 2452
		private const string TABLE = "ChatFilterType";

		// Token: 0x04000995 RID: 2453
		private const string COMMAND = "select BinData from `ChatFilterType` where Id=?";

		// Token: 0x04000996 RID: 2454
		private const string KEY_PREFIX = "ChatFilterTypeById";

		// Token: 0x04000997 RID: 2455
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000998 RID: 2456
		private static int HandleId;
	}
}
