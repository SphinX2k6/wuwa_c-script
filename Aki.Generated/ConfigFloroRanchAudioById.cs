using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000323 RID: 803
	public class ConfigFloroRanchAudioById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012D7 RID: 4823 RVA: 0x000C796F File Offset: 0x000C5B6F
		static ConfigFloroRanchAudioById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchAudioById.CreateStaticDefaultValue), new Action(ConfigFloroRanchAudioById.ResetStaticDefaultValue));
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x000C7990 File Offset: 0x000C5B90
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchAudioById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchAudioById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchAudio"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchAudio` where Id=?")
			});
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x000C7A0F File Offset: 0x000C5C0F
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchAudioById.LogPair = null;
			ConfigFloroRanchAudioById.HandleId = 0;
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x000C7A1D File Offset: 0x000C5C1D
		public static void Init()
		{
			ConfigFloroRanchAudioById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchAudioById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchAudio` where Id=?");
		}

		// Token: 0x060012DB RID: 4827 RVA: 0x000C7A38 File Offset: 0x000C5C38
		public static FloroRanchAudio? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchAudioById.HandleId, ConfigFloroRanchAudioById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchAudioById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchAudio?(FloroRanchAudio.GetRootAsFloroRanchAudio(configBuffer));
				}
			}
			ConfigFloroRanchAudioById.LogPair.Clear();
			ConfigFloroRanchAudioById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchAudioById.HandleId, 1, p0Id, ConfigFloroRanchAudioById.LogPair) || ConfigCommon.Step(ConfigFloroRanchAudioById.HandleId, true, ConfigFloroRanchAudioById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchAudioById.HandleId, ConfigFloroRanchAudioById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchAudioById.HandleId, 0, ConfigFloroRanchAudioById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchAudioById.HandleId, ConfigFloroRanchAudioById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchAudio rootAsFloroRanchAudio = FloroRanchAudio.GetRootAsFloroRanchAudio(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchAudioById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchAudioById.HandleId, ConfigFloroRanchAudioById.LogPair);
			return new FloroRanchAudio?(rootAsFloroRanchAudio);
		}

		// Token: 0x040015D9 RID: 5593
		private const string DB = "db_flororanch.db";

		// Token: 0x040015DA RID: 5594
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015DB RID: 5595
		private const string TABLE = "FloroRanchAudio";

		// Token: 0x040015DC RID: 5596
		private const string COMMAND = "select BinData from `FloroRanchAudio` where Id=?";

		// Token: 0x040015DD RID: 5597
		private const string KEY_PREFIX = "FloroRanchAudioById";

		// Token: 0x040015DE RID: 5598
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015DF RID: 5599
		private static int HandleId;
	}
}
