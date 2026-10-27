using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000737 RID: 1847
	public class ConfigPinballWeaponConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B5A RID: 11098 RVA: 0x0014E848 File Offset: 0x0014CA48
		static ConfigPinballWeaponConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWeaponConfigById.CreateStaticDefaultValue), new Action(ConfigPinballWeaponConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x0014E868 File Offset: 0x0014CA68
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

		// Token: 0x06002B5C RID: 11100 RVA: 0x0014E8E7 File Offset: 0x0014CAE7
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWeaponConfigById.LogPair = null;
			ConfigPinballWeaponConfigById.HandleId = 0;
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x0014E8F5 File Offset: 0x0014CAF5
		public static void Init()
		{
			ConfigPinballWeaponConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWeaponConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballWeaponConfig` where Id=?");
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x0014E910 File Offset: 0x0014CB10
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

		// Token: 0x04003267 RID: 12903
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003268 RID: 12904
		private const string FILE = "x.星弹奇游_武器.xlsx";

		// Token: 0x04003269 RID: 12905
		private const string TABLE = "PinballWeaponConfig";

		// Token: 0x0400326A RID: 12906
		private const string COMMAND = "select BinData from `PinballWeaponConfig` where Id=?";

		// Token: 0x0400326B RID: 12907
		private const string KEY_PREFIX = "PinballWeaponConfigById";

		// Token: 0x0400326C RID: 12908
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400326D RID: 12909
		private static int HandleId;
	}
}
