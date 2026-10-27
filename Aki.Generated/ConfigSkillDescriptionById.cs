using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200093F RID: 2367
	public class ConfigSkillDescriptionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600378D RID: 14221 RVA: 0x001936FC File Offset: 0x001918FC
		static ConfigSkillDescriptionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillDescriptionById.CreateStaticDefaultValue), new Action(ConfigSkillDescriptionById.ResetStaticDefaultValue));
		}

		// Token: 0x0600378E RID: 14222 RVA: 0x0019371C File Offset: 0x0019191C
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

		// Token: 0x0600378F RID: 14223 RVA: 0x0019379B File Offset: 0x0019199B
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillDescriptionById.LogPair = null;
			ConfigSkillDescriptionById.HandleId = 0;
		}

		// Token: 0x06003790 RID: 14224 RVA: 0x001937A9 File Offset: 0x001919A9
		public static void Init()
		{
			ConfigSkillDescriptionById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillDescriptionById.HandleId, "db_skill.db", "select BinData from `SkillDescription` where Id = ?");
		}

		// Token: 0x06003791 RID: 14225 RVA: 0x001937C4 File Offset: 0x001919C4
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

		// Token: 0x0400409F RID: 16543
		private const string DB = "db_skill.db";

		// Token: 0x040040A0 RID: 16544
		private const string FILE = "j.技能.xlsx";

		// Token: 0x040040A1 RID: 16545
		private const string TABLE = "SkillDescription";

		// Token: 0x040040A2 RID: 16546
		private const string COMMAND = "select BinData from `SkillDescription` where Id = ?";

		// Token: 0x040040A3 RID: 16547
		private const string KEY_PREFIX = "SkillDescriptionById";

		// Token: 0x040040A4 RID: 16548
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040A5 RID: 16549
		private static int HandleId;
	}
}
