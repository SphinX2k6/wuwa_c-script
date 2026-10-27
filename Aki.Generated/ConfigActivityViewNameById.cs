using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000058 RID: 88
	public class ConfigActivityViewNameById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000210 RID: 528 RVA: 0x000655E8 File Offset: 0x000637E8
		static ConfigActivityViewNameById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityViewNameById.CreateStaticDefaultValue), new Action(ConfigActivityViewNameById.ResetStaticDefaultValue));
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00065608 File Offset: 0x00063808
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityViewNameById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityViewNameById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activity.db"),
				new ValueTuple<string, object>("文件", "h.活动.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityViewName"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityViewName` where Id=?")
			});
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00065687 File Offset: 0x00063887
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityViewNameById.LogPair = null;
			ConfigActivityViewNameById.HandleId = 0;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00065695 File Offset: 0x00063895
		public static void Init()
		{
			ConfigActivityViewNameById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityViewNameById.HandleId, "db_activity.db", "select BinData from `ActivityViewName` where Id=?");
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000656B0 File Offset: 0x000638B0
		public static ActivityViewName? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityViewNameById.HandleId, ConfigActivityViewNameById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityViewNameById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityViewName?(ActivityViewName.GetRootAsActivityViewName(configBuffer));
				}
			}
			ConfigActivityViewNameById.LogPair.Clear();
			ConfigActivityViewNameById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityViewNameById.HandleId, 1, p0Id, ConfigActivityViewNameById.LogPair) || ConfigCommon.Step(ConfigActivityViewNameById.HandleId, true, ConfigActivityViewNameById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityViewNameById.HandleId, ConfigActivityViewNameById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityViewNameById.HandleId, 0, ConfigActivityViewNameById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityViewNameById.HandleId, ConfigActivityViewNameById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityViewName rootAsActivityViewName = ActivityViewName.GetRootAsActivityViewName(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityViewNameById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityViewNameById.HandleId, ConfigActivityViewNameById.LogPair);
			return new ActivityViewName?(rootAsActivityViewName);
		}

		// Token: 0x0400024C RID: 588
		private const string DB = "db_activity.db";

		// Token: 0x0400024D RID: 589
		private const string FILE = "h.活动.xlsx";

		// Token: 0x0400024E RID: 590
		private const string TABLE = "ActivityViewName";

		// Token: 0x0400024F RID: 591
		private const string COMMAND = "select BinData from `ActivityViewName` where Id=?";

		// Token: 0x04000250 RID: 592
		private const string KEY_PREFIX = "ActivityViewNameById";

		// Token: 0x04000251 RID: 593
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000252 RID: 594
		private static int HandleId;
	}
}
