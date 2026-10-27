using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009DC RID: 2524
	public class ConfigTetrisShapeConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B3C RID: 15164 RVA: 0x001A8C68 File Offset: 0x001A6E68
		static ConfigTetrisShapeConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisShapeConfigById.CreateStaticDefaultValue), new Action(ConfigTetrisShapeConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x001A8C88 File Offset: 0x001A6E88
		public static void CreateStaticDefaultValue()
		{
			ConfigTetrisShapeConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTetrisShapeConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tetrisshapeconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/e.俄罗斯方块形状表/*.csv*"),
				new ValueTuple<string, object>("表名", "TetrisShapeConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TetrisShapeConfig` where Id=?")
			});
		}

		// Token: 0x06003B3E RID: 15166 RVA: 0x001A8D07 File Offset: 0x001A6F07
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisShapeConfigById.LogPair = null;
			ConfigTetrisShapeConfigById.HandleId = 0;
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x001A8D15 File Offset: 0x001A6F15
		public static void Init()
		{
			ConfigTetrisShapeConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisShapeConfigById.HandleId, "db_tetrisshapeconfig.db", "select BinData from `TetrisShapeConfig` where Id=?");
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x001A8D30 File Offset: 0x001A6F30
		public static TetrisShapeConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTetrisShapeConfigById.HandleId, ConfigTetrisShapeConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisShapeConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TetrisShapeConfig?(TetrisShapeConfig.GetRootAsTetrisShapeConfig(configBuffer));
				}
			}
			ConfigTetrisShapeConfigById.LogPair.Clear();
			ConfigTetrisShapeConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTetrisShapeConfigById.HandleId, 1, p0Id, ConfigTetrisShapeConfigById.LogPair) || ConfigCommon.Step(ConfigTetrisShapeConfigById.HandleId, true, ConfigTetrisShapeConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTetrisShapeConfigById.HandleId, ConfigTetrisShapeConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTetrisShapeConfigById.HandleId, 0, ConfigTetrisShapeConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTetrisShapeConfigById.HandleId, ConfigTetrisShapeConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TetrisShapeConfig rootAsTetrisShapeConfig = TetrisShapeConfig.GetRootAsTetrisShapeConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisShapeConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTetrisShapeConfigById.HandleId, ConfigTetrisShapeConfigById.LogPair);
			return new TetrisShapeConfig?(rootAsTetrisShapeConfig);
		}

		// Token: 0x040044EA RID: 17642
		private const string DB = "db_tetrisshapeconfig.db";

		// Token: 0x040044EB RID: 17643
		private const string FILE = "k.可视化编辑/c.Csv/e.俄罗斯方块形状表/*.csv*";

		// Token: 0x040044EC RID: 17644
		private const string TABLE = "TetrisShapeConfig";

		// Token: 0x040044ED RID: 17645
		private const string COMMAND = "select BinData from `TetrisShapeConfig` where Id=?";

		// Token: 0x040044EE RID: 17646
		private const string KEY_PREFIX = "TetrisShapeConfigById";

		// Token: 0x040044EF RID: 17647
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044F0 RID: 17648
		private static int HandleId;
	}
}
