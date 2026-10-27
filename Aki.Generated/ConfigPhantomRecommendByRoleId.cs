using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B2 RID: 1714
	public class ConfigPhantomRecommendByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600283C RID: 10300 RVA: 0x0013D17C File Offset: 0x0013B37C
		static ConfigPhantomRecommendByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomRecommendByRoleId.CreateStaticDefaultValue), new Action(ConfigPhantomRecommendByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x0013D19C File Offset: 0x0013B39C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomRecommendByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomRecommendByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_visionrecommend.db"),
				new ValueTuple<string, object>("文件", "h.幻象推荐.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomRecommend"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomRecommend` where RoleId=?")
			});
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x0013D21B File Offset: 0x0013B41B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomRecommendByRoleId.LogPair = null;
			ConfigPhantomRecommendByRoleId.HandleId = 0;
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x0013D229 File Offset: 0x0013B429
		public static void Init()
		{
			ConfigPhantomRecommendByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomRecommendByRoleId.HandleId, "db_visionrecommend.db", "select BinData from `PhantomRecommend` where RoleId=?");
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x0013D244 File Offset: 0x0013B444
		public static PhantomRecommend? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomRecommendByRoleId.HandleId, ConfigPhantomRecommendByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomRecommendByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomRecommend?(PhantomRecommend.GetRootAsPhantomRecommend(configBuffer));
				}
			}
			ConfigPhantomRecommendByRoleId.LogPair.Clear();
			ConfigPhantomRecommendByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigPhantomRecommendByRoleId.HandleId, 1, p0RoleId, ConfigPhantomRecommendByRoleId.LogPair) || ConfigCommon.Step(ConfigPhantomRecommendByRoleId.HandleId, true, ConfigPhantomRecommendByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomRecommendByRoleId.HandleId, ConfigPhantomRecommendByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomRecommendByRoleId.HandleId, 0, ConfigPhantomRecommendByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomRecommendByRoleId.HandleId, ConfigPhantomRecommendByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomRecommend rootAsPhantomRecommend = PhantomRecommend.GetRootAsPhantomRecommend(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomRecommendByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomRecommendByRoleId.HandleId, ConfigPhantomRecommendByRoleId.LogPair);
			return new PhantomRecommend?(rootAsPhantomRecommend);
		}

		// Token: 0x04002EC4 RID: 11972
		private const string DB = "db_visionrecommend.db";

		// Token: 0x04002EC5 RID: 11973
		private const string FILE = "h.幻象推荐.xlsx";

		// Token: 0x04002EC6 RID: 11974
		private const string TABLE = "PhantomRecommend";

		// Token: 0x04002EC7 RID: 11975
		private const string COMMAND = "select BinData from `PhantomRecommend` where RoleId=?";

		// Token: 0x04002EC8 RID: 11976
		private const string KEY_PREFIX = "PhantomRecommendByRoleId";

		// Token: 0x04002EC9 RID: 11977
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002ECA RID: 11978
		private static int HandleId;
	}
}
