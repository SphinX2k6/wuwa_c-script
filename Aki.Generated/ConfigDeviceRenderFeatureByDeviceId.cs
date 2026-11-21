using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000218 RID: 536
	public class ConfigDeviceRenderFeatureByDeviceId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C93 RID: 3219 RVA: 0x000A44A5 File Offset: 0x000A26A5
		static ConfigDeviceRenderFeatureByDeviceId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDeviceRenderFeatureByDeviceId.CreateStaticDefaultValue), new Action(ConfigDeviceRenderFeatureByDeviceId.ResetStaticDefaultValue));
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x000A44C4 File Offset: 0x000A26C4
		public static void CreateStaticDefaultValue()
		{
			ConfigDeviceRenderFeatureByDeviceId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDeviceRenderFeatureByDeviceId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_device_render_feature.db"),
				new ValueTuple<string, object>("文件", "s.设置机型适配.xlsx"),
				new ValueTuple<string, object>("表名", "DeviceRenderFeature"),
				new ValueTuple<string, object>("语句", "select BinData from `DeviceRenderFeature` where DeviceId = ?")
			});
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x000A4543 File Offset: 0x000A2743
		public static void ResetStaticDefaultValue()
		{
			ConfigDeviceRenderFeatureByDeviceId.LogPair = null;
			ConfigDeviceRenderFeatureByDeviceId.HandleId = 0;
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x000A4551 File Offset: 0x000A2751
		public static void Init()
		{
			ConfigDeviceRenderFeatureByDeviceId.HandleId = ConfigCommon.InitDataStatement(ConfigDeviceRenderFeatureByDeviceId.HandleId, "db_device_render_feature.db", "select BinData from `DeviceRenderFeature` where DeviceId = ?");
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x000A456C File Offset: 0x000A276C
		[NullableContext(2)]
		public static IReadOnlyList<DeviceRenderFeature> GetConfigList(int p0DeviceId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDeviceRenderFeatureByDeviceId.HandleId, ConfigDeviceRenderFeatureByDeviceId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DeviceRenderFeatureByDeviceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DeviceId);
				IReadOnlyList<DeviceRenderFeature> readOnlyList = (IReadOnlyList<DeviceRenderFeature>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigDeviceRenderFeatureByDeviceId.LogPair.Clear();
			ConfigDeviceRenderFeatureByDeviceId.LogPair.Add(new ValueTuple<string, object>("DeviceId", p0DeviceId));
			if (!ConfigCommon.BindInt(ConfigDeviceRenderFeatureByDeviceId.HandleId, 1, p0DeviceId, ConfigDeviceRenderFeatureByDeviceId.LogPair))
			{
				ConfigCommon.Reset(ConfigDeviceRenderFeatureByDeviceId.HandleId, ConfigDeviceRenderFeatureByDeviceId.LogPair);
				return null;
			}
			List<DeviceRenderFeature> list = new List<DeviceRenderFeature>();
			while (ConfigCommon.Step(ConfigDeviceRenderFeatureByDeviceId.HandleId, false, ConfigDeviceRenderFeatureByDeviceId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDeviceRenderFeatureByDeviceId.HandleId, 0, ConfigDeviceRenderFeatureByDeviceId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDeviceRenderFeatureByDeviceId.HandleId, ConfigDeviceRenderFeatureByDeviceId.LogPair);
					return null;
				}
				DeviceRenderFeature rootAsDeviceRenderFeature = DeviceRenderFeature.GetRootAsDeviceRenderFeature(new ByteBuffer(item2));
				list.Add(rootAsDeviceRenderFeature);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DeviceRenderFeatureByDeviceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DeviceId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigDeviceRenderFeatureByDeviceId.HandleId, ConfigDeviceRenderFeatureByDeviceId.LogPair);
			return list;
		}

		// Token: 0x04000E8C RID: 3724
		private const string DB = "db_device_render_feature.db";

		// Token: 0x04000E8D RID: 3725
		private const string FILE = "s.设置机型适配.xlsx";

		// Token: 0x04000E8E RID: 3726
		private const string TABLE = "DeviceRenderFeature";

		// Token: 0x04000E8F RID: 3727
		private const string COMMAND = "select BinData from `DeviceRenderFeature` where DeviceId = ?";

		// Token: 0x04000E90 RID: 3728
		private const string KEY_PREFIX = "DeviceRenderFeatureByDeviceId";

		// Token: 0x04000E91 RID: 3729
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E92 RID: 3730
		private static int HandleId;
	}
}
