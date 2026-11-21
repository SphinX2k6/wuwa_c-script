using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000832 RID: 2098
	public class ConfigRoadBookPhantomGainById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600313E RID: 12606 RVA: 0x001731AB File Offset: 0x001713AB
		static ConfigRoadBookPhantomGainById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadBookPhantomGainById.CreateStaticDefaultValue), new Action(ConfigRoadBookPhantomGainById.ResetStaticDefaultValue));
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x001731CC File Offset: 0x001713CC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoadBookPhantomGainById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoadBookPhantomGainById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadbook.db"),
				new ValueTuple<string, object>("文件", "q.千岛路书3.0.xlsx"),
				new ValueTuple<string, object>("表名", "RoadBookPhantomGain"),
				new ValueTuple<string, object>("语句", "select BinData from `RoadBookPhantomGain` where Id=?")
			});
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x0017324B File Offset: 0x0017144B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadBookPhantomGainById.LogPair = null;
			ConfigRoadBookPhantomGainById.HandleId = 0;
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x00173259 File Offset: 0x00171459
		public static void Init()
		{
			ConfigRoadBookPhantomGainById.HandleId = ConfigCommon.InitDataStatement(ConfigRoadBookPhantomGainById.HandleId, "db_roadbook.db", "select BinData from `RoadBookPhantomGain` where Id=?");
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x00173274 File Offset: 0x00171474
		public static RoadBookPhantomGain? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoadBookPhantomGainById.HandleId, ConfigRoadBookPhantomGainById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookPhantomGainById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoadBookPhantomGain?(RoadBookPhantomGain.GetRootAsRoadBookPhantomGain(configBuffer));
				}
			}
			ConfigRoadBookPhantomGainById.LogPair.Clear();
			ConfigRoadBookPhantomGainById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoadBookPhantomGainById.HandleId, 1, p0Id, ConfigRoadBookPhantomGainById.LogPair) || ConfigCommon.Step(ConfigRoadBookPhantomGainById.HandleId, true, ConfigRoadBookPhantomGainById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoadBookPhantomGainById.HandleId, ConfigRoadBookPhantomGainById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoadBookPhantomGainById.HandleId, 0, ConfigRoadBookPhantomGainById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoadBookPhantomGainById.HandleId, ConfigRoadBookPhantomGainById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoadBookPhantomGain rootAsRoadBookPhantomGain = RoadBookPhantomGain.GetRootAsRoadBookPhantomGain(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadBookPhantomGainById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoadBookPhantomGainById.HandleId, ConfigRoadBookPhantomGainById.LogPair);
			return new RoadBookPhantomGain?(rootAsRoadBookPhantomGain);
		}

		// Token: 0x04003944 RID: 14660
		private const string DB = "db_roadbook.db";

		// Token: 0x04003945 RID: 14661
		private const string FILE = "q.千岛路书3.0.xlsx";

		// Token: 0x04003946 RID: 14662
		private const string TABLE = "RoadBookPhantomGain";

		// Token: 0x04003947 RID: 14663
		private const string COMMAND = "select BinData from `RoadBookPhantomGain` where Id=?";

		// Token: 0x04003948 RID: 14664
		private const string KEY_PREFIX = "RoadBookPhantomGainById";

		// Token: 0x04003949 RID: 14665
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400394A RID: 14666
		private static int HandleId;
	}
}
