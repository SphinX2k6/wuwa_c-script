using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB4 RID: 2740
	public class ConfigTetrisStyleConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600404C RID: 16460 RVA: 0x001C85CF File Offset: 0x001C67CF
		static ConfigTetrisStyleConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisStyleConfigById.CreateStaticDefaultValue), new Action(ConfigTetrisStyleConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x001C85F0 File Offset: 0x001C67F0
		public static void CreateStaticDefaultValue()
		{
			ConfigTetrisStyleConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTetrisStyleConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tetrisstyleconfig.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/e.俄罗斯方块样式表/*.csv*"),
				new ValueTuple<string, object>("表名", "TetrisStyleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TetrisStyleConfig` where Id=?")
			});
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x001C866F File Offset: 0x001C686F
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisStyleConfigById.LogPair = null;
			ConfigTetrisStyleConfigById.HandleId = 0;
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x001C867D File Offset: 0x001C687D
		public static void Init()
		{
			ConfigTetrisStyleConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisStyleConfigById.HandleId, "db_tetrisstyleconfig.db", "select BinData from `TetrisStyleConfig` where Id=?");
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x001C8698 File Offset: 0x001C6898
		public static TetrisStyleConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTetrisStyleConfigById.HandleId, ConfigTetrisStyleConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisStyleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TetrisStyleConfig?(TetrisStyleConfig.GetRootAsTetrisStyleConfig(configBuffer));
				}
			}
			ConfigTetrisStyleConfigById.LogPair.Clear();
			ConfigTetrisStyleConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTetrisStyleConfigById.HandleId, 1, p0Id, ConfigTetrisStyleConfigById.LogPair) || ConfigCommon.Step(ConfigTetrisStyleConfigById.HandleId, true, ConfigTetrisStyleConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTetrisStyleConfigById.HandleId, ConfigTetrisStyleConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTetrisStyleConfigById.HandleId, 0, ConfigTetrisStyleConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTetrisStyleConfigById.HandleId, ConfigTetrisStyleConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TetrisStyleConfig rootAsTetrisStyleConfig = TetrisStyleConfig.GetRootAsTetrisStyleConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TetrisStyleConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTetrisStyleConfigById.HandleId, ConfigTetrisStyleConfigById.LogPair);
			return new TetrisStyleConfig?(rootAsTetrisStyleConfig);
		}

		// Token: 0x04004AD2 RID: 19154
		private const string DB = "db_tetrisstyleconfig.db";

		// Token: 0x04004AD3 RID: 19155
		private const string FILE = "k.可视化编辑/c.Csv/e.俄罗斯方块样式表/*.csv*";

		// Token: 0x04004AD4 RID: 19156
		private const string TABLE = "TetrisStyleConfig";

		// Token: 0x04004AD5 RID: 19157
		private const string COMMAND = "select BinData from `TetrisStyleConfig` where Id=?";

		// Token: 0x04004AD6 RID: 19158
		private const string KEY_PREFIX = "TetrisStyleConfigById";

		// Token: 0x04004AD7 RID: 19159
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004AD8 RID: 19160
		private static int HandleId;
	}
}
