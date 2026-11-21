using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200033B RID: 827
	public class ConfigFloroRanchSubInsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001367 RID: 4967 RVA: 0x000CA9BC File Offset: 0x000C8BBC
		static ConfigFloroRanchSubInsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchSubInsById.CreateStaticDefaultValue), new Action(ConfigFloroRanchSubInsById.ResetStaticDefaultValue));
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x000CA9DC File Offset: 0x000C8BDC
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchSubInsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchSubInsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchSubIns"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchSubIns` where Id=?")
			});
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x000CAA5B File Offset: 0x000C8C5B
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchSubInsById.LogPair = null;
			ConfigFloroRanchSubInsById.HandleId = 0;
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x000CAA69 File Offset: 0x000C8C69
		public static void Init()
		{
			ConfigFloroRanchSubInsById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchSubInsById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchSubIns` where Id=?");
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x000CAA84 File Offset: 0x000C8C84
		public static FloroRanchSubIns? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchSubInsById.HandleId, ConfigFloroRanchSubInsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchSubInsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchSubIns?(FloroRanchSubIns.GetRootAsFloroRanchSubIns(configBuffer));
				}
			}
			ConfigFloroRanchSubInsById.LogPair.Clear();
			ConfigFloroRanchSubInsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchSubInsById.HandleId, 1, p0Id, ConfigFloroRanchSubInsById.LogPair) || ConfigCommon.Step(ConfigFloroRanchSubInsById.HandleId, true, ConfigFloroRanchSubInsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchSubInsById.HandleId, ConfigFloroRanchSubInsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchSubInsById.HandleId, 0, ConfigFloroRanchSubInsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchSubInsById.HandleId, ConfigFloroRanchSubInsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchSubIns rootAsFloroRanchSubIns = FloroRanchSubIns.GetRootAsFloroRanchSubIns(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchSubInsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchSubInsById.HandleId, ConfigFloroRanchSubInsById.LogPair);
			return new FloroRanchSubIns?(rootAsFloroRanchSubIns);
		}

		// Token: 0x04001681 RID: 5761
		private const string DB = "db_flororanch.db";

		// Token: 0x04001682 RID: 5762
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001683 RID: 5763
		private const string TABLE = "FloroRanchSubIns";

		// Token: 0x04001684 RID: 5764
		private const string COMMAND = "select BinData from `FloroRanchSubIns` where Id=?";

		// Token: 0x04001685 RID: 5765
		private const string KEY_PREFIX = "FloroRanchSubInsById";

		// Token: 0x04001686 RID: 5766
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001687 RID: 5767
		private static int HandleId;
	}
}
