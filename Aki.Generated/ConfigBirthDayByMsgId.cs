using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000F0 RID: 240
	public class ConfigBirthDayByMsgId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060005A1 RID: 1441 RVA: 0x000797F8 File Offset: 0x000779F8
		static ConfigBirthDayByMsgId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBirthDayByMsgId.CreateStaticDefaultValue), new Action(ConfigBirthDayByMsgId.ResetStaticDefaultValue));
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00079818 File Offset: 0x00077A18
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

		// Token: 0x060005A3 RID: 1443 RVA: 0x00079897 File Offset: 0x00077A97
		public static void ResetStaticDefaultValue()
		{
			ConfigBirthDayByMsgId.LogPair = null;
			ConfigBirthDayByMsgId.HandleId = 0;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x000798A5 File Offset: 0x00077AA5
		public static void Init()
		{
			ConfigBirthDayByMsgId.HandleId = ConfigCommon.InitDataStatement(ConfigBirthDayByMsgId.HandleId, "db_birthday.db", "select BinData from `BirthDay` where SendShortMessage=?");
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000798C0 File Offset: 0x00077AC0
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

		// Token: 0x04000674 RID: 1652
		private const string DB = "db_birthday.db";

		// Token: 0x04000675 RID: 1653
		private const string FILE = "s.生日.xlsx";

		// Token: 0x04000676 RID: 1654
		private const string TABLE = "BirthDay";

		// Token: 0x04000677 RID: 1655
		private const string COMMAND = "select BinData from `BirthDay` where SendShortMessage=?";

		// Token: 0x04000678 RID: 1656
		private const string KEY_PREFIX = "BirthDayByMsgId";

		// Token: 0x04000679 RID: 1657
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400067A RID: 1658
		private static int HandleId;
	}
}
