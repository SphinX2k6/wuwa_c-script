using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000140 RID: 320
	public class ConfigBulletPreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000781 RID: 1921 RVA: 0x00087B17 File Offset: 0x00085D17
		static ConfigBulletPreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBulletPreloadById.CreateStaticDefaultValue), new Action(ConfigBulletPreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00087B38 File Offset: 0x00085D38
		public static void CreateStaticDefaultValue()
		{
			ConfigBulletPreloadById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBulletPreloadById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_bullet_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/BulletPreload.csv"),
				new ValueTuple<string, object>("表名", "BulletPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `BulletPreload` where Id=?")
			});
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00087BB7 File Offset: 0x00085DB7
		public static void ResetStaticDefaultValue()
		{
			ConfigBulletPreloadById.LogPair = null;
			ConfigBulletPreloadById.HandleId = 0;
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00087BC5 File Offset: 0x00085DC5
		public static void Init()
		{
			ConfigBulletPreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigBulletPreloadById.HandleId, "db_bullet_preload.db", "select BinData from `BulletPreload` where Id=?");
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00087BE0 File Offset: 0x00085DE0
		public static BulletPreload? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBulletPreloadById.HandleId, ConfigBulletPreloadById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BulletPreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BulletPreload?(BulletPreload.GetRootAsBulletPreload(configBuffer));
				}
			}
			ConfigBulletPreloadById.LogPair.Clear();
			ConfigBulletPreloadById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBulletPreloadById.HandleId, 1, p0Id, ConfigBulletPreloadById.LogPair) || ConfigCommon.Step(ConfigBulletPreloadById.HandleId, true, ConfigBulletPreloadById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBulletPreloadById.HandleId, ConfigBulletPreloadById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBulletPreloadById.HandleId, 0, ConfigBulletPreloadById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBulletPreloadById.HandleId, ConfigBulletPreloadById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BulletPreload rootAsBulletPreload = BulletPreload.GetRootAsBulletPreload(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BulletPreloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBulletPreloadById.HandleId, ConfigBulletPreloadById.LogPair);
			return new BulletPreload?(rootAsBulletPreload);
		}

		// Token: 0x040008A4 RID: 2212
		private const string DB = "db_bullet_preload.db";

		// Token: 0x040008A5 RID: 2213
		private const string FILE = "Preload/BulletPreload.csv";

		// Token: 0x040008A6 RID: 2214
		private const string TABLE = "BulletPreload";

		// Token: 0x040008A7 RID: 2215
		private const string COMMAND = "select BinData from `BulletPreload` where Id=?";

		// Token: 0x040008A8 RID: 2216
		private const string KEY_PREFIX = "BulletPreloadById";

		// Token: 0x040008A9 RID: 2217
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008AA RID: 2218
		private static int HandleId;
	}
}
