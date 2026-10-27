using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000935 RID: 2357
	public class ConfigSkillButtonCustomById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003751 RID: 14161 RVA: 0x001921B3 File Offset: 0x001903B3
		static ConfigSkillButtonCustomById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillButtonCustomById.CreateStaticDefaultValue), new Action(ConfigSkillButtonCustomById.ResetStaticDefaultValue));
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x001921D4 File Offset: 0x001903D4
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

		// Token: 0x06003753 RID: 14163 RVA: 0x00192253 File Offset: 0x00190453
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillButtonCustomById.LogPair = null;
			ConfigSkillButtonCustomById.HandleId = 0;
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x00192261 File Offset: 0x00190461
		public static void Init()
		{
			ConfigSkillButtonCustomById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillButtonCustomById.HandleId, "db_skillbutton.db", "select BinData from `SkillButtonCustom` where Id=?");
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x0019227C File Offset: 0x0019047C
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

		// Token: 0x04004059 RID: 16473
		private const string DB = "db_skillbutton.db";

		// Token: 0x0400405A RID: 16474
		private const string FILE = "j.技能按钮.xlsx";

		// Token: 0x0400405B RID: 16475
		private const string TABLE = "SkillButtonCustom";

		// Token: 0x0400405C RID: 16476
		private const string COMMAND = "select BinData from `SkillButtonCustom` where Id=?";

		// Token: 0x0400405D RID: 16477
		private const string KEY_PREFIX = "SkillButtonCustomById";

		// Token: 0x0400405E RID: 16478
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400405F RID: 16479
		private static int HandleId;
	}
}
