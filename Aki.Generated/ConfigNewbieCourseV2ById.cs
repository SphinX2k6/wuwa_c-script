using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000601 RID: 1537
	public class ConfigNewbieCourseV2ById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002415 RID: 9237 RVA: 0x0012902F File Offset: 0x0012722F
		static ConfigNewbieCourseV2ById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCourseV2ById.CreateStaticDefaultValue), new Action(ConfigNewbieCourseV2ById.ResetStaticDefaultValue));
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x00129050 File Offset: 0x00127250
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieCourseV2ById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieCourseV2ById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newbiecourse.db"),
				new ValueTuple<string, object>("文件", "x.新手历程活动.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieCourseV2"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieCourseV2` where Id=?")
			});
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x001290CF File Offset: 0x001272CF
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCourseV2ById.LogPair = null;
			ConfigNewbieCourseV2ById.HandleId = 0;
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x001290DD File Offset: 0x001272DD
		public static void Init()
		{
			ConfigNewbieCourseV2ById.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCourseV2ById.HandleId, "db_newbiecourse.db", "select BinData from `NewbieCourseV2` where Id=?");
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x001290F8 File Offset: 0x001272F8
		public static NewbieCourseV2? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieCourseV2ById.HandleId, ConfigNewbieCourseV2ById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCourseV2ById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewbieCourseV2?(NewbieCourseV2.GetRootAsNewbieCourseV2(configBuffer));
				}
			}
			ConfigNewbieCourseV2ById.LogPair.Clear();
			ConfigNewbieCourseV2ById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewbieCourseV2ById.HandleId, 1, p0Id, ConfigNewbieCourseV2ById.LogPair) || ConfigCommon.Step(ConfigNewbieCourseV2ById.HandleId, true, ConfigNewbieCourseV2ById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewbieCourseV2ById.HandleId, ConfigNewbieCourseV2ById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieCourseV2ById.HandleId, 0, ConfigNewbieCourseV2ById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewbieCourseV2ById.HandleId, ConfigNewbieCourseV2ById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewbieCourseV2 rootAsNewbieCourseV = NewbieCourseV2.GetRootAsNewbieCourseV2(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCourseV2ById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewbieCourseV2ById.HandleId, ConfigNewbieCourseV2ById.LogPair);
			return new NewbieCourseV2?(rootAsNewbieCourseV);
		}

		// Token: 0x040029ED RID: 10733
		private const string DB = "db_newbiecourse.db";

		// Token: 0x040029EE RID: 10734
		private const string FILE = "x.新手历程活动.xlsx";

		// Token: 0x040029EF RID: 10735
		private const string TABLE = "NewbieCourseV2";

		// Token: 0x040029F0 RID: 10736
		private const string COMMAND = "select BinData from `NewbieCourseV2` where Id=?";

		// Token: 0x040029F1 RID: 10737
		private const string KEY_PREFIX = "NewbieCourseV2ById";

		// Token: 0x040029F2 RID: 10738
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029F3 RID: 10739
		private static int HandleId;
	}
}
