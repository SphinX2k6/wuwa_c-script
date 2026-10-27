using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000326 RID: 806
	public class ConfigFloroRanchSubInsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012E9 RID: 4841 RVA: 0x000C44B0 File Offset: 0x000C26B0
		static ConfigFloroRanchSubInsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchSubInsById.CreateStaticDefaultValue), new Action(ConfigFloroRanchSubInsById.ResetStaticDefaultValue));
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x000C44D0 File Offset: 0x000C26D0
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchSubInsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchSubInsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchSubIns"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchSubIns` where Id=?")
			});
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x000C454F File Offset: 0x000C274F
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchSubInsById.LogPair = null;
			ConfigFloroRanchSubInsById.HandleId = 0;
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x000C455D File Offset: 0x000C275D
		public static void Init()
		{
			ConfigFloroRanchSubInsById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchSubInsById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchSubIns` where Id=?");
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x000C4578 File Offset: 0x000C2778
		public static FloroRanchSubIns? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchSubInsById.HandleId, ConfigFloroRanchSubInsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchSubInsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchSubIns?(FloroRanchSubIns.GetRootAsFloroRanchSubIns(configBuffer));
				}
			}
			ConfigFloroRanchSubInsById.LogPair.Clear();
			ConfigFloroRanchSubInsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchSubInsById.HandleId, 1, p0Id, ConfigFloroRanchSubInsById.LogPair) || ConfigCommon.Step(ConfigFloroRanchSubInsById.HandleId, true, ConfigFloroRanchSubInsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchSubInsById.HandleId, ConfigFloroRanchSubInsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchSubInsById.HandleId, 0, ConfigFloroRanchSubInsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchSubInsById.HandleId, ConfigFloroRanchSubInsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchSubIns rootAsFloroRanchSubIns = FloroRanchSubIns.GetRootAsFloroRanchSubIns(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchSubInsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchSubInsById.HandleId, ConfigFloroRanchSubInsById.LogPair);
			return new FloroRanchSubIns?(rootAsFloroRanchSubIns);
		}

		// Token: 0x040015EE RID: 5614
		private const string DB = "db_flororanch.db";

		// Token: 0x040015EF RID: 5615
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015F0 RID: 5616
		private const string TABLE = "FloroRanchSubIns";

		// Token: 0x040015F1 RID: 5617
		private const string COMMAND = "select BinData from `FloroRanchSubIns` where Id=?";

		// Token: 0x040015F2 RID: 5618
		private const string KEY_PREFIX = "FloroRanchSubInsById";

		// Token: 0x040015F3 RID: 5619
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015F4 RID: 5620
		private static int HandleId;
	}
}
