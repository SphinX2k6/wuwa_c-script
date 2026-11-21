using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B8 RID: 952
	public class ConfigGmAccountById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001657 RID: 5719 RVA: 0x000DB61F File Offset: 0x000D981F
		static ConfigGmAccountById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmAccountById.CreateStaticDefaultValue), new Action(ConfigGmAccountById.ResetStaticDefaultValue));
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x000DB640 File Offset: 0x000D9840
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

		// Token: 0x06001659 RID: 5721 RVA: 0x000DB6BF File Offset: 0x000D98BF
		public static void ResetStaticDefaultValue()
		{
			ConfigGmAccountById.LogPair = null;
			ConfigGmAccountById.HandleId = 0;
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x000DB6CD File Offset: 0x000D98CD
		public static void Init()
		{
			ConfigGmAccountById.HandleId = ConfigCommon.InitDataStatement(ConfigGmAccountById.HandleId, "db_gm.db", "select BinData from `GmAccount` where Id=?");
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x000DB6E8 File Offset: 0x000D98E8
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

		// Token: 0x040019EC RID: 6636
		private const string DB = "db_gm.db";

		// Token: 0x040019ED RID: 6637
		private const string FILE = "g.GM.xlsx";

		// Token: 0x040019EE RID: 6638
		private const string TABLE = "GmAccount";

		// Token: 0x040019EF RID: 6639
		private const string COMMAND = "select BinData from `GmAccount` where Id=?";

		// Token: 0x040019F0 RID: 6640
		private const string KEY_PREFIX = "GmAccountById";

		// Token: 0x040019F1 RID: 6641
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019F2 RID: 6642
		private static int HandleId;
	}
}
