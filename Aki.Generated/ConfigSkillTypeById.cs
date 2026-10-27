using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200094C RID: 2380
	public class ConfigSkillTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037DB RID: 14299 RVA: 0x00195437 File Offset: 0x00193637
		static ConfigSkillTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillTypeById.CreateStaticDefaultValue), new Action(ConfigSkillTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x00195458 File Offset: 0x00193658
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

		// Token: 0x060037DD RID: 14301 RVA: 0x001954D7 File Offset: 0x001936D7
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillTypeById.LogPair = null;
			ConfigSkillTypeById.HandleId = 0;
		}

		// Token: 0x060037DE RID: 14302 RVA: 0x001954E5 File Offset: 0x001936E5
		public static void Init()
		{
			ConfigSkillTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillTypeById.HandleId, "db_skill.db", "select BinData from `SkillType` where Id = ?");
		}

		// Token: 0x060037DF RID: 14303 RVA: 0x00195500 File Offset: 0x00193700
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

		// Token: 0x040040FA RID: 16634
		private const string DB = "db_skill.db";

		// Token: 0x040040FB RID: 16635
		private const string FILE = "j.技能.xlsx";

		// Token: 0x040040FC RID: 16636
		private const string TABLE = "SkillType";

		// Token: 0x040040FD RID: 16637
		private const string COMMAND = "select BinData from `SkillType` where Id = ?";

		// Token: 0x040040FE RID: 16638
		private const string KEY_PREFIX = "SkillTypeById";

		// Token: 0x040040FF RID: 16639
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004100 RID: 16640
		private static int HandleId;
	}
}
