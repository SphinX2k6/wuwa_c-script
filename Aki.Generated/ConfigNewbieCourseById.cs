using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E7 RID: 1511
	public class ConfigNewbieCourseById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002379 RID: 9081 RVA: 0x001221D7 File Offset: 0x001203D7
		static ConfigNewbieCourseById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCourseById.CreateStaticDefaultValue), new Action(ConfigNewbieCourseById.ResetStaticDefaultValue));
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x001221F8 File Offset: 0x001203F8
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieCourseById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieCourseById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newbiecourse.db"),
				new ValueTuple<string, object>("文件", "x.新手历程活动.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieCourse"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieCourse` where Id=?")
			});
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x00122277 File Offset: 0x00120477
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCourseById.LogPair = null;
			ConfigNewbieCourseById.HandleId = 0;
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x00122285 File Offset: 0x00120485
		public static void Init()
		{
			ConfigNewbieCourseById.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCourseById.HandleId, "db_newbiecourse.db", "select BinData from `NewbieCourse` where Id=?");
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x001222A0 File Offset: 0x001204A0
		public static NewbieCourse? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieCourseById.HandleId, ConfigNewbieCourseById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCourseById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewbieCourse?(NewbieCourse.GetRootAsNewbieCourse(configBuffer));
				}
			}
			ConfigNewbieCourseById.LogPair.Clear();
			ConfigNewbieCourseById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewbieCourseById.HandleId, 1, p0Id, ConfigNewbieCourseById.LogPair) || ConfigCommon.Step(ConfigNewbieCourseById.HandleId, true, ConfigNewbieCourseById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewbieCourseById.HandleId, ConfigNewbieCourseById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieCourseById.HandleId, 0, ConfigNewbieCourseById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewbieCourseById.HandleId, ConfigNewbieCourseById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewbieCourse rootAsNewbieCourse = NewbieCourse.GetRootAsNewbieCourse(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCourseById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewbieCourseById.HandleId, ConfigNewbieCourseById.LogPair);
			return new NewbieCourse?(rootAsNewbieCourse);
		}

		// Token: 0x04002937 RID: 10551
		private const string DB = "db_newbiecourse.db";

		// Token: 0x04002938 RID: 10552
		private const string FILE = "x.新手历程活动.xlsx";

		// Token: 0x04002939 RID: 10553
		private const string TABLE = "NewbieCourse";

		// Token: 0x0400293A RID: 10554
		private const string COMMAND = "select BinData from `NewbieCourse` where Id=?";

		// Token: 0x0400293B RID: 10555
		private const string KEY_PREFIX = "NewbieCourseById";

		// Token: 0x0400293C RID: 10556
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400293D RID: 10557
		private static int HandleId;
	}
}
