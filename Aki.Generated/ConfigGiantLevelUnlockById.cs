using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003AC RID: 940
	public class ConfigGiantLevelUnlockById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600160E RID: 5646 RVA: 0x000D9D2C File Offset: 0x000D7F2C
		static ConfigGiantLevelUnlockById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantLevelUnlockById.CreateStaticDefaultValue), new Action(ConfigGiantLevelUnlockById.ResetStaticDefaultValue));
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x000D9D4C File Offset: 0x000D7F4C
		public static void CreateStaticDefaultValue()
		{
			ConfigGiantLevelUnlockById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiantLevelUnlockById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giant.db"),
				new ValueTuple<string, object>("文件", "j.巨人信物.xlsx"),
				new ValueTuple<string, object>("表名", "GiantLevelUnlock"),
				new ValueTuple<string, object>("语句", "select BinData from `GiantLevelUnlock` where Id=?")
			});
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000D9DCB File Offset: 0x000D7FCB
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantLevelUnlockById.LogPair = null;
			ConfigGiantLevelUnlockById.HandleId = 0;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x000D9DD9 File Offset: 0x000D7FD9
		public static void Init()
		{
			ConfigGiantLevelUnlockById.HandleId = ConfigCommon.InitDataStatement(ConfigGiantLevelUnlockById.HandleId, "db_giant.db", "select BinData from `GiantLevelUnlock` where Id=?");
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x000D9DF4 File Offset: 0x000D7FF4
		public static GiantLevelUnlock? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiantLevelUnlockById.HandleId, ConfigGiantLevelUnlockById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantLevelUnlockById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GiantLevelUnlock?(GiantLevelUnlock.GetRootAsGiantLevelUnlock(configBuffer));
				}
			}
			ConfigGiantLevelUnlockById.LogPair.Clear();
			ConfigGiantLevelUnlockById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGiantLevelUnlockById.HandleId, 1, p0Id, ConfigGiantLevelUnlockById.LogPair) || ConfigCommon.Step(ConfigGiantLevelUnlockById.HandleId, true, ConfigGiantLevelUnlockById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGiantLevelUnlockById.HandleId, ConfigGiantLevelUnlockById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiantLevelUnlockById.HandleId, 0, ConfigGiantLevelUnlockById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGiantLevelUnlockById.HandleId, ConfigGiantLevelUnlockById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GiantLevelUnlock rootAsGiantLevelUnlock = GiantLevelUnlock.GetRootAsGiantLevelUnlock(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantLevelUnlockById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGiantLevelUnlockById.HandleId, ConfigGiantLevelUnlockById.LogPair);
			return new GiantLevelUnlock?(rootAsGiantLevelUnlock);
		}

		// Token: 0x04001998 RID: 6552
		private const string DB = "db_giant.db";

		// Token: 0x04001999 RID: 6553
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x0400199A RID: 6554
		private const string TABLE = "GiantLevelUnlock";

		// Token: 0x0400199B RID: 6555
		private const string COMMAND = "select BinData from `GiantLevelUnlock` where Id=?";

		// Token: 0x0400199C RID: 6556
		private const string KEY_PREFIX = "GiantLevelUnlockById";

		// Token: 0x0400199D RID: 6557
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400199E RID: 6558
		private static int HandleId;
	}
}
