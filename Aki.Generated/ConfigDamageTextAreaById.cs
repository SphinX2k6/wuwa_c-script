using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C1 RID: 449
	public class ConfigDamageTextAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A89 RID: 2697 RVA: 0x0009529B File Offset: 0x0009349B
		static ConfigDamageTextAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDamageTextAreaById.CreateStaticDefaultValue), new Action(ConfigDamageTextAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x000952BC File Offset: 0x000934BC
		public static void CreateStaticDefaultValue()
		{
			ConfigDamageTextAreaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDamageTextAreaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_damage_text.db"),
				new ValueTuple<string, object>("文件", "s.伤害飘字.xlsx"),
				new ValueTuple<string, object>("表名", "DamageTextArea"),
				new ValueTuple<string, object>("语句", "select BinData from `DamageTextArea` where Id=?")
			});
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0009533B File Offset: 0x0009353B
		public static void ResetStaticDefaultValue()
		{
			ConfigDamageTextAreaById.LogPair = null;
			ConfigDamageTextAreaById.HandleId = 0;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00095349 File Offset: 0x00093549
		public static void Init()
		{
			ConfigDamageTextAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigDamageTextAreaById.HandleId, "db_damage_text.db", "select BinData from `DamageTextArea` where Id=?");
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00095364 File Offset: 0x00093564
		public static DamageTextArea? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDamageTextAreaById.HandleId, ConfigDamageTextAreaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DamageTextAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DamageTextArea?(DamageTextArea.GetRootAsDamageTextArea(configBuffer));
				}
			}
			ConfigDamageTextAreaById.LogPair.Clear();
			ConfigDamageTextAreaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigDamageTextAreaById.HandleId, 1, p0Id, ConfigDamageTextAreaById.LogPair) || ConfigCommon.Step(ConfigDamageTextAreaById.HandleId, true, ConfigDamageTextAreaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDamageTextAreaById.HandleId, ConfigDamageTextAreaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDamageTextAreaById.HandleId, 0, ConfigDamageTextAreaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDamageTextAreaById.HandleId, ConfigDamageTextAreaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DamageTextArea rootAsDamageTextArea = DamageTextArea.GetRootAsDamageTextArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DamageTextAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDamageTextAreaById.HandleId, ConfigDamageTextAreaById.LogPair);
			return new DamageTextArea?(rootAsDamageTextArea);
		}

		// Token: 0x04000C2B RID: 3115
		private const string DB = "db_damage_text.db";

		// Token: 0x04000C2C RID: 3116
		private const string FILE = "s.伤害飘字.xlsx";

		// Token: 0x04000C2D RID: 3117
		private const string TABLE = "DamageTextArea";

		// Token: 0x04000C2E RID: 3118
		private const string COMMAND = "select BinData from `DamageTextArea` where Id=?";

		// Token: 0x04000C2F RID: 3119
		private const string KEY_PREFIX = "DamageTextAreaById";

		// Token: 0x04000C30 RID: 3120
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C31 RID: 3121
		private static int HandleId;
	}
}
