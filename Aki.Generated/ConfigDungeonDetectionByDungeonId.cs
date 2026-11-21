using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000256 RID: 598
	public class ConfigDungeonDetectionByDungeonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E08 RID: 3592 RVA: 0x000AC5D3 File Offset: 0x000AA7D3
		static ConfigDungeonDetectionByDungeonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDungeonDetectionByDungeonId.CreateStaticDefaultValue), new Action(ConfigDungeonDetectionByDungeonId.ResetStaticDefaultValue));
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x000AC5F4 File Offset: 0x000AA7F4
		public static void CreateStaticDefaultValue()
		{
			ConfigDungeonDetectionByDungeonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDungeonDetectionByDungeonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "DungeonDetection"),
				new ValueTuple<string, object>("语句", "select BinData from `DungeonDetection` where DungeonId=?")
			});
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x000AC673 File Offset: 0x000AA873
		public static void ResetStaticDefaultValue()
		{
			ConfigDungeonDetectionByDungeonId.LogPair = null;
			ConfigDungeonDetectionByDungeonId.HandleId = 0;
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x000AC681 File Offset: 0x000AA881
		public static void Init()
		{
			ConfigDungeonDetectionByDungeonId.HandleId = ConfigCommon.InitDataStatement(ConfigDungeonDetectionByDungeonId.HandleId, "db_adventure_detect.db", "select BinData from `DungeonDetection` where DungeonId=?");
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x000AC69C File Offset: 0x000AA89C
		public static DungeonDetection? GetConfig(int p0DungeonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDungeonDetectionByDungeonId.HandleId, ConfigDungeonDetectionByDungeonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DungeonDetectionByDungeonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DungeonId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DungeonDetection?(DungeonDetection.GetRootAsDungeonDetection(configBuffer));
				}
			}
			ConfigDungeonDetectionByDungeonId.LogPair.Clear();
			ConfigDungeonDetectionByDungeonId.LogPair.Add(new ValueTuple<string, object>("DungeonId", p0DungeonId));
			if (!ConfigCommon.BindInt(ConfigDungeonDetectionByDungeonId.HandleId, 1, p0DungeonId, ConfigDungeonDetectionByDungeonId.LogPair) || ConfigCommon.Step(ConfigDungeonDetectionByDungeonId.HandleId, true, ConfigDungeonDetectionByDungeonId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDungeonDetectionByDungeonId.HandleId, ConfigDungeonDetectionByDungeonId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDungeonDetectionByDungeonId.HandleId, 0, ConfigDungeonDetectionByDungeonId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDungeonDetectionByDungeonId.HandleId, ConfigDungeonDetectionByDungeonId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DungeonDetection rootAsDungeonDetection = DungeonDetection.GetRootAsDungeonDetection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DungeonDetectionByDungeonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DungeonId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDungeonDetectionByDungeonId.HandleId, ConfigDungeonDetectionByDungeonId.LogPair);
			return new DungeonDetection?(rootAsDungeonDetection);
		}

		// Token: 0x0400103E RID: 4158
		private const string DB = "db_adventure_detect.db";

		// Token: 0x0400103F RID: 4159
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04001040 RID: 4160
		private const string TABLE = "DungeonDetection";

		// Token: 0x04001041 RID: 4161
		private const string COMMAND = "select BinData from `DungeonDetection` where DungeonId=?";

		// Token: 0x04001042 RID: 4162
		private const string KEY_PREFIX = "DungeonDetectionByDungeonId";

		// Token: 0x04001043 RID: 4163
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001044 RID: 4164
		private static int HandleId;
	}
}
