using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006DB RID: 1755
	public class ConfigPhonographAlbumById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002932 RID: 10546 RVA: 0x00145E67 File Offset: 0x00144067
		static ConfigPhonographAlbumById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhonographAlbumById.CreateStaticDefaultValue), new Action(ConfigPhonographAlbumById.ResetStaticDefaultValue));
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x00145E88 File Offset: 0x00144088
		public static void CreateStaticDefaultValue()
		{
			ConfigPhonographAlbumById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhonographAlbumById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonograph.db"),
				new ValueTuple<string, object>("文件", "l.留声机.xlsx"),
				new ValueTuple<string, object>("表名", "PhonographAlbum"),
				new ValueTuple<string, object>("语句", "select BinData from `PhonographAlbum` where Id=?")
			});
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x00145F07 File Offset: 0x00144107
		public static void ResetStaticDefaultValue()
		{
			ConfigPhonographAlbumById.LogPair = null;
			ConfigPhonographAlbumById.HandleId = 0;
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x00145F15 File Offset: 0x00144115
		public static void Init()
		{
			ConfigPhonographAlbumById.HandleId = ConfigCommon.InitDataStatement(ConfigPhonographAlbumById.HandleId, "db_phonograph.db", "select BinData from `PhonographAlbum` where Id=?");
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x00145F30 File Offset: 0x00144130
		public static PhonographAlbum? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhonographAlbumById.HandleId, ConfigPhonographAlbumById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhonographAlbumById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhonographAlbum?(PhonographAlbum.GetRootAsPhonographAlbum(configBuffer));
				}
			}
			ConfigPhonographAlbumById.LogPair.Clear();
			ConfigPhonographAlbumById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhonographAlbumById.HandleId, 1, p0Id, ConfigPhonographAlbumById.LogPair) || ConfigCommon.Step(ConfigPhonographAlbumById.HandleId, true, ConfigPhonographAlbumById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhonographAlbumById.HandleId, ConfigPhonographAlbumById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhonographAlbumById.HandleId, 0, ConfigPhonographAlbumById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhonographAlbumById.HandleId, ConfigPhonographAlbumById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhonographAlbum rootAsPhonographAlbum = PhonographAlbum.GetRootAsPhonographAlbum(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhonographAlbumById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhonographAlbumById.HandleId, ConfigPhonographAlbumById.LogPair);
			return new PhonographAlbum?(rootAsPhonographAlbum);
		}

		// Token: 0x04002FE3 RID: 12259
		private const string DB = "db_phonograph.db";

		// Token: 0x04002FE4 RID: 12260
		private const string FILE = "l.留声机.xlsx";

		// Token: 0x04002FE5 RID: 12261
		private const string TABLE = "PhonographAlbum";

		// Token: 0x04002FE6 RID: 12262
		private const string COMMAND = "select BinData from `PhonographAlbum` where Id=?";

		// Token: 0x04002FE7 RID: 12263
		private const string KEY_PREFIX = "PhonographAlbumById";

		// Token: 0x04002FE8 RID: 12264
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FE9 RID: 12265
		private static int HandleId;
	}
}
