using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000752 RID: 1874
	public class ConfigPinballWeaponSubEntryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BFC RID: 11260 RVA: 0x0015599C File Offset: 0x00153B9C
		static ConfigPinballWeaponSubEntryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballWeaponSubEntryById.CreateStaticDefaultValue), new Action(ConfigPinballWeaponSubEntryById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x001559BC File Offset: 0x00153BBC
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

		// Token: 0x06002BFE RID: 11262 RVA: 0x00155A3B File Offset: 0x00153C3B
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballWeaponSubEntryById.LogPair = null;
			ConfigPinballWeaponSubEntryById.HandleId = 0;
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x00155A49 File Offset: 0x00153C49
		public static void Init()
		{
			ConfigPinballWeaponSubEntryById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballWeaponSubEntryById.HandleId, "db_pinballbattle.db", "select BinData from `PinballWeaponSubEntry` where Id=?");
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x00155A64 File Offset: 0x00153C64
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

		// Token: 0x04003324 RID: 13092
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003325 RID: 13093
		private const string FILE = "x.星弹奇游_武器.xlsx";

		// Token: 0x04003326 RID: 13094
		private const string TABLE = "PinballWeaponSubEntry";

		// Token: 0x04003327 RID: 13095
		private const string COMMAND = "select BinData from `PinballWeaponSubEntry` where Id=?";

		// Token: 0x04003328 RID: 13096
		private const string KEY_PREFIX = "PinballWeaponSubEntryById";

		// Token: 0x04003329 RID: 13097
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400332A RID: 13098
		private static int HandleId;
	}
}
