using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005FD RID: 1533
	public class ConfigNewbieCarnivalTaskTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023FD RID: 9213 RVA: 0x00128877 File Offset: 0x00126A77
		static ConfigNewbieCarnivalTaskTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieCarnivalTaskTypeById.CreateStaticDefaultValue), new Action(ConfigNewbieCarnivalTaskTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x00128898 File Offset: 0x00126A98
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieCarnivalTaskTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieCarnivalTaskTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newbiecarnival.db"),
				new ValueTuple<string, object>("文件", "x.新手嘉年华.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieCarnivalTaskType"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieCarnivalTaskType` where Id=?")
			});
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x00128917 File Offset: 0x00126B17
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieCarnivalTaskTypeById.LogPair = null;
			ConfigNewbieCarnivalTaskTypeById.HandleId = 0;
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x00128925 File Offset: 0x00126B25
		public static void Init()
		{
			ConfigNewbieCarnivalTaskTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieCarnivalTaskTypeById.HandleId, "db_newbiecarnival.db", "select BinData from `NewbieCarnivalTaskType` where Id=?");
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x00128940 File Offset: 0x00126B40
		public static NewbieCarnivalTaskType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieCarnivalTaskTypeById.HandleId, ConfigNewbieCarnivalTaskTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalTaskTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewbieCarnivalTaskType?(NewbieCarnivalTaskType.GetRootAsNewbieCarnivalTaskType(configBuffer));
				}
			}
			ConfigNewbieCarnivalTaskTypeById.LogPair.Clear();
			ConfigNewbieCarnivalTaskTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewbieCarnivalTaskTypeById.HandleId, 1, p0Id, ConfigNewbieCarnivalTaskTypeById.LogPair) || ConfigCommon.Step(ConfigNewbieCarnivalTaskTypeById.HandleId, true, ConfigNewbieCarnivalTaskTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewbieCarnivalTaskTypeById.HandleId, ConfigNewbieCarnivalTaskTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieCarnivalTaskTypeById.HandleId, 0, ConfigNewbieCarnivalTaskTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewbieCarnivalTaskTypeById.HandleId, ConfigNewbieCarnivalTaskTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewbieCarnivalTaskType rootAsNewbieCarnivalTaskType = NewbieCarnivalTaskType.GetRootAsNewbieCarnivalTaskType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieCarnivalTaskTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewbieCarnivalTaskTypeById.HandleId, ConfigNewbieCarnivalTaskTypeById.LogPair);
			return new NewbieCarnivalTaskType?(rootAsNewbieCarnivalTaskType);
		}

		// Token: 0x040029D1 RID: 10705
		private const string DB = "db_newbiecarnival.db";

		// Token: 0x040029D2 RID: 10706
		private const string FILE = "x.新手嘉年华.xlsx";

		// Token: 0x040029D3 RID: 10707
		private const string TABLE = "NewbieCarnivalTaskType";

		// Token: 0x040029D4 RID: 10708
		private const string COMMAND = "select BinData from `NewbieCarnivalTaskType` where Id=?";

		// Token: 0x040029D5 RID: 10709
		private const string KEY_PREFIX = "NewbieCarnivalTaskTypeById";

		// Token: 0x040029D6 RID: 10710
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029D7 RID: 10711
		private static int HandleId;
	}
}
