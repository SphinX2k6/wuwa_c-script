using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009CE RID: 2510
	public class ConfigTemplateDataPreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AE8 RID: 15080 RVA: 0x001A6D5B File Offset: 0x001A4F5B
		static ConfigTemplateDataPreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTemplateDataPreloadById.CreateStaticDefaultValue), new Action(ConfigTemplateDataPreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x06003AE9 RID: 15081 RVA: 0x001A6D7C File Offset: 0x001A4F7C
		public static void CreateStaticDefaultValue()
		{
			ConfigTemplateDataPreloadById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTemplateDataPreloadById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_templatedata_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/TemplateDataPreload.csv"),
				new ValueTuple<string, object>("表名", "TemplateDataPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `TemplateDataPreload` where Id=?")
			});
		}

		// Token: 0x06003AEA RID: 15082 RVA: 0x001A6DFB File Offset: 0x001A4FFB
		public static void ResetStaticDefaultValue()
		{
			ConfigTemplateDataPreloadById.LogPair = null;
			ConfigTemplateDataPreloadById.HandleId = 0;
		}

		// Token: 0x06003AEB RID: 15083 RVA: 0x001A6E09 File Offset: 0x001A5009
		public static void Init()
		{
			ConfigTemplateDataPreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigTemplateDataPreloadById.HandleId, "db_templatedata_preload.db", "select BinData from `TemplateDataPreload` where Id=?");
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x001A6E24 File Offset: 0x001A5024
		public static TemplateDataPreload? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTemplateDataPreloadById.HandleId, ConfigTemplateDataPreloadById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TemplateDataPreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TemplateDataPreload?(TemplateDataPreload.GetRootAsTemplateDataPreload(configBuffer));
				}
			}
			ConfigTemplateDataPreloadById.LogPair.Clear();
			ConfigTemplateDataPreloadById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTemplateDataPreloadById.HandleId, 1, p0Id, ConfigTemplateDataPreloadById.LogPair) || ConfigCommon.Step(ConfigTemplateDataPreloadById.HandleId, true, ConfigTemplateDataPreloadById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTemplateDataPreloadById.HandleId, ConfigTemplateDataPreloadById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTemplateDataPreloadById.HandleId, 0, ConfigTemplateDataPreloadById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTemplateDataPreloadById.HandleId, ConfigTemplateDataPreloadById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TemplateDataPreload rootAsTemplateDataPreload = TemplateDataPreload.GetRootAsTemplateDataPreload(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TemplateDataPreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTemplateDataPreloadById.HandleId, ConfigTemplateDataPreloadById.LogPair);
			return new TemplateDataPreload?(rootAsTemplateDataPreload);
		}

		// Token: 0x04004488 RID: 17544
		private const string DB = "db_templatedata_preload.db";

		// Token: 0x04004489 RID: 17545
		private const string FILE = "Preload/TemplateDataPreload.csv";

		// Token: 0x0400448A RID: 17546
		private const string TABLE = "TemplateDataPreload";

		// Token: 0x0400448B RID: 17547
		private const string COMMAND = "select BinData from `TemplateDataPreload` where Id=?";

		// Token: 0x0400448C RID: 17548
		private const string KEY_PREFIX = "TemplateDataPreloadById";

		// Token: 0x0400448D RID: 17549
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400448E RID: 17550
		private static int HandleId;
	}
}
