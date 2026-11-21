using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000236 RID: 566
	public class ConfigDrinksDialogById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D48 RID: 3400 RVA: 0x000A83F8 File Offset: 0x000A65F8
		static ConfigDrinksDialogById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksDialogById.CreateStaticDefaultValue), new Action(ConfigDrinksDialogById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x000A8418 File Offset: 0x000A6618
		public static void CreateStaticDefaultValue()
		{
			ConfigDrinksDialogById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDrinksDialogById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_drinks.db"),
				new ValueTuple<string, object>("文件", "t.调饮料.xlsx"),
				new ValueTuple<string, object>("表名", "DrinksDialog"),
				new ValueTuple<string, object>("语句", "select BinData from `DrinksDialog` where Id=?")
			});
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x000A8497 File Offset: 0x000A6697
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksDialogById.LogPair = null;
			ConfigDrinksDialogById.HandleId = 0;
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x000A84A5 File Offset: 0x000A66A5
		public static void Init()
		{
			ConfigDrinksDialogById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksDialogById.HandleId, "db_drinks.db", "select BinData from `DrinksDialog` where Id=?");
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x000A84C0 File Offset: 0x000A66C0
		public static DrinksDialog? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDrinksDialogById.HandleId, ConfigDrinksDialogById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("DrinksDialogById#" + p0Id);
				if (configBuffer != null)
				{
					return new DrinksDialog?(DrinksDialog.GetRootAsDrinksDialog(configBuffer));
				}
			}
			ConfigDrinksDialogById.LogPair.Clear();
			ConfigDrinksDialogById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigDrinksDialogById.HandleId, 1, p0Id, ConfigDrinksDialogById.LogPair) || ConfigCommon.Step(ConfigDrinksDialogById.HandleId, true, ConfigDrinksDialogById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDrinksDialogById.HandleId, ConfigDrinksDialogById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDrinksDialogById.HandleId, 0, ConfigDrinksDialogById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDrinksDialogById.HandleId, ConfigDrinksDialogById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DrinksDialog rootAsDrinksDialog = DrinksDialog.GetRootAsDrinksDialog(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("DrinksDialogById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDrinksDialogById.HandleId, ConfigDrinksDialogById.LogPair);
			return new DrinksDialog?(rootAsDrinksDialog);
		}

		// Token: 0x04000F5E RID: 3934
		private const string DB = "db_drinks.db";

		// Token: 0x04000F5F RID: 3935
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000F60 RID: 3936
		private const string TABLE = "DrinksDialog";

		// Token: 0x04000F61 RID: 3937
		private const string COMMAND = "select BinData from `DrinksDialog` where Id=?";

		// Token: 0x04000F62 RID: 3938
		private const string KEY_PREFIX = "DrinksDialogById";

		// Token: 0x04000F63 RID: 3939
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F64 RID: 3940
		private static int HandleId;
	}
}
