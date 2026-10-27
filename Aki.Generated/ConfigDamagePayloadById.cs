using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001BE RID: 446
	public class ConfigDamagePayloadById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A77 RID: 2679 RVA: 0x00094D2D File Offset: 0x00092F2D
		static ConfigDamagePayloadById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDamagePayloadById.CreateStaticDefaultValue), new Action(ConfigDamagePayloadById.ResetStaticDefaultValue));
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00094D4C File Offset: 0x00092F4C
		public static void CreateStaticDefaultValue()
		{
			ConfigDamagePayloadById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDamagePayloadById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_damagepayload.db"),
				new ValueTuple<string, object>("文件", "j.结算参数.xlsx"),
				new ValueTuple<string, object>("表名", "DamagePayload"),
				new ValueTuple<string, object>("语句", "select BinData from `DamagePayload` where Id=?")
			});
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00094DCB File Offset: 0x00092FCB
		public static void ResetStaticDefaultValue()
		{
			ConfigDamagePayloadById.LogPair = null;
			ConfigDamagePayloadById.HandleId = 0;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x00094DD9 File Offset: 0x00092FD9
		public static void Init()
		{
			ConfigDamagePayloadById.HandleId = ConfigCommon.InitDataStatement(ConfigDamagePayloadById.HandleId, "db_damagepayload.db", "select BinData from `DamagePayload` where Id=?");
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x00094DF4 File Offset: 0x00092FF4
		public static DamagePayload? GetConfig(long p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDamagePayloadById.HandleId, ConfigDamagePayloadById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DamagePayloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new DamagePayload?(DamagePayload.GetRootAsDamagePayload(configBuffer));
				}
			}
			ConfigDamagePayloadById.LogPair.Clear();
			ConfigDamagePayloadById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindFloat64(ConfigDamagePayloadById.HandleId, 1, (double)p0Id, ConfigDamagePayloadById.LogPair) || ConfigCommon.Step(ConfigDamagePayloadById.HandleId, true, ConfigDamagePayloadById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigDamagePayloadById.HandleId, ConfigDamagePayloadById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDamagePayloadById.HandleId, 0, ConfigDamagePayloadById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigDamagePayloadById.HandleId, ConfigDamagePayloadById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			DamagePayload rootAsDamagePayload = DamagePayload.GetRootAsDamagePayload(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("DamagePayloadById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigDamagePayloadById.HandleId, ConfigDamagePayloadById.LogPair);
			return new DamagePayload?(rootAsDamagePayload);
		}

		// Token: 0x04000C16 RID: 3094
		private const string DB = "db_damagepayload.db";

		// Token: 0x04000C17 RID: 3095
		private const string FILE = "j.结算参数.xlsx";

		// Token: 0x04000C18 RID: 3096
		private const string TABLE = "DamagePayload";

		// Token: 0x04000C19 RID: 3097
		private const string COMMAND = "select BinData from `DamagePayload` where Id=?";

		// Token: 0x04000C1A RID: 3098
		private const string KEY_PREFIX = "DamagePayloadById";

		// Token: 0x04000C1B RID: 3099
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C1C RID: 3100
		private static int HandleId;
	}
}
