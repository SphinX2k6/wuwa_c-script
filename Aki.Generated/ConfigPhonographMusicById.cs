using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C5 RID: 1733
	public class ConfigPhonographMusicById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028AE RID: 10414 RVA: 0x0013F7C7 File Offset: 0x0013D9C7
		static ConfigPhonographMusicById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhonographMusicById.CreateStaticDefaultValue), new Action(ConfigPhonographMusicById.ResetStaticDefaultValue));
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x0013F7E8 File Offset: 0x0013D9E8
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

		// Token: 0x060028B0 RID: 10416 RVA: 0x0013F867 File Offset: 0x0013DA67
		public static void ResetStaticDefaultValue()
		{
			ConfigPhonographMusicById.LogPair = null;
			ConfigPhonographMusicById.HandleId = 0;
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x0013F875 File Offset: 0x0013DA75
		public static void Init()
		{
			ConfigPhonographMusicById.HandleId = ConfigCommon.InitDataStatement(ConfigPhonographMusicById.HandleId, "db_phonograph.db", "select BinData from `PhonographMusic` where Id=?");
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x0013F890 File Offset: 0x0013DA90
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

		// Token: 0x04002F49 RID: 12105
		private const string DB = "db_phonograph.db";

		// Token: 0x04002F4A RID: 12106
		private const string FILE = "l.留声机.xlsx";

		// Token: 0x04002F4B RID: 12107
		private const string TABLE = "PhonographMusic";

		// Token: 0x04002F4C RID: 12108
		private const string COMMAND = "select BinData from `PhonographMusic` where Id=?";

		// Token: 0x04002F4D RID: 12109
		private const string KEY_PREFIX = "PhonographMusicById";

		// Token: 0x04002F4E RID: 12110
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F4F RID: 12111
		private static int HandleId;
	}
}
