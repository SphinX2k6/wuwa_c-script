using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002FA RID: 762
	public class ConfigFishingPortById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011E1 RID: 4577 RVA: 0x000C214F File Offset: 0x000C034F
		static ConfigFishingPortById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingPortById.CreateStaticDefaultValue), new Action(ConfigFishingPortById.ResetStaticDefaultValue));
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x000C2170 File Offset: 0x000C0370
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingPortById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingPortById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishing.db"),
				new ValueTuple<string, object>("文件", "b.捕鱼船坞.xlsx"),
				new ValueTuple<string, object>("表名", "FishingPort"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingPort` where Id=?")
			});
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x000C21EF File Offset: 0x000C03EF
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingPortById.LogPair = null;
			ConfigFishingPortById.HandleId = 0;
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x000C21FD File Offset: 0x000C03FD
		public static void Init()
		{
			ConfigFishingPortById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingPortById.HandleId, "db_fishing.db", "select BinData from `FishingPort` where Id=?");
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x000C2218 File Offset: 0x000C0418
		public static FishingPort? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingPortById.HandleId, ConfigFishingPortById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingPortById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingPort?(FishingPort.GetRootAsFishingPort(configBuffer));
				}
			}
			ConfigFishingPortById.LogPair.Clear();
			ConfigFishingPortById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingPortById.HandleId, 1, p0Id, ConfigFishingPortById.LogPair) || ConfigCommon.Step(ConfigFishingPortById.HandleId, true, ConfigFishingPortById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingPortById.HandleId, ConfigFishingPortById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingPortById.HandleId, 0, ConfigFishingPortById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingPortById.HandleId, ConfigFishingPortById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingPort rootAsFishingPort = FishingPort.GetRootAsFishingPort(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingPortById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingPortById.HandleId, ConfigFishingPortById.LogPair);
			return new FishingPort?(rootAsFishingPort);
		}

		// Token: 0x040014BA RID: 5306
		private const string DB = "db_fishing.db";

		// Token: 0x040014BB RID: 5307
		private const string FILE = "b.捕鱼船坞.xlsx";

		// Token: 0x040014BC RID: 5308
		private const string TABLE = "FishingPort";

		// Token: 0x040014BD RID: 5309
		private const string COMMAND = "select BinData from `FishingPort` where Id=?";

		// Token: 0x040014BE RID: 5310
		private const string KEY_PREFIX = "FishingPortById";

		// Token: 0x040014BF RID: 5311
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014C0 RID: 5312
		private static int HandleId;
	}
}
