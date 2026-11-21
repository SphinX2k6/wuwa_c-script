using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007EB RID: 2027
	public class ConfigRegressDoubleDropById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F94 RID: 12180 RVA: 0x00169AC0 File Offset: 0x00167CC0
		static ConfigRegressDoubleDropById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressDoubleDropById.CreateStaticDefaultValue), new Action(ConfigRegressDoubleDropById.ResetStaticDefaultValue));
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x00169AE0 File Offset: 0x00167CE0
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressDoubleDropById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressDoubleDropById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressDoubleDrop"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressDoubleDrop` where Id=?")
			});
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x00169B5F File Offset: 0x00167D5F
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressDoubleDropById.LogPair = null;
			ConfigRegressDoubleDropById.HandleId = 0;
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x00169B6D File Offset: 0x00167D6D
		public static void Init()
		{
			ConfigRegressDoubleDropById.HandleId = ConfigCommon.InitDataStatement(ConfigRegressDoubleDropById.HandleId, "db_regressactivity.db", "select BinData from `RegressDoubleDrop` where Id=?");
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x00169B88 File Offset: 0x00167D88
		public static RegressDoubleDrop? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressDoubleDropById.HandleId, ConfigRegressDoubleDropById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressDoubleDropById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RegressDoubleDrop?(RegressDoubleDrop.GetRootAsRegressDoubleDrop(configBuffer));
				}
			}
			ConfigRegressDoubleDropById.LogPair.Clear();
			ConfigRegressDoubleDropById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRegressDoubleDropById.HandleId, 1, p0Id, ConfigRegressDoubleDropById.LogPair) || ConfigCommon.Step(ConfigRegressDoubleDropById.HandleId, true, ConfigRegressDoubleDropById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRegressDoubleDropById.HandleId, ConfigRegressDoubleDropById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressDoubleDropById.HandleId, 0, ConfigRegressDoubleDropById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRegressDoubleDropById.HandleId, ConfigRegressDoubleDropById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RegressDoubleDrop rootAsRegressDoubleDrop = RegressDoubleDrop.GetRootAsRegressDoubleDrop(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressDoubleDropById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRegressDoubleDropById.HandleId, ConfigRegressDoubleDropById.LogPair);
			return new RegressDoubleDrop?(rootAsRegressDoubleDrop);
		}

		// Token: 0x04003753 RID: 14163
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003754 RID: 14164
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003755 RID: 14165
		private const string TABLE = "RegressDoubleDrop";

		// Token: 0x04003756 RID: 14166
		private const string COMMAND = "select BinData from `RegressDoubleDrop` where Id=?";

		// Token: 0x04003757 RID: 14167
		private const string KEY_PREFIX = "RegressDoubleDropById";

		// Token: 0x04003758 RID: 14168
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003759 RID: 14169
		private static int HandleId;
	}
}
