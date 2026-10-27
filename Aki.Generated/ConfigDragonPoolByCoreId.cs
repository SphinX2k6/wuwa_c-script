using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200021D RID: 541
	public class ConfigDragonPoolByCoreId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CB1 RID: 3249 RVA: 0x000A1413 File Offset: 0x0009F613
		static ConfigDragonPoolByCoreId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDragonPoolByCoreId.CreateStaticDefaultValue), new Action(ConfigDragonPoolByCoreId.ResetStaticDefaultValue));
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x000A1434 File Offset: 0x0009F634
		public static void CreateStaticDefaultValue()
		{
			ConfigDragonPoolByCoreId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDragonPoolByCoreId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dragon_ball.db"),
				new ValueTuple<string, object>("文件", "m.鸣素体.xlsx"),
				new ValueTuple<string, object>("表名", "DragonPool"),
				new ValueTuple<string, object>("语句", "select BinData from `DragonPool` where CoreId=?")
			});
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x000A14B3 File Offset: 0x0009F6B3
		public static void ResetStaticDefaultValue()
		{
			ConfigDragonPoolByCoreId.LogPair = null;
			ConfigDragonPoolByCoreId.HandleId = 0;
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x000A14C1 File Offset: 0x0009F6C1
		public static void Init()
		{
			ConfigDragonPoolByCoreId.HandleId = ConfigCommon.InitDataStatement(ConfigDragonPoolByCoreId.HandleId, "db_dragon_ball.db", "select BinData from `DragonPool` where CoreId=?");
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x000A14DC File Offset: 0x0009F6DC
		public static DragonPool? GetConfig(int p0CoreId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDragonPoolByCoreId.HandleId, ConfigDragonPoolByCoreId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DragonPoolByCoreId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CoreId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DragonPool?(DragonPool.GetRootAsDragonPool(configBuffer));
				}
			}
			ConfigDragonPoolByCoreId.LogPair.Clear();
			ConfigDragonPoolByCoreId.LogPair.Add(new ValueTuple<string, object>("CoreId", p0CoreId));
			if (!ConfigCommon.BindInt(ConfigDragonPoolByCoreId.HandleId, 1, p0CoreId, ConfigDragonPoolByCoreId.LogPair) || ConfigCommon.Step(ConfigDragonPoolByCoreId.HandleId, true, ConfigDragonPoolByCoreId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDragonPoolByCoreId.HandleId, ConfigDragonPoolByCoreId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDragonPoolByCoreId.HandleId, 0, ConfigDragonPoolByCoreId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDragonPoolByCoreId.HandleId, ConfigDragonPoolByCoreId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DragonPool rootAsDragonPool = DragonPool.GetRootAsDragonPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DragonPoolByCoreId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CoreId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDragonPoolByCoreId.HandleId, ConfigDragonPoolByCoreId.LogPair);
			return new DragonPool?(rootAsDragonPool);
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x000A1654 File Offset: 0x0009F854
		[NullableContext(2)]
		public static IReadOnlyList<DragonPool> GetConfigList(int p0CoreId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDragonPoolByCoreId.HandleId, ConfigDragonPoolByCoreId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DragonPoolByCoreId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CoreId);
				IReadOnlyList<DragonPool> readOnlyList = (IReadOnlyList<DragonPool>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigDragonPoolByCoreId.LogPair.Clear();
			ConfigDragonPoolByCoreId.LogPair.Add(new ValueTuple<string, object>("CoreId", p0CoreId));
			if (!ConfigCommon.BindInt(ConfigDragonPoolByCoreId.HandleId, 1, p0CoreId, ConfigDragonPoolByCoreId.LogPair))
			{
				ConfigCommon.Reset(ConfigDragonPoolByCoreId.HandleId, ConfigDragonPoolByCoreId.LogPair);
				return null;
			}
			List<DragonPool> list = new List<DragonPool>();
			while (ConfigCommon.Step(ConfigDragonPoolByCoreId.HandleId, false, ConfigDragonPoolByCoreId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDragonPoolByCoreId.HandleId, 0, ConfigDragonPoolByCoreId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDragonPoolByCoreId.HandleId, ConfigDragonPoolByCoreId.LogPair);
					return null;
				}
				DragonPool rootAsDragonPool = DragonPool.GetRootAsDragonPool(new ByteBuffer(item2));
				list.Add(rootAsDragonPool);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DragonPoolByCoreId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CoreId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigDragonPoolByCoreId.HandleId, ConfigDragonPoolByCoreId.LogPair);
			return list;
		}

		// Token: 0x04000EAF RID: 3759
		private const string DB = "db_dragon_ball.db";

		// Token: 0x04000EB0 RID: 3760
		private const string FILE = "m.鸣素体.xlsx";

		// Token: 0x04000EB1 RID: 3761
		private const string TABLE = "DragonPool";

		// Token: 0x04000EB2 RID: 3762
		private const string COMMAND = "select BinData from `DragonPool` where CoreId=?";

		// Token: 0x04000EB3 RID: 3763
		private const string KEY_PREFIX = "DragonPoolByCoreId";

		// Token: 0x04000EB4 RID: 3764
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EB5 RID: 3765
		private static int HandleId;
	}
}
