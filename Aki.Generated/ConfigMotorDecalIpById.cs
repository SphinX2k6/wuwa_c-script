using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200058F RID: 1423
	public class ConfigMotorDecalIpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002167 RID: 8551 RVA: 0x00119CAF File Offset: 0x00117EAF
		static ConfigMotorDecalIpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDecalIpById.CreateStaticDefaultValue), new Action(ConfigMotorDecalIpById.ResetStaticDefaultValue));
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00119CD0 File Offset: 0x00117ED0
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorDecalIpById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorDecalIpById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorstickerip.db"),
				new ValueTuple<string, object>("文件", "m.摩托车贴纸活动.xlsx"),
				new ValueTuple<string, object>("表名", "MotorDecalIp"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorDecalIp` where Id=?")
			});
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x00119D4F File Offset: 0x00117F4F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDecalIpById.LogPair = null;
			ConfigMotorDecalIpById.HandleId = 0;
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x00119D5D File Offset: 0x00117F5D
		public static void Init()
		{
			ConfigMotorDecalIpById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDecalIpById.HandleId, "db_motorstickerip.db", "select BinData from `MotorDecalIp` where Id=?");
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x00119D78 File Offset: 0x00117F78
		public static MotorDecalIp? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorDecalIpById.HandleId, ConfigMotorDecalIpById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecalIpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorDecalIp?(MotorDecalIp.GetRootAsMotorDecalIp(configBuffer));
				}
			}
			ConfigMotorDecalIpById.LogPair.Clear();
			ConfigMotorDecalIpById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorDecalIpById.HandleId, 1, p0Id, ConfigMotorDecalIpById.LogPair) || ConfigCommon.Step(ConfigMotorDecalIpById.HandleId, true, ConfigMotorDecalIpById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorDecalIpById.HandleId, ConfigMotorDecalIpById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorDecalIpById.HandleId, 0, ConfigMotorDecalIpById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorDecalIpById.HandleId, ConfigMotorDecalIpById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorDecalIp rootAsMotorDecalIp = MotorDecalIp.GetRootAsMotorDecalIp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecalIpById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorDecalIpById.HandleId, ConfigMotorDecalIpById.LogPair);
			return new MotorDecalIp?(rootAsMotorDecalIp);
		}

		// Token: 0x040026CD RID: 9933
		private const string DB = "db_motorstickerip.db";

		// Token: 0x040026CE RID: 9934
		private const string FILE = "m.摩托车贴纸活动.xlsx";

		// Token: 0x040026CF RID: 9935
		private const string TABLE = "MotorDecalIp";

		// Token: 0x040026D0 RID: 9936
		private const string COMMAND = "select BinData from `MotorDecalIp` where Id=?";

		// Token: 0x040026D1 RID: 9937
		private const string KEY_PREFIX = "MotorDecalIpById";

		// Token: 0x040026D2 RID: 9938
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026D3 RID: 9939
		private static int HandleId;
	}
}
