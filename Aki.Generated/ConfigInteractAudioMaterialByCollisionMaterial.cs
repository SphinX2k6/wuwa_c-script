using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000464 RID: 1124
	public class ConfigInteractAudioMaterialByCollisionMaterial : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A62 RID: 6754 RVA: 0x000F229C File Offset: 0x000F049C
		static ConfigInteractAudioMaterialByCollisionMaterial()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInteractAudioMaterialByCollisionMaterial.CreateStaticDefaultValue), new Action(ConfigInteractAudioMaterialByCollisionMaterial.ResetStaticDefaultValue));
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x000F22BC File Offset: 0x000F04BC
		public static void CreateStaticDefaultValue()
		{
			ConfigInteractAudioMaterialByCollisionMaterial.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInteractAudioMaterialByCollisionMaterial.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_interactaudiomaterial.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/y.音频/j.交互材质音频/*.csv*"),
				new ValueTuple<string, object>("表名", "InteractAudioMaterial"),
				new ValueTuple<string, object>("语句", "select BinData from `InteractAudioMaterial` where CollisionMaterial=?")
			});
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x000F233B File Offset: 0x000F053B
		public static void ResetStaticDefaultValue()
		{
			ConfigInteractAudioMaterialByCollisionMaterial.LogPair = null;
			ConfigInteractAudioMaterialByCollisionMaterial.HandleId = 0;
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x000F2349 File Offset: 0x000F0549
		public static void Init()
		{
			ConfigInteractAudioMaterialByCollisionMaterial.HandleId = ConfigCommon.InitDataStatement(ConfigInteractAudioMaterialByCollisionMaterial.HandleId, "db_interactaudiomaterial.db", "select BinData from `InteractAudioMaterial` where CollisionMaterial=?");
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x000F2364 File Offset: 0x000F0564
		public static InteractAudioMaterial? GetConfig(string p0CollisionMaterial, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInteractAudioMaterialByCollisionMaterial.HandleId, ConfigInteractAudioMaterialByCollisionMaterial.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("InteractAudioMaterialByCollisionMaterial#" + p0CollisionMaterial);
				if (configBuffer != null)
				{
					return new InteractAudioMaterial?(InteractAudioMaterial.GetRootAsInteractAudioMaterial(configBuffer));
				}
			}
			ConfigInteractAudioMaterialByCollisionMaterial.LogPair.Clear();
			ConfigInteractAudioMaterialByCollisionMaterial.LogPair.Add(new ValueTuple<string, object>("CollisionMaterial", p0CollisionMaterial));
			if (!ConfigCommon.BindString(ConfigInteractAudioMaterialByCollisionMaterial.HandleId, 1, p0CollisionMaterial, ConfigInteractAudioMaterialByCollisionMaterial.LogPair) || ConfigCommon.Step(ConfigInteractAudioMaterialByCollisionMaterial.HandleId, true, ConfigInteractAudioMaterialByCollisionMaterial.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInteractAudioMaterialByCollisionMaterial.HandleId, ConfigInteractAudioMaterialByCollisionMaterial.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInteractAudioMaterialByCollisionMaterial.HandleId, 0, ConfigInteractAudioMaterialByCollisionMaterial.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInteractAudioMaterialByCollisionMaterial.HandleId, ConfigInteractAudioMaterialByCollisionMaterial.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InteractAudioMaterial rootAsInteractAudioMaterial = InteractAudioMaterial.GetRootAsInteractAudioMaterial(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("InteractAudioMaterialByCollisionMaterial#" + p0CollisionMaterial, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInteractAudioMaterialByCollisionMaterial.HandleId, ConfigInteractAudioMaterialByCollisionMaterial.LogPair);
			return new InteractAudioMaterial?(rootAsInteractAudioMaterial);
		}

		// Token: 0x04001EA0 RID: 7840
		private const string DB = "db_interactaudiomaterial.db";

		// Token: 0x04001EA1 RID: 7841
		private const string FILE = "k.可视化编辑/c.Csv/y.音频/j.交互材质音频/*.csv*";

		// Token: 0x04001EA2 RID: 7842
		private const string TABLE = "InteractAudioMaterial";

		// Token: 0x04001EA3 RID: 7843
		private const string COMMAND = "select BinData from `InteractAudioMaterial` where CollisionMaterial=?";

		// Token: 0x04001EA4 RID: 7844
		private const string KEY_PREFIX = "InteractAudioMaterialByCollisionMaterial";

		// Token: 0x04001EA5 RID: 7845
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EA6 RID: 7846
		private static int HandleId;
	}
}
