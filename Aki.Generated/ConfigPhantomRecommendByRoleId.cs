using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006CA RID: 1738
	public class ConfigPhantomRecommendByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028CC RID: 10444 RVA: 0x00143BF8 File Offset: 0x00141DF8
		static ConfigPhantomRecommendByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomRecommendByRoleId.CreateStaticDefaultValue), new Action(ConfigPhantomRecommendByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x00143C18 File Offset: 0x00141E18
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

		// Token: 0x060028CE RID: 10446 RVA: 0x00143C97 File Offset: 0x00141E97
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomRecommendByRoleId.LogPair = null;
			ConfigPhantomRecommendByRoleId.HandleId = 0;
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x00143CA5 File Offset: 0x00141EA5
		public static void Init()
		{
			ConfigPhantomRecommendByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomRecommendByRoleId.HandleId, "db_visionrecommend.db", "select BinData from `PhantomRecommend` where RoleId=?");
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x00143CC0 File Offset: 0x00141EC0
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

		// Token: 0x04002F6C RID: 12140
		private const string DB = "db_visionrecommend.db";

		// Token: 0x04002F6D RID: 12141
		private const string FILE = "h.幻象推荐.xlsx";

		// Token: 0x04002F6E RID: 12142
		private const string TABLE = "PhantomRecommend";

		// Token: 0x04002F6F RID: 12143
		private const string COMMAND = "select BinData from `PhantomRecommend` where RoleId=?";

		// Token: 0x04002F70 RID: 12144
		private const string KEY_PREFIX = "PhantomRecommendByRoleId";

		// Token: 0x04002F71 RID: 12145
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F72 RID: 12146
		private static int HandleId;
	}
}
