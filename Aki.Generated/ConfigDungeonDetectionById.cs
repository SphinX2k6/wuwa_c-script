using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000243 RID: 579
	public class ConfigDungeonDetectionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D96 RID: 3478 RVA: 0x000A6558 File Offset: 0x000A4758
		static ConfigDungeonDetectionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDungeonDetectionById.CreateStaticDefaultValue), new Action(ConfigDungeonDetectionById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x000A6578 File Offset: 0x000A4778
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

		// Token: 0x06000D98 RID: 3480 RVA: 0x000A65F7 File Offset: 0x000A47F7
		public static void ResetStaticDefaultValue()
		{
			ConfigDungeonDetectionById.LogPair = null;
			ConfigDungeonDetectionById.HandleId = 0;
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x000A6605 File Offset: 0x000A4805
		public static void Init()
		{
			ConfigDungeonDetectionById.HandleId = ConfigCommon.InitDataStatement(ConfigDungeonDetectionById.HandleId, "db_adventure_detect.db", "select BinData from `DungeonDetection` where Id=?");
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x000A6620 File Offset: 0x000A4820
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

		// Token: 0x04000FB9 RID: 4025
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04000FBA RID: 4026
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04000FBB RID: 4027
		private const string TABLE = "DungeonDetection";

		// Token: 0x04000FBC RID: 4028
		private const string COMMAND = "select BinData from `DungeonDetection` where Id=?";

		// Token: 0x04000FBD RID: 4029
		private const string KEY_PREFIX = "DungeonDetectionById";

		// Token: 0x04000FBE RID: 4030
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FBF RID: 4031
		private static int HandleId;
	}
}
