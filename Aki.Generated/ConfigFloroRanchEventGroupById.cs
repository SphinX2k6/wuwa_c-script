using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200032E RID: 814
	public class ConfigFloroRanchEventGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001319 RID: 4889 RVA: 0x000C8F04 File Offset: 0x000C7104
		static ConfigFloroRanchEventGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchEventGroupById.CreateStaticDefaultValue), new Action(ConfigFloroRanchEventGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x000C8F24 File Offset: 0x000C7124
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchEventGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchEventGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchEventGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchEventGroup` where Id=?")
			});
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x000C8FA3 File Offset: 0x000C71A3
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchEventGroupById.LogPair = null;
			ConfigFloroRanchEventGroupById.HandleId = 0;
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x000C8FB1 File Offset: 0x000C71B1
		public static void Init()
		{
			ConfigFloroRanchEventGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchEventGroupById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchEventGroup` where Id=?");
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x000C8FCC File Offset: 0x000C71CC
		public static FloroRanchEventGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchEventGroupById.HandleId, ConfigFloroRanchEventGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchEventGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchEventGroup?(FloroRanchEventGroup.GetRootAsFloroRanchEventGroup(configBuffer));
				}
			}
			ConfigFloroRanchEventGroupById.LogPair.Clear();
			ConfigFloroRanchEventGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchEventGroupById.HandleId, 1, p0Id, ConfigFloroRanchEventGroupById.LogPair) || ConfigCommon.Step(ConfigFloroRanchEventGroupById.HandleId, true, ConfigFloroRanchEventGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchEventGroupById.HandleId, ConfigFloroRanchEventGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchEventGroupById.HandleId, 0, ConfigFloroRanchEventGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchEventGroupById.HandleId, ConfigFloroRanchEventGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchEventGroup rootAsFloroRanchEventGroup = FloroRanchEventGroup.GetRootAsFloroRanchEventGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchEventGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchEventGroupById.HandleId, ConfigFloroRanchEventGroupById.LogPair);
			return new FloroRanchEventGroup?(rootAsFloroRanchEventGroup);
		}

		// Token: 0x04001626 RID: 5670
		private const string DB = "db_flororanch.db";

		// Token: 0x04001627 RID: 5671
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001628 RID: 5672
		private const string TABLE = "FloroRanchEventGroup";

		// Token: 0x04001629 RID: 5673
		private const string COMMAND = "select BinData from `FloroRanchEventGroup` where Id=?";

		// Token: 0x0400162A RID: 5674
		private const string KEY_PREFIX = "FloroRanchEventGroupById";

		// Token: 0x0400162B RID: 5675
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400162C RID: 5676
		private static int HandleId;
	}
}
