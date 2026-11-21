using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000804 RID: 2052
	public class ConfigReviveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600302A RID: 12330 RVA: 0x0016CFC4 File Offset: 0x0016B1C4
		static ConfigReviveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigReviveById.CreateStaticDefaultValue), new Action(ConfigReviveById.ResetStaticDefaultValue));
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x0016CFE4 File Offset: 0x0016B1E4
		public static void CreateStaticDefaultValue()
		{
			ConfigReviveById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigReviveById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_revive.db"),
				new ValueTuple<string, object>("文件", "f.复活.xlsx"),
				new ValueTuple<string, object>("表名", "Revive"),
				new ValueTuple<string, object>("语句", "select BinData from `Revive` where id=?")
			});
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x0016D063 File Offset: 0x0016B263
		public static void ResetStaticDefaultValue()
		{
			ConfigReviveById.LogPair = null;
			ConfigReviveById.HandleId = 0;
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x0016D071 File Offset: 0x0016B271
		public static void Init()
		{
			ConfigReviveById.HandleId = ConfigCommon.InitDataStatement(ConfigReviveById.HandleId, "db_revive.db", "select BinData from `Revive` where id=?");
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x0016D08C File Offset: 0x0016B28C
		public static Revive? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigReviveById.HandleId, ConfigReviveById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ReviveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Revive?(Revive.GetRootAsRevive(configBuffer));
				}
			}
			ConfigReviveById.LogPair.Clear();
			ConfigReviveById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigReviveById.HandleId, 1, p0Id, ConfigReviveById.LogPair) || ConfigCommon.Step(ConfigReviveById.HandleId, true, ConfigReviveById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigReviveById.HandleId, ConfigReviveById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigReviveById.HandleId, 0, ConfigReviveById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigReviveById.HandleId, ConfigReviveById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Revive rootAsRevive = Revive.GetRootAsRevive(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ReviveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigReviveById.HandleId, ConfigReviveById.LogPair);
			return new Revive?(rootAsRevive);
		}

		// Token: 0x04003802 RID: 14338
		private const string DB = "db_revive.db";

		// Token: 0x04003803 RID: 14339
		private const string FILE = "f.复活.xlsx";

		// Token: 0x04003804 RID: 14340
		private const string TABLE = "Revive";

		// Token: 0x04003805 RID: 14341
		private const string COMMAND = "select BinData from `Revive` where id=?";

		// Token: 0x04003806 RID: 14342
		private const string KEY_PREFIX = "ReviveById";

		// Token: 0x04003807 RID: 14343
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003808 RID: 14344
		private static int HandleId;
	}
}
