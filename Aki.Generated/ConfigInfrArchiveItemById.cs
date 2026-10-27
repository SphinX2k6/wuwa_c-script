using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000423 RID: 1059
	public class ConfigInfrArchiveItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018DB RID: 6363 RVA: 0x000E6317 File Offset: 0x000E4517
		static ConfigInfrArchiveItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrArchiveItemById.CreateStaticDefaultValue), new Action(ConfigInfrArchiveItemById.ResetStaticDefaultValue));
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x000E6338 File Offset: 0x000E4538
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

		// Token: 0x060018DD RID: 6365 RVA: 0x000E63B7 File Offset: 0x000E45B7
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrArchiveItemById.LogPair = null;
			ConfigInfrArchiveItemById.HandleId = 0;
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x000E63C5 File Offset: 0x000E45C5
		public static void Init()
		{
			ConfigInfrArchiveItemById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrArchiveItemById.HandleId, "db_infrastructure.db", "select BinData from `InfrArchiveItem` where Id=?");
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x000E63E0 File Offset: 0x000E45E0
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

		// Token: 0x04001CD9 RID: 7385
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001CDA RID: 7386
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001CDB RID: 7387
		private const string TABLE = "InfrArchiveItem";

		// Token: 0x04001CDC RID: 7388
		private const string COMMAND = "select BinData from `InfrArchiveItem` where Id=?";

		// Token: 0x04001CDD RID: 7389
		private const string KEY_PREFIX = "InfrArchiveItemById";

		// Token: 0x04001CDE RID: 7390
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CDF RID: 7391
		private static int HandleId;
	}
}
