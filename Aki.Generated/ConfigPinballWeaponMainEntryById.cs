using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000750 RID: 1872
	public class ConfigPinballWeaponMainEntryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BF0 RID: 11248 RVA: 0x0015550C File Offset: 0x0015370C
		static ConfigPinballWeaponMainEntryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWeaponMainEntryById.CreateStaticDefaultValue), new Action(ConfigPinballWeaponMainEntryById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x0015552C File Offset: 0x0015372C
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

		// Token: 0x06002BF2 RID: 11250 RVA: 0x001555AB File Offset: 0x001537AB
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWeaponMainEntryById.LogPair = null;
			ConfigPinballWeaponMainEntryById.HandleId = 0;
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x001555B9 File Offset: 0x001537B9
		public static void Init()
		{
			ConfigPinballWeaponMainEntryById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWeaponMainEntryById.HandleId, "db_pinballbattle.db", "select BinData from `PinballWeaponMainEntry` where Id=?");
		}

		// Token: 0x06002BF4 RID: 11252 RVA: 0x001555D4 File Offset: 0x001537D4
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

		// Token: 0x04003316 RID: 13078
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003317 RID: 13079
		private const string FILE = "x.星弹奇游_武器.xlsx";

		// Token: 0x04003318 RID: 13080
		private const string TABLE = "PinballWeaponMainEntry";

		// Token: 0x04003319 RID: 13081
		private const string COMMAND = "select BinData from `PinballWeaponMainEntry` where Id=?";

		// Token: 0x0400331A RID: 13082
		private const string KEY_PREFIX = "PinballWeaponMainEntryById";

		// Token: 0x0400331B RID: 13083
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400331C RID: 13084
		private static int HandleId;
	}
}
