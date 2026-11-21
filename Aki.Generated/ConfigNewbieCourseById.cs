using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005FF RID: 1535
	public class ConfigNewbieCourseById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002409 RID: 9225 RVA: 0x00128C53 File Offset: 0x00126E53
		static ConfigNewbieCourseById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCourseById.CreateStaticDefaultValue), new Action(ConfigNewbieCourseById.ResetStaticDefaultValue));
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x00128C74 File Offset: 0x00126E74
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

		// Token: 0x0600240B RID: 9227 RVA: 0x00128CF3 File Offset: 0x00126EF3
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCourseById.LogPair = null;
			ConfigNewbieCourseById.HandleId = 0;
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x00128D01 File Offset: 0x00126F01
		public static void Init()
		{
			ConfigNewbieCourseById.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCourseById.HandleId, "db_newbiecourse.db", "select BinData from `NewbieCourse` where Id=?");
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x00128D1C File Offset: 0x00126F1C
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

		// Token: 0x040029DF RID: 10719
		private const string DB = "db_newbiecourse.db";

		// Token: 0x040029E0 RID: 10720
		private const string FILE = "x.新手历程活动.xlsx";

		// Token: 0x040029E1 RID: 10721
		private const string TABLE = "NewbieCourse";

		// Token: 0x040029E2 RID: 10722
		private const string COMMAND = "select BinData from `NewbieCourse` where Id=?";

		// Token: 0x040029E3 RID: 10723
		private const string KEY_PREFIX = "NewbieCourseById";

		// Token: 0x040029E4 RID: 10724
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029E5 RID: 10725
		private static int HandleId;
	}
}
