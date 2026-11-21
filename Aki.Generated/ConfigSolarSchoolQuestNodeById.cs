using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A05 RID: 2565
	public class ConfigSolarSchoolQuestNodeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C32 RID: 15410 RVA: 0x001B108F File Offset: 0x001AF28F
		static ConfigSolarSchoolQuestNodeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolQuestNodeById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolQuestNodeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C33 RID: 15411 RVA: 0x001B10B0 File Offset: 0x001AF2B0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolQuestNodeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolQuestNodeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_任务.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolQuestNode"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolQuestNode` where Id=?")
			});
		}

		// Token: 0x06003C34 RID: 15412 RVA: 0x001B112F File Offset: 0x001AF32F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolQuestNodeById.LogPair = null;
			ConfigSolarSchoolQuestNodeById.HandleId = 0;
		}

		// Token: 0x06003C35 RID: 15413 RVA: 0x001B113D File Offset: 0x001AF33D
		public static void Init()
		{
			ConfigSolarSchoolQuestNodeById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolQuestNodeById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolQuestNode` where Id=?");
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x001B1158 File Offset: 0x001AF358
		public static SolarSchoolQuestNode? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolQuestNodeById.HandleId, ConfigSolarSchoolQuestNodeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolQuestNodeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolQuestNode?(SolarSchoolQuestNode.GetRootAsSolarSchoolQuestNode(configBuffer));
				}
			}
			ConfigSolarSchoolQuestNodeById.LogPair.Clear();
			ConfigSolarSchoolQuestNodeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolQuestNodeById.HandleId, 1, p0Id, ConfigSolarSchoolQuestNodeById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolQuestNodeById.HandleId, true, ConfigSolarSchoolQuestNodeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolQuestNodeById.HandleId, ConfigSolarSchoolQuestNodeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolQuestNodeById.HandleId, 0, ConfigSolarSchoolQuestNodeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolQuestNodeById.HandleId, ConfigSolarSchoolQuestNodeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolQuestNode rootAsSolarSchoolQuestNode = SolarSchoolQuestNode.GetRootAsSolarSchoolQuestNode(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolQuestNodeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolQuestNodeById.HandleId, ConfigSolarSchoolQuestNodeById.LogPair);
			return new SolarSchoolQuestNode?(rootAsSolarSchoolQuestNode);
		}

		// Token: 0x04004609 RID: 17929
		private const string DB = "db_solarschool.db";

		// Token: 0x0400460A RID: 17930
		private const string FILE = "d.第二索拉_任务.xlsx";

		// Token: 0x0400460B RID: 17931
		private const string TABLE = "SolarSchoolQuestNode";

		// Token: 0x0400460C RID: 17932
		private const string COMMAND = "select BinData from `SolarSchoolQuestNode` where Id=?";

		// Token: 0x0400460D RID: 17933
		private const string KEY_PREFIX = "SolarSchoolQuestNodeById";

		// Token: 0x0400460E RID: 17934
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400460F RID: 17935
		private static int HandleId;
	}
}
