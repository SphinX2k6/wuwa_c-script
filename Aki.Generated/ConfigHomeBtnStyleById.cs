using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003ED RID: 1005
	public class ConfigHomeBtnStyleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001795 RID: 6037 RVA: 0x000E2614 File Offset: 0x000E0814
		static ConfigHomeBtnStyleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHomeBtnStyleById.CreateStaticDefaultValue), new Action(ConfigHomeBtnStyleById.ResetStaticDefaultValue));
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x000E2634 File Offset: 0x000E0834
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

		// Token: 0x06001797 RID: 6039 RVA: 0x000E26B3 File Offset: 0x000E08B3
		public static void ResetStaticDefaultValue()
		{
			ConfigHomeBtnStyleById.LogPair = null;
			ConfigHomeBtnStyleById.HandleId = 0;
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x000E26C1 File Offset: 0x000E08C1
		public static void Init()
		{
			ConfigHomeBtnStyleById.HandleId = ConfigCommon.InitDataStatement(ConfigHomeBtnStyleById.HandleId, "db_homebtnstyle.db", "select BinData from `HomeBtnStyle` where Id=?");
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x000E26DC File Offset: 0x000E08DC
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

		// Token: 0x04001B5F RID: 7007
		private const string DB = "db_homebtnstyle.db";

		// Token: 0x04001B60 RID: 7008
		private const string FILE = "h.Home键样式.xlsx";

		// Token: 0x04001B61 RID: 7009
		private const string TABLE = "HomeBtnStyle";

		// Token: 0x04001B62 RID: 7010
		private const string COMMAND = "select BinData from `HomeBtnStyle` where Id=?";

		// Token: 0x04001B63 RID: 7011
		private const string KEY_PREFIX = "HomeBtnStyleById";

		// Token: 0x04001B64 RID: 7012
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B65 RID: 7013
		private static int HandleId;
	}
}
