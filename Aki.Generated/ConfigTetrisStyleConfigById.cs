using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009DF RID: 2527
	public class ConfigTetrisStyleConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B4E RID: 15182 RVA: 0x001A923B File Offset: 0x001A743B
		static ConfigTetrisStyleConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTetrisStyleConfigById.CreateStaticDefaultValue), new Action(ConfigTetrisStyleConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x001A925C File Offset: 0x001A745C
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

		// Token: 0x06003B50 RID: 15184 RVA: 0x001A92DB File Offset: 0x001A74DB
		public static void ResetStaticDefaultValue()
		{
			ConfigTetrisStyleConfigById.LogPair = null;
			ConfigTetrisStyleConfigById.HandleId = 0;
		}

		// Token: 0x06003B51 RID: 15185 RVA: 0x001A92E9 File Offset: 0x001A74E9
		public static void Init()
		{
			ConfigTetrisStyleConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTetrisStyleConfigById.HandleId, "db_tetrisstyleconfig.db", "select BinData from `TetrisStyleConfig` where Id=?");
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x001A9304 File Offset: 0x001A7504
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

		// Token: 0x040044FF RID: 17663
		private const string DB = "db_tetrisstyleconfig.db";

		// Token: 0x04004500 RID: 17664
		private const string FILE = "k.可视化编辑/c.Csv/e.俄罗斯方块样式表/*.csv*";

		// Token: 0x04004501 RID: 17665
		private const string TABLE = "TetrisStyleConfig";

		// Token: 0x04004502 RID: 17666
		private const string COMMAND = "select BinData from `TetrisStyleConfig` where Id=?";

		// Token: 0x04004503 RID: 17667
		private const string KEY_PREFIX = "TetrisStyleConfigById";

		// Token: 0x04004504 RID: 17668
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004505 RID: 17669
		private static int HandleId;
	}
}
