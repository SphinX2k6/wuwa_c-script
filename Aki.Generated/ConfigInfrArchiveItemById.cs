using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000439 RID: 1081
	public class ConfigInfrArchiveItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600195F RID: 6495 RVA: 0x000ECA6B File Offset: 0x000EAC6B
		static ConfigInfrArchiveItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrArchiveItemById.CreateStaticDefaultValue), new Action(ConfigInfrArchiveItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x000ECA8C File Offset: 0x000EAC8C
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrArchiveItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrArchiveItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建_档案馆.xlsx"),
				new ValueTuple<string, object>("表名", "InfrArchiveItem"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrArchiveItem` where Id=?")
			});
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x000ECB0B File Offset: 0x000EAD0B
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrArchiveItemById.LogPair = null;
			ConfigInfrArchiveItemById.HandleId = 0;
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x000ECB19 File Offset: 0x000EAD19
		public static void Init()
		{
			ConfigInfrArchiveItemById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrArchiveItemById.HandleId, "db_infrastructure.db", "select BinData from `InfrArchiveItem` where Id=?");
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x000ECB34 File Offset: 0x000EAD34
		public static InfrArchiveItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrArchiveItemById.HandleId, ConfigInfrArchiveItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrArchiveItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrArchiveItem?(InfrArchiveItem.GetRootAsInfrArchiveItem(configBuffer));
				}
			}
			ConfigInfrArchiveItemById.LogPair.Clear();
			ConfigInfrArchiveItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInfrArchiveItemById.HandleId, 1, p0Id, ConfigInfrArchiveItemById.LogPair) || ConfigCommon.Step(ConfigInfrArchiveItemById.HandleId, true, ConfigInfrArchiveItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrArchiveItemById.HandleId, ConfigInfrArchiveItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrArchiveItemById.HandleId, 0, ConfigInfrArchiveItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrArchiveItemById.HandleId, ConfigInfrArchiveItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrArchiveItem rootAsInfrArchiveItem = InfrArchiveItem.GetRootAsInfrArchiveItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrArchiveItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrArchiveItemById.HandleId, ConfigInfrArchiveItemById.LogPair);
			return new InfrArchiveItem?(rootAsInfrArchiveItem);
		}

		// Token: 0x04001D73 RID: 7539
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D74 RID: 7540
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001D75 RID: 7541
		private const string TABLE = "InfrArchiveItem";

		// Token: 0x04001D76 RID: 7542
		private const string COMMAND = "select BinData from `InfrArchiveItem` where Id=?";

		// Token: 0x04001D77 RID: 7543
		private const string KEY_PREFIX = "InfrArchiveItemById";

		// Token: 0x04001D78 RID: 7544
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D79 RID: 7545
		private static int HandleId;
	}
}
