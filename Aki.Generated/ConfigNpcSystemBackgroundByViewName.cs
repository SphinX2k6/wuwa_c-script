using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000636 RID: 1590
	public class ConfigNpcSystemBackgroundByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002554 RID: 9556 RVA: 0x001303A8 File Offset: 0x0012E5A8
		static ConfigNpcSystemBackgroundByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNpcSystemBackgroundByViewName.CreateStaticDefaultValue), new Action(ConfigNpcSystemBackgroundByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x001303C8 File Offset: 0x0012E5C8
		public static void CreateStaticDefaultValue()
		{
			ConfigNpcSystemBackgroundByViewName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNpcSystemBackgroundByViewName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_commonbackground.db"),
				new ValueTuple<string, object>("文件", "t.通用背景.xlsx"),
				new ValueTuple<string, object>("表名", "NpcSystemBackground"),
				new ValueTuple<string, object>("语句", "select BinData from `NpcSystemBackground` where ViewName=?")
			});
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00130447 File Offset: 0x0012E647
		public static void ResetStaticDefaultValue()
		{
			ConfigNpcSystemBackgroundByViewName.LogPair = null;
			ConfigNpcSystemBackgroundByViewName.HandleId = 0;
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00130455 File Offset: 0x0012E655
		public static void Init()
		{
			ConfigNpcSystemBackgroundByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigNpcSystemBackgroundByViewName.HandleId, "db_commonbackground.db", "select BinData from `NpcSystemBackground` where ViewName=?");
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x00130470 File Offset: 0x0012E670
		public static NpcSystemBackground? GetConfig(string p0ViewName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNpcSystemBackgroundByViewName.HandleId, ConfigNpcSystemBackgroundByViewName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("NpcSystemBackgroundByViewName#" + p0ViewName);
				if (configBuffer != null)
				{
					return new NpcSystemBackground?(NpcSystemBackground.GetRootAsNpcSystemBackground(configBuffer));
				}
			}
			ConfigNpcSystemBackgroundByViewName.LogPair.Clear();
			ConfigNpcSystemBackgroundByViewName.LogPair.Add(new ValueTuple<string, object>("ViewName", p0ViewName));
			if (!ConfigCommon.BindString(ConfigNpcSystemBackgroundByViewName.HandleId, 1, p0ViewName, ConfigNpcSystemBackgroundByViewName.LogPair) || ConfigCommon.Step(ConfigNpcSystemBackgroundByViewName.HandleId, true, ConfigNpcSystemBackgroundByViewName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNpcSystemBackgroundByViewName.HandleId, ConfigNpcSystemBackgroundByViewName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNpcSystemBackgroundByViewName.HandleId, 0, ConfigNpcSystemBackgroundByViewName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNpcSystemBackgroundByViewName.HandleId, ConfigNpcSystemBackgroundByViewName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NpcSystemBackground rootAsNpcSystemBackground = NpcSystemBackground.GetRootAsNpcSystemBackground(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("NpcSystemBackgroundByViewName#" + p0ViewName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNpcSystemBackgroundByViewName.HandleId, ConfigNpcSystemBackgroundByViewName.LogPair);
			return new NpcSystemBackground?(rootAsNpcSystemBackground);
		}

		// Token: 0x04002B60 RID: 11104
		private const string DB = "db_commonbackground.db";

		// Token: 0x04002B61 RID: 11105
		private const string FILE = "t.通用背景.xlsx";

		// Token: 0x04002B62 RID: 11106
		private const string TABLE = "NpcSystemBackground";

		// Token: 0x04002B63 RID: 11107
		private const string COMMAND = "select BinData from `NpcSystemBackground` where ViewName=?";

		// Token: 0x04002B64 RID: 11108
		private const string KEY_PREFIX = "NpcSystemBackgroundByViewName";

		// Token: 0x04002B65 RID: 11109
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B66 RID: 11110
		private static int HandleId;
	}
}
