using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A6 RID: 678
	public class ConfigExploreToolsByPhantomSkillId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FE9 RID: 4073 RVA: 0x000B35B7 File Offset: 0x000B17B7
		static ConfigExploreToolsByPhantomSkillId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreToolsByPhantomSkillId.CreateStaticDefaultValue), new Action(ConfigExploreToolsByPhantomSkillId.ResetStaticDefaultValue));
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x000B35D8 File Offset: 0x000B17D8
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

		// Token: 0x06000FEB RID: 4075 RVA: 0x000B3657 File Offset: 0x000B1857
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreToolsByPhantomSkillId.LogPair = null;
			ConfigExploreToolsByPhantomSkillId.HandleId = 0;
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x000B3665 File Offset: 0x000B1865
		public static void Init()
		{
			ConfigExploreToolsByPhantomSkillId.HandleId = ConfigCommon.InitDataStatement(ConfigExploreToolsByPhantomSkillId.HandleId, "db_explore_skill.db", "select BinData from `ExploreTools` where PhantomSkillId=?");
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x000B3680 File Offset: 0x000B1880
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

		// Token: 0x0400126E RID: 4718
		private const string DB = "db_explore_skill.db";

		// Token: 0x0400126F RID: 4719
		private const string FILE = "t.探索工具.xlsx";

		// Token: 0x04001270 RID: 4720
		private const string TABLE = "ExploreTools";

		// Token: 0x04001271 RID: 4721
		private const string COMMAND = "select BinData from `ExploreTools` where PhantomSkillId=?";

		// Token: 0x04001272 RID: 4722
		private const string KEY_PREFIX = "ExploreToolsByPhantomSkillId";

		// Token: 0x04001273 RID: 4723
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001274 RID: 4724
		private static int HandleId;
	}
}
