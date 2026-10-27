using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000730 RID: 1840
	public class ConfigPinballSkillDisplayConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B30 RID: 11056 RVA: 0x0014D914 File Offset: 0x0014BB14
		static ConfigPinballSkillDisplayConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballSkillDisplayConfigById.CreateStaticDefaultValue), new Action(ConfigPinballSkillDisplayConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B31 RID: 11057 RVA: 0x0014D934 File Offset: 0x0014BB34
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

		// Token: 0x06002B32 RID: 11058 RVA: 0x0014D9B3 File Offset: 0x0014BBB3
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballSkillDisplayConfigById.LogPair = null;
			ConfigPinballSkillDisplayConfigById.HandleId = 0;
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x0014D9C1 File Offset: 0x0014BBC1
		public static void Init()
		{
			ConfigPinballSkillDisplayConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballSkillDisplayConfigById.HandleId, "db_pinballbattle.db", "select BinData from `PinballSkillDisplayConfig` where Id=?");
		}

		// Token: 0x06002B34 RID: 11060 RVA: 0x0014D9DC File Offset: 0x0014BBDC
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

		// Token: 0x04003236 RID: 12854
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003237 RID: 12855
		private const string FILE = "x.星弹奇游_角色.xlsx";

		// Token: 0x04003238 RID: 12856
		private const string TABLE = "PinballSkillDisplayConfig";

		// Token: 0x04003239 RID: 12857
		private const string COMMAND = "select BinData from `PinballSkillDisplayConfig` where Id=?";

		// Token: 0x0400323A RID: 12858
		private const string KEY_PREFIX = "PinballSkillDisplayConfigById";

		// Token: 0x0400323B RID: 12859
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400323C RID: 12860
		private static int HandleId;
	}
}
