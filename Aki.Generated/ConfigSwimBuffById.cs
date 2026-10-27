using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B7 RID: 2487
	public class ConfigSwimBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A5E RID: 14942 RVA: 0x001A3DDB File Offset: 0x001A1FDB
		static ConfigSwimBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSwimBuffById.CreateStaticDefaultValue), new Action(ConfigSwimBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x001A3DFC File Offset: 0x001A1FFC
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

		// Token: 0x06003A60 RID: 14944 RVA: 0x001A3E7B File Offset: 0x001A207B
		public static void ResetStaticDefaultValue()
		{
			ConfigSwimBuffById.LogPair = null;
			ConfigSwimBuffById.HandleId = 0;
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x001A3E89 File Offset: 0x001A2089
		public static void Init()
		{
			ConfigSwimBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigSwimBuffById.HandleId, "db_swim.db", "select BinData from `SwimBuff` where Id=?");
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x001A3EA4 File Offset: 0x001A20A4
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

		// Token: 0x040043E7 RID: 17383
		private const string DB = "db_swim.db";

		// Token: 0x040043E8 RID: 17384
		private const string FILE = "y.游泳.xlsx";

		// Token: 0x040043E9 RID: 17385
		private const string TABLE = "SwimBuff";

		// Token: 0x040043EA RID: 17386
		private const string COMMAND = "select BinData from `SwimBuff` where Id=?";

		// Token: 0x040043EB RID: 17387
		private const string KEY_PREFIX = "SwimBuffById";

		// Token: 0x040043EC RID: 17388
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043ED RID: 17389
		private static int HandleId;
	}
}
