using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D3 RID: 467
	public class ConfigDamageTextAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AF5 RID: 2805 RVA: 0x0009B1D3 File Offset: 0x000993D3
		static ConfigDamageTextAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDamageTextAreaById.CreateStaticDefaultValue), new Action(ConfigDamageTextAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x0009B1F4 File Offset: 0x000993F4
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

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0009B273 File Offset: 0x00099473
		public static void ResetStaticDefaultValue()
		{
			ConfigDamageTextAreaById.LogPair = null;
			ConfigDamageTextAreaById.HandleId = 0;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0009B281 File Offset: 0x00099481
		public static void Init()
		{
			ConfigDamageTextAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigDamageTextAreaById.HandleId, "db_damage_text.db", "select BinData from `DamageTextArea` where Id=?");
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0009B29C File Offset: 0x0009949C
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

		// Token: 0x04000CA9 RID: 3241
		private const string DB = "db_damage_text.db";

		// Token: 0x04000CAA RID: 3242
		private const string FILE = "s.伤害飘字.xlsx";

		// Token: 0x04000CAB RID: 3243
		private const string TABLE = "DamageTextArea";

		// Token: 0x04000CAC RID: 3244
		private const string COMMAND = "select BinData from `DamageTextArea` where Id=?";

		// Token: 0x04000CAD RID: 3245
		private const string KEY_PREFIX = "DamageTextAreaById";

		// Token: 0x04000CAE RID: 3246
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CAF RID: 3247
		private static int HandleId;
	}
}
