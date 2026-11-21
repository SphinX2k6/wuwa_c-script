using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B2F RID: 2863
	public class ConfigTuningNodeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600432E RID: 17198 RVA: 0x001D8CA3 File Offset: 0x001D6EA3
		static ConfigTuningNodeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTuningNodeById.CreateStaticDefaultValue), new Action(ConfigTuningNodeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x001D8CC4 File Offset: 0x001D6EC4
		public static void CreateStaticDefaultValue()
		{
			ConfigTuningNodeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTuningNodeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_tuningnode.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/t.调律台音符/*.csv*"),
				new ValueTuple<string, object>("表名", "TuningNode"),
				new ValueTuple<string, object>("语句", "select BinData from `TuningNode` where Id=?")
			});
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x001D8D43 File Offset: 0x001D6F43
		public static void ResetStaticDefaultValue()
		{
			ConfigTuningNodeById.LogPair = null;
			ConfigTuningNodeById.HandleId = 0;
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x001D8D51 File Offset: 0x001D6F51
		public static void Init()
		{
			ConfigTuningNodeById.HandleId = ConfigCommon.InitDataStatement(ConfigTuningNodeById.HandleId, "db_tuningnode.db", "select BinData from `TuningNode` where Id=?");
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x001D8D6C File Offset: 0x001D6F6C
		public static TuningNode? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTuningNodeById.HandleId, ConfigTuningNodeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TuningNodeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TuningNode?(TuningNode.GetRootAsTuningNode(configBuffer));
				}
			}
			ConfigTuningNodeById.LogPair.Clear();
			ConfigTuningNodeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTuningNodeById.HandleId, 1, p0Id, ConfigTuningNodeById.LogPair) || ConfigCommon.Step(ConfigTuningNodeById.HandleId, true, ConfigTuningNodeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTuningNodeById.HandleId, ConfigTuningNodeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTuningNodeById.HandleId, 0, ConfigTuningNodeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTuningNodeById.HandleId, ConfigTuningNodeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TuningNode rootAsTuningNode = TuningNode.GetRootAsTuningNode(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TuningNodeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTuningNodeById.HandleId, ConfigTuningNodeById.LogPair);
			return new TuningNode?(rootAsTuningNode);
		}

		// Token: 0x04004E2F RID: 20015
		private const string DB = "db_tuningnode.db";

		// Token: 0x04004E30 RID: 20016
		private const string FILE = "k.可视化编辑/c.Csv/t.调律台音符/*.csv*";

		// Token: 0x04004E31 RID: 20017
		private const string TABLE = "TuningNode";

		// Token: 0x04004E32 RID: 20018
		private const string COMMAND = "select BinData from `TuningNode` where Id=?";

		// Token: 0x04004E33 RID: 20019
		private const string KEY_PREFIX = "TuningNodeById";

		// Token: 0x04004E34 RID: 20020
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E35 RID: 20021
		private static int HandleId;
	}
}
