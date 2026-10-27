using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B6 RID: 1718
	public class ConfigPhantomSubPropertyByPropId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002854 RID: 10324 RVA: 0x0013DA8C File Offset: 0x0013BC8C
		static ConfigPhantomSubPropertyByPropId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomSubPropertyByPropId.CreateStaticDefaultValue), new Action(ConfigPhantomSubPropertyByPropId.ResetStaticDefaultValue));
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x0013DAAC File Offset: 0x0013BCAC
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

		// Token: 0x06002856 RID: 10326 RVA: 0x0013DB2B File Offset: 0x0013BD2B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomSubPropertyByPropId.LogPair = null;
			ConfigPhantomSubPropertyByPropId.HandleId = 0;
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x0013DB39 File Offset: 0x0013BD39
		public static void Init()
		{
			ConfigPhantomSubPropertyByPropId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomSubPropertyByPropId.HandleId, "db_phantom.db", "select BinData from `PhantomSubProperty` where PropId=?");
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x0013DB54 File Offset: 0x0013BD54
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

		// Token: 0x04002EE0 RID: 12000
		private const string DB = "db_phantom.db";

		// Token: 0x04002EE1 RID: 12001
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EE2 RID: 12002
		private const string TABLE = "PhantomSubProperty";

		// Token: 0x04002EE3 RID: 12003
		private const string COMMAND = "select BinData from `PhantomSubProperty` where PropId=?";

		// Token: 0x04002EE4 RID: 12004
		private const string KEY_PREFIX = "PhantomSubPropertyByPropId";

		// Token: 0x04002EE5 RID: 12005
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EE6 RID: 12006
		private static int HandleId;
	}
}
