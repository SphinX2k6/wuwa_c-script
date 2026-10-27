using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200021F RID: 543
	public class ConfigDreamLinkRoleDungeonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000CBE RID: 3262 RVA: 0x000A1A0C File Offset: 0x0009FC0C
		static ConfigDreamLinkRoleDungeonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDreamLinkRoleDungeonById.CreateStaticDefaultValue), new Action(ConfigDreamLinkRoleDungeonById.ResetStaticDefaultValue));
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x000A1A2C File Offset: 0x0009FC2C
		public static void CreateStaticDefaultValue()
		{
			ConfigDreamLinkRoleDungeonById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDreamLinkRoleDungeonById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dreamlink.db"),
				new ValueTuple<string, object>("文件", "m.梦境链接活动.xlsx"),
				new ValueTuple<string, object>("表名", "DreamLinkRoleDungeon"),
				new ValueTuple<string, object>("语句", "select BinData from `DreamLinkRoleDungeon` where Id=?")
			});
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x000A1AAB File Offset: 0x0009FCAB
		public static void ResetStaticDefaultValue()
		{
			ConfigDreamLinkRoleDungeonById.LogPair = null;
			ConfigDreamLinkRoleDungeonById.HandleId = 0;
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x000A1AB9 File Offset: 0x0009FCB9
		public static void Init()
		{
			ConfigDreamLinkRoleDungeonById.HandleId = ConfigCommon.InitDataStatement(ConfigDreamLinkRoleDungeonById.HandleId, "db_dreamlink.db", "select BinData from `DreamLinkRoleDungeon` where Id=?");
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x000A1AD4 File Offset: 0x0009FCD4
		public static DreamLinkRoleDungeon? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDreamLinkRoleDungeonById.HandleId, ConfigDreamLinkRoleDungeonById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DreamLinkRoleDungeonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DreamLinkRoleDungeon?(DreamLinkRoleDungeon.GetRootAsDreamLinkRoleDungeon(configBuffer));
				}
			}
			ConfigDreamLinkRoleDungeonById.LogPair.Clear();
			ConfigDreamLinkRoleDungeonById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDreamLinkRoleDungeonById.HandleId, 1, p0Id, ConfigDreamLinkRoleDungeonById.LogPair) || ConfigCommon.Step(ConfigDreamLinkRoleDungeonById.HandleId, true, ConfigDreamLinkRoleDungeonById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDreamLinkRoleDungeonById.HandleId, ConfigDreamLinkRoleDungeonById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDreamLinkRoleDungeonById.HandleId, 0, ConfigDreamLinkRoleDungeonById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDreamLinkRoleDungeonById.HandleId, ConfigDreamLinkRoleDungeonById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DreamLinkRoleDungeon rootAsDreamLinkRoleDungeon = DreamLinkRoleDungeon.GetRootAsDreamLinkRoleDungeon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DreamLinkRoleDungeonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDreamLinkRoleDungeonById.HandleId, ConfigDreamLinkRoleDungeonById.LogPair);
			return new DreamLinkRoleDungeon?(rootAsDreamLinkRoleDungeon);
		}

		// Token: 0x04000EBD RID: 3773
		private const string DB = "db_dreamlink.db";

		// Token: 0x04000EBE RID: 3774
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04000EBF RID: 3775
		private const string TABLE = "DreamLinkRoleDungeon";

		// Token: 0x04000EC0 RID: 3776
		private const string COMMAND = "select BinData from `DreamLinkRoleDungeon` where Id=?";

		// Token: 0x04000EC1 RID: 3777
		private const string KEY_PREFIX = "DreamLinkRoleDungeonById";

		// Token: 0x04000EC2 RID: 3778
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000EC3 RID: 3779
		private static int HandleId;
	}
}
