using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200035F RID: 863
	public class ConfigFunPlaySharpCommentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600143F RID: 5183 RVA: 0x000CBE5C File Offset: 0x000CA05C
		static ConfigFunPlaySharpCommentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFunPlaySharpCommentById.CreateStaticDefaultValue), new Action(ConfigFunPlaySharpCommentById.ResetStaticDefaultValue));
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000CBE7C File Offset: 0x000CA07C
		public static void CreateStaticDefaultValue()
		{
			ConfigFunPlaySharpCommentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFunPlaySharpCommentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activityfunplay.db"),
				new ValueTuple<string, object>("文件", "q.趣味玩法活动.xlsx"),
				new ValueTuple<string, object>("表名", "FunPlaySharpComment"),
				new ValueTuple<string, object>("语句", "select BinData from `FunPlaySharpComment` where CommentId=?")
			});
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x000CBEFB File Offset: 0x000CA0FB
		public static void ResetStaticDefaultValue()
		{
			ConfigFunPlaySharpCommentById.LogPair = null;
			ConfigFunPlaySharpCommentById.HandleId = 0;
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x000CBF09 File Offset: 0x000CA109
		public static void Init()
		{
			ConfigFunPlaySharpCommentById.HandleId = ConfigCommon.InitDataStatement(ConfigFunPlaySharpCommentById.HandleId, "db_activityfunplay.db", "select BinData from `FunPlaySharpComment` where CommentId=?");
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x000CBF24 File Offset: 0x000CA124
		public static FunPlaySharpComment? GetConfig(int p0CommentId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFunPlaySharpCommentById.HandleId, ConfigFunPlaySharpCommentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FunPlaySharpCommentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CommentId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FunPlaySharpComment?(FunPlaySharpComment.GetRootAsFunPlaySharpComment(configBuffer));
				}
			}
			ConfigFunPlaySharpCommentById.LogPair.Clear();
			ConfigFunPlaySharpCommentById.LogPair.Add(new ValueTuple<string, object>("CommentId", p0CommentId));
			if (!ConfigCommon.BindInt(ConfigFunPlaySharpCommentById.HandleId, 1, p0CommentId, ConfigFunPlaySharpCommentById.LogPair) || ConfigCommon.Step(ConfigFunPlaySharpCommentById.HandleId, true, ConfigFunPlaySharpCommentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFunPlaySharpCommentById.HandleId, ConfigFunPlaySharpCommentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFunPlaySharpCommentById.HandleId, 0, ConfigFunPlaySharpCommentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFunPlaySharpCommentById.HandleId, ConfigFunPlaySharpCommentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FunPlaySharpComment rootAsFunPlaySharpComment = FunPlaySharpComment.GetRootAsFunPlaySharpComment(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FunPlaySharpCommentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CommentId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFunPlaySharpCommentById.HandleId, ConfigFunPlaySharpCommentById.LogPair);
			return new FunPlaySharpComment?(rootAsFunPlaySharpComment);
		}

		// Token: 0x0400177D RID: 6013
		private const string DB = "db_activityfunplay.db";

		// Token: 0x0400177E RID: 6014
		private const string FILE = "q.趣味玩法活动.xlsx";

		// Token: 0x0400177F RID: 6015
		private const string TABLE = "FunPlaySharpComment";

		// Token: 0x04001780 RID: 6016
		private const string COMMAND = "select BinData from `FunPlaySharpComment` where CommentId=?";

		// Token: 0x04001781 RID: 6017
		private const string KEY_PREFIX = "FunPlaySharpCommentById";

		// Token: 0x04001782 RID: 6018
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001783 RID: 6019
		private static int HandleId;
	}
}
