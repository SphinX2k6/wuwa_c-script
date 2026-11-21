using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C3 RID: 1219
	public class ConfigKurotatoPropertyByPropertyVarName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C9D RID: 7325 RVA: 0x000FEA6D File Offset: 0x000FCC6D
		static ConfigKurotatoPropertyByPropertyVarName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoPropertyByPropertyVarName.CreateStaticDefaultValue), new Action(ConfigKurotatoPropertyByPropertyVarName.ResetStaticDefaultValue));
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x000FEA8C File Offset: 0x000FCC8C
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoPropertyByPropertyVarName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoPropertyByPropertyVarName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局内.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoProperty` where KSCBasePropertyVarName=?")
			});
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x000FEB0B File Offset: 0x000FCD0B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoPropertyByPropertyVarName.LogPair = null;
			ConfigKurotatoPropertyByPropertyVarName.HandleId = 0;
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x000FEB19 File Offset: 0x000FCD19
		public static void Init()
		{
			ConfigKurotatoPropertyByPropertyVarName.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoPropertyByPropertyVarName.HandleId, "db_kurotato.db", "select BinData from `KurotatoProperty` where KSCBasePropertyVarName=?");
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x000FEB34 File Offset: 0x000FCD34
		public static KurotatoProperty? GetConfig(string p0KSCBasePropertyVarName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoPropertyByPropertyVarName.HandleId, ConfigKurotatoPropertyByPropertyVarName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("KurotatoPropertyByPropertyVarName#" + p0KSCBasePropertyVarName);
				if (configBuffer != null)
				{
					return new KurotatoProperty?(KurotatoProperty.GetRootAsKurotatoProperty(configBuffer));
				}
			}
			ConfigKurotatoPropertyByPropertyVarName.LogPair.Clear();
			ConfigKurotatoPropertyByPropertyVarName.LogPair.Add(new ValueTuple<string, object>("KSCBasePropertyVarName", p0KSCBasePropertyVarName));
			if (!ConfigCommon.BindString(ConfigKurotatoPropertyByPropertyVarName.HandleId, 1, p0KSCBasePropertyVarName, ConfigKurotatoPropertyByPropertyVarName.LogPair) || ConfigCommon.Step(ConfigKurotatoPropertyByPropertyVarName.HandleId, true, ConfigKurotatoPropertyByPropertyVarName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoPropertyByPropertyVarName.HandleId, ConfigKurotatoPropertyByPropertyVarName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoPropertyByPropertyVarName.HandleId, 0, ConfigKurotatoPropertyByPropertyVarName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoPropertyByPropertyVarName.HandleId, ConfigKurotatoPropertyByPropertyVarName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoProperty rootAsKurotatoProperty = KurotatoProperty.GetRootAsKurotatoProperty(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("KurotatoPropertyByPropertyVarName#" + p0KSCBasePropertyVarName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoPropertyByPropertyVarName.HandleId, ConfigKurotatoPropertyByPropertyVarName.LogPair);
			return new KurotatoProperty?(rootAsKurotatoProperty);
		}

		// Token: 0x04002139 RID: 8505
		private const string DB = "db_kurotato.db";

		// Token: 0x0400213A RID: 8506
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x0400213B RID: 8507
		private const string TABLE = "KurotatoProperty";

		// Token: 0x0400213C RID: 8508
		private const string COMMAND = "select BinData from `KurotatoProperty` where KSCBasePropertyVarName=?";

		// Token: 0x0400213D RID: 8509
		private const string KEY_PREFIX = "KurotatoPropertyByPropertyVarName";

		// Token: 0x0400213E RID: 8510
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400213F RID: 8511
		private static int HandleId;
	}
}
