using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000720 RID: 1824
	public class ConfigPinballMonsterAttrById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AD0 RID: 10960 RVA: 0x0014B5C7 File Offset: 0x001497C7
		static ConfigPinballMonsterAttrById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballMonsterAttrById.CreateStaticDefaultValue), new Action(ConfigPinballMonsterAttrById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x0014B5E8 File Offset: 0x001497E8
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballMonsterAttrById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballMonsterAttrById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "PinballMonsterAttr"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballMonsterAttr` where Id=?")
			});
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x0014B667 File Offset: 0x00149867
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballMonsterAttrById.LogPair = null;
			ConfigPinballMonsterAttrById.HandleId = 0;
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x0014B675 File Offset: 0x00149875
		public static void Init()
		{
			ConfigPinballMonsterAttrById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballMonsterAttrById.HandleId, "db_pinballbattle.db", "select BinData from `PinballMonsterAttr` where Id=?");
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x0014B690 File Offset: 0x00149890
		public static PinballMonsterAttr? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballMonsterAttrById.HandleId, ConfigPinballMonsterAttrById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterAttrById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballMonsterAttr?(PinballMonsterAttr.GetRootAsPinballMonsterAttr(configBuffer));
				}
			}
			ConfigPinballMonsterAttrById.LogPair.Clear();
			ConfigPinballMonsterAttrById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballMonsterAttrById.HandleId, 1, p0Id, ConfigPinballMonsterAttrById.LogPair) || ConfigCommon.Step(ConfigPinballMonsterAttrById.HandleId, true, ConfigPinballMonsterAttrById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballMonsterAttrById.HandleId, ConfigPinballMonsterAttrById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballMonsterAttrById.HandleId, 0, ConfigPinballMonsterAttrById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballMonsterAttrById.HandleId, ConfigPinballMonsterAttrById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballMonsterAttr rootAsPinballMonsterAttr = PinballMonsterAttr.GetRootAsPinballMonsterAttr(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballMonsterAttrById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballMonsterAttrById.HandleId, ConfigPinballMonsterAttrById.LogPair);
			return new PinballMonsterAttr?(rootAsPinballMonsterAttr);
		}

		// Token: 0x040031C6 RID: 12742
		private const string DB = "db_pinballbattle.db";

		// Token: 0x040031C7 RID: 12743
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x040031C8 RID: 12744
		private const string TABLE = "PinballMonsterAttr";

		// Token: 0x040031C9 RID: 12745
		private const string COMMAND = "select BinData from `PinballMonsterAttr` where Id=?";

		// Token: 0x040031CA RID: 12746
		private const string KEY_PREFIX = "PinballMonsterAttrById";

		// Token: 0x040031CB RID: 12747
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040031CC RID: 12748
		private static int HandleId;
	}
}
