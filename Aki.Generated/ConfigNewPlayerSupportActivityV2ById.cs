using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F4 RID: 1524
	public class ConfigNewPlayerSupportActivityV2ById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023C7 RID: 9159 RVA: 0x00123C2F File Offset: 0x00121E2F
		static ConfigNewPlayerSupportActivityV2ById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewPlayerSupportActivityV2ById.CreateStaticDefaultValue), new Action(ConfigNewPlayerSupportActivityV2ById.ResetStaticDefaultValue));
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x00123C50 File Offset: 0x00121E50
		public static void CreateStaticDefaultValue()
		{
			ConfigNewPlayerSupportActivityV2ById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewPlayerSupportActivityV2ById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新玩家助力活动V2.xlsx"),
				new ValueTuple<string, object>("表名", "NewPlayerSupportActivityV2"),
				new ValueTuple<string, object>("语句", "select BinData from `NewPlayerSupportActivityV2` where Id=?")
			});
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x00123CCF File Offset: 0x00121ECF
		public static void ResetStaticDefaultValue()
		{
			ConfigNewPlayerSupportActivityV2ById.LogPair = null;
			ConfigNewPlayerSupportActivityV2ById.HandleId = 0;
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x00123CDD File Offset: 0x00121EDD
		public static void Init()
		{
			ConfigNewPlayerSupportActivityV2ById.HandleId = ConfigCommon.InitDataStatement(ConfigNewPlayerSupportActivityV2ById.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewPlayerSupportActivityV2` where Id=?");
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x00123CF8 File Offset: 0x00121EF8
		public static NewPlayerSupportActivityV2? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewPlayerSupportActivityV2ById.HandleId, ConfigNewPlayerSupportActivityV2ById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewPlayerSupportActivityV2ById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewPlayerSupportActivityV2?(NewPlayerSupportActivityV2.GetRootAsNewPlayerSupportActivityV2(configBuffer));
				}
			}
			ConfigNewPlayerSupportActivityV2ById.LogPair.Clear();
			ConfigNewPlayerSupportActivityV2ById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNewPlayerSupportActivityV2ById.HandleId, 1, p0Id, ConfigNewPlayerSupportActivityV2ById.LogPair) || ConfigCommon.Step(ConfigNewPlayerSupportActivityV2ById.HandleId, true, ConfigNewPlayerSupportActivityV2ById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewPlayerSupportActivityV2ById.HandleId, ConfigNewPlayerSupportActivityV2ById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewPlayerSupportActivityV2ById.HandleId, 0, ConfigNewPlayerSupportActivityV2ById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewPlayerSupportActivityV2ById.HandleId, ConfigNewPlayerSupportActivityV2ById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewPlayerSupportActivityV2 rootAsNewPlayerSupportActivityV = NewPlayerSupportActivityV2.GetRootAsNewPlayerSupportActivityV2(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewPlayerSupportActivityV2ById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewPlayerSupportActivityV2ById.HandleId, ConfigNewPlayerSupportActivityV2ById.LogPair);
			return new NewPlayerSupportActivityV2?(rootAsNewPlayerSupportActivityV);
		}

		// Token: 0x04002992 RID: 10642
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002993 RID: 10643
		private const string FILE = "x.新玩家助力活动V2.xlsx";

		// Token: 0x04002994 RID: 10644
		private const string TABLE = "NewPlayerSupportActivityV2";

		// Token: 0x04002995 RID: 10645
		private const string COMMAND = "select BinData from `NewPlayerSupportActivityV2` where Id=?";

		// Token: 0x04002996 RID: 10646
		private const string KEY_PREFIX = "NewPlayerSupportActivityV2ById";

		// Token: 0x04002997 RID: 10647
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002998 RID: 10648
		private static int HandleId;
	}
}
