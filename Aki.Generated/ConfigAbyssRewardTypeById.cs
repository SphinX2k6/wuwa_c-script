using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000022 RID: 34
	public class ConfigAbyssRewardTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000CC RID: 204 RVA: 0x0005E553 File Offset: 0x0005C753
		static ConfigAbyssRewardTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRewardTypeById.CreateStaticDefaultValue), new Action(ConfigAbyssRewardTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0005E574 File Offset: 0x0005C774
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRewardTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRewardTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssRewardType"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssRewardType` where Id=?")
			});
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0005E5F3 File Offset: 0x0005C7F3
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRewardTypeById.LogPair = null;
			ConfigAbyssRewardTypeById.HandleId = 0;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0005E601 File Offset: 0x0005C801
		public static void Init()
		{
			ConfigAbyssRewardTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRewardTypeById.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssRewardType` where Id=?");
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0005E61C File Offset: 0x0005C81C
		public static AbyssRewardType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRewardTypeById.HandleId, ConfigAbyssRewardTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRewardTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AbyssRewardType?(AbyssRewardType.GetRootAsAbyssRewardType(configBuffer));
				}
			}
			ConfigAbyssRewardTypeById.LogPair.Clear();
			ConfigAbyssRewardTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAbyssRewardTypeById.HandleId, 1, p0Id, ConfigAbyssRewardTypeById.LogPair) || ConfigCommon.Step(ConfigAbyssRewardTypeById.HandleId, true, ConfigAbyssRewardTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAbyssRewardTypeById.HandleId, ConfigAbyssRewardTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRewardTypeById.HandleId, 0, ConfigAbyssRewardTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAbyssRewardTypeById.HandleId, ConfigAbyssRewardTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AbyssRewardType rootAsAbyssRewardType = AbyssRewardType.GetRootAsAbyssRewardType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AbyssRewardTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAbyssRewardTypeById.HandleId, ConfigAbyssRewardTypeById.LogPair);
			return new AbyssRewardType?(rootAsAbyssRewardType);
		}

		// Token: 0x040000D2 RID: 210
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x040000D3 RID: 211
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x040000D4 RID: 212
		private const string TABLE = "AbyssRewardType";

		// Token: 0x040000D5 RID: 213
		private const string COMMAND = "select BinData from `AbyssRewardType` where Id=?";

		// Token: 0x040000D6 RID: 214
		private const string KEY_PREFIX = "AbyssRewardTypeById";

		// Token: 0x040000D7 RID: 215
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040000D8 RID: 216
		private static int HandleId;
	}
}
