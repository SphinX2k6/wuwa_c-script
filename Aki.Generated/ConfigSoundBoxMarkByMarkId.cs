using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000966 RID: 2406
	public class ConfigSoundBoxMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003878 RID: 14456 RVA: 0x00198D24 File Offset: 0x00196F24
		static ConfigSoundBoxMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSoundBoxMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigSoundBoxMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06003879 RID: 14457 RVA: 0x00198D44 File Offset: 0x00196F44
		public static void CreateStaticDefaultValue()
		{
			ConfigSoundBoxMarkByMarkId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSoundBoxMarkByMarkId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "SoundBoxMark"),
				new ValueTuple<string, object>("语句", "select BinData from `SoundBoxMark` where MarkId=?")
			});
		}

		// Token: 0x0600387A RID: 14458 RVA: 0x00198DC3 File Offset: 0x00196FC3
		public static void ResetStaticDefaultValue()
		{
			ConfigSoundBoxMarkByMarkId.LogPair = null;
			ConfigSoundBoxMarkByMarkId.HandleId = 0;
		}

		// Token: 0x0600387B RID: 14459 RVA: 0x00198DD1 File Offset: 0x00196FD1
		public static void Init()
		{
			ConfigSoundBoxMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigSoundBoxMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `SoundBoxMark` where MarkId=?");
		}

		// Token: 0x0600387C RID: 14460 RVA: 0x00198DEC File Offset: 0x00196FEC
		public static SoundBoxMark? GetConfig(int p0MarkId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSoundBoxMarkByMarkId.HandleId, ConfigSoundBoxMarkByMarkId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SoundBoxMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SoundBoxMark?(SoundBoxMark.GetRootAsSoundBoxMark(configBuffer));
				}
			}
			ConfigSoundBoxMarkByMarkId.LogPair.Clear();
			ConfigSoundBoxMarkByMarkId.LogPair.Add(new ValueTuple<string, object>("MarkId", p0MarkId));
			if (!ConfigCommon.BindInt(ConfigSoundBoxMarkByMarkId.HandleId, 1, p0MarkId, ConfigSoundBoxMarkByMarkId.LogPair) || ConfigCommon.Step(ConfigSoundBoxMarkByMarkId.HandleId, true, ConfigSoundBoxMarkByMarkId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSoundBoxMarkByMarkId.HandleId, ConfigSoundBoxMarkByMarkId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSoundBoxMarkByMarkId.HandleId, 0, ConfigSoundBoxMarkByMarkId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSoundBoxMarkByMarkId.HandleId, ConfigSoundBoxMarkByMarkId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SoundBoxMark rootAsSoundBoxMark = SoundBoxMark.GetRootAsSoundBoxMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SoundBoxMarkByMarkId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MarkId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSoundBoxMarkByMarkId.HandleId, ConfigSoundBoxMarkByMarkId.LogPair);
			return new SoundBoxMark?(rootAsSoundBoxMark);
		}

		// Token: 0x040041B0 RID: 16816
		private const string DB = "db_map_mark.db";

		// Token: 0x040041B1 RID: 16817
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x040041B2 RID: 16818
		private const string TABLE = "SoundBoxMark";

		// Token: 0x040041B3 RID: 16819
		private const string COMMAND = "select BinData from `SoundBoxMark` where MarkId=?";

		// Token: 0x040041B4 RID: 16820
		private const string KEY_PREFIX = "SoundBoxMarkByMarkId";

		// Token: 0x040041B5 RID: 16821
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041B6 RID: 16822
		private static int HandleId;
	}
}
