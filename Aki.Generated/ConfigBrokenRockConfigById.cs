using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200012E RID: 302
	public class ConfigBrokenRockConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000715 RID: 1813 RVA: 0x00085474 File Offset: 0x00083674
		static ConfigBrokenRockConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBrokenRockConfigById.CreateStaticDefaultValue), new Action(ConfigBrokenRockConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00085494 File Offset: 0x00083694
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

		// Token: 0x06000717 RID: 1815 RVA: 0x00085513 File Offset: 0x00083713
		public static void ResetStaticDefaultValue()
		{
			ConfigBrokenRockConfigById.LogPair = null;
			ConfigBrokenRockConfigById.HandleId = 0;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00085521 File Offset: 0x00083721
		public static void Init()
		{
			ConfigBrokenRockConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigBrokenRockConfigById.HandleId, "db_brokenrockconfig.db", "select BinData from `BrokenRockConfig` where Id=?");
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0008553C File Offset: 0x0008373C
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

		// Token: 0x04000826 RID: 2086
		private const string DB = "db_brokenrockconfig.db";

		// Token: 0x04000827 RID: 2087
		private const string FILE = "k.可视化编辑/c.Csv/p.破碎岩石配置/*.csv*";

		// Token: 0x04000828 RID: 2088
		private const string TABLE = "BrokenRockConfig";

		// Token: 0x04000829 RID: 2089
		private const string COMMAND = "select BinData from `BrokenRockConfig` where Id=?";

		// Token: 0x0400082A RID: 2090
		private const string KEY_PREFIX = "BrokenRockConfigById";

		// Token: 0x0400082B RID: 2091
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400082C RID: 2092
		private static int HandleId;
	}
}
