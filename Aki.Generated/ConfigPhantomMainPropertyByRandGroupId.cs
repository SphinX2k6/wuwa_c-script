using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A5 RID: 1701
	public class ConfigPhantomMainPropertyByRandGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027EE RID: 10222 RVA: 0x0013B6D4 File Offset: 0x001398D4
		static ConfigPhantomMainPropertyByRandGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomMainPropertyByRandGroupId.CreateStaticDefaultValue), new Action(ConfigPhantomMainPropertyByRandGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x0013B6F4 File Offset: 0x001398F4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomMainPropertyByRandGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomMainPropertyByRandGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomMainProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomMainProperty` where RandGroupId=?")
			});
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x0013B773 File Offset: 0x00139973
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomMainPropertyByRandGroupId.LogPair = null;
			ConfigPhantomMainPropertyByRandGroupId.HandleId = 0;
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x0013B781 File Offset: 0x00139981
		public static void Init()
		{
			ConfigPhantomMainPropertyByRandGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomMainPropertyByRandGroupId.HandleId, "db_phantom.db", "select BinData from `PhantomMainProperty` where RandGroupId=?");
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x0013B79C File Offset: 0x0013999C
		[NullableContext(2)]
		public static IReadOnlyList<PhantomMainProperty> GetConfigList(int p0RandGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomMainPropertyByRandGroupId.HandleId, ConfigPhantomMainPropertyByRandGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomMainPropertyByRandGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RandGroupId);
				IReadOnlyList<PhantomMainProperty> readOnlyList = (IReadOnlyList<PhantomMainProperty>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomMainPropertyByRandGroupId.LogPair.Clear();
			ConfigPhantomMainPropertyByRandGroupId.LogPair.Add(new ValueTuple<string, object>("RandGroupId", p0RandGroupId));
			if (!ConfigCommon.BindInt(ConfigPhantomMainPropertyByRandGroupId.HandleId, 1, p0RandGroupId, ConfigPhantomMainPropertyByRandGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomMainPropertyByRandGroupId.HandleId, ConfigPhantomMainPropertyByRandGroupId.LogPair);
				return null;
			}
			List<PhantomMainProperty> list = new List<PhantomMainProperty>();
			while (ConfigCommon.Step(ConfigPhantomMainPropertyByRandGroupId.HandleId, false, ConfigPhantomMainPropertyByRandGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomMainPropertyByRandGroupId.HandleId, 0, ConfigPhantomMainPropertyByRandGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomMainPropertyByRandGroupId.HandleId, ConfigPhantomMainPropertyByRandGroupId.LogPair);
					return null;
				}
				PhantomMainProperty rootAsPhantomMainProperty = PhantomMainProperty.GetRootAsPhantomMainProperty(new ByteBuffer(item2));
				list.Add(rootAsPhantomMainProperty);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomMainPropertyByRandGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RandGroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomMainPropertyByRandGroupId.HandleId, ConfigPhantomMainPropertyByRandGroupId.LogPair);
			return list;
		}

		// Token: 0x04002E69 RID: 11881
		private const string DB = "db_phantom.db";

		// Token: 0x04002E6A RID: 11882
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E6B RID: 11883
		private const string TABLE = "PhantomMainProperty";

		// Token: 0x04002E6C RID: 11884
		private const string COMMAND = "select BinData from `PhantomMainProperty` where RandGroupId=?";

		// Token: 0x04002E6D RID: 11885
		private const string KEY_PREFIX = "PhantomMainPropertyByRandGroupId";

		// Token: 0x04002E6E RID: 11886
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E6F RID: 11887
		private static int HandleId;
	}
}
