using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006BA RID: 1722
	public class ConfigPhantomLevelByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600286C RID: 10348 RVA: 0x00141A33 File Offset: 0x0013FC33
		static ConfigPhantomLevelByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomLevelByGroupId.CreateStaticDefaultValue), new Action(ConfigPhantomLevelByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x00141A54 File Offset: 0x0013FC54
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

		// Token: 0x0600286E RID: 10350 RVA: 0x00141AD3 File Offset: 0x0013FCD3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomLevelByGroupId.LogPair = null;
			ConfigPhantomLevelByGroupId.HandleId = 0;
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x00141AE1 File Offset: 0x0013FCE1
		public static void Init()
		{
			ConfigPhantomLevelByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomLevelByGroupId.HandleId, "db_phantom.db", "select BinData from `PhantomLevel` where GroupId=?");
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x00141AFC File Offset: 0x0013FCFC
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

		// Token: 0x04002EFC RID: 12028
		private const string DB = "db_phantom.db";

		// Token: 0x04002EFD RID: 12029
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EFE RID: 12030
		private const string TABLE = "PhantomLevel";

		// Token: 0x04002EFF RID: 12031
		private const string COMMAND = "select BinData from `PhantomLevel` where GroupId=?";

		// Token: 0x04002F00 RID: 12032
		private const string KEY_PREFIX = "PhantomLevelByGroupId";

		// Token: 0x04002F01 RID: 12033
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F02 RID: 12034
		private static int HandleId;
	}
}
