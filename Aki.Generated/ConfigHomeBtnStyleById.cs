using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003D7 RID: 983
	public class ConfigHomeBtnStyleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001711 RID: 5905 RVA: 0x000DBEC0 File Offset: 0x000DA0C0
		static ConfigHomeBtnStyleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHomeBtnStyleById.CreateStaticDefaultValue), new Action(ConfigHomeBtnStyleById.ResetStaticDefaultValue));
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x000DBEE0 File Offset: 0x000DA0E0
		public static void CreateStaticDefaultValue()
		{
			ConfigHomeBtnStyleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHomeBtnStyleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_homebtnstyle.db"),
				new ValueTuple<string, object>("文件", "h.Home键样式.xlsx"),
				new ValueTuple<string, object>("表名", "HomeBtnStyle"),
				new ValueTuple<string, object>("语句", "select BinData from `HomeBtnStyle` where Id=?")
			});
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x000DBF5F File Offset: 0x000DA15F
		public static void ResetStaticDefaultValue()
		{
			ConfigHomeBtnStyleById.LogPair = null;
			ConfigHomeBtnStyleById.HandleId = 0;
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x000DBF6D File Offset: 0x000DA16D
		public static void Init()
		{
			ConfigHomeBtnStyleById.HandleId = ConfigCommon.InitDataStatement(ConfigHomeBtnStyleById.HandleId, "db_homebtnstyle.db", "select BinData from `HomeBtnStyle` where Id=?");
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x000DBF88 File Offset: 0x000DA188
		public static HomeBtnStyle? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHomeBtnStyleById.HandleId, ConfigHomeBtnStyleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HomeBtnStyleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HomeBtnStyle?(HomeBtnStyle.GetRootAsHomeBtnStyle(configBuffer));
				}
			}
			ConfigHomeBtnStyleById.LogPair.Clear();
			ConfigHomeBtnStyleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHomeBtnStyleById.HandleId, 1, p0Id, ConfigHomeBtnStyleById.LogPair) || ConfigCommon.Step(ConfigHomeBtnStyleById.HandleId, true, ConfigHomeBtnStyleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHomeBtnStyleById.HandleId, ConfigHomeBtnStyleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHomeBtnStyleById.HandleId, 0, ConfigHomeBtnStyleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHomeBtnStyleById.HandleId, ConfigHomeBtnStyleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HomeBtnStyle rootAsHomeBtnStyle = HomeBtnStyle.GetRootAsHomeBtnStyle(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HomeBtnStyleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHomeBtnStyleById.HandleId, ConfigHomeBtnStyleById.LogPair);
			return new HomeBtnStyle?(rootAsHomeBtnStyle);
		}

		// Token: 0x04001AC5 RID: 6853
		private const string DB = "db_homebtnstyle.db";

		// Token: 0x04001AC6 RID: 6854
		private const string FILE = "h.Home键样式.xlsx";

		// Token: 0x04001AC7 RID: 6855
		private const string TABLE = "HomeBtnStyle";

		// Token: 0x04001AC8 RID: 6856
		private const string COMMAND = "select BinData from `HomeBtnStyle` where Id=?";

		// Token: 0x04001AC9 RID: 6857
		private const string KEY_PREFIX = "HomeBtnStyleById";

		// Token: 0x04001ACA RID: 6858
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001ACB RID: 6859
		private static int HandleId;
	}
}
