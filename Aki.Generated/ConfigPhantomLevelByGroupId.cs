using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A2 RID: 1698
	public class ConfigPhantomLevelByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027DC RID: 10204 RVA: 0x0013AFB7 File Offset: 0x001391B7
		static ConfigPhantomLevelByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomLevelByGroupId.CreateStaticDefaultValue), new Action(ConfigPhantomLevelByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x0013AFD8 File Offset: 0x001391D8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomLevelByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomLevelByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomLevel` where GroupId=?")
			});
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x0013B057 File Offset: 0x00139257
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomLevelByGroupId.LogPair = null;
			ConfigPhantomLevelByGroupId.HandleId = 0;
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x0013B065 File Offset: 0x00139265
		public static void Init()
		{
			ConfigPhantomLevelByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomLevelByGroupId.HandleId, "db_phantom.db", "select BinData from `PhantomLevel` where GroupId=?");
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x0013B080 File Offset: 0x00139280
		[NullableContext(2)]
		public static IReadOnlyList<PhantomLevel> GetConfigList(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomLevelByGroupId.HandleId, ConfigPhantomLevelByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomLevelByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				IReadOnlyList<PhantomLevel> readOnlyList = (IReadOnlyList<PhantomLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPhantomLevelByGroupId.LogPair.Clear();
			ConfigPhantomLevelByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigPhantomLevelByGroupId.HandleId, 1, p0GroupId, ConfigPhantomLevelByGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigPhantomLevelByGroupId.HandleId, ConfigPhantomLevelByGroupId.LogPair);
				return null;
			}
			List<PhantomLevel> list = new List<PhantomLevel>();
			while (ConfigCommon.Step(ConfigPhantomLevelByGroupId.HandleId, false, ConfigPhantomLevelByGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomLevelByGroupId.HandleId, 0, ConfigPhantomLevelByGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhantomLevelByGroupId.HandleId, ConfigPhantomLevelByGroupId.LogPair);
					return null;
				}
				PhantomLevel rootAsPhantomLevel = PhantomLevel.GetRootAsPhantomLevel(new ByteBuffer(item2));
				list.Add(rootAsPhantomLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomLevelByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhantomLevelByGroupId.HandleId, ConfigPhantomLevelByGroupId.LogPair);
			return list;
		}

		// Token: 0x04002E54 RID: 11860
		private const string DB = "db_phantom.db";

		// Token: 0x04002E55 RID: 11861
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E56 RID: 11862
		private const string TABLE = "PhantomLevel";

		// Token: 0x04002E57 RID: 11863
		private const string COMMAND = "select BinData from `PhantomLevel` where GroupId=?";

		// Token: 0x04002E58 RID: 11864
		private const string KEY_PREFIX = "PhantomLevelByGroupId";

		// Token: 0x04002E59 RID: 11865
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E5A RID: 11866
		private static int HandleId;
	}
}
