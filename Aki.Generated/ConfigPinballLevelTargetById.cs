using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000736 RID: 1846
	public class ConfigPinballLevelTargetById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B54 RID: 11092 RVA: 0x00151C68 File Offset: 0x0014FE68
		static ConfigPinballLevelTargetById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballLevelTargetById.CreateStaticDefaultValue), new Action(ConfigPinballLevelTargetById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x00151C88 File Offset: 0x0014FE88
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

		// Token: 0x06002B56 RID: 11094 RVA: 0x00151D07 File Offset: 0x0014FF07
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballLevelTargetById.LogPair = null;
			ConfigPinballLevelTargetById.HandleId = 0;
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x00151D15 File Offset: 0x0014FF15
		public static void Init()
		{
			ConfigPinballLevelTargetById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballLevelTargetById.HandleId, "db_pinballbattle.db", "select BinData from `PinballLevelTarget` where Id=?");
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x00151D30 File Offset: 0x0014FF30
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

		// Token: 0x04003260 RID: 12896
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003261 RID: 12897
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x04003262 RID: 12898
		private const string TABLE = "PinballLevelTarget";

		// Token: 0x04003263 RID: 12899
		private const string COMMAND = "select BinData from `PinballLevelTarget` where Id=?";

		// Token: 0x04003264 RID: 12900
		private const string KEY_PREFIX = "PinballLevelTargetById";

		// Token: 0x04003265 RID: 12901
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003266 RID: 12902
		private static int HandleId;
	}
}
