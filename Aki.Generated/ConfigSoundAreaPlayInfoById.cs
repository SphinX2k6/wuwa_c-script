using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A3A RID: 2618
	public class ConfigSoundAreaPlayInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D70 RID: 15728 RVA: 0x001B7E6F File Offset: 0x001B606F
		static ConfigSoundAreaPlayInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSoundAreaPlayInfoById.CreateStaticDefaultValue), new Action(ConfigSoundAreaPlayInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x001B7E90 File Offset: 0x001B6090
		public static void CreateStaticDefaultValue()
		{
			ConfigSoundAreaPlayInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSoundAreaPlayInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_soundareaplayinfo.db"),
				new ValueTuple<string, object>("文件", "w.无音区玩法信息.xlsx"),
				new ValueTuple<string, object>("表名", "SoundAreaPlayInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `SoundAreaPlayInfo` where Id=?")
			});
		}

		// Token: 0x06003D72 RID: 15730 RVA: 0x001B7F0F File Offset: 0x001B610F
		public static void ResetStaticDefaultValue()
		{
			ConfigSoundAreaPlayInfoById.LogPair = null;
			ConfigSoundAreaPlayInfoById.HandleId = 0;
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x001B7F1D File Offset: 0x001B611D
		public static void Init()
		{
			ConfigSoundAreaPlayInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigSoundAreaPlayInfoById.HandleId, "db_soundareaplayinfo.db", "select BinData from `SoundAreaPlayInfo` where Id=?");
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x001B7F38 File Offset: 0x001B6138
		public static SoundAreaPlayInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSoundAreaPlayInfoById.HandleId, ConfigSoundAreaPlayInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SoundAreaPlayInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SoundAreaPlayInfo?(SoundAreaPlayInfo.GetRootAsSoundAreaPlayInfo(configBuffer));
				}
			}
			ConfigSoundAreaPlayInfoById.LogPair.Clear();
			ConfigSoundAreaPlayInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSoundAreaPlayInfoById.HandleId, 1, p0Id, ConfigSoundAreaPlayInfoById.LogPair) || ConfigCommon.Step(ConfigSoundAreaPlayInfoById.HandleId, true, ConfigSoundAreaPlayInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSoundAreaPlayInfoById.HandleId, ConfigSoundAreaPlayInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSoundAreaPlayInfoById.HandleId, 0, ConfigSoundAreaPlayInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSoundAreaPlayInfoById.HandleId, ConfigSoundAreaPlayInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SoundAreaPlayInfo rootAsSoundAreaPlayInfo = SoundAreaPlayInfo.GetRootAsSoundAreaPlayInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SoundAreaPlayInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSoundAreaPlayInfoById.HandleId, ConfigSoundAreaPlayInfoById.LogPair);
			return new SoundAreaPlayInfo?(rootAsSoundAreaPlayInfo);
		}

		// Token: 0x0400477C RID: 18300
		private const string DB = "db_soundareaplayinfo.db";

		// Token: 0x0400477D RID: 18301
		private const string FILE = "w.无音区玩法信息.xlsx";

		// Token: 0x0400477E RID: 18302
		private const string TABLE = "SoundAreaPlayInfo";

		// Token: 0x0400477F RID: 18303
		private const string COMMAND = "select BinData from `SoundAreaPlayInfo` where Id=?";

		// Token: 0x04004780 RID: 18304
		private const string KEY_PREFIX = "SoundAreaPlayInfoById";

		// Token: 0x04004781 RID: 18305
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004782 RID: 18306
		private static int HandleId;
	}
}
