using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A9 RID: 2473
	public class ConfigSlideById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A0A RID: 14858 RVA: 0x001A4EB8 File Offset: 0x001A30B8
		static ConfigSlideById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlideById.CreateStaticDefaultValue), new Action(ConfigSlideById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A0B RID: 14859 RVA: 0x001A4ED8 File Offset: 0x001A30D8
		public static void CreateStaticDefaultValue()
		{
			ConfigSlideById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSlideById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_slide.db"),
				new ValueTuple<string, object>("文件", "h.滑行.xlsx"),
				new ValueTuple<string, object>("表名", "Slide"),
				new ValueTuple<string, object>("语句", "select BinData from `Slide` where Id=?")
			});
		}

		// Token: 0x06003A0C RID: 14860 RVA: 0x001A4F57 File Offset: 0x001A3157
		public static void ResetStaticDefaultValue()
		{
			ConfigSlideById.LogPair = null;
			ConfigSlideById.HandleId = 0;
		}

		// Token: 0x06003A0D RID: 14861 RVA: 0x001A4F65 File Offset: 0x001A3165
		public static void Init()
		{
			ConfigSlideById.HandleId = ConfigCommon.InitDataStatement(ConfigSlideById.HandleId, "db_slide.db", "select BinData from `Slide` where Id=?");
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x001A4F80 File Offset: 0x001A3180
		public static Slide? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSlideById.HandleId, ConfigSlideById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("SlideById#" + p0Id);
				if (configBuffer != null)
				{
					return new Slide?(Slide.GetRootAsSlide(configBuffer));
				}
			}
			ConfigSlideById.LogPair.Clear();
			ConfigSlideById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigSlideById.HandleId, 1, p0Id, ConfigSlideById.LogPair) || ConfigCommon.Step(ConfigSlideById.HandleId, true, ConfigSlideById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSlideById.HandleId, ConfigSlideById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSlideById.HandleId, 0, ConfigSlideById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSlideById.HandleId, ConfigSlideById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Slide rootAsSlide = Slide.GetRootAsSlide(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("SlideById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSlideById.HandleId, ConfigSlideById.LogPair);
			return new Slide?(rootAsSlide);
		}

		// Token: 0x04004385 RID: 17285
		private const string DB = "db_slide.db";

		// Token: 0x04004386 RID: 17286
		private const string FILE = "h.滑行.xlsx";

		// Token: 0x04004387 RID: 17287
		private const string TABLE = "Slide";

		// Token: 0x04004388 RID: 17288
		private const string COMMAND = "select BinData from `Slide` where Id=?";

		// Token: 0x04004389 RID: 17289
		private const string KEY_PREFIX = "SlideById";

		// Token: 0x0400438A RID: 17290
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400438B RID: 17291
		private static int HandleId;
	}
}
