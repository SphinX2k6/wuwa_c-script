using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A62 RID: 2658
	public class ConfigUiCameraMappingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E60 RID: 15968 RVA: 0x001BAA7B File Offset: 0x001B8C7B
		static ConfigUiCameraMappingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiCameraMappingById.CreateStaticDefaultValue), new Action(ConfigUiCameraMappingById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x001BAA9C File Offset: 0x001B8C9C
		public static void CreateStaticDefaultValue()
		{
			ConfigUiCameraMappingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigUiCameraMappingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_uicamera.db"),
				new ValueTuple<string, object>("文件", "u.Ui相机.xlsx"),
				new ValueTuple<string, object>("表名", "UiCameraMapping"),
				new ValueTuple<string, object>("语句", "select BinData from `UiCameraMapping` where Id=?")
			});
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x001BAB1B File Offset: 0x001B8D1B
		public static void ResetStaticDefaultValue()
		{
			ConfigUiCameraMappingById.LogPair = null;
			ConfigUiCameraMappingById.HandleId = 0;
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x001BAB29 File Offset: 0x001B8D29
		public static void Init()
		{
			ConfigUiCameraMappingById.HandleId = ConfigCommon.InitDataStatement(ConfigUiCameraMappingById.HandleId, "db_uicamera.db", "select BinData from `UiCameraMapping` where Id=?");
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x001BAB44 File Offset: 0x001B8D44
		public static UiCameraMapping? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigUiCameraMappingById.HandleId, ConfigUiCameraMappingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("UiCameraMappingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new UiCameraMapping?(UiCameraMapping.GetRootAsUiCameraMapping(configBuffer));
				}
			}
			ConfigUiCameraMappingById.LogPair.Clear();
			ConfigUiCameraMappingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigUiCameraMappingById.HandleId, 1, p0Id, ConfigUiCameraMappingById.LogPair) || ConfigCommon.Step(ConfigUiCameraMappingById.HandleId, true, ConfigUiCameraMappingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigUiCameraMappingById.HandleId, ConfigUiCameraMappingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigUiCameraMappingById.HandleId, 0, ConfigUiCameraMappingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigUiCameraMappingById.HandleId, ConfigUiCameraMappingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			UiCameraMapping rootAsUiCameraMapping = UiCameraMapping.GetRootAsUiCameraMapping(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("UiCameraMappingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigUiCameraMappingById.HandleId, ConfigUiCameraMappingById.LogPair);
			return new UiCameraMapping?(rootAsUiCameraMapping);
		}

		// Token: 0x04004894 RID: 18580
		private const string DB = "db_uicamera.db";

		// Token: 0x04004895 RID: 18581
		private const string FILE = "u.Ui相机.xlsx";

		// Token: 0x04004896 RID: 18582
		private const string TABLE = "UiCameraMapping";

		// Token: 0x04004897 RID: 18583
		private const string COMMAND = "select BinData from `UiCameraMapping` where Id=?";

		// Token: 0x04004898 RID: 18584
		private const string KEY_PREFIX = "UiCameraMappingById";

		// Token: 0x04004899 RID: 18585
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400489A RID: 18586
		private static int HandleId;
	}
}
