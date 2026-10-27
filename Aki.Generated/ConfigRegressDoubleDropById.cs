using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007CF RID: 1999
	public class ConfigRegressDoubleDropById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EEC RID: 12012 RVA: 0x001627D8 File Offset: 0x001609D8
		static ConfigRegressDoubleDropById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressDoubleDropById.CreateStaticDefaultValue), new Action(ConfigRegressDoubleDropById.ResetStaticDefaultValue));
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x001627F8 File Offset: 0x001609F8
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

		// Token: 0x06002EEE RID: 12014 RVA: 0x00162877 File Offset: 0x00160A77
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressDoubleDropById.LogPair = null;
			ConfigRegressDoubleDropById.HandleId = 0;
		}

		// Token: 0x06002EEF RID: 12015 RVA: 0x00162885 File Offset: 0x00160A85
		public static void Init()
		{
			ConfigRegressDoubleDropById.HandleId = ConfigCommon.InitDataStatement(ConfigRegressDoubleDropById.HandleId, "db_regressactivity.db", "select BinData from `RegressDoubleDrop` where Id=?");
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x001628A0 File Offset: 0x00160AA0
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

		// Token: 0x0400368F RID: 13967
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003690 RID: 13968
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003691 RID: 13969
		private const string TABLE = "RegressDoubleDrop";

		// Token: 0x04003692 RID: 13970
		private const string COMMAND = "select BinData from `RegressDoubleDrop` where Id=?";

		// Token: 0x04003693 RID: 13971
		private const string KEY_PREFIX = "RegressDoubleDropById";

		// Token: 0x04003694 RID: 13972
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003695 RID: 13973
		private static int HandleId;
	}
}
