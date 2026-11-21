using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000257 RID: 599
	public class ConfigDungeonDetectionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E0E RID: 3598 RVA: 0x000AC81C File Offset: 0x000AAA1C
		static ConfigDungeonDetectionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDungeonDetectionById.CreateStaticDefaultValue), new Action(ConfigDungeonDetectionById.ResetStaticDefaultValue));
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x000AC83C File Offset: 0x000AAA3C
		public static void CreateStaticDefaultValue()
		{
			ConfigDungeonDetectionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDungeonDetectionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "DungeonDetection"),
				new ValueTuple<string, object>("语句", "select BinData from `DungeonDetection` where Id=?")
			});
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x000AC8BB File Offset: 0x000AAABB
		public static void ResetStaticDefaultValue()
		{
			ConfigDungeonDetectionById.LogPair = null;
			ConfigDungeonDetectionById.HandleId = 0;
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x000AC8C9 File Offset: 0x000AAAC9
		public static void Init()
		{
			ConfigDungeonDetectionById.HandleId = ConfigCommon.InitDataStatement(ConfigDungeonDetectionById.HandleId, "db_adventure_detect.db", "select BinData from `DungeonDetection` where Id=?");
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x000AC8E4 File Offset: 0x000AAAE4
		public static DungeonDetection? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDungeonDetectionById.HandleId, ConfigDungeonDetectionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DungeonDetectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DungeonDetection?(DungeonDetection.GetRootAsDungeonDetection(configBuffer));
				}
			}
			ConfigDungeonDetectionById.LogPair.Clear();
			ConfigDungeonDetectionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDungeonDetectionById.HandleId, 1, p0Id, ConfigDungeonDetectionById.LogPair) || ConfigCommon.Step(ConfigDungeonDetectionById.HandleId, true, ConfigDungeonDetectionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDungeonDetectionById.HandleId, ConfigDungeonDetectionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDungeonDetectionById.HandleId, 0, ConfigDungeonDetectionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDungeonDetectionById.HandleId, ConfigDungeonDetectionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DungeonDetection rootAsDungeonDetection = DungeonDetection.GetRootAsDungeonDetection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DungeonDetectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDungeonDetectionById.HandleId, ConfigDungeonDetectionById.LogPair);
			return new DungeonDetection?(rootAsDungeonDetection);
		}

		// Token: 0x04001045 RID: 4165
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04001046 RID: 4166
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04001047 RID: 4167
		private const string TABLE = "DungeonDetection";

		// Token: 0x04001048 RID: 4168
		private const string COMMAND = "select BinData from `DungeonDetection` where Id=?";

		// Token: 0x04001049 RID: 4169
		private const string KEY_PREFIX = "DungeonDetectionById";

		// Token: 0x0400104A RID: 4170
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400104B RID: 4171
		private static int HandleId;
	}
}
