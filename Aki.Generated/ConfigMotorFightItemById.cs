using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200058C RID: 1420
	public class ConfigMotorFightItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002155 RID: 8533 RVA: 0x00115F2B File Offset: 0x0011412B
		static ConfigMotorFightItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightItemById.CreateStaticDefaultValue), new Action(ConfigMotorFightItemById.ResetStaticDefaultValue));
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x00115F4C File Offset: 0x0011414C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightItem"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightItem` where Id=?")
			});
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x00115FCB File Offset: 0x001141CB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightItemById.LogPair = null;
			ConfigMotorFightItemById.HandleId = 0;
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x00115FD9 File Offset: 0x001141D9
		public static void Init()
		{
			ConfigMotorFightItemById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightItemById.HandleId, "db_motorfight.db", "select BinData from `MotorFightItem` where Id=?");
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00115FF4 File Offset: 0x001141F4
		public static MotorFightItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightItemById.HandleId, ConfigMotorFightItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightItem?(MotorFightItem.GetRootAsMotorFightItem(configBuffer));
				}
			}
			ConfigMotorFightItemById.LogPair.Clear();
			ConfigMotorFightItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightItemById.HandleId, 1, p0Id, ConfigMotorFightItemById.LogPair) || ConfigCommon.Step(ConfigMotorFightItemById.HandleId, true, ConfigMotorFightItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightItemById.HandleId, ConfigMotorFightItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightItemById.HandleId, 0, ConfigMotorFightItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightItemById.HandleId, ConfigMotorFightItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightItem rootAsMotorFightItem = MotorFightItem.GetRootAsMotorFightItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightItemById.HandleId, ConfigMotorFightItemById.LogPair);
			return new MotorFightItem?(rootAsMotorFightItem);
		}

		// Token: 0x040026B8 RID: 9912
		private const string DB = "db_motorfight.db";

		// Token: 0x040026B9 RID: 9913
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040026BA RID: 9914
		private const string TABLE = "MotorFightItem";

		// Token: 0x040026BB RID: 9915
		private const string COMMAND = "select BinData from `MotorFightItem` where Id=?";

		// Token: 0x040026BC RID: 9916
		private const string KEY_PREFIX = "MotorFightItemById";

		// Token: 0x040026BD RID: 9917
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026BE RID: 9918
		private static int HandleId;
	}
}
