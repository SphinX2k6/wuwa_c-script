using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000392 RID: 914
	public class ConfigGiantEntrustById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001572 RID: 5490 RVA: 0x000D2D6B File Offset: 0x000D0F6B
		static ConfigGiantEntrustById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantEntrustById.CreateStaticDefaultValue), new Action(ConfigGiantEntrustById.ResetStaticDefaultValue));
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x000D2D8C File Offset: 0x000D0F8C
		public static void CreateStaticDefaultValue()
		{
			ConfigGiantEntrustById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiantEntrustById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giant.db"),
				new ValueTuple<string, object>("文件", "j.巨人信物.xlsx"),
				new ValueTuple<string, object>("表名", "GiantEntrust"),
				new ValueTuple<string, object>("语句", "select BinData from `GiantEntrust` where Id=?")
			});
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x000D2E0B File Offset: 0x000D100B
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantEntrustById.LogPair = null;
			ConfigGiantEntrustById.HandleId = 0;
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x000D2E19 File Offset: 0x000D1019
		public static void Init()
		{
			ConfigGiantEntrustById.HandleId = ConfigCommon.InitDataStatement(ConfigGiantEntrustById.HandleId, "db_giant.db", "select BinData from `GiantEntrust` where Id=?");
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x000D2E34 File Offset: 0x000D1034
		public static GiantEntrust? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiantEntrustById.HandleId, ConfigGiantEntrustById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantEntrustById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GiantEntrust?(GiantEntrust.GetRootAsGiantEntrust(configBuffer));
				}
			}
			ConfigGiantEntrustById.LogPair.Clear();
			ConfigGiantEntrustById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGiantEntrustById.HandleId, 1, p0Id, ConfigGiantEntrustById.LogPair) || ConfigCommon.Step(ConfigGiantEntrustById.HandleId, true, ConfigGiantEntrustById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGiantEntrustById.HandleId, ConfigGiantEntrustById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiantEntrustById.HandleId, 0, ConfigGiantEntrustById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGiantEntrustById.HandleId, ConfigGiantEntrustById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GiantEntrust rootAsGiantEntrust = GiantEntrust.GetRootAsGiantEntrust(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantEntrustById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGiantEntrustById.HandleId, ConfigGiantEntrustById.LogPair);
			return new GiantEntrust?(rootAsGiantEntrust);
		}

		// Token: 0x040018E2 RID: 6370
		private const string DB = "db_giant.db";

		// Token: 0x040018E3 RID: 6371
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x040018E4 RID: 6372
		private const string TABLE = "GiantEntrust";

		// Token: 0x040018E5 RID: 6373
		private const string COMMAND = "select BinData from `GiantEntrust` where Id=?";

		// Token: 0x040018E6 RID: 6374
		private const string KEY_PREFIX = "GiantEntrustById";

		// Token: 0x040018E7 RID: 6375
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018E8 RID: 6376
		private static int HandleId;
	}
}
