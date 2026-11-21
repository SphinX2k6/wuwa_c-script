using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000058 RID: 88
	public class ConfigActivitySignById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000210 RID: 528 RVA: 0x00068DC4 File Offset: 0x00066FC4
		static ConfigActivitySignById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivitySignById.CreateStaticDefaultValue), new Action(ConfigActivitySignById.ResetStaticDefaultValue));
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00068DE4 File Offset: 0x00066FE4
		public static void CreateStaticDefaultValue()
		{
			ConfigActivitySignById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivitySignById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sevendaysign.db"),
				new ValueTuple<string, object>("文件", "q.七天签到.xlsx"),
				new ValueTuple<string, object>("表名", "ActivitySign"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivitySign` where Id=?")
			});
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00068E63 File Offset: 0x00067063
		public static void ResetStaticDefaultValue()
		{
			ConfigActivitySignById.LogPair = null;
			ConfigActivitySignById.HandleId = 0;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00068E71 File Offset: 0x00067071
		public static void Init()
		{
			ConfigActivitySignById.HandleId = ConfigCommon.InitDataStatement(ConfigActivitySignById.HandleId, "db_sevendaysign.db", "select BinData from `ActivitySign` where Id=?");
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00068E8C File Offset: 0x0006708C
		public static ActivitySign? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivitySignById.HandleId, ConfigActivitySignById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivitySignById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ActivitySign?(ActivitySign.GetRootAsActivitySign(configBuffer));
				}
			}
			ConfigActivitySignById.LogPair.Clear();
			ConfigActivitySignById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigActivitySignById.HandleId, 1, p0Id, ConfigActivitySignById.LogPair) || ConfigCommon.Step(ConfigActivitySignById.HandleId, true, ConfigActivitySignById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigActivitySignById.HandleId, ConfigActivitySignById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivitySignById.HandleId, 0, ConfigActivitySignById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigActivitySignById.HandleId, ConfigActivitySignById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ActivitySign rootAsActivitySign = ActivitySign.GetRootAsActivitySign(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ActivitySignById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigActivitySignById.HandleId, ConfigActivitySignById.LogPair);
			return new ActivitySign?(rootAsActivitySign);
		}

		// Token: 0x0400024C RID: 588
		private const string DB = "db_sevendaysign.db";

		// Token: 0x0400024D RID: 589
		private const string FILE = "q.七天签到.xlsx";

		// Token: 0x0400024E RID: 590
		private const string TABLE = "ActivitySign";

		// Token: 0x0400024F RID: 591
		private const string COMMAND = "select BinData from `ActivitySign` where Id=?";

		// Token: 0x04000250 RID: 592
		private const string KEY_PREFIX = "ActivitySignById";

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
