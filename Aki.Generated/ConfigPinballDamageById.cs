using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200072F RID: 1839
	public class ConfigPinballDamageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B2A RID: 11050 RVA: 0x00150C7F File Offset: 0x0014EE7F
		static ConfigPinballDamageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballDamageById.CreateStaticDefaultValue), new Action(ConfigPinballDamageById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x00150CA0 File Offset: 0x0014EEA0
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballDamageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballDamageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_局内.xlsx"),
				new ValueTuple<string, object>("表名", "PinballDamage"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballDamage` where Id=?")
			});
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x00150D1F File Offset: 0x0014EF1F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballDamageById.LogPair = null;
			ConfigPinballDamageById.HandleId = 0;
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x00150D2D File Offset: 0x0014EF2D
		public static void Init()
		{
			ConfigPinballDamageById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballDamageById.HandleId, "db_pinballbattle.db", "select BinData from `PinballDamage` where Id=?");
		}

		// Token: 0x06002B2E RID: 11054 RVA: 0x00150D48 File Offset: 0x0014EF48
		public static PinballDamage? GetConfig(long p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballDamageById.HandleId, ConfigPinballDamageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballDamageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballDamage?(PinballDamage.GetRootAsPinballDamage(configBuffer));
				}
			}
			ConfigPinballDamageById.LogPair.Clear();
			ConfigPinballDamageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindFloat64(ConfigPinballDamageById.HandleId, 1, (double)p0Id, ConfigPinballDamageById.LogPair) || ConfigCommon.Step(ConfigPinballDamageById.HandleId, true, ConfigPinballDamageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballDamageById.HandleId, ConfigPinballDamageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballDamageById.HandleId, 0, ConfigPinballDamageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballDamageById.HandleId, ConfigPinballDamageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballDamage rootAsPinballDamage = PinballDamage.GetRootAsPinballDamage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballDamageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballDamageById.HandleId, ConfigPinballDamageById.LogPair);
			return new PinballDamage?(rootAsPinballDamage);
		}

		// Token: 0x0400322F RID: 12847
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003230 RID: 12848
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x04003231 RID: 12849
		private const string TABLE = "PinballDamage";

		// Token: 0x04003232 RID: 12850
		private const string COMMAND = "select BinData from `PinballDamage` where Id=?";

		// Token: 0x04003233 RID: 12851
		private const string KEY_PREFIX = "PinballDamageById";

		// Token: 0x04003234 RID: 12852
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003235 RID: 12853
		private static int HandleId;
	}
}
