using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006BD RID: 1725
	public class ConfigPhantomMainPropertyByRandGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600287E RID: 10366 RVA: 0x00142150 File Offset: 0x00140350
		static ConfigPhantomMainPropertyByRandGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomMainPropertyByRandGroupId.CreateStaticDefaultValue), new Action(ConfigPhantomMainPropertyByRandGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x00142170 File Offset: 0x00140370
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

		// Token: 0x06002880 RID: 10368 RVA: 0x001421EF File Offset: 0x001403EF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomMainPropertyByRandGroupId.LogPair = null;
			ConfigPhantomMainPropertyByRandGroupId.HandleId = 0;
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x001421FD File Offset: 0x001403FD
		public static void Init()
		{
			ConfigPhantomMainPropertyByRandGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomMainPropertyByRandGroupId.HandleId, "db_phantom.db", "select BinData from `PhantomMainProperty` where RandGroupId=?");
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x00142218 File Offset: 0x00140418
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

		// Token: 0x04002F11 RID: 12049
		private const string DB = "db_phantom.db";

		// Token: 0x04002F12 RID: 12050
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002F13 RID: 12051
		private const string TABLE = "PhantomMainProperty";

		// Token: 0x04002F14 RID: 12052
		private const string COMMAND = "select BinData from `PhantomMainProperty` where RandGroupId=?";

		// Token: 0x04002F15 RID: 12053
		private const string KEY_PREFIX = "PhantomMainPropertyByRandGroupId";

		// Token: 0x04002F16 RID: 12054
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F17 RID: 12055
		private static int HandleId;
	}
}
