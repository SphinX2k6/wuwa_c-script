using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B9 RID: 1721
	public class ConfigPhantomItemByParentMonsterId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002866 RID: 10342 RVA: 0x001417FB File Offset: 0x0013F9FB
		static ConfigPhantomItemByParentMonsterId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomItemByParentMonsterId.CreateStaticDefaultValue), new Action(ConfigPhantomItemByParentMonsterId.ResetStaticDefaultValue));
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x0014181C File Offset: 0x0013FA1C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomItemByParentMonsterId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomItemByParentMonsterId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomItem` where ParentMonsterId=?")
			});
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x0014189B File Offset: 0x0013FA9B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomItemByParentMonsterId.LogPair = null;
			ConfigPhantomItemByParentMonsterId.HandleId = 0;
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x001418A9 File Offset: 0x0013FAA9
		public static void Init()
		{
			ConfigPhantomItemByParentMonsterId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomItemByParentMonsterId.HandleId, "db_phantom.db", "select BinData from `PhantomItem` where ParentMonsterId=?");
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x001418C4 File Offset: 0x0013FAC4
		[NullableContext(2)]
		public static IReadOnlyList<PhantomItem> GetConfigList(int p0ParentMonsterId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomItemByParentMonsterId.HandleId, ConfigPhantomItemByParentMonsterId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomItemByParentMonsterId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ParentMonsterId);
				IReadOnlyList<PhantomItem> readOnlyList = (IReadOnlyList<PhantomItem>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomItemByParentMonsterId.LogPair.Clear();
			ConfigPhantomItemByParentMonsterId.LogPair.Add(new ValueTuple<string, object>("ParentMonsterId", p0ParentMonsterId));
			if (!ConfigCommon.BindInt(ConfigPhantomItemByParentMonsterId.HandleId, 1, p0ParentMonsterId, ConfigPhantomItemByParentMonsterId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomItemByParentMonsterId.HandleId, ConfigPhantomItemByParentMonsterId.LogPair);
				return null;
			}
			List<PhantomItem> list = new List<PhantomItem>();
			while (ConfigCommon.Step(ConfigPhantomItemByParentMonsterId.HandleId, false, ConfigPhantomItemByParentMonsterId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomItemByParentMonsterId.HandleId, 0, ConfigPhantomItemByParentMonsterId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomItemByParentMonsterId.HandleId, ConfigPhantomItemByParentMonsterId.LogPair);
					return null;
				}
				PhantomItem rootAsPhantomItem = PhantomItem.GetRootAsPhantomItem(new ByteBuffer(item2));
				list.Add(rootAsPhantomItem);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomItemByParentMonsterId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ParentMonsterId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomItemByParentMonsterId.HandleId, ConfigPhantomItemByParentMonsterId.LogPair);
			return list;
		}

		// Token: 0x04002EF5 RID: 12021
		private const string DB = "db_phantom.db";

		// Token: 0x04002EF6 RID: 12022
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EF7 RID: 12023
		private const string TABLE = "PhantomItem";

		// Token: 0x04002EF8 RID: 12024
		private const string COMMAND = "select BinData from `PhantomItem` where ParentMonsterId=?";

		// Token: 0x04002EF9 RID: 12025
		private const string KEY_PREFIX = "PhantomItemByParentMonsterId";

		// Token: 0x04002EFA RID: 12026
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EFB RID: 12027
		private static int HandleId;
	}
}
