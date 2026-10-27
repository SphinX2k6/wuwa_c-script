using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200064C RID: 1612
	public class ConfigPcKeyByKeyName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025D8 RID: 9688 RVA: 0x0012F9B8 File Offset: 0x0012DBB8
		static ConfigPcKeyByKeyName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPcKeyByKeyName.CreateStaticDefaultValue), new Action(ConfigPcKeyByKeyName.ResetStaticDefaultValue));
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x0012F9D8 File Offset: 0x0012DBD8
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

		// Token: 0x060025DA RID: 9690 RVA: 0x0012FA57 File Offset: 0x0012DC57
		public static void ResetStaticDefaultValue()
		{
			ConfigPcKeyByKeyName.LogPair = null;
			ConfigPcKeyByKeyName.HandleId = 0;
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x0012FA65 File Offset: 0x0012DC65
		public static void Init()
		{
			ConfigPcKeyByKeyName.HandleId = ConfigCommon.InitDataStatement(ConfigPcKeyByKeyName.HandleId, "db_key.db", "select BinData from `PcKey` where KeyName=?");
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x0012FA80 File Offset: 0x0012DC80
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

		// Token: 0x04002BFA RID: 11258
		private const string DB = "db_key.db";

		// Token: 0x04002BFB RID: 11259
		private const string FILE = "a.按键.xlsx";

		// Token: 0x04002BFC RID: 11260
		private const string TABLE = "PcKey";

		// Token: 0x04002BFD RID: 11261
		private const string COMMAND = "select BinData from `PcKey` where KeyName=?";

		// Token: 0x04002BFE RID: 11262
		private const string KEY_PREFIX = "PcKeyByKeyName";

		// Token: 0x04002BFF RID: 11263
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C00 RID: 11264
		private static int HandleId;
	}
}
