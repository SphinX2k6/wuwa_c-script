using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200094B RID: 2379
	public class ConfigSecondaryGuideDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037D5 RID: 14293 RVA: 0x0019826C File Offset: 0x0019646C
		static ConfigSecondaryGuideDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSecondaryGuideDataById.CreateStaticDefaultValue), new Action(ConfigSecondaryGuideDataById.ResetStaticDefaultValue));
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x0019828C File Offset: 0x0019648C
		public static void CreateStaticDefaultValue()
		{
			ConfigSecondaryGuideDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSecondaryGuideDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "SecondaryGuideData"),
				new ValueTuple<string, object>("语句", "select BinData from `SecondaryGuideData` where Id=?")
			});
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x0019830B File Offset: 0x0019650B
		public static void ResetStaticDefaultValue()
		{
			ConfigSecondaryGuideDataById.LogPair = null;
			ConfigSecondaryGuideDataById.HandleId = 0;
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x00198319 File Offset: 0x00196519
		public static void Init()
		{
			ConfigSecondaryGuideDataById.HandleId = ConfigCommon.InitDataStatement(ConfigSecondaryGuideDataById.HandleId, "db_adventure_detect.db", "select BinData from `SecondaryGuideData` where Id=?");
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x00198334 File Offset: 0x00196534
		public static SecondaryGuideData? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSecondaryGuideDataById.HandleId, ConfigSecondaryGuideDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SecondaryGuideDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SecondaryGuideData?(SecondaryGuideData.GetRootAsSecondaryGuideData(configBuffer));
				}
			}
			ConfigSecondaryGuideDataById.LogPair.Clear();
			ConfigSecondaryGuideDataById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSecondaryGuideDataById.HandleId, 1, p0Id, ConfigSecondaryGuideDataById.LogPair) || ConfigCommon.Step(ConfigSecondaryGuideDataById.HandleId, true, ConfigSecondaryGuideDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSecondaryGuideDataById.HandleId, ConfigSecondaryGuideDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSecondaryGuideDataById.HandleId, 0, ConfigSecondaryGuideDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSecondaryGuideDataById.HandleId, ConfigSecondaryGuideDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SecondaryGuideData rootAsSecondaryGuideData = SecondaryGuideData.GetRootAsSecondaryGuideData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SecondaryGuideDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSecondaryGuideDataById.HandleId, ConfigSecondaryGuideDataById.LogPair);
			return new SecondaryGuideData?(rootAsSecondaryGuideData);
		}

		// Token: 0x040040F3 RID: 16627
		private const string DB = "db_adventure_detect.db";

		// Token: 0x040040F4 RID: 16628
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x040040F5 RID: 16629
		private const string TABLE = "SecondaryGuideData";

		// Token: 0x040040F6 RID: 16630
		private const string COMMAND = "select BinData from `SecondaryGuideData` where Id=?";

		// Token: 0x040040F7 RID: 16631
		private const string KEY_PREFIX = "SecondaryGuideDataById";

		// Token: 0x040040F8 RID: 16632
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040F9 RID: 16633
		private static int HandleId;
	}
}
