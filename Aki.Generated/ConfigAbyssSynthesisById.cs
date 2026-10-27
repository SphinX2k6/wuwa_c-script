using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000031 RID: 49
	public class ConfigAbyssSynthesisById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000126 RID: 294 RVA: 0x000603DF File Offset: 0x0005E5DF
		static ConfigAbyssSynthesisById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssSynthesisById.CreateStaticDefaultValue), new Action(ConfigAbyssSynthesisById.ResetStaticDefaultValue));
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00060400 File Offset: 0x0005E600
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssSynthesisById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssSynthesisById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssSynthesis"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssSynthesis` where Id=?")
			});
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0006047F File Offset: 0x0005E67F
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssSynthesisById.LogPair = null;
			ConfigAbyssSynthesisById.HandleId = 0;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0006048D File Offset: 0x0005E68D
		public static void Init()
		{
			ConfigAbyssSynthesisById.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssSynthesisById.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssSynthesis` where Id=?");
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000604A8 File Offset: 0x0005E6A8
		public static AbyssSynthesis? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssSynthesisById.HandleId, ConfigAbyssSynthesisById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssSynthesisById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssSynthesis?(AbyssSynthesis.GetRootAsAbyssSynthesis(configBuffer));
				}
			}
			ConfigAbyssSynthesisById.LogPair.Clear();
			ConfigAbyssSynthesisById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbyssSynthesisById.HandleId, 1, p0Id, ConfigAbyssSynthesisById.LogPair) || ConfigCommon.Step(ConfigAbyssSynthesisById.HandleId, true, ConfigAbyssSynthesisById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssSynthesisById.HandleId, ConfigAbyssSynthesisById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssSynthesisById.HandleId, 0, ConfigAbyssSynthesisById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssSynthesisById.HandleId, ConfigAbyssSynthesisById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssSynthesis rootAsAbyssSynthesis = AbyssSynthesis.GetRootAsAbyssSynthesis(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssSynthesisById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssSynthesisById.HandleId, ConfigAbyssSynthesisById.LogPair);
			return new AbyssSynthesis?(rootAsAbyssSynthesis);
		}

		// Token: 0x0400013B RID: 315
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x0400013C RID: 316
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x0400013D RID: 317
		private const string TABLE = "AbyssSynthesis";

		// Token: 0x0400013E RID: 318
		private const string COMMAND = "select BinData from `AbyssSynthesis` where Id=?";

		// Token: 0x0400013F RID: 319
		private const string KEY_PREFIX = "AbyssSynthesisById";

		// Token: 0x04000140 RID: 320
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000141 RID: 321
		private static int HandleId;
	}
}
