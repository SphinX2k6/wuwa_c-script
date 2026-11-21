using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000879 RID: 2169
	public class ConfigRogueResTaskThemeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032E8 RID: 13032 RVA: 0x0017CC90 File Offset: 0x0017AE90
		static ConfigRogueResTaskThemeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResTaskThemeById.CreateStaticDefaultValue), new Action(ConfigRogueResTaskThemeById.ResetStaticDefaultValue));
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x0017CCB0 File Offset: 0x0017AEB0
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResTaskThemeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResTaskThemeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResTaskTheme"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResTaskTheme` where Id=?")
			});
		}

		// Token: 0x060032EA RID: 13034 RVA: 0x0017CD2F File Offset: 0x0017AF2F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResTaskThemeById.LogPair = null;
			ConfigRogueResTaskThemeById.HandleId = 0;
		}

		// Token: 0x060032EB RID: 13035 RVA: 0x0017CD3D File Offset: 0x0017AF3D
		public static void Init()
		{
			ConfigRogueResTaskThemeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResTaskThemeById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTaskTheme` where Id=?");
		}

		// Token: 0x060032EC RID: 13036 RVA: 0x0017CD58 File Offset: 0x0017AF58
		public static RogueResTaskTheme? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResTaskThemeById.HandleId, ConfigRogueResTaskThemeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResTaskThemeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResTaskTheme?(RogueResTaskTheme.GetRootAsRogueResTaskTheme(configBuffer));
				}
			}
			ConfigRogueResTaskThemeById.LogPair.Clear();
			ConfigRogueResTaskThemeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResTaskThemeById.HandleId, 1, p0Id, ConfigRogueResTaskThemeById.LogPair) || ConfigCommon.Step(ConfigRogueResTaskThemeById.HandleId, true, ConfigRogueResTaskThemeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResTaskThemeById.HandleId, ConfigRogueResTaskThemeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResTaskThemeById.HandleId, 0, ConfigRogueResTaskThemeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResTaskThemeById.HandleId, ConfigRogueResTaskThemeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResTaskTheme rootAsRogueResTaskTheme = RogueResTaskTheme.GetRootAsRogueResTaskTheme(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResTaskThemeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResTaskThemeById.HandleId, ConfigRogueResTaskThemeById.LogPair);
			return new RogueResTaskTheme?(rootAsRogueResTaskTheme);
		}

		// Token: 0x04003B35 RID: 15157
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003B36 RID: 15158
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003B37 RID: 15159
		private const string TABLE = "RogueResTaskTheme";

		// Token: 0x04003B38 RID: 15160
		private const string COMMAND = "select BinData from `RogueResTaskTheme` where Id=?";

		// Token: 0x04003B39 RID: 15161
		private const string KEY_PREFIX = "RogueResTaskThemeById";

		// Token: 0x04003B3A RID: 15162
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B3B RID: 15163
		private static int HandleId;
	}
}
