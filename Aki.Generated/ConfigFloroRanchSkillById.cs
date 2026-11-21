using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200033A RID: 826
	public class ConfigFloroRanchSkillById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001361 RID: 4961 RVA: 0x000CA773 File Offset: 0x000C8973
		static ConfigFloroRanchSkillById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchSkillById.CreateStaticDefaultValue), new Action(ConfigFloroRanchSkillById.ResetStaticDefaultValue));
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x000CA794 File Offset: 0x000C8994
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchSkillById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchSkillById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchSkill"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchSkill` where Id=?")
			});
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x000CA813 File Offset: 0x000C8A13
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchSkillById.LogPair = null;
			ConfigFloroRanchSkillById.HandleId = 0;
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x000CA821 File Offset: 0x000C8A21
		public static void Init()
		{
			ConfigFloroRanchSkillById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchSkillById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchSkill` where Id=?");
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x000CA83C File Offset: 0x000C8A3C
		public static FloroRanchSkill? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchSkillById.HandleId, ConfigFloroRanchSkillById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchSkill?(FloroRanchSkill.GetRootAsFloroRanchSkill(configBuffer));
				}
			}
			ConfigFloroRanchSkillById.LogPair.Clear();
			ConfigFloroRanchSkillById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchSkillById.HandleId, 1, p0Id, ConfigFloroRanchSkillById.LogPair) || ConfigCommon.Step(ConfigFloroRanchSkillById.HandleId, true, ConfigFloroRanchSkillById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchSkillById.HandleId, ConfigFloroRanchSkillById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchSkillById.HandleId, 0, ConfigFloroRanchSkillById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchSkillById.HandleId, ConfigFloroRanchSkillById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchSkill rootAsFloroRanchSkill = FloroRanchSkill.GetRootAsFloroRanchSkill(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchSkillById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchSkillById.HandleId, ConfigFloroRanchSkillById.LogPair);
			return new FloroRanchSkill?(rootAsFloroRanchSkill);
		}

		// Token: 0x0400167A RID: 5754
		private const string DB = "db_flororanch.db";

		// Token: 0x0400167B RID: 5755
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400167C RID: 5756
		private const string TABLE = "FloroRanchSkill";

		// Token: 0x0400167D RID: 5757
		private const string COMMAND = "select BinData from `FloroRanchSkill` where Id=?";

		// Token: 0x0400167E RID: 5758
		private const string KEY_PREFIX = "FloroRanchSkillById";

		// Token: 0x0400167F RID: 5759
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001680 RID: 5760
		private static int HandleId;
	}
}
