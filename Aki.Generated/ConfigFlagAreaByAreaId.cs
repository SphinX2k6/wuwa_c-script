using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000307 RID: 775
	public class ConfigFlagAreaByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600122F RID: 4655 RVA: 0x000C3CCB File Offset: 0x000C1ECB
		static ConfigFlagAreaByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagAreaByAreaId.CreateStaticDefaultValue), new Action(ConfigFlagAreaByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x000C3CEC File Offset: 0x000C1EEC
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagAreaByAreaId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagAreaByAreaId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "FlagArea"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagArea` where FlagAreaId=?")
			});
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x000C3D6B File Offset: 0x000C1F6B
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagAreaByAreaId.LogPair = null;
			ConfigFlagAreaByAreaId.HandleId = 0;
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x000C3D79 File Offset: 0x000C1F79
		public static void Init()
		{
			ConfigFlagAreaByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigFlagAreaByAreaId.HandleId, "db_moraleplay.db", "select BinData from `FlagArea` where FlagAreaId=?");
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x000C3D94 File Offset: 0x000C1F94
		[NullableContext(2)]
		public static IReadOnlyList<FlagArea> GetConfigList(int p0FlagAreaId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagAreaByAreaId.HandleId, ConfigFlagAreaByAreaId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagAreaByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FlagAreaId);
				IReadOnlyList<FlagArea> readOnlyList = (IReadOnlyList<FlagArea>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFlagAreaByAreaId.LogPair.Clear();
			ConfigFlagAreaByAreaId.LogPair.Add(new ValueTuple<string, object>("FlagAreaId", p0FlagAreaId));
			if (!ConfigCommon.BindInt(ConfigFlagAreaByAreaId.HandleId, 1, p0FlagAreaId, ConfigFlagAreaByAreaId.LogPair))
			{
				ConfigCommon.Reset(ConfigFlagAreaByAreaId.HandleId, ConfigFlagAreaByAreaId.LogPair);
				return null;
			}
			List<FlagArea> list = new List<FlagArea>();
			while (ConfigCommon.Step(ConfigFlagAreaByAreaId.HandleId, false, ConfigFlagAreaByAreaId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagAreaByAreaId.HandleId, 0, ConfigFlagAreaByAreaId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFlagAreaByAreaId.HandleId, ConfigFlagAreaByAreaId.LogPair);
					return null;
				}
				FlagArea rootAsFlagArea = FlagArea.GetRootAsFlagArea(new ByteBuffer(item2));
				list.Add(rootAsFlagArea);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagAreaByAreaId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FlagAreaId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFlagAreaByAreaId.HandleId, ConfigFlagAreaByAreaId.LogPair);
			return list;
		}

		// Token: 0x04001515 RID: 5397
		private const string DB = "db_moraleplay.db";

		// Token: 0x04001516 RID: 5398
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04001517 RID: 5399
		private const string TABLE = "FlagArea";

		// Token: 0x04001518 RID: 5400
		private const string COMMAND = "select BinData from `FlagArea` where FlagAreaId=?";

		// Token: 0x04001519 RID: 5401
		private const string KEY_PREFIX = "FlagAreaByAreaId";

		// Token: 0x0400151A RID: 5402
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400151B RID: 5403
		private static int HandleId;
	}
}
