using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004AD RID: 1197
	public class ConfigKurotatoPropertyByPropertyVarName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C19 RID: 7193 RVA: 0x000F8319 File Offset: 0x000F6519
		static ConfigKurotatoPropertyByPropertyVarName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoPropertyByPropertyVarName.CreateStaticDefaultValue), new Action(ConfigKurotatoPropertyByPropertyVarName.ResetStaticDefaultValue));
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x000F8338 File Offset: 0x000F6538
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

		// Token: 0x06001C1B RID: 7195 RVA: 0x000F83B7 File Offset: 0x000F65B7
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoPropertyByPropertyVarName.LogPair = null;
			ConfigKurotatoPropertyByPropertyVarName.HandleId = 0;
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x000F83C5 File Offset: 0x000F65C5
		public static void Init()
		{
			ConfigKurotatoPropertyByPropertyVarName.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoPropertyByPropertyVarName.HandleId, "db_kurotato.db", "select BinData from `KurotatoProperty` where KSCBasePropertyVarName=?");
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x000F83E0 File Offset: 0x000F65E0
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

		// Token: 0x0400209F RID: 8351
		private const string DB = "db_kurotato.db";

		// Token: 0x040020A0 RID: 8352
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x040020A1 RID: 8353
		private const string TABLE = "KurotatoProperty";

		// Token: 0x040020A2 RID: 8354
		private const string COMMAND = "select BinData from `KurotatoProperty` where KSCBasePropertyVarName=?";

		// Token: 0x040020A3 RID: 8355
		private const string KEY_PREFIX = "KurotatoPropertyByPropertyVarName";

		// Token: 0x040020A4 RID: 8356
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020A5 RID: 8357
		private static int HandleId;
	}
}
