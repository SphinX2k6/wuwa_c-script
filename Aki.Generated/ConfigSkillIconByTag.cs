using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200098E RID: 2446
	public class ConfigSkillIconByTag : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003967 RID: 14695 RVA: 0x001A120B File Offset: 0x0019F40B
		static ConfigSkillIconByTag()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillIconByTag.CreateStaticDefaultValue), new Action(ConfigSkillIconByTag.ResetStaticDefaultValue));
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x001A122C File Offset: 0x0019F42C
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

		// Token: 0x06003969 RID: 14697 RVA: 0x001A12AB File Offset: 0x0019F4AB
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillIconByTag.LogPair = null;
			ConfigSkillIconByTag.HandleId = 0;
		}

		// Token: 0x0600396A RID: 14698 RVA: 0x001A12B9 File Offset: 0x0019F4B9
		public static void Init()
		{
			ConfigSkillIconByTag.HandleId = ConfigCommon.InitDataStatement(ConfigSkillIconByTag.HandleId, "db_skillbutton.db", "select BinData from `SkillIcon` where Tag=?");
		}

		// Token: 0x0600396B RID: 14699 RVA: 0x001A12D4 File Offset: 0x0019F4D4
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

		// Token: 0x040042C8 RID: 17096
		private const string DB = "db_skillbutton.db";

		// Token: 0x040042C9 RID: 17097
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x040042CA RID: 17098
		private const string TABLE = "SkillIcon";

		// Token: 0x040042CB RID: 17099
		private const string COMMAND = "select BinData from `SkillIcon` where Tag=?";

		// Token: 0x040042CC RID: 17100
		private const string KEY_PREFIX = "SkillIconByTag";

		// Token: 0x040042CD RID: 17101
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042CE RID: 17102
		private static int HandleId;
	}
}
