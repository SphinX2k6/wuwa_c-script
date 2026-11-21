using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A80 RID: 2688
	public class ConfigSurvivorsTalentTreeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F14 RID: 16148 RVA: 0x001C1703 File Offset: 0x001BF903
		static ConfigSurvivorsTalentTreeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsTalentTreeById.CreateStaticDefaultValue), new Action(ConfigSurvivorsTalentTreeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F15 RID: 16149 RVA: 0x001C1724 File Offset: 0x001BF924
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsTalentTreeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsTalentTreeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局外.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsTalentTree"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsTalentTree` where Id=?")
			});
		}

		// Token: 0x06003F16 RID: 16150 RVA: 0x001C17A3 File Offset: 0x001BF9A3
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsTalentTreeById.LogPair = null;
			ConfigSurvivorsTalentTreeById.HandleId = 0;
		}

		// Token: 0x06003F17 RID: 16151 RVA: 0x001C17B1 File Offset: 0x001BF9B1
		public static void Init()
		{
			ConfigSurvivorsTalentTreeById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsTalentTreeById.HandleId, "db_survivors.db", "select BinData from `SurvivorsTalentTree` where Id=?");
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x001C17CC File Offset: 0x001BF9CC
		public static SurvivorsTalentTree? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsTalentTreeById.HandleId, ConfigSurvivorsTalentTreeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTalentTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsTalentTree?(SurvivorsTalentTree.GetRootAsSurvivorsTalentTree(configBuffer));
				}
			}
			ConfigSurvivorsTalentTreeById.LogPair.Clear();
			ConfigSurvivorsTalentTreeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsTalentTreeById.HandleId, 1, p0Id, ConfigSurvivorsTalentTreeById.LogPair) || ConfigCommon.Step(ConfigSurvivorsTalentTreeById.HandleId, true, ConfigSurvivorsTalentTreeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsTalentTreeById.HandleId, ConfigSurvivorsTalentTreeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsTalentTreeById.HandleId, 0, ConfigSurvivorsTalentTreeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsTalentTreeById.HandleId, ConfigSurvivorsTalentTreeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsTalentTree rootAsSurvivorsTalentTree = SurvivorsTalentTree.GetRootAsSurvivorsTalentTree(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTalentTreeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsTalentTreeById.HandleId, ConfigSurvivorsTalentTreeById.LogPair);
			return new SurvivorsTalentTree?(rootAsSurvivorsTalentTree);
		}

		// Token: 0x04004966 RID: 18790
		private const string DB = "db_survivors.db";

		// Token: 0x04004967 RID: 18791
		private const string FILE = "x.幸存者_局外.xlsx";

		// Token: 0x04004968 RID: 18792
		private const string TABLE = "SurvivorsTalentTree";

		// Token: 0x04004969 RID: 18793
		private const string COMMAND = "select BinData from `SurvivorsTalentTree` where Id=?";

		// Token: 0x0400496A RID: 18794
		private const string KEY_PREFIX = "SurvivorsTalentTreeById";

		// Token: 0x0400496B RID: 18795
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400496C RID: 18796
		private static int HandleId;
	}
}
