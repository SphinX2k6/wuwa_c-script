using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B32 RID: 2866
	public class ConfigTurntableAwardsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004340 RID: 17216 RVA: 0x001D935B File Offset: 0x001D755B
		static ConfigTurntableAwardsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTurntableAwardsById.CreateStaticDefaultValue), new Action(ConfigTurntableAwardsById.ResetStaticDefaultValue));
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x001D937C File Offset: 0x001D757C
		public static void CreateStaticDefaultValue()
		{
			ConfigTurntableAwardsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTurntableAwardsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_turntableactivity.db"),
				new ValueTuple<string, object>("文件", "z.转盘活动.xlsx"),
				new ValueTuple<string, object>("表名", "TurntableAwards"),
				new ValueTuple<string, object>("语句", "select BinData from `TurntableAwards` where Id=?")
			});
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x001D93FB File Offset: 0x001D75FB
		public static void ResetStaticDefaultValue()
		{
			ConfigTurntableAwardsById.LogPair = null;
			ConfigTurntableAwardsById.HandleId = 0;
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x001D9409 File Offset: 0x001D7609
		public static void Init()
		{
			ConfigTurntableAwardsById.HandleId = ConfigCommon.InitDataStatement(ConfigTurntableAwardsById.HandleId, "db_turntableactivity.db", "select BinData from `TurntableAwards` where Id=?");
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x001D9424 File Offset: 0x001D7624
		public static TurntableAwards? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTurntableAwardsById.HandleId, ConfigTurntableAwardsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TurntableAwardsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TurntableAwards?(TurntableAwards.GetRootAsTurntableAwards(configBuffer));
				}
			}
			ConfigTurntableAwardsById.LogPair.Clear();
			ConfigTurntableAwardsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTurntableAwardsById.HandleId, 1, p0Id, ConfigTurntableAwardsById.LogPair) || ConfigCommon.Step(ConfigTurntableAwardsById.HandleId, true, ConfigTurntableAwardsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTurntableAwardsById.HandleId, ConfigTurntableAwardsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTurntableAwardsById.HandleId, 0, ConfigTurntableAwardsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTurntableAwardsById.HandleId, ConfigTurntableAwardsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TurntableAwards rootAsTurntableAwards = TurntableAwards.GetRootAsTurntableAwards(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TurntableAwardsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTurntableAwardsById.HandleId, ConfigTurntableAwardsById.LogPair);
			return new TurntableAwards?(rootAsTurntableAwards);
		}

		// Token: 0x04004E44 RID: 20036
		private const string DB = "db_turntableactivity.db";

		// Token: 0x04004E45 RID: 20037
		private const string FILE = "z.转盘活动.xlsx";

		// Token: 0x04004E46 RID: 20038
		private const string TABLE = "TurntableAwards";

		// Token: 0x04004E47 RID: 20039
		private const string COMMAND = "select BinData from `TurntableAwards` where Id=?";

		// Token: 0x04004E48 RID: 20040
		private const string KEY_PREFIX = "TurntableAwardsById";

		// Token: 0x04004E49 RID: 20041
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E4A RID: 20042
		private static int HandleId;
	}
}
