using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003BB RID: 955
	public class ConfigGuideDungeonSetDefineByStrId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001669 RID: 5737 RVA: 0x000D8378 File Offset: 0x000D6578
		static ConfigGuideDungeonSetDefineByStrId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideDungeonSetDefineByStrId.CreateStaticDefaultValue), new Action(ConfigGuideDungeonSetDefineByStrId.ResetStaticDefaultValue));
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000D8398 File Offset: 0x000D6598
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideDungeonSetDefineByStrId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideDungeonSetDefineByStrId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guide_new.db"),
				new ValueTuple<string, object>("文件", "y.引导(新).xlsx"),
				new ValueTuple<string, object>("表名", "GuideDungeonSetDefine"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideDungeonSetDefine` where StrId=?")
			});
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x000D8417 File Offset: 0x000D6617
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideDungeonSetDefineByStrId.LogPair = null;
			ConfigGuideDungeonSetDefineByStrId.HandleId = 0;
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x000D8425 File Offset: 0x000D6625
		public static void Init()
		{
			ConfigGuideDungeonSetDefineByStrId.HandleId = ConfigCommon.InitDataStatement(ConfigGuideDungeonSetDefineByStrId.HandleId, "db_guide_new.db", "select BinData from `GuideDungeonSetDefine` where StrId=?");
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x000D8440 File Offset: 0x000D6640
		public static GuideDungeonSetDefine? GetConfig(string p0StrId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideDungeonSetDefineByStrId.HandleId, ConfigGuideDungeonSetDefineByStrId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("GuideDungeonSetDefineByStrId#" + p0StrId);
				if (configBuffer != null)
				{
					return new GuideDungeonSetDefine?(GuideDungeonSetDefine.GetRootAsGuideDungeonSetDefine(configBuffer));
				}
			}
			ConfigGuideDungeonSetDefineByStrId.LogPair.Clear();
			ConfigGuideDungeonSetDefineByStrId.LogPair.Add(new ValueTuple<string, object>("StrId", p0StrId));
			if (!ConfigCommon.BindString(ConfigGuideDungeonSetDefineByStrId.HandleId, 1, p0StrId, ConfigGuideDungeonSetDefineByStrId.LogPair) || ConfigCommon.Step(ConfigGuideDungeonSetDefineByStrId.HandleId, true, ConfigGuideDungeonSetDefineByStrId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuideDungeonSetDefineByStrId.HandleId, ConfigGuideDungeonSetDefineByStrId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideDungeonSetDefineByStrId.HandleId, 0, ConfigGuideDungeonSetDefineByStrId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuideDungeonSetDefineByStrId.HandleId, ConfigGuideDungeonSetDefineByStrId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuideDungeonSetDefine rootAsGuideDungeonSetDefine = GuideDungeonSetDefine.GetRootAsGuideDungeonSetDefine(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("GuideDungeonSetDefineByStrId#" + p0StrId, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuideDungeonSetDefineByStrId.HandleId, ConfigGuideDungeonSetDefineByStrId.LogPair);
			return new GuideDungeonSetDefine?(rootAsGuideDungeonSetDefine);
		}

		// Token: 0x04001A01 RID: 6657
		private const string DB = "db_guide_new.db";

		// Token: 0x04001A02 RID: 6658
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001A03 RID: 6659
		private const string TABLE = "GuideDungeonSetDefine";

		// Token: 0x04001A04 RID: 6660
		private const string COMMAND = "select BinData from `GuideDungeonSetDefine` where StrId=?";

		// Token: 0x04001A05 RID: 6661
		private const string KEY_PREFIX = "GuideDungeonSetDefineByStrId";

		// Token: 0x04001A06 RID: 6662
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A07 RID: 6663
		private static int HandleId;
	}
}
