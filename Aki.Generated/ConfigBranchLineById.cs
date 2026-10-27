using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200011B RID: 283
	public class ConfigBranchLineById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006A3 RID: 1699 RVA: 0x0007F19B File Offset: 0x0007D39B
		static ConfigBranchLineById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBranchLineById.CreateStaticDefaultValue), new Action(ConfigBranchLineById.ResetStaticDefaultValue));
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0007F1BC File Offset: 0x0007D3BC
		public static void CreateStaticDefaultValue()
		{
			ConfigBranchLineById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBranchLineById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "BranchLine"),
				new ValueTuple<string, object>("语句", "select BinData from `BranchLine` where Id=?")
			});
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0007F23B File Offset: 0x0007D43B
		public static void ResetStaticDefaultValue()
		{
			ConfigBranchLineById.LogPair = null;
			ConfigBranchLineById.HandleId = 0;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0007F249 File Offset: 0x0007D449
		public static void Init()
		{
			ConfigBranchLineById.HandleId = ConfigCommon.InitDataStatement(ConfigBranchLineById.HandleId, "db_moonchasing.db", "select BinData from `BranchLine` where Id=?");
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0007F264 File Offset: 0x0007D464
		public static BranchLine? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBranchLineById.HandleId, ConfigBranchLineById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BranchLineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BranchLine?(BranchLine.GetRootAsBranchLine(configBuffer));
				}
			}
			ConfigBranchLineById.LogPair.Clear();
			ConfigBranchLineById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBranchLineById.HandleId, 1, p0Id, ConfigBranchLineById.LogPair) || ConfigCommon.Step(ConfigBranchLineById.HandleId, true, ConfigBranchLineById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBranchLineById.HandleId, ConfigBranchLineById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBranchLineById.HandleId, 0, ConfigBranchLineById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBranchLineById.HandleId, ConfigBranchLineById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BranchLine rootAsBranchLine = BranchLine.GetRootAsBranchLine(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BranchLineById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBranchLineById.HandleId, ConfigBranchLineById.LogPair);
			return new BranchLine?(rootAsBranchLine);
		}

		// Token: 0x040007A1 RID: 1953
		private const string DB = "db_moonchasing.db";

		// Token: 0x040007A2 RID: 1954
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x040007A3 RID: 1955
		private const string TABLE = "BranchLine";

		// Token: 0x040007A4 RID: 1956
		private const string COMMAND = "select BinData from `BranchLine` where Id=?";

		// Token: 0x040007A5 RID: 1957
		private const string KEY_PREFIX = "BranchLineById";

		// Token: 0x040007A6 RID: 1958
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007A7 RID: 1959
		private static int HandleId;
	}
}
