using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000889 RID: 2185
	public class ConfigRogueTowerById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003348 RID: 13128 RVA: 0x0017EE20 File Offset: 0x0017D020
		static ConfigRogueTowerById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueTowerById.CreateStaticDefaultValue), new Action(ConfigRogueTowerById.ResetStaticDefaultValue));
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x0017EE40 File Offset: 0x0017D040
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

		// Token: 0x0600334A RID: 13130 RVA: 0x0017EEBF File Offset: 0x0017D0BF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueTowerById.LogPair = null;
			ConfigRogueTowerById.HandleId = 0;
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x0017EECD File Offset: 0x0017D0CD
		public static void Init()
		{
			ConfigRogueTowerById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueTowerById.HandleId, "db_rogue.db", "select BinData from `RogueTower` where Id=?");
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x0017EEE8 File Offset: 0x0017D0E8
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

		// Token: 0x04003BA5 RID: 15269
		private const string DB = "db_rogue.db";

		// Token: 0x04003BA6 RID: 15270
		private const string FILE = "r.肉鸽经典复开.xlsx";

		// Token: 0x04003BA7 RID: 15271
		private const string TABLE = "RogueTower";

		// Token: 0x04003BA8 RID: 15272
		private const string COMMAND = "select BinData from `RogueTower` where Id=?";

		// Token: 0x04003BA9 RID: 15273
		private const string KEY_PREFIX = "RogueTowerById";

		// Token: 0x04003BAA RID: 15274
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BAB RID: 15275
		private static int HandleId;
	}
}
