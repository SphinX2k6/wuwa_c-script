using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F1 RID: 1777
	public class ConfigPhotoFilterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029B6 RID: 10678 RVA: 0x001489F3 File Offset: 0x00146BF3
		static ConfigPhotoFilterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFilterById.CreateStaticDefaultValue), new Action(ConfigPhotoFilterById.ResetStaticDefaultValue));
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x00148A14 File Offset: 0x00146C14
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFilterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFilterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFilter"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFilter` where Id=?")
			});
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x00148A93 File Offset: 0x00146C93
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFilterById.LogPair = null;
			ConfigPhotoFilterById.HandleId = 0;
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x00148AA1 File Offset: 0x00146CA1
		public static void Init()
		{
			ConfigPhotoFilterById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFilterById.HandleId, "db_photograph.db", "select BinData from `PhotoFilter` where Id=?");
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x00148ABC File Offset: 0x00146CBC
		public static PhotoFilter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFilterById.HandleId, ConfigPhotoFilterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoFilter?(PhotoFilter.GetRootAsPhotoFilter(configBuffer));
				}
			}
			ConfigPhotoFilterById.LogPair.Clear();
			ConfigPhotoFilterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoFilterById.HandleId, 1, p0Id, ConfigPhotoFilterById.LogPair) || ConfigCommon.Step(ConfigPhotoFilterById.HandleId, true, ConfigPhotoFilterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoFilterById.HandleId, ConfigPhotoFilterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFilterById.HandleId, 0, ConfigPhotoFilterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoFilterById.HandleId, ConfigPhotoFilterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoFilter rootAsPhotoFilter = PhotoFilter.GetRootAsPhotoFilter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFilterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoFilterById.HandleId, ConfigPhotoFilterById.LogPair);
			return new PhotoFilter?(rootAsPhotoFilter);
		}

		// Token: 0x0400307D RID: 12413
		private const string DB = "db_photograph.db";

		// Token: 0x0400307E RID: 12414
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x0400307F RID: 12415
		private const string TABLE = "PhotoFilter";

		// Token: 0x04003080 RID: 12416
		private const string COMMAND = "select BinData from `PhotoFilter` where Id=?";

		// Token: 0x04003081 RID: 12417
		private const string KEY_PREFIX = "PhotoFilterById";

		// Token: 0x04003082 RID: 12418
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003083 RID: 12419
		private static int HandleId;
	}
}
