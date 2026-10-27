using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000439 RID: 1081
	public class ConfigInfrV2PopupMsgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001960 RID: 6496 RVA: 0x000E904B File Offset: 0x000E724B
		static ConfigInfrV2PopupMsgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2PopupMsgById.CreateStaticDefaultValue), new Action(ConfigInfrV2PopupMsgById.ResetStaticDefaultValue));
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x000E906C File Offset: 0x000E726C
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrV2PopupMsgById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrV2PopupMsgById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_villageinfr.db"),
				new ValueTuple<string, object>("文件", "j.基建V2.xlsx"),
				new ValueTuple<string, object>("表名", "InfrV2PopupMsg"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrV2PopupMsg` where Id=?")
			});
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x000E90EB File Offset: 0x000E72EB
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2PopupMsgById.LogPair = null;
			ConfigInfrV2PopupMsgById.HandleId = 0;
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x000E90F9 File Offset: 0x000E72F9
		public static void Init()
		{
			ConfigInfrV2PopupMsgById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2PopupMsgById.HandleId, "db_villageinfr.db", "select BinData from `InfrV2PopupMsg` where Id=?");
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x000E9114 File Offset: 0x000E7314
		public static InfrV2PopupMsg? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrV2PopupMsgById.HandleId, ConfigInfrV2PopupMsgById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2PopupMsgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfrV2PopupMsg?(InfrV2PopupMsg.GetRootAsInfrV2PopupMsg(configBuffer));
				}
			}
			ConfigInfrV2PopupMsgById.LogPair.Clear();
			ConfigInfrV2PopupMsgById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInfrV2PopupMsgById.HandleId, 1, p0Id, ConfigInfrV2PopupMsgById.LogPair) || ConfigCommon.Step(ConfigInfrV2PopupMsgById.HandleId, true, ConfigInfrV2PopupMsgById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfrV2PopupMsgById.HandleId, ConfigInfrV2PopupMsgById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrV2PopupMsgById.HandleId, 0, ConfigInfrV2PopupMsgById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfrV2PopupMsgById.HandleId, ConfigInfrV2PopupMsgById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfrV2PopupMsg rootAsInfrV2PopupMsg = InfrV2PopupMsg.GetRootAsInfrV2PopupMsg(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfrV2PopupMsgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfrV2PopupMsgById.HandleId, ConfigInfrV2PopupMsgById.LogPair);
			return new InfrV2PopupMsg?(rootAsInfrV2PopupMsg);
		}

		// Token: 0x04001D73 RID: 7539
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001D74 RID: 7540
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001D75 RID: 7541
		private const string TABLE = "InfrV2PopupMsg";

		// Token: 0x04001D76 RID: 7542
		private const string COMMAND = "select BinData from `InfrV2PopupMsg` where Id=?";

		// Token: 0x04001D77 RID: 7543
		private const string KEY_PREFIX = "InfrV2PopupMsgById";

		// Token: 0x04001D78 RID: 7544
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D79 RID: 7545
		private static int HandleId;
	}
}
