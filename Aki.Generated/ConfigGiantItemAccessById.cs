using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000394 RID: 916
	public class ConfigGiantItemAccessById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600157E RID: 5502 RVA: 0x000D3147 File Offset: 0x000D1347
		static ConfigGiantItemAccessById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantItemAccessById.CreateStaticDefaultValue), new Action(ConfigGiantItemAccessById.ResetStaticDefaultValue));
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x000D3168 File Offset: 0x000D1368
		public static void CreateStaticDefaultValue()
		{
			ConfigGiantItemAccessById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiantItemAccessById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giant.db"),
				new ValueTuple<string, object>("文件", "j.巨人信物.xlsx"),
				new ValueTuple<string, object>("表名", "GiantItemAccess"),
				new ValueTuple<string, object>("语句", "select BinData from `GiantItemAccess` where Id=?")
			});
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x000D31E7 File Offset: 0x000D13E7
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantItemAccessById.LogPair = null;
			ConfigGiantItemAccessById.HandleId = 0;
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x000D31F5 File Offset: 0x000D13F5
		public static void Init()
		{
			ConfigGiantItemAccessById.HandleId = ConfigCommon.InitDataStatement(ConfigGiantItemAccessById.HandleId, "db_giant.db", "select BinData from `GiantItemAccess` where Id=?");
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x000D3210 File Offset: 0x000D1410
		public static GiantItemAccess? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiantItemAccessById.HandleId, ConfigGiantItemAccessById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantItemAccessById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GiantItemAccess?(GiantItemAccess.GetRootAsGiantItemAccess(configBuffer));
				}
			}
			ConfigGiantItemAccessById.LogPair.Clear();
			ConfigGiantItemAccessById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGiantItemAccessById.HandleId, 1, p0Id, ConfigGiantItemAccessById.LogPair) || ConfigCommon.Step(ConfigGiantItemAccessById.HandleId, true, ConfigGiantItemAccessById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGiantItemAccessById.HandleId, ConfigGiantItemAccessById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiantItemAccessById.HandleId, 0, ConfigGiantItemAccessById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGiantItemAccessById.HandleId, ConfigGiantItemAccessById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GiantItemAccess rootAsGiantItemAccess = GiantItemAccess.GetRootAsGiantItemAccess(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantItemAccessById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGiantItemAccessById.HandleId, ConfigGiantItemAccessById.LogPair);
			return new GiantItemAccess?(rootAsGiantItemAccess);
		}

		// Token: 0x040018F0 RID: 6384
		private const string DB = "db_giant.db";

		// Token: 0x040018F1 RID: 6385
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x040018F2 RID: 6386
		private const string TABLE = "GiantItemAccess";

		// Token: 0x040018F3 RID: 6387
		private const string COMMAND = "select BinData from `GiantItemAccess` where Id=?";

		// Token: 0x040018F4 RID: 6388
		private const string KEY_PREFIX = "GiantItemAccessById";

		// Token: 0x040018F5 RID: 6389
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018F6 RID: 6390
		private static int HandleId;
	}
}
