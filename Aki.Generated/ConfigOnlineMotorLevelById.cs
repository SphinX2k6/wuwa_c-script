using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000642 RID: 1602
	public class ConfigOnlineMotorLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600259C RID: 9628 RVA: 0x00131CF3 File Offset: 0x0012FEF3
		static ConfigOnlineMotorLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOnlineMotorLevelById.CreateStaticDefaultValue), new Action(ConfigOnlineMotorLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x00131D14 File Offset: 0x0012FF14
		public static void CreateStaticDefaultValue()
		{
			ConfigOnlineMotorLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOnlineMotorLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db.onlinemotor.db"),
				new ValueTuple<string, object>("文件", "l.联机摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "OnlineMotorLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `OnlineMotorLevel` where Id=?")
			});
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x00131D93 File Offset: 0x0012FF93
		public static void ResetStaticDefaultValue()
		{
			ConfigOnlineMotorLevelById.LogPair = null;
			ConfigOnlineMotorLevelById.HandleId = 0;
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x00131DA1 File Offset: 0x0012FFA1
		public static void Init()
		{
			ConfigOnlineMotorLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigOnlineMotorLevelById.HandleId, "db.onlinemotor.db", "select BinData from `OnlineMotorLevel` where Id=?");
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x00131DBC File Offset: 0x0012FFBC
		public static OnlineMotorLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOnlineMotorLevelById.HandleId, ConfigOnlineMotorLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OnlineMotorLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new OnlineMotorLevel?(OnlineMotorLevel.GetRootAsOnlineMotorLevel(configBuffer));
				}
			}
			ConfigOnlineMotorLevelById.LogPair.Clear();
			ConfigOnlineMotorLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigOnlineMotorLevelById.HandleId, 1, p0Id, ConfigOnlineMotorLevelById.LogPair) || ConfigCommon.Step(ConfigOnlineMotorLevelById.HandleId, true, ConfigOnlineMotorLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigOnlineMotorLevelById.HandleId, ConfigOnlineMotorLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOnlineMotorLevelById.HandleId, 0, ConfigOnlineMotorLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigOnlineMotorLevelById.HandleId, ConfigOnlineMotorLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			OnlineMotorLevel rootAsOnlineMotorLevel = OnlineMotorLevel.GetRootAsOnlineMotorLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OnlineMotorLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigOnlineMotorLevelById.HandleId, ConfigOnlineMotorLevelById.LogPair);
			return new OnlineMotorLevel?(rootAsOnlineMotorLevel);
		}

		// Token: 0x04002BB4 RID: 11188
		private const string DB = "db.onlinemotor.db";

		// Token: 0x04002BB5 RID: 11189
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x04002BB6 RID: 11190
		private const string TABLE = "OnlineMotorLevel";

		// Token: 0x04002BB7 RID: 11191
		private const string COMMAND = "select BinData from `OnlineMotorLevel` where Id=?";

		// Token: 0x04002BB8 RID: 11192
		private const string KEY_PREFIX = "OnlineMotorLevelById";

		// Token: 0x04002BB9 RID: 11193
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BBA RID: 11194
		private static int HandleId;
	}
}
