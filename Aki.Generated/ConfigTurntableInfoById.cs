using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B33 RID: 2867
	public class ConfigTurntableInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004346 RID: 17222 RVA: 0x001D95A4 File Offset: 0x001D77A4
		static ConfigTurntableInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTurntableInfoById.CreateStaticDefaultValue), new Action(ConfigTurntableInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x001D95C4 File Offset: 0x001D77C4
		public static void CreateStaticDefaultValue()
		{
			ConfigTurntableInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTurntableInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_turntableactivity.db"),
				new ValueTuple<string, object>("文件", "z.转盘活动.xlsx"),
				new ValueTuple<string, object>("表名", "TurntableInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `TurntableInfo` where Id=?")
			});
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x001D9643 File Offset: 0x001D7843
		public static void ResetStaticDefaultValue()
		{
			ConfigTurntableInfoById.LogPair = null;
			ConfigTurntableInfoById.HandleId = 0;
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x001D9651 File Offset: 0x001D7851
		public static void Init()
		{
			ConfigTurntableInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigTurntableInfoById.HandleId, "db_turntableactivity.db", "select BinData from `TurntableInfo` where Id=?");
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x001D966C File Offset: 0x001D786C
		public static TurntableInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTurntableInfoById.HandleId, ConfigTurntableInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TurntableInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TurntableInfo?(TurntableInfo.GetRootAsTurntableInfo(configBuffer));
				}
			}
			ConfigTurntableInfoById.LogPair.Clear();
			ConfigTurntableInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTurntableInfoById.HandleId, 1, p0Id, ConfigTurntableInfoById.LogPair) || ConfigCommon.Step(ConfigTurntableInfoById.HandleId, true, ConfigTurntableInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTurntableInfoById.HandleId, ConfigTurntableInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTurntableInfoById.HandleId, 0, ConfigTurntableInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTurntableInfoById.HandleId, ConfigTurntableInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TurntableInfo rootAsTurntableInfo = TurntableInfo.GetRootAsTurntableInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TurntableInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTurntableInfoById.HandleId, ConfigTurntableInfoById.LogPair);
			return new TurntableInfo?(rootAsTurntableInfo);
		}

		// Token: 0x04004E4B RID: 20043
		private const string DB = "db_turntableactivity.db";

		// Token: 0x04004E4C RID: 20044
		private const string FILE = "z.转盘活动.xlsx";

		// Token: 0x04004E4D RID: 20045
		private const string TABLE = "TurntableInfo";

		// Token: 0x04004E4E RID: 20046
		private const string COMMAND = "select BinData from `TurntableInfo` where Id=?";

		// Token: 0x04004E4F RID: 20047
		private const string KEY_PREFIX = "TurntableInfoById";

		// Token: 0x04004E50 RID: 20048
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E51 RID: 20049
		private static int HandleId;
	}
}
