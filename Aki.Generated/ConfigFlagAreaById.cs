using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000309 RID: 777
	public class ConfigFlagAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600123B RID: 4667 RVA: 0x000C414C File Offset: 0x000C234C
		static ConfigFlagAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagAreaById.CreateStaticDefaultValue), new Action(ConfigFlagAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x000C416C File Offset: 0x000C236C
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagAreaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagAreaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "FlagArea"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagArea` where Id=?")
			});
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000C41EB File Offset: 0x000C23EB
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagAreaById.LogPair = null;
			ConfigFlagAreaById.HandleId = 0;
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x000C41F9 File Offset: 0x000C23F9
		public static void Init()
		{
			ConfigFlagAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigFlagAreaById.HandleId, "db_moraleplay.db", "select BinData from `FlagArea` where Id=?");
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x000C4214 File Offset: 0x000C2414
		public static FlagArea? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagAreaById.HandleId, ConfigFlagAreaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlagArea?(FlagArea.GetRootAsFlagArea(configBuffer));
				}
			}
			ConfigFlagAreaById.LogPair.Clear();
			ConfigFlagAreaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFlagAreaById.HandleId, 1, p0Id, ConfigFlagAreaById.LogPair) || ConfigCommon.Step(ConfigFlagAreaById.HandleId, true, ConfigFlagAreaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlagAreaById.HandleId, ConfigFlagAreaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagAreaById.HandleId, 0, ConfigFlagAreaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlagAreaById.HandleId, ConfigFlagAreaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlagArea rootAsFlagArea = FlagArea.GetRootAsFlagArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlagAreaById.HandleId, ConfigFlagAreaById.LogPair);
			return new FlagArea?(rootAsFlagArea);
		}

		// Token: 0x04001523 RID: 5411
		private const string DB = "db_moraleplay.db";

		// Token: 0x04001524 RID: 5412
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04001525 RID: 5413
		private const string TABLE = "FlagArea";

		// Token: 0x04001526 RID: 5414
		private const string COMMAND = "select BinData from `FlagArea` where Id=?";

		// Token: 0x04001527 RID: 5415
		private const string KEY_PREFIX = "FlagAreaById";

		// Token: 0x04001528 RID: 5416
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001529 RID: 5417
		private static int HandleId;
	}
}
