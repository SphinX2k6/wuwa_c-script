using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000579 RID: 1401
	public class ConfigMotorDecalIpById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020E3 RID: 8419 RVA: 0x0011355B File Offset: 0x0011175B
		static ConfigMotorDecalIpById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDecalIpById.CreateStaticDefaultValue), new Action(ConfigMotorDecalIpById.ResetStaticDefaultValue));
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x0011357C File Offset: 0x0011177C
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

		// Token: 0x060020E5 RID: 8421 RVA: 0x001135FB File Offset: 0x001117FB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDecalIpById.LogPair = null;
			ConfigMotorDecalIpById.HandleId = 0;
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x00113609 File Offset: 0x00111809
		public static void Init()
		{
			ConfigMotorDecalIpById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDecalIpById.HandleId, "db_motorstickerip.db", "select BinData from `MotorDecalIp` where Id=?");
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x00113624 File Offset: 0x00111824
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

		// Token: 0x04002633 RID: 9779
		private const string DB = "db_motorstickerip.db";

		// Token: 0x04002634 RID: 9780
		private const string FILE = "m.摩托车贴纸活动.xlsx";

		// Token: 0x04002635 RID: 9781
		private const string TABLE = "MotorDecalIp";

		// Token: 0x04002636 RID: 9782
		private const string COMMAND = "select BinData from `MotorDecalIp` where Id=?";

		// Token: 0x04002637 RID: 9783
		private const string KEY_PREFIX = "MotorDecalIpById";

		// Token: 0x04002638 RID: 9784
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002639 RID: 9785
		private static int HandleId;
	}
}
