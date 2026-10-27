using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000319 RID: 793
	public class ConfigFloroRanchEventGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600129B RID: 4763 RVA: 0x000C29F8 File Offset: 0x000C0BF8
		static ConfigFloroRanchEventGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchEventGroupById.CreateStaticDefaultValue), new Action(ConfigFloroRanchEventGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x000C2A18 File Offset: 0x000C0C18
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

		// Token: 0x0600129D RID: 4765 RVA: 0x000C2A97 File Offset: 0x000C0C97
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchEventGroupById.LogPair = null;
			ConfigFloroRanchEventGroupById.HandleId = 0;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x000C2AA5 File Offset: 0x000C0CA5
		public static void Init()
		{
			ConfigFloroRanchEventGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchEventGroupById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchEventGroup` where Id=?");
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x000C2AC0 File Offset: 0x000C0CC0
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

		// Token: 0x04001593 RID: 5523
		private const string DB = "db_flororanch.db";

		// Token: 0x04001594 RID: 5524
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001595 RID: 5525
		private const string TABLE = "FloroRanchEventGroup";

		// Token: 0x04001596 RID: 5526
		private const string COMMAND = "select BinData from `FloroRanchEventGroup` where Id=?";

		// Token: 0x04001597 RID: 5527
		private const string KEY_PREFIX = "FloroRanchEventGroupById";

		// Token: 0x04001598 RID: 5528
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001599 RID: 5529
		private static int HandleId;
	}
}
