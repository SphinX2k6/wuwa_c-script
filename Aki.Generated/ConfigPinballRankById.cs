using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000740 RID: 1856
	public class ConfigPinballRankById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B90 RID: 11152 RVA: 0x001531CF File Offset: 0x001513CF
		static ConfigPinballRankById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballRankById.CreateStaticDefaultValue), new Action(ConfigPinballRankById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B91 RID: 11153 RVA: 0x001531F0 File Offset: 0x001513F0
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

		// Token: 0x06002B92 RID: 11154 RVA: 0x0015326F File Offset: 0x0015146F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballRankById.LogPair = null;
			ConfigPinballRankById.HandleId = 0;
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x0015327D File Offset: 0x0015147D
		public static void Init()
		{
			ConfigPinballRankById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballRankById.HandleId, "db_pinballbattle.db", "select BinData from `PinballRank` where Id=?");
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x00153298 File Offset: 0x00151498
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

		// Token: 0x040032A6 RID: 12966
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040032A7 RID: 12967
		private const string FILE = "x.星弹奇游_活动.xlsx";

		// Token: 0x040032A8 RID: 12968
		private const string TABLE = "PinballRank";

		// Token: 0x040032A9 RID: 12969
		private const string COMMAND = "select BinData from `PinballRank` where Id=?";

		// Token: 0x040032AA RID: 12970
		private const string KEY_PREFIX = "PinballRankById";

		// Token: 0x040032AB RID: 12971
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032AC RID: 12972
		private static int HandleId;
	}
}
