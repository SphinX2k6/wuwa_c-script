using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A0 RID: 1696
	public class ConfigPhantomItemByMonsterId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027D0 RID: 10192 RVA: 0x0013AB48 File Offset: 0x00138D48
		static ConfigPhantomItemByMonsterId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomItemByMonsterId.CreateStaticDefaultValue), new Action(ConfigPhantomItemByMonsterId.ResetStaticDefaultValue));
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x0013AB68 File Offset: 0x00138D68
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

		// Token: 0x060027D2 RID: 10194 RVA: 0x0013ABE7 File Offset: 0x00138DE7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomItemByMonsterId.LogPair = null;
			ConfigPhantomItemByMonsterId.HandleId = 0;
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x0013ABF5 File Offset: 0x00138DF5
		public static void Init()
		{
			ConfigPhantomItemByMonsterId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomItemByMonsterId.HandleId, "db_phantom.db", "select BinData from `PhantomItem` where MonsterId=?");
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x0013AC10 File Offset: 0x00138E10
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

		// Token: 0x04002E46 RID: 11846
		private const string DB = "db_phantom.db";

		// Token: 0x04002E47 RID: 11847
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E48 RID: 11848
		private const string TABLE = "PhantomItem";

		// Token: 0x04002E49 RID: 11849
		private const string COMMAND = "select BinData from `PhantomItem` where MonsterId=?";

		// Token: 0x04002E4A RID: 11850
		private const string KEY_PREFIX = "PhantomItemByMonsterId";

		// Token: 0x04002E4B RID: 11851
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E4C RID: 11852
		private static int HandleId;
	}
}
