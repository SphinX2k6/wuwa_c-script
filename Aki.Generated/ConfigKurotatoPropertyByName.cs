using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004AC RID: 1196
	public class ConfigKurotatoPropertyByName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C13 RID: 7187 RVA: 0x000F8120 File Offset: 0x000F6320
		static ConfigKurotatoPropertyByName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoPropertyByName.CreateStaticDefaultValue), new Action(ConfigKurotatoPropertyByName.ResetStaticDefaultValue));
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x000F8140 File Offset: 0x000F6340
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoPropertyByName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoPropertyByName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局内.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoProperty` where Name=?")
			});
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x000F81BF File Offset: 0x000F63BF
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoPropertyByName.LogPair = null;
			ConfigKurotatoPropertyByName.HandleId = 0;
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x000F81CD File Offset: 0x000F63CD
		public static void Init()
		{
			ConfigKurotatoPropertyByName.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoPropertyByName.HandleId, "db_kurotato.db", "select BinData from `KurotatoProperty` where Name=?");
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x000F81E8 File Offset: 0x000F63E8
		public static KurotatoProperty? GetConfig(string p0Name, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoPropertyByName.HandleId, ConfigKurotatoPropertyByName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("KurotatoPropertyByName#" + p0Name);
				if (configBuffer != null)
				{
					return new KurotatoProperty?(KurotatoProperty.GetRootAsKurotatoProperty(configBuffer));
				}
			}
			ConfigKurotatoPropertyByName.LogPair.Clear();
			ConfigKurotatoPropertyByName.LogPair.Add(new ValueTuple<string, object>("Name", p0Name));
			if (!ConfigCommon.BindString(ConfigKurotatoPropertyByName.HandleId, 1, p0Name, ConfigKurotatoPropertyByName.LogPair) || ConfigCommon.Step(ConfigKurotatoPropertyByName.HandleId, true, ConfigKurotatoPropertyByName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoPropertyByName.HandleId, ConfigKurotatoPropertyByName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoPropertyByName.HandleId, 0, ConfigKurotatoPropertyByName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoPropertyByName.HandleId, ConfigKurotatoPropertyByName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoProperty rootAsKurotatoProperty = KurotatoProperty.GetRootAsKurotatoProperty(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("KurotatoPropertyByName#" + p0Name, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoPropertyByName.HandleId, ConfigKurotatoPropertyByName.LogPair);
			return new KurotatoProperty?(rootAsKurotatoProperty);
		}

		// Token: 0x04002098 RID: 8344
		private const string DB = "db_kurotato.db";

		// Token: 0x04002099 RID: 8345
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x0400209A RID: 8346
		private const string TABLE = "KurotatoProperty";

		// Token: 0x0400209B RID: 8347
		private const string COMMAND = "select BinData from `KurotatoProperty` where Name=?";

		// Token: 0x0400209C RID: 8348
		private const string KEY_PREFIX = "KurotatoPropertyByName";

		// Token: 0x0400209D RID: 8349
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400209E RID: 8350
		private static int HandleId;
	}
}
