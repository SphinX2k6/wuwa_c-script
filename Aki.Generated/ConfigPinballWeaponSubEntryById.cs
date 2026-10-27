using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200073A RID: 1850
	public class ConfigPinballWeaponSubEntryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B6C RID: 11116 RVA: 0x0014EF20 File Offset: 0x0014D120
		static ConfigPinballWeaponSubEntryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWeaponSubEntryById.CreateStaticDefaultValue), new Action(ConfigPinballWeaponSubEntryById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x0014EF40 File Offset: 0x0014D140
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballWeaponSubEntryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballWeaponSubEntryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_武器.xlsx"),
				new ValueTuple<string, object>("表名", "PinballWeaponSubEntry"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballWeaponSubEntry` where Id=?")
			});
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x0014EFBF File Offset: 0x0014D1BF
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWeaponSubEntryById.LogPair = null;
			ConfigPinballWeaponSubEntryById.HandleId = 0;
		}

		// Token: 0x06002B6F RID: 11119 RVA: 0x0014EFCD File Offset: 0x0014D1CD
		public static void Init()
		{
			ConfigPinballWeaponSubEntryById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWeaponSubEntryById.HandleId, "db_pinballbattle.db", "select BinData from `PinballWeaponSubEntry` where Id=?");
		}

		// Token: 0x06002B70 RID: 11120 RVA: 0x0014EFE8 File Offset: 0x0014D1E8
		public static PinballWeaponSubEntry? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballWeaponSubEntryById.HandleId, ConfigPinballWeaponSubEntryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWeaponSubEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballWeaponSubEntry?(PinballWeaponSubEntry.GetRootAsPinballWeaponSubEntry(configBuffer));
				}
			}
			ConfigPinballWeaponSubEntryById.LogPair.Clear();
			ConfigPinballWeaponSubEntryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballWeaponSubEntryById.HandleId, 1, p0Id, ConfigPinballWeaponSubEntryById.LogPair) || ConfigCommon.Step(ConfigPinballWeaponSubEntryById.HandleId, true, ConfigPinballWeaponSubEntryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballWeaponSubEntryById.HandleId, ConfigPinballWeaponSubEntryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballWeaponSubEntryById.HandleId, 0, ConfigPinballWeaponSubEntryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballWeaponSubEntryById.HandleId, ConfigPinballWeaponSubEntryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballWeaponSubEntry rootAsPinballWeaponSubEntry = PinballWeaponSubEntry.GetRootAsPinballWeaponSubEntry(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWeaponSubEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballWeaponSubEntryById.HandleId, ConfigPinballWeaponSubEntryById.LogPair);
			return new PinballWeaponSubEntry?(rootAsPinballWeaponSubEntry);
		}

		// Token: 0x0400327C RID: 12924
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400327D RID: 12925
		private const string FILE = "x.星弹奇游_武器.xlsx";

		// Token: 0x0400327E RID: 12926
		private const string TABLE = "PinballWeaponSubEntry";

		// Token: 0x0400327F RID: 12927
		private const string COMMAND = "select BinData from `PinballWeaponSubEntry` where Id=?";

		// Token: 0x04003280 RID: 12928
		private const string KEY_PREFIX = "PinballWeaponSubEntryById";

		// Token: 0x04003281 RID: 12929
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003282 RID: 12930
		private static int HandleId;
	}
}
