using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200086D RID: 2157
	public class ConfigRogueTowerById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032A0 RID: 12960 RVA: 0x00177B38 File Offset: 0x00175D38
		static ConfigRogueTowerById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueTowerById.CreateStaticDefaultValue), new Action(ConfigRogueTowerById.ResetStaticDefaultValue));
		}

		// Token: 0x060032A1 RID: 12961 RVA: 0x00177B58 File Offset: 0x00175D58
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueTowerById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueTowerById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽经典复开.xlsx"),
				new ValueTuple<string, object>("表名", "RogueTower"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueTower` where Id=?")
			});
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x00177BD7 File Offset: 0x00175DD7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueTowerById.LogPair = null;
			ConfigRogueTowerById.HandleId = 0;
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x00177BE5 File Offset: 0x00175DE5
		public static void Init()
		{
			ConfigRogueTowerById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueTowerById.HandleId, "db_rogue.db", "select BinData from `RogueTower` where Id=?");
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x00177C00 File Offset: 0x00175E00
		public static RogueTower? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueTowerById.HandleId, ConfigRogueTowerById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueTowerById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueTower?(RogueTower.GetRootAsRogueTower(configBuffer));
				}
			}
			ConfigRogueTowerById.LogPair.Clear();
			ConfigRogueTowerById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueTowerById.HandleId, 1, p0Id, ConfigRogueTowerById.LogPair) || ConfigCommon.Step(ConfigRogueTowerById.HandleId, true, ConfigRogueTowerById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueTowerById.HandleId, ConfigRogueTowerById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueTowerById.HandleId, 0, ConfigRogueTowerById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueTowerById.HandleId, ConfigRogueTowerById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueTower rootAsRogueTower = RogueTower.GetRootAsRogueTower(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueTowerById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueTowerById.HandleId, ConfigRogueTowerById.LogPair);
			return new RogueTower?(rootAsRogueTower);
		}

		// Token: 0x04003AE1 RID: 15073
		private const string DB = "db_rogue.db";

		// Token: 0x04003AE2 RID: 15074
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x04003AE3 RID: 15075
		private const string TABLE = "RogueTower";

		// Token: 0x04003AE4 RID: 15076
		private const string COMMAND = "select BinData from `RogueTower` where Id=?";

		// Token: 0x04003AE5 RID: 15077
		private const string KEY_PREFIX = "RogueTowerById";

		// Token: 0x04003AE6 RID: 15078
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AE7 RID: 15079
		private static int HandleId;
	}
}
