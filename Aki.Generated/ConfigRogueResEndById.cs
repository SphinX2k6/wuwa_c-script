using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000860 RID: 2144
	public class ConfigRogueResEndById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003252 RID: 12882 RVA: 0x001796A8 File Offset: 0x001778A8
		static ConfigRogueResEndById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEndById.CreateStaticDefaultValue), new Action(ConfigRogueResEndById.ResetStaticDefaultValue));
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x001796C8 File Offset: 0x001778C8
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEndById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEndById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEnd"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEnd` where Id=?")
			});
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x00179747 File Offset: 0x00177947
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEndById.LogPair = null;
			ConfigRogueResEndById.HandleId = 0;
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x00179755 File Offset: 0x00177955
		public static void Init()
		{
			ConfigRogueResEndById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEndById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEnd` where Id=?");
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x00179770 File Offset: 0x00177970
		public static RogueResEnd? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEndById.HandleId, ConfigRogueResEndById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEndById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResEnd?(RogueResEnd.GetRootAsRogueResEnd(configBuffer));
				}
			}
			ConfigRogueResEndById.LogPair.Clear();
			ConfigRogueResEndById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResEndById.HandleId, 1, p0Id, ConfigRogueResEndById.LogPair) || ConfigCommon.Step(ConfigRogueResEndById.HandleId, true, ConfigRogueResEndById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEndById.HandleId, ConfigRogueResEndById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEndById.HandleId, 0, ConfigRogueResEndById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEndById.HandleId, ConfigRogueResEndById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEnd rootAsRogueResEnd = RogueResEnd.GetRootAsRogueResEnd(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEndById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEndById.HandleId, ConfigRogueResEndById.LogPair);
			return new RogueResEnd?(rootAsRogueResEnd);
		}

		// Token: 0x04003A86 RID: 14982
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003A87 RID: 14983
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003A88 RID: 14984
		private const string TABLE = "RogueResEnd";

		// Token: 0x04003A89 RID: 14985
		private const string COMMAND = "select BinData from `RogueResEnd` where Id=?";

		// Token: 0x04003A8A RID: 14986
		private const string KEY_PREFIX = "RogueResEndById";

		// Token: 0x04003A8B RID: 14987
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A8C RID: 14988
		private static int HandleId;
	}
}
