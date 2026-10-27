using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000224 RID: 548
	public class ConfigDrinksDialogById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CDC RID: 3292 RVA: 0x000A24C0 File Offset: 0x000A06C0
		static ConfigDrinksDialogById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDrinksDialogById.CreateStaticDefaultValue), new Action(ConfigDrinksDialogById.ResetStaticDefaultValue));
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x000A24E0 File Offset: 0x000A06E0
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

		// Token: 0x06000CDE RID: 3294 RVA: 0x000A255F File Offset: 0x000A075F
		public static void ResetStaticDefaultValue()
		{
			ConfigDrinksDialogById.LogPair = null;
			ConfigDrinksDialogById.HandleId = 0;
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x000A256D File Offset: 0x000A076D
		public static void Init()
		{
			ConfigDrinksDialogById.HandleId = ConfigCommon.InitDataStatement(ConfigDrinksDialogById.HandleId, "db_drinks.db", "select BinData from `DrinksDialog` where Id=?");
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x000A2588 File Offset: 0x000A0788
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

		// Token: 0x04000EE0 RID: 3808
		private const string DB = "db_drinks.db";

		// Token: 0x04000EE1 RID: 3809
		private const string FILE = "t.调饮料.xlsx";

		// Token: 0x04000EE2 RID: 3810
		private const string TABLE = "DrinksDialog";

		// Token: 0x04000EE3 RID: 3811
		private const string COMMAND = "select BinData from `DrinksDialog` where Id=?";

		// Token: 0x04000EE4 RID: 3812
		private const string KEY_PREFIX = "DrinksDialogById";

		// Token: 0x04000EE5 RID: 3813
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EE6 RID: 3814
		private static int HandleId;
	}
}
