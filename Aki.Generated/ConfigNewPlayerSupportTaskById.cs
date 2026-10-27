using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F6 RID: 1526
	public class ConfigNewPlayerSupportTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023D3 RID: 9171 RVA: 0x0012400B File Offset: 0x0012220B
		static ConfigNewPlayerSupportTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewPlayerSupportTaskById.CreateStaticDefaultValue), new Action(ConfigNewPlayerSupportTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x0012402C File Offset: 0x0012222C
		public static void CreateStaticDefaultValue()
		{
			ConfigNewPlayerSupportTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewPlayerSupportTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupport.db"),
				new ValueTuple<string, object>("文件", "x.新玩家助力活动.xlsx"),
				new ValueTuple<string, object>("表名", "NewPlayerSupportTask"),
				new ValueTuple<string, object>("语句", "select BinData from `NewPlayerSupportTask` where Id=?")
			});
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x001240AB File Offset: 0x001222AB
		public static void ResetStaticDefaultValue()
		{
			ConfigNewPlayerSupportTaskById.LogPair = null;
			ConfigNewPlayerSupportTaskById.HandleId = 0;
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x001240B9 File Offset: 0x001222B9
		public static void Init()
		{
			ConfigNewPlayerSupportTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigNewPlayerSupportTaskById.HandleId, "db_newplayersupport.db", "select BinData from `NewPlayerSupportTask` where Id=?");
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x001240D4 File Offset: 0x001222D4
		public static NewPlayerSupportTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewPlayerSupportTaskById.HandleId, ConfigNewPlayerSupportTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewPlayerSupportTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewPlayerSupportTask?(NewPlayerSupportTask.GetRootAsNewPlayerSupportTask(configBuffer));
				}
			}
			ConfigNewPlayerSupportTaskById.LogPair.Clear();
			ConfigNewPlayerSupportTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewPlayerSupportTaskById.HandleId, 1, p0Id, ConfigNewPlayerSupportTaskById.LogPair) || ConfigCommon.Step(ConfigNewPlayerSupportTaskById.HandleId, true, ConfigNewPlayerSupportTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewPlayerSupportTaskById.HandleId, ConfigNewPlayerSupportTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewPlayerSupportTaskById.HandleId, 0, ConfigNewPlayerSupportTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewPlayerSupportTaskById.HandleId, ConfigNewPlayerSupportTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewPlayerSupportTask rootAsNewPlayerSupportTask = NewPlayerSupportTask.GetRootAsNewPlayerSupportTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewPlayerSupportTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewPlayerSupportTaskById.HandleId, ConfigNewPlayerSupportTaskById.LogPair);
			return new NewPlayerSupportTask?(rootAsNewPlayerSupportTask);
		}

		// Token: 0x040029A0 RID: 10656
		private const string DB = "db_newplayersupport.db";

		// Token: 0x040029A1 RID: 10657
		private const string FILE = "x.新玩家助力活动.xlsx";

		// Token: 0x040029A2 RID: 10658
		private const string TABLE = "NewPlayerSupportTask";

		// Token: 0x040029A3 RID: 10659
		private const string COMMAND = "select BinData from `NewPlayerSupportTask` where Id=?";

		// Token: 0x040029A4 RID: 10660
		private const string KEY_PREFIX = "NewPlayerSupportTaskById";

		// Token: 0x040029A5 RID: 10661
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029A6 RID: 10662
		private static int HandleId;
	}
}
