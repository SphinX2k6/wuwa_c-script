using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000973 RID: 2419
	public class ConfigShortMessageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038C5 RID: 14533 RVA: 0x0019D863 File Offset: 0x0019BA63
		static ConfigShortMessageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigShortMessageById.CreateStaticDefaultValue), new Action(ConfigShortMessageById.ResetStaticDefaultValue));
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x0019D884 File Offset: 0x0019BA84
		public static void CreateStaticDefaultValue()
		{
			ConfigShortMessageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigShortMessageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "ShortMessage"),
				new ValueTuple<string, object>("语句", "select BinData from `ShortMessage` where Id = ?")
			});
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x0019D903 File Offset: 0x0019BB03
		public static void ResetStaticDefaultValue()
		{
			ConfigShortMessageById.LogPair = null;
			ConfigShortMessageById.HandleId = 0;
		}

		// Token: 0x060038C8 RID: 14536 RVA: 0x0019D911 File Offset: 0x0019BB11
		public static void Init()
		{
			ConfigShortMessageById.HandleId = ConfigCommon.InitDataStatement(ConfigShortMessageById.HandleId, "db_phonemsg.db", "select BinData from `ShortMessage` where Id = ?");
		}

		// Token: 0x060038C9 RID: 14537 RVA: 0x0019D92C File Offset: 0x0019BB2C
		public static ShortMessage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigShortMessageById.HandleId, ConfigShortMessageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ShortMessageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ShortMessage?(ShortMessage.GetRootAsShortMessage(configBuffer));
				}
			}
			ConfigShortMessageById.LogPair.Clear();
			ConfigShortMessageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigShortMessageById.HandleId, 1, p0Id, ConfigShortMessageById.LogPair) || ConfigCommon.Step(ConfigShortMessageById.HandleId, true, ConfigShortMessageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigShortMessageById.HandleId, ConfigShortMessageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigShortMessageById.HandleId, 0, ConfigShortMessageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigShortMessageById.HandleId, ConfigShortMessageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ShortMessage rootAsShortMessage = ShortMessage.GetRootAsShortMessage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ShortMessageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigShortMessageById.HandleId, ConfigShortMessageById.LogPair);
			return new ShortMessage?(rootAsShortMessage);
		}

		// Token: 0x0400420B RID: 16907
		private const string DB = "db_phonemsg.db";

		// Token: 0x0400420C RID: 16908
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x0400420D RID: 16909
		private const string TABLE = "ShortMessage";

		// Token: 0x0400420E RID: 16910
		private const string COMMAND = "select BinData from `ShortMessage` where Id = ?";

		// Token: 0x0400420F RID: 16911
		private const string KEY_PREFIX = "ShortMessageById";

		// Token: 0x04004210 RID: 16912
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004211 RID: 16913
		private static int HandleId;
	}
}
