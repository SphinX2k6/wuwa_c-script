using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001CF RID: 463
	public class ConfigDamageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000ADD RID: 2781 RVA: 0x0009AA1B File Offset: 0x00098C1B
		static ConfigDamageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDamageById.CreateStaticDefaultValue), new Action(ConfigDamageById.ResetStaticDefaultValue));
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0009AA3C File Offset: 0x00098C3C
		public static void CreateStaticDefaultValue()
		{
			ConfigDamageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDamageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_damage.db"),
				new ValueTuple<string, object>("文件", "j.结算.xlsx"),
				new ValueTuple<string, object>("表名", "Damage"),
				new ValueTuple<string, object>("语句", "select BinData from `Damage` where Id=?")
			});
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0009AABB File Offset: 0x00098CBB
		public static void ResetStaticDefaultValue()
		{
			ConfigDamageById.LogPair = null;
			ConfigDamageById.HandleId = 0;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0009AAC9 File Offset: 0x00098CC9
		public static void Init()
		{
			ConfigDamageById.HandleId = ConfigCommon.InitDataStatement(ConfigDamageById.HandleId, "db_damage.db", "select BinData from `Damage` where Id=?");
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0009AAE4 File Offset: 0x00098CE4
		public static Damage? GetConfig(long p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDamageById.HandleId, ConfigDamageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DamageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Damage?(Damage.GetRootAsDamage(configBuffer));
				}
			}
			ConfigDamageById.LogPair.Clear();
			ConfigDamageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindFloat64(ConfigDamageById.HandleId, 1, (double)p0Id, ConfigDamageById.LogPair) || ConfigCommon.Step(ConfigDamageById.HandleId, true, ConfigDamageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDamageById.HandleId, ConfigDamageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDamageById.HandleId, 0, ConfigDamageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDamageById.HandleId, ConfigDamageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Damage rootAsDamage = Damage.GetRootAsDamage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DamageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDamageById.HandleId, ConfigDamageById.LogPair);
			return new Damage?(rootAsDamage);
		}

		// Token: 0x04000C8D RID: 3213
		private const string DB = "db_damage.db";

		// Token: 0x04000C8E RID: 3214
		private const string FILE = "j.结算.xlsx";

		// Token: 0x04000C8F RID: 3215
		private const string TABLE = "Damage";

		// Token: 0x04000C90 RID: 3216
		private const string COMMAND = "select BinData from `Damage` where Id=?";

		// Token: 0x04000C91 RID: 3217
		private const string KEY_PREFIX = "DamageById";

		// Token: 0x04000C92 RID: 3218
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C93 RID: 3219
		private static int HandleId;
	}
}
