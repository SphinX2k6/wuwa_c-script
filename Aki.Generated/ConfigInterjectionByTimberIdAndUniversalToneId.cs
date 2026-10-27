using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000452 RID: 1106
	public class ConfigInterjectionByTimberIdAndUniversalToneId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019F6 RID: 6646 RVA: 0x000EC379 File Offset: 0x000EA579
		static ConfigInterjectionByTimberIdAndUniversalToneId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInterjectionByTimberIdAndUniversalToneId.CreateStaticDefaultValue), new Action(ConfigInterjectionByTimberIdAndUniversalToneId.ResetStaticDefaultValue));
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x000EC398 File Offset: 0x000EA598
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

		// Token: 0x060019F8 RID: 6648 RVA: 0x000EC417 File Offset: 0x000EA617
		public static void ResetStaticDefaultValue()
		{
			ConfigInterjectionByTimberIdAndUniversalToneId.LogPair = null;
			ConfigInterjectionByTimberIdAndUniversalToneId.HandleId = 0;
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x000EC425 File Offset: 0x000EA625
		public static void Init()
		{
			ConfigInterjectionByTimberIdAndUniversalToneId.HandleId = ConfigCommon.InitDataStatement(ConfigInterjectionByTimberIdAndUniversalToneId.HandleId, "db_audio_interjection.db", "select BinData from `Interjection` where TimberId = ? AND UniversalToneId = ?");
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x000EC440 File Offset: 0x000EA640
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

		// Token: 0x04001E22 RID: 7714
		private const string DB = "db_audio_interjection.db";

		// Token: 0x04001E23 RID: 7715
		private const string FILE = "k.可视化编辑/c.Csv/y.音频/y.音色语音事件映射/*.csv*";

		// Token: 0x04001E24 RID: 7716
		private const string TABLE = "Interjection";

		// Token: 0x04001E25 RID: 7717
		private const string COMMAND = "select BinData from `Interjection` where TimberId = ? AND UniversalToneId = ?";

		// Token: 0x04001E26 RID: 7718
		private const string KEY_PREFIX = "InterjectionByTimberIdAndUniversalToneId";

		// Token: 0x04001E27 RID: 7719
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E28 RID: 7720
		private static int HandleId;
	}
}
