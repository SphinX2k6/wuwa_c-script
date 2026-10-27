using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006F5 RID: 1781
	public class ConfigPhotoSetupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060029CE RID: 10702 RVA: 0x00145B9F File Offset: 0x00143D9F
		static ConfigPhotoSetupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoSetupById.CreateStaticDefaultValue), new Action(ConfigPhotoSetupById.ResetStaticDefaultValue));
		}

		// Token: 0x060029CF RID: 10703 RVA: 0x00145BC0 File Offset: 0x00143DC0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoSetupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoSetupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_photograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoSetup"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoSetup` where Id=?")
			});
		}

		// Token: 0x060029D0 RID: 10704 RVA: 0x00145C3F File Offset: 0x00143E3F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoSetupById.LogPair = null;
			ConfigPhotoSetupById.HandleId = 0;
		}

		// Token: 0x060029D1 RID: 10705 RVA: 0x00145C4D File Offset: 0x00143E4D
		public static void Init()
		{
			ConfigPhotoSetupById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoSetupById.HandleId, "db_photograph.db", "select BinData from `PhotoSetup` where Id=?");
		}

		// Token: 0x060029D2 RID: 10706 RVA: 0x00145C68 File Offset: 0x00143E68
		public static PhotoSetup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoSetupById.HandleId, ConfigPhotoSetupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoSetupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoSetup?(PhotoSetup.GetRootAsPhotoSetup(configBuffer));
				}
			}
			ConfigPhotoSetupById.LogPair.Clear();
			ConfigPhotoSetupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoSetupById.HandleId, 1, p0Id, ConfigPhotoSetupById.LogPair) || ConfigCommon.Step(ConfigPhotoSetupById.HandleId, true, ConfigPhotoSetupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoSetupById.HandleId, ConfigPhotoSetupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoSetupById.HandleId, 0, ConfigPhotoSetupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoSetupById.HandleId, ConfigPhotoSetupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoSetup rootAsPhotoSetup = PhotoSetup.GetRootAsPhotoSetup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoSetupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoSetupById.HandleId, ConfigPhotoSetupById.LogPair);
			return new PhotoSetup?(rootAsPhotoSetup);
		}

		// Token: 0x04003099 RID: 12441
		private const string DB = "db_photograph.db";

		// Token: 0x0400309A RID: 12442
		private const string FILE = "p.拍照.xlsx";

		// Token: 0x0400309B RID: 12443
		private const string TABLE = "PhotoSetup";

		// Token: 0x0400309C RID: 12444
		private const string COMMAND = "select BinData from `PhotoSetup` where Id=?";

		// Token: 0x0400309D RID: 12445
		private const string KEY_PREFIX = "PhotoSetupById";

		// Token: 0x0400309E RID: 12446
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400309F RID: 12447
		private static int HandleId;
	}
}
