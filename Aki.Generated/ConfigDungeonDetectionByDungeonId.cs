using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000242 RID: 578
	public class ConfigDungeonDetectionByDungeonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D90 RID: 3472 RVA: 0x000A630F File Offset: 0x000A450F
		static ConfigDungeonDetectionByDungeonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDungeonDetectionByDungeonId.CreateStaticDefaultValue), new Action(ConfigDungeonDetectionByDungeonId.ResetStaticDefaultValue));
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x000A6330 File Offset: 0x000A4530
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

		// Token: 0x06000D92 RID: 3474 RVA: 0x000A63AF File Offset: 0x000A45AF
		public static void ResetStaticDefaultValue()
		{
			ConfigDungeonDetectionByDungeonId.LogPair = null;
			ConfigDungeonDetectionByDungeonId.HandleId = 0;
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x000A63BD File Offset: 0x000A45BD
		public static void Init()
		{
			ConfigDungeonDetectionByDungeonId.HandleId = ConfigCommon.InitDataStatement(ConfigDungeonDetectionByDungeonId.HandleId, "db_adventure_detect.db", "select BinData from `DungeonDetection` where DungeonId=?");
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x000A63D8 File Offset: 0x000A45D8
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

		// Token: 0x04000FB2 RID: 4018
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04000FB3 RID: 4019
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04000FB4 RID: 4020
		private const string TABLE = "DungeonDetection";

		// Token: 0x04000FB5 RID: 4021
		private const string COMMAND = "select BinData from `DungeonDetection` where DungeonId=?";

		// Token: 0x04000FB6 RID: 4022
		private const string KEY_PREFIX = "DungeonDetectionByDungeonId";

		// Token: 0x04000FB7 RID: 4023
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FB8 RID: 4024
		private static int HandleId;
	}
}
