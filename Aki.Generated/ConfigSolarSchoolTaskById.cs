using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A2F RID: 2607
	public class ConfigSolarSchoolTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D2E RID: 15662 RVA: 0x001B66FB File Offset: 0x001B48FB
		static ConfigSolarSchoolTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolTaskById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x001B671C File Offset: 0x001B491C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolTask"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolTask` where Id=?")
			});
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x001B679B File Offset: 0x001B499B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolTaskById.LogPair = null;
			ConfigSolarSchoolTaskById.HandleId = 0;
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x001B67A9 File Offset: 0x001B49A9
		public static void Init()
		{
			ConfigSolarSchoolTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolTaskById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolTask` where Id=?");
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x001B67C4 File Offset: 0x001B49C4
		public static SolarSchoolTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolTaskById.HandleId, ConfigSolarSchoolTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolTask?(SolarSchoolTask.GetRootAsSolarSchoolTask(configBuffer));
				}
			}
			ConfigSolarSchoolTaskById.LogPair.Clear();
			ConfigSolarSchoolTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolTaskById.HandleId, 1, p0Id, ConfigSolarSchoolTaskById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolTaskById.HandleId, true, ConfigSolarSchoolTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolTaskById.HandleId, ConfigSolarSchoolTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolTaskById.HandleId, 0, ConfigSolarSchoolTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolTaskById.HandleId, ConfigSolarSchoolTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolTask rootAsSolarSchoolTask = SolarSchoolTask.GetRootAsSolarSchoolTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolTaskById.HandleId, ConfigSolarSchoolTaskById.LogPair);
			return new SolarSchoolTask?(rootAsSolarSchoolTask);
		}

		// Token: 0x0400472F RID: 18223
		private const string DB = "db_solarschool.db";

		// Token: 0x04004730 RID: 18224
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x04004731 RID: 18225
		private const string TABLE = "SolarSchoolTask";

		// Token: 0x04004732 RID: 18226
		private const string COMMAND = "select BinData from `SolarSchoolTask` where Id=?";

		// Token: 0x04004733 RID: 18227
		private const string KEY_PREFIX = "SolarSchoolTaskById";

		// Token: 0x04004734 RID: 18228
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004735 RID: 18229
		private static int HandleId;
	}
}
