using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000746 RID: 1862
	public class ConfigPinballRoleLevelConfigByGroupIdAndLevel : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BB4 RID: 11188 RVA: 0x00153EAB File Offset: 0x001520AB
		static ConfigPinballRoleLevelConfigByGroupIdAndLevel()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRoleLevelConfigByGroupIdAndLevel.CreateStaticDefaultValue), new Action(ConfigPinballRoleLevelConfigByGroupIdAndLevel.ResetStaticDefaultValue));
		}

		// Token: 0x06002BB5 RID: 11189 RVA: 0x00153ECC File Offset: 0x001520CC
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_角色.xlsx"),
				new ValueTuple<string, object>("表名", "PinballRoleLevelConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballRoleLevelConfig` where GroupId=? AND Level=?")
			});
		}

		// Token: 0x06002BB6 RID: 11190 RVA: 0x00153F4B File Offset: 0x0015214B
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair = null;
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId = 0;
		}

		// Token: 0x06002BB7 RID: 11191 RVA: 0x00153F59 File Offset: 0x00152159
		public static void Init()
		{
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, "db_pinballbattle.db", "select BinData from `PinballRoleLevelConfig` where GroupId=? AND Level=?");
		}

		// Token: 0x06002BB8 RID: 11192 RVA: 0x00153F74 File Offset: 0x00152174
		public static PinballRoleLevelConfig? GetConfig(int p0GroupId, int p1Level, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRoleLevelConfigByGroupIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballRoleLevelConfig?(PinballRoleLevelConfig.GetRootAsPinballRoleLevelConfig(configBuffer));
				}
			}
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair.Clear();
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair.Add(new ValueTuple<string, object>("Level", p1Level));
			if (!ConfigCommon.BindInt(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, 1, p0GroupId, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair) || !ConfigCommon.BindInt(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, 2, p1Level, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair) || ConfigCommon.Step(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, true, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, 0, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballRoleLevelConfig rootAsPinballRoleLevelConfig = PinballRoleLevelConfig.GetRootAsPinballRoleLevelConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRoleLevelConfigByGroupIdAndLevel");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1Level);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballRoleLevelConfigByGroupIdAndLevel.HandleId, ConfigPinballRoleLevelConfigByGroupIdAndLevel.LogPair);
			return new PinballRoleLevelConfig?(rootAsPinballRoleLevelConfig);
		}

		// Token: 0x040032D0 RID: 13008
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040032D1 RID: 13009
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x040032D2 RID: 13010
		private const string TABLE = "PinballRoleLevelConfig";

		// Token: 0x040032D3 RID: 13011
		private const string COMMAND = "select BinData from `PinballRoleLevelConfig` where GroupId=? AND Level=?";

		// Token: 0x040032D4 RID: 13012
		private const string KEY_PREFIX = "PinballRoleLevelConfigByGroupIdAndLevel";

		// Token: 0x040032D5 RID: 13013
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032D6 RID: 13014
		private static int HandleId;
	}
}
