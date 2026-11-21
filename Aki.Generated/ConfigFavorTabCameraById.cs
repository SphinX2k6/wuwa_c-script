using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002CD RID: 717
	public class ConfigFavorTabCameraById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060010D3 RID: 4307 RVA: 0x000BC17F File Offset: 0x000BA37F
		static ConfigFavorTabCameraById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFavorTabCameraById.CreateStaticDefaultValue), new Action(ConfigFavorTabCameraById.ResetStaticDefaultValue));
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x000BC1A0 File Offset: 0x000BA3A0
		public static void CreateStaticDefaultValue()
		{
			ConfigFavorTabCameraById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFavorTabCameraById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_favor.db"),
				new ValueTuple<string, object>("文件", "h.好感度.xlsx"),
				new ValueTuple<string, object>("表名", "FavorTabCamera"),
				new ValueTuple<string, object>("语句", "select BinData from `FavorTabCamera` where Id=?")
			});
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x000BC21F File Offset: 0x000BA41F
		public static void ResetStaticDefaultValue()
		{
			ConfigFavorTabCameraById.LogPair = null;
			ConfigFavorTabCameraById.HandleId = 0;
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x000BC22D File Offset: 0x000BA42D
		public static void Init()
		{
			ConfigFavorTabCameraById.HandleId = ConfigCommon.InitDataStatement(ConfigFavorTabCameraById.HandleId, "db_favor.db", "select BinData from `FavorTabCamera` where Id=?");
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x000BC248 File Offset: 0x000BA448
		public static FavorTabCamera? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFavorTabCameraById.HandleId, ConfigFavorTabCameraById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FavorTabCameraById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FavorTabCamera?(FavorTabCamera.GetRootAsFavorTabCamera(configBuffer));
				}
			}
			ConfigFavorTabCameraById.LogPair.Clear();
			ConfigFavorTabCameraById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFavorTabCameraById.HandleId, 1, p0Id, ConfigFavorTabCameraById.LogPair) || ConfigCommon.Step(ConfigFavorTabCameraById.HandleId, true, ConfigFavorTabCameraById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFavorTabCameraById.HandleId, ConfigFavorTabCameraById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFavorTabCameraById.HandleId, 0, ConfigFavorTabCameraById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFavorTabCameraById.HandleId, ConfigFavorTabCameraById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FavorTabCamera rootAsFavorTabCamera = FavorTabCamera.GetRootAsFavorTabCamera(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FavorTabCameraById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFavorTabCameraById.HandleId, ConfigFavorTabCameraById.LogPair);
			return new FavorTabCamera?(rootAsFavorTabCamera);
		}

		// Token: 0x0400137F RID: 4991
		private const string DB = "db_favor.db";

		// Token: 0x04001380 RID: 4992
		private const string FILE = "h.好感度.xlsx";

		// Token: 0x04001381 RID: 4993
		private const string TABLE = "FavorTabCamera";

		// Token: 0x04001382 RID: 4994
		private const string COMMAND = "select BinData from `FavorTabCamera` where Id=?";

		// Token: 0x04001383 RID: 4995
		private const string KEY_PREFIX = "FavorTabCameraById";

		// Token: 0x04001384 RID: 4996
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001385 RID: 4997
		private static int HandleId;
	}
}
