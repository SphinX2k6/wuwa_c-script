using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200085D RID: 2141
	public class ConfigRogueResTaskThemeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003240 RID: 12864 RVA: 0x001759A8 File Offset: 0x00173BA8
		static ConfigRogueResTaskThemeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResTaskThemeById.CreateStaticDefaultValue), new Action(ConfigRogueResTaskThemeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x001759C8 File Offset: 0x00173BC8
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

		// Token: 0x06003242 RID: 12866 RVA: 0x00175A47 File Offset: 0x00173C47
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResTaskThemeById.LogPair = null;
			ConfigRogueResTaskThemeById.HandleId = 0;
		}

		// Token: 0x06003243 RID: 12867 RVA: 0x00175A55 File Offset: 0x00173C55
		public static void Init()
		{
			ConfigRogueResTaskThemeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResTaskThemeById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResTaskTheme` where Id=?");
		}

		// Token: 0x06003244 RID: 12868 RVA: 0x00175A70 File Offset: 0x00173C70
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

		// Token: 0x04003A71 RID: 14961
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A72 RID: 14962
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A73 RID: 14963
		private const string TABLE = "RogueResTaskTheme";

		// Token: 0x04003A74 RID: 14964
		private const string COMMAND = "select BinData from `RogueResTaskTheme` where Id=?";

		// Token: 0x04003A75 RID: 14965
		private const string KEY_PREFIX = "RogueResTaskThemeById";

		// Token: 0x04003A76 RID: 14966
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A77 RID: 14967
		private static int HandleId;
	}
}
