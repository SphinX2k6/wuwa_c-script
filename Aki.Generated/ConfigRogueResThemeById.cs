using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000860 RID: 2144
	public class ConfigRogueResThemeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003252 RID: 12882 RVA: 0x00175F17 File Offset: 0x00174117
		static ConfigRogueResThemeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResThemeById.CreateStaticDefaultValue), new Action(ConfigRogueResThemeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x00175F38 File Offset: 0x00174138
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResThemeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResThemeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResTheme"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResTheme` where Id=?")
			});
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x00175FB7 File Offset: 0x001741B7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResThemeById.LogPair = null;
			ConfigRogueResThemeById.HandleId = 0;
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x00175FC5 File Offset: 0x001741C5
		public static void Init()
		{
			ConfigRogueResThemeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResThemeById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTheme` where Id=?");
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x00175FE0 File Offset: 0x001741E0
		public static RogueResTheme? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResThemeById.HandleId, ConfigRogueResThemeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResThemeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResTheme?(RogueResTheme.GetRootAsRogueResTheme(configBuffer));
				}
			}
			ConfigRogueResThemeById.LogPair.Clear();
			ConfigRogueResThemeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResThemeById.HandleId, 1, p0Id, ConfigRogueResThemeById.LogPair) || ConfigCommon.Step(ConfigRogueResThemeById.HandleId, true, ConfigRogueResThemeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResThemeById.HandleId, ConfigRogueResThemeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResThemeById.HandleId, 0, ConfigRogueResThemeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResThemeById.HandleId, ConfigRogueResThemeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResTheme rootAsRogueResTheme = RogueResTheme.GetRootAsRogueResTheme(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResThemeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResThemeById.HandleId, ConfigRogueResThemeById.LogPair);
			return new RogueResTheme?(rootAsRogueResTheme);
		}

		// Token: 0x04003A86 RID: 14982
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A87 RID: 14983
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A88 RID: 14984
		private const string TABLE = "RogueResTheme";

		// Token: 0x04003A89 RID: 14985
		private const string COMMAND = "select BinData from `RogueResTheme` where Id=?";

		// Token: 0x04003A8A RID: 14986
		private const string KEY_PREFIX = "RogueResThemeById";

		// Token: 0x04003A8B RID: 14987
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A8C RID: 14988
		private static int HandleId;
	}
}
