using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000554 RID: 1364
	public class ConfigMenuDetailPopById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002005 RID: 8197 RVA: 0x00111EA3 File Offset: 0x001100A3
		static ConfigMenuDetailPopById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMenuDetailPopById.CreateStaticDefaultValue), new Action(ConfigMenuDetailPopById.ResetStaticDefaultValue));
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x00111EC4 File Offset: 0x001100C4
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

		// Token: 0x06002007 RID: 8199 RVA: 0x00111F43 File Offset: 0x00110143
		public static void ResetStaticDefaultValue()
		{
			ConfigMenuDetailPopById.LogPair = null;
			ConfigMenuDetailPopById.HandleId = 0;
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00111F51 File Offset: 0x00110151
		public static void Init()
		{
			ConfigMenuDetailPopById.HandleId = ConfigCommon.InitDataStatement(ConfigMenuDetailPopById.HandleId, "db_menu.db", "select BinData from `MenuDetailPop` where Id=?");
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x00111F6C File Offset: 0x0011016C
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

		// Token: 0x04002530 RID: 9520
		private const string DB = "db_menu.db";

		// Token: 0x04002531 RID: 9521
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04002532 RID: 9522
		private const string TABLE = "MenuDetailPop";

		// Token: 0x04002533 RID: 9523
		private const string COMMAND = "select BinData from `MenuDetailPop` where Id=?";

		// Token: 0x04002534 RID: 9524
		private const string KEY_PREFIX = "MenuDetailPopById";

		// Token: 0x04002535 RID: 9525
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002536 RID: 9526
		private static int HandleId;
	}
}
