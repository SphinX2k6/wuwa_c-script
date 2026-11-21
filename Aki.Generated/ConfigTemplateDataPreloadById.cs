using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA3 RID: 2723
	public class ConfigTemplateDataPreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FE6 RID: 16358 RVA: 0x001C60EF File Offset: 0x001C42EF
		static ConfigTemplateDataPreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTemplateDataPreloadById.CreateStaticDefaultValue), new Action(ConfigTemplateDataPreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x001C6110 File Offset: 0x001C4310
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

		// Token: 0x06003FE8 RID: 16360 RVA: 0x001C618F File Offset: 0x001C438F
		public static void ResetStaticDefaultValue()
		{
			ConfigTemplateDataPreloadById.LogPair = null;
			ConfigTemplateDataPreloadById.HandleId = 0;
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x001C619D File Offset: 0x001C439D
		public static void Init()
		{
			ConfigTemplateDataPreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigTemplateDataPreloadById.HandleId, "db_templatedata_preload.db", "select BinData from `TemplateDataPreload` where Id=?");
		}

		// Token: 0x06003FEA RID: 16362 RVA: 0x001C61B8 File Offset: 0x001C43B8
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

		// Token: 0x04004A5B RID: 19035
		private const string DB = "db_templatedata_preload.db";

		// Token: 0x04004A5C RID: 19036
		private const string FILE = "Preload/TemplateDataPreload.csv";

		// Token: 0x04004A5D RID: 19037
		private const string TABLE = "TemplateDataPreload";

		// Token: 0x04004A5E RID: 19038
		private const string COMMAND = "select BinData from `TemplateDataPreload` where Id=?";

		// Token: 0x04004A5F RID: 19039
		private const string KEY_PREFIX = "TemplateDataPreloadById";

		// Token: 0x04004A60 RID: 19040
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A61 RID: 19041
		private static int HandleId;
	}
}
