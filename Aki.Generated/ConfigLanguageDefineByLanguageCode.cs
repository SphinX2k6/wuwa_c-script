using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004DE RID: 1246
	public class ConfigLanguageDefineByLanguageCode : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D3F RID: 7487 RVA: 0x00101FFD File Offset: 0x001001FD
		static ConfigLanguageDefineByLanguageCode()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLanguageDefineByLanguageCode.CreateStaticDefaultValue), new Action(ConfigLanguageDefineByLanguageCode.ResetStaticDefaultValue));
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x0010201C File Offset: 0x0010021C
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

		// Token: 0x06001D41 RID: 7489 RVA: 0x0010209B File Offset: 0x0010029B
		public static void ResetStaticDefaultValue()
		{
			ConfigLanguageDefineByLanguageCode.LogPair = null;
			ConfigLanguageDefineByLanguageCode.HandleId = 0;
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x001020A9 File Offset: 0x001002A9
		public static void Init()
		{
			ConfigLanguageDefineByLanguageCode.HandleId = ConfigCommon.InitDataStatement(ConfigLanguageDefineByLanguageCode.HandleId, "db_menu.db", "select BinData from `LanguageDefine` where LanguageCode=?");
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x001020C4 File Offset: 0x001002C4
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

		// Token: 0x040021F6 RID: 8694
		private const string DB = "db_menu.db";

		// Token: 0x040021F7 RID: 8695
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x040021F8 RID: 8696
		private const string TABLE = "LanguageDefine";

		// Token: 0x040021F9 RID: 8697
		private const string COMMAND = "select BinData from `LanguageDefine` where LanguageCode=?";

		// Token: 0x040021FA RID: 8698
		private const string KEY_PREFIX = "LanguageDefineByLanguageCode";

		// Token: 0x040021FB RID: 8699
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021FC RID: 8700
		private static int HandleId;
	}
}
