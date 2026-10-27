using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000900 RID: 2304
	public class ConfigSecondaryGuideDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003613 RID: 13843 RVA: 0x0018B04C File Offset: 0x0018924C
		static ConfigSecondaryGuideDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSecondaryGuideDataById.CreateStaticDefaultValue), new Action(ConfigSecondaryGuideDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x0018B06C File Offset: 0x0018926C
		public static void CreateStaticDefaultValue()
		{
			ConfigSecondaryGuideDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSecondaryGuideDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "SecondaryGuideData"),
				new ValueTuple<string, object>("语句", "select BinData from `SecondaryGuideData` where Id=?")
			});
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x0018B0EB File Offset: 0x001892EB
		public static void ResetStaticDefaultValue()
		{
			ConfigSecondaryGuideDataById.LogPair = null;
			ConfigSecondaryGuideDataById.HandleId = 0;
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x0018B0F9 File Offset: 0x001892F9
		public static void Init()
		{
			ConfigSecondaryGuideDataById.HandleId = ConfigCommon.InitDataStatement(ConfigSecondaryGuideDataById.HandleId, "db_adventure_detect.db", "select BinData from `SecondaryGuideData` where Id=?");
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x0018B114 File Offset: 0x00189314
		public static SecondaryGuideData? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSecondaryGuideDataById.HandleId, ConfigSecondaryGuideDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SecondaryGuideDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SecondaryGuideData?(SecondaryGuideData.GetRootAsSecondaryGuideData(configBuffer));
				}
			}
			ConfigSecondaryGuideDataById.LogPair.Clear();
			ConfigSecondaryGuideDataById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSecondaryGuideDataById.HandleId, 1, p0Id, ConfigSecondaryGuideDataById.LogPair) || ConfigCommon.Step(ConfigSecondaryGuideDataById.HandleId, true, ConfigSecondaryGuideDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSecondaryGuideDataById.HandleId, ConfigSecondaryGuideDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSecondaryGuideDataById.HandleId, 0, ConfigSecondaryGuideDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSecondaryGuideDataById.HandleId, ConfigSecondaryGuideDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SecondaryGuideData rootAsSecondaryGuideData = SecondaryGuideData.GetRootAsSecondaryGuideData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SecondaryGuideDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSecondaryGuideDataById.HandleId, ConfigSecondaryGuideDataById.LogPair);
			return new SecondaryGuideData?(rootAsSecondaryGuideData);
		}

		// Token: 0x04003EE6 RID: 16102
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04003EE7 RID: 16103
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04003EE8 RID: 16104
		private const string TABLE = "SecondaryGuideData";

		// Token: 0x04003EE9 RID: 16105
		private const string COMMAND = "select BinData from `SecondaryGuideData` where Id=?";

		// Token: 0x04003EEA RID: 16106
		private const string KEY_PREFIX = "SecondaryGuideDataById";

		// Token: 0x04003EEB RID: 16107
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EEC RID: 16108
		private static int HandleId;
	}
}
