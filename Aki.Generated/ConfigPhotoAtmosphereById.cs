using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C7 RID: 1735
	public class ConfigPhotoAtmosphereById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028BA RID: 10426 RVA: 0x0013FBA3 File Offset: 0x0013DDA3
		static ConfigPhotoAtmosphereById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoAtmosphereById.CreateStaticDefaultValue), new Action(ConfigPhotoAtmosphereById.ResetStaticDefaultValue));
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x0013FBC4 File Offset: 0x0013DDC4
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

		// Token: 0x060028BC RID: 10428 RVA: 0x0013FC43 File Offset: 0x0013DE43
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoAtmosphereById.LogPair = null;
			ConfigPhotoAtmosphereById.HandleId = 0;
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x0013FC51 File Offset: 0x0013DE51
		public static void Init()
		{
			ConfigPhotoAtmosphereById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoAtmosphereById.HandleId, "db_photonew.db", "select BinData from `PhotoAtmosphere` where Id=?");
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x0013FC6C File Offset: 0x0013DE6C
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

		// Token: 0x04002F57 RID: 12119
		private const string DB = "db_photonew.db";

		// Token: 0x04002F58 RID: 12120
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x04002F59 RID: 12121
		private const string TABLE = "PhotoAtmosphere";

		// Token: 0x04002F5A RID: 12122
		private const string COMMAND = "select BinData from `PhotoAtmosphere` where Id=?";

		// Token: 0x04002F5B RID: 12123
		private const string KEY_PREFIX = "PhotoAtmosphereById";

		// Token: 0x04002F5C RID: 12124
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F5D RID: 12125
		private static int HandleId;
	}
}
