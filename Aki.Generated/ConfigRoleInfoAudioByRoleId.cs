using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B0 RID: 2224
	public class ConfigRoleInfoAudioByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003433 RID: 13363 RVA: 0x001803FB File Offset: 0x0017E5FB
		static ConfigRoleInfoAudioByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfoAudioByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleInfoAudioByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x0018041C File Offset: 0x0017E61C
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

		// Token: 0x06003435 RID: 13365 RVA: 0x0018049B File Offset: 0x0017E69B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfoAudioByRoleId.LogPair = null;
			ConfigRoleInfoAudioByRoleId.HandleId = 0;
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x001804A9 File Offset: 0x0017E6A9
		public static void Init()
		{
			ConfigRoleInfoAudioByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfoAudioByRoleId.HandleId, "db_audio.db", "select BinData from `RoleInfoAudio` where RoleId=?");
		}

		// Token: 0x06003437 RID: 13367 RVA: 0x001804C4 File Offset: 0x0017E6C4
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

		// Token: 0x04003CB6 RID: 15542
		private const string DB = "db_audio.db";

		// Token: 0x04003CB7 RID: 15543
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003CB8 RID: 15544
		private const string TABLE = "RoleInfoAudio";

		// Token: 0x04003CB9 RID: 15545
		private const string COMMAND = "select BinData from `RoleInfoAudio` where RoleId=?";

		// Token: 0x04003CBA RID: 15546
		private const string KEY_PREFIX = "RoleInfoAudioByRoleId";

		// Token: 0x04003CBB RID: 15547
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CBC RID: 15548
		private static int HandleId;
	}
}
