using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000325 RID: 805
	public class ConfigFloroRanchBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012E3 RID: 4835 RVA: 0x000C7D4B File Offset: 0x000C5F4B
		static ConfigFloroRanchBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchBuffById.CreateStaticDefaultValue), new Action(ConfigFloroRanchBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x000C7D6C File Offset: 0x000C5F6C
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanchbuff.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场_buff.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchBuff` where Id=?")
			});
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x000C7DEB File Offset: 0x000C5FEB
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchBuffById.LogPair = null;
			ConfigFloroRanchBuffById.HandleId = 0;
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x000C7DF9 File Offset: 0x000C5FF9
		public static void Init()
		{
			ConfigFloroRanchBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchBuffById.HandleId, "db_flororanchbuff.db", "select BinData from `FloroRanchBuff` where Id=?");
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x000C7E14 File Offset: 0x000C6014
		public static FloroRanchBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchBuffById.HandleId, ConfigFloroRanchBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchBuff?(FloroRanchBuff.GetRootAsFloroRanchBuff(configBuffer));
				}
			}
			ConfigFloroRanchBuffById.LogPair.Clear();
			ConfigFloroRanchBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchBuffById.HandleId, 1, p0Id, ConfigFloroRanchBuffById.LogPair) || ConfigCommon.Step(ConfigFloroRanchBuffById.HandleId, true, ConfigFloroRanchBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchBuffById.HandleId, ConfigFloroRanchBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchBuffById.HandleId, 0, ConfigFloroRanchBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchBuffById.HandleId, ConfigFloroRanchBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchBuff rootAsFloroRanchBuff = FloroRanchBuff.GetRootAsFloroRanchBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchBuffById.HandleId, ConfigFloroRanchBuffById.LogPair);
			return new FloroRanchBuff?(rootAsFloroRanchBuff);
		}

		// Token: 0x040015E7 RID: 5607
		private const string DB = "db_flororanchbuff.db";

		// Token: 0x040015E8 RID: 5608
		private const string FILE = "f.弗洛洛牧场_buff.xlsx";

		// Token: 0x040015E9 RID: 5609
		private const string TABLE = "FloroRanchBuff";

		// Token: 0x040015EA RID: 5610
		private const string COMMAND = "select BinData from `FloroRanchBuff` where Id=?";

		// Token: 0x040015EB RID: 5611
		private const string KEY_PREFIX = "FloroRanchBuffById";

		// Token: 0x040015EC RID: 5612
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015ED RID: 5613
		private static int HandleId;
	}
}
