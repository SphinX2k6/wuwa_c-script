using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200014B RID: 331
	public class ConfigCalabashTransformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007C3 RID: 1987 RVA: 0x00089204 File Offset: 0x00087404
		static ConfigCalabashTransformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashTransformById.CreateStaticDefaultValue), new Action(ConfigCalabashTransformById.ResetStaticDefaultValue));
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00089224 File Offset: 0x00087424
		public static void CreateStaticDefaultValue()
		{
			ConfigCalabashTransformById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCalabashTransformById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "CalabashTransform"),
				new ValueTuple<string, object>("语句", "select BinData from `CalabashTransform` where Id=?")
			});
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x000892A3 File Offset: 0x000874A3
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashTransformById.LogPair = null;
			ConfigCalabashTransformById.HandleId = 0;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x000892B1 File Offset: 0x000874B1
		public static void Init()
		{
			ConfigCalabashTransformById.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashTransformById.HandleId, "db_calabash.db", "select BinData from `CalabashTransform` where Id=?");
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x000892CC File Offset: 0x000874CC
		public static CalabashTransform? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCalabashTransformById.HandleId, ConfigCalabashTransformById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashTransformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CalabashTransform?(CalabashTransform.GetRootAsCalabashTransform(configBuffer));
				}
			}
			ConfigCalabashTransformById.LogPair.Clear();
			ConfigCalabashTransformById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCalabashTransformById.HandleId, 1, p0Id, ConfigCalabashTransformById.LogPair) || ConfigCommon.Step(ConfigCalabashTransformById.HandleId, true, ConfigCalabashTransformById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCalabashTransformById.HandleId, ConfigCalabashTransformById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCalabashTransformById.HandleId, 0, ConfigCalabashTransformById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCalabashTransformById.HandleId, ConfigCalabashTransformById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CalabashTransform rootAsCalabashTransform = CalabashTransform.GetRootAsCalabashTransform(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashTransformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCalabashTransformById.HandleId, ConfigCalabashTransformById.LogPair);
			return new CalabashTransform?(rootAsCalabashTransform);
		}

		// Token: 0x040008F1 RID: 2289
		private const string DB = "db_calabash.db";

		// Token: 0x040008F2 RID: 2290
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x040008F3 RID: 2291
		private const string TABLE = "CalabashTransform";

		// Token: 0x040008F4 RID: 2292
		private const string COMMAND = "select BinData from `CalabashTransform` where Id=?";

		// Token: 0x040008F5 RID: 2293
		private const string KEY_PREFIX = "CalabashTransformById";

		// Token: 0x040008F6 RID: 2294
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008F7 RID: 2295
		private static int HandleId;
	}
}
