using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000937 RID: 2359
	public class ConfigSkillButtonIndexById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600375D RID: 14173 RVA: 0x00192644 File Offset: 0x00190844
		static ConfigSkillButtonIndexById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillButtonIndexById.CreateStaticDefaultValue), new Action(ConfigSkillButtonIndexById.ResetStaticDefaultValue));
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x00192664 File Offset: 0x00190864
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

		// Token: 0x0600375F RID: 14175 RVA: 0x001926E3 File Offset: 0x001908E3
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillButtonIndexById.LogPair = null;
			ConfigSkillButtonIndexById.HandleId = 0;
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x001926F1 File Offset: 0x001908F1
		public static void Init()
		{
			ConfigSkillButtonIndexById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillButtonIndexById.HandleId, "db_skillbutton.db", "select BinData from `SkillButtonIndex` where Id=?");
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x0019270C File Offset: 0x0019090C
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

		// Token: 0x04004067 RID: 16487
		private const string DB = "db_skillbutton.db";

		// Token: 0x04004068 RID: 16488
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x04004069 RID: 16489
		private const string TABLE = "SkillButtonIndex";

		// Token: 0x0400406A RID: 16490
		private const string COMMAND = "select BinData from `SkillButtonIndex` where Id=?";

		// Token: 0x0400406B RID: 16491
		private const string KEY_PREFIX = "SkillButtonIndexById";

		// Token: 0x0400406C RID: 16492
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400406D RID: 16493
		private static int HandleId;
	}
}
