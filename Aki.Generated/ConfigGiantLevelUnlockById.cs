using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000396 RID: 918
	public class ConfigGiantLevelUnlockById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600158A RID: 5514 RVA: 0x000D35D8 File Offset: 0x000D17D8
		static ConfigGiantLevelUnlockById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantLevelUnlockById.CreateStaticDefaultValue), new Action(ConfigGiantLevelUnlockById.ResetStaticDefaultValue));
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x000D35F8 File Offset: 0x000D17F8
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

		// Token: 0x0600158C RID: 5516 RVA: 0x000D3677 File Offset: 0x000D1877
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantLevelUnlockById.LogPair = null;
			ConfigGiantLevelUnlockById.HandleId = 0;
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x000D3685 File Offset: 0x000D1885
		public static void Init()
		{
			ConfigGiantLevelUnlockById.HandleId = ConfigCommon.InitDataStatement(ConfigGiantLevelUnlockById.HandleId, "db_giant.db", "select BinData from `GiantLevelUnlock` where Id=?");
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x000D36A0 File Offset: 0x000D18A0
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

		// Token: 0x040018FE RID: 6398
		private const string DB = "db_giant.db";

		// Token: 0x040018FF RID: 6399
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x04001900 RID: 6400
		private const string TABLE = "GiantLevelUnlock";

		// Token: 0x04001901 RID: 6401
		private const string COMMAND = "select BinData from `GiantLevelUnlock` where Id=?";

		// Token: 0x04001902 RID: 6402
		private const string KEY_PREFIX = "GiantLevelUnlockById";

		// Token: 0x04001903 RID: 6403
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001904 RID: 6404
		private static int HandleId;
	}
}
