using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003AB RID: 939
	public class ConfigGiantItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001608 RID: 5640 RVA: 0x000D9AE4 File Offset: 0x000D7CE4
		static ConfigGiantItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantItemById.CreateStaticDefaultValue), new Action(ConfigGiantItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x000D9B04 File Offset: 0x000D7D04
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

		// Token: 0x0600160A RID: 5642 RVA: 0x000D9B83 File Offset: 0x000D7D83
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantItemById.LogPair = null;
			ConfigGiantItemById.HandleId = 0;
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x000D9B91 File Offset: 0x000D7D91
		public static void Init()
		{
			ConfigGiantItemById.HandleId = ConfigCommon.InitDataStatement(ConfigGiantItemById.HandleId, "db_giant.db", "select BinData from `GiantItem` where Id=?");
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x000D9BAC File Offset: 0x000D7DAC
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

		// Token: 0x04001991 RID: 6545
		private const string DB = "db_giant.db";

		// Token: 0x04001992 RID: 6546
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x04001993 RID: 6547
		private const string TABLE = "GiantItem";

		// Token: 0x04001994 RID: 6548
		private const string COMMAND = "select BinData from `GiantItem` where Id=?";

		// Token: 0x04001995 RID: 6549
		private const string KEY_PREFIX = "GiantItemById";

		// Token: 0x04001996 RID: 6550
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001997 RID: 6551
		private static int HandleId;
	}
}
