using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000965 RID: 2405
	public class ConfigSoundAreaPlayInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003872 RID: 14450 RVA: 0x00198ADB File Offset: 0x00196CDB
		static ConfigSoundAreaPlayInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSoundAreaPlayInfoById.CreateStaticDefaultValue), new Action(ConfigSoundAreaPlayInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x00198AFC File Offset: 0x00196CFC
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

		// Token: 0x06003874 RID: 14452 RVA: 0x00198B7B File Offset: 0x00196D7B
		public static void ResetStaticDefaultValue()
		{
			ConfigSoundAreaPlayInfoById.LogPair = null;
			ConfigSoundAreaPlayInfoById.HandleId = 0;
		}

		// Token: 0x06003875 RID: 14453 RVA: 0x00198B89 File Offset: 0x00196D89
		public static void Init()
		{
			ConfigSoundAreaPlayInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigSoundAreaPlayInfoById.HandleId, "db_soundareaplayinfo.db", "select BinData from `SoundAreaPlayInfo` where Id=?");
		}

		// Token: 0x06003876 RID: 14454 RVA: 0x00198BA4 File Offset: 0x00196DA4
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

		// Token: 0x040041A9 RID: 16809
		private const string DB = "db_soundareaplayinfo.db";

		// Token: 0x040041AA RID: 16810
		private const string FILE = "w.无音区玩法信息.xlsx";

		// Token: 0x040041AB RID: 16811
		private const string TABLE = "SoundAreaPlayInfo";

		// Token: 0x040041AC RID: 16812
		private const string COMMAND = "select BinData from `SoundAreaPlayInfo` where Id=?";

		// Token: 0x040041AD RID: 16813
		private const string KEY_PREFIX = "SoundAreaPlayInfoById";

		// Token: 0x040041AE RID: 16814
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041AF RID: 16815
		private static int HandleId;
	}
}
