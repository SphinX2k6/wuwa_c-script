using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000980 RID: 2432
	public class ConfigSkillButtonCustomById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003913 RID: 14611 RVA: 0x0019F3D3 File Offset: 0x0019D5D3
		static ConfigSkillButtonCustomById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillButtonCustomById.CreateStaticDefaultValue), new Action(ConfigSkillButtonCustomById.ResetStaticDefaultValue));
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x0019F3F4 File Offset: 0x0019D5F4
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillButtonCustomById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillButtonCustomById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillbutton.db"),
				new ValueTuple<string, object>("文件", "j.技能按钮.xlsx"),
				new ValueTuple<string, object>("表名", "SkillButtonCustom"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillButtonCustom` where Id=?")
			});
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x0019F473 File Offset: 0x0019D673
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillButtonCustomById.LogPair = null;
			ConfigSkillButtonCustomById.HandleId = 0;
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x0019F481 File Offset: 0x0019D681
		public static void Init()
		{
			ConfigSkillButtonCustomById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillButtonCustomById.HandleId, "db_skillbutton.db", "select BinData from `SkillButtonCustom` where Id=?");
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x0019F49C File Offset: 0x0019D69C
		public static SkillButtonCustom? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillButtonCustomById.HandleId, ConfigSkillButtonCustomById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillButtonCustomById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SkillButtonCustom?(SkillButtonCustom.GetRootAsSkillButtonCustom(configBuffer));
				}
			}
			ConfigSkillButtonCustomById.LogPair.Clear();
			ConfigSkillButtonCustomById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSkillButtonCustomById.HandleId, 1, p0Id, ConfigSkillButtonCustomById.LogPair) || ConfigCommon.Step(ConfigSkillButtonCustomById.HandleId, true, ConfigSkillButtonCustomById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkillButtonCustomById.HandleId, ConfigSkillButtonCustomById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillButtonCustomById.HandleId, 0, ConfigSkillButtonCustomById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkillButtonCustomById.HandleId, ConfigSkillButtonCustomById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SkillButtonCustom rootAsSkillButtonCustom = SkillButtonCustom.GetRootAsSkillButtonCustom(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillButtonCustomById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkillButtonCustomById.HandleId, ConfigSkillButtonCustomById.LogPair);
			return new SkillButtonCustom?(rootAsSkillButtonCustom);
		}

		// Token: 0x04004266 RID: 16998
		private const string DB = "db_skillbutton.db";

		// Token: 0x04004267 RID: 16999
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x04004268 RID: 17000
		private const string TABLE = "SkillButtonCustom";

		// Token: 0x04004269 RID: 17001
		private const string COMMAND = "select BinData from `SkillButtonCustom` where Id=?";

		// Token: 0x0400426A RID: 17002
		private const string KEY_PREFIX = "SkillButtonCustomById";

		// Token: 0x0400426B RID: 17003
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400426C RID: 17004
		private static int HandleId;
	}
}
