using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001BD RID: 445
	public class ConfigDamageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A71 RID: 2673 RVA: 0x00094AE3 File Offset: 0x00092CE3
		static ConfigDamageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDamageById.CreateStaticDefaultValue), new Action(ConfigDamageById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00094B04 File Offset: 0x00092D04
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

		// Token: 0x06000A73 RID: 2675 RVA: 0x00094B83 File Offset: 0x00092D83
		public static void ResetStaticDefaultValue()
		{
			ConfigDamageById.LogPair = null;
			ConfigDamageById.HandleId = 0;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00094B91 File Offset: 0x00092D91
		public static void Init()
		{
			ConfigDamageById.HandleId = ConfigCommon.InitDataStatement(ConfigDamageById.HandleId, "db_damage.db", "select BinData from `Damage` where Id=?");
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00094BAC File Offset: 0x00092DAC
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

		// Token: 0x04000C0F RID: 3087
		private const string DB = "db_damage.db";

		// Token: 0x04000C10 RID: 3088
		private const string FILE = "j.结算.xlsx";

		// Token: 0x04000C11 RID: 3089
		private const string TABLE = "Damage";

		// Token: 0x04000C12 RID: 3090
		private const string COMMAND = "select BinData from `Damage` where Id=?";

		// Token: 0x04000C13 RID: 3091
		private const string KEY_PREFIX = "DamageById";

		// Token: 0x04000C14 RID: 3092
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C15 RID: 3093
		private static int HandleId;
	}
}
