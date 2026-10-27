using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200071E RID: 1822
	public class ConfigPinballLevelTargetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AC4 RID: 10948 RVA: 0x0014B1EC File Offset: 0x001493EC
		static ConfigPinballLevelTargetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballLevelTargetById.CreateStaticDefaultValue), new Action(ConfigPinballLevelTargetById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x0014B20C File Offset: 0x0014940C
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballLevelTargetById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballLevelTargetById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "PinballLevelTarget"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballLevelTarget` where Id=?")
			});
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x0014B28B File Offset: 0x0014948B
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballLevelTargetById.LogPair = null;
			ConfigPinballLevelTargetById.HandleId = 0;
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x0014B299 File Offset: 0x00149499
		public static void Init()
		{
			ConfigPinballLevelTargetById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballLevelTargetById.HandleId, "db_pinballbattle.db", "select BinData from `PinballLevelTarget` where Id=?");
		}

		// Token: 0x06002AC8 RID: 10952 RVA: 0x0014B2B4 File Offset: 0x001494B4
		public static PinballLevelTarget? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballLevelTargetById.HandleId, ConfigPinballLevelTargetById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballLevelTargetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballLevelTarget?(PinballLevelTarget.GetRootAsPinballLevelTarget(configBuffer));
				}
			}
			ConfigPinballLevelTargetById.LogPair.Clear();
			ConfigPinballLevelTargetById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballLevelTargetById.HandleId, 1, p0Id, ConfigPinballLevelTargetById.LogPair) || ConfigCommon.Step(ConfigPinballLevelTargetById.HandleId, true, ConfigPinballLevelTargetById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballLevelTargetById.HandleId, ConfigPinballLevelTargetById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballLevelTargetById.HandleId, 0, ConfigPinballLevelTargetById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballLevelTargetById.HandleId, ConfigPinballLevelTargetById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballLevelTarget rootAsPinballLevelTarget = PinballLevelTarget.GetRootAsPinballLevelTarget(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballLevelTargetById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballLevelTargetById.HandleId, ConfigPinballLevelTargetById.LogPair);
			return new PinballLevelTarget?(rootAsPinballLevelTarget);
		}

		// Token: 0x040031B8 RID: 12728
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031B9 RID: 12729
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x040031BA RID: 12730
		private const string TABLE = "PinballLevelTarget";

		// Token: 0x040031BB RID: 12731
		private const string COMMAND = "select BinData from `PinballLevelTarget` where Id=?";

		// Token: 0x040031BC RID: 12732
		private const string KEY_PREFIX = "PinballLevelTargetById";

		// Token: 0x040031BD RID: 12733
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031BE RID: 12734
		private static int HandleId;
	}
}
