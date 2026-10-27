using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C3 RID: 1731
	public class ConfigPhonographAlbumById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028A2 RID: 10402 RVA: 0x0013F3EB File Offset: 0x0013D5EB
		static ConfigPhonographAlbumById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhonographAlbumById.CreateStaticDefaultValue), new Action(ConfigPhonographAlbumById.ResetStaticDefaultValue));
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x0013F40C File Offset: 0x0013D60C
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

		// Token: 0x060028A4 RID: 10404 RVA: 0x0013F48B File Offset: 0x0013D68B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhonographAlbumById.LogPair = null;
			ConfigPhonographAlbumById.HandleId = 0;
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x0013F499 File Offset: 0x0013D699
		public static void Init()
		{
			ConfigPhonographAlbumById.HandleId = ConfigCommon.InitDataStatement(ConfigPhonographAlbumById.HandleId, "db_phonograph.db", "select BinData from `PhonographAlbum` where Id=?");
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x0013F4B4 File Offset: 0x0013D6B4
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

		// Token: 0x04002F3B RID: 12091
		private const string DB = "db_phonograph.db";

		// Token: 0x04002F3C RID: 12092
		private const string FILE = "l.留声机.xlsx";

		// Token: 0x04002F3D RID: 12093
		private const string TABLE = "PhonographAlbum";

		// Token: 0x04002F3E RID: 12094
		private const string COMMAND = "select BinData from `PhonographAlbum` where Id=?";

		// Token: 0x04002F3F RID: 12095
		private const string KEY_PREFIX = "PhonographAlbumById";

		// Token: 0x04002F40 RID: 12096
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F41 RID: 12097
		private static int HandleId;
	}
}
