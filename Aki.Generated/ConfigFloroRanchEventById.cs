using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000318 RID: 792
	public class ConfigFloroRanchEventById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001295 RID: 4757 RVA: 0x000C27AF File Offset: 0x000C09AF
		static ConfigFloroRanchEventById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchEventById.CreateStaticDefaultValue), new Action(ConfigFloroRanchEventById.ResetStaticDefaultValue));
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x000C27D0 File Offset: 0x000C09D0
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

		// Token: 0x06001297 RID: 4759 RVA: 0x000C284F File Offset: 0x000C0A4F
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchEventById.LogPair = null;
			ConfigFloroRanchEventById.HandleId = 0;
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x000C285D File Offset: 0x000C0A5D
		public static void Init()
		{
			ConfigFloroRanchEventById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchEventById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchEvent` where Id=?");
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x000C2878 File Offset: 0x000C0A78
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

		// Token: 0x0400158C RID: 5516
		private const string DB = "db_flororanch.db";

		// Token: 0x0400158D RID: 5517
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400158E RID: 5518
		private const string TABLE = "FloroRanchEvent";

		// Token: 0x0400158F RID: 5519
		private const string COMMAND = "select BinData from `FloroRanchEvent` where Id=?";

		// Token: 0x04001590 RID: 5520
		private const string KEY_PREFIX = "FloroRanchEventById";

		// Token: 0x04001591 RID: 5521
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001592 RID: 5522
		private static int HandleId;
	}
}
