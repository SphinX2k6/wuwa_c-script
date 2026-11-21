using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000981 RID: 2433
	public class ConfigSkillButtonEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003919 RID: 14617 RVA: 0x0019F61C File Offset: 0x0019D81C
		static ConfigSkillButtonEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillButtonEffectById.CreateStaticDefaultValue), new Action(ConfigSkillButtonEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x0019F63C File Offset: 0x0019D83C
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillButtonEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillButtonEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillbutton.db"),
				new ValueTuple<string, object>("文件", "j.技能按钮.xlsx"),
				new ValueTuple<string, object>("表名", "SkillButtonEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillButtonEffect` where Id=?")
			});
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x0019F6BB File Offset: 0x0019D8BB
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillButtonEffectById.LogPair = null;
			ConfigSkillButtonEffectById.HandleId = 0;
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x0019F6C9 File Offset: 0x0019D8C9
		public static void Init()
		{
			ConfigSkillButtonEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillButtonEffectById.HandleId, "db_skillbutton.db", "select BinData from `SkillButtonEffect` where Id=?");
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x0019F6E4 File Offset: 0x0019D8E4
		public static SkillButtonEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillButtonEffectById.HandleId, ConfigSkillButtonEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillButtonEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SkillButtonEffect?(SkillButtonEffect.GetRootAsSkillButtonEffect(configBuffer));
				}
			}
			ConfigSkillButtonEffectById.LogPair.Clear();
			ConfigSkillButtonEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSkillButtonEffectById.HandleId, 1, p0Id, ConfigSkillButtonEffectById.LogPair) || ConfigCommon.Step(ConfigSkillButtonEffectById.HandleId, true, ConfigSkillButtonEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkillButtonEffectById.HandleId, ConfigSkillButtonEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillButtonEffectById.HandleId, 0, ConfigSkillButtonEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkillButtonEffectById.HandleId, ConfigSkillButtonEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SkillButtonEffect rootAsSkillButtonEffect = SkillButtonEffect.GetRootAsSkillButtonEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillButtonEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkillButtonEffectById.HandleId, ConfigSkillButtonEffectById.LogPair);
			return new SkillButtonEffect?(rootAsSkillButtonEffect);
		}

		// Token: 0x0400426D RID: 17005
		private const string DB = "db_skillbutton.db";

		// Token: 0x0400426E RID: 17006
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x0400426F RID: 17007
		private const string TABLE = "SkillButtonEffect";

		// Token: 0x04004270 RID: 17008
		private const string COMMAND = "select BinData from `SkillButtonEffect` where Id=?";

		// Token: 0x04004271 RID: 17009
		private const string KEY_PREFIX = "SkillButtonEffectById";

		// Token: 0x04004272 RID: 17010
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004273 RID: 17011
		private static int HandleId;
	}
}
