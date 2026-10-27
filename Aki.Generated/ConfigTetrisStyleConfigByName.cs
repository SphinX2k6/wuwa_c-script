using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E0 RID: 2528
	public class ConfigTetrisStyleConfigByName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B54 RID: 15188 RVA: 0x001A9484 File Offset: 0x001A7684
		static ConfigTetrisStyleConfigByName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisStyleConfigByName.CreateStaticDefaultValue), new Action(ConfigTetrisStyleConfigByName.ResetStaticDefaultValue));
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x001A94A4 File Offset: 0x001A76A4
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

		// Token: 0x06003B56 RID: 15190 RVA: 0x001A9523 File Offset: 0x001A7723
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisStyleConfigByName.LogPair = null;
			ConfigTetrisStyleConfigByName.HandleId = 0;
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x001A9531 File Offset: 0x001A7731
		public static void Init()
		{
			ConfigTetrisStyleConfigByName.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisStyleConfigByName.HandleId, "db_tetrisstyleconfig.db", "select BinData from `TetrisStyleConfig` where Name=?");
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x001A954C File Offset: 0x001A774C
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

		// Token: 0x04004506 RID: 17670
		private const string DB = "db_tetrisstyleconfig.db";

		// Token: 0x04004507 RID: 17671
		private const string FILE = "k.可视化编辑/c.Csv/e.俄罗斯方块样式表/*.csv*";

		// Token: 0x04004508 RID: 17672
		private const string TABLE = "TetrisStyleConfig";

		// Token: 0x04004509 RID: 17673
		private const string COMMAND = "select BinData from `TetrisStyleConfig` where Name=?";

		// Token: 0x0400450A RID: 17674
		private const string KEY_PREFIX = "TetrisStyleConfigByName";

		// Token: 0x0400450B RID: 17675
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400450C RID: 17676
		private static int HandleId;
	}
}
