using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200004A RID: 74
	public class ConfigActivityLinkageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001BC RID: 444 RVA: 0x0006700C File Offset: 0x0006520C
		static ConfigActivityLinkageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityLinkageById.CreateStaticDefaultValue), new Action(ConfigActivityLinkageById.ResetStaticDefaultValue));
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0006702C File Offset: 0x0006522C
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityLinkageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityLinkageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitylinkage.db"),
				new ValueTuple<string, object>("文件", "h.活动联动页活动.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityLinkage"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityLinkage` where Id=?")
			});
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000670AB File Offset: 0x000652AB
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityLinkageById.LogPair = null;
			ConfigActivityLinkageById.HandleId = 0;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000670B9 File Offset: 0x000652B9
		public static void Init()
		{
			ConfigActivityLinkageById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityLinkageById.HandleId, "db_activitylinkage.db", "select BinData from `ActivityLinkage` where Id=?");
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000670D4 File Offset: 0x000652D4
		public static ActivityLinkage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityLinkageById.HandleId, ConfigActivityLinkageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityLinkageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityLinkage?(ActivityLinkage.GetRootAsActivityLinkage(configBuffer));
				}
			}
			ConfigActivityLinkageById.LogPair.Clear();
			ConfigActivityLinkageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityLinkageById.HandleId, 1, p0Id, ConfigActivityLinkageById.LogPair) || ConfigCommon.Step(ConfigActivityLinkageById.HandleId, true, ConfigActivityLinkageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityLinkageById.HandleId, ConfigActivityLinkageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityLinkageById.HandleId, 0, ConfigActivityLinkageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityLinkageById.HandleId, ConfigActivityLinkageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityLinkage rootAsActivityLinkage = ActivityLinkage.GetRootAsActivityLinkage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityLinkageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityLinkageById.HandleId, ConfigActivityLinkageById.LogPair);
			return new ActivityLinkage?(rootAsActivityLinkage);
		}

		// Token: 0x040001EA RID: 490
		private const string DB = "db_activitylinkage.db";

		// Token: 0x040001EB RID: 491
		private const string FILE = "h.活动联动页活动.xlsx";

		// Token: 0x040001EC RID: 492
		private const string TABLE = "ActivityLinkage";

		// Token: 0x040001ED RID: 493
		private const string COMMAND = "select BinData from `ActivityLinkage` where Id=?";

		// Token: 0x040001EE RID: 494
		private const string KEY_PREFIX = "ActivityLinkageById";

		// Token: 0x040001EF RID: 495
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001F0 RID: 496
		private static int HandleId;
	}
}
