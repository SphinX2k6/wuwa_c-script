using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E4 RID: 484
	public class ConfigDangoBroadcastById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B5B RID: 2907 RVA: 0x00099CB4 File Offset: 0x00097EB4
		static ConfigDangoBroadcastById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBroadcastById.CreateStaticDefaultValue), new Action(ConfigDangoBroadcastById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00099CD4 File Offset: 0x00097ED4
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

		// Token: 0x06000B5D RID: 2909 RVA: 0x00099D53 File Offset: 0x00097F53
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBroadcastById.LogPair = null;
			ConfigDangoBroadcastById.HandleId = 0;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00099D61 File Offset: 0x00097F61
		public static void Init()
		{
			ConfigDangoBroadcastById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBroadcastById.HandleId, "db_racingbets.db", "select BinData from `DangoBroadcast` where Id=?");
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00099D7C File Offset: 0x00097F7C
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

		// Token: 0x04000D20 RID: 3360
		private const string DB = "db_racingbets.db";

		// Token: 0x04000D21 RID: 3361
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04000D22 RID: 3362
		private const string TABLE = "DangoBroadcast";

		// Token: 0x04000D23 RID: 3363
		private const string COMMAND = "select BinData from `DangoBroadcast` where Id=?";

		// Token: 0x04000D24 RID: 3364
		private const string KEY_PREFIX = "DangoBroadcastById";

		// Token: 0x04000D25 RID: 3365
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D26 RID: 3366
		private static int HandleId;
	}
}
