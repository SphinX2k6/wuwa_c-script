using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200053B RID: 1339
	public class ConfigMaterialReplaceByItemId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F6E RID: 8046 RVA: 0x0010AFC3 File Offset: 0x001091C3
		static ConfigMaterialReplaceByItemId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMaterialReplaceByItemId.CreateStaticDefaultValue), new Action(ConfigMaterialReplaceByItemId.ResetStaticDefaultValue));
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x0010AFE4 File Offset: 0x001091E4
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

		// Token: 0x06001F70 RID: 8048 RVA: 0x0010B063 File Offset: 0x00109263
		public static void ResetStaticDefaultValue()
		{
			ConfigMaterialReplaceByItemId.LogPair = null;
			ConfigMaterialReplaceByItemId.HandleId = 0;
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x0010B071 File Offset: 0x00109271
		public static void Init()
		{
			ConfigMaterialReplaceByItemId.HandleId = ConfigCommon.InitDataStatement(ConfigMaterialReplaceByItemId.HandleId, "db_compose.db", "select BinData from `MaterialReplace` where ItemId = ?");
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x0010B08C File Offset: 0x0010928C
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

		// Token: 0x04002481 RID: 9345
		private const string DB = "db_compose.db";

		// Token: 0x04002482 RID: 9346
		private const string FILE = "h.合成.xlsx";

		// Token: 0x04002483 RID: 9347
		private const string TABLE = "MaterialReplace";

		// Token: 0x04002484 RID: 9348
		private const string COMMAND = "select BinData from `MaterialReplace` where ItemId = ?";

		// Token: 0x04002485 RID: 9349
		private const string KEY_PREFIX = "MaterialReplaceByItemId";

		// Token: 0x04002486 RID: 9350
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002487 RID: 9351
		private static int HandleId;
	}
}
