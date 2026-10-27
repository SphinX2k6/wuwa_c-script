using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D0 RID: 2512
	public class ConfigTermConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AF4 RID: 15092 RVA: 0x001A71EC File Offset: 0x001A53EC
		static ConfigTermConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTermConfigById.CreateStaticDefaultValue), new Action(ConfigTermConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x001A720C File Offset: 0x001A540C
		public static void CreateStaticDefaultValue()
		{
			ConfigTermConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTermConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_term.db"),
				new ValueTuple<string, object>("文件", "s.术语/*.csv*"),
				new ValueTuple<string, object>("表名", "TermConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TermConfig` where Id=?")
			});
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x001A728B File Offset: 0x001A548B
		public static void ResetStaticDefaultValue()
		{
			ConfigTermConfigById.LogPair = null;
			ConfigTermConfigById.HandleId = 0;
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x001A7299 File Offset: 0x001A5499
		public static void Init()
		{
			ConfigTermConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTermConfigById.HandleId, "db_term.db", "select BinData from `TermConfig` where Id=?");
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x001A72B4 File Offset: 0x001A54B4
		public static TermConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTermConfigById.HandleId, ConfigTermConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TermConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TermConfig?(TermConfig.GetRootAsTermConfig(configBuffer));
				}
			}
			ConfigTermConfigById.LogPair.Clear();
			ConfigTermConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTermConfigById.HandleId, 1, p0Id, ConfigTermConfigById.LogPair) || ConfigCommon.Step(ConfigTermConfigById.HandleId, true, ConfigTermConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTermConfigById.HandleId, ConfigTermConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTermConfigById.HandleId, 0, ConfigTermConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTermConfigById.HandleId, ConfigTermConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TermConfig rootAsTermConfig = TermConfig.GetRootAsTermConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TermConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTermConfigById.HandleId, ConfigTermConfigById.LogPair);
			return new TermConfig?(rootAsTermConfig);
		}

		// Token: 0x04004496 RID: 17558
		private const string DB = "db_term.db";

		// Token: 0x04004497 RID: 17559
		private const string FILE = "s.术语/*.csv*";

		// Token: 0x04004498 RID: 17560
		private const string TABLE = "TermConfig";

		// Token: 0x04004499 RID: 17561
		private const string COMMAND = "select BinData from `TermConfig` where Id=?";

		// Token: 0x0400449A RID: 17562
		private const string KEY_PREFIX = "TermConfigById";

		// Token: 0x0400449B RID: 17563
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400449C RID: 17564
		private static int HandleId;
	}
}
