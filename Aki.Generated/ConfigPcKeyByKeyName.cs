using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000664 RID: 1636
	public class ConfigPcKeyByKeyName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002668 RID: 9832 RVA: 0x00136434 File Offset: 0x00134634
		static ConfigPcKeyByKeyName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPcKeyByKeyName.CreateStaticDefaultValue), new Action(ConfigPcKeyByKeyName.ResetStaticDefaultValue));
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x00136454 File Offset: 0x00134654
		public static void CreateStaticDefaultValue()
		{
			ConfigPcKeyByKeyName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPcKeyByKeyName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_key.db"),
				new ValueTuple<string, object>("文件", "a.按键.xlsx"),
				new ValueTuple<string, object>("表名", "PcKey"),
				new ValueTuple<string, object>("语句", "select BinData from `PcKey` where KeyName=?")
			});
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x001364D3 File Offset: 0x001346D3
		public static void ResetStaticDefaultValue()
		{
			ConfigPcKeyByKeyName.LogPair = null;
			ConfigPcKeyByKeyName.HandleId = 0;
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x001364E1 File Offset: 0x001346E1
		public static void Init()
		{
			ConfigPcKeyByKeyName.HandleId = ConfigCommon.InitDataStatement(ConfigPcKeyByKeyName.HandleId, "db_key.db", "select BinData from `PcKey` where KeyName=?");
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x001364FC File Offset: 0x001346FC
		public static PcKey? GetConfig(string p0KeyName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPcKeyByKeyName.HandleId, ConfigPcKeyByKeyName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("PcKeyByKeyName#" + p0KeyName);
				if (configBuffer != null)
				{
					return new PcKey?(PcKey.GetRootAsPcKey(configBuffer));
				}
			}
			ConfigPcKeyByKeyName.LogPair.Clear();
			ConfigPcKeyByKeyName.LogPair.Add(new ValueTuple<string, object>("KeyName", p0KeyName));
			if (!ConfigCommon.BindString(ConfigPcKeyByKeyName.HandleId, 1, p0KeyName, ConfigPcKeyByKeyName.LogPair) || ConfigCommon.Step(ConfigPcKeyByKeyName.HandleId, true, ConfigPcKeyByKeyName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPcKeyByKeyName.HandleId, ConfigPcKeyByKeyName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPcKeyByKeyName.HandleId, 0, ConfigPcKeyByKeyName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPcKeyByKeyName.HandleId, ConfigPcKeyByKeyName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PcKey rootAsPcKey = PcKey.GetRootAsPcKey(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("PcKeyByKeyName#" + p0KeyName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPcKeyByKeyName.HandleId, ConfigPcKeyByKeyName.LogPair);
			return new PcKey?(rootAsPcKey);
		}

		// Token: 0x04002CA2 RID: 11426
		private const string DB = "db_key.db";

		// Token: 0x04002CA3 RID: 11427
		private const string FILE = "a.按键.xlsx";

		// Token: 0x04002CA4 RID: 11428
		private const string TABLE = "PcKey";

		// Token: 0x04002CA5 RID: 11429
		private const string COMMAND = "select BinData from `PcKey` where KeyName=?";

		// Token: 0x04002CA6 RID: 11430
		private const string KEY_PREFIX = "PcKeyByKeyName";

		// Token: 0x04002CA7 RID: 11431
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002CA8 RID: 11432
		private static int HandleId;
	}
}
