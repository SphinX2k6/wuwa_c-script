using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A8C RID: 2700
	public class ConfigSwimBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F5C RID: 16220 RVA: 0x001C316F File Offset: 0x001C136F
		static ConfigSwimBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSwimBuffById.CreateStaticDefaultValue), new Action(ConfigSwimBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F5D RID: 16221 RVA: 0x001C3190 File Offset: 0x001C1390
		public static void CreateStaticDefaultValue()
		{
			ConfigSwimBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSwimBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_swim.db"),
				new ValueTuple<string, object>("文件", "y.游泳.xlsx"),
				new ValueTuple<string, object>("表名", "SwimBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `SwimBuff` where Id=?")
			});
		}

		// Token: 0x06003F5E RID: 16222 RVA: 0x001C320F File Offset: 0x001C140F
		public static void ResetStaticDefaultValue()
		{
			ConfigSwimBuffById.LogPair = null;
			ConfigSwimBuffById.HandleId = 0;
		}

		// Token: 0x06003F5F RID: 16223 RVA: 0x001C321D File Offset: 0x001C141D
		public static void Init()
		{
			ConfigSwimBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigSwimBuffById.HandleId, "db_swim.db", "select BinData from `SwimBuff` where Id=?");
		}

		// Token: 0x06003F60 RID: 16224 RVA: 0x001C3238 File Offset: 0x001C1438
		public static SwimBuff? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSwimBuffById.HandleId, ConfigSwimBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SwimBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SwimBuff?(SwimBuff.GetRootAsSwimBuff(configBuffer));
				}
			}
			ConfigSwimBuffById.LogPair.Clear();
			ConfigSwimBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSwimBuffById.HandleId, 1, p0Id, ConfigSwimBuffById.LogPair) || ConfigCommon.Step(ConfigSwimBuffById.HandleId, true, ConfigSwimBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSwimBuffById.HandleId, ConfigSwimBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSwimBuffById.HandleId, 0, ConfigSwimBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSwimBuffById.HandleId, ConfigSwimBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SwimBuff rootAsSwimBuff = SwimBuff.GetRootAsSwimBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SwimBuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSwimBuffById.HandleId, ConfigSwimBuffById.LogPair);
			return new SwimBuff?(rootAsSwimBuff);
		}

		// Token: 0x040049BA RID: 18874
		private const string DB = "db_swim.db";

		// Token: 0x040049BB RID: 18875
		private const string FILE = "y.游泳.xlsx";

		// Token: 0x040049BC RID: 18876
		private const string TABLE = "SwimBuff";

		// Token: 0x040049BD RID: 18877
		private const string COMMAND = "select BinData from `SwimBuff` where Id=?";

		// Token: 0x040049BE RID: 18878
		private const string KEY_PREFIX = "SwimBuffById";

		// Token: 0x040049BF RID: 18879
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049C0 RID: 18880
		private static int HandleId;
	}
}
