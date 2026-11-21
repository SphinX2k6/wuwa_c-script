using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200098F RID: 2447
	public class ConfigSkillInputById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600396D RID: 14701 RVA: 0x001A1454 File Offset: 0x0019F654
		static ConfigSkillInputById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillInputById.CreateStaticDefaultValue), new Action(ConfigSkillInputById.ResetStaticDefaultValue));
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x001A1474 File Offset: 0x0019F674
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

		// Token: 0x0600396F RID: 14703 RVA: 0x001A14F3 File Offset: 0x0019F6F3
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillInputById.LogPair = null;
			ConfigSkillInputById.HandleId = 0;
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x001A1501 File Offset: 0x0019F701
		public static void Init()
		{
			ConfigSkillInputById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillInputById.HandleId, "db_skilltree.db", "select BinData from `SkillInput` where Id = ?");
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x001A151C File Offset: 0x0019F71C
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

		// Token: 0x040042CF RID: 17103
		private const string DB = "db_skilltree.db";

		// Token: 0x040042D0 RID: 17104
		private const string FILE = "j.技能树.xlsx";

		// Token: 0x040042D1 RID: 17105
		private const string TABLE = "SkillInput";

		// Token: 0x040042D2 RID: 17106
		private const string COMMAND = "select BinData from `SkillInput` where Id = ?";

		// Token: 0x040042D3 RID: 17107
		private const string KEY_PREFIX = "SkillInputById";

		// Token: 0x040042D4 RID: 17108
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042D5 RID: 17109
		private static int HandleId;
	}
}
