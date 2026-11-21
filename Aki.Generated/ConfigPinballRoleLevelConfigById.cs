using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000747 RID: 1863
	public class ConfigPinballRoleLevelConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BBA RID: 11194 RVA: 0x00154149 File Offset: 0x00152349
		static ConfigPinballRoleLevelConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRoleLevelConfigById.CreateStaticDefaultValue), new Action(ConfigPinballRoleLevelConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BBB RID: 11195 RVA: 0x00154168 File Offset: 0x00152368
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballRoleLevelConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballRoleLevelConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_角色.xlsx"),
				new ValueTuple<string, object>("表名", "PinballRoleLevelConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballRoleLevelConfig` where Id=?")
			});
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x001541E7 File Offset: 0x001523E7
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRoleLevelConfigById.LogPair = null;
			ConfigPinballRoleLevelConfigById.HandleId = 0;
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x001541F5 File Offset: 0x001523F5
		public static void Init()
		{
			ConfigPinballRoleLevelConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRoleLevelConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballRoleLevelConfig` where Id=?");
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x00154210 File Offset: 0x00152410
		public static PinballRoleLevelConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballRoleLevelConfigById.HandleId, ConfigPinballRoleLevelConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRoleLevelConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballRoleLevelConfig?(PinballRoleLevelConfig.GetRootAsPinballRoleLevelConfig(configBuffer));
				}
			}
			ConfigPinballRoleLevelConfigById.LogPair.Clear();
			ConfigPinballRoleLevelConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballRoleLevelConfigById.HandleId, 1, p0Id, ConfigPinballRoleLevelConfigById.LogPair) || ConfigCommon.Step(ConfigPinballRoleLevelConfigById.HandleId, true, ConfigPinballRoleLevelConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballRoleLevelConfigById.HandleId, ConfigPinballRoleLevelConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballRoleLevelConfigById.HandleId, 0, ConfigPinballRoleLevelConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballRoleLevelConfigById.HandleId, ConfigPinballRoleLevelConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballRoleLevelConfig rootAsPinballRoleLevelConfig = PinballRoleLevelConfig.GetRootAsPinballRoleLevelConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRoleLevelConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballRoleLevelConfigById.HandleId, ConfigPinballRoleLevelConfigById.LogPair);
			return new PinballRoleLevelConfig?(rootAsPinballRoleLevelConfig);
		}

		// Token: 0x040032D7 RID: 13015
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040032D8 RID: 13016
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x040032D9 RID: 13017
		private const string TABLE = "PinballRoleLevelConfig";

		// Token: 0x040032DA RID: 13018
		private const string COMMAND = "select BinData from `PinballRoleLevelConfig` where Id=?";

		// Token: 0x040032DB RID: 13019
		private const string KEY_PREFIX = "PinballRoleLevelConfigById";

		// Token: 0x040032DC RID: 13020
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032DD RID: 13021
		private static int HandleId;
	}
}
