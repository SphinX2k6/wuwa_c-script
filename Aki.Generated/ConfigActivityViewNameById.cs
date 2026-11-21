using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000060 RID: 96
	public class ConfigActivityViewNameById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000240 RID: 576 RVA: 0x00069E9C File Offset: 0x0006809C
		static ConfigActivityViewNameById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityViewNameById.CreateStaticDefaultValue), new Action(ConfigActivityViewNameById.ResetStaticDefaultValue));
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00069EBC File Offset: 0x000680BC
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

		// Token: 0x06000242 RID: 578 RVA: 0x00069F3B File Offset: 0x0006813B
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityViewNameById.LogPair = null;
			ConfigActivityViewNameById.HandleId = 0;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00069F49 File Offset: 0x00068149
		public static void Init()
		{
			ConfigActivityViewNameById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityViewNameById.HandleId, "db_activity.db", "select BinData from `ActivityViewName` where Id=?");
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00069F64 File Offset: 0x00068164
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

		// Token: 0x04000284 RID: 644
		private const string DB = "db_activity.db";

		// Token: 0x04000285 RID: 645
		private const string FILE = "h.活动.xlsx";

		// Token: 0x04000286 RID: 646
		private const string TABLE = "ActivityViewName";

		// Token: 0x04000287 RID: 647
		private const string COMMAND = "select BinData from `ActivityViewName` where Id=?";

		// Token: 0x04000288 RID: 648
		private const string KEY_PREFIX = "ActivityViewNameById";

		// Token: 0x04000289 RID: 649
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400028A RID: 650
		private static int HandleId;
	}
}
