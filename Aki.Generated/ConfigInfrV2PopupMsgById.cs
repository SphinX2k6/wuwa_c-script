using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200044F RID: 1103
	public class ConfigInfrV2PopupMsgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019E4 RID: 6628 RVA: 0x000EF79F File Offset: 0x000ED99F
		static ConfigInfrV2PopupMsgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2PopupMsgById.CreateStaticDefaultValue), new Action(ConfigInfrV2PopupMsgById.ResetStaticDefaultValue));
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x000EF7C0 File Offset: 0x000ED9C0
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

		// Token: 0x060019E6 RID: 6630 RVA: 0x000EF83F File Offset: 0x000EDA3F
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2PopupMsgById.LogPair = null;
			ConfigInfrV2PopupMsgById.HandleId = 0;
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x000EF84D File Offset: 0x000EDA4D
		public static void Init()
		{
			ConfigInfrV2PopupMsgById.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2PopupMsgById.HandleId, "db_villageinfr.db", "select BinData from `InfrV2PopupMsg` where Id=?");
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x000EF868 File Offset: 0x000EDA68
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

		// Token: 0x04001E0D RID: 7693
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001E0E RID: 7694
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001E0F RID: 7695
		private const string TABLE = "InfrV2PopupMsg";

		// Token: 0x04001E10 RID: 7696
		private const string COMMAND = "select BinData from `InfrV2PopupMsg` where Id=?";

		// Token: 0x04001E11 RID: 7697
		private const string KEY_PREFIX = "InfrV2PopupMsgById";

		// Token: 0x04001E12 RID: 7698
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E13 RID: 7699
		private static int HandleId;
	}
}
