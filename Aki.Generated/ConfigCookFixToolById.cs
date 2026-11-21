using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001AC RID: 428
	public class ConfigCookFixToolById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A0B RID: 2571 RVA: 0x00095D9C File Offset: 0x00093F9C
		static ConfigCookFixToolById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookFixToolById.CreateStaticDefaultValue), new Action(ConfigCookFixToolById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00095DBC File Offset: 0x00093FBC
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

		// Token: 0x06000A0D RID: 2573 RVA: 0x00095E3B File Offset: 0x0009403B
		public static void ResetStaticDefaultValue()
		{
			ConfigCookFixToolById.LogPair = null;
			ConfigCookFixToolById.HandleId = 0;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00095E49 File Offset: 0x00094049
		public static void Init()
		{
			ConfigCookFixToolById.HandleId = ConfigCommon.InitDataStatement(ConfigCookFixToolById.HandleId, "db_cook.db", "select BinData from `CookFixTool` where Id=?");
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00095E64 File Offset: 0x00094064
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

		// Token: 0x04000B98 RID: 2968
		private const string DB = "db_cook.db";

		// Token: 0x04000B99 RID: 2969
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000B9A RID: 2970
		private const string TABLE = "CookFixTool";

		// Token: 0x04000B9B RID: 2971
		private const string COMMAND = "select BinData from `CookFixTool` where Id=?";

		// Token: 0x04000B9C RID: 2972
		private const string KEY_PREFIX = "CookFixToolById";

		// Token: 0x04000B9D RID: 2973
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B9E RID: 2974
		private static int HandleId;
	}
}
