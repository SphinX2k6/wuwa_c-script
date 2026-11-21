using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200074B RID: 1867
	public class ConfigPinballTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BD2 RID: 11218 RVA: 0x001549B3 File Offset: 0x00152BB3
		static ConfigPinballTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballTaskById.CreateStaticDefaultValue), new Action(ConfigPinballTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x001549D4 File Offset: 0x00152BD4
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

		// Token: 0x06002BD4 RID: 11220 RVA: 0x00154A53 File Offset: 0x00152C53
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballTaskById.LogPair = null;
			ConfigPinballTaskById.HandleId = 0;
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x00154A61 File Offset: 0x00152C61
		public static void Init()
		{
			ConfigPinballTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballTaskById.HandleId, "db_pinballbattle.db", "select BinData from `PinballTask` where Id=?");
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x00154A7C File Offset: 0x00152C7C
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

		// Token: 0x040032F3 RID: 13043
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040032F4 RID: 13044
		private const string FILE = "x.星弹奇游_活动.xlsx";

		// Token: 0x040032F5 RID: 13045
		private const string TABLE = "PinballTask";

		// Token: 0x040032F6 RID: 13046
		private const string COMMAND = "select BinData from `PinballTask` where Id=?";

		// Token: 0x040032F7 RID: 13047
		private const string KEY_PREFIX = "PinballTaskById";

		// Token: 0x040032F8 RID: 13048
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032F9 RID: 13049
		private static int HandleId;
	}
}
