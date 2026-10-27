using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006BE RID: 1726
	public class ConfigPhoneInputTimeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002884 RID: 10372 RVA: 0x0013E9EB File Offset: 0x0013CBEB
		static ConfigPhoneInputTimeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhoneInputTimeById.CreateStaticDefaultValue), new Action(ConfigPhoneInputTimeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x0013EA0C File Offset: 0x0013CC0C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhoneInputTimeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhoneInputTimeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "PhoneInputTime"),
				new ValueTuple<string, object>("语句", "select BinData from `PhoneInputTime` where Id=?")
			});
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x0013EA8B File Offset: 0x0013CC8B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhoneInputTimeById.LogPair = null;
			ConfigPhoneInputTimeById.HandleId = 0;
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x0013EA99 File Offset: 0x0013CC99
		public static void Init()
		{
			ConfigPhoneInputTimeById.HandleId = ConfigCommon.InitDataStatement(ConfigPhoneInputTimeById.HandleId, "db_phonemsg.db", "select BinData from `PhoneInputTime` where Id=?");
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x0013EAB4 File Offset: 0x0013CCB4
		public static PhoneInputTime? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhoneInputTimeById.HandleId, ConfigPhoneInputTimeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhoneInputTimeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhoneInputTime?(PhoneInputTime.GetRootAsPhoneInputTime(configBuffer));
				}
			}
			ConfigPhoneInputTimeById.LogPair.Clear();
			ConfigPhoneInputTimeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhoneInputTimeById.HandleId, 1, p0Id, ConfigPhoneInputTimeById.LogPair) || ConfigCommon.Step(ConfigPhoneInputTimeById.HandleId, true, ConfigPhoneInputTimeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhoneInputTimeById.HandleId, ConfigPhoneInputTimeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhoneInputTimeById.HandleId, 0, ConfigPhoneInputTimeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhoneInputTimeById.HandleId, ConfigPhoneInputTimeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhoneInputTime rootAsPhoneInputTime = PhoneInputTime.GetRootAsPhoneInputTime(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhoneInputTimeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhoneInputTimeById.HandleId, ConfigPhoneInputTimeById.LogPair);
			return new PhoneInputTime?(rootAsPhoneInputTime);
		}

		// Token: 0x04002F18 RID: 12056
		private const string DB = "db_phonemsg.db";

		// Token: 0x04002F19 RID: 12057
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04002F1A RID: 12058
		private const string TABLE = "PhoneInputTime";

		// Token: 0x04002F1B RID: 12059
		private const string COMMAND = "select BinData from `PhoneInputTime` where Id=?";

		// Token: 0x04002F1C RID: 12060
		private const string KEY_PREFIX = "PhoneInputTimeById";

		// Token: 0x04002F1D RID: 12061
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F1E RID: 12062
		private static int HandleId;
	}
}
