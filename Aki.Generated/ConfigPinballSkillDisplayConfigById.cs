using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000748 RID: 1864
	public class ConfigPinballSkillDisplayConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BC0 RID: 11200 RVA: 0x00154390 File Offset: 0x00152590
		static ConfigPinballSkillDisplayConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballSkillDisplayConfigById.CreateStaticDefaultValue), new Action(ConfigPinballSkillDisplayConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BC1 RID: 11201 RVA: 0x001543B0 File Offset: 0x001525B0
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballSkillDisplayConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballSkillDisplayConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_角色.xlsx"),
				new ValueTuple<string, object>("表名", "PinballSkillDisplayConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballSkillDisplayConfig` where Id=?")
			});
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x0015442F File Offset: 0x0015262F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballSkillDisplayConfigById.LogPair = null;
			ConfigPinballSkillDisplayConfigById.HandleId = 0;
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x0015443D File Offset: 0x0015263D
		public static void Init()
		{
			ConfigPinballSkillDisplayConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballSkillDisplayConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballSkillDisplayConfig` where Id=?");
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x00154458 File Offset: 0x00152658
		public static PinballSkillDisplayConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballSkillDisplayConfigById.HandleId, ConfigPinballSkillDisplayConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballSkillDisplayConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballSkillDisplayConfig?(PinballSkillDisplayConfig.GetRootAsPinballSkillDisplayConfig(configBuffer));
				}
			}
			ConfigPinballSkillDisplayConfigById.LogPair.Clear();
			ConfigPinballSkillDisplayConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballSkillDisplayConfigById.HandleId, 1, p0Id, ConfigPinballSkillDisplayConfigById.LogPair) || ConfigCommon.Step(ConfigPinballSkillDisplayConfigById.HandleId, true, ConfigPinballSkillDisplayConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballSkillDisplayConfigById.HandleId, ConfigPinballSkillDisplayConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballSkillDisplayConfigById.HandleId, 0, ConfigPinballSkillDisplayConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballSkillDisplayConfigById.HandleId, ConfigPinballSkillDisplayConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballSkillDisplayConfig rootAsPinballSkillDisplayConfig = PinballSkillDisplayConfig.GetRootAsPinballSkillDisplayConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballSkillDisplayConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballSkillDisplayConfigById.HandleId, ConfigPinballSkillDisplayConfigById.LogPair);
			return new PinballSkillDisplayConfig?(rootAsPinballSkillDisplayConfig);
		}

		// Token: 0x040032DE RID: 13022
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040032DF RID: 13023
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x040032E0 RID: 13024
		private const string TABLE = "PinballSkillDisplayConfig";

		// Token: 0x040032E1 RID: 13025
		private const string COMMAND = "select BinData from `PinballSkillDisplayConfig` where Id=?";

		// Token: 0x040032E2 RID: 13026
		private const string KEY_PREFIX = "PinballSkillDisplayConfigById";

		// Token: 0x040032E3 RID: 13027
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032E4 RID: 13028
		private static int HandleId;
	}
}
