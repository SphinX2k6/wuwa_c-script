using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000245 RID: 581
	public class ConfigDungeonPackInfoByDungeonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DA2 RID: 3490 RVA: 0x000A6933 File Offset: 0x000A4B33
		static ConfigDungeonPackInfoByDungeonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDungeonPackInfoByDungeonId.CreateStaticDefaultValue), new Action(ConfigDungeonPackInfoByDungeonId.ResetStaticDefaultValue));
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x000A6954 File Offset: 0x000A4B54
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

		// Token: 0x06000DA4 RID: 3492 RVA: 0x000A69D3 File Offset: 0x000A4BD3
		public static void ResetStaticDefaultValue()
		{
			ConfigDungeonPackInfoByDungeonId.LogPair = null;
			ConfigDungeonPackInfoByDungeonId.HandleId = 0;
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x000A69E1 File Offset: 0x000A4BE1
		public static void Init()
		{
			ConfigDungeonPackInfoByDungeonId.HandleId = ConfigCommon.InitDataStatement(ConfigDungeonPackInfoByDungeonId.HandleId, "db_dungeonpackinfo.db", "select BinData from `DungeonPackInfo` where DungeonId=?");
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x000A69FC File Offset: 0x000A4BFC
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

		// Token: 0x04000FC7 RID: 4039
		private const string DB = "db_dungeonpackinfo.db";

		// Token: 0x04000FC8 RID: 4040
		private const string FILE = "UniverseEditor/QuestRefMapBlockConfig/DungeonPackInfo.csv";

		// Token: 0x04000FC9 RID: 4041
		private const string TABLE = "DungeonPackInfo";

		// Token: 0x04000FCA RID: 4042
		private const string COMMAND = "select BinData from `DungeonPackInfo` where DungeonId=?";

		// Token: 0x04000FCB RID: 4043
		private const string KEY_PREFIX = "DungeonPackInfoByDungeonId";

		// Token: 0x04000FCC RID: 4044
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FCD RID: 4045
		private static int HandleId;
	}
}
