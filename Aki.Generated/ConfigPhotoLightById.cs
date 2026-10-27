using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E0 RID: 1760
	public class ConfigPhotoLightById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002950 RID: 10576 RVA: 0x00142D43 File Offset: 0x00140F43
		static ConfigPhotoLightById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoLightById.CreateStaticDefaultValue), new Action(ConfigPhotoLightById.ResetStaticDefaultValue));
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x00142D64 File Offset: 0x00140F64
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoLightById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoLightById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoLight"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoLight` where Id=?")
			});
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x00142DE3 File Offset: 0x00140FE3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoLightById.LogPair = null;
			ConfigPhotoLightById.HandleId = 0;
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x00142DF1 File Offset: 0x00140FF1
		public static void Init()
		{
			ConfigPhotoLightById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoLightById.HandleId, "db_photonew.db", "select BinData from `PhotoLight` where Id=?");
		}

		// Token: 0x06002954 RID: 10580 RVA: 0x00142E0C File Offset: 0x0014100C
		public static PhotoLight? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoLightById.HandleId, ConfigPhotoLightById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoLightById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoLight?(PhotoLight.GetRootAsPhotoLight(configBuffer));
				}
			}
			ConfigPhotoLightById.LogPair.Clear();
			ConfigPhotoLightById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoLightById.HandleId, 1, p0Id, ConfigPhotoLightById.LogPair) || ConfigCommon.Step(ConfigPhotoLightById.HandleId, true, ConfigPhotoLightById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoLightById.HandleId, ConfigPhotoLightById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoLightById.HandleId, 0, ConfigPhotoLightById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoLightById.HandleId, ConfigPhotoLightById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoLight rootAsPhotoLight = PhotoLight.GetRootAsPhotoLight(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoLightById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoLightById.HandleId, ConfigPhotoLightById.LogPair);
			return new PhotoLight?(rootAsPhotoLight);
		}

		// Token: 0x04003006 RID: 12294
		private const string DB = "db_photonew.db";

		// Token: 0x04003007 RID: 12295
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003008 RID: 12296
		private const string TABLE = "PhotoLight";

		// Token: 0x04003009 RID: 12297
		private const string COMMAND = "select BinData from `PhotoLight` where Id=?";

		// Token: 0x0400300A RID: 12298
		private const string KEY_PREFIX = "PhotoLightById";

		// Token: 0x0400300B RID: 12299
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400300C RID: 12300
		private static int HandleId;
	}
}
