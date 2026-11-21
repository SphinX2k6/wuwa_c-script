using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200012A RID: 298
	public class ConfigBranchLineById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006FD RID: 1789 RVA: 0x00084AFF File Offset: 0x00082CFF
		static ConfigBranchLineById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBranchLineById.CreateStaticDefaultValue), new Action(ConfigBranchLineById.ResetStaticDefaultValue));
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00084B20 File Offset: 0x00082D20
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

		// Token: 0x060006FF RID: 1791 RVA: 0x00084B9F File Offset: 0x00082D9F
		public static void ResetStaticDefaultValue()
		{
			ConfigBranchLineById.LogPair = null;
			ConfigBranchLineById.HandleId = 0;
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00084BAD File Offset: 0x00082DAD
		public static void Init()
		{
			ConfigBranchLineById.HandleId = ConfigCommon.InitDataStatement(ConfigBranchLineById.HandleId, "db_moonchasing.db", "select BinData from `BranchLine` where Id=?");
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00084BC8 File Offset: 0x00082DC8
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

		// Token: 0x0400080A RID: 2058
		private const string DB = "db_moonchasing.db";

		// Token: 0x0400080B RID: 2059
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400080C RID: 2060
		private const string TABLE = "BranchLine";

		// Token: 0x0400080D RID: 2061
		private const string COMMAND = "select BinData from `BranchLine` where Id=?";

		// Token: 0x0400080E RID: 2062
		private const string KEY_PREFIX = "BranchLineById";

		// Token: 0x0400080F RID: 2063
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000810 RID: 2064
		private static int HandleId;
	}
}
