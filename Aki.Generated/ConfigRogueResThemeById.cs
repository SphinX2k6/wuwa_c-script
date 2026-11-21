using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200087C RID: 2172
	public class ConfigRogueResThemeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032FA RID: 13050 RVA: 0x0017D1FF File Offset: 0x0017B3FF
		static ConfigRogueResThemeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResThemeById.CreateStaticDefaultValue), new Action(ConfigRogueResThemeById.ResetStaticDefaultValue));
		}

		// Token: 0x060032FB RID: 13051 RVA: 0x0017D220 File Offset: 0x0017B420
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

		// Token: 0x060032FC RID: 13052 RVA: 0x0017D29F File Offset: 0x0017B49F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResThemeById.LogPair = null;
			ConfigRogueResThemeById.HandleId = 0;
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x0017D2AD File Offset: 0x0017B4AD
		public static void Init()
		{
			ConfigRogueResThemeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResThemeById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTheme` where Id=?");
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x0017D2C8 File Offset: 0x0017B4C8
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

		// Token: 0x04003B4A RID: 15178
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003B4B RID: 15179
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003B4C RID: 15180
		private const string TABLE = "RogueResTheme";

		// Token: 0x04003B4D RID: 15181
		private const string COMMAND = "select BinData from `RogueResTheme` where Id=?";

		// Token: 0x04003B4E RID: 15182
		private const string KEY_PREFIX = "RogueResThemeById";

		// Token: 0x04003B4F RID: 15183
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B50 RID: 15184
		private static int HandleId;
	}
}
