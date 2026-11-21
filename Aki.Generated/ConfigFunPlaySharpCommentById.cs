using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000374 RID: 884
	public class ConfigFunPlaySharpCommentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014BD RID: 5309 RVA: 0x000D2368 File Offset: 0x000D0568
		static ConfigFunPlaySharpCommentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFunPlaySharpCommentById.CreateStaticDefaultValue), new Action(ConfigFunPlaySharpCommentById.ResetStaticDefaultValue));
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x000D2388 File Offset: 0x000D0588
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

		// Token: 0x060014BF RID: 5311 RVA: 0x000D2407 File Offset: 0x000D0607
		public static void ResetStaticDefaultValue()
		{
			ConfigFunPlaySharpCommentById.LogPair = null;
			ConfigFunPlaySharpCommentById.HandleId = 0;
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x000D2415 File Offset: 0x000D0615
		public static void Init()
		{
			ConfigFunPlaySharpCommentById.HandleId = ConfigCommon.InitDataStatement(ConfigFunPlaySharpCommentById.HandleId, "db_activityfunplay.db", "select BinData from `FunPlaySharpComment` where CommentId=?");
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x000D2430 File Offset: 0x000D0630
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

		// Token: 0x04001810 RID: 6160
		private const string DB = "db_activityfunplay.db";

		// Token: 0x04001811 RID: 6161
		private const string FILE = "q.趣味玩法活动.xlsx";

		// Token: 0x04001812 RID: 6162
		private const string TABLE = "FunPlaySharpComment";

		// Token: 0x04001813 RID: 6163
		private const string COMMAND = "select BinData from `FunPlaySharpComment` where CommentId=?";

		// Token: 0x04001814 RID: 6164
		private const string KEY_PREFIX = "FunPlaySharpCommentById";

		// Token: 0x04001815 RID: 6165
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001816 RID: 6166
		private static int HandleId;
	}
}
