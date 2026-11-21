using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A3B RID: 2619
	public class ConfigSoundBoxMarkByMarkId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D76 RID: 15734 RVA: 0x001B80B8 File Offset: 0x001B62B8
		static ConfigSoundBoxMarkByMarkId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSoundBoxMarkByMarkId.CreateStaticDefaultValue), new Action(ConfigSoundBoxMarkByMarkId.ResetStaticDefaultValue));
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x001B80D8 File Offset: 0x001B62D8
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

		// Token: 0x06003D78 RID: 15736 RVA: 0x001B8157 File Offset: 0x001B6357
		public static void ResetStaticDefaultValue()
		{
			ConfigSoundBoxMarkByMarkId.LogPair = null;
			ConfigSoundBoxMarkByMarkId.HandleId = 0;
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x001B8165 File Offset: 0x001B6365
		public static void Init()
		{
			ConfigSoundBoxMarkByMarkId.HandleId = ConfigCommon.InitDataStatement(ConfigSoundBoxMarkByMarkId.HandleId, "db_map_mark.db", "select BinData from `SoundBoxMark` where MarkId=?");
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x001B8180 File Offset: 0x001B6380
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

		// Token: 0x04004783 RID: 18307
		private const string DB = "db_map_mark.db";

		// Token: 0x04004784 RID: 18308
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x04004785 RID: 18309
		private const string TABLE = "SoundBoxMark";

		// Token: 0x04004786 RID: 18310
		private const string COMMAND = "select BinData from `SoundBoxMark` where MarkId=?";

		// Token: 0x04004787 RID: 18311
		private const string KEY_PREFIX = "SoundBoxMarkByMarkId";

		// Token: 0x04004788 RID: 18312
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004789 RID: 18313
		private static int HandleId;
	}
}
