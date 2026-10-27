using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000020 RID: 32
	public class ConfigAbyssRewardTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x0005E177 File Offset: 0x0005C377
		static ConfigAbyssRewardTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRewardTabById.CreateStaticDefaultValue), new Action(ConfigAbyssRewardTabById.ResetStaticDefaultValue));
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0005E198 File Offset: 0x0005C398
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRewardTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRewardTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssRewardTab"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssRewardTab` where Id=?")
			});
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0005E217 File Offset: 0x0005C417
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRewardTabById.LogPair = null;
			ConfigAbyssRewardTabById.HandleId = 0;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0005E225 File Offset: 0x0005C425
		public static void Init()
		{
			ConfigAbyssRewardTabById.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRewardTabById.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssRewardTab` where Id=?");
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0005E240 File Offset: 0x0005C440
		public static AbyssRewardTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRewardTabById.HandleId, ConfigAbyssRewardTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRewardTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssRewardTab?(AbyssRewardTab.GetRootAsAbyssRewardTab(configBuffer));
				}
			}
			ConfigAbyssRewardTabById.LogPair.Clear();
			ConfigAbyssRewardTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbyssRewardTabById.HandleId, 1, p0Id, ConfigAbyssRewardTabById.LogPair) || ConfigCommon.Step(ConfigAbyssRewardTabById.HandleId, true, ConfigAbyssRewardTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssRewardTabById.HandleId, ConfigAbyssRewardTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRewardTabById.HandleId, 0, ConfigAbyssRewardTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssRewardTabById.HandleId, ConfigAbyssRewardTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssRewardTab rootAsAbyssRewardTab = AbyssRewardTab.GetRootAsAbyssRewardTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRewardTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssRewardTabById.HandleId, ConfigAbyssRewardTabById.LogPair);
			return new AbyssRewardTab?(rootAsAbyssRewardTab);
		}

		// Token: 0x040000C4 RID: 196
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x040000C5 RID: 197
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x040000C6 RID: 198
		private const string TABLE = "AbyssRewardTab";

		// Token: 0x040000C7 RID: 199
		private const string COMMAND = "select BinData from `AbyssRewardTab` where Id=?";

		// Token: 0x040000C8 RID: 200
		private const string KEY_PREFIX = "AbyssRewardTabById";

		// Token: 0x040000C9 RID: 201
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040000CA RID: 202
		private static int HandleId;
	}
}
