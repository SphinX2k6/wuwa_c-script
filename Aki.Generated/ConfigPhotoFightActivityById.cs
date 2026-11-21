using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006E8 RID: 1768
	public class ConfigPhotoFightActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002980 RID: 10624 RVA: 0x0014786B File Offset: 0x00145A6B
		static ConfigPhotoFightActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotoFightActivityById.CreateStaticDefaultValue), new Action(ConfigPhotoFightActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x0014788C File Offset: 0x00145A8C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotoFightActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotoFightActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fightphotograph.db"),
				new ValueTuple<string, object>("文件", "p.拍照战斗活动.xlsx"),
				new ValueTuple<string, object>("表名", "PhotoFightActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotoFightActivity` where Id=?")
			});
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x0014790B File Offset: 0x00145B0B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotoFightActivityById.LogPair = null;
			ConfigPhotoFightActivityById.HandleId = 0;
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x00147919 File Offset: 0x00145B19
		public static void Init()
		{
			ConfigPhotoFightActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigPhotoFightActivityById.HandleId, "db_fightphotograph.db", "select BinData from `PhotoFightActivity` where Id=?");
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x00147934 File Offset: 0x00145B34
		public static PhotoFightActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotoFightActivityById.HandleId, ConfigPhotoFightActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFightActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhotoFightActivity?(PhotoFightActivity.GetRootAsPhotoFightActivity(configBuffer));
				}
			}
			ConfigPhotoFightActivityById.LogPair.Clear();
			ConfigPhotoFightActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhotoFightActivityById.HandleId, 1, p0Id, ConfigPhotoFightActivityById.LogPair) || ConfigCommon.Step(ConfigPhotoFightActivityById.HandleId, true, ConfigPhotoFightActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhotoFightActivityById.HandleId, ConfigPhotoFightActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotoFightActivityById.HandleId, 0, ConfigPhotoFightActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhotoFightActivityById.HandleId, ConfigPhotoFightActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhotoFightActivity rootAsPhotoFightActivity = PhotoFightActivity.GetRootAsPhotoFightActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhotoFightActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhotoFightActivityById.HandleId, ConfigPhotoFightActivityById.LogPair);
			return new PhotoFightActivity?(rootAsPhotoFightActivity);
		}

		// Token: 0x0400303E RID: 12350
		private const string DB = "db_fightphotograph.db";

		// Token: 0x0400303F RID: 12351
		private const string FILE = "p.拍照战斗活动.xlsx";

		// Token: 0x04003040 RID: 12352
		private const string TABLE = "PhotoFightActivity";

		// Token: 0x04003041 RID: 12353
		private const string COMMAND = "select BinData from `PhotoFightActivity` where Id=?";

		// Token: 0x04003042 RID: 12354
		private const string KEY_PREFIX = "PhotoFightActivityById";

		// Token: 0x04003043 RID: 12355
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003044 RID: 12356
		private static int HandleId;
	}
}
