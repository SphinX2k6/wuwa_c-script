using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000431 RID: 1073
	public class ConfigImmersiveMouseByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600192F RID: 6447 RVA: 0x000EBA97 File Offset: 0x000E9C97
		static ConfigImmersiveMouseByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigImmersiveMouseByViewName.CreateStaticDefaultValue), new Action(ConfigImmersiveMouseByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x000EBAB8 File Offset: 0x000E9CB8
		public static void CreateStaticDefaultValue()
		{
			ConfigImmersiveMouseByViewName.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigImmersiveMouseByViewName.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "ImmersiveMouse"),
				new ValueTuple<string, object>("语句", "select BinData from `ImmersiveMouse` where ViewName=?")
			});
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x000EBB37 File Offset: 0x000E9D37
		public static void ResetStaticDefaultValue()
		{
			ConfigImmersiveMouseByViewName.LogPair = null;
			ConfigImmersiveMouseByViewName.HandleId = 0;
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x000EBB45 File Offset: 0x000E9D45
		public static void Init()
		{
			ConfigImmersiveMouseByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigImmersiveMouseByViewName.HandleId, "db_input_settings.db", "select BinData from `ImmersiveMouse` where ViewName=?");
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x000EBB60 File Offset: 0x000E9D60
		public static ImmersiveMouse? GetConfig(string p0ViewName, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigImmersiveMouseByViewName.HandleId, ConfigImmersiveMouseByViewName.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("ImmersiveMouseByViewName#" + p0ViewName);
				if (configBuffer != null)
				{
					return new ImmersiveMouse?(ImmersiveMouse.GetRootAsImmersiveMouse(configBuffer));
				}
			}
			ConfigImmersiveMouseByViewName.LogPair.Clear();
			ConfigImmersiveMouseByViewName.LogPair.Add(new ValueTuple<string, object>("ViewName", p0ViewName));
			if (!ConfigCommon.BindString(ConfigImmersiveMouseByViewName.HandleId, 1, p0ViewName, ConfigImmersiveMouseByViewName.LogPair) || ConfigCommon.Step(ConfigImmersiveMouseByViewName.HandleId, true, ConfigImmersiveMouseByViewName.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigImmersiveMouseByViewName.HandleId, ConfigImmersiveMouseByViewName.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigImmersiveMouseByViewName.HandleId, 0, ConfigImmersiveMouseByViewName.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigImmersiveMouseByViewName.HandleId, ConfigImmersiveMouseByViewName.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ImmersiveMouse rootAsImmersiveMouse = ImmersiveMouse.GetRootAsImmersiveMouse(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("ImmersiveMouseByViewName#" + p0ViewName, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigImmersiveMouseByViewName.HandleId, ConfigImmersiveMouseByViewName.LogPair);
			return new ImmersiveMouse?(rootAsImmersiveMouse);
		}

		// Token: 0x04001D3B RID: 7483
		private const string DB = "db_input_settings.db";

		// Token: 0x04001D3C RID: 7484
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04001D3D RID: 7485
		private const string TABLE = "ImmersiveMouse";

		// Token: 0x04001D3E RID: 7486
		private const string COMMAND = "select BinData from `ImmersiveMouse` where ViewName=?";

		// Token: 0x04001D3F RID: 7487
		private const string KEY_PREFIX = "ImmersiveMouseByViewName";

		// Token: 0x04001D40 RID: 7488
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D41 RID: 7489
		private static int HandleId;
	}
}
