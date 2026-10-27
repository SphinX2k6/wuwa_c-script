using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000430 RID: 1072
	public class ConfigInfrPhoneMessageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001929 RID: 6441 RVA: 0x000E7D2B File Offset: 0x000E5F2B
		static ConfigInfrPhoneMessageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrPhoneMessageById.CreateStaticDefaultValue), new Action(ConfigInfrPhoneMessageById.ResetStaticDefaultValue));
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x000E7D4C File Offset: 0x000E5F4C
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

		// Token: 0x0600192B RID: 6443 RVA: 0x000E7DCB File Offset: 0x000E5FCB
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrPhoneMessageById.LogPair = null;
			ConfigInfrPhoneMessageById.HandleId = 0;
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x000E7DD9 File Offset: 0x000E5FD9
		public static void Init()
		{
			ConfigInfrPhoneMessageById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrPhoneMessageById.HandleId, "db_infrastructure.db", "select BinData from `InfrPhoneMessage` where Id=?");
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x000E7DF4 File Offset: 0x000E5FF4
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

		// Token: 0x04001D34 RID: 7476
		private const string DB = "db_infrastructure.db";

		// Token: 0x04001D35 RID: 7477
		private const string FILE = "j.基建_档案馆.xlsx";

		// Token: 0x04001D36 RID: 7478
		private const string TABLE = "InfrPhoneMessage";

		// Token: 0x04001D37 RID: 7479
		private const string COMMAND = "select BinData from `InfrPhoneMessage` where Id=?";

		// Token: 0x04001D38 RID: 7480
		private const string KEY_PREFIX = "InfrPhoneMessageById";

		// Token: 0x04001D39 RID: 7481
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D3A RID: 7482
		private static int HandleId;
	}
}
