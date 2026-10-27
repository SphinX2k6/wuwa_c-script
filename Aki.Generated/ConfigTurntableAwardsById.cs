using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A5D RID: 2653
	public class ConfigTurntableAwardsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E42 RID: 15938 RVA: 0x001B9FC7 File Offset: 0x001B81C7
		static ConfigTurntableAwardsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTurntableAwardsById.CreateStaticDefaultValue), new Action(ConfigTurntableAwardsById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x001B9FE8 File Offset: 0x001B81E8
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

		// Token: 0x06003E44 RID: 15940 RVA: 0x001BA067 File Offset: 0x001B8267
		public static void ResetStaticDefaultValue()
		{
			ConfigTurntableAwardsById.LogPair = null;
			ConfigTurntableAwardsById.HandleId = 0;
		}

		// Token: 0x06003E45 RID: 15941 RVA: 0x001BA075 File Offset: 0x001B8275
		public static void Init()
		{
			ConfigTurntableAwardsById.HandleId = ConfigCommon.InitDataStatement(ConfigTurntableAwardsById.HandleId, "db_turntableactivity.db", "select BinData from `TurntableAwards` where Id=?");
		}

		// Token: 0x06003E46 RID: 15942 RVA: 0x001BA090 File Offset: 0x001B8290
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

		// Token: 0x04004871 RID: 18545
		private const string DB = "db_turntableactivity.db";

		// Token: 0x04004872 RID: 18546
		private const string FILE = "z.转盘活动.xlsx";

		// Token: 0x04004873 RID: 18547
		private const string TABLE = "TurntableAwards";

		// Token: 0x04004874 RID: 18548
		private const string COMMAND = "select BinData from `TurntableAwards` where Id=?";

		// Token: 0x04004875 RID: 18549
		private const string KEY_PREFIX = "TurntableAwardsById";

		// Token: 0x04004876 RID: 18550
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004877 RID: 18551
		private static int HandleId;
	}
}
