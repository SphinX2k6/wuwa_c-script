using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D5 RID: 1237
	public class ConfigLifePointEntranceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D09 RID: 7433 RVA: 0x000FD428 File Offset: 0x000FB628
		static ConfigLifePointEntranceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLifePointEntranceById.CreateStaticDefaultValue), new Action(ConfigLifePointEntranceById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x000FD448 File Offset: 0x000FB648
		public static void CreateStaticDefaultValue()
		{
			ConfigLifePointEntranceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLifePointEntranceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lifepoint.db"),
				new ValueTuple<string, object>("文件", "y.溢彩画.xlsx"),
				new ValueTuple<string, object>("表名", "LifePointEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `LifePointEntrance` where Id=?")
			});
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x000FD4C7 File Offset: 0x000FB6C7
		public static void ResetStaticDefaultValue()
		{
			ConfigLifePointEntranceById.LogPair = null;
			ConfigLifePointEntranceById.HandleId = 0;
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x000FD4D5 File Offset: 0x000FB6D5
		public static void Init()
		{
			ConfigLifePointEntranceById.HandleId = ConfigCommon.InitDataStatement(ConfigLifePointEntranceById.HandleId, "db_lifepoint.db", "select BinData from `LifePointEntrance` where Id=?");
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x000FD4F0 File Offset: 0x000FB6F0
		public static LifePointEntrance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLifePointEntranceById.HandleId, ConfigLifePointEntranceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LifePointEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LifePointEntrance?(LifePointEntrance.GetRootAsLifePointEntrance(configBuffer));
				}
			}
			ConfigLifePointEntranceById.LogPair.Clear();
			ConfigLifePointEntranceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLifePointEntranceById.HandleId, 1, p0Id, ConfigLifePointEntranceById.LogPair) || ConfigCommon.Step(ConfigLifePointEntranceById.HandleId, true, ConfigLifePointEntranceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLifePointEntranceById.HandleId, ConfigLifePointEntranceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLifePointEntranceById.HandleId, 0, ConfigLifePointEntranceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLifePointEntranceById.HandleId, ConfigLifePointEntranceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LifePointEntrance rootAsLifePointEntrance = LifePointEntrance.GetRootAsLifePointEntrance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LifePointEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLifePointEntranceById.HandleId, ConfigLifePointEntranceById.LogPair);
			return new LifePointEntrance?(rootAsLifePointEntrance);
		}

		// Token: 0x040021B7 RID: 8631
		private const string DB = "db_lifepoint.db";

		// Token: 0x040021B8 RID: 8632
		private const string FILE = "y.溢彩画.xlsx";

		// Token: 0x040021B9 RID: 8633
		private const string TABLE = "LifePointEntrance";

		// Token: 0x040021BA RID: 8634
		private const string COMMAND = "select BinData from `LifePointEntrance` where Id=?";

		// Token: 0x040021BB RID: 8635
		private const string KEY_PREFIX = "LifePointEntranceById";

		// Token: 0x040021BC RID: 8636
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021BD RID: 8637
		private static int HandleId;
	}
}
