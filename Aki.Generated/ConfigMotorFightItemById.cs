using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A3 RID: 1443
	public class ConfigMotorFightItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021DF RID: 8671 RVA: 0x0011C813 File Offset: 0x0011AA13
		static ConfigMotorFightItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightItemById.CreateStaticDefaultValue), new Action(ConfigMotorFightItemById.ResetStaticDefaultValue));
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x0011C834 File Offset: 0x0011AA34
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

		// Token: 0x060021E1 RID: 8673 RVA: 0x0011C8B3 File Offset: 0x0011AAB3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightItemById.LogPair = null;
			ConfigMotorFightItemById.HandleId = 0;
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x0011C8C1 File Offset: 0x0011AAC1
		public static void Init()
		{
			ConfigMotorFightItemById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightItemById.HandleId, "db_motorfight.db", "select BinData from `MotorFightItem` where Id=?");
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x0011C8DC File Offset: 0x0011AADC
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

		// Token: 0x04002759 RID: 10073
		private const string DB = "db_motorfight.db";

		// Token: 0x0400275A RID: 10074
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x0400275B RID: 10075
		private const string TABLE = "MotorFightItem";

		// Token: 0x0400275C RID: 10076
		private const string COMMAND = "select BinData from `MotorFightItem` where Id=?";

		// Token: 0x0400275D RID: 10077
		private const string KEY_PREFIX = "MotorFightItemById";

		// Token: 0x0400275E RID: 10078
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400275F RID: 10079
		private static int HandleId;
	}
}
