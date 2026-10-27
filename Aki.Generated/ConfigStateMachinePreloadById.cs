using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000992 RID: 2450
	public class ConfigStateMachinePreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003980 RID: 14720 RVA: 0x0019E9C1 File Offset: 0x0019CBC1
		static ConfigStateMachinePreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigStateMachinePreloadById.CreateStaticDefaultValue), new Action(ConfigStateMachinePreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x0019E9E0 File Offset: 0x0019CBE0
		public static void CreateStaticDefaultValue()
		{
			ConfigStateMachinePreloadById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigStateMachinePreloadById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_state_machine_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/StateMachinePreload.csv"),
				new ValueTuple<string, object>("表名", "StateMachinePreload"),
				new ValueTuple<string, object>("语句", "select BinData from `StateMachinePreload` where Id=?")
			});
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x0019EA5F File Offset: 0x0019CC5F
		public static void ResetStaticDefaultValue()
		{
			ConfigStateMachinePreloadById.LogPair = null;
			ConfigStateMachinePreloadById.HandleId = 0;
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x0019EA6D File Offset: 0x0019CC6D
		public static void Init()
		{
			ConfigStateMachinePreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigStateMachinePreloadById.HandleId, "db_state_machine_preload.db", "select BinData from `StateMachinePreload` where Id=?");
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x0019EA88 File Offset: 0x0019CC88
		public static StateMachinePreload? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigStateMachinePreloadById.HandleId, ConfigStateMachinePreloadById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("StateMachinePreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new StateMachinePreload?(StateMachinePreload.GetRootAsStateMachinePreload(configBuffer));
				}
			}
			ConfigStateMachinePreloadById.LogPair.Clear();
			ConfigStateMachinePreloadById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigStateMachinePreloadById.HandleId, 1, p0Id, ConfigStateMachinePreloadById.LogPair) || ConfigCommon.Step(ConfigStateMachinePreloadById.HandleId, true, ConfigStateMachinePreloadById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigStateMachinePreloadById.HandleId, ConfigStateMachinePreloadById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigStateMachinePreloadById.HandleId, 0, ConfigStateMachinePreloadById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigStateMachinePreloadById.HandleId, ConfigStateMachinePreloadById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			StateMachinePreload rootAsStateMachinePreload = StateMachinePreload.GetRootAsStateMachinePreload(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("StateMachinePreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigStateMachinePreloadById.HandleId, ConfigStateMachinePreloadById.LogPair);
			return new StateMachinePreload?(rootAsStateMachinePreload);
		}

		// Token: 0x040042E4 RID: 17124
		private const string DB = "db_state_machine_preload.db";

		// Token: 0x040042E5 RID: 17125
		private const string FILE = "Preload/StateMachinePreload.csv";

		// Token: 0x040042E6 RID: 17126
		private const string TABLE = "StateMachinePreload";

		// Token: 0x040042E7 RID: 17127
		private const string COMMAND = "select BinData from `StateMachinePreload` where Id=?";

		// Token: 0x040042E8 RID: 17128
		private const string KEY_PREFIX = "StateMachinePreloadById";

		// Token: 0x040042E9 RID: 17129
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042EA RID: 17130
		private static int HandleId;
	}
}
