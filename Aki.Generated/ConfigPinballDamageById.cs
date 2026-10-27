using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000717 RID: 1815
	public class ConfigPinballDamageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A9A RID: 10906 RVA: 0x0014A203 File Offset: 0x00148403
		static ConfigPinballDamageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballDamageById.CreateStaticDefaultValue), new Action(ConfigPinballDamageById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x0014A224 File Offset: 0x00148424
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

		// Token: 0x06002A9C RID: 10908 RVA: 0x0014A2A3 File Offset: 0x001484A3
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballDamageById.LogPair = null;
			ConfigPinballDamageById.HandleId = 0;
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x0014A2B1 File Offset: 0x001484B1
		public static void Init()
		{
			ConfigPinballDamageById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballDamageById.HandleId, "db_pinballbattle.db", "select BinData from `PinballDamage` where Id=?");
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x0014A2CC File Offset: 0x001484CC
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

		// Token: 0x04003187 RID: 12679
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003188 RID: 12680
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x04003189 RID: 12681
		private const string TABLE = "PinballDamage";

		// Token: 0x0400318A RID: 12682
		private const string COMMAND = "select BinData from `PinballDamage` where Id=?";

		// Token: 0x0400318B RID: 12683
		private const string KEY_PREFIX = "PinballDamageById";

		// Token: 0x0400318C RID: 12684
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400318D RID: 12685
		private static int HandleId;
	}
}
