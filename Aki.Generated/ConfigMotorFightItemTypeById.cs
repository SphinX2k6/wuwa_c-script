using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200058E RID: 1422
	public class ConfigMotorFightItemTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002161 RID: 8545 RVA: 0x00116307 File Offset: 0x00114507
		static ConfigMotorFightItemTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightItemTypeById.CreateStaticDefaultValue), new Action(ConfigMotorFightItemTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x00116328 File Offset: 0x00114528
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

		// Token: 0x06002163 RID: 8547 RVA: 0x001163A7 File Offset: 0x001145A7
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightItemTypeById.LogPair = null;
			ConfigMotorFightItemTypeById.HandleId = 0;
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x001163B5 File Offset: 0x001145B5
		public static void Init()
		{
			ConfigMotorFightItemTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightItemTypeById.HandleId, "db_motorfight.db", "select BinData from `MotorFightItemType` where Id=?");
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x001163D0 File Offset: 0x001145D0
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

		// Token: 0x040026C6 RID: 9926
		private const string DB = "db_motorfight.db";

		// Token: 0x040026C7 RID: 9927
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040026C8 RID: 9928
		private const string TABLE = "MotorFightItemType";

		// Token: 0x040026C9 RID: 9929
		private const string COMMAND = "select BinData from `MotorFightItemType` where Id=?";

		// Token: 0x040026CA RID: 9930
		private const string KEY_PREFIX = "MotorFightItemTypeById";

		// Token: 0x040026CB RID: 9931
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026CC RID: 9932
		private static int HandleId;
	}
}
