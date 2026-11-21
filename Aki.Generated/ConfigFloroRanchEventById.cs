using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200032D RID: 813
	public class ConfigFloroRanchEventById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001313 RID: 4883 RVA: 0x000C8CBB File Offset: 0x000C6EBB
		static ConfigFloroRanchEventById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchEventById.CreateStaticDefaultValue), new Action(ConfigFloroRanchEventById.ResetStaticDefaultValue));
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x000C8CDC File Offset: 0x000C6EDC
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchEventById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchEventById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchEvent"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchEvent` where Id=?")
			});
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x000C8D5B File Offset: 0x000C6F5B
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchEventById.LogPair = null;
			ConfigFloroRanchEventById.HandleId = 0;
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x000C8D69 File Offset: 0x000C6F69
		public static void Init()
		{
			ConfigFloroRanchEventById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchEventById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchEvent` where Id=?");
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x000C8D84 File Offset: 0x000C6F84
		public static FloroRanchEvent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchEventById.HandleId, ConfigFloroRanchEventById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchEvent?(FloroRanchEvent.GetRootAsFloroRanchEvent(configBuffer));
				}
			}
			ConfigFloroRanchEventById.LogPair.Clear();
			ConfigFloroRanchEventById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchEventById.HandleId, 1, p0Id, ConfigFloroRanchEventById.LogPair) || ConfigCommon.Step(ConfigFloroRanchEventById.HandleId, true, ConfigFloroRanchEventById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchEventById.HandleId, ConfigFloroRanchEventById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchEventById.HandleId, 0, ConfigFloroRanchEventById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchEventById.HandleId, ConfigFloroRanchEventById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchEvent rootAsFloroRanchEvent = FloroRanchEvent.GetRootAsFloroRanchEvent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchEventById.HandleId, ConfigFloroRanchEventById.LogPair);
			return new FloroRanchEvent?(rootAsFloroRanchEvent);
		}

		// Token: 0x0400161F RID: 5663
		private const string DB = "db_flororanch.db";

		// Token: 0x04001620 RID: 5664
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001621 RID: 5665
		private const string TABLE = "FloroRanchEvent";

		// Token: 0x04001622 RID: 5666
		private const string COMMAND = "select BinData from `FloroRanchEvent` where Id=?";

		// Token: 0x04001623 RID: 5667
		private const string KEY_PREFIX = "FloroRanchEventById";

		// Token: 0x04001624 RID: 5668
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001625 RID: 5669
		private static int HandleId;
	}
}
