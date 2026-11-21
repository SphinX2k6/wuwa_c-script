using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200022F RID: 559
	public class ConfigDragonPoolByCoreId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D1D RID: 3357 RVA: 0x000A734B File Offset: 0x000A554B
		static ConfigDragonPoolByCoreId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDragonPoolByCoreId.CreateStaticDefaultValue), new Action(ConfigDragonPoolByCoreId.ResetStaticDefaultValue));
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x000A736C File Offset: 0x000A556C
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

		// Token: 0x06000D1F RID: 3359 RVA: 0x000A73EB File Offset: 0x000A55EB
		public static void ResetStaticDefaultValue()
		{
			ConfigDragonPoolByCoreId.LogPair = null;
			ConfigDragonPoolByCoreId.HandleId = 0;
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x000A73F9 File Offset: 0x000A55F9
		public static void Init()
		{
			ConfigDragonPoolByCoreId.HandleId = ConfigCommon.InitDataStatement(ConfigDragonPoolByCoreId.HandleId, "db_dragon_ball.db", "select BinData from `DragonPool` where CoreId=?");
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x000A7414 File Offset: 0x000A5614
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

		// Token: 0x06000D22 RID: 3362 RVA: 0x000A758C File Offset: 0x000A578C
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

		// Token: 0x04000F2D RID: 3885
		private const string DB = "db_dragon_ball.db";

		// Token: 0x04000F2E RID: 3886
		private const string FILE = "m.鸣素体.xlsx";

		// Token: 0x04000F2F RID: 3887
		private const string TABLE = "DragonPool";

		// Token: 0x04000F30 RID: 3888
		private const string COMMAND = "select BinData from `DragonPool` where CoreId=?";

		// Token: 0x04000F31 RID: 3889
		private const string KEY_PREFIX = "DragonPoolByCoreId";

		// Token: 0x04000F32 RID: 3890
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F33 RID: 3891
		private static int HandleId;
	}
}
