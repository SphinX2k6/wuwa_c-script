using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000713 RID: 1811
	public class ConfigPinballCreatureById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002A82 RID: 10882 RVA: 0x00149A4B File Offset: 0x00147C4B
		static ConfigPinballCreatureById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballCreatureById.CreateStaticDefaultValue), new Action(ConfigPinballCreatureById.ResetStaticDefaultValue));
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x00149A6C File Offset: 0x00147C6C
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

		// Token: 0x06002A84 RID: 10884 RVA: 0x00149AEB File Offset: 0x00147CEB
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballCreatureById.LogPair = null;
			ConfigPinballCreatureById.HandleId = 0;
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x00149AF9 File Offset: 0x00147CF9
		public static void Init()
		{
			ConfigPinballCreatureById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballCreatureById.HandleId, "db_pinballbattle.db", "select BinData from `PinballCreature` where Id=?");
		}

		// Token: 0x06002A86 RID: 10886 RVA: 0x00149B14 File Offset: 0x00147D14
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

		// Token: 0x0400316B RID: 12651
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400316C RID: 12652
		private const string FILE = "x.星弹奇游_局内.xlsx";

		// Token: 0x0400316D RID: 12653
		private const string TABLE = "PinballCreature";

		// Token: 0x0400316E RID: 12654
		private const string COMMAND = "select BinData from `PinballCreature` where Id=?";

		// Token: 0x0400316F RID: 12655
		private const string KEY_PREFIX = "PinballCreatureById";

		// Token: 0x04003170 RID: 12656
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003171 RID: 12657
		private static int HandleId;
	}
}
