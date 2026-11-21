using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000733 RID: 1843
	public class ConfigPinballEntityTestByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B42 RID: 11074 RVA: 0x001515A0 File Offset: 0x0014F7A0
		static ConfigPinballEntityTestByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballEntityTestByMapId.CreateStaticDefaultValue), new Action(ConfigPinballEntityTestByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x001515C0 File Offset: 0x0014F7C0
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

		// Token: 0x06002B44 RID: 11076 RVA: 0x0015163F File Offset: 0x0014F83F
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballEntityTestByMapId.LogPair = null;
			ConfigPinballEntityTestByMapId.HandleId = 0;
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x0015164D File Offset: 0x0014F84D
		public static void Init()
		{
			ConfigPinballEntityTestByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigPinballEntityTestByMapId.HandleId, "db_pinballbattle.db", "select BinData from `PinballEntityTest` where MapId=?");
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x00151668 File Offset: 0x0014F868
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

		// Token: 0x0400324B RID: 12875
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400324C RID: 12876
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x0400324D RID: 12877
		private const string TABLE = "PinballEntityTest";

		// Token: 0x0400324E RID: 12878
		private const string COMMAND = "select BinData from `PinballEntityTest` where MapId=?";

		// Token: 0x0400324F RID: 12879
		private const string KEY_PREFIX = "PinballEntityTestByMapId";

		// Token: 0x04003250 RID: 12880
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003251 RID: 12881
		private static int HandleId;
	}
}
