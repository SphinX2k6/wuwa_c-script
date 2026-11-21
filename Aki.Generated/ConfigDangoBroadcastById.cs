using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F6 RID: 502
	public class ConfigDangoBroadcastById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BC7 RID: 3015 RVA: 0x0009FBEC File Offset: 0x0009DDEC
		static ConfigDangoBroadcastById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBroadcastById.CreateStaticDefaultValue), new Action(ConfigDangoBroadcastById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0009FC0C File Offset: 0x0009DE0C
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBroadcastById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBroadcastById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBroadcast"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBroadcast` where Id=?")
			});
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0009FC8B File Offset: 0x0009DE8B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBroadcastById.LogPair = null;
			ConfigDangoBroadcastById.HandleId = 0;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0009FC99 File Offset: 0x0009DE99
		public static void Init()
		{
			ConfigDangoBroadcastById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBroadcastById.HandleId, "db_racingbets.db", "select BinData from `DangoBroadcast` where Id=?");
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0009FCB4 File Offset: 0x0009DEB4
		public static DangoBroadcast? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBroadcastById.HandleId, ConfigDangoBroadcastById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBroadcastById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DangoBroadcast?(DangoBroadcast.GetRootAsDangoBroadcast(configBuffer));
				}
			}
			ConfigDangoBroadcastById.LogPair.Clear();
			ConfigDangoBroadcastById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoBroadcastById.HandleId, 1, p0Id, ConfigDangoBroadcastById.LogPair) || ConfigCommon.Step(ConfigDangoBroadcastById.HandleId, true, ConfigDangoBroadcastById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoBroadcastById.HandleId, ConfigDangoBroadcastById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBroadcastById.HandleId, 0, ConfigDangoBroadcastById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoBroadcastById.HandleId, ConfigDangoBroadcastById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DangoBroadcast rootAsDangoBroadcast = DangoBroadcast.GetRootAsDangoBroadcast(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoBroadcastById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoBroadcastById.HandleId, ConfigDangoBroadcastById.LogPair);
			return new DangoBroadcast?(rootAsDangoBroadcast);
		}

		// Token: 0x04000D9E RID: 3486
		private const string DB = "db_racingbets.db";

		// Token: 0x04000D9F RID: 3487
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04000DA0 RID: 3488
		private const string TABLE = "DangoBroadcast";

		// Token: 0x04000DA1 RID: 3489
		private const string COMMAND = "select BinData from `DangoBroadcast` where Id=?";

		// Token: 0x04000DA2 RID: 3490
		private const string KEY_PREFIX = "DangoBroadcastById";

		// Token: 0x04000DA3 RID: 3491
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DA4 RID: 3492
		private static int HandleId;
	}
}
