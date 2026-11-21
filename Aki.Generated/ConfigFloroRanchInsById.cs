using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000332 RID: 818
	public class ConfigFloroRanchInsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001331 RID: 4913 RVA: 0x000C975F File Offset: 0x000C795F
		static ConfigFloroRanchInsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchInsById.CreateStaticDefaultValue), new Action(ConfigFloroRanchInsById.ResetStaticDefaultValue));
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x000C9780 File Offset: 0x000C7980
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchInsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchInsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchIns"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchIns` where Id=?")
			});
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x000C97FF File Offset: 0x000C79FF
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchInsById.LogPair = null;
			ConfigFloroRanchInsById.HandleId = 0;
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x000C980D File Offset: 0x000C7A0D
		public static void Init()
		{
			ConfigFloroRanchInsById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchInsById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchIns` where Id=?");
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x000C9828 File Offset: 0x000C7A28
		public static FloroRanchIns? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchInsById.HandleId, ConfigFloroRanchInsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchInsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchIns?(FloroRanchIns.GetRootAsFloroRanchIns(configBuffer));
				}
			}
			ConfigFloroRanchInsById.LogPair.Clear();
			ConfigFloroRanchInsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchInsById.HandleId, 1, p0Id, ConfigFloroRanchInsById.LogPair) || ConfigCommon.Step(ConfigFloroRanchInsById.HandleId, true, ConfigFloroRanchInsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchInsById.HandleId, ConfigFloroRanchInsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchInsById.HandleId, 0, ConfigFloroRanchInsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchInsById.HandleId, ConfigFloroRanchInsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchIns rootAsFloroRanchIns = FloroRanchIns.GetRootAsFloroRanchIns(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchInsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchInsById.HandleId, ConfigFloroRanchInsById.LogPair);
			return new FloroRanchIns?(rootAsFloroRanchIns);
		}

		// Token: 0x04001642 RID: 5698
		private const string DB = "db_flororanch.db";

		// Token: 0x04001643 RID: 5699
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001644 RID: 5700
		private const string TABLE = "FloroRanchIns";

		// Token: 0x04001645 RID: 5701
		private const string COMMAND = "select BinData from `FloroRanchIns` where Id=?";

		// Token: 0x04001646 RID: 5702
		private const string KEY_PREFIX = "FloroRanchInsById";

		// Token: 0x04001647 RID: 5703
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001648 RID: 5704
		private static int HandleId;
	}
}
