using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A5A RID: 2650
	public class ConfigTuningNodeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E30 RID: 15920 RVA: 0x001B990F File Offset: 0x001B7B0F
		static ConfigTuningNodeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTuningNodeById.CreateStaticDefaultValue), new Action(ConfigTuningNodeById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x001B9930 File Offset: 0x001B7B30
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

		// Token: 0x06003E32 RID: 15922 RVA: 0x001B99AF File Offset: 0x001B7BAF
		public static void ResetStaticDefaultValue()
		{
			ConfigTuningNodeById.LogPair = null;
			ConfigTuningNodeById.HandleId = 0;
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x001B99BD File Offset: 0x001B7BBD
		public static void Init()
		{
			ConfigTuningNodeById.HandleId = ConfigCommon.InitDataStatement(ConfigTuningNodeById.HandleId, "db_tuningnode.db", "select BinData from `TuningNode` where Id=?");
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x001B99D8 File Offset: 0x001B7BD8
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

		// Token: 0x0400485C RID: 18524
		private const string DB = "db_tuningnode.db";

		// Token: 0x0400485D RID: 18525
		private const string FILE = "k.可视化编辑/c.Csv/t.调律台音符/*.csv*";

		// Token: 0x0400485E RID: 18526
		private const string TABLE = "TuningNode";

		// Token: 0x0400485F RID: 18527
		private const string COMMAND = "select BinData from `TuningNode` where Id=?";

		// Token: 0x04004860 RID: 18528
		private const string KEY_PREFIX = "TuningNodeById";

		// Token: 0x04004861 RID: 18529
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004862 RID: 18530
		private static int HandleId;
	}
}
