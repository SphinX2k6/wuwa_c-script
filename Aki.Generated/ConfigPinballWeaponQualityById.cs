using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000751 RID: 1873
	public class ConfigPinballWeaponQualityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BF6 RID: 11254 RVA: 0x00155754 File Offset: 0x00153954
		static ConfigPinballWeaponQualityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWeaponQualityById.CreateStaticDefaultValue), new Action(ConfigPinballWeaponQualityById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x00155774 File Offset: 0x00153974
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

		// Token: 0x06002BF8 RID: 11256 RVA: 0x001557F3 File Offset: 0x001539F3
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWeaponQualityById.LogPair = null;
			ConfigPinballWeaponQualityById.HandleId = 0;
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x00155801 File Offset: 0x00153A01
		public static void Init()
		{
			ConfigPinballWeaponQualityById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWeaponQualityById.HandleId, "db_pinballbattle.db", "select BinData from `PinballWeaponQuality` where Id=?");
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x0015581C File Offset: 0x00153A1C
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

		// Token: 0x0400331D RID: 13085
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400331E RID: 13086
		private const string FILE = "x.星弹奇游_武器.xlsx";

		// Token: 0x0400331F RID: 13087
		private const string TABLE = "PinballWeaponQuality";

		// Token: 0x04003320 RID: 13088
		private const string COMMAND = "select BinData from `PinballWeaponQuality` where Id=?";

		// Token: 0x04003321 RID: 13089
		private const string KEY_PREFIX = "PinballWeaponQualityById";

		// Token: 0x04003322 RID: 13090
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003323 RID: 13091
		private static int HandleId;
	}
}
