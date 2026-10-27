using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009DD RID: 2525
	public class ConfigTetrisShapeConfigByName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B42 RID: 15170 RVA: 0x001A8EB0 File Offset: 0x001A70B0
		static ConfigTetrisShapeConfigByName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisShapeConfigByName.CreateStaticDefaultValue), new Action(ConfigTetrisShapeConfigByName.ResetStaticDefaultValue));
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x001A8ED0 File Offset: 0x001A70D0
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

		// Token: 0x06003B44 RID: 15172 RVA: 0x001A8F4F File Offset: 0x001A714F
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisShapeConfigByName.LogPair = null;
			ConfigTetrisShapeConfigByName.HandleId = 0;
		}

		// Token: 0x06003B45 RID: 15173 RVA: 0x001A8F5D File Offset: 0x001A715D
		public static void Init()
		{
			ConfigTetrisShapeConfigByName.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisShapeConfigByName.HandleId, "db_tetrisshapeconfig.db", "select BinData from `TetrisShapeConfig` where Name=?");
		}

		// Token: 0x06003B46 RID: 15174 RVA: 0x001A8F78 File Offset: 0x001A7178
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

		// Token: 0x040044F1 RID: 17649
		private const string DB = "db_tetrisshapeconfig.db";

		// Token: 0x040044F2 RID: 17650
		private const string FILE = "k.可视化编辑/c.Csv/e.俄罗斯方块形状表/*.csv*";

		// Token: 0x040044F3 RID: 17651
		private const string TABLE = "TetrisShapeConfig";

		// Token: 0x040044F4 RID: 17652
		private const string COMMAND = "select BinData from `TetrisShapeConfig` where Name=?";

		// Token: 0x040044F5 RID: 17653
		private const string KEY_PREFIX = "TetrisShapeConfigByName";

		// Token: 0x040044F6 RID: 17654
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044F7 RID: 17655
		private static int HandleId;
	}
}
