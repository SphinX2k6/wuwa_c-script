using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000187 RID: 391
	public class ConfigCommonSkillPreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600092B RID: 2347 RVA: 0x0008D44B File Offset: 0x0008B64B
		static ConfigCommonSkillPreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonSkillPreloadById.CreateStaticDefaultValue), new Action(ConfigCommonSkillPreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0008D46C File Offset: 0x0008B66C
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

		// Token: 0x0600092D RID: 2349 RVA: 0x0008D4EB File Offset: 0x0008B6EB
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonSkillPreloadById.LogPair = null;
			ConfigCommonSkillPreloadById.HandleId = 0;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0008D4F9 File Offset: 0x0008B6F9
		public static void Init()
		{
			ConfigCommonSkillPreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigCommonSkillPreloadById.HandleId, "db_common_skill_preload.db", "select BinData from `CommonSkillPreload` where Id=?");
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x0008D514 File Offset: 0x0008B714
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

		// Token: 0x04000A95 RID: 2709
		private const string DB = "db_common_skill_preload.db";

		// Token: 0x04000A96 RID: 2710
		private const string FILE = "Preload/CommonSkillPreload.csv";

		// Token: 0x04000A97 RID: 2711
		private const string TABLE = "CommonSkillPreload";

		// Token: 0x04000A98 RID: 2712
		private const string COMMAND = "select BinData from `CommonSkillPreload` where Id=?";

		// Token: 0x04000A99 RID: 2713
		private const string KEY_PREFIX = "CommonSkillPreloadById";

		// Token: 0x04000A9A RID: 2714
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A9B RID: 2715
		private static int HandleId;
	}
}
