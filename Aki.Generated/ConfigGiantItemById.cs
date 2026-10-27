using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000395 RID: 917
	public class ConfigGiantItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001584 RID: 5508 RVA: 0x000D3390 File Offset: 0x000D1590
		static ConfigGiantItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantItemById.CreateStaticDefaultValue), new Action(ConfigGiantItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x000D33B0 File Offset: 0x000D15B0
		public static void CreateStaticDefaultValue()
		{
			ConfigGiantItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiantItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giant.db"),
				new ValueTuple<string, object>("文件", "j.巨人信物.xlsx"),
				new ValueTuple<string, object>("表名", "GiantItem"),
				new ValueTuple<string, object>("语句", "select BinData from `GiantItem` where Id=?")
			});
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x000D342F File Offset: 0x000D162F
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantItemById.LogPair = null;
			ConfigGiantItemById.HandleId = 0;
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x000D343D File Offset: 0x000D163D
		public static void Init()
		{
			ConfigGiantItemById.HandleId = ConfigCommon.InitDataStatement(ConfigGiantItemById.HandleId, "db_giant.db", "select BinData from `GiantItem` where Id=?");
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x000D3458 File Offset: 0x000D1658
		public static GiantItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiantItemById.HandleId, ConfigGiantItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GiantItem?(GiantItem.GetRootAsGiantItem(configBuffer));
				}
			}
			ConfigGiantItemById.LogPair.Clear();
			ConfigGiantItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGiantItemById.HandleId, 1, p0Id, ConfigGiantItemById.LogPair) || ConfigCommon.Step(ConfigGiantItemById.HandleId, true, ConfigGiantItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGiantItemById.HandleId, ConfigGiantItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiantItemById.HandleId, 0, ConfigGiantItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGiantItemById.HandleId, ConfigGiantItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GiantItem rootAsGiantItem = GiantItem.GetRootAsGiantItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGiantItemById.HandleId, ConfigGiantItemById.LogPair);
			return new GiantItem?(rootAsGiantItem);
		}

		// Token: 0x040018F7 RID: 6391
		private const string DB = "db_giant.db";

		// Token: 0x040018F8 RID: 6392
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x040018F9 RID: 6393
		private const string TABLE = "GiantItem";

		// Token: 0x040018FA RID: 6394
		private const string COMMAND = "select BinData from `GiantItem` where Id=?";

		// Token: 0x040018FB RID: 6395
		private const string KEY_PREFIX = "GiantItemById";

		// Token: 0x040018FC RID: 6396
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018FD RID: 6397
		private static int HandleId;
	}
}
