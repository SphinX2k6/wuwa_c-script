using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000040 RID: 64
	public class ConfigActivityActionClientTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000180 RID: 384 RVA: 0x00065B68 File Offset: 0x00063D68
		static ConfigActivityActionClientTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityActionClientTypeById.CreateStaticDefaultValue), new Action(ConfigActivityActionClientTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00065B88 File Offset: 0x00063D88
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityActionClientTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityActionClientTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activityaction.db"),
				new ValueTuple<string, object>("文件", "h.活动Action.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityActionClientType"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityActionClientType` where Id=?")
			});
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00065C07 File Offset: 0x00063E07
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityActionClientTypeById.LogPair = null;
			ConfigActivityActionClientTypeById.HandleId = 0;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00065C15 File Offset: 0x00063E15
		public static void Init()
		{
			ConfigActivityActionClientTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigActivityActionClientTypeById.HandleId, "db_activityaction.db", "select BinData from `ActivityActionClientType` where Id=?");
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00065C30 File Offset: 0x00063E30
		public static ActivityActionClientType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityActionClientTypeById.HandleId, ConfigActivityActionClientTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityActionClientTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivityActionClientType?(ActivityActionClientType.GetRootAsActivityActionClientType(configBuffer));
				}
			}
			ConfigActivityActionClientTypeById.LogPair.Clear();
			ConfigActivityActionClientTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivityActionClientTypeById.HandleId, 1, p0Id, ConfigActivityActionClientTypeById.LogPair) || ConfigCommon.Step(ConfigActivityActionClientTypeById.HandleId, true, ConfigActivityActionClientTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivityActionClientTypeById.HandleId, ConfigActivityActionClientTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityActionClientTypeById.HandleId, 0, ConfigActivityActionClientTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivityActionClientTypeById.HandleId, ConfigActivityActionClientTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivityActionClientType rootAsActivityActionClientType = ActivityActionClientType.GetRootAsActivityActionClientType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivityActionClientTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivityActionClientTypeById.HandleId, ConfigActivityActionClientTypeById.LogPair);
			return new ActivityActionClientType?(rootAsActivityActionClientType);
		}

		// Token: 0x040001A4 RID: 420
		private const string DB = "db_activityaction.db";

		// Token: 0x040001A5 RID: 421
		private const string FILE = "h.活动Action.xlsx";

		// Token: 0x040001A6 RID: 422
		private const string TABLE = "ActivityActionClientType";

		// Token: 0x040001A7 RID: 423
		private const string COMMAND = "select BinData from `ActivityActionClientType` where Id=?";

		// Token: 0x040001A8 RID: 424
		private const string KEY_PREFIX = "ActivityActionClientTypeById";

		// Token: 0x040001A9 RID: 425
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001AA RID: 426
		private static int HandleId;
	}
}
