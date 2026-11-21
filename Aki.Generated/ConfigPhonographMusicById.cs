using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006DD RID: 1757
	public class ConfigPhonographMusicById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600293E RID: 10558 RVA: 0x00146243 File Offset: 0x00144443
		static ConfigPhonographMusicById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhonographMusicById.CreateStaticDefaultValue), new Action(ConfigPhonographMusicById.ResetStaticDefaultValue));
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x00146264 File Offset: 0x00144464
		public static void CreateStaticDefaultValue()
		{
			ConfigPhonographMusicById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhonographMusicById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonograph.db"),
				new ValueTuple<string, object>("文件", "l.留声机.xlsx"),
				new ValueTuple<string, object>("表名", "PhonographMusic"),
				new ValueTuple<string, object>("语句", "select BinData from `PhonographMusic` where Id=?")
			});
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x001462E3 File Offset: 0x001444E3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhonographMusicById.LogPair = null;
			ConfigPhonographMusicById.HandleId = 0;
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x001462F1 File Offset: 0x001444F1
		public static void Init()
		{
			ConfigPhonographMusicById.HandleId = ConfigCommon.InitDataStatement(ConfigPhonographMusicById.HandleId, "db_phonograph.db", "select BinData from `PhonographMusic` where Id=?");
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x0014630C File Offset: 0x0014450C
		public static PhonographMusic? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhonographMusicById.HandleId, ConfigPhonographMusicById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhonographMusicById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhonographMusic?(PhonographMusic.GetRootAsPhonographMusic(configBuffer));
				}
			}
			ConfigPhonographMusicById.LogPair.Clear();
			ConfigPhonographMusicById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhonographMusicById.HandleId, 1, p0Id, ConfigPhonographMusicById.LogPair) || ConfigCommon.Step(ConfigPhonographMusicById.HandleId, true, ConfigPhonographMusicById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhonographMusicById.HandleId, ConfigPhonographMusicById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhonographMusicById.HandleId, 0, ConfigPhonographMusicById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhonographMusicById.HandleId, ConfigPhonographMusicById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhonographMusic rootAsPhonographMusic = PhonographMusic.GetRootAsPhonographMusic(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhonographMusicById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhonographMusicById.HandleId, ConfigPhonographMusicById.LogPair);
			return new PhonographMusic?(rootAsPhonographMusic);
		}

		// Token: 0x04002FF1 RID: 12273
		private const string DB = "db_phonograph.db";

		// Token: 0x04002FF2 RID: 12274
		private const string FILE = "l.留声机.xlsx";

		// Token: 0x04002FF3 RID: 12275
		private const string TABLE = "PhonographMusic";

		// Token: 0x04002FF4 RID: 12276
		private const string COMMAND = "select BinData from `PhonographMusic` where Id=?";

		// Token: 0x04002FF5 RID: 12277
		private const string KEY_PREFIX = "PhonographMusicById";

		// Token: 0x04002FF6 RID: 12278
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FF7 RID: 12279
		private static int HandleId;
	}
}
