using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200074F RID: 1871
	public class ConfigPinballWeaponConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BEA RID: 11242 RVA: 0x001552C4 File Offset: 0x001534C4
		static ConfigPinballWeaponConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWeaponConfigById.CreateStaticDefaultValue), new Action(ConfigPinballWeaponConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x001552E4 File Offset: 0x001534E4
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballWeaponConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballWeaponConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_武器.xlsx"),
				new ValueTuple<string, object>("表名", "PinballWeaponConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballWeaponConfig` where Id=?")
			});
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x00155363 File Offset: 0x00153563
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWeaponConfigById.LogPair = null;
			ConfigPinballWeaponConfigById.HandleId = 0;
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x00155371 File Offset: 0x00153571
		public static void Init()
		{
			ConfigPinballWeaponConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWeaponConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballWeaponConfig` where Id=?");
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x0015538C File Offset: 0x0015358C
		public static PinballWeaponConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballWeaponConfigById.HandleId, ConfigPinballWeaponConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWeaponConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballWeaponConfig?(PinballWeaponConfig.GetRootAsPinballWeaponConfig(configBuffer));
				}
			}
			ConfigPinballWeaponConfigById.LogPair.Clear();
			ConfigPinballWeaponConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballWeaponConfigById.HandleId, 1, p0Id, ConfigPinballWeaponConfigById.LogPair) || ConfigCommon.Step(ConfigPinballWeaponConfigById.HandleId, true, ConfigPinballWeaponConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballWeaponConfigById.HandleId, ConfigPinballWeaponConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballWeaponConfigById.HandleId, 0, ConfigPinballWeaponConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballWeaponConfigById.HandleId, ConfigPinballWeaponConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballWeaponConfig rootAsPinballWeaponConfig = PinballWeaponConfig.GetRootAsPinballWeaponConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWeaponConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballWeaponConfigById.HandleId, ConfigPinballWeaponConfigById.LogPair);
			return new PinballWeaponConfig?(rootAsPinballWeaponConfig);
		}

		// Token: 0x0400330F RID: 13071
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003310 RID: 13072
		private const string FILE = "x.星弹奇游_武器.xlsx";

		// Token: 0x04003311 RID: 13073
		private const string TABLE = "PinballWeaponConfig";

		// Token: 0x04003312 RID: 13074
		private const string COMMAND = "select BinData from `PinballWeaponConfig` where Id=?";

		// Token: 0x04003313 RID: 13075
		private const string KEY_PREFIX = "PinballWeaponConfigById";

		// Token: 0x04003314 RID: 13076
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003315 RID: 13077
		private static int HandleId;
	}
}
