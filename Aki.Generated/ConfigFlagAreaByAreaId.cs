using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002F2 RID: 754
	public class ConfigFlagAreaByAreaId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011B1 RID: 4529 RVA: 0x000BD7BF File Offset: 0x000BB9BF
		static ConfigFlagAreaByAreaId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagAreaByAreaId.CreateStaticDefaultValue), new Action(ConfigFlagAreaByAreaId.ResetStaticDefaultValue));
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x000BD7E0 File Offset: 0x000BB9E0
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

		// Token: 0x060011B3 RID: 4531 RVA: 0x000BD85F File Offset: 0x000BBA5F
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagAreaByAreaId.LogPair = null;
			ConfigFlagAreaByAreaId.HandleId = 0;
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x000BD86D File Offset: 0x000BBA6D
		public static void Init()
		{
			ConfigFlagAreaByAreaId.HandleId = ConfigCommon.InitDataStatement(ConfigFlagAreaByAreaId.HandleId, "db_moraleplay.db", "select BinData from `FlagArea` where FlagAreaId=?");
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x000BD888 File Offset: 0x000BBA88
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

		// Token: 0x04001482 RID: 5250
		private const string DB = "db_moraleplay.db";

		// Token: 0x04001483 RID: 5251
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04001484 RID: 5252
		private const string TABLE = "FlagArea";

		// Token: 0x04001485 RID: 5253
		private const string COMMAND = "select BinData from `FlagArea` where FlagAreaId=?";

		// Token: 0x04001486 RID: 5254
		private const string KEY_PREFIX = "FlagAreaByAreaId";

		// Token: 0x04001487 RID: 5255
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001488 RID: 5256
		private static int HandleId;
	}
}
