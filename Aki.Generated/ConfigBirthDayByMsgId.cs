using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000FF RID: 255
	public class ConfigBirthDayByMsgId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005FB RID: 1531 RVA: 0x0007F15C File Offset: 0x0007D35C
		static ConfigBirthDayByMsgId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBirthDayByMsgId.CreateStaticDefaultValue), new Action(ConfigBirthDayByMsgId.ResetStaticDefaultValue));
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0007F17C File Offset: 0x0007D37C
		public static void CreateStaticDefaultValue()
		{
			ConfigBirthDayByMsgId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBirthDayByMsgId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_birthday.db"),
				new ValueTuple<string, object>("文件", "s.生日.xlsx"),
				new ValueTuple<string, object>("表名", "BirthDay"),
				new ValueTuple<string, object>("语句", "select BinData from `BirthDay` where SendShortMessage=?")
			});
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0007F1FB File Offset: 0x0007D3FB
		public static void ResetStaticDefaultValue()
		{
			ConfigBirthDayByMsgId.LogPair = null;
			ConfigBirthDayByMsgId.HandleId = 0;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0007F209 File Offset: 0x0007D409
		public static void Init()
		{
			ConfigBirthDayByMsgId.HandleId = ConfigCommon.InitDataStatement(ConfigBirthDayByMsgId.HandleId, "db_birthday.db", "select BinData from `BirthDay` where SendShortMessage=?");
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0007F224 File Offset: 0x0007D424
		public static BirthDay? GetConfig(int p0SendShortMessage, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBirthDayByMsgId.HandleId, ConfigBirthDayByMsgId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BirthDayByMsgId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SendShortMessage);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BirthDay?(BirthDay.GetRootAsBirthDay(configBuffer));
				}
			}
			ConfigBirthDayByMsgId.LogPair.Clear();
			ConfigBirthDayByMsgId.LogPair.Add(new ValueTuple<string, object>("SendShortMessage", p0SendShortMessage));
			if (!ConfigCommon.BindInt(ConfigBirthDayByMsgId.HandleId, 1, p0SendShortMessage, ConfigBirthDayByMsgId.LogPair) || ConfigCommon.Step(ConfigBirthDayByMsgId.HandleId, true, ConfigBirthDayByMsgId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBirthDayByMsgId.HandleId, ConfigBirthDayByMsgId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBirthDayByMsgId.HandleId, 0, ConfigBirthDayByMsgId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBirthDayByMsgId.HandleId, ConfigBirthDayByMsgId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BirthDay rootAsBirthDay = BirthDay.GetRootAsBirthDay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BirthDayByMsgId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SendShortMessage);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBirthDayByMsgId.HandleId, ConfigBirthDayByMsgId.LogPair);
			return new BirthDay?(rootAsBirthDay);
		}

		// Token: 0x040006DD RID: 1757
		private const string DB = "db_birthday.db";

		// Token: 0x040006DE RID: 1758
		private const string FILE = "s.生日.xlsx";

		// Token: 0x040006DF RID: 1759
		private const string TABLE = "BirthDay";

		// Token: 0x040006E0 RID: 1760
		private const string COMMAND = "select BinData from `BirthDay` where SendShortMessage=?";

		// Token: 0x040006E1 RID: 1761
		private const string KEY_PREFIX = "BirthDayByMsgId";

		// Token: 0x040006E2 RID: 1762
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040006E3 RID: 1763
		private static int HandleId;
	}
}
