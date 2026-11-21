using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003CE RID: 974
	public class ConfigGuideDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016DB RID: 5851 RVA: 0x000DE4A8 File Offset: 0x000DC6A8
		static ConfigGuideDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuideDataById.CreateStaticDefaultValue), new Action(ConfigGuideDataById.ResetStaticDefaultValue));
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x000DE4C8 File Offset: 0x000DC6C8
		public static void CreateStaticDefaultValue()
		{
			ConfigGuideDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuideDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "GuideData"),
				new ValueTuple<string, object>("语句", "select BinData from `GuideData` where Id=?")
			});
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x000DE547 File Offset: 0x000DC747
		public static void ResetStaticDefaultValue()
		{
			ConfigGuideDataById.LogPair = null;
			ConfigGuideDataById.HandleId = 0;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x000DE555 File Offset: 0x000DC755
		public static void Init()
		{
			ConfigGuideDataById.HandleId = ConfigCommon.InitDataStatement(ConfigGuideDataById.HandleId, "db_adventure_detect.db", "select BinData from `GuideData` where Id=?");
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x000DE570 File Offset: 0x000DC770
		public static GuideData? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuideDataById.HandleId, ConfigGuideDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuideData?(GuideData.GetRootAsGuideData(configBuffer));
				}
			}
			ConfigGuideDataById.LogPair.Clear();
			ConfigGuideDataById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGuideDataById.HandleId, 1, p0Id, ConfigGuideDataById.LogPair) || ConfigCommon.Step(ConfigGuideDataById.HandleId, true, ConfigGuideDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuideDataById.HandleId, ConfigGuideDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuideDataById.HandleId, 0, ConfigGuideDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuideDataById.HandleId, ConfigGuideDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuideData rootAsGuideData = GuideData.GetRootAsGuideData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuideDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuideDataById.HandleId, ConfigGuideDataById.LogPair);
			return new GuideData?(rootAsGuideData);
		}

		// Token: 0x04001A86 RID: 6790
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04001A87 RID: 6791
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04001A88 RID: 6792
		private const string TABLE = "GuideData";

		// Token: 0x04001A89 RID: 6793
		private const string COMMAND = "select BinData from `GuideData` where Id=?";

		// Token: 0x04001A8A RID: 6794
		private const string KEY_PREFIX = "GuideDataById";

		// Token: 0x04001A8B RID: 6795
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A8C RID: 6796
		private static int HandleId;
	}
}
