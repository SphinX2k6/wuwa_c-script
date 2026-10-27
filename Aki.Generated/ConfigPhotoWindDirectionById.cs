using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000705 RID: 1797
	public class ConfigPhotoWindDirectionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A2E RID: 10798 RVA: 0x00147BD7 File Offset: 0x00145DD7
		static ConfigPhotoWindDirectionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoWindDirectionById.CreateStaticDefaultValue), new Action(ConfigPhotoWindDirectionById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x00147BF8 File Offset: 0x00145DF8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoWindDirectionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoWindDirectionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photonew.db"),
				new ValueTuple<string, object>("文件", "p.拍照新.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoWindDirection"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoWindDirection` where Id=?")
			});
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x00147C77 File Offset: 0x00145E77
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoWindDirectionById.LogPair = null;
			ConfigPhotoWindDirectionById.HandleId = 0;
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x00147C85 File Offset: 0x00145E85
		public static void Init()
		{
			ConfigPhotoWindDirectionById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoWindDirectionById.HandleId, "db_photonew.db", "select BinData from `PhotoWindDirection` where Id=?");
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x00147CA0 File Offset: 0x00145EA0
		public static PhotoWindDirection? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoWindDirectionById.HandleId, ConfigPhotoWindDirectionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoWindDirectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoWindDirection?(PhotoWindDirection.GetRootAsPhotoWindDirection(configBuffer));
				}
			}
			ConfigPhotoWindDirectionById.LogPair.Clear();
			ConfigPhotoWindDirectionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoWindDirectionById.HandleId, 1, p0Id, ConfigPhotoWindDirectionById.LogPair) || ConfigCommon.Step(ConfigPhotoWindDirectionById.HandleId, true, ConfigPhotoWindDirectionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoWindDirectionById.HandleId, ConfigPhotoWindDirectionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoWindDirectionById.HandleId, 0, ConfigPhotoWindDirectionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoWindDirectionById.HandleId, ConfigPhotoWindDirectionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoWindDirection rootAsPhotoWindDirection = PhotoWindDirection.GetRootAsPhotoWindDirection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoWindDirectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoWindDirectionById.HandleId, ConfigPhotoWindDirectionById.LogPair);
			return new PhotoWindDirection?(rootAsPhotoWindDirection);
		}

		// Token: 0x04003109 RID: 12553
		private const string DB = "db_photonew.db";

		// Token: 0x0400310A RID: 12554
		private const string FILE = "p.拍照新.xlsx";

		// Token: 0x0400310B RID: 12555
		private const string TABLE = "PhotoWindDirection";

		// Token: 0x0400310C RID: 12556
		private const string COMMAND = "select BinData from `PhotoWindDirection` where Id=?";

		// Token: 0x0400310D RID: 12557
		private const string KEY_PREFIX = "PhotoWindDirectionById";

		// Token: 0x0400310E RID: 12558
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400310F RID: 12559
		private static int HandleId;
	}
}
