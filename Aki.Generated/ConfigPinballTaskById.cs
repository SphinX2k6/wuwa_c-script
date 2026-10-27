using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000733 RID: 1843
	public class ConfigPinballTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B42 RID: 11074 RVA: 0x0014DF37 File Offset: 0x0014C137
		static ConfigPinballTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballTaskById.CreateStaticDefaultValue), new Action(ConfigPinballTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x0014DF58 File Offset: 0x0014C158
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_活动.xlsx"),
				new ValueTuple<string, object>("表名", "PinballTask"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballTask` where Id=?")
			});
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x0014DFD7 File Offset: 0x0014C1D7
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballTaskById.LogPair = null;
			ConfigPinballTaskById.HandleId = 0;
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x0014DFE5 File Offset: 0x0014C1E5
		public static void Init()
		{
			ConfigPinballTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballTaskById.HandleId, "db_pinballbattle.db", "select BinData from `PinballTask` where Id=?");
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x0014E000 File Offset: 0x0014C200
		public static PinballTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballTaskById.HandleId, ConfigPinballTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballTask?(PinballTask.GetRootAsPinballTask(configBuffer));
				}
			}
			ConfigPinballTaskById.LogPair.Clear();
			ConfigPinballTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballTaskById.HandleId, 1, p0Id, ConfigPinballTaskById.LogPair) || ConfigCommon.Step(ConfigPinballTaskById.HandleId, true, ConfigPinballTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballTaskById.HandleId, ConfigPinballTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballTaskById.HandleId, 0, ConfigPinballTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballTaskById.HandleId, ConfigPinballTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballTask rootAsPinballTask = PinballTask.GetRootAsPinballTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballTaskById.HandleId, ConfigPinballTaskById.LogPair);
			return new PinballTask?(rootAsPinballTask);
		}

		// Token: 0x0400324B RID: 12875
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400324C RID: 12876
		private const string FILE = "x.星弹奇游_活动.xlsx";

		// Token: 0x0400324D RID: 12877
		private const string TABLE = "PinballTask";

		// Token: 0x0400324E RID: 12878
		private const string COMMAND = "select BinData from `PinballTask` where Id=?";

		// Token: 0x0400324F RID: 12879
		private const string KEY_PREFIX = "PinballTaskById";

		// Token: 0x04003250 RID: 12880
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003251 RID: 12881
		private static int HandleId;
	}
}
