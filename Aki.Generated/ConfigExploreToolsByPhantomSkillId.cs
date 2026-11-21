using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002BA RID: 698
	public class ConfigExploreToolsByPhantomSkillId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001061 RID: 4193 RVA: 0x000B987B File Offset: 0x000B7A7B
		static ConfigExploreToolsByPhantomSkillId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreToolsByPhantomSkillId.CreateStaticDefaultValue), new Action(ConfigExploreToolsByPhantomSkillId.ResetStaticDefaultValue));
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x000B989C File Offset: 0x000B7A9C
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreToolsByPhantomSkillId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreToolsByPhantomSkillId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_skill.db"),
				new ValueTuple<string, object>("文件", "t.探索工具.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreTools"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreTools` where PhantomSkillId=?")
			});
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x000B991B File Offset: 0x000B7B1B
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreToolsByPhantomSkillId.LogPair = null;
			ConfigExploreToolsByPhantomSkillId.HandleId = 0;
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x000B9929 File Offset: 0x000B7B29
		public static void Init()
		{
			ConfigExploreToolsByPhantomSkillId.HandleId = ConfigCommon.InitDataStatement(ConfigExploreToolsByPhantomSkillId.HandleId, "db_explore_skill.db", "select BinData from `ExploreTools` where PhantomSkillId=?");
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x000B9944 File Offset: 0x000B7B44
		public static ExploreTools? GetConfig(int p0PhantomSkillId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreToolsByPhantomSkillId.HandleId, ConfigExploreToolsByPhantomSkillId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreToolsByPhantomSkillId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PhantomSkillId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExploreTools?(ExploreTools.GetRootAsExploreTools(configBuffer));
				}
			}
			ConfigExploreToolsByPhantomSkillId.LogPair.Clear();
			ConfigExploreToolsByPhantomSkillId.LogPair.Add(new ValueTuple<string, object>("PhantomSkillId", p0PhantomSkillId));
			if (!ConfigCommon.BindInt(ConfigExploreToolsByPhantomSkillId.HandleId, 1, p0PhantomSkillId, ConfigExploreToolsByPhantomSkillId.LogPair) || ConfigCommon.Step(ConfigExploreToolsByPhantomSkillId.HandleId, true, ConfigExploreToolsByPhantomSkillId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExploreToolsByPhantomSkillId.HandleId, ConfigExploreToolsByPhantomSkillId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreToolsByPhantomSkillId.HandleId, 0, ConfigExploreToolsByPhantomSkillId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExploreToolsByPhantomSkillId.HandleId, ConfigExploreToolsByPhantomSkillId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExploreTools rootAsExploreTools = ExploreTools.GetRootAsExploreTools(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreToolsByPhantomSkillId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PhantomSkillId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExploreToolsByPhantomSkillId.HandleId, ConfigExploreToolsByPhantomSkillId.LogPair);
			return new ExploreTools?(rootAsExploreTools);
		}

		// Token: 0x040012FA RID: 4858
		private const string DB = "db_explore_skill.db";

		// Token: 0x040012FB RID: 4859
		private const string FILE = "t.探索工具.xlsx";

		// Token: 0x040012FC RID: 4860
		private const string TABLE = "ExploreTools";

		// Token: 0x040012FD RID: 4861
		private const string COMMAND = "select BinData from `ExploreTools` where PhantomSkillId=?";

		// Token: 0x040012FE RID: 4862
		private const string KEY_PREFIX = "ExploreToolsByPhantomSkillId";

		// Token: 0x040012FF RID: 4863
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001300 RID: 4864
		private static int HandleId;
	}
}
