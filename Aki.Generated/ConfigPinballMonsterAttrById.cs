using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000738 RID: 1848
	public class ConfigPinballMonsterAttrById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B60 RID: 11104 RVA: 0x00152043 File Offset: 0x00150243
		static ConfigPinballMonsterAttrById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballMonsterAttrById.CreateStaticDefaultValue), new Action(ConfigPinballMonsterAttrById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x00152064 File Offset: 0x00150264
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

		// Token: 0x06002B62 RID: 11106 RVA: 0x001520E3 File Offset: 0x001502E3
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballMonsterAttrById.LogPair = null;
			ConfigPinballMonsterAttrById.HandleId = 0;
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x001520F1 File Offset: 0x001502F1
		public static void Init()
		{
			ConfigPinballMonsterAttrById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballMonsterAttrById.HandleId, "db_pinballbattle.db", "select BinData from `PinballMonsterAttr` where Id=?");
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x0015210C File Offset: 0x0015030C
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

		// Token: 0x0400326E RID: 12910
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400326F RID: 12911
		private const string FILE = "x.星弹奇游_怪物.xlsx";

		// Token: 0x04003270 RID: 12912
		private const string TABLE = "PinballMonsterAttr";

		// Token: 0x04003271 RID: 12913
		private const string COMMAND = "select BinData from `PinballMonsterAttr` where Id=?";

		// Token: 0x04003272 RID: 12914
		private const string KEY_PREFIX = "PinballMonsterAttrById";

		// Token: 0x04003273 RID: 12915
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003274 RID: 12916
		private static int HandleId;
	}
}
