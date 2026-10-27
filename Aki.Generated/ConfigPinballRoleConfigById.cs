using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200072C RID: 1836
	public class ConfigPinballRoleConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B18 RID: 11032 RVA: 0x0014CFAF File Offset: 0x0014B1AF
		static ConfigPinballRoleConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRoleConfigById.CreateStaticDefaultValue), new Action(ConfigPinballRoleConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x0014CFD0 File Offset: 0x0014B1D0
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

		// Token: 0x06002B1A RID: 11034 RVA: 0x0014D04F File Offset: 0x0014B24F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRoleConfigById.LogPair = null;
			ConfigPinballRoleConfigById.HandleId = 0;
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x0014D05D File Offset: 0x0014B25D
		public static void Init()
		{
			ConfigPinballRoleConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRoleConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballRoleConfig` where Id=?");
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x0014D078 File Offset: 0x0014B278
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

		// Token: 0x0400321A RID: 12826
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400321B RID: 12827
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x0400321C RID: 12828
		private const string TABLE = "PinballRoleConfig";

		// Token: 0x0400321D RID: 12829
		private const string COMMAND = "select BinData from `PinballRoleConfig` where Id=?";

		// Token: 0x0400321E RID: 12830
		private const string KEY_PREFIX = "PinballRoleConfigById";

		// Token: 0x0400321F RID: 12831
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003220 RID: 12832
		private static int HandleId;
	}
}
