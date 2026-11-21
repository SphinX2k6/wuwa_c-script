using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200073E RID: 1854
	public class ConfigPinballPropertyIndexById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B84 RID: 11140 RVA: 0x00152DF4 File Offset: 0x00150FF4
		static ConfigPinballPropertyIndexById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballPropertyIndexById.CreateStaticDefaultValue), new Action(ConfigPinballPropertyIndexById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x00152E14 File Offset: 0x00151014
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

		// Token: 0x06002B86 RID: 11142 RVA: 0x00152E93 File Offset: 0x00151093
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballPropertyIndexById.LogPair = null;
			ConfigPinballPropertyIndexById.HandleId = 0;
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x00152EA1 File Offset: 0x001510A1
		public static void Init()
		{
			ConfigPinballPropertyIndexById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballPropertyIndexById.HandleId, "db_pinballbattle.db", "select BinData from `PinballPropertyIndex` where Id = ?");
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x00152EBC File Offset: 0x001510BC
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

		// Token: 0x04003298 RID: 12952
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003299 RID: 12953
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x0400329A RID: 12954
		private const string TABLE = "PinballPropertyIndex";

		// Token: 0x0400329B RID: 12955
		private const string COMMAND = "select BinData from `PinballPropertyIndex` where Id = ?";

		// Token: 0x0400329C RID: 12956
		private const string KEY_PREFIX = "PinballPropertyIndexById";

		// Token: 0x0400329D RID: 12957
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400329E RID: 12958
		private static int HandleId;
	}
}
