using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200044E RID: 1102
	public class ConfigInteractAudioMaterialByCollisionMaterial : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019DE RID: 6622 RVA: 0x000EBB48 File Offset: 0x000E9D48
		static ConfigInteractAudioMaterialByCollisionMaterial()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInteractAudioMaterialByCollisionMaterial.CreateStaticDefaultValue), new Action(ConfigInteractAudioMaterialByCollisionMaterial.ResetStaticDefaultValue));
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x000EBB68 File Offset: 0x000E9D68
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

		// Token: 0x060019E0 RID: 6624 RVA: 0x000EBBE7 File Offset: 0x000E9DE7
		public static void ResetStaticDefaultValue()
		{
			ConfigInteractAudioMaterialByCollisionMaterial.LogPair = null;
			ConfigInteractAudioMaterialByCollisionMaterial.HandleId = 0;
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x000EBBF5 File Offset: 0x000E9DF5
		public static void Init()
		{
			ConfigInteractAudioMaterialByCollisionMaterial.HandleId = ConfigCommon.InitDataStatement(ConfigInteractAudioMaterialByCollisionMaterial.HandleId, "db_interactaudiomaterial.db", "select BinData from `InteractAudioMaterial` where CollisionMaterial=?");
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x000EBC10 File Offset: 0x000E9E10
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

		// Token: 0x04001E06 RID: 7686
		private const string DB = "db_interactaudiomaterial.db";

		// Token: 0x04001E07 RID: 7687
		private const string FILE = "k.可视化编辑/c.Csv/y.音频/j.交互材质音频/*.csv*";

		// Token: 0x04001E08 RID: 7688
		private const string TABLE = "InteractAudioMaterial";

		// Token: 0x04001E09 RID: 7689
		private const string COMMAND = "select BinData from `InteractAudioMaterial` where CollisionMaterial=?";

		// Token: 0x04001E0A RID: 7690
		private const string KEY_PREFIX = "InteractAudioMaterialByCollisionMaterial";

		// Token: 0x04001E0B RID: 7691
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E0C RID: 7692
		private static int HandleId;
	}
}
