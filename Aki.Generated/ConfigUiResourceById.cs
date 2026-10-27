using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A6C RID: 2668
	public class ConfigUiResourceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E9C RID: 16028 RVA: 0x001BC0E0 File Offset: 0x001BA2E0
		static ConfigUiResourceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiResourceById.CreateStaticDefaultValue), new Action(ConfigUiResourceById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x001BC100 File Offset: 0x001BA300
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

		// Token: 0x06003E9E RID: 16030 RVA: 0x001BC17F File Offset: 0x001BA37F
		public static void ResetStaticDefaultValue()
		{
			ConfigUiResourceById.LogPair = null;
			ConfigUiResourceById.HandleId = 0;
		}

		// Token: 0x06003E9F RID: 16031 RVA: 0x001BC18D File Offset: 0x001BA38D
		public static void Init()
		{
			ConfigUiResourceById.HandleId = ConfigCommon.InitDataStatement(ConfigUiResourceById.HandleId, "db_ui_resource.db", "select BinData from `UiResource` where Id=?");
		}

		// Token: 0x06003EA0 RID: 16032 RVA: 0x001BC1A8 File Offset: 0x001BA3A8
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

		// Token: 0x040048DA RID: 18650
		private const string DB = "db_ui_resource.db";

		// Token: 0x040048DB RID: 18651
		private const string FILE = "u.UI资源.csv";

		// Token: 0x040048DC RID: 18652
		private const string TABLE = "UiResource";

		// Token: 0x040048DD RID: 18653
		private const string COMMAND = "select BinData from `UiResource` where Id=?";

		// Token: 0x040048DE RID: 18654
		private const string KEY_PREFIX = "UiResourceById";

		// Token: 0x040048DF RID: 18655
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048E0 RID: 18656
		private static int HandleId;
	}
}
