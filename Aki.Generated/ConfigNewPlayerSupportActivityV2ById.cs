using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200060C RID: 1548
	public class ConfigNewPlayerSupportActivityV2ById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002457 RID: 9303 RVA: 0x0012A6AB File Offset: 0x001288AB
		static ConfigNewPlayerSupportActivityV2ById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewPlayerSupportActivityV2ById.CreateStaticDefaultValue), new Action(ConfigNewPlayerSupportActivityV2ById.ResetStaticDefaultValue));
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x0012A6CC File Offset: 0x001288CC
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

		// Token: 0x06002459 RID: 9305 RVA: 0x0012A74B File Offset: 0x0012894B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewPlayerSupportActivityV2ById.LogPair = null;
			ConfigNewPlayerSupportActivityV2ById.HandleId = 0;
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x0012A759 File Offset: 0x00128959
		public static void Init()
		{
			ConfigNewPlayerSupportActivityV2ById.HandleId = ConfigCommon.InitDataStatement(ConfigNewPlayerSupportActivityV2ById.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewPlayerSupportActivityV2` where Id=?");
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x0012A774 File Offset: 0x00128974
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

		// Token: 0x04002A3A RID: 10810
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002A3B RID: 10811
		private const string FILE = "x.新玩家助力活动V2.xlsx";

		// Token: 0x04002A3C RID: 10812
		private const string TABLE = "NewPlayerSupportActivityV2";

		// Token: 0x04002A3D RID: 10813
		private const string COMMAND = "select BinData from `NewPlayerSupportActivityV2` where Id=?";

		// Token: 0x04002A3E RID: 10814
		private const string KEY_PREFIX = "NewPlayerSupportActivityV2ById";

		// Token: 0x04002A3F RID: 10815
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A40 RID: 10816
		private static int HandleId;
	}
}
