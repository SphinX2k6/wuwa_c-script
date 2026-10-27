using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200071A RID: 1818
	public class ConfigPinballEntityTestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AAC RID: 10924 RVA: 0x0014A8DC File Offset: 0x00148ADC
		static ConfigPinballEntityTestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballEntityTestById.CreateStaticDefaultValue), new Action(ConfigPinballEntityTestById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x0014A8FC File Offset: 0x00148AFC
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballEntityTestById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballEntityTestById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "PinballEntityTest"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballEntityTest` where Id=?")
			});
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x0014A97B File Offset: 0x00148B7B
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballEntityTestById.LogPair = null;
			ConfigPinballEntityTestById.HandleId = 0;
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x0014A989 File Offset: 0x00148B89
		public static void Init()
		{
			ConfigPinballEntityTestById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballEntityTestById.HandleId, "db_pinballbattle.db", "select BinData from `PinballEntityTest` where Id=?");
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x0014A9A4 File Offset: 0x00148BA4
		public static PinballEntityTest? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballEntityTestById.HandleId, ConfigPinballEntityTestById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballEntityTestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballEntityTest?(PinballEntityTest.GetRootAsPinballEntityTest(configBuffer));
				}
			}
			ConfigPinballEntityTestById.LogPair.Clear();
			ConfigPinballEntityTestById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballEntityTestById.HandleId, 1, p0Id, ConfigPinballEntityTestById.LogPair) || ConfigCommon.Step(ConfigPinballEntityTestById.HandleId, true, ConfigPinballEntityTestById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballEntityTestById.HandleId, ConfigPinballEntityTestById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballEntityTestById.HandleId, 0, ConfigPinballEntityTestById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballEntityTestById.HandleId, ConfigPinballEntityTestById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballEntityTest rootAsPinballEntityTest = PinballEntityTest.GetRootAsPinballEntityTest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballEntityTestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballEntityTestById.HandleId, ConfigPinballEntityTestById.LogPair);
			return new PinballEntityTest?(rootAsPinballEntityTest);
		}

		// Token: 0x0400319C RID: 12700
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400319D RID: 12701
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x0400319E RID: 12702
		private const string TABLE = "PinballEntityTest";

		// Token: 0x0400319F RID: 12703
		private const string COMMAND = "select BinData from `PinballEntityTest` where Id=?";

		// Token: 0x040031A0 RID: 12704
		private const string KEY_PREFIX = "PinballEntityTestById";

		// Token: 0x040031A1 RID: 12705
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031A2 RID: 12706
		private static int HandleId;
	}
}
