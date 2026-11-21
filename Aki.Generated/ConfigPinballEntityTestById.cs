using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000732 RID: 1842
	public class ConfigPinballEntityTestById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B3C RID: 11068 RVA: 0x00151358 File Offset: 0x0014F558
		static ConfigPinballEntityTestById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballEntityTestById.CreateStaticDefaultValue), new Action(ConfigPinballEntityTestById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x00151378 File Offset: 0x0014F578
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballEntityTestById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballEntityTestById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "PinballEntityTest"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballEntityTest` where Id=?")
			});
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x001513F7 File Offset: 0x0014F5F7
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballEntityTestById.LogPair = null;
			ConfigPinballEntityTestById.HandleId = 0;
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x00151405 File Offset: 0x0014F605
		public static void Init()
		{
			ConfigPinballEntityTestById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballEntityTestById.HandleId, "db_pinballbattle.db", "select BinData from `PinballEntityTest` where Id=?");
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x00151420 File Offset: 0x0014F620
		public static PinballEntityTest? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballEntityTestById.HandleId, ConfigPinballEntityTestById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballEntityTestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballEntityTest?(PinballEntityTest.GetRootAsPinballEntityTest(configBuffer));
				}
			}
			ConfigPinballEntityTestById.LogPair.Clear();
			ConfigPinballEntityTestById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballEntityTestById.HandleId, 1, p0Id, ConfigPinballEntityTestById.LogPair) || ConfigCommon.Step(ConfigPinballEntityTestById.HandleId, true, ConfigPinballEntityTestById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballEntityTestById.HandleId, ConfigPinballEntityTestById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballEntityTestById.HandleId, 0, ConfigPinballEntityTestById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballEntityTestById.HandleId, ConfigPinballEntityTestById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballEntityTest rootAsPinballEntityTest = PinballEntityTest.GetRootAsPinballEntityTest(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballEntityTestById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballEntityTestById.HandleId, ConfigPinballEntityTestById.LogPair);
			return new PinballEntityTest?(rootAsPinballEntityTest);
		}

		// Token: 0x04003244 RID: 12868
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003245 RID: 12869
		private const string FILE = "x.星弹奇游_关卡.xlsx";

		// Token: 0x04003246 RID: 12870
		private const string TABLE = "PinballEntityTest";

		// Token: 0x04003247 RID: 12871
		private const string COMMAND = "select BinData from `PinballEntityTest` where Id=?";

		// Token: 0x04003248 RID: 12872
		private const string KEY_PREFIX = "PinballEntityTestById";

		// Token: 0x04003249 RID: 12873
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400324A RID: 12874
		private static int HandleId;
	}
}
