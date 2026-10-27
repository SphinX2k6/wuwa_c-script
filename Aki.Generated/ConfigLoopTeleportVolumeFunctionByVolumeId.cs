using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004F2 RID: 1266
	public class ConfigLoopTeleportVolumeFunctionByVolumeId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DB7 RID: 7607 RVA: 0x001013F4 File Offset: 0x000FF5F4
		static ConfigLoopTeleportVolumeFunctionByVolumeId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLoopTeleportVolumeFunctionByVolumeId.CreateStaticDefaultValue), new Action(ConfigLoopTeleportVolumeFunctionByVolumeId.ResetStaticDefaultValue));
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x00101414 File Offset: 0x000FF614
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

		// Token: 0x06001DB9 RID: 7609 RVA: 0x00101493 File Offset: 0x000FF693
		public static void ResetStaticDefaultValue()
		{
			ConfigLoopTeleportVolumeFunctionByVolumeId.LogPair = null;
			ConfigLoopTeleportVolumeFunctionByVolumeId.HandleId = 0;
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x001014A1 File Offset: 0x000FF6A1
		public static void Init()
		{
			ConfigLoopTeleportVolumeFunctionByVolumeId.HandleId = ConfigCommon.InitDataStatement(ConfigLoopTeleportVolumeFunctionByVolumeId.HandleId, "db_loopteleportvolumefunction.db", "select BinData from `LoopTeleportVolumeFunction` where VolumeId = ?");
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x001014BC File Offset: 0x000FF6BC
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

		// Token: 0x04002282 RID: 8834
		private const string DB = "db_loopteleportvolumefunction.db";

		// Token: 0x04002283 RID: 8835
		private const string FILE = "k.可视化编辑/c.Csv/c.循环传送Volume功能/*.csv*";

		// Token: 0x04002284 RID: 8836
		private const string TABLE = "LoopTeleportVolumeFunction";

		// Token: 0x04002285 RID: 8837
		private const string COMMAND = "select BinData from `LoopTeleportVolumeFunction` where VolumeId = ?";

		// Token: 0x04002286 RID: 8838
		private const string KEY_PREFIX = "LoopTeleportVolumeFunctionByVolumeId";

		// Token: 0x04002287 RID: 8839
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002288 RID: 8840
		private static int HandleId;
	}
}
