using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200098F RID: 2447
	public class ConfigStateByStateId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600396E RID: 14702 RVA: 0x0019E3EC File Offset: 0x0019C5EC
		static ConfigStateByStateId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigStateByStateId.CreateStaticDefaultValue), new Action(ConfigStateByStateId.ResetStaticDefaultValue));
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x0019E40C File Offset: 0x0019C60C
		public static void CreateStaticDefaultValue()
		{
			ConfigStateByStateId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigStateByStateId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_area.db"),
				new ValueTuple<string, object>("文件", "q.区域.xlsx"),
				new ValueTuple<string, object>("表名", "State"),
				new ValueTuple<string, object>("语句", "select BinData from `State` where StateId = ?")
			});
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x0019E48B File Offset: 0x0019C68B
		public static void ResetStaticDefaultValue()
		{
			ConfigStateByStateId.LogPair = null;
			ConfigStateByStateId.HandleId = 0;
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x0019E499 File Offset: 0x0019C699
		public static void Init()
		{
			ConfigStateByStateId.HandleId = ConfigCommon.InitDataStatement(ConfigStateByStateId.HandleId, "db_area.db", "select BinData from `State` where StateId = ?");
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x0019E4B4 File Offset: 0x0019C6B4
		public static State? GetConfig(int p0StateId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigStateByStateId.HandleId, ConfigStateByStateId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("StateByStateId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0StateId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new State?(State.GetRootAsState(configBuffer));
				}
			}
			ConfigStateByStateId.LogPair.Clear();
			ConfigStateByStateId.LogPair.Add(new ValueTuple<string, object>("StateId", p0StateId));
			if (!ConfigCommon.BindInt(ConfigStateByStateId.HandleId, 1, p0StateId, ConfigStateByStateId.LogPair) || ConfigCommon.Step(ConfigStateByStateId.HandleId, true, ConfigStateByStateId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigStateByStateId.HandleId, ConfigStateByStateId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigStateByStateId.HandleId, 0, ConfigStateByStateId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigStateByStateId.HandleId, ConfigStateByStateId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			State rootAsState = State.GetRootAsState(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("StateByStateId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0StateId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigStateByStateId.HandleId, ConfigStateByStateId.LogPair);
			return new State?(rootAsState);
		}

		// Token: 0x040042CF RID: 17103
		private const string DB = "db_area.db";

		// Token: 0x040042D0 RID: 17104
		private const string FILE = "q.区域.xlsx";

		// Token: 0x040042D1 RID: 17105
		private const string TABLE = "State";

		// Token: 0x040042D2 RID: 17106
		private const string COMMAND = "select BinData from `State` where StateId = ?";

		// Token: 0x040042D3 RID: 17107
		private const string KEY_PREFIX = "StateByStateId";

		// Token: 0x040042D4 RID: 17108
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042D5 RID: 17109
		private static int HandleId;
	}
}
