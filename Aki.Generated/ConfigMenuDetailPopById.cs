using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200053E RID: 1342
	public class ConfigMenuDetailPopById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F81 RID: 8065 RVA: 0x0010B74F File Offset: 0x0010994F
		static ConfigMenuDetailPopById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMenuDetailPopById.CreateStaticDefaultValue), new Action(ConfigMenuDetailPopById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x0010B770 File Offset: 0x00109970
		public static void CreateStaticDefaultValue()
		{
			ConfigMenuDetailPopById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMenuDetailPopById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "MenuDetailPop"),
				new ValueTuple<string, object>("语句", "select BinData from `MenuDetailPop` where Id=?")
			});
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x0010B7EF File Offset: 0x001099EF
		public static void ResetStaticDefaultValue()
		{
			ConfigMenuDetailPopById.LogPair = null;
			ConfigMenuDetailPopById.HandleId = 0;
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x0010B7FD File Offset: 0x001099FD
		public static void Init()
		{
			ConfigMenuDetailPopById.HandleId = ConfigCommon.InitDataStatement(ConfigMenuDetailPopById.HandleId, "db_menu.db", "select BinData from `MenuDetailPop` where Id=?");
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x0010B818 File Offset: 0x00109A18
		public static MenuDetailPop? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMenuDetailPopById.HandleId, ConfigMenuDetailPopById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MenuDetailPopById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MenuDetailPop?(MenuDetailPop.GetRootAsMenuDetailPop(configBuffer));
				}
			}
			ConfigMenuDetailPopById.LogPair.Clear();
			ConfigMenuDetailPopById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMenuDetailPopById.HandleId, 1, p0Id, ConfigMenuDetailPopById.LogPair) || ConfigCommon.Step(ConfigMenuDetailPopById.HandleId, true, ConfigMenuDetailPopById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMenuDetailPopById.HandleId, ConfigMenuDetailPopById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMenuDetailPopById.HandleId, 0, ConfigMenuDetailPopById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMenuDetailPopById.HandleId, ConfigMenuDetailPopById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MenuDetailPop rootAsMenuDetailPop = MenuDetailPop.GetRootAsMenuDetailPop(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MenuDetailPopById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMenuDetailPopById.HandleId, ConfigMenuDetailPopById.LogPair);
			return new MenuDetailPop?(rootAsMenuDetailPop);
		}

		// Token: 0x04002496 RID: 9366
		private const string DB = "db_menu.db";

		// Token: 0x04002497 RID: 9367
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04002498 RID: 9368
		private const string TABLE = "MenuDetailPop";

		// Token: 0x04002499 RID: 9369
		private const string COMMAND = "select BinData from `MenuDetailPop` where Id=?";

		// Token: 0x0400249A RID: 9370
		private const string KEY_PREFIX = "MenuDetailPopById";

		// Token: 0x0400249B RID: 9371
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400249C RID: 9372
		private static int HandleId;
	}
}
