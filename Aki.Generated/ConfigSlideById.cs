using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200095E RID: 2398
	public class ConfigSlideById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003848 RID: 14408 RVA: 0x00197C98 File Offset: 0x00195E98
		static ConfigSlideById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSlideById.CreateStaticDefaultValue), new Action(ConfigSlideById.ResetStaticDefaultValue));
		}

		// Token: 0x06003849 RID: 14409 RVA: 0x00197CB8 File Offset: 0x00195EB8
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

		// Token: 0x0600384A RID: 14410 RVA: 0x00197D37 File Offset: 0x00195F37
		public static void ResetStaticDefaultValue()
		{
			ConfigSlideById.LogPair = null;
			ConfigSlideById.HandleId = 0;
		}

		// Token: 0x0600384B RID: 14411 RVA: 0x00197D45 File Offset: 0x00195F45
		public static void Init()
		{
			ConfigSlideById.HandleId = ConfigCommon.InitDataStatement(ConfigSlideById.HandleId, "db_slide.db", "select BinData from `Slide` where Id=?");
		}

		// Token: 0x0600384C RID: 14412 RVA: 0x00197D60 File Offset: 0x00195F60
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

		// Token: 0x04004178 RID: 16760
		private const string DB = "db_slide.db";

		// Token: 0x04004179 RID: 16761
		private const string FILE = "h.滑行.xlsx";

		// Token: 0x0400417A RID: 16762
		private const string TABLE = "Slide";

		// Token: 0x0400417B RID: 16763
		private const string COMMAND = "select BinData from `Slide` where Id=?";

		// Token: 0x0400417C RID: 16764
		private const string KEY_PREFIX = "SlideById";

		// Token: 0x0400417D RID: 16765
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400417E RID: 16766
		private static int HandleId;
	}
}
