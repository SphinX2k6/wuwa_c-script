using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B8 RID: 1720
	public class ConfigPhantomItemByMonsterId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002860 RID: 10336 RVA: 0x001415C4 File Offset: 0x0013F7C4
		static ConfigPhantomItemByMonsterId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomItemByMonsterId.CreateStaticDefaultValue), new Action(ConfigPhantomItemByMonsterId.ResetStaticDefaultValue));
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x001415E4 File Offset: 0x0013F7E4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomItemByMonsterId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomItemByMonsterId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomItem` where MonsterId=?")
			});
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x00141663 File Offset: 0x0013F863
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomItemByMonsterId.LogPair = null;
			ConfigPhantomItemByMonsterId.HandleId = 0;
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x00141671 File Offset: 0x0013F871
		public static void Init()
		{
			ConfigPhantomItemByMonsterId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomItemByMonsterId.HandleId, "db_phantom.db", "select BinData from `PhantomItem` where MonsterId=?");
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x0014168C File Offset: 0x0013F88C
		[NullableContext(2)]
		public static IReadOnlyList<PhantomItem> GetConfigList(int p0MonsterId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomItemByMonsterId.HandleId, ConfigPhantomItemByMonsterId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomItemByMonsterId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MonsterId);
				IReadOnlyList<PhantomItem> readOnlyList = (IReadOnlyList<PhantomItem>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomItemByMonsterId.LogPair.Clear();
			ConfigPhantomItemByMonsterId.LogPair.Add(new ValueTuple<string, object>("MonsterId", p0MonsterId));
			if (!ConfigCommon.BindInt(ConfigPhantomItemByMonsterId.HandleId, 1, p0MonsterId, ConfigPhantomItemByMonsterId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomItemByMonsterId.HandleId, ConfigPhantomItemByMonsterId.LogPair);
				return null;
			}
			List<PhantomItem> list = new List<PhantomItem>();
			while (ConfigCommon.Step(ConfigPhantomItemByMonsterId.HandleId, false, ConfigPhantomItemByMonsterId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomItemByMonsterId.HandleId, 0, ConfigPhantomItemByMonsterId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomItemByMonsterId.HandleId, ConfigPhantomItemByMonsterId.LogPair);
					return null;
				}
				PhantomItem rootAsPhantomItem = PhantomItem.GetRootAsPhantomItem(new ByteBuffer(item2));
				list.Add(rootAsPhantomItem);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomItemByMonsterId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MonsterId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomItemByMonsterId.HandleId, ConfigPhantomItemByMonsterId.LogPair);
			return list;
		}

		// Token: 0x04002EEE RID: 12014
		private const string DB = "db_phantom.db";

		// Token: 0x04002EEF RID: 12015
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EF0 RID: 12016
		private const string TABLE = "PhantomItem";

		// Token: 0x04002EF1 RID: 12017
		private const string COMMAND = "select BinData from `PhantomItem` where MonsterId=?";

		// Token: 0x04002EF2 RID: 12018
		private const string KEY_PREFIX = "PhantomItemByMonsterId";

		// Token: 0x04002EF3 RID: 12019
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EF4 RID: 12020
		private static int HandleId;
	}
}
