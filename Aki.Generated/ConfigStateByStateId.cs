using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A64 RID: 2660
	public class ConfigStateByStateId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E6C RID: 15980 RVA: 0x001BD780 File Offset: 0x001BB980
		static ConfigStateByStateId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigStateByStateId.CreateStaticDefaultValue), new Action(ConfigStateByStateId.ResetStaticDefaultValue));
		}

		// Token: 0x06003E6D RID: 15981 RVA: 0x001BD7A0 File Offset: 0x001BB9A0
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

		// Token: 0x06003E6E RID: 15982 RVA: 0x001BD81F File Offset: 0x001BBA1F
		public static void ResetStaticDefaultValue()
		{
			ConfigStateByStateId.LogPair = null;
			ConfigStateByStateId.HandleId = 0;
		}

		// Token: 0x06003E6F RID: 15983 RVA: 0x001BD82D File Offset: 0x001BBA2D
		public static void Init()
		{
			ConfigStateByStateId.HandleId = ConfigCommon.InitDataStatement(ConfigStateByStateId.HandleId, "db_area.db", "select BinData from `State` where StateId = ?");
		}

		// Token: 0x06003E70 RID: 15984 RVA: 0x001BD848 File Offset: 0x001BBA48
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

		// Token: 0x040048A2 RID: 18594
		private const string DB = "db_area.db";

		// Token: 0x040048A3 RID: 18595
		private const string FILE = "q.区域.xlsx";

		// Token: 0x040048A4 RID: 18596
		private const string TABLE = "State";

		// Token: 0x040048A5 RID: 18597
		private const string COMMAND = "select BinData from `State` where StateId = ?";

		// Token: 0x040048A6 RID: 18598
		private const string KEY_PREFIX = "StateByStateId";

		// Token: 0x040048A7 RID: 18599
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048A8 RID: 18600
		private static int HandleId;
	}
}
