using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000944 RID: 2372
	public class ConfigSkillInputById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037AB RID: 14251 RVA: 0x00194234 File Offset: 0x00192434
		static ConfigSkillInputById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillInputById.CreateStaticDefaultValue), new Action(ConfigSkillInputById.ResetStaticDefaultValue));
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x00194254 File Offset: 0x00192454
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillInputById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillInputById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skilltree.db"),
				new ValueTuple<string, object>("文件", "j.技能树.xlsx"),
				new ValueTuple<string, object>("表名", "SkillInput"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillInput` where Id = ?")
			});
		}

		// Token: 0x060037AD RID: 14253 RVA: 0x001942D3 File Offset: 0x001924D3
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillInputById.LogPair = null;
			ConfigSkillInputById.HandleId = 0;
		}

		// Token: 0x060037AE RID: 14254 RVA: 0x001942E1 File Offset: 0x001924E1
		public static void Init()
		{
			ConfigSkillInputById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillInputById.HandleId, "db_skilltree.db", "select BinData from `SkillInput` where Id = ?");
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x001942FC File Offset: 0x001924FC
		public static SkillInput? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillInputById.HandleId, ConfigSkillInputById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillInputById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SkillInput?(SkillInput.GetRootAsSkillInput(configBuffer));
				}
			}
			ConfigSkillInputById.LogPair.Clear();
			ConfigSkillInputById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSkillInputById.HandleId, 1, p0Id, ConfigSkillInputById.LogPair) || ConfigCommon.Step(ConfigSkillInputById.HandleId, true, ConfigSkillInputById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkillInputById.HandleId, ConfigSkillInputById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillInputById.HandleId, 0, ConfigSkillInputById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkillInputById.HandleId, ConfigSkillInputById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SkillInput rootAsSkillInput = SkillInput.GetRootAsSkillInput(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillInputById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkillInputById.HandleId, ConfigSkillInputById.LogPair);
			return new SkillInput?(rootAsSkillInput);
		}

		// Token: 0x040040C2 RID: 16578
		private const string DB = "db_skilltree.db";

		// Token: 0x040040C3 RID: 16579
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x040040C4 RID: 16580
		private const string TABLE = "SkillInput";

		// Token: 0x040040C5 RID: 16581
		private const string COMMAND = "select BinData from `SkillInput` where Id = ?";

		// Token: 0x040040C6 RID: 16582
		private const string KEY_PREFIX = "SkillInputById";

		// Token: 0x040040C7 RID: 16583
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040C8 RID: 16584
		private static int HandleId;
	}
}
