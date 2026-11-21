using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000380 RID: 896
	public class ConfigGachaAccumulateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001505 RID: 5381 RVA: 0x000D3CD4 File Offset: 0x000D1ED4
		static ConfigGachaAccumulateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaAccumulateById.CreateStaticDefaultValue), new Action(ConfigGachaAccumulateById.ResetStaticDefaultValue));
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x000D3CF4 File Offset: 0x000D1EF4
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaAccumulateById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaAccumulateById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gachaaccumulate.db"),
				new ValueTuple<string, object>("文件", "c.抽卡累抽.xlsx"),
				new ValueTuple<string, object>("表名", "GachaAccumulate"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaAccumulate` where Id=?")
			});
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x000D3D73 File Offset: 0x000D1F73
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaAccumulateById.LogPair = null;
			ConfigGachaAccumulateById.HandleId = 0;
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x000D3D81 File Offset: 0x000D1F81
		public static void Init()
		{
			ConfigGachaAccumulateById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaAccumulateById.HandleId, "db_gachaaccumulate.db", "select BinData from `GachaAccumulate` where Id=?");
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x000D3D9C File Offset: 0x000D1F9C
		public static GachaAccumulate? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaAccumulateById.HandleId, ConfigGachaAccumulateById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaAccumulateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaAccumulate?(GachaAccumulate.GetRootAsGachaAccumulate(configBuffer));
				}
			}
			ConfigGachaAccumulateById.LogPair.Clear();
			ConfigGachaAccumulateById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaAccumulateById.HandleId, 1, p0Id, ConfigGachaAccumulateById.LogPair) || ConfigCommon.Step(ConfigGachaAccumulateById.HandleId, true, ConfigGachaAccumulateById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaAccumulateById.HandleId, ConfigGachaAccumulateById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaAccumulateById.HandleId, 0, ConfigGachaAccumulateById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaAccumulateById.HandleId, ConfigGachaAccumulateById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaAccumulate rootAsGachaAccumulate = GachaAccumulate.GetRootAsGachaAccumulate(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaAccumulateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaAccumulateById.HandleId, ConfigGachaAccumulateById.LogPair);
			return new GachaAccumulate?(rootAsGachaAccumulate);
		}

		// Token: 0x04001864 RID: 6244
		private const string DB = "db_gachaaccumulate.db";

		// Token: 0x04001865 RID: 6245
		private const string FILE = "c.抽卡累抽.xlsx";

		// Token: 0x04001866 RID: 6246
		private const string TABLE = "GachaAccumulate";

		// Token: 0x04001867 RID: 6247
		private const string COMMAND = "select BinData from `GachaAccumulate` where Id=?";

		// Token: 0x04001868 RID: 6248
		private const string KEY_PREFIX = "GachaAccumulateById";

		// Token: 0x04001869 RID: 6249
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400186A RID: 6250
		private static int HandleId;
	}
}
