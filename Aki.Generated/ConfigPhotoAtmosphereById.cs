using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006DF RID: 1759
	public class ConfigPhotoAtmosphereById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600294A RID: 10570 RVA: 0x0014661F File Offset: 0x0014481F
		static ConfigPhotoAtmosphereById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoAtmosphereById.CreateStaticDefaultValue), new Action(ConfigPhotoAtmosphereById.ResetStaticDefaultValue));
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00146640 File Offset: 0x00144840
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoAtmosphereById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoAtmosphereById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoAtmosphere"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoAtmosphere` where Id=?")
			});
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x001466BF File Offset: 0x001448BF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoAtmosphereById.LogPair = null;
			ConfigPhotoAtmosphereById.HandleId = 0;
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x001466CD File Offset: 0x001448CD
		public static void Init()
		{
			ConfigPhotoAtmosphereById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoAtmosphereById.HandleId, "db_photonew.db", "select BinData from `PhotoAtmosphere` where Id=?");
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x001466E8 File Offset: 0x001448E8
		public static PhotoAtmosphere? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoAtmosphereById.HandleId, ConfigPhotoAtmosphereById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoAtmosphereById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoAtmosphere?(PhotoAtmosphere.GetRootAsPhotoAtmosphere(configBuffer));
				}
			}
			ConfigPhotoAtmosphereById.LogPair.Clear();
			ConfigPhotoAtmosphereById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoAtmosphereById.HandleId, 1, p0Id, ConfigPhotoAtmosphereById.LogPair) || ConfigCommon.Step(ConfigPhotoAtmosphereById.HandleId, true, ConfigPhotoAtmosphereById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoAtmosphereById.HandleId, ConfigPhotoAtmosphereById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoAtmosphereById.HandleId, 0, ConfigPhotoAtmosphereById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoAtmosphereById.HandleId, ConfigPhotoAtmosphereById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoAtmosphere rootAsPhotoAtmosphere = PhotoAtmosphere.GetRootAsPhotoAtmosphere(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoAtmosphereById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoAtmosphereById.HandleId, ConfigPhotoAtmosphereById.LogPair);
			return new PhotoAtmosphere?(rootAsPhotoAtmosphere);
		}

		// Token: 0x04002FFF RID: 12287
		private const string DB = "db_photonew.db";

		// Token: 0x04003000 RID: 12288
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04003001 RID: 12289
		private const string TABLE = "PhotoAtmosphere";

		// Token: 0x04003002 RID: 12290
		private const string COMMAND = "select BinData from `PhotoAtmosphere` where Id=?";

		// Token: 0x04003003 RID: 12291
		private const string KEY_PREFIX = "PhotoAtmosphereById";

		// Token: 0x04003004 RID: 12292
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003005 RID: 12293
		private static int HandleId;
	}
}
