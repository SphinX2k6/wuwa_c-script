using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000446 RID: 1094
	public class ConfigInfrPhoneMessageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019AD RID: 6573 RVA: 0x000EE47F File Offset: 0x000EC67F
		static ConfigInfrPhoneMessageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrPhoneMessageById.CreateStaticDefaultValue), new Action(ConfigInfrPhoneMessageById.ResetStaticDefaultValue));
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x000EE4A0 File Offset: 0x000EC6A0
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrPhoneMessageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrPhoneMessageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infrastructure.db"),
				new ValueTuple<string, object>("文件", "j.基建_档案馆.xlsx"),
				new ValueTuple<string, object>("表名", "InfrPhoneMessage"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrPhoneMessage` where Id=?")
			});
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x000EE51F File Offset: 0x000EC71F
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrPhoneMessageById.LogPair = null;
			ConfigInfrPhoneMessageById.HandleId = 0;
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x000EE52D File Offset: 0x000EC72D
		public static void Init()
		{
			ConfigInfrPhoneMessageById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrPhoneMessageById.HandleId, "db_infrastructure.db", "select BinData from `InfrPhoneMessage` where Id=?");
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x000EE548 File Offset: 0x000EC748
		public static InfrPhoneMessage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrPhoneMessageById.HandleId, ConfigInfrPhoneMessageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrPhoneMessageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrPhoneMessage?(InfrPhoneMessage.GetRootAsInfrPhoneMessage(configBuffer));
				}
			}
			ConfigInfrPhoneMessageById.LogPair.Clear();
			ConfigInfrPhoneMessageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInfrPhoneMessageById.HandleId, 1, p0Id, ConfigInfrPhoneMessageById.LogPair) || ConfigCommon.Step(ConfigInfrPhoneMessageById.HandleId, true, ConfigInfrPhoneMessageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrPhoneMessageById.HandleId, ConfigInfrPhoneMessageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrPhoneMessageById.HandleId, 0, ConfigInfrPhoneMessageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrPhoneMessageById.HandleId, ConfigInfrPhoneMessageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrPhoneMessage rootAsInfrPhoneMessage = InfrPhoneMessage.GetRootAsInfrPhoneMessage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrPhoneMessageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrPhoneMessageById.HandleId, ConfigInfrPhoneMessageById.LogPair);
			return new InfrPhoneMessage?(rootAsInfrPhoneMessage);
		}

		// Token: 0x04001DCE RID: 7630
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001DCF RID: 7631
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001DD0 RID: 7632
		private const string TABLE = "InfrPhoneMessage";

		// Token: 0x04001DD1 RID: 7633
		private const string COMMAND = "select BinData from `InfrPhoneMessage` where Id=?";

		// Token: 0x04001DD2 RID: 7634
		private const string KEY_PREFIX = "InfrPhoneMessageById";

		// Token: 0x04001DD3 RID: 7635
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001DD4 RID: 7636
		private static int HandleId;
	}
}
