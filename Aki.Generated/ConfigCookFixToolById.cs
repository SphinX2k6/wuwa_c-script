using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200019A RID: 410
	public class ConfigCookFixToolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600099F RID: 2463 RVA: 0x0008FE64 File Offset: 0x0008E064
		static ConfigCookFixToolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookFixToolById.CreateStaticDefaultValue), new Action(ConfigCookFixToolById.ResetStaticDefaultValue));
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0008FE84 File Offset: 0x0008E084
		public static void CreateStaticDefaultValue()
		{
			ConfigCookFixToolById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCookFixToolById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cook.db"),
				new ValueTuple<string, object>("文件", "p.烹饪.xlsx"),
				new ValueTuple<string, object>("表名", "CookFixTool"),
				new ValueTuple<string, object>("语句", "select BinData from `CookFixTool` where Id=?")
			});
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x0008FF03 File Offset: 0x0008E103
		public static void ResetStaticDefaultValue()
		{
			ConfigCookFixToolById.LogPair = null;
			ConfigCookFixToolById.HandleId = 0;
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0008FF11 File Offset: 0x0008E111
		public static void Init()
		{
			ConfigCookFixToolById.HandleId = ConfigCommon.InitDataStatement(ConfigCookFixToolById.HandleId, "db_cook.db", "select BinData from `CookFixTool` where Id=?");
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0008FF2C File Offset: 0x0008E12C
		public static CookFixTool? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCookFixToolById.HandleId, ConfigCookFixToolById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookFixToolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CookFixTool?(CookFixTool.GetRootAsCookFixTool(configBuffer));
				}
			}
			ConfigCookFixToolById.LogPair.Clear();
			ConfigCookFixToolById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCookFixToolById.HandleId, 1, p0Id, ConfigCookFixToolById.LogPair) || ConfigCommon.Step(ConfigCookFixToolById.HandleId, true, ConfigCookFixToolById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCookFixToolById.HandleId, ConfigCookFixToolById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCookFixToolById.HandleId, 0, ConfigCookFixToolById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCookFixToolById.HandleId, ConfigCookFixToolById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CookFixTool rootAsCookFixTool = CookFixTool.GetRootAsCookFixTool(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookFixToolById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCookFixToolById.HandleId, ConfigCookFixToolById.LogPair);
			return new CookFixTool?(rootAsCookFixTool);
		}

		// Token: 0x04000B1A RID: 2842
		private const string DB = "db_cook.db";

		// Token: 0x04000B1B RID: 2843
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000B1C RID: 2844
		private const string TABLE = "CookFixTool";

		// Token: 0x04000B1D RID: 2845
		private const string COMMAND = "select BinData from `CookFixTool` where Id=?";

		// Token: 0x04000B1E RID: 2846
		private const string KEY_PREFIX = "CookFixToolById";

		// Token: 0x04000B1F RID: 2847
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B20 RID: 2848
		private static int HandleId;
	}
}
