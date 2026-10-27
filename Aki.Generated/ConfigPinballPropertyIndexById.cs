using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000726 RID: 1830
	public class ConfigPinballPropertyIndexById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AF4 RID: 10996 RVA: 0x0014C378 File Offset: 0x0014A578
		static ConfigPinballPropertyIndexById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballPropertyIndexById.CreateStaticDefaultValue), new Action(ConfigPinballPropertyIndexById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x0014C398 File Offset: 0x0014A598
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballPropertyIndexById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballPropertyIndexById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_局内.xlsx"),
				new ValueTuple<string, object>("表名", "PinballPropertyIndex"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballPropertyIndex` where Id = ?")
			});
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x0014C417 File Offset: 0x0014A617
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballPropertyIndexById.LogPair = null;
			ConfigPinballPropertyIndexById.HandleId = 0;
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x0014C425 File Offset: 0x0014A625
		public static void Init()
		{
			ConfigPinballPropertyIndexById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballPropertyIndexById.HandleId, "db_pinballbattle.db", "select BinData from `PinballPropertyIndex` where Id = ?");
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x0014C440 File Offset: 0x0014A640
		public static PinballPropertyIndex? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballPropertyIndexById.HandleId, ConfigPinballPropertyIndexById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballPropertyIndexById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballPropertyIndex?(PinballPropertyIndex.GetRootAsPinballPropertyIndex(configBuffer));
				}
			}
			ConfigPinballPropertyIndexById.LogPair.Clear();
			ConfigPinballPropertyIndexById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballPropertyIndexById.HandleId, 1, p0Id, ConfigPinballPropertyIndexById.LogPair) || ConfigCommon.Step(ConfigPinballPropertyIndexById.HandleId, true, ConfigPinballPropertyIndexById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballPropertyIndexById.HandleId, ConfigPinballPropertyIndexById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballPropertyIndexById.HandleId, 0, ConfigPinballPropertyIndexById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballPropertyIndexById.HandleId, ConfigPinballPropertyIndexById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballPropertyIndex rootAsPinballPropertyIndex = PinballPropertyIndex.GetRootAsPinballPropertyIndex(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballPropertyIndexById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballPropertyIndexById.HandleId, ConfigPinballPropertyIndexById.LogPair);
			return new PinballPropertyIndex?(rootAsPinballPropertyIndex);
		}

		// Token: 0x040031F0 RID: 12784
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031F1 RID: 12785
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x040031F2 RID: 12786
		private const string TABLE = "PinballPropertyIndex";

		// Token: 0x040031F3 RID: 12787
		private const string COMMAND = "select BinData from `PinballPropertyIndex` where Id = ?";

		// Token: 0x040031F4 RID: 12788
		private const string KEY_PREFIX = "PinballPropertyIndexById";

		// Token: 0x040031F5 RID: 12789
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031F6 RID: 12790
		private static int HandleId;
	}
}
