using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000389 RID: 905
	public class ConfigGaChaShareById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600153C RID: 5436 RVA: 0x000D5254 File Offset: 0x000D3454
		static ConfigGaChaShareById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGaChaShareById.CreateStaticDefaultValue), new Action(ConfigGaChaShareById.ResetStaticDefaultValue));
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x000D5274 File Offset: 0x000D3474
		public static void CreateStaticDefaultValue()
		{
			ConfigGaChaShareById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGaChaShareById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shareinfo.db"),
				new ValueTuple<string, object>("文件", "f.分享.xlsx"),
				new ValueTuple<string, object>("表名", "GaChaShare"),
				new ValueTuple<string, object>("语句", "select BinData from `GaChaShare` where Id=?")
			});
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x000D52F3 File Offset: 0x000D34F3
		public static void ResetStaticDefaultValue()
		{
			ConfigGaChaShareById.LogPair = null;
			ConfigGaChaShareById.HandleId = 0;
		}

		// Token: 0x0600153F RID: 5439 RVA: 0x000D5301 File Offset: 0x000D3501
		public static void Init()
		{
			ConfigGaChaShareById.HandleId = ConfigCommon.InitDataStatement(ConfigGaChaShareById.HandleId, "db_shareinfo.db", "select BinData from `GaChaShare` where Id=?");
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x000D531C File Offset: 0x000D351C
		public static GaChaShare? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGaChaShareById.HandleId, ConfigGaChaShareById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GaChaShareById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GaChaShare?(GaChaShare.GetRootAsGaChaShare(configBuffer));
				}
			}
			ConfigGaChaShareById.LogPair.Clear();
			ConfigGaChaShareById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGaChaShareById.HandleId, 1, p0Id, ConfigGaChaShareById.LogPair) || ConfigCommon.Step(ConfigGaChaShareById.HandleId, true, ConfigGaChaShareById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGaChaShareById.HandleId, ConfigGaChaShareById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGaChaShareById.HandleId, 0, ConfigGaChaShareById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGaChaShareById.HandleId, ConfigGaChaShareById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GaChaShare rootAsGaChaShare = GaChaShare.GetRootAsGaChaShare(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GaChaShareById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGaChaShareById.HandleId, ConfigGaChaShareById.LogPair);
			return new GaChaShare?(rootAsGaChaShare);
		}

		// Token: 0x040018A3 RID: 6307
		private const string DB = "db_shareinfo.db";

		// Token: 0x040018A4 RID: 6308
		private const string FILE = "f.分享.xlsx";

		// Token: 0x040018A5 RID: 6309
		private const string TABLE = "GaChaShare";

		// Token: 0x040018A6 RID: 6310
		private const string COMMAND = "select BinData from `GaChaShare` where Id=?";

		// Token: 0x040018A7 RID: 6311
		private const string KEY_PREFIX = "GaChaShareById";

		// Token: 0x040018A8 RID: 6312
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018A9 RID: 6313
		private static int HandleId;
	}
}
