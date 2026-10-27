using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E5 RID: 485
	public class ConfigDangoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B61 RID: 2913 RVA: 0x00099EFC File Offset: 0x000980FC
		static ConfigDangoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoById.CreateStaticDefaultValue), new Action(ConfigDangoById.ResetStaticDefaultValue));
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00099F1C File Offset: 0x0009811C
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dango.db"),
				new ValueTuple<string, object>("文件", "t.团子.xlsx"),
				new ValueTuple<string, object>("表名", "Dango"),
				new ValueTuple<string, object>("语句", "select BinData from `Dango` where Id=?")
			});
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00099F9B File Offset: 0x0009819B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoById.LogPair = null;
			ConfigDangoById.HandleId = 0;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00099FA9 File Offset: 0x000981A9
		public static void Init()
		{
			ConfigDangoById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoById.HandleId, "db_dango.db", "select BinData from `Dango` where Id=?");
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00099FC4 File Offset: 0x000981C4
		public static Dango? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoById.HandleId, ConfigDangoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Dango?(Dango.GetRootAsDango(configBuffer));
				}
			}
			ConfigDangoById.LogPair.Clear();
			ConfigDangoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDangoById.HandleId, 1, p0Id, ConfigDangoById.LogPair) || ConfigCommon.Step(ConfigDangoById.HandleId, true, ConfigDangoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDangoById.HandleId, ConfigDangoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoById.HandleId, 0, ConfigDangoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDangoById.HandleId, ConfigDangoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Dango rootAsDango = Dango.GetRootAsDango(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DangoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDangoById.HandleId, ConfigDangoById.LogPair);
			return new Dango?(rootAsDango);
		}

		// Token: 0x04000D27 RID: 3367
		private const string DB = "db_dango.db";

		// Token: 0x04000D28 RID: 3368
		private const string FILE = "t.团子.xlsx";

		// Token: 0x04000D29 RID: 3369
		private const string TABLE = "Dango";

		// Token: 0x04000D2A RID: 3370
		private const string COMMAND = "select BinData from `Dango` where Id=?";

		// Token: 0x04000D2B RID: 3371
		private const string KEY_PREFIX = "DangoById";

		// Token: 0x04000D2C RID: 3372
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D2D RID: 3373
		private static int HandleId;
	}
}
