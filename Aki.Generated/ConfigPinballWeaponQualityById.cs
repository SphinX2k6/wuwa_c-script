using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000739 RID: 1849
	public class ConfigPinballWeaponQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B66 RID: 11110 RVA: 0x0014ECD8 File Offset: 0x0014CED8
		static ConfigPinballWeaponQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWeaponQualityById.CreateStaticDefaultValue), new Action(ConfigPinballWeaponQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x0014ECF8 File Offset: 0x0014CEF8
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballWeaponQualityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballWeaponQualityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_武器.xlsx"),
				new ValueTuple<string, object>("表名", "PinballWeaponQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballWeaponQuality` where Id=?")
			});
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x0014ED77 File Offset: 0x0014CF77
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWeaponQualityById.LogPair = null;
			ConfigPinballWeaponQualityById.HandleId = 0;
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x0014ED85 File Offset: 0x0014CF85
		public static void Init()
		{
			ConfigPinballWeaponQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWeaponQualityById.HandleId, "db_pinballbattle.db", "select BinData from `PinballWeaponQuality` where Id=?");
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x0014EDA0 File Offset: 0x0014CFA0
		public static PinballWeaponQuality? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballWeaponQualityById.HandleId, ConfigPinballWeaponQualityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWeaponQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballWeaponQuality?(PinballWeaponQuality.GetRootAsPinballWeaponQuality(configBuffer));
				}
			}
			ConfigPinballWeaponQualityById.LogPair.Clear();
			ConfigPinballWeaponQualityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballWeaponQualityById.HandleId, 1, p0Id, ConfigPinballWeaponQualityById.LogPair) || ConfigCommon.Step(ConfigPinballWeaponQualityById.HandleId, true, ConfigPinballWeaponQualityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballWeaponQualityById.HandleId, ConfigPinballWeaponQualityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballWeaponQualityById.HandleId, 0, ConfigPinballWeaponQualityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballWeaponQualityById.HandleId, ConfigPinballWeaponQualityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballWeaponQuality rootAsPinballWeaponQuality = PinballWeaponQuality.GetRootAsPinballWeaponQuality(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWeaponQualityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballWeaponQualityById.HandleId, ConfigPinballWeaponQualityById.LogPair);
			return new PinballWeaponQuality?(rootAsPinballWeaponQuality);
		}

		// Token: 0x04003275 RID: 12917
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003276 RID: 12918
		private const string FILE = "x.星弹奇游_武器.xlsx";

		// Token: 0x04003277 RID: 12919
		private const string TABLE = "PinballWeaponQuality";

		// Token: 0x04003278 RID: 12920
		private const string COMMAND = "select BinData from `PinballWeaponQuality` where Id=?";

		// Token: 0x04003279 RID: 12921
		private const string KEY_PREFIX = "PinballWeaponQualityById";

		// Token: 0x0400327A RID: 12922
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400327B RID: 12923
		private static int HandleId;
	}
}
