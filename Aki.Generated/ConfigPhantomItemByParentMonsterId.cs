using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A1 RID: 1697
	public class ConfigPhantomItemByParentMonsterId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027D6 RID: 10198 RVA: 0x0013AD7F File Offset: 0x00138F7F
		static ConfigPhantomItemByParentMonsterId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomItemByParentMonsterId.CreateStaticDefaultValue), new Action(ConfigPhantomItemByParentMonsterId.ResetStaticDefaultValue));
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x0013ADA0 File Offset: 0x00138FA0
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

		// Token: 0x060027D8 RID: 10200 RVA: 0x0013AE1F File Offset: 0x0013901F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomItemByParentMonsterId.LogPair = null;
			ConfigPhantomItemByParentMonsterId.HandleId = 0;
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x0013AE2D File Offset: 0x0013902D
		public static void Init()
		{
			ConfigPhantomItemByParentMonsterId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomItemByParentMonsterId.HandleId, "db_phantom.db", "select BinData from `PhantomItem` where ParentMonsterId=?");
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x0013AE48 File Offset: 0x00139048
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

		// Token: 0x04002E4D RID: 11853
		private const string DB = "db_phantom.db";

		// Token: 0x04002E4E RID: 11854
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E4F RID: 11855
		private const string TABLE = "PhantomItem";

		// Token: 0x04002E50 RID: 11856
		private const string COMMAND = "select BinData from `PhantomItem` where ParentMonsterId=?";

		// Token: 0x04002E51 RID: 11857
		private const string KEY_PREFIX = "PhantomItemByParentMonsterId";

		// Token: 0x04002E52 RID: 11858
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E53 RID: 11859
		private static int HandleId;
	}
}
