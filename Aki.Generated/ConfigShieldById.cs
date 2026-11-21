using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200096E RID: 2414
	public class ConfigShieldById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038A7 RID: 14503 RVA: 0x0019CD6C File Offset: 0x0019AF6C
		static ConfigShieldById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigShieldById.CreateStaticDefaultValue), new Action(ConfigShieldById.ResetStaticDefaultValue));
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x0019CD8C File Offset: 0x0019AF8C
		public static void CreateStaticDefaultValue()
		{
			ConfigShieldById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigShieldById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shield.db"),
				new ValueTuple<string, object>("文件", "h.护盾.xlsx"),
				new ValueTuple<string, object>("表名", "Shield"),
				new ValueTuple<string, object>("语句", "select BinData from `Shield` where Id = ?")
			});
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x0019CE0B File Offset: 0x0019B00B
		public static void ResetStaticDefaultValue()
		{
			ConfigShieldById.LogPair = null;
			ConfigShieldById.HandleId = 0;
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x0019CE19 File Offset: 0x0019B019
		public static void Init()
		{
			ConfigShieldById.HandleId = ConfigCommon.InitDataStatement(ConfigShieldById.HandleId, "db_shield.db", "select BinData from `Shield` where Id = ?");
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x0019CE34 File Offset: 0x0019B034
		public static Shield? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigShieldById.HandleId, ConfigShieldById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ShieldById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Shield?(Shield.GetRootAsShield(configBuffer));
				}
			}
			ConfigShieldById.LogPair.Clear();
			ConfigShieldById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigShieldById.HandleId, 1, p0Id, ConfigShieldById.LogPair) || ConfigCommon.Step(ConfigShieldById.HandleId, true, ConfigShieldById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigShieldById.HandleId, ConfigShieldById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigShieldById.HandleId, 0, ConfigShieldById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigShieldById.HandleId, ConfigShieldById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Shield rootAsShield = Shield.GetRootAsShield(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ShieldById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigShieldById.HandleId, ConfigShieldById.LogPair);
			return new Shield?(rootAsShield);
		}

		// Token: 0x040041E8 RID: 16872
		private const string DB = "db_shield.db";

		// Token: 0x040041E9 RID: 16873
		private const string FILE = "h.护盾.xlsx";

		// Token: 0x040041EA RID: 16874
		private const string TABLE = "Shield";

		// Token: 0x040041EB RID: 16875
		private const string COMMAND = "select BinData from `Shield` where Id = ?";

		// Token: 0x040041EC RID: 16876
		private const string KEY_PREFIX = "ShieldById";

		// Token: 0x040041ED RID: 16877
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040041EE RID: 16878
		private static int HandleId;
	}
}
