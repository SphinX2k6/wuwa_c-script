using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000997 RID: 2455
	public class ConfigSkillTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600399D RID: 14749 RVA: 0x001A2657 File Offset: 0x001A0857
		static ConfigSkillTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillTypeById.CreateStaticDefaultValue), new Action(ConfigSkillTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x001A2678 File Offset: 0x001A0878
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skill.db"),
				new ValueTuple<string, object>("文件", "j.技能.xlsx"),
				new ValueTuple<string, object>("表名", "SkillType"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillType` where Id = ?")
			});
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x001A26F7 File Offset: 0x001A08F7
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillTypeById.LogPair = null;
			ConfigSkillTypeById.HandleId = 0;
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x001A2705 File Offset: 0x001A0905
		public static void Init()
		{
			ConfigSkillTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillTypeById.HandleId, "db_skill.db", "select BinData from `SkillType` where Id = ?");
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x001A2720 File Offset: 0x001A0920
		public static SkillType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillTypeById.HandleId, ConfigSkillTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SkillType?(SkillType.GetRootAsSkillType(configBuffer));
				}
			}
			ConfigSkillTypeById.LogPair.Clear();
			ConfigSkillTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSkillTypeById.HandleId, 1, p0Id, ConfigSkillTypeById.LogPair) || ConfigCommon.Step(ConfigSkillTypeById.HandleId, true, ConfigSkillTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkillTypeById.HandleId, ConfigSkillTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillTypeById.HandleId, 0, ConfigSkillTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkillTypeById.HandleId, ConfigSkillTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SkillType rootAsSkillType = SkillType.GetRootAsSkillType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkillTypeById.HandleId, ConfigSkillTypeById.LogPair);
			return new SkillType?(rootAsSkillType);
		}

		// Token: 0x04004307 RID: 17159
		private const string DB = "db_skill.db";

		// Token: 0x04004308 RID: 17160
		private const string FILE = "j.技能.xlsx";

		// Token: 0x04004309 RID: 17161
		private const string TABLE = "SkillType";

		// Token: 0x0400430A RID: 17162
		private const string COMMAND = "select BinData from `SkillType` where Id = ?";

		// Token: 0x0400430B RID: 17163
		private const string KEY_PREFIX = "SkillTypeById";

		// Token: 0x0400430C RID: 17164
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400430D RID: 17165
		private static int HandleId;
	}
}
