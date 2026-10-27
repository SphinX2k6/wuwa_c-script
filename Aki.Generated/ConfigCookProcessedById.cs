using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A1 RID: 417
	public class ConfigCookProcessedById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009C9 RID: 2505 RVA: 0x00090C3F File Offset: 0x0008EE3F
		static ConfigCookProcessedById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookProcessedById.CreateStaticDefaultValue), new Action(ConfigCookProcessedById.ResetStaticDefaultValue));
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00090C60 File Offset: 0x0008EE60
		public static void CreateStaticDefaultValue()
		{
			ConfigCookProcessedById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCookProcessedById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cook.db"),
				new ValueTuple<string, object>("文件", "p.烹饪.xlsx"),
				new ValueTuple<string, object>("表名", "CookProcessed"),
				new ValueTuple<string, object>("语句", "select BinData from `CookProcessed` where Id=?")
			});
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x00090CDF File Offset: 0x0008EEDF
		public static void ResetStaticDefaultValue()
		{
			ConfigCookProcessedById.LogPair = null;
			ConfigCookProcessedById.HandleId = 0;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00090CED File Offset: 0x0008EEED
		public static void Init()
		{
			ConfigCookProcessedById.HandleId = ConfigCommon.InitDataStatement(ConfigCookProcessedById.HandleId, "db_cook.db", "select BinData from `CookProcessed` where Id=?");
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00090D08 File Offset: 0x0008EF08
		public static CookProcessed? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCookProcessedById.HandleId, ConfigCookProcessedById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookProcessedById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CookProcessed?(CookProcessed.GetRootAsCookProcessed(configBuffer));
				}
			}
			ConfigCookProcessedById.LogPair.Clear();
			ConfigCookProcessedById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCookProcessedById.HandleId, 1, p0Id, ConfigCookProcessedById.LogPair) || ConfigCommon.Step(ConfigCookProcessedById.HandleId, true, ConfigCookProcessedById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCookProcessedById.HandleId, ConfigCookProcessedById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCookProcessedById.HandleId, 0, ConfigCookProcessedById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCookProcessedById.HandleId, ConfigCookProcessedById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CookProcessed rootAsCookProcessed = CookProcessed.GetRootAsCookProcessed(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookProcessedById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCookProcessedById.HandleId, ConfigCookProcessedById.LogPair);
			return new CookProcessed?(rootAsCookProcessed);
		}

		// Token: 0x04000B4B RID: 2891
		private const string DB = "db_cook.db";

		// Token: 0x04000B4C RID: 2892
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000B4D RID: 2893
		private const string TABLE = "CookProcessed";

		// Token: 0x04000B4E RID: 2894
		private const string COMMAND = "select BinData from `CookProcessed` where Id=?";

		// Token: 0x04000B4F RID: 2895
		private const string KEY_PREFIX = "CookProcessedById";

		// Token: 0x04000B50 RID: 2896
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B51 RID: 2897
		private static int HandleId;
	}
}
