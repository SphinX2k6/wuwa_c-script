using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000399 RID: 921
	public class ConfigGiantTotalProgressById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600159D RID: 5533 RVA: 0x000D3D63 File Offset: 0x000D1F63
		static ConfigGiantTotalProgressById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantTotalProgressById.CreateStaticDefaultValue), new Action(ConfigGiantTotalProgressById.ResetStaticDefaultValue));
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x000D3D84 File Offset: 0x000D1F84
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

		// Token: 0x0600159F RID: 5535 RVA: 0x000D3E03 File Offset: 0x000D2003
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantTotalProgressById.LogPair = null;
			ConfigGiantTotalProgressById.HandleId = 0;
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x000D3E11 File Offset: 0x000D2011
		public static void Init()
		{
			ConfigGiantTotalProgressById.HandleId = ConfigCommon.InitDataStatement(ConfigGiantTotalProgressById.HandleId, "db_giant.db", "select BinData from `GiantTotalProgress` where Id=?");
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x000D3E2C File Offset: 0x000D202C
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

		// Token: 0x04001913 RID: 6419
		private const string DB = "db_giant.db";

		// Token: 0x04001914 RID: 6420
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x04001915 RID: 6421
		private const string TABLE = "GiantTotalProgress";

		// Token: 0x04001916 RID: 6422
		private const string COMMAND = "select BinData from `GiantTotalProgress` where Id=?";

		// Token: 0x04001917 RID: 6423
		private const string KEY_PREFIX = "GiantTotalProgressById";

		// Token: 0x04001918 RID: 6424
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001919 RID: 6425
		private static int HandleId;
	}
}
