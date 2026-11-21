using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200098A RID: 2442
	public class ConfigSkillDescriptionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600394F RID: 14671 RVA: 0x001A091C File Offset: 0x0019EB1C
		static ConfigSkillDescriptionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillDescriptionById.CreateStaticDefaultValue), new Action(ConfigSkillDescriptionById.ResetStaticDefaultValue));
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x001A093C File Offset: 0x0019EB3C
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillDescriptionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillDescriptionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skill.db"),
				new ValueTuple<string, object>("文件", "j.技能.xlsx"),
				new ValueTuple<string, object>("表名", "SkillDescription"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillDescription` where Id = ?")
			});
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x001A09BB File Offset: 0x0019EBBB
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillDescriptionById.LogPair = null;
			ConfigSkillDescriptionById.HandleId = 0;
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x001A09C9 File Offset: 0x0019EBC9
		public static void Init()
		{
			ConfigSkillDescriptionById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillDescriptionById.HandleId, "db_skill.db", "select BinData from `SkillDescription` where Id = ?");
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x001A09E4 File Offset: 0x0019EBE4
		public static SkillDescription? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillDescriptionById.HandleId, ConfigSkillDescriptionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillDescriptionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SkillDescription?(SkillDescription.GetRootAsSkillDescription(configBuffer));
				}
			}
			ConfigSkillDescriptionById.LogPair.Clear();
			ConfigSkillDescriptionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSkillDescriptionById.HandleId, 1, p0Id, ConfigSkillDescriptionById.LogPair) || ConfigCommon.Step(ConfigSkillDescriptionById.HandleId, true, ConfigSkillDescriptionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkillDescriptionById.HandleId, ConfigSkillDescriptionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillDescriptionById.HandleId, 0, ConfigSkillDescriptionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkillDescriptionById.HandleId, ConfigSkillDescriptionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SkillDescription rootAsSkillDescription = SkillDescription.GetRootAsSkillDescription(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillDescriptionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkillDescriptionById.HandleId, ConfigSkillDescriptionById.LogPair);
			return new SkillDescription?(rootAsSkillDescription);
		}

		// Token: 0x040042AC RID: 17068
		private const string DB = "db_skill.db";

		// Token: 0x040042AD RID: 17069
		private const string FILE = "j.技能.xlsx";

		// Token: 0x040042AE RID: 17070
		private const string TABLE = "SkillDescription";

		// Token: 0x040042AF RID: 17071
		private const string COMMAND = "select BinData from `SkillDescription` where Id = ?";

		// Token: 0x040042B0 RID: 17072
		private const string KEY_PREFIX = "SkillDescriptionById";

		// Token: 0x040042B1 RID: 17073
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042B2 RID: 17074
		private static int HandleId;
	}
}
