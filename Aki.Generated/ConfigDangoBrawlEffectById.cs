using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D9 RID: 473
	public class ConfigDangoBrawlEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B19 RID: 2841 RVA: 0x0009BED0 File Offset: 0x0009A0D0
		static ConfigDangoBrawlEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlEffectById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0009BEF0 File Offset: 0x0009A0F0
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗战斗.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlEffect` where Id=?")
			});
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0009BF6F File Offset: 0x0009A16F
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlEffectById.LogPair = null;
			ConfigDangoBrawlEffectById.HandleId = 0;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0009BF7D File Offset: 0x0009A17D
		public static void Init()
		{
			ConfigDangoBrawlEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlEffectById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlEffect` where Id=?");
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x0009BF98 File Offset: 0x0009A198
		public static DangoBrawlEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlEffectById.HandleId, ConfigDangoBrawlEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBrawlEffect?(DangoBrawlEffect.GetRootAsDangoBrawlEffect(configBuffer));
				}
			}
			ConfigDangoBrawlEffectById.LogPair.Clear();
			ConfigDangoBrawlEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBrawlEffectById.HandleId, 1, p0Id, ConfigDangoBrawlEffectById.LogPair) || ConfigCommon.Step(ConfigDangoBrawlEffectById.HandleId, true, ConfigDangoBrawlEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBrawlEffectById.HandleId, ConfigDangoBrawlEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlEffectById.HandleId, 0, ConfigDangoBrawlEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBrawlEffectById.HandleId, ConfigDangoBrawlEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBrawlEffect rootAsDangoBrawlEffect = DangoBrawlEffect.GetRootAsDangoBrawlEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBrawlEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBrawlEffectById.HandleId, ConfigDangoBrawlEffectById.LogPair);
			return new DangoBrawlEffect?(rootAsDangoBrawlEffect);
		}

		// Token: 0x04000CD3 RID: 3283
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CD4 RID: 3284
		private const string FILE = "t.团子乱斗战斗.xlsx";

		// Token: 0x04000CD5 RID: 3285
		private const string TABLE = "DangoBrawlEffect";

		// Token: 0x04000CD6 RID: 3286
		private const string COMMAND = "select BinData from `DangoBrawlEffect` where Id=?";

		// Token: 0x04000CD7 RID: 3287
		private const string KEY_PREFIX = "DangoBrawlEffectById";

		// Token: 0x04000CD8 RID: 3288
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CD9 RID: 3289
		private static int HandleId;
	}
}
