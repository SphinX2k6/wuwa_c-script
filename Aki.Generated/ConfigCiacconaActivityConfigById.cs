using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000161 RID: 353
	public class ConfigCiacconaActivityConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000847 RID: 2119 RVA: 0x00088428 File Offset: 0x00086628
		static ConfigCiacconaActivityConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaActivityConfigById.CreateStaticDefaultValue), new Action(ConfigCiacconaActivityConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00088448 File Offset: 0x00086648
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaActivityConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaActivityConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaActivityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaActivityConfig` where Id=?")
			});
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x000884C7 File Offset: 0x000866C7
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaActivityConfigById.LogPair = null;
			ConfigCiacconaActivityConfigById.HandleId = 0;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000884D5 File Offset: 0x000866D5
		public static void Init()
		{
			ConfigCiacconaActivityConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaActivityConfigById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaActivityConfig` where Id=?");
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000884F0 File Offset: 0x000866F0
		public static CiacconaActivityConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaActivityConfigById.HandleId, ConfigCiacconaActivityConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaActivityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CiacconaActivityConfig?(CiacconaActivityConfig.GetRootAsCiacconaActivityConfig(configBuffer));
				}
			}
			ConfigCiacconaActivityConfigById.LogPair.Clear();
			ConfigCiacconaActivityConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCiacconaActivityConfigById.HandleId, 1, p0Id, ConfigCiacconaActivityConfigById.LogPair) || ConfigCommon.Step(ConfigCiacconaActivityConfigById.HandleId, true, ConfigCiacconaActivityConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCiacconaActivityConfigById.HandleId, ConfigCiacconaActivityConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaActivityConfigById.HandleId, 0, ConfigCiacconaActivityConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCiacconaActivityConfigById.HandleId, ConfigCiacconaActivityConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CiacconaActivityConfig rootAsCiacconaActivityConfig = CiacconaActivityConfig.GetRootAsCiacconaActivityConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaActivityConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCiacconaActivityConfigById.HandleId, ConfigCiacconaActivityConfigById.LogPair);
			return new CiacconaActivityConfig?(rootAsCiacconaActivityConfig);
		}

		// Token: 0x0400098B RID: 2443
		private const string DB = "db_ciacconagal.db";

		// Token: 0x0400098C RID: 2444
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x0400098D RID: 2445
		private const string TABLE = "CiacconaActivityConfig";

		// Token: 0x0400098E RID: 2446
		private const string COMMAND = "select BinData from `CiacconaActivityConfig` where Id=?";

		// Token: 0x0400098F RID: 2447
		private const string KEY_PREFIX = "CiacconaActivityConfigById";

		// Token: 0x04000990 RID: 2448
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000991 RID: 2449
		private static int HandleId;
	}
}
