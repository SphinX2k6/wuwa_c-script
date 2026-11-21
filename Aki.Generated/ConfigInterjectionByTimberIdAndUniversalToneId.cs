using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000468 RID: 1128
	public class ConfigInterjectionByTimberIdAndUniversalToneId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A7A RID: 6778 RVA: 0x000F2ACD File Offset: 0x000F0CCD
		static ConfigInterjectionByTimberIdAndUniversalToneId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInterjectionByTimberIdAndUniversalToneId.CreateStaticDefaultValue), new Action(ConfigInterjectionByTimberIdAndUniversalToneId.ResetStaticDefaultValue));
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x000F2AEC File Offset: 0x000F0CEC
		public static void CreateStaticDefaultValue()
		{
			ConfigInterjectionByTimberIdAndUniversalToneId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInterjectionByTimberIdAndUniversalToneId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_audio_interjection.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/y.音频/y.音色语音事件映射/*.csv*"),
				new ValueTuple<string, object>("表名", "Interjection"),
				new ValueTuple<string, object>("语句", "select BinData from `Interjection` where TimberId = ? AND UniversalToneId = ?")
			});
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x000F2B6B File Offset: 0x000F0D6B
		public static void ResetStaticDefaultValue()
		{
			ConfigInterjectionByTimberIdAndUniversalToneId.LogPair = null;
			ConfigInterjectionByTimberIdAndUniversalToneId.HandleId = 0;
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x000F2B79 File Offset: 0x000F0D79
		public static void Init()
		{
			ConfigInterjectionByTimberIdAndUniversalToneId.HandleId = ConfigCommon.InitDataStatement(ConfigInterjectionByTimberIdAndUniversalToneId.HandleId, "db_audio_interjection.db", "select BinData from `Interjection` where TimberId = ? AND UniversalToneId = ?");
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x000F2B94 File Offset: 0x000F0D94
		public static Interjection? GetConfig(int p0TimberId, int p1UniversalToneId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInterjectionByTimberIdAndUniversalToneId.HandleId, ConfigInterjectionByTimberIdAndUniversalToneId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("InterjectionByTimberIdAndUniversalToneId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TimberId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1UniversalToneId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Interjection?(Interjection.GetRootAsInterjection(configBuffer));
				}
			}
			ConfigInterjectionByTimberIdAndUniversalToneId.LogPair.Clear();
			ConfigInterjectionByTimberIdAndUniversalToneId.LogPair.Add(new ValueTuple<string, object>("TimberId", p0TimberId));
			ConfigInterjectionByTimberIdAndUniversalToneId.LogPair.Add(new ValueTuple<string, object>("UniversalToneId", p1UniversalToneId));
			if (!ConfigCommon.BindInt(ConfigInterjectionByTimberIdAndUniversalToneId.HandleId, 1, p0TimberId, ConfigInterjectionByTimberIdAndUniversalToneId.LogPair) || !ConfigCommon.BindInt(ConfigInterjectionByTimberIdAndUniversalToneId.HandleId, 2, p1UniversalToneId, ConfigInterjectionByTimberIdAndUniversalToneId.LogPair) || ConfigCommon.Step(ConfigInterjectionByTimberIdAndUniversalToneId.HandleId, true, ConfigInterjectionByTimberIdAndUniversalToneId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInterjectionByTimberIdAndUniversalToneId.HandleId, ConfigInterjectionByTimberIdAndUniversalToneId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInterjectionByTimberIdAndUniversalToneId.HandleId, 0, ConfigInterjectionByTimberIdAndUniversalToneId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInterjectionByTimberIdAndUniversalToneId.HandleId, ConfigInterjectionByTimberIdAndUniversalToneId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Interjection rootAsInterjection = Interjection.GetRootAsInterjection(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("InterjectionByTimberIdAndUniversalToneId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TimberId);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1UniversalToneId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInterjectionByTimberIdAndUniversalToneId.HandleId, ConfigInterjectionByTimberIdAndUniversalToneId.LogPair);
			return new Interjection?(rootAsInterjection);
		}

		// Token: 0x04001EBC RID: 7868
		private const string DB = "db_audio_interjection.db";

		// Token: 0x04001EBD RID: 7869
		private const string FILE = "k.可视化编辑/c.Csv/y.音频/y.音色语音事件映射/*.csv*";

		// Token: 0x04001EBE RID: 7870
		private const string TABLE = "Interjection";

		// Token: 0x04001EBF RID: 7871
		private const string COMMAND = "select BinData from `Interjection` where TimberId = ? AND UniversalToneId = ?";

		// Token: 0x04001EC0 RID: 7872
		private const string KEY_PREFIX = "InterjectionByTimberIdAndUniversalToneId";

		// Token: 0x04001EC1 RID: 7873
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EC2 RID: 7874
		private static int HandleId;
	}
}
