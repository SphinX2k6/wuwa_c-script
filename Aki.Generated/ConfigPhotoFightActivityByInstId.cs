using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E9 RID: 1769
	public class ConfigPhotoFightActivityByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002986 RID: 10630 RVA: 0x00147AB4 File Offset: 0x00145CB4
		static ConfigPhotoFightActivityByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightActivityByInstId.CreateStaticDefaultValue), new Action(ConfigPhotoFightActivityByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x00147AD4 File Offset: 0x00145CD4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFightActivityByInstId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFightActivityByInstId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照战斗活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFightActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFightActivity` where InstId=?")
			});
		}

		// Token: 0x06002988 RID: 10632 RVA: 0x00147B53 File Offset: 0x00145D53
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightActivityByInstId.LogPair = null;
			ConfigPhotoFightActivityByInstId.HandleId = 0;
		}

		// Token: 0x06002989 RID: 10633 RVA: 0x00147B61 File Offset: 0x00145D61
		public static void Init()
		{
			ConfigPhotoFightActivityByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightActivityByInstId.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightActivity` where InstId=?");
		}

		// Token: 0x0600298A RID: 10634 RVA: 0x00147B7C File Offset: 0x00145D7C
		public static PhotoFightActivity? GetConfig(int p0InstId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFightActivityByInstId.HandleId, ConfigPhotoFightActivityByInstId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFightActivityByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoFightActivity?(PhotoFightActivity.GetRootAsPhotoFightActivity(configBuffer));
				}
			}
			ConfigPhotoFightActivityByInstId.LogPair.Clear();
			ConfigPhotoFightActivityByInstId.LogPair.Add(new ValueTuple<string, object>("InstId", p0InstId));
			if (!ConfigCommon.BindInt(ConfigPhotoFightActivityByInstId.HandleId, 1, p0InstId, ConfigPhotoFightActivityByInstId.LogPair) || ConfigCommon.Step(ConfigPhotoFightActivityByInstId.HandleId, true, ConfigPhotoFightActivityByInstId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoFightActivityByInstId.HandleId, ConfigPhotoFightActivityByInstId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFightActivityByInstId.HandleId, 0, ConfigPhotoFightActivityByInstId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoFightActivityByInstId.HandleId, ConfigPhotoFightActivityByInstId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoFightActivity rootAsPhotoFightActivity = PhotoFightActivity.GetRootAsPhotoFightActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFightActivityByInstId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoFightActivityByInstId.HandleId, ConfigPhotoFightActivityByInstId.LogPair);
			return new PhotoFightActivity?(rootAsPhotoFightActivity);
		}

		// Token: 0x04003045 RID: 12357
		private const string DB = "db_fightphotograph.db";

		// Token: 0x04003046 RID: 12358
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x04003047 RID: 12359
		private const string TABLE = "PhotoFightActivity";

		// Token: 0x04003048 RID: 12360
		private const string COMMAND = "select BinData from `PhotoFightActivity` where InstId=?";

		// Token: 0x04003049 RID: 12361
		private const string KEY_PREFIX = "PhotoFightActivityByInstId";

		// Token: 0x0400304A RID: 12362
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400304B RID: 12363
		private static int HandleId;
	}
}
