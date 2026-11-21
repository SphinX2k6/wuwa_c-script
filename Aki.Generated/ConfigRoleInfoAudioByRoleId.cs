using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008CC RID: 2252
	public class ConfigRoleInfoAudioByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034DB RID: 13531 RVA: 0x001876E3 File Offset: 0x001858E3
		static ConfigRoleInfoAudioByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfoAudioByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleInfoAudioByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x00187704 File Offset: 0x00185904
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleInfoAudioByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleInfoAudioByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频_角色音频.xlsx"),
				new ValueTuple<string, object>("表名", "RoleInfoAudio"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleInfoAudio` where RoleId=?")
			});
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x00187783 File Offset: 0x00185983
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfoAudioByRoleId.LogPair = null;
			ConfigRoleInfoAudioByRoleId.HandleId = 0;
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x00187791 File Offset: 0x00185991
		public static void Init()
		{
			ConfigRoleInfoAudioByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfoAudioByRoleId.HandleId, "db_audio.db", "select BinData from `RoleInfoAudio` where RoleId=?");
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x001877AC File Offset: 0x001859AC
		public static RoleInfoAudio? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleInfoAudioByRoleId.HandleId, ConfigRoleInfoAudioByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleInfoAudioByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleInfoAudio?(RoleInfoAudio.GetRootAsRoleInfoAudio(configBuffer));
				}
			}
			ConfigRoleInfoAudioByRoleId.LogPair.Clear();
			ConfigRoleInfoAudioByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleInfoAudioByRoleId.HandleId, 1, p0RoleId, ConfigRoleInfoAudioByRoleId.LogPair) || ConfigCommon.Step(ConfigRoleInfoAudioByRoleId.HandleId, true, ConfigRoleInfoAudioByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleInfoAudioByRoleId.HandleId, ConfigRoleInfoAudioByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleInfoAudioByRoleId.HandleId, 0, ConfigRoleInfoAudioByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleInfoAudioByRoleId.HandleId, ConfigRoleInfoAudioByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleInfoAudio rootAsRoleInfoAudio = RoleInfoAudio.GetRootAsRoleInfoAudio(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleInfoAudioByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleInfoAudioByRoleId.HandleId, ConfigRoleInfoAudioByRoleId.LogPair);
			return new RoleInfoAudio?(rootAsRoleInfoAudio);
		}

		// Token: 0x04003D7A RID: 15738
		private const string DB = "db_audio.db";

		// Token: 0x04003D7B RID: 15739
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003D7C RID: 15740
		private const string TABLE = "RoleInfoAudio";

		// Token: 0x04003D7D RID: 15741
		private const string COMMAND = "select BinData from `RoleInfoAudio` where RoleId=?";

		// Token: 0x04003D7E RID: 15742
		private const string KEY_PREFIX = "RoleInfoAudioByRoleId";

		// Token: 0x04003D7F RID: 15743
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D80 RID: 15744
		private static int HandleId;
	}
}
