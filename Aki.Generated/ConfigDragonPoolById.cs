using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200021E RID: 542
	public class ConfigDragonPoolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CB8 RID: 3256 RVA: 0x000A17C3 File Offset: 0x0009F9C3
		static ConfigDragonPoolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDragonPoolById.CreateStaticDefaultValue), new Action(ConfigDragonPoolById.ResetStaticDefaultValue));
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x000A17E4 File Offset: 0x0009F9E4
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

		// Token: 0x06000CBA RID: 3258 RVA: 0x000A1863 File Offset: 0x0009FA63
		public static void ResetStaticDefaultValue()
		{
			ConfigDragonPoolById.LogPair = null;
			ConfigDragonPoolById.HandleId = 0;
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x000A1871 File Offset: 0x0009FA71
		public static void Init()
		{
			ConfigDragonPoolById.HandleId = ConfigCommon.InitDataStatement(ConfigDragonPoolById.HandleId, "db_dragon_ball.db", "select BinData from `DragonPool` where Id=?");
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x000A188C File Offset: 0x0009FA8C
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

		// Token: 0x04000EB6 RID: 3766
		private const string DB = "db_dragon_ball.db";

		// Token: 0x04000EB7 RID: 3767
		private const string FILE = "m.鸣素体.xlsx";

		// Token: 0x04000EB8 RID: 3768
		private const string TABLE = "DragonPool";

		// Token: 0x04000EB9 RID: 3769
		private const string COMMAND = "select BinData from `DragonPool` where Id=?";

		// Token: 0x04000EBA RID: 3770
		private const string KEY_PREFIX = "DragonPoolById";

		// Token: 0x04000EBB RID: 3771
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EBC RID: 3772
		private static int HandleId;
	}
}
