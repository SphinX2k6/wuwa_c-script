using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A5E RID: 2654
	public class ConfigTurntableInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E48 RID: 15944 RVA: 0x001BA210 File Offset: 0x001B8410
		static ConfigTurntableInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTurntableInfoById.CreateStaticDefaultValue), new Action(ConfigTurntableInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x001BA230 File Offset: 0x001B8430
		public static void CreateStaticDefaultValue()
		{
			ConfigTurntableInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTurntableInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_turntableactivity.db"),
				new ValueTuple<string, object>("文件", "z.转盘活动.xlsx"),
				new ValueTuple<string, object>("表名", "TurntableInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `TurntableInfo` where Id=?")
			});
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x001BA2AF File Offset: 0x001B84AF
		public static void ResetStaticDefaultValue()
		{
			ConfigTurntableInfoById.LogPair = null;
			ConfigTurntableInfoById.HandleId = 0;
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x001BA2BD File Offset: 0x001B84BD
		public static void Init()
		{
			ConfigTurntableInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigTurntableInfoById.HandleId, "db_turntableactivity.db", "select BinData from `TurntableInfo` where Id=?");
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x001BA2D8 File Offset: 0x001B84D8
		public static TurntableInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTurntableInfoById.HandleId, ConfigTurntableInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TurntableInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TurntableInfo?(TurntableInfo.GetRootAsTurntableInfo(configBuffer));
				}
			}
			ConfigTurntableInfoById.LogPair.Clear();
			ConfigTurntableInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTurntableInfoById.HandleId, 1, p0Id, ConfigTurntableInfoById.LogPair) || ConfigCommon.Step(ConfigTurntableInfoById.HandleId, true, ConfigTurntableInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTurntableInfoById.HandleId, ConfigTurntableInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTurntableInfoById.HandleId, 0, ConfigTurntableInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTurntableInfoById.HandleId, ConfigTurntableInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TurntableInfo rootAsTurntableInfo = TurntableInfo.GetRootAsTurntableInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TurntableInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTurntableInfoById.HandleId, ConfigTurntableInfoById.LogPair);
			return new TurntableInfo?(rootAsTurntableInfo);
		}

		// Token: 0x04004878 RID: 18552
		private const string DB = "db_turntableactivity.db";

		// Token: 0x04004879 RID: 18553
		private const string FILE = "z.转盘活动.xlsx";

		// Token: 0x0400487A RID: 18554
		private const string TABLE = "TurntableInfo";

		// Token: 0x0400487B RID: 18555
		private const string COMMAND = "select BinData from `TurntableInfo` where Id=?";

		// Token: 0x0400487C RID: 18556
		private const string KEY_PREFIX = "TurntableInfoById";

		// Token: 0x0400487D RID: 18557
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400487E RID: 18558
		private static int HandleId;
	}
}
