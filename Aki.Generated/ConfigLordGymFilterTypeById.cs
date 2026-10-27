using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004FE RID: 1278
	public class ConfigLordGymFilterTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DFF RID: 7679 RVA: 0x00102C53 File Offset: 0x00100E53
		static ConfigLordGymFilterTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymFilterTypeById.CreateStaticDefaultValue), new Action(ConfigLordGymFilterTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00102C74 File Offset: 0x00100E74
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

		// Token: 0x06001E01 RID: 7681 RVA: 0x00102CF3 File Offset: 0x00100EF3
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymFilterTypeById.LogPair = null;
			ConfigLordGymFilterTypeById.HandleId = 0;
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00102D01 File Offset: 0x00100F01
		public static void Init()
		{
			ConfigLordGymFilterTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymFilterTypeById.HandleId, "db_lordgym.db", "select BinData from `LordGymFilterType` where Id=?");
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x00102D1C File Offset: 0x00100F1C
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

		// Token: 0x040022D6 RID: 8918
		private const string DB = "db_lordgym.db";

		// Token: 0x040022D7 RID: 8919
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x040022D8 RID: 8920
		private const string TABLE = "LordGymFilterType";

		// Token: 0x040022D9 RID: 8921
		private const string COMMAND = "select BinData from `LordGymFilterType` where Id=?";

		// Token: 0x040022DA RID: 8922
		private const string KEY_PREFIX = "LordGymFilterTypeById";

		// Token: 0x040022DB RID: 8923
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022DC RID: 8924
		private static int HandleId;
	}
}
