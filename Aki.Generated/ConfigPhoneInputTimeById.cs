using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D6 RID: 1750
	public class ConfigPhoneInputTimeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002914 RID: 10516 RVA: 0x00145467 File Offset: 0x00143667
		static ConfigPhoneInputTimeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhoneInputTimeById.CreateStaticDefaultValue), new Action(ConfigPhoneInputTimeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x00145488 File Offset: 0x00143688
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

		// Token: 0x06002916 RID: 10518 RVA: 0x00145507 File Offset: 0x00143707
		public static void ResetStaticDefaultValue()
		{
			ConfigPhoneInputTimeById.LogPair = null;
			ConfigPhoneInputTimeById.HandleId = 0;
		}

		// Token: 0x06002917 RID: 10519 RVA: 0x00145515 File Offset: 0x00143715
		public static void Init()
		{
			ConfigPhoneInputTimeById.HandleId = ConfigCommon.InitDataStatement(ConfigPhoneInputTimeById.HandleId, "db_phonemsg.db", "select BinData from `PhoneInputTime` where Id=?");
		}

		// Token: 0x06002918 RID: 10520 RVA: 0x00145530 File Offset: 0x00143730
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

		// Token: 0x04002FC0 RID: 12224
		private const string DB = "db_phonemsg.db";

		// Token: 0x04002FC1 RID: 12225
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04002FC2 RID: 12226
		private const string TABLE = "PhoneInputTime";

		// Token: 0x04002FC3 RID: 12227
		private const string COMMAND = "select BinData from `PhoneInputTime` where Id=?";

		// Token: 0x04002FC4 RID: 12228
		private const string KEY_PREFIX = "PhoneInputTimeById";

		// Token: 0x04002FC5 RID: 12229
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FC6 RID: 12230
		private static int HandleId;
	}
}
