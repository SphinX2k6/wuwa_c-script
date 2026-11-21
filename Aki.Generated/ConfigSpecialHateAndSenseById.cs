using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A42 RID: 2626
	public class ConfigSpecialHateAndSenseById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DA0 RID: 15776 RVA: 0x001B9001 File Offset: 0x001B7201
		static ConfigSpecialHateAndSenseById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpecialHateAndSenseById.CreateStaticDefaultValue), new Action(ConfigSpecialHateAndSenseById.ResetStaticDefaultValue));
		}

		// Token: 0x06003DA1 RID: 15777 RVA: 0x001B9020 File Offset: 0x001B7220
		public static void CreateStaticDefaultValue()
		{
			ConfigSpecialHateAndSenseById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpecialHateAndSenseById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_specialhateandsense.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/t.特殊仇恨感知/*.csv*"),
				new ValueTuple<string, object>("表名", "SpecialHateAndSense"),
				new ValueTuple<string, object>("语句", "select BinData from `SpecialHateAndSense` where id=?")
			});
		}

		// Token: 0x06003DA2 RID: 15778 RVA: 0x001B909F File Offset: 0x001B729F
		public static void ResetStaticDefaultValue()
		{
			ConfigSpecialHateAndSenseById.LogPair = null;
			ConfigSpecialHateAndSenseById.HandleId = 0;
		}

		// Token: 0x06003DA3 RID: 15779 RVA: 0x001B90AD File Offset: 0x001B72AD
		public static void Init()
		{
			ConfigSpecialHateAndSenseById.HandleId = ConfigCommon.InitDataStatement(ConfigSpecialHateAndSenseById.HandleId, "db_specialhateandsense.db", "select BinData from `SpecialHateAndSense` where id=?");
		}

		// Token: 0x06003DA4 RID: 15780 RVA: 0x001B90C8 File Offset: 0x001B72C8
		public static SpecialHateAndSense? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpecialHateAndSenseById.HandleId, ConfigSpecialHateAndSenseById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpecialHateAndSenseById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SpecialHateAndSense?(SpecialHateAndSense.GetRootAsSpecialHateAndSense(configBuffer));
				}
			}
			ConfigSpecialHateAndSenseById.LogPair.Clear();
			ConfigSpecialHateAndSenseById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSpecialHateAndSenseById.HandleId, 1, p0Id, ConfigSpecialHateAndSenseById.LogPair) || ConfigCommon.Step(ConfigSpecialHateAndSenseById.HandleId, true, ConfigSpecialHateAndSenseById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSpecialHateAndSenseById.HandleId, ConfigSpecialHateAndSenseById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpecialHateAndSenseById.HandleId, 0, ConfigSpecialHateAndSenseById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSpecialHateAndSenseById.HandleId, ConfigSpecialHateAndSenseById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SpecialHateAndSense rootAsSpecialHateAndSense = SpecialHateAndSense.GetRootAsSpecialHateAndSense(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SpecialHateAndSenseById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSpecialHateAndSenseById.HandleId, ConfigSpecialHateAndSenseById.LogPair);
			return new SpecialHateAndSense?(rootAsSpecialHateAndSense);
		}

		// Token: 0x040047B4 RID: 18356
		private const string DB = "db_specialhateandsense.db";

		// Token: 0x040047B5 RID: 18357
		private const string FILE = "k.可视化编辑/c.Csv/t.特殊仇恨感知/*.csv*";

		// Token: 0x040047B6 RID: 18358
		private const string TABLE = "SpecialHateAndSense";

		// Token: 0x040047B7 RID: 18359
		private const string COMMAND = "select BinData from `SpecialHateAndSense` where id=?";

		// Token: 0x040047B8 RID: 18360
		private const string KEY_PREFIX = "SpecialHateAndSenseById";

		// Token: 0x040047B9 RID: 18361
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047BA RID: 18362
		private static int HandleId;
	}
}
