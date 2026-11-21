using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006CE RID: 1742
	public class ConfigPhantomSubPropertyByPropId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028E4 RID: 10468 RVA: 0x00144508 File Offset: 0x00142708
		static ConfigPhantomSubPropertyByPropId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomSubPropertyByPropId.CreateStaticDefaultValue), new Action(ConfigPhantomSubPropertyByPropId.ResetStaticDefaultValue));
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x00144528 File Offset: 0x00142728
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomSubPropertyByPropId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomSubPropertyByPropId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomSubProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomSubProperty` where PropId=?")
			});
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x001445A7 File Offset: 0x001427A7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomSubPropertyByPropId.LogPair = null;
			ConfigPhantomSubPropertyByPropId.HandleId = 0;
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x001445B5 File Offset: 0x001427B5
		public static void Init()
		{
			ConfigPhantomSubPropertyByPropId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomSubPropertyByPropId.HandleId, "db_phantom.db", "select BinData from `PhantomSubProperty` where PropId=?");
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x001445D0 File Offset: 0x001427D0
		[NullableContext(2)]
		public static IReadOnlyList<PhantomSubProperty> GetConfigList(int p0PropId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomSubPropertyByPropId.HandleId, ConfigPhantomSubPropertyByPropId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomSubPropertyByPropId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PropId);
				IReadOnlyList<PhantomSubProperty> readOnlyList = (IReadOnlyList<PhantomSubProperty>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomSubPropertyByPropId.LogPair.Clear();
			ConfigPhantomSubPropertyByPropId.LogPair.Add(new ValueTuple<string, object>("PropId", p0PropId));
			if (!ConfigCommon.BindInt(ConfigPhantomSubPropertyByPropId.HandleId, 1, p0PropId, ConfigPhantomSubPropertyByPropId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomSubPropertyByPropId.HandleId, ConfigPhantomSubPropertyByPropId.LogPair);
				return null;
			}
			List<PhantomSubProperty> list = new List<PhantomSubProperty>();
			while (ConfigCommon.Step(ConfigPhantomSubPropertyByPropId.HandleId, false, ConfigPhantomSubPropertyByPropId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomSubPropertyByPropId.HandleId, 0, ConfigPhantomSubPropertyByPropId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomSubPropertyByPropId.HandleId, ConfigPhantomSubPropertyByPropId.LogPair);
					return null;
				}
				PhantomSubProperty rootAsPhantomSubProperty = PhantomSubProperty.GetRootAsPhantomSubProperty(new ByteBuffer(item2));
				list.Add(rootAsPhantomSubProperty);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomSubPropertyByPropId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0PropId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomSubPropertyByPropId.HandleId, ConfigPhantomSubPropertyByPropId.LogPair);
			return list;
		}

		// Token: 0x04002F88 RID: 12168
		private const string DB = "db_phantom.db";

		// Token: 0x04002F89 RID: 12169
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002F8A RID: 12170
		private const string TABLE = "PhantomSubProperty";

		// Token: 0x04002F8B RID: 12171
		private const string COMMAND = "select BinData from `PhantomSubProperty` where PropId=?";

		// Token: 0x04002F8C RID: 12172
		private const string KEY_PREFIX = "PhantomSubPropertyByPropId";

		// Token: 0x04002F8D RID: 12173
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F8E RID: 12174
		private static int HandleId;
	}
}
