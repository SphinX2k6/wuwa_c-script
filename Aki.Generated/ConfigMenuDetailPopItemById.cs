using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200053F RID: 1343
	public class ConfigMenuDetailPopItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F87 RID: 8071 RVA: 0x0010B998 File Offset: 0x00109B98
		static ConfigMenuDetailPopItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMenuDetailPopItemById.CreateStaticDefaultValue), new Action(ConfigMenuDetailPopItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x0010B9B8 File Offset: 0x00109BB8
		public static void CreateStaticDefaultValue()
		{
			ConfigMenuDetailPopItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMenuDetailPopItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "MenuDetailPopItem"),
				new ValueTuple<string, object>("语句", "select BinData from `MenuDetailPopItem` where Id=?")
			});
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x0010BA37 File Offset: 0x00109C37
		public static void ResetStaticDefaultValue()
		{
			ConfigMenuDetailPopItemById.LogPair = null;
			ConfigMenuDetailPopItemById.HandleId = 0;
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x0010BA45 File Offset: 0x00109C45
		public static void Init()
		{
			ConfigMenuDetailPopItemById.HandleId = ConfigCommon.InitDataStatement(ConfigMenuDetailPopItemById.HandleId, "db_menu.db", "select BinData from `MenuDetailPopItem` where Id=?");
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x0010BA60 File Offset: 0x00109C60
		public static MenuDetailPopItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMenuDetailPopItemById.HandleId, ConfigMenuDetailPopItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MenuDetailPopItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MenuDetailPopItem?(MenuDetailPopItem.GetRootAsMenuDetailPopItem(configBuffer));
				}
			}
			ConfigMenuDetailPopItemById.LogPair.Clear();
			ConfigMenuDetailPopItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMenuDetailPopItemById.HandleId, 1, p0Id, ConfigMenuDetailPopItemById.LogPair) || ConfigCommon.Step(ConfigMenuDetailPopItemById.HandleId, true, ConfigMenuDetailPopItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMenuDetailPopItemById.HandleId, ConfigMenuDetailPopItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMenuDetailPopItemById.HandleId, 0, ConfigMenuDetailPopItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMenuDetailPopItemById.HandleId, ConfigMenuDetailPopItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MenuDetailPopItem rootAsMenuDetailPopItem = MenuDetailPopItem.GetRootAsMenuDetailPopItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MenuDetailPopItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMenuDetailPopItemById.HandleId, ConfigMenuDetailPopItemById.LogPair);
			return new MenuDetailPopItem?(rootAsMenuDetailPopItem);
		}

		// Token: 0x0400249D RID: 9373
		private const string DB = "db_menu.db";

		// Token: 0x0400249E RID: 9374
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x0400249F RID: 9375
		private const string TABLE = "MenuDetailPopItem";

		// Token: 0x040024A0 RID: 9376
		private const string COMMAND = "select BinData from `MenuDetailPopItem` where Id=?";

		// Token: 0x040024A1 RID: 9377
		private const string KEY_PREFIX = "MenuDetailPopItemById";

		// Token: 0x040024A2 RID: 9378
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024A3 RID: 9379
		private static int HandleId;
	}
}
