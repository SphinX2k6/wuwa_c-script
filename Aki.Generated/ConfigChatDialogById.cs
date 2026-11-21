using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200015B RID: 347
	public class ConfigChatDialogById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000823 RID: 2083 RVA: 0x0008B3B3 File Offset: 0x000895B3
		static ConfigChatDialogById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatDialogById.CreateStaticDefaultValue), new Action(ConfigChatDialogById.ResetStaticDefaultValue));
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0008B3D4 File Offset: 0x000895D4
		public static void CreateStaticDefaultValue()
		{
			ConfigChatDialogById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChatDialogById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChatDialog"),
				new ValueTuple<string, object>("语句", "select BinData from `ChatDialog` where Id=?")
			});
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0008B453 File Offset: 0x00089653
		public static void ResetStaticDefaultValue()
		{
			ConfigChatDialogById.LogPair = null;
			ConfigChatDialogById.HandleId = 0;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0008B461 File Offset: 0x00089661
		public static void Init()
		{
			ConfigChatDialogById.HandleId = ConfigCommon.InitDataStatement(ConfigChatDialogById.HandleId, "db_phonemsg.db", "select BinData from `ChatDialog` where Id=?");
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0008B47C File Offset: 0x0008967C
		public static ChatDialog? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChatDialogById.HandleId, ConfigChatDialogById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatDialogById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ChatDialog?(ChatDialog.GetRootAsChatDialog(configBuffer));
				}
			}
			ConfigChatDialogById.LogPair.Clear();
			ConfigChatDialogById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigChatDialogById.HandleId, 1, p0Id, ConfigChatDialogById.LogPair) || ConfigCommon.Step(ConfigChatDialogById.HandleId, true, ConfigChatDialogById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChatDialogById.HandleId, ConfigChatDialogById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChatDialogById.HandleId, 0, ConfigChatDialogById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChatDialogById.HandleId, ConfigChatDialogById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChatDialog rootAsChatDialog = ChatDialog.GetRootAsChatDialog(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChatDialogById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChatDialogById.HandleId, ConfigChatDialogById.LogPair);
			return new ChatDialog?(rootAsChatDialog);
		}

		// Token: 0x04000961 RID: 2401
		private const string DB = "db_phonemsg.db";

		// Token: 0x04000962 RID: 2402
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04000963 RID: 2403
		private const string TABLE = "ChatDialog";

		// Token: 0x04000964 RID: 2404
		private const string COMMAND = "select BinData from `ChatDialog` where Id=?";

		// Token: 0x04000965 RID: 2405
		private const string KEY_PREFIX = "ChatDialogById";

		// Token: 0x04000966 RID: 2406
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000967 RID: 2407
		private static int HandleId;
	}
}
