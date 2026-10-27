using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200041B RID: 1051
	public class ConfigImmersiveMouseByViewName : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018AB RID: 6315 RVA: 0x000E5343 File Offset: 0x000E3543
		static ConfigImmersiveMouseByViewName()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigImmersiveMouseByViewName.CreateStaticDefaultValue), new Action(ConfigImmersiveMouseByViewName.ResetStaticDefaultValue));
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x000E5364 File Offset: 0x000E3564
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

		// Token: 0x060018AD RID: 6317 RVA: 0x000E53E3 File Offset: 0x000E35E3
		public static void ResetStaticDefaultValue()
		{
			ConfigImmersiveMouseByViewName.LogPair = null;
			ConfigImmersiveMouseByViewName.HandleId = 0;
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x000E53F1 File Offset: 0x000E35F1
		public static void Init()
		{
			ConfigImmersiveMouseByViewName.HandleId = ConfigCommon.InitDataStatement(ConfigImmersiveMouseByViewName.HandleId, "db_input_settings.db", "select BinData from `ImmersiveMouse` where ViewName=?");
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x000E540C File Offset: 0x000E360C
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

		// Token: 0x04001CA1 RID: 7329
		private const string DB = "db_input_settings.db";

		// Token: 0x04001CA2 RID: 7330
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04001CA3 RID: 7331
		private const string TABLE = "ImmersiveMouse";

		// Token: 0x04001CA4 RID: 7332
		private const string COMMAND = "select BinData from `ImmersiveMouse` where ViewName=?";

		// Token: 0x04001CA5 RID: 7333
		private const string KEY_PREFIX = "ImmersiveMouseByViewName";

		// Token: 0x04001CA6 RID: 7334
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CA7 RID: 7335
		private static int HandleId;
	}
}
