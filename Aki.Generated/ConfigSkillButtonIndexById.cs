using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000982 RID: 2434
	public class ConfigSkillButtonIndexById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600391F RID: 14623 RVA: 0x0019F864 File Offset: 0x0019DA64
		static ConfigSkillButtonIndexById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillButtonIndexById.CreateStaticDefaultValue), new Action(ConfigSkillButtonIndexById.ResetStaticDefaultValue));
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x0019F884 File Offset: 0x0019DA84
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillButtonIndexById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillButtonIndexById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillbutton.db"),
				new ValueTuple<string, object>("文件", "j.技能按钮.xlsx"),
				new ValueTuple<string, object>("表名", "SkillButtonIndex"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillButtonIndex` where Id=?")
			});
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x0019F903 File Offset: 0x0019DB03
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillButtonIndexById.LogPair = null;
			ConfigSkillButtonIndexById.HandleId = 0;
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x0019F911 File Offset: 0x0019DB11
		public static void Init()
		{
			ConfigSkillButtonIndexById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillButtonIndexById.HandleId, "db_skillbutton.db", "select BinData from `SkillButtonIndex` where Id=?");
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x0019F92C File Offset: 0x0019DB2C
		public static SkillButtonIndex? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillButtonIndexById.HandleId, ConfigSkillButtonIndexById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillButtonIndexById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SkillButtonIndex?(SkillButtonIndex.GetRootAsSkillButtonIndex(configBuffer));
				}
			}
			ConfigSkillButtonIndexById.LogPair.Clear();
			ConfigSkillButtonIndexById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSkillButtonIndexById.HandleId, 1, p0Id, ConfigSkillButtonIndexById.LogPair) || ConfigCommon.Step(ConfigSkillButtonIndexById.HandleId, true, ConfigSkillButtonIndexById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkillButtonIndexById.HandleId, ConfigSkillButtonIndexById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillButtonIndexById.HandleId, 0, ConfigSkillButtonIndexById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkillButtonIndexById.HandleId, ConfigSkillButtonIndexById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SkillButtonIndex rootAsSkillButtonIndex = SkillButtonIndex.GetRootAsSkillButtonIndex(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillButtonIndexById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkillButtonIndexById.HandleId, ConfigSkillButtonIndexById.LogPair);
			return new SkillButtonIndex?(rootAsSkillButtonIndex);
		}

		// Token: 0x04004274 RID: 17012
		private const string DB = "db_skillbutton.db";

		// Token: 0x04004275 RID: 17013
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x04004276 RID: 17014
		private const string TABLE = "SkillButtonIndex";

		// Token: 0x04004277 RID: 17015
		private const string COMMAND = "select BinData from `SkillButtonIndex` where Id=?";

		// Token: 0x04004278 RID: 17016
		private const string KEY_PREFIX = "SkillButtonIndexById";

		// Token: 0x04004279 RID: 17017
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400427A RID: 17018
		private static int HandleId;
	}
}
