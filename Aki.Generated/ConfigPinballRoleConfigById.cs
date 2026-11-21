using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000744 RID: 1860
	public class ConfigPinballRoleConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BA8 RID: 11176 RVA: 0x00153A2B File Offset: 0x00151C2B
		static ConfigPinballRoleConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRoleConfigById.CreateStaticDefaultValue), new Action(ConfigPinballRoleConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x00153A4C File Offset: 0x00151C4C
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballRoleConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballRoleConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_角色.xlsx"),
				new ValueTuple<string, object>("表名", "PinballRoleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballRoleConfig` where Id=?")
			});
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x00153ACB File Offset: 0x00151CCB
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRoleConfigById.LogPair = null;
			ConfigPinballRoleConfigById.HandleId = 0;
		}

		// Token: 0x06002BAB RID: 11179 RVA: 0x00153AD9 File Offset: 0x00151CD9
		public static void Init()
		{
			ConfigPinballRoleConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRoleConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballRoleConfig` where Id=?");
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x00153AF4 File Offset: 0x00151CF4
		public static PinballRoleConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballRoleConfigById.HandleId, ConfigPinballRoleConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRoleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballRoleConfig?(PinballRoleConfig.GetRootAsPinballRoleConfig(configBuffer));
				}
			}
			ConfigPinballRoleConfigById.LogPair.Clear();
			ConfigPinballRoleConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballRoleConfigById.HandleId, 1, p0Id, ConfigPinballRoleConfigById.LogPair) || ConfigCommon.Step(ConfigPinballRoleConfigById.HandleId, true, ConfigPinballRoleConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballRoleConfigById.HandleId, ConfigPinballRoleConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballRoleConfigById.HandleId, 0, ConfigPinballRoleConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballRoleConfigById.HandleId, ConfigPinballRoleConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballRoleConfig rootAsPinballRoleConfig = PinballRoleConfig.GetRootAsPinballRoleConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRoleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballRoleConfigById.HandleId, ConfigPinballRoleConfigById.LogPair);
			return new PinballRoleConfig?(rootAsPinballRoleConfig);
		}

		// Token: 0x040032C2 RID: 12994
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040032C3 RID: 12995
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x040032C4 RID: 12996
		private const string TABLE = "PinballRoleConfig";

		// Token: 0x040032C5 RID: 12997
		private const string COMMAND = "select BinData from `PinballRoleConfig` where Id=?";

		// Token: 0x040032C6 RID: 12998
		private const string KEY_PREFIX = "PinballRoleConfigById";

		// Token: 0x040032C7 RID: 12999
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032C8 RID: 13000
		private static int HandleId;
	}
}
