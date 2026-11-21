using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000231 RID: 561
	public class ConfigDreamLinkRoleDungeonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D2A RID: 3370 RVA: 0x000A7944 File Offset: 0x000A5B44
		static ConfigDreamLinkRoleDungeonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDreamLinkRoleDungeonById.CreateStaticDefaultValue), new Action(ConfigDreamLinkRoleDungeonById.ResetStaticDefaultValue));
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x000A7964 File Offset: 0x000A5B64
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

		// Token: 0x06000D2C RID: 3372 RVA: 0x000A79E3 File Offset: 0x000A5BE3
		public static void ResetStaticDefaultValue()
		{
			ConfigDreamLinkRoleDungeonById.LogPair = null;
			ConfigDreamLinkRoleDungeonById.HandleId = 0;
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x000A79F1 File Offset: 0x000A5BF1
		public static void Init()
		{
			ConfigDreamLinkRoleDungeonById.HandleId = ConfigCommon.InitDataStatement(ConfigDreamLinkRoleDungeonById.HandleId, "db_dreamlink.db", "select BinData from `DreamLinkRoleDungeon` where Id=?");
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x000A7A0C File Offset: 0x000A5C0C
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

		// Token: 0x04000F3B RID: 3899
		private const string DB = "db_dreamlink.db";

		// Token: 0x04000F3C RID: 3900
		private const string FILE = "m.梦境链接活动.xlsx";

		// Token: 0x04000F3D RID: 3901
		private const string TABLE = "DreamLinkRoleDungeon";

		// Token: 0x04000F3E RID: 3902
		private const string COMMAND = "select BinData from `DreamLinkRoleDungeon` where Id=?";

		// Token: 0x04000F3F RID: 3903
		private const string KEY_PREFIX = "DreamLinkRoleDungeonById";

		// Token: 0x04000F40 RID: 3904
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F41 RID: 3905
		private static int HandleId;
	}
}
