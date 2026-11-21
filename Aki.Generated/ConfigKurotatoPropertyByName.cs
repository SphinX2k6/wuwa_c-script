using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C2 RID: 1218
	public class ConfigKurotatoPropertyByName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C97 RID: 7319 RVA: 0x000FE874 File Offset: 0x000FCA74
		static ConfigKurotatoPropertyByName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoPropertyByName.CreateStaticDefaultValue), new Action(ConfigKurotatoPropertyByName.ResetStaticDefaultValue));
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x000FE894 File Offset: 0x000FCA94
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

		// Token: 0x06001C99 RID: 7321 RVA: 0x000FE913 File Offset: 0x000FCB13
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoPropertyByName.LogPair = null;
			ConfigKurotatoPropertyByName.HandleId = 0;
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x000FE921 File Offset: 0x000FCB21
		public static void Init()
		{
			ConfigKurotatoPropertyByName.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoPropertyByName.HandleId, "db_kurotato.db", "select BinData from `KurotatoProperty` where Name=?");
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x000FE93C File Offset: 0x000FCB3C
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

		// Token: 0x04002132 RID: 8498
		private const string DB = "db_kurotato.db";

		// Token: 0x04002133 RID: 8499
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x04002134 RID: 8500
		private const string TABLE = "KurotatoProperty";

		// Token: 0x04002135 RID: 8501
		private const string COMMAND = "select BinData from `KurotatoProperty` where Name=?";

		// Token: 0x04002136 RID: 8502
		private const string KEY_PREFIX = "KurotatoPropertyByName";

		// Token: 0x04002137 RID: 8503
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002138 RID: 8504
		private static int HandleId;
	}
}
