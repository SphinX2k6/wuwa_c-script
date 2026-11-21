using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000514 RID: 1300
	public class ConfigLordGymFilterTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E83 RID: 7811 RVA: 0x001093A7 File Offset: 0x001075A7
		static ConfigLordGymFilterTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymFilterTypeById.CreateStaticDefaultValue), new Action(ConfigLordGymFilterTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x001093C8 File Offset: 0x001075C8
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymFilterTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymFilterTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGymFilterType"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGymFilterType` where Id=?")
			});
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x00109447 File Offset: 0x00107647
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymFilterTypeById.LogPair = null;
			ConfigLordGymFilterTypeById.HandleId = 0;
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00109455 File Offset: 0x00107655
		public static void Init()
		{
			ConfigLordGymFilterTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymFilterTypeById.HandleId, "db_lordgym.db", "select BinData from `LordGymFilterType` where Id=?");
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x00109470 File Offset: 0x00107670
		public static LordGymFilterType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymFilterTypeById.HandleId, ConfigLordGymFilterTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymFilterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LordGymFilterType?(LordGymFilterType.GetRootAsLordGymFilterType(configBuffer));
				}
			}
			ConfigLordGymFilterTypeById.LogPair.Clear();
			ConfigLordGymFilterTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLordGymFilterTypeById.HandleId, 1, p0Id, ConfigLordGymFilterTypeById.LogPair) || ConfigCommon.Step(ConfigLordGymFilterTypeById.HandleId, true, ConfigLordGymFilterTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLordGymFilterTypeById.HandleId, ConfigLordGymFilterTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymFilterTypeById.HandleId, 0, ConfigLordGymFilterTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLordGymFilterTypeById.HandleId, ConfigLordGymFilterTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LordGymFilterType rootAsLordGymFilterType = LordGymFilterType.GetRootAsLordGymFilterType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymFilterTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLordGymFilterTypeById.HandleId, ConfigLordGymFilterTypeById.LogPair);
			return new LordGymFilterType?(rootAsLordGymFilterType);
		}

		// Token: 0x04002370 RID: 9072
		private const string DB = "db_lordgym.db";

		// Token: 0x04002371 RID: 9073
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x04002372 RID: 9074
		private const string TABLE = "LordGymFilterType";

		// Token: 0x04002373 RID: 9075
		private const string COMMAND = "select BinData from `LordGymFilterType` where Id=?";

		// Token: 0x04002374 RID: 9076
		private const string KEY_PREFIX = "LordGymFilterTypeById";

		// Token: 0x04002375 RID: 9077
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002376 RID: 9078
		private static int HandleId;
	}
}
