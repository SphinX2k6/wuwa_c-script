using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB2 RID: 2738
	public class ConfigTetrisShapeConfigByName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004040 RID: 16448 RVA: 0x001C8244 File Offset: 0x001C6444
		static ConfigTetrisShapeConfigByName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisShapeConfigByName.CreateStaticDefaultValue), new Action(ConfigTetrisShapeConfigByName.ResetStaticDefaultValue));
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x001C8264 File Offset: 0x001C6464
		public static void CreateStaticDefaultValue()
		{
			ConfigTetrisShapeConfigByName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTetrisShapeConfigByName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tetrisshapeconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/e.俄罗斯方块形状表/*.csv*"),
				new ValueTuple<string, object>("表名", "TetrisShapeConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TetrisShapeConfig` where Name=?")
			});
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x001C82E3 File Offset: 0x001C64E3
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisShapeConfigByName.LogPair = null;
			ConfigTetrisShapeConfigByName.HandleId = 0;
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x001C82F1 File Offset: 0x001C64F1
		public static void Init()
		{
			ConfigTetrisShapeConfigByName.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisShapeConfigByName.HandleId, "db_tetrisshapeconfig.db", "select BinData from `TetrisShapeConfig` where Name=?");
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x001C830C File Offset: 0x001C650C
		public static TetrisShapeConfig? GetConfig(string p0Name, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTetrisShapeConfigByName.HandleId, ConfigTetrisShapeConfigByName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("TetrisShapeConfigByName#" + p0Name);
				if (configBuffer != null)
				{
					return new TetrisShapeConfig?(TetrisShapeConfig.GetRootAsTetrisShapeConfig(configBuffer));
				}
			}
			ConfigTetrisShapeConfigByName.LogPair.Clear();
			ConfigTetrisShapeConfigByName.LogPair.Add(new ValueTuple<string, object>("Name", p0Name));
			if (!ConfigCommon.BindString(ConfigTetrisShapeConfigByName.HandleId, 1, p0Name, ConfigTetrisShapeConfigByName.LogPair) || ConfigCommon.Step(ConfigTetrisShapeConfigByName.HandleId, true, ConfigTetrisShapeConfigByName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTetrisShapeConfigByName.HandleId, ConfigTetrisShapeConfigByName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTetrisShapeConfigByName.HandleId, 0, ConfigTetrisShapeConfigByName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTetrisShapeConfigByName.HandleId, ConfigTetrisShapeConfigByName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TetrisShapeConfig rootAsTetrisShapeConfig = TetrisShapeConfig.GetRootAsTetrisShapeConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("TetrisShapeConfigByName#" + p0Name, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTetrisShapeConfigByName.HandleId, ConfigTetrisShapeConfigByName.LogPair);
			return new TetrisShapeConfig?(rootAsTetrisShapeConfig);
		}

		// Token: 0x04004AC4 RID: 19140
		private const string DB = "db_tetrisshapeconfig.db";

		// Token: 0x04004AC5 RID: 19141
		private const string FILE = "k.可视化编辑/c.Csv/e.俄罗斯方块形状表/*.csv*";

		// Token: 0x04004AC6 RID: 19142
		private const string TABLE = "TetrisShapeConfig";

		// Token: 0x04004AC7 RID: 19143
		private const string COMMAND = "select BinData from `TetrisShapeConfig` where Name=?";

		// Token: 0x04004AC8 RID: 19144
		private const string KEY_PREFIX = "TetrisShapeConfigByName";

		// Token: 0x04004AC9 RID: 19145
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004ACA RID: 19146
		private static int HandleId;
	}
}
