using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200092E RID: 2350
	public class ConfigSilentAreaDetectionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003727 RID: 14119 RVA: 0x001912DF File Offset: 0x0018F4DF
		static ConfigSilentAreaDetectionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSilentAreaDetectionById.CreateStaticDefaultValue), new Action(ConfigSilentAreaDetectionById.ResetStaticDefaultValue));
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x00191300 File Offset: 0x0018F500
		public static void CreateStaticDefaultValue()
		{
			ConfigSilentAreaDetectionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSilentAreaDetectionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "SilentAreaDetection"),
				new ValueTuple<string, object>("语句", "select BinData from `SilentAreaDetection` where id=?")
			});
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x0019137F File Offset: 0x0018F57F
		public static void ResetStaticDefaultValue()
		{
			ConfigSilentAreaDetectionById.LogPair = null;
			ConfigSilentAreaDetectionById.HandleId = 0;
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x0019138D File Offset: 0x0018F58D
		public static void Init()
		{
			ConfigSilentAreaDetectionById.HandleId = ConfigCommon.InitDataStatement(ConfigSilentAreaDetectionById.HandleId, "db_adventure_detect.db", "select BinData from `SilentAreaDetection` where id=?");
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x001913A8 File Offset: 0x0018F5A8
		public static SilentAreaDetection? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSilentAreaDetectionById.HandleId, ConfigSilentAreaDetectionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SilentAreaDetectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SilentAreaDetection?(SilentAreaDetection.GetRootAsSilentAreaDetection(configBuffer));
				}
			}
			ConfigSilentAreaDetectionById.LogPair.Clear();
			ConfigSilentAreaDetectionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSilentAreaDetectionById.HandleId, 1, p0Id, ConfigSilentAreaDetectionById.LogPair) || ConfigCommon.Step(ConfigSilentAreaDetectionById.HandleId, true, ConfigSilentAreaDetectionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSilentAreaDetectionById.HandleId, ConfigSilentAreaDetectionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSilentAreaDetectionById.HandleId, 0, ConfigSilentAreaDetectionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSilentAreaDetectionById.HandleId, ConfigSilentAreaDetectionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SilentAreaDetection rootAsSilentAreaDetection = SilentAreaDetection.GetRootAsSilentAreaDetection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SilentAreaDetectionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSilentAreaDetectionById.HandleId, ConfigSilentAreaDetectionById.LogPair);
			return new SilentAreaDetection?(rootAsSilentAreaDetection);
		}

		// Token: 0x04004028 RID: 16424
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04004029 RID: 16425
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x0400402A RID: 16426
		private const string TABLE = "SilentAreaDetection";

		// Token: 0x0400402B RID: 16427
		private const string COMMAND = "select BinData from `SilentAreaDetection` where id=?";

		// Token: 0x0400402C RID: 16428
		private const string KEY_PREFIX = "SilentAreaDetectionById";

		// Token: 0x0400402D RID: 16429
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400402E RID: 16430
		private static int HandleId;
	}
}
