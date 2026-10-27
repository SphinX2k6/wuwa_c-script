using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000943 RID: 2371
	public class ConfigSkillIconByTag : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037A5 RID: 14245 RVA: 0x00193FEB File Offset: 0x001921EB
		static ConfigSkillIconByTag()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillIconByTag.CreateStaticDefaultValue), new Action(ConfigSkillIconByTag.ResetStaticDefaultValue));
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x0019400C File Offset: 0x0019220C
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillIconByTag.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillIconByTag.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillbutton.db"),
				new ValueTuple<string, object>("文件", "j.技能按钮.xlsx"),
				new ValueTuple<string, object>("表名", "SkillIcon"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillIcon` where Tag=?")
			});
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x0019408B File Offset: 0x0019228B
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillIconByTag.LogPair = null;
			ConfigSkillIconByTag.HandleId = 0;
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x00194099 File Offset: 0x00192299
		public static void Init()
		{
			ConfigSkillIconByTag.HandleId = ConfigCommon.InitDataStatement(ConfigSkillIconByTag.HandleId, "db_skillbutton.db", "select BinData from `SkillIcon` where Tag=?");
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x001940B4 File Offset: 0x001922B4
		public static SkillIcon? GetConfig(int p0Tag, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillIconByTag.HandleId, ConfigSkillIconByTag.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillIconByTag");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Tag);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SkillIcon?(SkillIcon.GetRootAsSkillIcon(configBuffer));
				}
			}
			ConfigSkillIconByTag.LogPair.Clear();
			ConfigSkillIconByTag.LogPair.Add(new ValueTuple<string, object>("Tag", p0Tag));
			if (!ConfigCommon.BindInt(ConfigSkillIconByTag.HandleId, 1, p0Tag, ConfigSkillIconByTag.LogPair) || ConfigCommon.Step(ConfigSkillIconByTag.HandleId, true, ConfigSkillIconByTag.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkillIconByTag.HandleId, ConfigSkillIconByTag.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillIconByTag.HandleId, 0, ConfigSkillIconByTag.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkillIconByTag.HandleId, ConfigSkillIconByTag.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SkillIcon rootAsSkillIcon = SkillIcon.GetRootAsSkillIcon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillIconByTag");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Tag);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkillIconByTag.HandleId, ConfigSkillIconByTag.LogPair);
			return new SkillIcon?(rootAsSkillIcon);
		}

		// Token: 0x040040BB RID: 16571
		private const string DB = "db_skillbutton.db";

		// Token: 0x040040BC RID: 16572
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x040040BD RID: 16573
		private const string TABLE = "SkillIcon";

		// Token: 0x040040BE RID: 16574
		private const string COMMAND = "select BinData from `SkillIcon` where Tag=?";

		// Token: 0x040040BF RID: 16575
		private const string KEY_PREFIX = "SkillIconByTag";

		// Token: 0x040040C0 RID: 16576
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040C1 RID: 16577
		private static int HandleId;
	}
}
