using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000259 RID: 601
	public class ConfigDungeonPackInfoByDungeonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E1A RID: 3610 RVA: 0x000ACBF7 File Offset: 0x000AADF7
		static ConfigDungeonPackInfoByDungeonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDungeonPackInfoByDungeonId.CreateStaticDefaultValue), new Action(ConfigDungeonPackInfoByDungeonId.ResetStaticDefaultValue));
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x000ACC18 File Offset: 0x000AAE18
		public static void CreateStaticDefaultValue()
		{
			ConfigDungeonPackInfoByDungeonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDungeonPackInfoByDungeonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dungeonpackinfo.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/QuestRefMapBlockConfig/DungeonPackInfo.csv"),
				new ValueTuple<string, object>("表名", "DungeonPackInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `DungeonPackInfo` where DungeonId=?")
			});
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x000ACC97 File Offset: 0x000AAE97
		public static void ResetStaticDefaultValue()
		{
			ConfigDungeonPackInfoByDungeonId.LogPair = null;
			ConfigDungeonPackInfoByDungeonId.HandleId = 0;
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x000ACCA5 File Offset: 0x000AAEA5
		public static void Init()
		{
			ConfigDungeonPackInfoByDungeonId.HandleId = ConfigCommon.InitDataStatement(ConfigDungeonPackInfoByDungeonId.HandleId, "db_dungeonpackinfo.db", "select BinData from `DungeonPackInfo` where DungeonId=?");
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x000ACCC0 File Offset: 0x000AAEC0
		public static DungeonPackInfo? GetConfig(int p0DungeonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDungeonPackInfoByDungeonId.HandleId, ConfigDungeonPackInfoByDungeonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DungeonPackInfoByDungeonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DungeonId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DungeonPackInfo?(DungeonPackInfo.GetRootAsDungeonPackInfo(configBuffer));
				}
			}
			ConfigDungeonPackInfoByDungeonId.LogPair.Clear();
			ConfigDungeonPackInfoByDungeonId.LogPair.Add(new ValueTuple<string, object>("DungeonId", p0DungeonId));
			if (!ConfigCommon.BindInt(ConfigDungeonPackInfoByDungeonId.HandleId, 1, p0DungeonId, ConfigDungeonPackInfoByDungeonId.LogPair) || ConfigCommon.Step(ConfigDungeonPackInfoByDungeonId.HandleId, true, ConfigDungeonPackInfoByDungeonId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDungeonPackInfoByDungeonId.HandleId, ConfigDungeonPackInfoByDungeonId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDungeonPackInfoByDungeonId.HandleId, 0, ConfigDungeonPackInfoByDungeonId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDungeonPackInfoByDungeonId.HandleId, ConfigDungeonPackInfoByDungeonId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DungeonPackInfo rootAsDungeonPackInfo = DungeonPackInfo.GetRootAsDungeonPackInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DungeonPackInfoByDungeonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DungeonId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDungeonPackInfoByDungeonId.HandleId, ConfigDungeonPackInfoByDungeonId.LogPair);
			return new DungeonPackInfo?(rootAsDungeonPackInfo);
		}

		// Token: 0x04001053 RID: 4179
		private const string DB = "db_dungeonpackinfo.db";

		// Token: 0x04001054 RID: 4180
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/DungeonPackInfo.csv";

		// Token: 0x04001055 RID: 4181
		private const string TABLE = "DungeonPackInfo";

		// Token: 0x04001056 RID: 4182
		private const string COMMAND = "select BinData from `DungeonPackInfo` where DungeonId=?";

		// Token: 0x04001057 RID: 4183
		private const string KEY_PREFIX = "DungeonPackInfoByDungeonId";

		// Token: 0x04001058 RID: 4184
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001059 RID: 4185
		private static int HandleId;
	}
}
