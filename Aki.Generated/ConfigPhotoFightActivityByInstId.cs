using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D1 RID: 1745
	public class ConfigPhotoFightActivityByInstId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028F6 RID: 10486 RVA: 0x00141038 File Offset: 0x0013F238
		static ConfigPhotoFightActivityByInstId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightActivityByInstId.CreateStaticDefaultValue), new Action(ConfigPhotoFightActivityByInstId.ResetStaticDefaultValue));
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x00141058 File Offset: 0x0013F258
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

		// Token: 0x060028F8 RID: 10488 RVA: 0x001410D7 File Offset: 0x0013F2D7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightActivityByInstId.LogPair = null;
			ConfigPhotoFightActivityByInstId.HandleId = 0;
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x001410E5 File Offset: 0x0013F2E5
		public static void Init()
		{
			ConfigPhotoFightActivityByInstId.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightActivityByInstId.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightActivity` where InstId=?");
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x00141100 File Offset: 0x0013F300
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

		// Token: 0x04002F9D RID: 12189
		private const string DB = "db_fightphotograph.db";

		// Token: 0x04002F9E RID: 12190
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x04002F9F RID: 12191
		private const string TABLE = "PhotoFightActivity";

		// Token: 0x04002FA0 RID: 12192
		private const string COMMAND = "select BinData from `PhotoFightActivity` where InstId=?";

		// Token: 0x04002FA1 RID: 12193
		private const string KEY_PREFIX = "PhotoFightActivityByInstId";

		// Token: 0x04002FA2 RID: 12194
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FA3 RID: 12195
		private static int HandleId;
	}
}
