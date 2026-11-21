using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200072B RID: 1835
	public class ConfigPinballCreatureById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B12 RID: 11026 RVA: 0x001504C7 File Offset: 0x0014E6C7
		static ConfigPinballCreatureById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballCreatureById.CreateStaticDefaultValue), new Action(ConfigPinballCreatureById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x001504E8 File Offset: 0x0014E6E8
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballCreatureById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballCreatureById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_局内.xlsx"),
				new ValueTuple<string, object>("表名", "PinballCreature"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballCreature` where Id=?")
			});
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x00150567 File Offset: 0x0014E767
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballCreatureById.LogPair = null;
			ConfigPinballCreatureById.HandleId = 0;
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x00150575 File Offset: 0x0014E775
		public static void Init()
		{
			ConfigPinballCreatureById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballCreatureById.HandleId, "db_pinballbattle.db", "select BinData from `PinballCreature` where Id=?");
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x00150590 File Offset: 0x0014E790
		public static PinballCreature? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballCreatureById.HandleId, ConfigPinballCreatureById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballCreatureById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballCreature?(PinballCreature.GetRootAsPinballCreature(configBuffer));
				}
			}
			ConfigPinballCreatureById.LogPair.Clear();
			ConfigPinballCreatureById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballCreatureById.HandleId, 1, p0Id, ConfigPinballCreatureById.LogPair) || ConfigCommon.Step(ConfigPinballCreatureById.HandleId, true, ConfigPinballCreatureById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballCreatureById.HandleId, ConfigPinballCreatureById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballCreatureById.HandleId, 0, ConfigPinballCreatureById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballCreatureById.HandleId, ConfigPinballCreatureById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballCreature rootAsPinballCreature = PinballCreature.GetRootAsPinballCreature(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballCreatureById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballCreatureById.HandleId, ConfigPinballCreatureById.LogPair);
			return new PinballCreature?(rootAsPinballCreature);
		}

		// Token: 0x04003213 RID: 12819
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003214 RID: 12820
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x04003215 RID: 12821
		private const string TABLE = "PinballCreature";

		// Token: 0x04003216 RID: 12822
		private const string COMMAND = "select BinData from `PinballCreature` where Id=?";

		// Token: 0x04003217 RID: 12823
		private const string KEY_PREFIX = "PinballCreatureById";

		// Token: 0x04003218 RID: 12824
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003219 RID: 12825
		private static int HandleId;
	}
}
