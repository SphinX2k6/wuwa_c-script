using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB5 RID: 2741
	public class ConfigTetrisStyleConfigByName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004052 RID: 16466 RVA: 0x001C8818 File Offset: 0x001C6A18
		static ConfigTetrisStyleConfigByName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisStyleConfigByName.CreateStaticDefaultValue), new Action(ConfigTetrisStyleConfigByName.ResetStaticDefaultValue));
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x001C8838 File Offset: 0x001C6A38
		public static void CreateStaticDefaultValue()
		{
			ConfigTetrisStyleConfigByName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTetrisStyleConfigByName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tetrisstyleconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/e.俄罗斯方块样式表/*.csv*"),
				new ValueTuple<string, object>("表名", "TetrisStyleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TetrisStyleConfig` where Name=?")
			});
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x001C88B7 File Offset: 0x001C6AB7
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisStyleConfigByName.LogPair = null;
			ConfigTetrisStyleConfigByName.HandleId = 0;
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x001C88C5 File Offset: 0x001C6AC5
		public static void Init()
		{
			ConfigTetrisStyleConfigByName.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisStyleConfigByName.HandleId, "db_tetrisstyleconfig.db", "select BinData from `TetrisStyleConfig` where Name=?");
		}

		// Token: 0x06004056 RID: 16470 RVA: 0x001C88E0 File Offset: 0x001C6AE0
		public static TetrisStyleConfig? GetConfig(string p0Name, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTetrisStyleConfigByName.HandleId, ConfigTetrisStyleConfigByName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("TetrisStyleConfigByName#" + p0Name);
				if (configBuffer != null)
				{
					return new TetrisStyleConfig?(TetrisStyleConfig.GetRootAsTetrisStyleConfig(configBuffer));
				}
			}
			ConfigTetrisStyleConfigByName.LogPair.Clear();
			ConfigTetrisStyleConfigByName.LogPair.Add(new ValueTuple<string, object>("Name", p0Name));
			if (!ConfigCommon.BindString(ConfigTetrisStyleConfigByName.HandleId, 1, p0Name, ConfigTetrisStyleConfigByName.LogPair) || ConfigCommon.Step(ConfigTetrisStyleConfigByName.HandleId, true, ConfigTetrisStyleConfigByName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTetrisStyleConfigByName.HandleId, ConfigTetrisStyleConfigByName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTetrisStyleConfigByName.HandleId, 0, ConfigTetrisStyleConfigByName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTetrisStyleConfigByName.HandleId, ConfigTetrisStyleConfigByName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TetrisStyleConfig rootAsTetrisStyleConfig = TetrisStyleConfig.GetRootAsTetrisStyleConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("TetrisStyleConfigByName#" + p0Name, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTetrisStyleConfigByName.HandleId, ConfigTetrisStyleConfigByName.LogPair);
			return new TetrisStyleConfig?(rootAsTetrisStyleConfig);
		}

		// Token: 0x04004AD9 RID: 19161
		private const string DB = "db_tetrisstyleconfig.db";

		// Token: 0x04004ADA RID: 19162
		private const string FILE = "k.可视化编辑/c.Csv/e.俄罗斯方块样式表/*.csv*";

		// Token: 0x04004ADB RID: 19163
		private const string TABLE = "TetrisStyleConfig";

		// Token: 0x04004ADC RID: 19164
		private const string COMMAND = "select BinData from `TetrisStyleConfig` where Name=?";

		// Token: 0x04004ADD RID: 19165
		private const string KEY_PREFIX = "TetrisStyleConfigByName";

		// Token: 0x04004ADE RID: 19166
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004ADF RID: 19167
		private static int HandleId;
	}
}
