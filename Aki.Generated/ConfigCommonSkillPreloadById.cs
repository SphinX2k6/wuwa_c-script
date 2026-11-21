using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000199 RID: 409
	public class ConfigCommonSkillPreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000997 RID: 2455 RVA: 0x00093383 File Offset: 0x00091583
		static ConfigCommonSkillPreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonSkillPreloadById.CreateStaticDefaultValue), new Action(ConfigCommonSkillPreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x000933A4 File Offset: 0x000915A4
		public static void CreateStaticDefaultValue()
		{
			ConfigCommonSkillPreloadById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCommonSkillPreloadById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_common_skill_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/CommonSkillPreload.csv"),
				new ValueTuple<string, object>("表名", "CommonSkillPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `CommonSkillPreload` where Id=?")
			});
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00093423 File Offset: 0x00091623
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonSkillPreloadById.LogPair = null;
			ConfigCommonSkillPreloadById.HandleId = 0;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00093431 File Offset: 0x00091631
		public static void Init()
		{
			ConfigCommonSkillPreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigCommonSkillPreloadById.HandleId, "db_common_skill_preload.db", "select BinData from `CommonSkillPreload` where Id=?");
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x0009344C File Offset: 0x0009164C
		public static CommonSkillPreload? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCommonSkillPreloadById.HandleId, ConfigCommonSkillPreloadById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommonSkillPreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CommonSkillPreload?(CommonSkillPreload.GetRootAsCommonSkillPreload(configBuffer));
				}
			}
			ConfigCommonSkillPreloadById.LogPair.Clear();
			ConfigCommonSkillPreloadById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCommonSkillPreloadById.HandleId, 1, p0Id, ConfigCommonSkillPreloadById.LogPair) || ConfigCommon.Step(ConfigCommonSkillPreloadById.HandleId, true, ConfigCommonSkillPreloadById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCommonSkillPreloadById.HandleId, ConfigCommonSkillPreloadById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCommonSkillPreloadById.HandleId, 0, ConfigCommonSkillPreloadById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCommonSkillPreloadById.HandleId, ConfigCommonSkillPreloadById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CommonSkillPreload rootAsCommonSkillPreload = CommonSkillPreload.GetRootAsCommonSkillPreload(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommonSkillPreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCommonSkillPreloadById.HandleId, ConfigCommonSkillPreloadById.LogPair);
			return new CommonSkillPreload?(rootAsCommonSkillPreload);
		}

		// Token: 0x04000B13 RID: 2835
		private const string DB = "db_common_skill_preload.db";

		// Token: 0x04000B14 RID: 2836
		private const string FILE = "Preload/CommonSkillPreload.csv";

		// Token: 0x04000B15 RID: 2837
		private const string TABLE = "CommonSkillPreload";

		// Token: 0x04000B16 RID: 2838
		private const string COMMAND = "select BinData from `CommonSkillPreload` where Id=?";

		// Token: 0x04000B17 RID: 2839
		private const string KEY_PREFIX = "CommonSkillPreloadById";

		// Token: 0x04000B18 RID: 2840
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B19 RID: 2841
		private static int HandleId;
	}
}
