using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000131 RID: 305
	public class ConfigBulletPreloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000727 RID: 1831 RVA: 0x000821B3 File Offset: 0x000803B3
		static ConfigBulletPreloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBulletPreloadById.CreateStaticDefaultValue), new Action(ConfigBulletPreloadById.ResetStaticDefaultValue));
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000821D4 File Offset: 0x000803D4
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

		// Token: 0x06000729 RID: 1833 RVA: 0x00082253 File Offset: 0x00080453
		public static void ResetStaticDefaultValue()
		{
			ConfigBulletPreloadById.LogPair = null;
			ConfigBulletPreloadById.HandleId = 0;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00082261 File Offset: 0x00080461
		public static void Init()
		{
			ConfigBulletPreloadById.HandleId = ConfigCommon.InitDataStatement(ConfigBulletPreloadById.HandleId, "db_bullet_preload.db", "select BinData from `BulletPreload` where Id=?");
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0008227C File Offset: 0x0008047C
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

		// Token: 0x0400083B RID: 2107
		private const string DB = "db_bullet_preload.db";

		// Token: 0x0400083C RID: 2108
		private const string FILE = "Preload/BulletPreload.csv";

		// Token: 0x0400083D RID: 2109
		private const string TABLE = "BulletPreload";

		// Token: 0x0400083E RID: 2110
		private const string COMMAND = "select BinData from `BulletPreload` where Id=?";

		// Token: 0x0400083F RID: 2111
		private const string KEY_PREFIX = "BulletPreloadById";

		// Token: 0x04000840 RID: 2112
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000841 RID: 2113
		private static int HandleId;
	}
}
