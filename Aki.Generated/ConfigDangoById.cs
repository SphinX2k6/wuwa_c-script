using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001F7 RID: 503
	public class ConfigDangoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BCD RID: 3021 RVA: 0x0009FE34 File Offset: 0x0009E034
		static ConfigDangoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoById.CreateStaticDefaultValue), new Action(ConfigDangoById.ResetStaticDefaultValue));
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0009FE54 File Offset: 0x0009E054
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

		// Token: 0x06000BCF RID: 3023 RVA: 0x0009FED3 File Offset: 0x0009E0D3
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoById.LogPair = null;
			ConfigDangoById.HandleId = 0;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0009FEE1 File Offset: 0x0009E0E1
		public static void Init()
		{
			ConfigDangoById.HandleId = ConfigCommon.InitDataStatement(ConfigDangoById.HandleId, "db_dango.db", "select BinData from `Dango` where Id=?");
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0009FEFC File Offset: 0x0009E0FC
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

		// Token: 0x04000DA5 RID: 3493
		private const string DB = "db_dango.db";

		// Token: 0x04000DA6 RID: 3494
		private const string FILE = "t.团子.xlsx";

		// Token: 0x04000DA7 RID: 3495
		private const string TABLE = "Dango";

		// Token: 0x04000DA8 RID: 3496
		private const string COMMAND = "select BinData from `Dango` where Id=?";

		// Token: 0x04000DA9 RID: 3497
		private const string KEY_PREFIX = "DangoById";

		// Token: 0x04000DAA RID: 3498
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DAB RID: 3499
		private static int HandleId;
	}
}
