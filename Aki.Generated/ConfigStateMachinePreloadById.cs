using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A67 RID: 2663
	public class ConfigStateMachinePreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E7E RID: 15998 RVA: 0x001BDD55 File Offset: 0x001BBF55
		static ConfigStateMachinePreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigStateMachinePreloadById.CreateStaticDefaultValue), new Action(ConfigStateMachinePreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E7F RID: 15999 RVA: 0x001BDD74 File Offset: 0x001BBF74
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

		// Token: 0x06003E80 RID: 16000 RVA: 0x001BDDF3 File Offset: 0x001BBFF3
		public static void ResetStaticDefaultValue()
		{
			ConfigStateMachinePreloadById.LogPair = null;
			ConfigStateMachinePreloadById.HandleId = 0;
		}

		// Token: 0x06003E81 RID: 16001 RVA: 0x001BDE01 File Offset: 0x001BC001
		public static void Init()
		{
			ConfigStateMachinePreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigStateMachinePreloadById.HandleId, "db_state_machine_preload.db", "select BinData from `StateMachinePreload` where Id=?");
		}

		// Token: 0x06003E82 RID: 16002 RVA: 0x001BDE1C File Offset: 0x001BC01C
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

		// Token: 0x040048B7 RID: 18615
		private const string DB = "db_state_machine_preload.db";

		// Token: 0x040048B8 RID: 18616
		private const string FILE = "Preload/StateMachinePreload.csv";

		// Token: 0x040048B9 RID: 18617
		private const string TABLE = "StateMachinePreload";

		// Token: 0x040048BA RID: 18618
		private const string COMMAND = "select BinData from `StateMachinePreload` where Id=?";

		// Token: 0x040048BB RID: 18619
		private const string KEY_PREFIX = "StateMachinePreloadById";

		// Token: 0x040048BC RID: 18620
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048BD RID: 18621
		private static int HandleId;
	}
}
