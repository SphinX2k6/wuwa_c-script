using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D1 RID: 977
	public class ConfigGuideDungeonSetDefineByStrId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016ED RID: 5869 RVA: 0x000DEACC File Offset: 0x000DCCCC
		static ConfigGuideDungeonSetDefineByStrId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideDungeonSetDefineByStrId.CreateStaticDefaultValue), new Action(ConfigGuideDungeonSetDefineByStrId.ResetStaticDefaultValue));
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x000DEAEC File Offset: 0x000DCCEC
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

		// Token: 0x060016EF RID: 5871 RVA: 0x000DEB6B File Offset: 0x000DCD6B
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideDungeonSetDefineByStrId.LogPair = null;
			ConfigGuideDungeonSetDefineByStrId.HandleId = 0;
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x000DEB79 File Offset: 0x000DCD79
		public static void Init()
		{
			ConfigGuideDungeonSetDefineByStrId.HandleId = ConfigCommon.InitDataStatement(ConfigGuideDungeonSetDefineByStrId.HandleId, "db_guide_new.db", "select BinData from `GuideDungeonSetDefine` where StrId=?");
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x000DEB94 File Offset: 0x000DCD94
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

		// Token: 0x04001A9B RID: 6811
		private const string DB = "db_guide_new.db";

		// Token: 0x04001A9C RID: 6812
		private const string FILE = "y.引导(新).xlsx";

		// Token: 0x04001A9D RID: 6813
		private const string TABLE = "GuideDungeonSetDefine";

		// Token: 0x04001A9E RID: 6814
		private const string COMMAND = "select BinData from `GuideDungeonSetDefine` where StrId=?";

		// Token: 0x04001A9F RID: 6815
		private const string KEY_PREFIX = "GuideDungeonSetDefineByStrId";

		// Token: 0x04001AA0 RID: 6816
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001AA1 RID: 6817
		private static int HandleId;
	}
}
