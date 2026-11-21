using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000555 RID: 1365
	public class ConfigMenuDetailPopItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600200B RID: 8203 RVA: 0x001120EC File Offset: 0x001102EC
		static ConfigMenuDetailPopItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMenuDetailPopItemById.CreateStaticDefaultValue), new Action(ConfigMenuDetailPopItemById.ResetStaticDefaultValue));
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x0011210C File Offset: 0x0011030C
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

		// Token: 0x0600200D RID: 8205 RVA: 0x0011218B File Offset: 0x0011038B
		public static void ResetStaticDefaultValue()
		{
			ConfigMenuDetailPopItemById.LogPair = null;
			ConfigMenuDetailPopItemById.HandleId = 0;
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x00112199 File Offset: 0x00110399
		public static void Init()
		{
			ConfigMenuDetailPopItemById.HandleId = ConfigCommon.InitDataStatement(ConfigMenuDetailPopItemById.HandleId, "db_menu.db", "select BinData from `MenuDetailPopItem` where Id=?");
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x001121B4 File Offset: 0x001103B4
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

		// Token: 0x04002537 RID: 9527
		private const string DB = "db_menu.db";

		// Token: 0x04002538 RID: 9528
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04002539 RID: 9529
		private const string TABLE = "MenuDetailPopItem";

		// Token: 0x0400253A RID: 9530
		private const string COMMAND = "select BinData from `MenuDetailPopItem` where Id=?";

		// Token: 0x0400253B RID: 9531
		private const string KEY_PREFIX = "MenuDetailPopItemById";

		// Token: 0x0400253C RID: 9532
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400253D RID: 9533
		private static int HandleId;
	}
}
