using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000128 RID: 296
	public class ConfigBoxTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006F1 RID: 1777 RVA: 0x00084724 File Offset: 0x00082924
		static ConfigBoxTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBoxTypeById.CreateStaticDefaultValue), new Action(ConfigBoxTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00084744 File Offset: 0x00082944
		public static void CreateStaticDefaultValue()
		{
			ConfigBoxTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBoxTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_treasure.db"),
				new ValueTuple<string, object>("文件", "w.物资箱.xlsx"),
				new ValueTuple<string, object>("表名", "BoxType"),
				new ValueTuple<string, object>("语句", "select BinData from `BoxType` where Id=?")
			});
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x000847C3 File Offset: 0x000829C3
		public static void ResetStaticDefaultValue()
		{
			ConfigBoxTypeById.LogPair = null;
			ConfigBoxTypeById.HandleId = 0;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x000847D1 File Offset: 0x000829D1
		public static void Init()
		{
			ConfigBoxTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigBoxTypeById.HandleId, "db_treasure.db", "select BinData from `BoxType` where Id=?");
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x000847EC File Offset: 0x000829EC
		public static BoxType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBoxTypeById.HandleId, ConfigBoxTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BoxTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BoxType?(BoxType.GetRootAsBoxType(configBuffer));
				}
			}
			ConfigBoxTypeById.LogPair.Clear();
			ConfigBoxTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBoxTypeById.HandleId, 1, p0Id, ConfigBoxTypeById.LogPair) || ConfigCommon.Step(ConfigBoxTypeById.HandleId, true, ConfigBoxTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBoxTypeById.HandleId, ConfigBoxTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBoxTypeById.HandleId, 0, ConfigBoxTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBoxTypeById.HandleId, ConfigBoxTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BoxType rootAsBoxType = BoxType.GetRootAsBoxType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BoxTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBoxTypeById.HandleId, ConfigBoxTypeById.LogPair);
			return new BoxType?(rootAsBoxType);
		}

		// Token: 0x040007FC RID: 2044
		private const string DB = "db_treasure.db";

		// Token: 0x040007FD RID: 2045
		private const string FILE = "w.物资箱.xlsx";

		// Token: 0x040007FE RID: 2046
		private const string TABLE = "BoxType";

		// Token: 0x040007FF RID: 2047
		private const string COMMAND = "select BinData from `BoxType` where Id=?";

		// Token: 0x04000800 RID: 2048
		private const string KEY_PREFIX = "BoxTypeById";

		// Token: 0x04000801 RID: 2049
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000802 RID: 2050
		private static int HandleId;
	}
}
