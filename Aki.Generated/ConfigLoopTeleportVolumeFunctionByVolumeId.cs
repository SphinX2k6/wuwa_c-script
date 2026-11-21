using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000508 RID: 1288
	public class ConfigLoopTeleportVolumeFunctionByVolumeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E3B RID: 7739 RVA: 0x00107B48 File Offset: 0x00105D48
		static ConfigLoopTeleportVolumeFunctionByVolumeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLoopTeleportVolumeFunctionByVolumeId.CreateStaticDefaultValue), new Action(ConfigLoopTeleportVolumeFunctionByVolumeId.ResetStaticDefaultValue));
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00107B68 File Offset: 0x00105D68
		public static void CreateStaticDefaultValue()
		{
			ConfigLoopTeleportVolumeFunctionByVolumeId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLoopTeleportVolumeFunctionByVolumeId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_loopteleportvolumefunction.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/c.循环传送Volume功能/*.csv*"),
				new ValueTuple<string, object>("表名", "LoopTeleportVolumeFunction"),
				new ValueTuple<string, object>("语句", "select BinData from `LoopTeleportVolumeFunction` where VolumeId = ?")
			});
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00107BE7 File Offset: 0x00105DE7
		public static void ResetStaticDefaultValue()
		{
			ConfigLoopTeleportVolumeFunctionByVolumeId.LogPair = null;
			ConfigLoopTeleportVolumeFunctionByVolumeId.HandleId = 0;
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00107BF5 File Offset: 0x00105DF5
		public static void Init()
		{
			ConfigLoopTeleportVolumeFunctionByVolumeId.HandleId = ConfigCommon.InitDataStatement(ConfigLoopTeleportVolumeFunctionByVolumeId.HandleId, "db_loopteleportvolumefunction.db", "select BinData from `LoopTeleportVolumeFunction` where VolumeId = ?");
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x00107C10 File Offset: 0x00105E10
		[NullableContext(2)]
		public static IReadOnlyList<LoopTeleportVolumeFunction> GetConfigList(int p0VolumeId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLoopTeleportVolumeFunctionByVolumeId.HandleId, ConfigLoopTeleportVolumeFunctionByVolumeId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LoopTeleportVolumeFunctionByVolumeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0VolumeId);
				IReadOnlyList<LoopTeleportVolumeFunction> readOnlyList = (IReadOnlyList<LoopTeleportVolumeFunction>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigLoopTeleportVolumeFunctionByVolumeId.LogPair.Clear();
			ConfigLoopTeleportVolumeFunctionByVolumeId.LogPair.Add(new ValueTuple<string, object>("VolumeId", p0VolumeId));
			if (!ConfigCommon.BindInt(ConfigLoopTeleportVolumeFunctionByVolumeId.HandleId, 1, p0VolumeId, ConfigLoopTeleportVolumeFunctionByVolumeId.LogPair))
			{
				ConfigCommon.Reset(ConfigLoopTeleportVolumeFunctionByVolumeId.HandleId, ConfigLoopTeleportVolumeFunctionByVolumeId.LogPair);
				return null;
			}
			List<LoopTeleportVolumeFunction> list = new List<LoopTeleportVolumeFunction>();
			while (ConfigCommon.Step(ConfigLoopTeleportVolumeFunctionByVolumeId.HandleId, false, ConfigLoopTeleportVolumeFunctionByVolumeId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLoopTeleportVolumeFunctionByVolumeId.HandleId, 0, ConfigLoopTeleportVolumeFunctionByVolumeId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLoopTeleportVolumeFunctionByVolumeId.HandleId, ConfigLoopTeleportVolumeFunctionByVolumeId.LogPair);
					return null;
				}
				LoopTeleportVolumeFunction rootAsLoopTeleportVolumeFunction = LoopTeleportVolumeFunction.GetRootAsLoopTeleportVolumeFunction(new ByteBuffer(item2));
				list.Add(rootAsLoopTeleportVolumeFunction);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LoopTeleportVolumeFunctionByVolumeId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0VolumeId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigLoopTeleportVolumeFunctionByVolumeId.HandleId, ConfigLoopTeleportVolumeFunctionByVolumeId.LogPair);
			return list;
		}

		// Token: 0x0400231C RID: 8988
		private const string DB = "db_loopteleportvolumefunction.db";

		// Token: 0x0400231D RID: 8989
		private const string FILE = "k.可视化编辑/c.Csv/c.循环传送Volume功能/*.csv*";

		// Token: 0x0400231E RID: 8990
		private const string TABLE = "LoopTeleportVolumeFunction";

		// Token: 0x0400231F RID: 8991
		private const string COMMAND = "select BinData from `LoopTeleportVolumeFunction` where VolumeId = ?";

		// Token: 0x04002320 RID: 8992
		private const string KEY_PREFIX = "LoopTeleportVolumeFunctionByVolumeId";

		// Token: 0x04002321 RID: 8993
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002322 RID: 8994
		private static int HandleId;
	}
}
