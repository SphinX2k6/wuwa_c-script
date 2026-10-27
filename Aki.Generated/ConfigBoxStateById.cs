using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000118 RID: 280
	public class ConfigBoxStateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000691 RID: 1681 RVA: 0x0007EB78 File Offset: 0x0007CD78
		static ConfigBoxStateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBoxStateById.CreateStaticDefaultValue), new Action(ConfigBoxStateById.ResetStaticDefaultValue));
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0007EB98 File Offset: 0x0007CD98
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

		// Token: 0x06000693 RID: 1683 RVA: 0x0007EC17 File Offset: 0x0007CE17
		public static void ResetStaticDefaultValue()
		{
			ConfigBoxStateById.LogPair = null;
			ConfigBoxStateById.HandleId = 0;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0007EC25 File Offset: 0x0007CE25
		public static void Init()
		{
			ConfigBoxStateById.HandleId = ConfigCommon.InitDataStatement(ConfigBoxStateById.HandleId, "db_treasure.db", "select BinData from `BoxState` where Id=?");
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0007EC40 File Offset: 0x0007CE40
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

		// Token: 0x0400078C RID: 1932
		private const string DB = "db_treasure.db";

		// Token: 0x0400078D RID: 1933
		private const string FILE = "w.物资箱.xlsx";

		// Token: 0x0400078E RID: 1934
		private const string TABLE = "BoxState";

		// Token: 0x0400078F RID: 1935
		private const string COMMAND = "select BinData from `BoxState` where Id=?";

		// Token: 0x04000790 RID: 1936
		private const string KEY_PREFIX = "BoxStateById";

		// Token: 0x04000791 RID: 1937
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000792 RID: 1938
		private static int HandleId;
	}
}
