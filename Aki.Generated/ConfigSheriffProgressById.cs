using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200091A RID: 2330
	public class ConfigSheriffProgressById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036AF RID: 13999 RVA: 0x0018E798 File Offset: 0x0018C998
		static ConfigSheriffProgressById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffProgressById.CreateStaticDefaultValue), new Action(ConfigSheriffProgressById.ResetStaticDefaultValue));
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x0018E7B8 File Offset: 0x0018C9B8
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffProgressById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffProgressById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffProgress"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffProgress` where Id=?")
			});
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x0018E837 File Offset: 0x0018CA37
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffProgressById.LogPair = null;
			ConfigSheriffProgressById.HandleId = 0;
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x0018E845 File Offset: 0x0018CA45
		public static void Init()
		{
			ConfigSheriffProgressById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffProgressById.HandleId, "db_sheriff.db", "select BinData from `SheriffProgress` where Id=?");
		}

		// Token: 0x060036B3 RID: 14003 RVA: 0x0018E860 File Offset: 0x0018CA60
		public static SheriffProgress? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffProgressById.HandleId, ConfigSheriffProgressById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffProgressById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffProgress?(SheriffProgress.GetRootAsSheriffProgress(configBuffer));
				}
			}
			ConfigSheriffProgressById.LogPair.Clear();
			ConfigSheriffProgressById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSheriffProgressById.HandleId, 1, p0Id, ConfigSheriffProgressById.LogPair) || ConfigCommon.Step(ConfigSheriffProgressById.HandleId, true, ConfigSheriffProgressById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffProgressById.HandleId, ConfigSheriffProgressById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffProgressById.HandleId, 0, ConfigSheriffProgressById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffProgressById.HandleId, ConfigSheriffProgressById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffProgress rootAsSheriffProgress = SheriffProgress.GetRootAsSheriffProgress(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffProgressById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffProgressById.HandleId, ConfigSheriffProgressById.LogPair);
			return new SheriffProgress?(rootAsSheriffProgress);
		}

		// Token: 0x04003F9C RID: 16284
		private const string DB = "db_sheriff.db";

		// Token: 0x04003F9D RID: 16285
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003F9E RID: 16286
		private const string TABLE = "SheriffProgress";

		// Token: 0x04003F9F RID: 16287
		private const string COMMAND = "select BinData from `SheriffProgress` where Id=?";

		// Token: 0x04003FA0 RID: 16288
		private const string KEY_PREFIX = "SheriffProgressById";

		// Token: 0x04003FA1 RID: 16289
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FA2 RID: 16290
		private static int HandleId;
	}
}
