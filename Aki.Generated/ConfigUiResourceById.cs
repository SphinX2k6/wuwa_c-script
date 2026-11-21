using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B41 RID: 2881
	public class ConfigUiResourceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600439A RID: 17306 RVA: 0x001DB474 File Offset: 0x001D9674
		static ConfigUiResourceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiResourceById.CreateStaticDefaultValue), new Action(ConfigUiResourceById.ResetStaticDefaultValue));
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x001DB494 File Offset: 0x001D9694
		public static void CreateStaticDefaultValue()
		{
			ConfigUiResourceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUiResourceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ui_resource.db"),
				new ValueTuple<string, object>("文件", "u.UI资源.csv"),
				new ValueTuple<string, object>("表名", "UiResource"),
				new ValueTuple<string, object>("语句", "select BinData from `UiResource` where Id=?")
			});
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x001DB513 File Offset: 0x001D9713
		public static void ResetStaticDefaultValue()
		{
			ConfigUiResourceById.LogPair = null;
			ConfigUiResourceById.HandleId = 0;
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x001DB521 File Offset: 0x001D9721
		public static void Init()
		{
			ConfigUiResourceById.HandleId = ConfigCommon.InitDataStatement(ConfigUiResourceById.HandleId, "db_ui_resource.db", "select BinData from `UiResource` where Id=?");
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x001DB53C File Offset: 0x001D973C
		public static UiResource? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUiResourceById.HandleId, ConfigUiResourceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("UiResourceById#" + p0Id);
				if (configBuffer != null)
				{
					return new UiResource?(UiResource.GetRootAsUiResource(configBuffer));
				}
			}
			ConfigUiResourceById.LogPair.Clear();
			ConfigUiResourceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigUiResourceById.HandleId, 1, p0Id, ConfigUiResourceById.LogPair) || ConfigCommon.Step(ConfigUiResourceById.HandleId, true, ConfigUiResourceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigUiResourceById.HandleId, ConfigUiResourceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUiResourceById.HandleId, 0, ConfigUiResourceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigUiResourceById.HandleId, ConfigUiResourceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			UiResource rootAsUiResource = UiResource.GetRootAsUiResource(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("UiResourceById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigUiResourceById.HandleId, ConfigUiResourceById.LogPair);
			return new UiResource?(rootAsUiResource);
		}

		// Token: 0x04004EAD RID: 20141
		private const string DB = "db_ui_resource.db";

		// Token: 0x04004EAE RID: 20142
		private const string FILE = "u.UI资源.csv";

		// Token: 0x04004EAF RID: 20143
		private const string TABLE = "UiResource";

		// Token: 0x04004EB0 RID: 20144
		private const string COMMAND = "select BinData from `UiResource` where Id=?";

		// Token: 0x04004EB1 RID: 20145
		private const string KEY_PREFIX = "UiResourceById";

		// Token: 0x04004EB2 RID: 20146
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004EB3 RID: 20147
		private static int HandleId;
	}
}
