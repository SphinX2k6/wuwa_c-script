using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB0 RID: 2736
	public class ConfigTetrisShapeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004034 RID: 16436 RVA: 0x001C7DB3 File Offset: 0x001C5FB3
		static ConfigTetrisShapeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisShapeById.CreateStaticDefaultValue), new Action(ConfigTetrisShapeById.ResetStaticDefaultValue));
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x001C7DD4 File Offset: 0x001C5FD4
		public static void CreateStaticDefaultValue()
		{
			ConfigTetrisShapeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTetrisShapeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tetris.db"),
				new ValueTuple<string, object>("文件", "e.俄罗斯方块.xlsx"),
				new ValueTuple<string, object>("表名", "TetrisShape"),
				new ValueTuple<string, object>("语句", "select BinData from `TetrisShape` where Id=?")
			});
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x001C7E53 File Offset: 0x001C6053
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisShapeById.LogPair = null;
			ConfigTetrisShapeById.HandleId = 0;
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x001C7E61 File Offset: 0x001C6061
		public static void Init()
		{
			ConfigTetrisShapeById.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisShapeById.HandleId, "db_tetris.db", "select BinData from `TetrisShape` where Id=?");
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x001C7E7C File Offset: 0x001C607C
		public static TetrisShape? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTetrisShapeById.HandleId, ConfigTetrisShapeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisShapeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TetrisShape?(TetrisShape.GetRootAsTetrisShape(configBuffer));
				}
			}
			ConfigTetrisShapeById.LogPair.Clear();
			ConfigTetrisShapeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTetrisShapeById.HandleId, 1, p0Id, ConfigTetrisShapeById.LogPair) || ConfigCommon.Step(ConfigTetrisShapeById.HandleId, true, ConfigTetrisShapeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTetrisShapeById.HandleId, ConfigTetrisShapeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTetrisShapeById.HandleId, 0, ConfigTetrisShapeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTetrisShapeById.HandleId, ConfigTetrisShapeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TetrisShape rootAsTetrisShape = TetrisShape.GetRootAsTetrisShape(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisShapeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTetrisShapeById.HandleId, ConfigTetrisShapeById.LogPair);
			return new TetrisShape?(rootAsTetrisShape);
		}

		// Token: 0x04004AB6 RID: 19126
		private const string DB = "db_tetris.db";

		// Token: 0x04004AB7 RID: 19127
		private const string FILE = "e.俄罗斯方块.xlsx";

		// Token: 0x04004AB8 RID: 19128
		private const string TABLE = "TetrisShape";

		// Token: 0x04004AB9 RID: 19129
		private const string COMMAND = "select BinData from `TetrisShape` where Id=?";

		// Token: 0x04004ABA RID: 19130
		private const string KEY_PREFIX = "TetrisShapeById";

		// Token: 0x04004ABB RID: 19131
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004ABC RID: 19132
		private static int HandleId;
	}
}
