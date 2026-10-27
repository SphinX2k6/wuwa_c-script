using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200071B RID: 1819
	public class ConfigPinballEntityTestByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AB2 RID: 10930 RVA: 0x0014AB24 File Offset: 0x00148D24
		static ConfigPinballEntityTestByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballEntityTestByMapId.CreateStaticDefaultValue), new Action(ConfigPinballEntityTestByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x0014AB44 File Offset: 0x00148D44
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballEntityTestByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballEntityTestByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "PinballEntityTest"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballEntityTest` where MapId=?")
			});
		}

		// Token: 0x06002AB4 RID: 10932 RVA: 0x0014ABC3 File Offset: 0x00148DC3
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballEntityTestByMapId.LogPair = null;
			ConfigPinballEntityTestByMapId.HandleId = 0;
		}

		// Token: 0x06002AB5 RID: 10933 RVA: 0x0014ABD1 File Offset: 0x00148DD1
		public static void Init()
		{
			ConfigPinballEntityTestByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigPinballEntityTestByMapId.HandleId, "db_pinballbattle.db", "select BinData from `PinballEntityTest` where MapId=?");
		}

		// Token: 0x06002AB6 RID: 10934 RVA: 0x0014ABEC File Offset: 0x00148DEC
		[NullableContext(2)]
		public static IReadOnlyList<PinballEntityTest> GetConfigList(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballEntityTestByMapId.HandleId, ConfigPinballEntityTestByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballEntityTestByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				IReadOnlyList<PinballEntityTest> readOnlyList = (IReadOnlyList<PinballEntityTest>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigPinballEntityTestByMapId.LogPair.Clear();
			ConfigPinballEntityTestByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigPinballEntityTestByMapId.HandleId, 1, p0MapId, ConfigPinballEntityTestByMapId.LogPair))
			{
				ConfigCommon.Reset(ConfigPinballEntityTestByMapId.HandleId, ConfigPinballEntityTestByMapId.LogPair);
				return null;
			}
			List<PinballEntityTest> list = new List<PinballEntityTest>();
			while (ConfigCommon.Step(ConfigPinballEntityTestByMapId.HandleId, false, ConfigPinballEntityTestByMapId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballEntityTestByMapId.HandleId, 0, ConfigPinballEntityTestByMapId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPinballEntityTestByMapId.HandleId, ConfigPinballEntityTestByMapId.LogPair);
					return null;
				}
				PinballEntityTest rootAsPinballEntityTest = PinballEntityTest.GetRootAsPinballEntityTest(new ByteBuffer(item2));
				list.Add(rootAsPinballEntityTest);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballEntityTestByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigPinballEntityTestByMapId.HandleId, ConfigPinballEntityTestByMapId.LogPair);
			return list;
		}

		// Token: 0x040031A3 RID: 12707
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031A4 RID: 12708
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x040031A5 RID: 12709
		private const string TABLE = "PinballEntityTest";

		// Token: 0x040031A6 RID: 12710
		private const string COMMAND = "select BinData from `PinballEntityTest` where MapId=?";

		// Token: 0x040031A7 RID: 12711
		private const string KEY_PREFIX = "PinballEntityTestByMapId";

		// Token: 0x040031A8 RID: 12712
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031A9 RID: 12713
		private static int HandleId;
	}
}
