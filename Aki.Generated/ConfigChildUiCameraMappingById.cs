using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200015A RID: 346
	public class ConfigChildUiCameraMappingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600081D RID: 2077 RVA: 0x000875F7 File Offset: 0x000857F7
		static ConfigChildUiCameraMappingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChildUiCameraMappingById.CreateStaticDefaultValue), new Action(ConfigChildUiCameraMappingById.ResetStaticDefaultValue));
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00087618 File Offset: 0x00085818
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

		// Token: 0x0600081F RID: 2079 RVA: 0x00087697 File Offset: 0x00085897
		public static void ResetStaticDefaultValue()
		{
			ConfigChildUiCameraMappingById.LogPair = null;
			ConfigChildUiCameraMappingById.HandleId = 0;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000876A5 File Offset: 0x000858A5
		public static void Init()
		{
			ConfigChildUiCameraMappingById.HandleId = ConfigCommon.InitDataStatement(ConfigChildUiCameraMappingById.HandleId, "db_uicamera.db", "select BinData from `ChildUiCameraMapping` where Id=?");
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x000876C0 File Offset: 0x000858C0
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

		// Token: 0x0400095A RID: 2394
		private const string DB = "db_uicamera.db";

		// Token: 0x0400095B RID: 2395
		private const string FILE = "u.Ui相机.xlsx";

		// Token: 0x0400095C RID: 2396
		private const string TABLE = "ChildUiCameraMapping";

		// Token: 0x0400095D RID: 2397
		private const string COMMAND = "select BinData from `ChildUiCameraMapping` where Id=?";

		// Token: 0x0400095E RID: 2398
		private const string KEY_PREFIX = "ChildUiCameraMappingById";

		// Token: 0x0400095F RID: 2399
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000960 RID: 2400
		private static int HandleId;
	}
}
