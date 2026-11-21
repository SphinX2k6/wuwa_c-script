using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200016A RID: 362
	public class ConfigChildUiCameraMappingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600087D RID: 2173 RVA: 0x0008D153 File Offset: 0x0008B353
		static ConfigChildUiCameraMappingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChildUiCameraMappingById.CreateStaticDefaultValue), new Action(ConfigChildUiCameraMappingById.ResetStaticDefaultValue));
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0008D174 File Offset: 0x0008B374
		public static void CreateStaticDefaultValue()
		{
			ConfigChildUiCameraMappingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChildUiCameraMappingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_uicamera.db"),
				new ValueTuple<string, object>("文件", "u.Ui相机.xlsx"),
				new ValueTuple<string, object>("表名", "ChildUiCameraMapping"),
				new ValueTuple<string, object>("语句", "select BinData from `ChildUiCameraMapping` where Id=?")
			});
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0008D1F3 File Offset: 0x0008B3F3
		public static void ResetStaticDefaultValue()
		{
			ConfigChildUiCameraMappingById.LogPair = null;
			ConfigChildUiCameraMappingById.HandleId = 0;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0008D201 File Offset: 0x0008B401
		public static void Init()
		{
			ConfigChildUiCameraMappingById.HandleId = ConfigCommon.InitDataStatement(ConfigChildUiCameraMappingById.HandleId, "db_uicamera.db", "select BinData from `ChildUiCameraMapping` where Id=?");
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0008D21C File Offset: 0x0008B41C
		public static ChildUiCameraMapping? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChildUiCameraMappingById.HandleId, ConfigChildUiCameraMappingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChildUiCameraMappingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ChildUiCameraMapping?(ChildUiCameraMapping.GetRootAsChildUiCameraMapping(configBuffer));
				}
			}
			ConfigChildUiCameraMappingById.LogPair.Clear();
			ConfigChildUiCameraMappingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigChildUiCameraMappingById.HandleId, 1, p0Id, ConfigChildUiCameraMappingById.LogPair) || ConfigCommon.Step(ConfigChildUiCameraMappingById.HandleId, true, ConfigChildUiCameraMappingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigChildUiCameraMappingById.HandleId, ConfigChildUiCameraMappingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChildUiCameraMappingById.HandleId, 0, ConfigChildUiCameraMappingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigChildUiCameraMappingById.HandleId, ConfigChildUiCameraMappingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ChildUiCameraMapping rootAsChildUiCameraMapping = ChildUiCameraMapping.GetRootAsChildUiCameraMapping(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ChildUiCameraMappingById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigChildUiCameraMappingById.HandleId, ConfigChildUiCameraMappingById.LogPair);
			return new ChildUiCameraMapping?(rootAsChildUiCameraMapping);
		}

		// Token: 0x040009CA RID: 2506
		private const string DB = "db_uicamera.db";

		// Token: 0x040009CB RID: 2507
		private const string FILE = "u.Ui相机.xlsx";

		// Token: 0x040009CC RID: 2508
		private const string TABLE = "ChildUiCameraMapping";

		// Token: 0x040009CD RID: 2509
		private const string COMMAND = "select BinData from `ChildUiCameraMapping` where Id=?";

		// Token: 0x040009CE RID: 2510
		private const string KEY_PREFIX = "ChildUiCameraMappingById";

		// Token: 0x040009CF RID: 2511
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009D0 RID: 2512
		private static int HandleId;
	}
}
