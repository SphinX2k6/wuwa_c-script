using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200011F RID: 287
	public class ConfigBrokenRockConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006BB RID: 1723 RVA: 0x0007FB10 File Offset: 0x0007DD10
		static ConfigBrokenRockConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBrokenRockConfigById.CreateStaticDefaultValue), new Action(ConfigBrokenRockConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0007FB30 File Offset: 0x0007DD30
		public static void CreateStaticDefaultValue()
		{
			ConfigBrokenRockConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBrokenRockConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_brokenrockconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/p.破碎岩石配置/*.csv*"),
				new ValueTuple<string, object>("表名", "BrokenRockConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `BrokenRockConfig` where Id=?")
			});
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0007FBAF File Offset: 0x0007DDAF
		public static void ResetStaticDefaultValue()
		{
			ConfigBrokenRockConfigById.LogPair = null;
			ConfigBrokenRockConfigById.HandleId = 0;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0007FBBD File Offset: 0x0007DDBD
		public static void Init()
		{
			ConfigBrokenRockConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigBrokenRockConfigById.HandleId, "db_brokenrockconfig.db", "select BinData from `BrokenRockConfig` where Id=?");
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0007FBD8 File Offset: 0x0007DDD8
		public static BrokenRockConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBrokenRockConfigById.HandleId, ConfigBrokenRockConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BrokenRockConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BrokenRockConfig?(BrokenRockConfig.GetRootAsBrokenRockConfig(configBuffer));
				}
			}
			ConfigBrokenRockConfigById.LogPair.Clear();
			ConfigBrokenRockConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBrokenRockConfigById.HandleId, 1, p0Id, ConfigBrokenRockConfigById.LogPair) || ConfigCommon.Step(ConfigBrokenRockConfigById.HandleId, true, ConfigBrokenRockConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBrokenRockConfigById.HandleId, ConfigBrokenRockConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBrokenRockConfigById.HandleId, 0, ConfigBrokenRockConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBrokenRockConfigById.HandleId, ConfigBrokenRockConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BrokenRockConfig rootAsBrokenRockConfig = BrokenRockConfig.GetRootAsBrokenRockConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BrokenRockConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBrokenRockConfigById.HandleId, ConfigBrokenRockConfigById.LogPair);
			return new BrokenRockConfig?(rootAsBrokenRockConfig);
		}

		// Token: 0x040007BD RID: 1981
		private const string DB = "db_brokenrockconfig.db";

		// Token: 0x040007BE RID: 1982
		private const string FILE = "k.可视化编辑/c.Csv/p.破碎岩石配置/*.csv*";

		// Token: 0x040007BF RID: 1983
		private const string TABLE = "BrokenRockConfig";

		// Token: 0x040007C0 RID: 1984
		private const string COMMAND = "select BinData from `BrokenRockConfig` where Id=?";

		// Token: 0x040007C1 RID: 1985
		private const string KEY_PREFIX = "BrokenRockConfigById";

		// Token: 0x040007C2 RID: 1986
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007C3 RID: 1987
		private static int HandleId;
	}
}
