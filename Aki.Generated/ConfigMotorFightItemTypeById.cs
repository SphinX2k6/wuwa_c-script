using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005A5 RID: 1445
	public class ConfigMotorFightItemTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021EB RID: 8683 RVA: 0x0011CBEF File Offset: 0x0011ADEF
		static ConfigMotorFightItemTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightItemTypeById.CreateStaticDefaultValue), new Action(ConfigMotorFightItemTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x0011CC10 File Offset: 0x0011AE10
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightItemTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightItemTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightItemType"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightItemType` where Id=?")
			});
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x0011CC8F File Offset: 0x0011AE8F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightItemTypeById.LogPair = null;
			ConfigMotorFightItemTypeById.HandleId = 0;
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x0011CC9D File Offset: 0x0011AE9D
		public static void Init()
		{
			ConfigMotorFightItemTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightItemTypeById.HandleId, "db_motorfight.db", "select BinData from `MotorFightItemType` where Id=?");
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x0011CCB8 File Offset: 0x0011AEB8
		public static MotorFightItemType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightItemTypeById.HandleId, ConfigMotorFightItemTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightItemTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightItemType?(MotorFightItemType.GetRootAsMotorFightItemType(configBuffer));
				}
			}
			ConfigMotorFightItemTypeById.LogPair.Clear();
			ConfigMotorFightItemTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightItemTypeById.HandleId, 1, p0Id, ConfigMotorFightItemTypeById.LogPair) || ConfigCommon.Step(ConfigMotorFightItemTypeById.HandleId, true, ConfigMotorFightItemTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightItemTypeById.HandleId, ConfigMotorFightItemTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightItemTypeById.HandleId, 0, ConfigMotorFightItemTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightItemTypeById.HandleId, ConfigMotorFightItemTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightItemType rootAsMotorFightItemType = MotorFightItemType.GetRootAsMotorFightItemType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightItemTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightItemTypeById.HandleId, ConfigMotorFightItemTypeById.LogPair);
			return new MotorFightItemType?(rootAsMotorFightItemType);
		}

		// Token: 0x04002767 RID: 10087
		private const string DB = "db_motorfight.db";

		// Token: 0x04002768 RID: 10088
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002769 RID: 10089
		private const string TABLE = "MotorFightItemType";

		// Token: 0x0400276A RID: 10090
		private const string COMMAND = "select BinData from `MotorFightItemType` where Id=?";

		// Token: 0x0400276B RID: 10091
		private const string KEY_PREFIX = "MotorFightItemTypeById";

		// Token: 0x0400276C RID: 10092
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400276D RID: 10093
		private static int HandleId;
	}
}
