using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C7 RID: 455
	public class ConfigDangoBrawlEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AAD RID: 2733 RVA: 0x00095F98 File Offset: 0x00094198
		static ConfigDangoBrawlEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlEffectById.CreateStaticDefaultValue), new Action(ConfigDangoBrawlEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00095FB8 File Offset: 0x000941B8
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

		// Token: 0x06000AAF RID: 2735 RVA: 0x00096037 File Offset: 0x00094237
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlEffectById.LogPair = null;
			ConfigDangoBrawlEffectById.HandleId = 0;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00096045 File Offset: 0x00094245
		public static void Init()
		{
			ConfigDangoBrawlEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlEffectById.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlEffect` where Id=?");
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00096060 File Offset: 0x00094260
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

		// Token: 0x04000C55 RID: 3157
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000C56 RID: 3158
		private const string FILE = "t.团子乱斗战斗.xlsx";

		// Token: 0x04000C57 RID: 3159
		private const string TABLE = "DangoBrawlEffect";

		// Token: 0x04000C58 RID: 3160
		private const string COMMAND = "select BinData from `DangoBrawlEffect` where Id=?";

		// Token: 0x04000C59 RID: 3161
		private const string KEY_PREFIX = "DangoBrawlEffectById";

		// Token: 0x04000C5A RID: 3162
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C5B RID: 3163
		private static int HandleId;
	}
}
