using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000551 RID: 1361
	public class ConfigMaterialReplaceByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FF2 RID: 8178 RVA: 0x00111717 File Offset: 0x0010F917
		static ConfigMaterialReplaceByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMaterialReplaceByItemId.CreateStaticDefaultValue), new Action(ConfigMaterialReplaceByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00111738 File Offset: 0x0010F938
		public static void CreateStaticDefaultValue()
		{
			ConfigMaterialReplaceByItemId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMaterialReplaceByItemId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_compose.db"),
				new ValueTuple<string, object>("文件", "h.合成.xlsx"),
				new ValueTuple<string, object>("表名", "MaterialReplace"),
				new ValueTuple<string, object>("语句", "select BinData from `MaterialReplace` where ItemId = ?")
			});
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x001117B7 File Offset: 0x0010F9B7
		public static void ResetStaticDefaultValue()
		{
			ConfigMaterialReplaceByItemId.LogPair = null;
			ConfigMaterialReplaceByItemId.HandleId = 0;
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x001117C5 File Offset: 0x0010F9C5
		public static void Init()
		{
			ConfigMaterialReplaceByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigMaterialReplaceByItemId.HandleId, "db_compose.db", "select BinData from `MaterialReplace` where ItemId = ?");
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x001117E0 File Offset: 0x0010F9E0
		public static MaterialReplace? GetConfig(int p0ItemId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMaterialReplaceByItemId.HandleId, ConfigMaterialReplaceByItemId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MaterialReplaceByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MaterialReplace?(MaterialReplace.GetRootAsMaterialReplace(configBuffer));
				}
			}
			ConfigMaterialReplaceByItemId.LogPair.Clear();
			ConfigMaterialReplaceByItemId.LogPair.Add(new ValueTuple<string, object>("ItemId", p0ItemId));
			if (!ConfigCommon.BindInt(ConfigMaterialReplaceByItemId.HandleId, 1, p0ItemId, ConfigMaterialReplaceByItemId.LogPair) || ConfigCommon.Step(ConfigMaterialReplaceByItemId.HandleId, true, ConfigMaterialReplaceByItemId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMaterialReplaceByItemId.HandleId, ConfigMaterialReplaceByItemId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMaterialReplaceByItemId.HandleId, 0, ConfigMaterialReplaceByItemId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMaterialReplaceByItemId.HandleId, ConfigMaterialReplaceByItemId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MaterialReplace rootAsMaterialReplace = MaterialReplace.GetRootAsMaterialReplace(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MaterialReplaceByItemId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ItemId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMaterialReplaceByItemId.HandleId, ConfigMaterialReplaceByItemId.LogPair);
			return new MaterialReplace?(rootAsMaterialReplace);
		}

		// Token: 0x0400251B RID: 9499
		private const string DB = "db_compose.db";

		// Token: 0x0400251C RID: 9500
		private const string FILE = "h.合成.xlsx";

		// Token: 0x0400251D RID: 9501
		private const string TABLE = "MaterialReplace";

		// Token: 0x0400251E RID: 9502
		private const string COMMAND = "select BinData from `MaterialReplace` where ItemId = ?";

		// Token: 0x0400251F RID: 9503
		private const string KEY_PREFIX = "MaterialReplaceByItemId";

		// Token: 0x04002520 RID: 9504
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002521 RID: 9505
		private static int HandleId;
	}
}
