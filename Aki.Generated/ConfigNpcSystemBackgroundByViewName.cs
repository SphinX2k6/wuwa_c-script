using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200061E RID: 1566
	public class ConfigNpcSystemBackgroundByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024C4 RID: 9412 RVA: 0x0012992C File Offset: 0x00127B2C
		static ConfigNpcSystemBackgroundByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNpcSystemBackgroundByViewName.CreateStaticDefaultValue), new Action(ConfigNpcSystemBackgroundByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x0012994C File Offset: 0x00127B4C
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

		// Token: 0x060024C6 RID: 9414 RVA: 0x001299CB File Offset: 0x00127BCB
		public static void ResetStaticDefaultValue()
		{
			ConfigNpcSystemBackgroundByViewName.LogPair = null;
			ConfigNpcSystemBackgroundByViewName.HandleId = 0;
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x001299D9 File Offset: 0x00127BD9
		public static void Init()
		{
			ConfigNpcSystemBackgroundByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigNpcSystemBackgroundByViewName.HandleId, "db_commonbackground.db", "select BinData from `NpcSystemBackground` where ViewName=?");
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x001299F4 File Offset: 0x00127BF4
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

		// Token: 0x04002AB8 RID: 10936
		private const string DB = "db_commonbackground.db";

		// Token: 0x04002AB9 RID: 10937
		private const string FILE = "t.通用背景.xlsx";

		// Token: 0x04002ABA RID: 10938
		private const string TABLE = "NpcSystemBackground";

		// Token: 0x04002ABB RID: 10939
		private const string COMMAND = "select BinData from `NpcSystemBackground` where ViewName=?";

		// Token: 0x04002ABC RID: 10940
		private const string KEY_PREFIX = "NpcSystemBackgroundByViewName";

		// Token: 0x04002ABD RID: 10941
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002ABE RID: 10942
		private static int HandleId;
	}
}
