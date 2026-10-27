using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A2 RID: 930
	public class ConfigGmAccountById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015D3 RID: 5587 RVA: 0x000D4ECB File Offset: 0x000D30CB
		static ConfigGmAccountById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmAccountById.CreateStaticDefaultValue), new Action(ConfigGmAccountById.ResetStaticDefaultValue));
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x000D4EEC File Offset: 0x000D30EC
		public static void CreateStaticDefaultValue()
		{
			ConfigGmAccountById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGmAccountById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gm.db"),
				new ValueTuple<string, object>("文件", "g.GM.xlsx"),
				new ValueTuple<string, object>("表名", "GmAccount"),
				new ValueTuple<string, object>("语句", "select BinData from `GmAccount` where Id=?")
			});
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x000D4F6B File Offset: 0x000D316B
		public static void ResetStaticDefaultValue()
		{
			ConfigGmAccountById.LogPair = null;
			ConfigGmAccountById.HandleId = 0;
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x000D4F79 File Offset: 0x000D3179
		public static void Init()
		{
			ConfigGmAccountById.HandleId = ConfigCommon.InitDataStatement(ConfigGmAccountById.HandleId, "db_gm.db", "select BinData from `GmAccount` where Id=?");
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x000D4F94 File Offset: 0x000D3194
		public static GmAccount? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGmAccountById.HandleId, ConfigGmAccountById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GmAccountById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GmAccount?(GmAccount.GetRootAsGmAccount(configBuffer));
				}
			}
			ConfigGmAccountById.LogPair.Clear();
			ConfigGmAccountById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGmAccountById.HandleId, 1, p0Id, ConfigGmAccountById.LogPair) || ConfigCommon.Step(ConfigGmAccountById.HandleId, true, ConfigGmAccountById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGmAccountById.HandleId, ConfigGmAccountById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGmAccountById.HandleId, 0, ConfigGmAccountById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGmAccountById.HandleId, ConfigGmAccountById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GmAccount rootAsGmAccount = GmAccount.GetRootAsGmAccount(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GmAccountById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGmAccountById.HandleId, ConfigGmAccountById.LogPair);
			return new GmAccount?(rootAsGmAccount);
		}

		// Token: 0x04001952 RID: 6482
		private const string DB = "db_gm.db";

		// Token: 0x04001953 RID: 6483
		private const string FILE = "g.GM.xlsx";

		// Token: 0x04001954 RID: 6484
		private const string TABLE = "GmAccount";

		// Token: 0x04001955 RID: 6485
		private const string COMMAND = "select BinData from `GmAccount` where Id=?";

		// Token: 0x04001956 RID: 6486
		private const string KEY_PREFIX = "GmAccountById";

		// Token: 0x04001957 RID: 6487
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001958 RID: 6488
		private static int HandleId;
	}
}
