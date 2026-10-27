using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000728 RID: 1832
	public class ConfigPinballRankById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B00 RID: 11008 RVA: 0x0014C753 File Offset: 0x0014A953
		static ConfigPinballRankById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRankById.CreateStaticDefaultValue), new Action(ConfigPinballRankById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x0014C774 File Offset: 0x0014A974
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballRankById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballRankById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_活动.xlsx"),
				new ValueTuple<string, object>("表名", "PinballRank"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballRank` where Id=?")
			});
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x0014C7F3 File Offset: 0x0014A9F3
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRankById.LogPair = null;
			ConfigPinballRankById.HandleId = 0;
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x0014C801 File Offset: 0x0014AA01
		public static void Init()
		{
			ConfigPinballRankById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRankById.HandleId, "db_pinballbattle.db", "select BinData from `PinballRank` where Id=?");
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x0014C81C File Offset: 0x0014AA1C
		public static PinballRank? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballRankById.HandleId, ConfigPinballRankById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRankById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballRank?(PinballRank.GetRootAsPinballRank(configBuffer));
				}
			}
			ConfigPinballRankById.LogPair.Clear();
			ConfigPinballRankById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballRankById.HandleId, 1, p0Id, ConfigPinballRankById.LogPair) || ConfigCommon.Step(ConfigPinballRankById.HandleId, true, ConfigPinballRankById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballRankById.HandleId, ConfigPinballRankById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballRankById.HandleId, 0, ConfigPinballRankById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballRankById.HandleId, ConfigPinballRankById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballRank rootAsPinballRank = PinballRank.GetRootAsPinballRank(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballRankById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballRankById.HandleId, ConfigPinballRankById.LogPair);
			return new PinballRank?(rootAsPinballRank);
		}

		// Token: 0x040031FE RID: 12798
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031FF RID: 12799
		private const string FILE = "x.星弹奇游_活动.xlsx";

		// Token: 0x04003200 RID: 12800
		private const string TABLE = "PinballRank";

		// Token: 0x04003201 RID: 12801
		private const string COMMAND = "select BinData from `PinballRank` where Id=?";

		// Token: 0x04003202 RID: 12802
		private const string KEY_PREFIX = "PinballRankById";

		// Token: 0x04003203 RID: 12803
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003204 RID: 12804
		private static int HandleId;
	}
}
