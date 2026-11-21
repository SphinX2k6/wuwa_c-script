using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000127 RID: 295
	public class ConfigBoxStateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006EB RID: 1771 RVA: 0x000844DC File Offset: 0x000826DC
		static ConfigBoxStateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBoxStateById.CreateStaticDefaultValue), new Action(ConfigBoxStateById.ResetStaticDefaultValue));
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x000844FC File Offset: 0x000826FC
		public static void CreateStaticDefaultValue()
		{
			ConfigBoxStateById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBoxStateById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_treasure.db"),
				new ValueTuple<string, object>("文件", "w.物资箱.xlsx"),
				new ValueTuple<string, object>("表名", "BoxState"),
				new ValueTuple<string, object>("语句", "select BinData from `BoxState` where Id=?")
			});
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0008457B File Offset: 0x0008277B
		public static void ResetStaticDefaultValue()
		{
			ConfigBoxStateById.LogPair = null;
			ConfigBoxStateById.HandleId = 0;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00084589 File Offset: 0x00082789
		public static void Init()
		{
			ConfigBoxStateById.HandleId = ConfigCommon.InitDataStatement(ConfigBoxStateById.HandleId, "db_treasure.db", "select BinData from `BoxState` where Id=?");
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x000845A4 File Offset: 0x000827A4
		public static BoxState? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBoxStateById.HandleId, ConfigBoxStateById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BoxStateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BoxState?(BoxState.GetRootAsBoxState(configBuffer));
				}
			}
			ConfigBoxStateById.LogPair.Clear();
			ConfigBoxStateById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBoxStateById.HandleId, 1, p0Id, ConfigBoxStateById.LogPair) || ConfigCommon.Step(ConfigBoxStateById.HandleId, true, ConfigBoxStateById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBoxStateById.HandleId, ConfigBoxStateById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBoxStateById.HandleId, 0, ConfigBoxStateById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBoxStateById.HandleId, ConfigBoxStateById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BoxState rootAsBoxState = BoxState.GetRootAsBoxState(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BoxStateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBoxStateById.HandleId, ConfigBoxStateById.LogPair);
			return new BoxState?(rootAsBoxState);
		}

		// Token: 0x040007F5 RID: 2037
		private const string DB = "db_treasure.db";

		// Token: 0x040007F6 RID: 2038
		private const string FILE = "w.物资箱.xlsx";

		// Token: 0x040007F7 RID: 2039
		private const string TABLE = "BoxState";

		// Token: 0x040007F8 RID: 2040
		private const string COMMAND = "select BinData from `BoxState` where Id=?";

		// Token: 0x040007F9 RID: 2041
		private const string KEY_PREFIX = "BoxStateById";

		// Token: 0x040007FA RID: 2042
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007FB RID: 2043
		private static int HandleId;
	}
}
