using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000738 RID: 1848
	public class ConfigPinballWeaponMainEntryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B60 RID: 11104 RVA: 0x0014EA90 File Offset: 0x0014CC90
		static ConfigPinballWeaponMainEntryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWeaponMainEntryById.CreateStaticDefaultValue), new Action(ConfigPinballWeaponMainEntryById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x0014EAB0 File Offset: 0x0014CCB0
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballWeaponMainEntryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballWeaponMainEntryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_武器.xlsx"),
				new ValueTuple<string, object>("表名", "PinballWeaponMainEntry"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballWeaponMainEntry` where Id=?")
			});
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x0014EB2F File Offset: 0x0014CD2F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWeaponMainEntryById.LogPair = null;
			ConfigPinballWeaponMainEntryById.HandleId = 0;
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x0014EB3D File Offset: 0x0014CD3D
		public static void Init()
		{
			ConfigPinballWeaponMainEntryById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWeaponMainEntryById.HandleId, "db_pinballbattle.db", "select BinData from `PinballWeaponMainEntry` where Id=?");
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x0014EB58 File Offset: 0x0014CD58
		public static PinballWeaponMainEntry? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballWeaponMainEntryById.HandleId, ConfigPinballWeaponMainEntryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWeaponMainEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballWeaponMainEntry?(PinballWeaponMainEntry.GetRootAsPinballWeaponMainEntry(configBuffer));
				}
			}
			ConfigPinballWeaponMainEntryById.LogPair.Clear();
			ConfigPinballWeaponMainEntryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballWeaponMainEntryById.HandleId, 1, p0Id, ConfigPinballWeaponMainEntryById.LogPair) || ConfigCommon.Step(ConfigPinballWeaponMainEntryById.HandleId, true, ConfigPinballWeaponMainEntryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballWeaponMainEntryById.HandleId, ConfigPinballWeaponMainEntryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballWeaponMainEntryById.HandleId, 0, ConfigPinballWeaponMainEntryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballWeaponMainEntryById.HandleId, ConfigPinballWeaponMainEntryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballWeaponMainEntry rootAsPinballWeaponMainEntry = PinballWeaponMainEntry.GetRootAsPinballWeaponMainEntry(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballWeaponMainEntryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballWeaponMainEntryById.HandleId, ConfigPinballWeaponMainEntryById.LogPair);
			return new PinballWeaponMainEntry?(rootAsPinballWeaponMainEntry);
		}

		// Token: 0x0400326E RID: 12910
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400326F RID: 12911
		private const string FILE = "x.星弹奇游_武器.xlsx";

		// Token: 0x04003270 RID: 12912
		private const string TABLE = "PinballWeaponMainEntry";

		// Token: 0x04003271 RID: 12913
		private const string COMMAND = "select BinData from `PinballWeaponMainEntry` where Id=?";

		// Token: 0x04003272 RID: 12914
		private const string KEY_PREFIX = "PinballWeaponMainEntryById";

		// Token: 0x04003273 RID: 12915
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003274 RID: 12916
		private static int HandleId;
	}
}
