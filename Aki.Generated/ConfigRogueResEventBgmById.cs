using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000862 RID: 2146
	public class ConfigRogueResEventBgmById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600325E RID: 12894 RVA: 0x00179B38 File Offset: 0x00177D38
		static ConfigRogueResEventBgmById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEventBgmById.CreateStaticDefaultValue), new Action(ConfigRogueResEventBgmById.ResetStaticDefaultValue));
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x00179B58 File Offset: 0x00177D58
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEventBgmById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEventBgmById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEventBgm"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEventBgm` where Id=?")
			});
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x00179BD7 File Offset: 0x00177DD7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEventBgmById.LogPair = null;
			ConfigRogueResEventBgmById.HandleId = 0;
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x00179BE5 File Offset: 0x00177DE5
		public static void Init()
		{
			ConfigRogueResEventBgmById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEventBgmById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEventBgm` where Id=?");
		}

		// Token: 0x06003262 RID: 12898 RVA: 0x00179C00 File Offset: 0x00177E00
		public static RogueResEventBgm? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEventBgmById.HandleId, ConfigRogueResEventBgmById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventBgmById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResEventBgm?(RogueResEventBgm.GetRootAsRogueResEventBgm(configBuffer));
				}
			}
			ConfigRogueResEventBgmById.LogPair.Clear();
			ConfigRogueResEventBgmById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResEventBgmById.HandleId, 1, p0Id, ConfigRogueResEventBgmById.LogPair) || ConfigCommon.Step(ConfigRogueResEventBgmById.HandleId, true, ConfigRogueResEventBgmById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEventBgmById.HandleId, ConfigRogueResEventBgmById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEventBgmById.HandleId, 0, ConfigRogueResEventBgmById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEventBgmById.HandleId, ConfigRogueResEventBgmById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEventBgm rootAsRogueResEventBgm = RogueResEventBgm.GetRootAsRogueResEventBgm(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventBgmById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEventBgmById.HandleId, ConfigRogueResEventBgmById.LogPair);
			return new RogueResEventBgm?(rootAsRogueResEventBgm);
		}

		// Token: 0x04003A94 RID: 14996
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A95 RID: 14997
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A96 RID: 14998
		private const string TABLE = "RogueResEventBgm";

		// Token: 0x04003A97 RID: 14999
		private const string COMMAND = "select BinData from `RogueResEventBgm` where Id=?";

		// Token: 0x04003A98 RID: 15000
		private const string KEY_PREFIX = "RogueResEventBgmById";

		// Token: 0x04003A99 RID: 15001
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A9A RID: 15002
		private static int HandleId;
	}
}
