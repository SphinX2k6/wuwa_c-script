using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200031D RID: 797
	public class ConfigFloroRanchInsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012B3 RID: 4787 RVA: 0x000C3253 File Offset: 0x000C1453
		static ConfigFloroRanchInsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchInsById.CreateStaticDefaultValue), new Action(ConfigFloroRanchInsById.ResetStaticDefaultValue));
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x000C3274 File Offset: 0x000C1474
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchInsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchInsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchIns"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchIns` where Id=?")
			});
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x000C32F3 File Offset: 0x000C14F3
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchInsById.LogPair = null;
			ConfigFloroRanchInsById.HandleId = 0;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x000C3301 File Offset: 0x000C1501
		public static void Init()
		{
			ConfigFloroRanchInsById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchInsById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchIns` where Id=?");
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x000C331C File Offset: 0x000C151C
		public static FloroRanchIns? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchInsById.HandleId, ConfigFloroRanchInsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchInsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchIns?(FloroRanchIns.GetRootAsFloroRanchIns(configBuffer));
				}
			}
			ConfigFloroRanchInsById.LogPair.Clear();
			ConfigFloroRanchInsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchInsById.HandleId, 1, p0Id, ConfigFloroRanchInsById.LogPair) || ConfigCommon.Step(ConfigFloroRanchInsById.HandleId, true, ConfigFloroRanchInsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchInsById.HandleId, ConfigFloroRanchInsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchInsById.HandleId, 0, ConfigFloroRanchInsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchInsById.HandleId, ConfigFloroRanchInsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchIns rootAsFloroRanchIns = FloroRanchIns.GetRootAsFloroRanchIns(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchInsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchInsById.HandleId, ConfigFloroRanchInsById.LogPair);
			return new FloroRanchIns?(rootAsFloroRanchIns);
		}

		// Token: 0x040015AF RID: 5551
		private const string DB = "db_flororanch.db";

		// Token: 0x040015B0 RID: 5552
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015B1 RID: 5553
		private const string TABLE = "FloroRanchIns";

		// Token: 0x040015B2 RID: 5554
		private const string COMMAND = "select BinData from `FloroRanchIns` where Id=?";

		// Token: 0x040015B3 RID: 5555
		private const string KEY_PREFIX = "FloroRanchInsById";

		// Token: 0x040015B4 RID: 5556
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015B5 RID: 5557
		private static int HandleId;
	}
}
