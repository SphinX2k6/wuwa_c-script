using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003CA RID: 970
	public class ConfigH5JumpActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016C3 RID: 5827 RVA: 0x000DA344 File Offset: 0x000D8544
		static ConfigH5JumpActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigH5JumpActivityById.CreateStaticDefaultValue), new Action(ConfigH5JumpActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000DA364 File Offset: 0x000D8564
		public static void CreateStaticDefaultValue()
		{
			ConfigH5JumpActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigH5JumpActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_h5activity.db"),
				new ValueTuple<string, object>("文件", "h.h5活动.xlsx"),
				new ValueTuple<string, object>("表名", "H5JumpActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `H5JumpActivity` where Id=?")
			});
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000DA3E3 File Offset: 0x000D85E3
		public static void ResetStaticDefaultValue()
		{
			ConfigH5JumpActivityById.LogPair = null;
			ConfigH5JumpActivityById.HandleId = 0;
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x000DA3F1 File Offset: 0x000D85F1
		public static void Init()
		{
			ConfigH5JumpActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigH5JumpActivityById.HandleId, "db_h5activity.db", "select BinData from `H5JumpActivity` where Id=?");
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x000DA40C File Offset: 0x000D860C
		public static H5JumpActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigH5JumpActivityById.HandleId, ConfigH5JumpActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("H5JumpActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new H5JumpActivity?(H5JumpActivity.GetRootAsH5JumpActivity(configBuffer));
				}
			}
			ConfigH5JumpActivityById.LogPair.Clear();
			ConfigH5JumpActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigH5JumpActivityById.HandleId, 1, p0Id, ConfigH5JumpActivityById.LogPair) || ConfigCommon.Step(ConfigH5JumpActivityById.HandleId, true, ConfigH5JumpActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigH5JumpActivityById.HandleId, ConfigH5JumpActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigH5JumpActivityById.HandleId, 0, ConfigH5JumpActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigH5JumpActivityById.HandleId, ConfigH5JumpActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			H5JumpActivity rootAsH5JumpActivity = H5JumpActivity.GetRootAsH5JumpActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("H5JumpActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigH5JumpActivityById.HandleId, ConfigH5JumpActivityById.LogPair);
			return new H5JumpActivity?(rootAsH5JumpActivity);
		}

		// Token: 0x04001A6A RID: 6762
		private const string DB = "db_h5activity.db";

		// Token: 0x04001A6B RID: 6763
		private const string FILE = "h.h5活动.xlsx";

		// Token: 0x04001A6C RID: 6764
		private const string TABLE = "H5JumpActivity";

		// Token: 0x04001A6D RID: 6765
		private const string COMMAND = "select BinData from `H5JumpActivity` where Id=?";

		// Token: 0x04001A6E RID: 6766
		private const string KEY_PREFIX = "H5JumpActivityById";

		// Token: 0x04001A6F RID: 6767
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A70 RID: 6768
		private static int HandleId;
	}
}
