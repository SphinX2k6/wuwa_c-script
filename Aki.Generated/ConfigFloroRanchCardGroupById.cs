using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000329 RID: 809
	public class ConfigFloroRanchCardGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012FB RID: 4859 RVA: 0x000C8503 File Offset: 0x000C6703
		static ConfigFloroRanchCardGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchCardGroupById.CreateStaticDefaultValue), new Action(ConfigFloroRanchCardGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x000C8524 File Offset: 0x000C6724
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchCardGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchCardGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchCardGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchCardGroup` where Id=?")
			});
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x000C85A3 File Offset: 0x000C67A3
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchCardGroupById.LogPair = null;
			ConfigFloroRanchCardGroupById.HandleId = 0;
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x000C85B1 File Offset: 0x000C67B1
		public static void Init()
		{
			ConfigFloroRanchCardGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchCardGroupById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchCardGroup` where Id=?");
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x000C85CC File Offset: 0x000C67CC
		public static FloroRanchCardGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchCardGroupById.HandleId, ConfigFloroRanchCardGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchCardGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchCardGroup?(FloroRanchCardGroup.GetRootAsFloroRanchCardGroup(configBuffer));
				}
			}
			ConfigFloroRanchCardGroupById.LogPair.Clear();
			ConfigFloroRanchCardGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchCardGroupById.HandleId, 1, p0Id, ConfigFloroRanchCardGroupById.LogPair) || ConfigCommon.Step(ConfigFloroRanchCardGroupById.HandleId, true, ConfigFloroRanchCardGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchCardGroupById.HandleId, ConfigFloroRanchCardGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchCardGroupById.HandleId, 0, ConfigFloroRanchCardGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchCardGroupById.HandleId, ConfigFloroRanchCardGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchCardGroup rootAsFloroRanchCardGroup = FloroRanchCardGroup.GetRootAsFloroRanchCardGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchCardGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchCardGroupById.HandleId, ConfigFloroRanchCardGroupById.LogPair);
			return new FloroRanchCardGroup?(rootAsFloroRanchCardGroup);
		}

		// Token: 0x04001603 RID: 5635
		private const string DB = "db_flororanch.db";

		// Token: 0x04001604 RID: 5636
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001605 RID: 5637
		private const string TABLE = "FloroRanchCardGroup";

		// Token: 0x04001606 RID: 5638
		private const string COMMAND = "select BinData from `FloroRanchCardGroup` where Id=?";

		// Token: 0x04001607 RID: 5639
		private const string KEY_PREFIX = "FloroRanchCardGroupById";

		// Token: 0x04001608 RID: 5640
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001609 RID: 5641
		private static int HandleId;
	}
}
