using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B37 RID: 2871
	public class ConfigUiCameraMappingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600435E RID: 17246 RVA: 0x001D9E0F File Offset: 0x001D800F
		static ConfigUiCameraMappingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigUiCameraMappingById.CreateStaticDefaultValue), new Action(ConfigUiCameraMappingById.ResetStaticDefaultValue));
		}

		// Token: 0x0600435F RID: 17247 RVA: 0x001D9E30 File Offset: 0x001D8030
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

		// Token: 0x06004360 RID: 17248 RVA: 0x001D9EAF File Offset: 0x001D80AF
		public static void ResetStaticDefaultValue()
		{
			ConfigUiCameraMappingById.LogPair = null;
			ConfigUiCameraMappingById.HandleId = 0;
		}

		// Token: 0x06004361 RID: 17249 RVA: 0x001D9EBD File Offset: 0x001D80BD
		public static void Init()
		{
			ConfigUiCameraMappingById.HandleId = ConfigCommon.InitDataStatement(ConfigUiCameraMappingById.HandleId, "db_uicamera.db", "select BinData from `UiCameraMapping` where Id=?");
		}

		// Token: 0x06004362 RID: 17250 RVA: 0x001D9ED8 File Offset: 0x001D80D8
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

		// Token: 0x04004E67 RID: 20071
		private const string DB = "db_uicamera.db";

		// Token: 0x04004E68 RID: 20072
		private const string FILE = "u.Ui相机.xlsx";

		// Token: 0x04004E69 RID: 20073
		private const string TABLE = "UiCameraMapping";

		// Token: 0x04004E6A RID: 20074
		private const string COMMAND = "select BinData from `UiCameraMapping` where Id=?";

		// Token: 0x04004E6B RID: 20075
		private const string KEY_PREFIX = "UiCameraMappingById";

		// Token: 0x04004E6C RID: 20076
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E6D RID: 20077
		private static int HandleId;
	}
}
