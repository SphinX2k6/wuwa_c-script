using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200096D RID: 2413
	public class ConfigSpecialHateAndSenseById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038A2 RID: 14498 RVA: 0x00199C6D File Offset: 0x00197E6D
		static ConfigSpecialHateAndSenseById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpecialHateAndSenseById.CreateStaticDefaultValue), new Action(ConfigSpecialHateAndSenseById.ResetStaticDefaultValue));
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x00199C8C File Offset: 0x00197E8C
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

		// Token: 0x060038A4 RID: 14500 RVA: 0x00199D0B File Offset: 0x00197F0B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpecialHateAndSenseById.LogPair = null;
			ConfigSpecialHateAndSenseById.HandleId = 0;
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x00199D19 File Offset: 0x00197F19
		public static void Init()
		{
			ConfigSpecialHateAndSenseById.HandleId = ConfigCommon.InitDataStatement(ConfigSpecialHateAndSenseById.HandleId, "db_specialhateandsense.db", "select BinData from `SpecialHateAndSense` where id=?");
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x00199D34 File Offset: 0x00197F34
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

		// Token: 0x040041E1 RID: 16865
		private const string DB = "db_specialhateandsense.db";

		// Token: 0x040041E2 RID: 16866
		private const string FILE = "k.可视化编辑/c.Csv/t.特殊仇恨感知/*.csv*";

		// Token: 0x040041E3 RID: 16867
		private const string TABLE = "SpecialHateAndSense";

		// Token: 0x040041E4 RID: 16868
		private const string COMMAND = "select BinData from `SpecialHateAndSense` where id=?";

		// Token: 0x040041E5 RID: 16869
		private const string KEY_PREFIX = "SpecialHateAndSenseById";

		// Token: 0x040041E6 RID: 16870
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041E7 RID: 16871
		private static int HandleId;
	}
}
