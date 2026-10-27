using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200014C RID: 332
	public class ConfigChatDialogById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007C9 RID: 1993 RVA: 0x00085A4F File Offset: 0x00083C4F
		static ConfigChatDialogById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChatDialogById.CreateStaticDefaultValue), new Action(ConfigChatDialogById.ResetStaticDefaultValue));
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x00085A70 File Offset: 0x00083C70
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

		// Token: 0x060007CB RID: 1995 RVA: 0x00085AEF File Offset: 0x00083CEF
		public static void ResetStaticDefaultValue()
		{
			ConfigChatDialogById.LogPair = null;
			ConfigChatDialogById.HandleId = 0;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00085AFD File Offset: 0x00083CFD
		public static void Init()
		{
			ConfigChatDialogById.HandleId = ConfigCommon.InitDataStatement(ConfigChatDialogById.HandleId, "db_phonemsg.db", "select BinData from `ChatDialog` where Id=?");
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00085B18 File Offset: 0x00083D18
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

		// Token: 0x040008F8 RID: 2296
		private const string DB = "db_phonemsg.db";

		// Token: 0x040008F9 RID: 2297
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x040008FA RID: 2298
		private const string TABLE = "ChatDialog";

		// Token: 0x040008FB RID: 2299
		private const string COMMAND = "select BinData from `ChatDialog` where Id=?";

		// Token: 0x040008FC RID: 2300
		private const string KEY_PREFIX = "ChatDialogById";

		// Token: 0x040008FD RID: 2301
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008FE RID: 2302
		private static int HandleId;
	}
}
