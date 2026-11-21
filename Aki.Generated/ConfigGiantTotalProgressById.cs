using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003AF RID: 943
	public class ConfigGiantTotalProgressById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001621 RID: 5665 RVA: 0x000DA4B7 File Offset: 0x000D86B7
		static ConfigGiantTotalProgressById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantTotalProgressById.CreateStaticDefaultValue), new Action(ConfigGiantTotalProgressById.ResetStaticDefaultValue));
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x000DA4D8 File Offset: 0x000D86D8
		public static void CreateStaticDefaultValue()
		{
			ConfigGiantTotalProgressById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiantTotalProgressById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giant.db"),
				new ValueTuple<string, object>("文件", "j.巨人信物.xlsx"),
				new ValueTuple<string, object>("表名", "GiantTotalProgress"),
				new ValueTuple<string, object>("语句", "select BinData from `GiantTotalProgress` where Id=?")
			});
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x000DA557 File Offset: 0x000D8757
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantTotalProgressById.LogPair = null;
			ConfigGiantTotalProgressById.HandleId = 0;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x000DA565 File Offset: 0x000D8765
		public static void Init()
		{
			ConfigGiantTotalProgressById.HandleId = ConfigCommon.InitDataStatement(ConfigGiantTotalProgressById.HandleId, "db_giant.db", "select BinData from `GiantTotalProgress` where Id=?");
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x000DA580 File Offset: 0x000D8780
		public static GiantTotalProgress? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiantTotalProgressById.HandleId, ConfigGiantTotalProgressById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantTotalProgressById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GiantTotalProgress?(GiantTotalProgress.GetRootAsGiantTotalProgress(configBuffer));
				}
			}
			ConfigGiantTotalProgressById.LogPair.Clear();
			ConfigGiantTotalProgressById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGiantTotalProgressById.HandleId, 1, p0Id, ConfigGiantTotalProgressById.LogPair) || ConfigCommon.Step(ConfigGiantTotalProgressById.HandleId, true, ConfigGiantTotalProgressById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGiantTotalProgressById.HandleId, ConfigGiantTotalProgressById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiantTotalProgressById.HandleId, 0, ConfigGiantTotalProgressById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGiantTotalProgressById.HandleId, ConfigGiantTotalProgressById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GiantTotalProgress rootAsGiantTotalProgress = GiantTotalProgress.GetRootAsGiantTotalProgress(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantTotalProgressById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGiantTotalProgressById.HandleId, ConfigGiantTotalProgressById.LogPair);
			return new GiantTotalProgress?(rootAsGiantTotalProgress);
		}

		// Token: 0x040019AD RID: 6573
		private const string DB = "db_giant.db";

		// Token: 0x040019AE RID: 6574
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x040019AF RID: 6575
		private const string TABLE = "GiantTotalProgress";

		// Token: 0x040019B0 RID: 6576
		private const string COMMAND = "select BinData from `GiantTotalProgress` where Id=?";

		// Token: 0x040019B1 RID: 6577
		private const string KEY_PREFIX = "GiantTotalProgressById";

		// Token: 0x040019B2 RID: 6578
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019B3 RID: 6579
		private static int HandleId;
	}
}
