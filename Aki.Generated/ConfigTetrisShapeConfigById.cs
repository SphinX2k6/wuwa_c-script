using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB1 RID: 2737
	public class ConfigTetrisShapeConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600403A RID: 16442 RVA: 0x001C7FFC File Offset: 0x001C61FC
		static ConfigTetrisShapeConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisShapeConfigById.CreateStaticDefaultValue), new Action(ConfigTetrisShapeConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x001C801C File Offset: 0x001C621C
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

		// Token: 0x0600403C RID: 16444 RVA: 0x001C809B File Offset: 0x001C629B
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisShapeConfigById.LogPair = null;
			ConfigTetrisShapeConfigById.HandleId = 0;
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x001C80A9 File Offset: 0x001C62A9
		public static void Init()
		{
			ConfigTetrisShapeConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisShapeConfigById.HandleId, "db_tetrisshapeconfig.db", "select BinData from `TetrisShapeConfig` where Id=?");
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x001C80C4 File Offset: 0x001C62C4
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

		// Token: 0x04004ABD RID: 19133
		private const string DB = "db_tetrisshapeconfig.db";

		// Token: 0x04004ABE RID: 19134
		private const string FILE = "k.可视化编辑/c.Csv/e.俄罗斯方块形状表/*.csv*";

		// Token: 0x04004ABF RID: 19135
		private const string TABLE = "TetrisShapeConfig";

		// Token: 0x04004AC0 RID: 19136
		private const string COMMAND = "select BinData from `TetrisShapeConfig` where Id=?";

		// Token: 0x04004AC1 RID: 19137
		private const string KEY_PREFIX = "TetrisShapeConfigById";

		// Token: 0x04004AC2 RID: 19138
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004AC3 RID: 19139
		private static int HandleId;
	}
}
