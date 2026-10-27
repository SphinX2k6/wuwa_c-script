using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B8 RID: 696
	public class ConfigFavorTabCameraById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001055 RID: 4181 RVA: 0x000B5C73 File Offset: 0x000B3E73
		static ConfigFavorTabCameraById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFavorTabCameraById.CreateStaticDefaultValue), new Action(ConfigFavorTabCameraById.ResetStaticDefaultValue));
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x000B5C94 File Offset: 0x000B3E94
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

		// Token: 0x06001057 RID: 4183 RVA: 0x000B5D13 File Offset: 0x000B3F13
		public static void ResetStaticDefaultValue()
		{
			ConfigFavorTabCameraById.LogPair = null;
			ConfigFavorTabCameraById.HandleId = 0;
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x000B5D21 File Offset: 0x000B3F21
		public static void Init()
		{
			ConfigFavorTabCameraById.HandleId = ConfigCommon.InitDataStatement(ConfigFavorTabCameraById.HandleId, "db_favor.db", "select BinData from `FavorTabCamera` where Id=?");
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x000B5D3C File Offset: 0x000B3F3C
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

		// Token: 0x040012EC RID: 4844
		private const string DB = "db_favor.db";

		// Token: 0x040012ED RID: 4845
		private const string FILE = "h.好感度.xlsx";

		// Token: 0x040012EE RID: 4846
		private const string TABLE = "FavorTabCamera";

		// Token: 0x040012EF RID: 4847
		private const string COMMAND = "select BinData from `FavorTabCamera` where Id=?";

		// Token: 0x040012F0 RID: 4848
		private const string KEY_PREFIX = "FavorTabCameraById";

		// Token: 0x040012F1 RID: 4849
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012F2 RID: 4850
		private static int HandleId;
	}
}
