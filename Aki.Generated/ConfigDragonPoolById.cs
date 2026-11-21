using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000230 RID: 560
	public class ConfigDragonPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D24 RID: 3364 RVA: 0x000A76FB File Offset: 0x000A58FB
		static ConfigDragonPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDragonPoolById.CreateStaticDefaultValue), new Action(ConfigDragonPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x000A771C File Offset: 0x000A591C
		public static void CreateStaticDefaultValue()
		{
			ConfigDragonPoolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDragonPoolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dragon_ball.db"),
				new ValueTuple<string, object>("文件", "m.鸣素体.xlsx"),
				new ValueTuple<string, object>("表名", "DragonPool"),
				new ValueTuple<string, object>("语句", "select BinData from `DragonPool` where Id=?")
			});
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x000A779B File Offset: 0x000A599B
		public static void ResetStaticDefaultValue()
		{
			ConfigDragonPoolById.LogPair = null;
			ConfigDragonPoolById.HandleId = 0;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x000A77A9 File Offset: 0x000A59A9
		public static void Init()
		{
			ConfigDragonPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigDragonPoolById.HandleId, "db_dragon_ball.db", "select BinData from `DragonPool` where Id=?");
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x000A77C4 File Offset: 0x000A59C4
		public static DragonPool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDragonPoolById.HandleId, ConfigDragonPoolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DragonPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DragonPool?(DragonPool.GetRootAsDragonPool(configBuffer));
				}
			}
			ConfigDragonPoolById.LogPair.Clear();
			ConfigDragonPoolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDragonPoolById.HandleId, 1, p0Id, ConfigDragonPoolById.LogPair) || ConfigCommon.Step(ConfigDragonPoolById.HandleId, true, ConfigDragonPoolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDragonPoolById.HandleId, ConfigDragonPoolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDragonPoolById.HandleId, 0, ConfigDragonPoolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDragonPoolById.HandleId, ConfigDragonPoolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DragonPool rootAsDragonPool = DragonPool.GetRootAsDragonPool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DragonPoolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDragonPoolById.HandleId, ConfigDragonPoolById.LogPair);
			return new DragonPool?(rootAsDragonPool);
		}

		// Token: 0x04000F34 RID: 3892
		private const string DB = "db_dragon_ball.db";

		// Token: 0x04000F35 RID: 3893
		private const string FILE = "m.鸣素体.xlsx";

		// Token: 0x04000F36 RID: 3894
		private const string TABLE = "DragonPool";

		// Token: 0x04000F37 RID: 3895
		private const string COMMAND = "select BinData from `DragonPool` where Id=?";

		// Token: 0x04000F38 RID: 3896
		private const string KEY_PREFIX = "DragonPoolById";

		// Token: 0x04000F39 RID: 3897
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F3A RID: 3898
		private static int HandleId;
	}
}
