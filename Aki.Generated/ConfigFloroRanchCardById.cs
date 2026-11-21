using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000327 RID: 807
	public class ConfigFloroRanchCardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012EF RID: 4847 RVA: 0x000C8127 File Offset: 0x000C6327
		static ConfigFloroRanchCardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchCardById.CreateStaticDefaultValue), new Action(ConfigFloroRanchCardById.ResetStaticDefaultValue));
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x000C8148 File Offset: 0x000C6348
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchCardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchCardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchCard"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchCard` where Id=?")
			});
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x000C81C7 File Offset: 0x000C63C7
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchCardById.LogPair = null;
			ConfigFloroRanchCardById.HandleId = 0;
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x000C81D5 File Offset: 0x000C63D5
		public static void Init()
		{
			ConfigFloroRanchCardById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchCardById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchCard` where Id=?");
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x000C81F0 File Offset: 0x000C63F0
		public static FloroRanchCard? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchCardById.HandleId, ConfigFloroRanchCardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchCardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchCard?(FloroRanchCard.GetRootAsFloroRanchCard(configBuffer));
				}
			}
			ConfigFloroRanchCardById.LogPair.Clear();
			ConfigFloroRanchCardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchCardById.HandleId, 1, p0Id, ConfigFloroRanchCardById.LogPair) || ConfigCommon.Step(ConfigFloroRanchCardById.HandleId, true, ConfigFloroRanchCardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchCardById.HandleId, ConfigFloroRanchCardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchCardById.HandleId, 0, ConfigFloroRanchCardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchCardById.HandleId, ConfigFloroRanchCardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchCard rootAsFloroRanchCard = FloroRanchCard.GetRootAsFloroRanchCard(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchCardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchCardById.HandleId, ConfigFloroRanchCardById.LogPair);
			return new FloroRanchCard?(rootAsFloroRanchCard);
		}

		// Token: 0x040015F5 RID: 5621
		private const string DB = "db_flororanch.db";

		// Token: 0x040015F6 RID: 5622
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015F7 RID: 5623
		private const string TABLE = "FloroRanchCard";

		// Token: 0x040015F8 RID: 5624
		private const string COMMAND = "select BinData from `FloroRanchCard` where Id=?";

		// Token: 0x040015F9 RID: 5625
		private const string KEY_PREFIX = "FloroRanchCardById";

		// Token: 0x040015FA RID: 5626
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015FB RID: 5627
		private static int HandleId;
	}
}
