using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C8 RID: 1224
	public class ConfigLanguageDefineByLanguageCode : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CBB RID: 7355 RVA: 0x000FB8A9 File Offset: 0x000F9AA9
		static ConfigLanguageDefineByLanguageCode()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLanguageDefineByLanguageCode.CreateStaticDefaultValue), new Action(ConfigLanguageDefineByLanguageCode.ResetStaticDefaultValue));
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x000FB8C8 File Offset: 0x000F9AC8
		public static void CreateStaticDefaultValue()
		{
			ConfigLanguageDefineByLanguageCode.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLanguageDefineByLanguageCode.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "LanguageDefine"),
				new ValueTuple<string, object>("语句", "select BinData from `LanguageDefine` where LanguageCode=?")
			});
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x000FB947 File Offset: 0x000F9B47
		public static void ResetStaticDefaultValue()
		{
			ConfigLanguageDefineByLanguageCode.LogPair = null;
			ConfigLanguageDefineByLanguageCode.HandleId = 0;
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x000FB955 File Offset: 0x000F9B55
		public static void Init()
		{
			ConfigLanguageDefineByLanguageCode.HandleId = ConfigCommon.InitDataStatement(ConfigLanguageDefineByLanguageCode.HandleId, "db_menu.db", "select BinData from `LanguageDefine` where LanguageCode=?");
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x000FB970 File Offset: 0x000F9B70
		public static LanguageDefine? GetConfig(string p0LanguageCode, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLanguageDefineByLanguageCode.HandleId, ConfigLanguageDefineByLanguageCode.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("LanguageDefineByLanguageCode#" + p0LanguageCode);
				if (configBuffer != null)
				{
					return new LanguageDefine?(LanguageDefine.GetRootAsLanguageDefine(configBuffer));
				}
			}
			ConfigLanguageDefineByLanguageCode.LogPair.Clear();
			ConfigLanguageDefineByLanguageCode.LogPair.Add(new ValueTuple<string, object>("LanguageCode", p0LanguageCode));
			if (!ConfigCommon.BindString(ConfigLanguageDefineByLanguageCode.HandleId, 1, p0LanguageCode, ConfigLanguageDefineByLanguageCode.LogPair) || ConfigCommon.Step(ConfigLanguageDefineByLanguageCode.HandleId, true, ConfigLanguageDefineByLanguageCode.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLanguageDefineByLanguageCode.HandleId, ConfigLanguageDefineByLanguageCode.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLanguageDefineByLanguageCode.HandleId, 0, ConfigLanguageDefineByLanguageCode.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLanguageDefineByLanguageCode.HandleId, ConfigLanguageDefineByLanguageCode.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LanguageDefine rootAsLanguageDefine = LanguageDefine.GetRootAsLanguageDefine(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("LanguageDefineByLanguageCode#" + p0LanguageCode, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLanguageDefineByLanguageCode.HandleId, ConfigLanguageDefineByLanguageCode.LogPair);
			return new LanguageDefine?(rootAsLanguageDefine);
		}

		// Token: 0x0400215C RID: 8540
		private const string DB = "db_menu.db";

		// Token: 0x0400215D RID: 8541
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x0400215E RID: 8542
		private const string TABLE = "LanguageDefine";

		// Token: 0x0400215F RID: 8543
		private const string COMMAND = "select BinData from `LanguageDefine` where LanguageCode=?";

		// Token: 0x04002160 RID: 8544
		private const string KEY_PREFIX = "LanguageDefineByLanguageCode";

		// Token: 0x04002161 RID: 8545
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002162 RID: 8546
		private static int HandleId;
	}
}
